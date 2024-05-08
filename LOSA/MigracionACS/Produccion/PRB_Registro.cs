using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ACS.Classes;
using LOSA.MigracionACS.DataSetx;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using LOSA.Clases;
using LOSA.MigracionACS.Produccion.Eficiencia;
using System.Globalization;

namespace LOSA.MigracionACS.Produccion
{
    public partial class PRB_Registro : DevExpress.XtraEditors.XtraForm
    {
        string UsuarioLog;
        string codigoUss;
        int SelectedId;
        int Varid;
        int gruopp;
        int Pellet1VarIdDetalle;
        int Pellet2VarIdDetalle;
        int ExtruderVarIdDetalle;
        bool Jefe;
        
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogeado;
        public bool CerrarForm;
        public PRB_Registro(string codigoUss, int group, UserLogin pUser)
        {
            this.gruopp = group;
            Jefe = false;
            UsuarioLogeado = pUser;
            this.codigoUss = codigoUss;
            dp = new DataOperations();
            

            InitializeComponent();
            
        }


        private void ValidatePermisos()
        {
            bool AccesoPrevio = false;
            if (UsuarioLogeado.ValidarNivelPermisos(31))
            {
                btnNew.Enabled = true;
                AccesoPrevio = true;
            }

            //Validar si cuenta con un permiso temporal para acceder
            if (UsuarioLogeado.ValidarNivelPermisosTemporal(31))
            {
                btnNew.Enabled = true;
                AccesoPrevio = true;
            }

            //Si no se consiguio acceso previo vamos a validar niveles permanentes
            if (!AccesoPrevio)
            {
                int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.Id, 7);//7=ALOSY, 9=AMS
                switch (idNivel)
                {
                    case 1://Basic View
                    case 2://Basic No Autorization
                        btnNew.Enabled = false;
                        AccesoPrevio = true;
                        break;
                    case 3://Medium Autorization
                    case 4://Depth With Delta
                    case 5://Depth Without Delta
                        AccesoPrevio = true;
                        break;
                    default:
                        break;
                }
            }

            if (!AccesoPrevio)
            {
                CerrarForm = true;
                CajaDialogo.Error("No tiene privilegios para esta función! El permiso requerido es #31");
            }
            else
            {
                load_dataCausas();
                LoadPresentacionSacos();
                LoadMotivosParos();
                LoadTipoReproceso();

                //barStaticItem5.Caption = DateTime.Now.ToString("dddd MMMMM yyyy HH:mm:ss");
                //timer1.Interval = 1000;
                //timer1.Start();


                if (gruopp == 1)
                {
                    btnNew.Enabled = true;
                    //btnNuevoDescrip.Enabled = true;
                    //btncausas.Enabled = true;
                    load_H();
                    load_advanceJefe();
                    //load_advance();
                    this.Text = "Registro de Trabajo - (Produccion)";
                }
                if (gruopp == 2)
                {
                    load_advanceJefe();
                    //load_advance();
                    this.Text = "Registro de Trabajo - (Logistica)";
                }
                if (gruopp == 3)
                {
                    load_advanceJefe();
                    //load_advance();

                    this.Text = "Registro de Trabajo - (Calidad)";
                }
                if (gruopp == 4)
                {
                    btnNew.Enabled = true;
                    //btnNuevoDescrip.Enabled = true;
                    //btncausas.Enabled = true;
                    load_advanceJefe();
                    //load_advance();
                    this.Text = "Registro de Trabajo - (Desarrollo)";
                }

                var tt = new ToolTip();
                //tt.SetToolTip(btnNuevoDescrip, "Al cambiar de lote se agrega un registro.");

                if (UsuarioLogeado.ValidarNivelPermisos(61))
                {
                    //cmdEditar2.Visible = true;
                    dtFechaDesde.Visible = dtFechaHasta.Visible = cmdCargarDatosJefe2.Visible = true;
                    Jefe = true;
                }
                else
                {
                    //CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #60");
                    dtFechaDesde.Visible = dtFechaHasta.Visible = cmdCargarDatosJefe2.Visible = true;
                    //cmdEditar2.Visible = false;
                    Jefe = false;
                }
            }
        }



        private void LoadRendimiento()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_detalle_eficiencia_prd", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idh", Varid);
                cmd.Parameters.AddWithValue("@idlinea", radioGroupLineas.EditValue);
                pRBdata1.rendimiento.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(pRBdata1.rendimiento);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        public string UsuarioLog1 { get => UsuarioLog; set => UsuarioLog = value; }
        public string CodigoUss { get => codigoUss; set => codigoUss = value; }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //barStaticItem5.Caption = DateTime.Now.ToString("dddd MMMM yyyy HH:mm:ss");
            

        }


        private void LoadTipoReproceso()
        {
            try
            {
                string query = @"SELECT [id]
                                      ,[descripcion]
                                  FROM [dbo].[PRB_Registro_tipo_Reproceso]
                                  where id_linea = @idlinea
	                                    and enable = 1";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@idlinea", radioGroupLineas.EditValue);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                pRBdata1.tipo_reproceso.Clear();
                da.Fill(pRBdata1.tipo_reproceso);
                cn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadMotivosParos()
        {
            try
            {
                string query = @"sp_get_lista_causas_tipo_paro_PRB";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                pRBdata1.tipo_causa.Clear();
                da.Fill(pRBdata1.tipo_causa);
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadPresentacionSacos()
        {
            try
            {
                string query = @"sp_get_persentacions_from_prb_reporte";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                pRBdata1.presentacion_sacos.Clear();
                da.Fill(pRBdata1.presentacion_sacos);
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);

            }
        }

        private void PRB_Registro_Load(object sender, EventArgs e)
        {
            
        }

        public decimal LoadHorasMaquina(int pIdRegistro, int pIdMaquina)
        {
            decimal val = 0;
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                string sql = @"SELECT [cant]
                                FROM [dbo].[EQ_Maquinas_Horas_Periodo]
                                where acs_id_registro_detalle = "+ pIdRegistro + 
                                   " and id_maquina = " + pIdMaquina;
                SqlCommand cmd = new SqlCommand(sql, cn);
                val = Convert.ToDecimal(cmd.ExecuteScalar());
                cn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return val;
        }

        public void load_H()
        {
            try
            {

                string query = @"SELECT a.[id]
                                ,a.[fecha_ini]
                                ,a.[horas_dis]
                                ,a.[estatus]
                                ,a.[fecha_fin]
                                ,a.[enable]
                                ,a.[comentario]
								,b.descripcion
                                ,Case when a.estatus = 10 then 'Activo'
                                when a.estatus = 50 then 'Proceso'
                                else 'Cerrado' end as Activa
                            FROM dbo.[PRB_Registro_H] a join
							[dbo].PRB_Turno b on
							a.idturno = b.id
                            where a.enable = 1 and a.estatus = 10 or a.estatus = 50 and [user_code] = " + codigoUss + @"
                            and SYSDATETIME()  >= DATEADD(DAY,-3,a.fecha_ini) and SYSDATETIME() <=  DATEADD(DAY,3,a.fecha_ini)
                            order by 1 desc";

                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                pRBdata1.PRB_Registro.Clear();
                da.Fill(pRBdata1.PRB_Registro);
                pRBdata1.PRB_Detalle.Clear();

                //for (int i = 0; i < grdcreate.ViewCollection[0].RowCount; i++)
                //{
                //    DataRow row = (DataRow)grdcreate.ViewCollection[0].GetRow(i);
                //    row["h_pelle1"] = LoadHorasMaquina(Convert.ToInt32(row["id"]),1);
                //    row["h_pelle2"] = LoadHorasMaquina(Convert.ToInt32(row["id"]), 2);
                //    row["h_extruder"] = LoadHorasMaquina(Convert.ToInt32(row["id"]), 3);
                //}
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            

        }
        public void load_advance()
        {
            try
            {
                string query = @"SELECT a.[id]
                                ,a.[fecha_ini]
                                ,a.[horas_dis]
                                ,a.[estatus]
                                ,a.[fecha_fin]
                                ,a.[enable]
                                ,a.[comentario]
								,b.descripcion
                                ,Case when a.estatus = 10 then 'Activo'
                                when a.estatus = 50 then 'Proceso'
                                else 'Terminado' end as Activa
                                ,(SELECT top 1 [cant]
                                  FROM [AQFSVR008\AQFSVR008].[APMS].[dbo].[EQ_Maquinas_Horas_Periodo] dd
                                  where acs_id_registro_detalle = a.id
                                        and id_maquina = 1 order by dd.id desc) as h_pelle1
                                ,(SELECT top 1 [cant]
                                  FROM [AQFSVR008\AQFSVR008].[APMS].[dbo].[EQ_Maquinas_Horas_Periodo] dd
                                  where acs_id_registro_detalle = a.id
                                        and id_maquina = 2 order by dd.id desc) as h_pelle2
                                ,(SELECT top 1 [cant]
                                  FROM [AQFSVR008\AQFSVR008].[APMS].[dbo].[EQ_Maquinas_Horas_Periodo] dd
                                  where acs_id_registro_detalle = a.id
                                        and id_maquina = 3 order by dd.id desc) as h_extruder
                            FROM dbo.[PRB_Registro_H] a join
							[dbo].PRB_Turno b on
							a.idturno = b.id
                            where a.enable = 1 
                                  and a.estatus = 10 or 
                                  a.estatus = 50 or 
                                  a.estatus = 70 and SYSDATETIME()  >= DATEADD(DAY,-3,a.fecha_ini) 
                                  and SYSDATETIME() <=  DATEADD(DAY,3,a.fecha_ini) order by 1 desc";        //[AQFSVR008\WINCC].

                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                pRBdata1.PRB_Registro.Clear();
                da.Fill(pRBdata1.PRB_Registro);
                pRBdata1.PRB_Detalle.Clear();
                cn.Close();

                //int a = gridView2.RowCount;// gridView1.RowCount;// gridView2.RowCount;
                //for (int i = 0; i < grdcreate.ViewCollection[0].RowCount; i++)
                //{
                //    DataRow row = (DataRow)grdcreate.ViewCollection[0].GetRow(i);
                    //row["h_pelle1"] = LoadHorasMaquina(Convert.ToInt32(row["id"]), 1);
                //    row["h_pelle2"] = LoadHorasMaquina(Convert.ToInt32(row["id"]), 2);
                //    row["h_extruder"] = LoadHorasMaquina(Convert.ToInt32(row["id"]), 3);
                //}
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
      

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                pRBdata1.PRB_Detalle.Clear();
                var GridView = (GridView)grdcreate.FocusedView;
                var row = (PRBdata.PRB_RegistroRow)GridView.GetFocusedDataRow();
                if (row != null)
                {
                    Varid = row.id;

                    load_details();
                }
            }
            catch (Exception ec)
            {
                throw new Exception(ec.Message);
            }
           


        }
        public void load_details()
        {
            /*try
            {
                string Query;
                Query = @"SELECT    a.[id]
                                    ,a.[id_h]
                                    ,a.idMaqui
                                    ,coalesce(a.[mix1],0) as mix1
                                    ,coalesce(a.[mix2],0) as mix2
                                    ,coalesce(a.[reproceso],0) as reproceso
                                    ,coalesce(a.[lote],0) as lote
                                    ,coalesce(a.[bag_prod],0) as bag_prod
                                    ,coalesce(a.[bag_conf],0) as bag_conf
                                    ,coalesce(a.[prod_noconf],0) as prod_noconf
                                    ,coalesce(a.[prod_arran],0) as [prod_arran]
                                    ,coalesce(a.[flushing],0) as [flushing]
                                    ,coalesce(a.[humedad],0) as [humedad]
                                    ,coalesce(a.[Ton_produc],0) as [Ton_produc]
                                    ,coalesce(a.[rendimiento],0) as [rendimiento]
                                    ,coalesce(a.[horasMa],0) as horasMa
                                    ,coalesce(b.name,' Desconocido') as name
                                    ,coalesce(a.[enable],0) as enable
		                            ,case when a.formulacode is null then 
									Coalesce((Select Coalesce(RR.formula_code,0) from ACS.dbo.PT_Productos RR where RR.Codigo = a.codigopt),0)
									 else Coalesce(a.formulacode,0 ) end as formulacode
                                   ,coalesce(a.idapms,0) as NumerodeOrden
                                   ,a.idMaqui as id_linea
                                FROM [dbo].[PRB_Registro_D] a left join
	                            ACS.dbo.PP_Production_Lines b on
	                            a.idMaqui = b.id
                                where id_h = " + Varid + @" and enable = 1 order by 1 desc";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                //SqlDataAdapter da = new SqlDataAdapter(cmd);
                //pRBdata.PRB_Detalle.Clear();
                //da.Fill(pRBdata.PRB_Detalle);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    int idMaquina = 0;// dr.getin
                    int iddetalle = 0;
                    if (!dr.IsDBNull(dr.GetOrdinal("id")))
                        idMaquina = dr.GetInt32(2);

                    if (!dr.IsDBNull(dr.GetOrdinal("idMaqui")))
                        iddetalle = dr.GetInt32(0);

                    switch (idMaquina)
                    {
                        case 1://Pellet 1
                            Pellet1VarIdDetalle = iddetalle;
                            break;
                        case 2://Pellet 2
                            Pellet2VarIdDetalle = iddetalle;
                            break;
                        case 3:
                            ExtruderVarIdDetalle = iddetalle;
                            break;//extruder
                    }
                }
                dr.Close();

                cn.Close();

            }
            catch (Exception)
            {


            }*/
            int _idLinea = Convert.ToInt32(radioGroupLineas.EditValue);
            LoadTipoReproceso();
            LoadDetalleParos_(Varid, _idLinea);
            LoadReproceso(Varid, _idLinea);
            LoadDetalleLinea(Varid, _idLinea);
            LoadRendimiento();
        }

        private void grdcreate_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevoDescrip_Click(object sender, EventArgs e)
        {
            //Validar si ya se ingresaron los rangos de horas.
            var gridView = (GridView)grdcreate.FocusedView;
            var row = (DataSetx.PRBdata.PRB_RegistroRow)gridView.GetFocusedDataRow();

            if (PermiteAgregarDetalle(row.id))
            {
                
                PRB_New_Details pRB_New_Details = new PRB_New_Details(row.id, PRB_New_Details.TipoOperacion.Nuevo,0,0);

                if (pRB_New_Details.ShowDialog() == DialogResult.Yes)//
                {
                    load_details();
                }
            }
            else
            {
                CajaDialogo.Error("Debe ingresar las horas de trabajo antes de ingresar la Produccion!");
                return;
            }
            load_details();
        }

        private bool PermiteAgregarDetalle(int pIdR)
        {
            bool Permitir = false;
            try
            {
                var GridView = (GridView)grdedit.FocusedView;
                var row = (PRBdata.PRB_DetalleRow)GridView.GetFocusedDataRow();
                string query = @"sp_get_permitir_agregar_produccion_prb";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", pIdR);
                Permitir = Convert.ToBoolean(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return Permitir;
        }

        private void rebtninsert_Click(object sender, EventArgs e)
        {
            var GridView = (GridView)grdedit.FocusedView;
            var row = (PRBdata.PRB_DetalleRow)GridView.GetFocusedDataRow();
            if (gruopp == 1)//produccion
            {
                PRB_New_Details pRB_New_Details = new PRB_New_Details(Varid, row.id);
                if (pRB_New_Details.ShowDialog() == DialogResult.Yes)
                {
                    load_details();
                }
            }
            else
            {
                if (gruopp == 3)//calidadx
                {
                    PRB_Calidad calidad = new PRB_Calidad(row.id, Varid);
                    if (calidad.ShowDialog()==DialogResult.Yes)
                    {
                        load_details();
                        load_advance();
                    }
                }
                else // logistica 
                {
                    if (gruopp == 2)
                    {
                        PRB_Logistic logistic = new PRB_Logistic(row.id, Varid);
                        if (logistic.ShowDialog() == DialogResult.Yes)
                        {
                            load_details();
                            load_advance();
                        }

                    }
                }
                if (gruopp == 4)
                {
                    PRB_New_Details pRB_New_Details = new PRB_New_Details(Varid, row.id);
                    if (pRB_New_Details.ShowDialog() == DialogResult.Yes)
                    {
                        load_details();
                        load_advance();
                    }
                }
            }
        }

        private void btncausas_Click(object sender, EventArgs e)
        {
            //PRB_Causes causes = new PRB_Causes(SelectedId);
            //causes.Show();
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                var GridView = (GridView)grdedit.FocusedView;
                var row = (PRBdata.PRB_DetalleRow)GridView.GetFocusedDataRow();
                SelectedId = row.id;
            }
            catch (Exception)
            {
            }

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            if (gruopp == 1 || gruopp == 2)
            {

            }
            var GridView = (GridView)grdcreate.FocusedView;
            var row = (PRBdata.PRB_RegistroRow)GridView.GetFocusedDataRow();
            SelectedId = row.id;

            if (row.estatus == 70)
            {
                return;
            }

            if (MessageBox.Show("Se va terminar el proceso, \n Los datos deben estar completos para continuar","Cerrar turno",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                foreach (DataRow rows in pRBdata1.PRB_Detalle.Rows)
                {
                    
                    if (rows[2].ToString() == "")
                    {
                        MessageBox.Show("Mix1 Faltante en uno de los registros");
                        return;
                    }

                    if (rows[3].ToString() == "")
                    {
                        MessageBox.Show("Mix2 Faltante en uno de los registros");
                        return;
                    }

                    if (rows[4].ToString() == "")
                    {
                        MessageBox.Show("Reproceso Faltante en uno de los registros");
                        return;
                    }

                    if (rows[5].ToString() == "")
                    {
                        MessageBox.Show("Lote Faltante en uno de los registros");
                        return;
                    }

                    if (rows[6].ToString() == "")
                    {
                        MessageBox.Show("Sacos producidos Faltante en uno de los registros");
                        return;
                    }

                    if (rows[7].ToString() == "")
                    {
                        MessageBox.Show("Sacos Conformes faltantes en uno de los registros");
                        return;
                    }

                    if (rows[8].ToString() == "")
                    {
                        MessageBox.Show("Sacos no conformes Faltante en uno de los registros");
                        return;
                    }

                    if (rows[9].ToString() == "")
                    {
                        MessageBox.Show("Producto de arranque Faltante en uno de los registros");
                        return;
                    }

                    if (rows[10].ToString() == "")
                    {
                        MessageBox.Show("Flushing Faltante en uno de los registros");
                        return;
                    }

                    if (rows[11].ToString() == "")
                    {
                        MessageBox.Show("Humedad Faltante en uno de los registros");
                        return;
                    }

                    if (rows[12].ToString() == "")
                    {
                        MessageBox.Show("Toneladas producidas Faltante en uno de los registros");
                        return;
                    }

                    //if (rows[13].ToString() == "")
                    //{
                    //    MessageBox.Show("rendimiento Faltante en uno de los registros");
                    //    return;
                    //}

                    if (rows[14].ToString() == "")
                    {
                        MessageBox.Show("horas maquina Faltante en uno de los registros");
                        return;
                    }
                    
                    
                }

                string query;
                query = @"UPDATE [dbo].[PRB_Registro_H]
                                   SET 
                                      [estatus] = 70
                                      WHERE id = " + Varid;
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.ExecuteNonQuery();
                if (gruopp == 1)
                {
                    load_H();
                }
                else
                {
                    load_advance();
                }
            }
           
        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            var GridView = (GridView)grdcreate.FocusedView;
            var row = (PRBdata.PRB_RegistroRow)GridView.GetFocusedDataRow();

            PRB_Report_v2 cp = new PRB_Report_v2(row.id);
                cp.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                ReportPrintTool printReport = new ReportPrintTool(cp);
                printReport.ShowPreview();
            
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea eliminar la informacion de este registro.", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                try
                {
                    var GridView = (GridView)grdedit.FocusedView;
                    var row = (PRBdata.PRB_DetalleRow)GridView.GetFocusedDataRow();
                    string query = @"UPDATE [dbo].[PRB_Registro_D]
                                       SET [enable] = 0
                                     WHERE id =" + row.id;
                    SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    load_details();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnNuevoDescrip_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridViewx = (GridView)grdcreate.FocusedView;
            var row1 = (PRBdata.PRB_RegistroRow)gridViewx.GetFocusedDataRow();

            //Seleccionar las horas de los periodos activos.
            frmHorasPorPeriodioMaquinas frm = new frmHorasPorPeriodioMaquinas(row1.fecha_ini, row1.fecha_fin);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                //var gridView1 = (GridView)grdcreate.FocusedView;
                var gridView = (GridView)grdcreate.FocusedView;
                
                DataRow row = gridView1.GetDataRow(gridView.FocusedRowHandle);
                int id_registro = Convert.ToInt32(row["id"]);
                if (frm.Horas1 > 0)
                {
                    row["h_pelle1"] = frm.Horas1;
                    UpdatePeriodo(1, id_registro, frm.Horas1, frm.Id1);
                }

                if (frm.Horas2 > 0)
                {
                    row["h_pelle2"] = frm.Horas2;
                    UpdatePeriodo(2, id_registro, frm.Horas2, frm.Id2);
                }

                if (frm.Horas3 > 0)
                {
                    row["h_extruder"] = frm.Horas3;
                    UpdatePeriodo(3, id_registro, frm.Horas3, frm.Id3);
                }

                
                
                
                


            }
        }


        private void UpdatePeriodo(int pIdMaquina, int pIdRegistro, decimal pHoras, int pIdPeriodo)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringAPMS);
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_update_id_registro_horas_maquina", con);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", pIdPeriodo);
                cmd.Parameters.AddWithValue("@id_acs_registro_detalle", pIdRegistro);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            if (gruopp == 1 || gruopp == 2)
            {

            }
            else
            {
                try
                {
                    var GridView = (GridView)grdcreate.FocusedView;
                    var row = (PRBdata.PRB_RegistroRow)GridView.GetFocusedDataRow();
                    if (MessageBox.Show("Desea eliminar este registro?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string query = @"UPDATE [dbo].[PRB_Registro_H]
                                        SET [enable] = 0
                                            ,estatus = 10
                                        WHERE id = @ID";
                        SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                        cn.Open();
                        SqlCommand cmd = new SqlCommand(query, cn);
                        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = row.id;
                        cmd.ExecuteNonQuery();
                        load_advance();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnNuevoDescrip_EditValueChanged_1(object sender, EventArgs e)
        {

        }

        private void cmdEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Validar si ya se ingresaron los rangos de horas.
            var gridView = (GridView)grdedit.FocusedView;
            var row = (DataSetx.PRBdata.PRB_DetalleRow)gridView.GetFocusedDataRow();

            if (PermiteAgregarDetalle(row.id_h))
            {

                PRB_New_Details pRB_New_Details = new PRB_New_Details(row.id_h, PRB_New_Details.TipoOperacion.Edit, row.id_linea, row.id);
                if (pRB_New_Details.ShowDialog() == DialogResult.Yes)//
                {
                    load_details();
                }
            }
            else
            {
                CajaDialogo.Error("Debe ingresar las horas de trabajo antes de ingresar la Produccion!");
                return;
            }
        }

        private void cmdEditar_Click(object sender, EventArgs e)
        {
            //Validar si ya se ingresaron los rangos de horas.
            var gridView = (GridView)grdedit.FocusedView;
            var row = (DataSetx.PRBdata.PRB_DetalleRow)gridView.GetFocusedDataRow();

            if (PermiteAgregarDetalle(row.id_h))
            {

                PRB_New_Details pRB_New_Details = new PRB_New_Details(row.id_h, PRB_New_Details.TipoOperacion.Edit, row.id_linea, row.id);
                if (pRB_New_Details.ShowDialog() == DialogResult.Yes)//
                {
                    load_details();
                }
            }
            else
            {
                CajaDialogo.Error("Debe ingresar las horas de trabajo antes de ingresar la Produccion!");
                return;
            }
        }

        private void btncausas_Click_1(object sender, EventArgs e)
        {
            //Validar si ya se ingresaron los rangos de horas.
            //var gridView = (GridView)grdedit.FocusedView;
            //var row = (ACS.DataSetx.PRBdata.PRB_DetalleRow)gridView.GetFocusedDataRow();

            
            int idlinea = 0;
            int idDetalle_x = 0;
            switch (radioGroupLineas.EditValue)
            {
                case 1:
                    idlinea = 1;
                    idDetalle_x = Pellet1VarIdDetalle;
                    break;
                case 2:
                    idlinea = 2;
                    idDetalle_x = Pellet2VarIdDetalle;
                    break;
                case 3:
                    idlinea = 3;
                    idDetalle_x = ExtruderVarIdDetalle;
                    break;
            }

            PRB_New_Details pRB_New_Details = new PRB_New_Details(Varid, PRB_New_Details.TipoOperacion.Edit, idlinea, ExtruderVarIdDetalle);
            if (pRB_New_Details.ShowDialog() == DialogResult.Yes)//
            {
                load_details();
            }
        }

        public void load_dataCausas()
        {
            try
            {
                string Query;
                Query = @"Select id
                            ,causa
                            ,descripcion
                    From [dbo].[PRB_Causa]
                    where enable = 1";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                pRBdata1.causas.Clear();
                da.Fill(pRBdata1.causas);
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }

        private void LoadDetalleParos_(int varid, int vIdLinea)
        {
            try
            {
                string query = @"[sp_get_lista_transaccion_causas_tipo_paro_PRB]";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idreg", Varid);
                cmd.Parameters.AddWithValue("@linea", vIdLinea);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                pRBdata1.causas_transact.Clear();
                da.Fill(pRBdata1.causas_transact);
                //SumHoras();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
        private void LoadReproceso(int idh, int idLinea)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_detalle_reproceso_registro_prb_h", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idh", idh);
                cmd.Parameters.AddWithValue("@idlinea", idLinea);
                pRBdata1.reproceso.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(pRBdata1.reproceso);

                con.Close();

            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void radioGroupLineas_EditValueChanged(object sender, EventArgs e)
        {
            int _idLinea = Convert.ToInt32(radioGroupLineas.EditValue);
            LoadTipoReproceso();
            LoadDetalleParos_(Varid, _idLinea);
            LoadReproceso(Varid, _idLinea);
            LoadDetalleLinea(Varid, _idLinea);
            LoadRendimiento();
        }

        private void LoadDetalleLinea(int varid, int idLinea)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_detalles_linea_prb_reporte_v2", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idh", varid);
                cmd.Parameters.AddWithValue("@idlinea", idLinea);
                pRBdata1.data_resumen.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(pRBdata1.data_resumen);

                con.Close();

            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdNew_Click(object sender, EventArgs e)
        {
            //Validar si ya se ingresaron los rangos de horas.
            var gridView = (GridView)grdcreate.FocusedView;
            var row = (DataSetx.PRBdata.PRB_RegistroRow)gridView.GetFocusedDataRow();

            if (PermiteAgregarDetalle(row.id))
            {

                PRB_New_Details pRB_New_Details = new PRB_New_Details(row.id, PRB_New_Details.TipoOperacion.Nuevo, 0, 0);

                if (pRB_New_Details.ShowDialog() == DialogResult.Yes)//
                {
                    load_details();
                }
            }
            else
            {
                CajaDialogo.Error("Debe ingresar las horas de trabajo antes de ingresar la Produccion!");
                return;
            }
            load_details();
        }

        private void cmdEditar_Click_1(object sender, EventArgs e)
        {
            int idlinea = 0;
            int idDetalle_x = 0;
            switch (radioGroupLineas.EditValue)
            {
                case 1:
                    idlinea = 1;
                    idDetalle_x = Pellet1VarIdDetalle;
                    break;
                case 2:
                    idlinea = 2;
                    idDetalle_x = Pellet2VarIdDetalle;
                    break;
                case 3:
                    idlinea = 3;
                    idDetalle_x = ExtruderVarIdDetalle;
                    break;
            }

            PRB_New_Details pRB_New_Details = new PRB_New_Details(Varid, PRB_New_Details.TipoOperacion.Edit, idlinea, ExtruderVarIdDetalle);
            if (Jefe)
            {
                pRB_New_Details.Jefe = true;
                pRB_New_Details.Jefe_Fdesde = Convert.ToDateTime(dtFechaDesde.EditValue);
                pRB_New_Details.Jefe_Fhasta = Convert.ToDateTime(dtFechaHasta.EditValue);
            }

            if (pRB_New_Details.ShowDialog() == DialogResult.Yes)//
            {
                load_details();
            }
        }

        private void btnImprimirRpt_Click(object sender, EventArgs e)
        {
            int idlinea = 0;
            int idDetalle_x = 0;
            switch (radioGroupLineas.EditValue)
            {
                case 1:
                    idlinea = 1;
                    idDetalle_x = Pellet1VarIdDetalle;
                    break;
                case 2:
                    idlinea = 2;
                    idDetalle_x = Pellet2VarIdDetalle;
                    break;
                case 3:
                    idlinea = 3;
                    idDetalle_x = ExtruderVarIdDetalle;
                    break;
            }
            rpt_reporte_produccion cp = new rpt_reporte_produccion(Varid,idlinea);
            cp.PrintingSystem.Document.AutoFitToPagesWidth = 1;
            ReportPrintTool printReport = new ReportPrintTool(cp);
            printReport.ShowPreview();
        }

        public void load_advanceJefe()
        {
            try
            {
                string query = @"sp_get_avance_prd_registro_jefe";

                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fechai", dtFechaDesde.DateTime);
                cmd.Parameters.AddWithValue("@fechaf", dtFechaHasta.DateTime);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                pRBdata1.PRB_Registro.Clear();
                da.Fill(pRBdata1.PRB_Registro);
                pRBdata1.PRB_Detalle.Clear();
                cn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//End Load Avance Jefe

        private void cmdEditar2_Click(object sender, EventArgs e)
        {
            int idlinea = 0;
            int idDetalle_x = 0;
            switch (radioGroupLineas.EditValue)
            {
                case 1:
                    idlinea = 1;
                    idDetalle_x = Pellet1VarIdDetalle;
                    break;
                case 2:
                    idlinea = 2;
                    idDetalle_x = Pellet2VarIdDetalle;
                    break;
                case 3:
                    idlinea = 3;
                    idDetalle_x = ExtruderVarIdDetalle;
                    break;
            }

            frm_new_detail_prd_efi pRB_New_Details = new frm_new_detail_prd_efi(Varid, frm_new_detail_prd_efi.TipoOperacion.Edit, idlinea, ExtruderVarIdDetalle);
            if (Jefe)
            {
                pRB_New_Details.Jefe = true;
                pRB_New_Details.Jefe_Fdesde = Convert.ToDateTime(dtFechaDesde.EditValue);
                pRB_New_Details.Jefe_Fhasta = Convert.ToDateTime(dtFechaHasta.EditValue);
            }

            if (pRB_New_Details.ShowDialog() == DialogResult.Yes)
            {
                load_details();
            }
        }

        private void btnNew2_Click(object sender, EventArgs e)
        {
            PRB_Create create = new PRB_Create(codigoUss);
            if (create.ShowDialog() == DialogResult.Yes)
            {
                Varid = create.IDReturn();
                load_H();
            }
        }

        private void cmdCargarDatosJefe2_Click(object sender, EventArgs e)
        {
            load_advanceJefe();
        }

        private void btnreimpresion2_Click(object sender, EventArgs e)
        {
            PBR_Reimpresion re = new PBR_Reimpresion();
            re.Show();
        }

        private void PRB_Registro_Load_1(object sender, EventArgs e)
        {
            if (UsuarioLogeado.GrupoUsuario.GrupoUsuarioActivo == GrupoUser.GrupoUsuario.Administradores)
                txtVentana.Visible = true;
            else
                txtVentana.Visible = false;

            barStaticItem.Text = UsuarioLog;
            dtFechaDesde.DateTime = dp.Now().AddDays(-180);
            dtFechaHasta.DateTime = dp.Now().AddDays(1);
            ValidatePermisos();
        }
    }
}