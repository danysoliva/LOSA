using System;
using System.Windows.Forms;
using ACS.Classes;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.MigracionACS.DataSetx;
using System.Data;
using LOSA.Clases;

namespace LOSA.MigracionACS.PT
{
    public partial class EditarProductos : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DataOperations dp;
        public string codigo;

        string Vdescripcion, VEspecie, VFecha, VEstado, VFormula;
        string idEsp = "";
        int IdProducto;
        private void repositoryItemCheckEdit1_CheckedChanged(object sender, EventArgs e)
        {
        }
        
        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        public EditarProductos(string Pcodigo, string Pdescripcion, string PEspecie, string PFecha, string PEstado, int PFormula, UserLogin UsuarioLogeado, int pIdProducto , int dias_vencimiento)
        {

            InitializeComponent();
            IdProducto = pIdProducto;
            if (UsuarioLogeado.ValidarNivelPermisos(16))
            {
                toggleSwitch1.Enabled = true;
            }

                dp = new DataOperations();
            codigo = Pcodigo; //Codigo.
            Vdescripcion = Pdescripcion; //Descricion.
            VEspecie = PEspecie;//Especie.
            VFecha = PFecha;//Fecha.
            VEstado = PEstado; //Estado. 
            VFormula = PFormula.ToString(); //Formula
            //spindDiasVenc.EditValue = dias_vencimiento;
            ProductoTerminado prod1 = new ProductoTerminado(dp.ConnectionStringCostos);
            prod1.Recuperar_producto(IdProducto);
            spindDiasVenc.EditValue = prod1.dias_vencimiento;
            spinDiasMinimos.EditValue = prod1.dias_venc_despacho;
            GenerarCodex();
            Llenado_Zarandas();
        }
        private void EditarProductos_Load(object sender, EventArgs e)
        {
        }
        private void GenerarCodex()//llena los campos
        {
            textFormula.Text = VFormula;
            
            if (VEstado == "Habilitado")
            {
                toggleSwitch1.IsOn = false; //llenar la barra de inhabilitados
            }
            else
            {
                toggleSwitch1.IsOn = true;
            }

            labelCodigo1.Text = codigo;
            labelDescrip.Text = Vdescripcion;
            labelFecha.Text = VFecha;
            labelEspecie.Text = VEspecie;


            if (VEspecie == "Camarón")
            {
                idEsp = "2";
            }
            else
            {
                idEsp = "1";
            }

            string LlenadoFamilia = @"SELECT [id]
                                            ,[short_name]
                                            ,[specie]
                                      FROM .dbo.PT_Productos_Familias
                                      where specie = " + idEsp;
            try
            {
                SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                con.Open();
                SqlCommand cmd = new SqlCommand(LlenadoFamilia, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsProductos1.Familia.Clear();
                da.Fill(dsProductos1.Familia);
                con.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
            string Query = @"SELECT [id]
                              ,[descripcion]
	                           FROM [dbo].[PT_Products_Origen]
                          where especie = "+ idEsp;
            
            try
            {
                SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                con.Open();
                SqlCommand cmd = new SqlCommand(Query, con);
                SqlDataAdapter dax = new SqlDataAdapter(cmd);
                dsProductos1.Origen.Clear();
                dax.Fill(dsProductos1.Origen);
                con.Close();
            }
            catch (Exception)
            {

                throw;
            }
            LlenadoPeso();
            LlenadoSaco();
            LlenadoCate();
            LlenadoProce();
            LlenadoSAPODOO();
            ProductoTerminado pt = new ProductoTerminado(dp.ConnectionStringCostos);
            if (pt.Recuperar_producto(codigo))
            {
                gridLookFamilia.EditValue = pt.family;
                gridLookSaco.EditValue = pt.id_bag;
                gridLookTipoSaco.EditValue = pt.id_portafolio;
                gridLookProce.EditValue = pt.id_proceso;
                gridLookCate.EditValue = pt.id_category;
                gridOrigen.EditValue = pt.idOr;
                spinProteina.Text = pt.proteinas.ToString();
                spingrasa.Text = pt.grasa.ToString();
                txtTamañodelaparticula.Text = pt.tamaño;
                txtdiametro.Text = pt.diametro;
                txtRegistro.Text = pt.registro;
                spindDiasVenc.EditValue = pt.dias_vencimiento;
                spinDiasMinimos.EditValue = pt.dias_venc_despacho;
                //txtHoras.Value = Convert.ToDateTime(pt.horasP);

            }
        }
        public void LlenadoSAPODOO()
        {
            try
            {
                string query = @"Select T0.sww as ODOO, T0.ItemCode as SAP From OITM T0 where T0.ItemCode Like 'PT%%'
                                    UNION ALL
                                    Select '--' as ODOO, 'PTXXXX' as SAP";
                DataOperations dpSAP = new DataOperations();
                SqlConnection cn = new SqlConnection(dpSAP.ConnectionSAP_OnlySELECT);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsProductos1.SAPODOO.Clear();
                da.Fill(dsProductos1.SAPODOO);
                cn.Close();
                grdSAP.EditValue = "--";
                foreach (DataRow row in dsProductos1.SAPODOO)
                {
                    if (row["ODOO"].ToString() == codigo)
                    {
                        grdSAP.EditValue = codigo;
                        return;
                    }
                   
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void LlenadoPeso()
        {
            try
            {
                string QueryPeso;
                QueryPeso = @"SELECT id
                                    ,description
                             FROM [dbo].[PT_Products_Bags]
                             where enable = 1";
                SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                con.Open();
                SqlCommand cmd = new SqlCommand(QueryPeso, con);
                SqlDataAdapter daa = new SqlDataAdapter(cmd);
                dsProductos1.Peso.Clear();
                daa.Fill(dsProductos1.Peso);
                con.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);

            }


        }

        private void gridView5_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

            bool algo = false;
            var GridView = (GridView)gridControl1.FocusedView;
            var row1 = (DSProductos.ZarandasRow)GridView.GetFocusedDataRow();
            int id = row1.id;
            switch (e.Column.Name)
            {
                case ("colActivo"):
                    {
                        algo =  Convert.ToBoolean(e.Value);
                        dsProductos1.Zarandas.AcceptChanges();
                        if (algo)
                        {
                            try
                            {
                                string Add;
                                Add = @"INSERT INTO [dbo].[PT_ProZar]
                                                         ([cod_oodo]
                                                        ,[id_Zaranda]
                                                        ,[superior]
                                                        ,[inferior])
                                                    VALUES
                                                        ('" + codigo + "'," + id + "," + row1.superior + "," + row1.inferior + ")";
                                SqlConnection cnn = new SqlConnection(dp.ConnectionStringCostos);
                                cnn.Open();
                                SqlCommand cmmd = new SqlCommand(Add, cnn);
                                cmmd.ExecuteNonQuery();
                                cnn.Close();
                            }
                            catch (Exception ex)
                            {
                                CajaDialogo.Error(ex.Message);

                            }

                        }
                        else
                        {
                            try
                            {
                                string Quit;
                                Quit = @"DELETE FROM [dbo].[PT_ProZar]
                                             WHERE cod_oodo = '" + codigo + "'" +
                                             " and id_Zaranda = " + id;
                                SqlConnection cnn = new SqlConnection(dp.ConnectionStringCostos);
                                cnn.Open();
                                SqlCommand cmmd = new SqlCommand(Quit, cnn);
                                cmmd.ExecuteNonQuery();
                                cnn.Close();
                            }
                            catch (Exception ex)
                            {
                                CajaDialogo.Error(ex.Message);

                            }
                        }
                        break;
                    }
                case ("colsuperior"):
                    {
                        int infer;
                        if (Convert.ToString(e.Value) == "")
                        {
                            infer = 0;

                        }
                        else
                        {
                            try
                            {
                                infer = Convert.ToInt32(e.Value);
                            }
                            catch (Exception)
                            {
                                row1.inferior = 0;
                                CajaDialogo.Error("Ingrese un valor numerico");
                                return;
                            }

                        }
                        try
                        {
                            SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                            cn.Open();
                            SqlCommand cmd;
                            string Cambio;
                            Cambio = @"UPDATE [dbo].[PT_ProZar]
                                        SET 
                                    [superior] = " + infer + " ,[inferior] = " + row1.inferior + "" +
                                        "  WHERE cod_oodo = '" + codigo + "' and id_Zaranda =" + id;
                            cmd = new SqlCommand(Cambio, cn);
                            cmd.ExecuteNonQuery();
                            

                        }
                        catch (Exception ex)
                        {

                            CajaDialogo.Error("Valor no valido");
                        }
                        break;
                    }
                case ("colinferior"):
                    {
                        int infer;
                        if (Convert.ToString(e.Value) == "")
                        {
                            infer = 0;

                        }
                        else
                        {
                            try
                            {
                                infer = Convert.ToInt32(e.Value);
                            }
                            catch (Exception)
                            {
                                row1.inferior = 0;
                                CajaDialogo.Error("Ingrese un valor numerico");
                                return;
                            }
                            
                        }
                        try
                        {
                            SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                            cn.Open();
                            SqlCommand cmd;
                            string Cambio;
                            Cambio = @"UPDATE [dbo].[PT_ProZar]
                                        SET 
                                    [superior] = " + row1.superior + " ,[inferior] = " + infer + "" +
                                        "  WHERE cod_oodo = '" + codigo + "' and id_Zaranda =" + id;
                            cmd = new SqlCommand(Cambio, cn);
                            cmd.ExecuteNonQuery();
                          
                        }
                        catch (Exception Ex)
                        {

                            CajaDialogo.Error(Ex.Message);
                        }
                        break;

                    }

                default:
                        break;
                }
         
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string Estado, peso;
            string family, id_bag,  id_portafolio, id_category;
            int id_proceso;
            if (toggleSwitch1.IsOn==true)
            {
                Estado = "i";
            }
            else
            {
                Estado = "a";
            }
            if (gridLookSaco.Text=="")
            {
                peso = "0";
            }
            else
            {
                if (gridLookSaco.Text == "25 Kg")
                {
                    peso = "25";
                }
                else
                {
                    peso = gridLookSaco.Text.Substring(0, 5);
                }
                
            }
            if (textFormula.Text =="")
            {
                textFormula.Text = "NULL";
            }
           
            string Update;
            if (gridLookFamilia.EditValue.ToString() == "0" )
            {
                family = "NULL";
            }
            else
            {
                family = gridLookFamilia.EditValue.ToString();
            }

            if (gridLookSaco.EditValue.ToString()=="0")
            {
                id_bag = "NULL";
            }
            else
            {
                id_bag = gridLookSaco.EditValue.ToString();
            }

            if (gridLookProce.EditValue.ToString()=="0")
            {
                id_proceso = 0;
            }
            else
            {
                id_proceso = Convert.ToInt32(gridLookProce.EditValue);
            }

            if (gridLookTipoSaco.EditValue.ToString() == "0")
            {
                id_portafolio = "NULL";
            }
            else
            {
                id_portafolio = gridLookTipoSaco.EditValue.ToString();
            }
            if (gridLookCate.EditValue.ToString()=="0")
            {
                id_category = "NULL";

            }
            else
            {
               id_category =  gridLookCate.EditValue.ToString();
            }

            if (string.IsNullOrEmpty(id_proceso.ToString()))
            {
                id_proceso = 0;
            }

            if (Convert.ToInt32(spindDiasVenc.EditValue) <= Convert.ToInt32(spinDiasMinimos.EditValue))
            {
                CajaDialogo.Error("Los Dias de Vencimiento no pueden ser menor que los Dias minimos para el Despacho del Producto!");
                return;
            }

            try
            { 
                string codigoSAP = " ";
                //var gridView = (GridView)gridControl1.FocusedView;
                //var row = (DSProductos.ProductosRow)gridView.GetFocusedDataRow();

                //if (row != null)
                //{

                codigoSAP = grdSAP.Text;

                //Update = @"UPDATE [dbo].[PT_Productos]
                //        SET    [Proteina] = " + spinProteina.Text +
                //                " ,[Grasa] = " + spingrasa.Text +
                //                " ,[PesoSaco] = " + peso +
                //                " ,[id_category] = " + id_category +
                //                " ,[Estado] = '" + Estado +
                //                "' ,[family] = " + family +
                //                " ,[id_bag] = " + id_bag +
                //                " ,[Formula_code_V2] = " + textFormula.Text +
                //                " ,formula_code = " + textFormula.Text +
                //                " ,[id_proceso] = " + id_proceso +
                //                " ,[id_portafolio] = " + id_portafolio +
                //                ",[tamanio] = '" + txtTamañodelaparticula.Text +
                //                "' ,[id_origen] = " + gridOrigen.EditValue.ToString() +
                //                " ,[Registro] = '" + txtRegistro.Text +
                //                " ,[dias_vencimiento] = '" + spindDiasVenc.EditValue +
                //                "' , [diametro] =  '" + txtdiametro.Text +
                //                @"' ,[code_sap] = '" + codigoSAP +
                //            @"' WHERE id = " + IdProducto;

                string query = @"sp_update_pt_productos";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", IdProducto);
                cmd.Parameters.AddWithValue("@Proteina", Convert.ToDecimal(spinProteina.Text));
                cmd.Parameters.AddWithValue("@Grasa", Convert.ToDecimal(spingrasa.Text));
                cmd.Parameters.AddWithValue("@PesoSaco", peso);
                cmd.Parameters.AddWithValue("@Estado", Estado);
                cmd.Parameters.AddWithValue("@id_category", id_category);
                cmd.Parameters.AddWithValue("@family", family);
                cmd.Parameters.AddWithValue("@id_bag", id_bag);
                cmd.Parameters.AddWithValue("@formula_code_V2",dp.ValidateNumberInt32(textFormula.Text));
                cmd.Parameters.AddWithValue("@formula_code", textFormula.Text);
                cmd.Parameters.AddWithValue("@id_proceso", id_proceso);
                cmd.Parameters.AddWithValue("@id_portafolio", id_portafolio);
                cmd.Parameters.AddWithValue("@tamanio", txtTamañodelaparticula.Text);
                cmd.Parameters.AddWithValue("@id_origen", gridOrigen.EditValue);
                cmd.Parameters.AddWithValue("@Registro", txtRegistro.Text);
                cmd.Parameters.AddWithValue("@diametro", txtdiametro.Text);
                cmd.Parameters.AddWithValue("@code_sap", codigoSAP);
                //cmd.Parameters.AddWithValue("@codigo_unite", );
                cmd.Parameters.AddWithValue("@dias_vencimiento", spindDiasVenc.EditValue);
                cmd.Parameters.AddWithValue("@dias_venc_despachos", spinDiasMinimos.EditValue);
                //cmd.Parameters.AddWithValue("",);

                cmd.ExecuteScalar();
                //if (Convert.ToInt32(cmd.ExecuteScalar()) == 1)
                {
                    //CajaDialogo.Information("Se han actualizado los datos correctamente");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                
               

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
               
            }
        }

        private void labelEspecie_Click(object sender, EventArgs e)
        {
        }

        private void gridView5_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
           
     
        }

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {

        }

        private void grdSAP_EditValueChanged(object sender, EventArgs e)
        {

        }

        public void LlenadoSaco()
        {
            try
            {
                string QueryPeso;
                QueryPeso = @"SELECT id
                                    ,description
                              FROM [dbo].[PT_Products_Portafolio]
                              where enable = 1";
                SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                con.Open();
                SqlCommand cmd = new SqlCommand(QueryPeso, con);
                SqlDataAdapter dataA = new SqlDataAdapter(cmd);
                dsProductos1.Portafolio.Clear();
                dataA.Fill(dsProductos1.Portafolio);
                con.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);

            }

        }

        public void LlenadoCate()
        {
            try
            {
                string Querys = @"SELECT id
                                        ,description
                                FROM [dbo].[PT_Products_Category]
                                where enable = 1";
                SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                con.Open();
                SqlCommand cmd = new SqlCommand(Querys, con);
                SqlDataAdapter Data = new SqlDataAdapter(cmd);
                dsProductos1.Categoria.Clear();
                Data.Fill(dsProductos1.Categoria);
                con.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
               
            }
        }

        public void LlenadoProce()
        {
            try
            {
                String Qry;
                Qry = @"SELECT id
                              ,description
                        FROM [dbo].[PT_Products_Process]
                        where enable = 1";
                SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                con.Open();
                SqlCommand cmd = new SqlCommand(Qry, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsProductos1.Proceso);
                con.Close();            
            }
            catch (Exception es)
            {
                CajaDialogo.Error(es.Message);
                throw;
            }
        }
        public void Llenado_Zarandas() //Parte del cambio en las Zarandas
        {
            String Qry;
            Qry = @"SELECT 
                          [id]
                         ,[description] 
                         ,Case when (SELECT
		                             Tabla.id_Zaranda 	  
                                      FROM [dbo].[PT_ProZar] as Tabla
                                     where Tabla.cod_oodo = '"+codigo+"' " +
                                     "and Tabla.id_Zaranda = id) > 0 then 1 else 0 " +
                                     "end as Activo " +
                         " ,coalesce ((Select inferior" +
                                     " from ACS.dbo.PT_ProZar " +
                                     "where [id_Zaranda] = ACS.dbo.PT_Products_Zaranda.id and cod_oodo = '"+codigo+"' ) , 0) as inferior" +
                         ",coalesce ((Select superior " +
                                     "from Acs.dbo.PT_ProZar " +
                                     " where [id_Zaranda] = ACS.dbo.PT_Products_Zaranda.id and cod_oodo = '"+codigo+"' ),0) as superior " +
                         " FROM [dbo].[PT_Products_Zaranda]  " +
                         "where especie = "+idEsp;
            SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
            con.Open();
            SqlCommand cmd = new SqlCommand(Qry, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dsProductos1.Zarandas.Clear();
            da.Fill(dsProductos1.Zarandas);
        }


    }
}