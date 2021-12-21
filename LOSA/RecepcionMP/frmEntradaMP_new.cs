using ACS.Classes;
using Core.Clases.Herramientas;
using LOSA.Clases;
using LOSA.Despachos;
using LOSA.Utileria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.RecepcionMP
{
    public partial class frmEntradaMP_new : Form
    {
        //public decimal CantidadUnidades;
        public decimal PesoPorTarima;
        public int DEFAULT_VALUE = 0;
        public decimal FactorTarima;
        private int idTarima, idUbicacion;
        public enum VentanaTarima
        {
            asignarUbicacion = 1,
            cambiarUbicacion = 2
        };
        DataOperations dp = new DataOperations();
        DataTable dtTarima = new DataTable();
        UserLogin Usuariologeado;
        public frmEntradaMP_new(UserLogin pUser)
        {
            InitializeComponent();
            Usuariologeado = pUser;
            dtFecha.DateTime = dp.Now();
            UbicacionVacia();
            //CantidadUnidades = DEFAULT_VALUE;
            PesoPorTarima = DEFAULT_VALUE;
            FactorTarima = DEFAULT_VALUE;
            
        }

        void UbicacionVacia()
        {
            lblRack.Text = lblBodega.Text = "";
            pictureBoxIndicadorOk.Visible = false;
            pictureBoxIndicadorError.Visible = true;
        }

        private void CmdSelectTarima_Click(object sender, EventArgs e)
        {
            frmTarimas frm = new frmTarimas((int) VentanaTarima.asignarUbicacion);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                idTarima = frm.idTarima;
                beTarima.Text= frm.idTarima.ToString();
                               gcTarima.DataSource = CreateDataTarima(frm.idTarima, frm.proveedor, frm.nombreTarima, frm.lote, frm.presentacion);
                gvTarima.InitNewRow += GridView1_InitNewRow;
                gvTarima.Columns[0].AppearanceCell.Font= new Font("Segoe UI", 11, FontStyle.Bold);

            }
        }

        private void CmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        void datosTarima(SqlConnection connection)
        {
            try
            {
                using (connection)
                {
                    string SQL = "exec sp_obtener_tarimas_sin_ubicacion  @codigo_barra";
                    SqlCommand cmd = new SqlCommand();
                    SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                    cmd.Connection = connection;
                    cmd.CommandText = SQL;

                    cmd.Parameters.AddWithValue("@codigo_barra", beTarima.Text);

                    connection.Open();
               

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            idTarima = dr.GetInt32(0);
                            gcTarima.DataSource = CreateDataTarima(dr.GetInt32(0),dr.GetString(2), dr.GetString(1), dr.GetString(5), dr.GetString(6));
                            gvTarima.InitNewRow += GridView1_InitNewRow;
                            gvTarima.Columns[0].AppearanceCell.Font = new Font("Segoe UI",12, FontStyle.Bold);
                        }
                    }
                    else
                    {
                        //CajaDialogo.Error("TARIMA NO ENCONTRADA");
                        frmMensaje frmx = new frmMensaje(frmMensaje.TipoMsj.error, "¡La Tarima no está en recepción de Materia Prima!", 2800);
                        frmx.StartPosition = FormStartPosition.CenterScreen;
                        
                        frmx.ShowDialog();
                        gcTarima.DataSource = null;
                        idTarima = 0;
                        beTarima.Text = "";
                        beTarima.Focus();
                    }
                    dr.Close();
                    cn.Close();
                  
                }
            }
            catch (Exception error)
            {
                CajaDialogo.Error(error.Message);
            }
        }

        void SetUbicacionOk()
        {
            pictureBoxIndicadorOk.Visible = true;
            pictureBoxIndicadorError.Visible = false;
            beTarima.Focus();
        }

        void SetUbicacionFailError()
        {
            pictureBoxIndicadorOk.Visible = false;
            pictureBoxIndicadorError.Visible = true;
            idUbicacion = 0;
            lblBodega.Text = lblRack.Text = "";
            beUbicacion.Focus();
        }

        void datosUbicacion(SqlConnection connection)
        {
            try
            {
                using (connection)
                {
                    string SQL = "exec [sp_get_UbicacionTarima_from_code] @codigo_barra";
                    SqlCommand cmd = new SqlCommand();
                    SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                    cmd.Connection = connection;
                    cmd.CommandText = SQL;

                   cmd.Parameters.AddWithValue("@codigo_barra", beUbicacion.Text);

                    connection.Open();


                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        idUbicacion = dr.GetInt32(0);
                        Ubicaciones ub = new Ubicaciones();
                        if(ub.RecuperarRegistro_v2(idUbicacion, ""))
                        {
                            lblBodega.Text = ub.BodegaDescripcion;
                            lblRack.Text = ub.Rack;
                            pictureBoxIndicadorOk.Visible = true;
                            pictureBoxIndicadorError.Visible = false;
                            beTarima.Focus();
                        }
                        else
                        {
                            idUbicacion = 0;
                            lblBodega.Text = lblRack.Text = "";
                            pictureBoxIndicadorOk.Visible = false;
                            pictureBoxIndicadorError.Visible = true;
                            beUbicacion.Focus();
                        }
                    }
                    else
                    {
                        CajaDialogo.Error("UBICACIÓN NO ENCONTRADA");
                       beUbicacion.Text = "";
                       // gcUbicacion.DataSource = null;
                    }
                    dr.Close();
                    cn.Close();

                }
            }
            catch (Exception error)
            {
                CajaDialogo.Error(error.Message);
            }
        }
       

        private void BeTarima_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                datosTarima(cn);
            }
        }

        private void BtnUbicacion_Click(object sender, EventArgs e)
        {
            //frmUbicacionTarima frm = new frmUbicacionTarima();
            frmUbicacionTarima2 frm = new frmUbicacionTarima2();

            if (frm.ShowDialog()==DialogResult.OK)
            {
                idUbicacion = frm.idUbicacion;
                beUbicacion.Text = frm.idUbicacion.ToString();

                Ubicaciones ub1 = new Ubicaciones();
                if (ub1.RecuperarRegistro_v2(idUbicacion, ""))
                {
                    lblBodega.Text = ub1.BodegaDescripcion;
                    lblRack.Text = ub1.Rack;
                    pictureBoxIndicadorOk.Visible = true;
                    pictureBoxIndicadorError.Visible = false;
                }
                else
                {
                    pictureBoxIndicadorOk.Visible = false;
                    pictureBoxIndicadorError.Visible = true;
                }
            }
        }

        private void BeUbicacion_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
         
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                datosUbicacion(cn);
            }
        }

         private void BeUbicacion_Click(object sender, EventArgs e)
        {
           
            //beUbicacion.Text = "";
        }

        private void GridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gvTarima.SetRowCellValue(e.RowHandle, gvTarima.Columns["Detalle"], true);
        }

        private void BeTarima_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            beTarima.Text = "";
            gcTarima.DataSource = null;
            idTarima = 0;
            beTarima.Focus();
        }

        private DataTable CreateDataTarima(int idTarima, string pProveedor, string pNombreTarima, string pLote, string pPpresentacion)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Detalle", typeof(string));
            dt.Columns.Add("Valor", typeof(string));

          
            dt.Rows.Add("TARIMA", idTarima);
            dt.Rows.Add("PROVEEDOR" ,pProveedor);
            dt.Rows.Add("LOTE" ,pLote);
            dt.Rows.Add("PRESENTACION",pPpresentacion);

            return dt;
        }

        private void GvUbicacion_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
           //gvUbicacion.SetRowCellValue(e.RowHandle, gvUbicacion.Columns["Detalle"], true);
        }

        private void BeUbicacion_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
           beUbicacion.Text = "";
            //gcUbicacion.DataSource = null;
            SetUbicacionFailError();
        }


        

        void insertarData()
        {
            bool Guardado = false;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);

                
                con.Open();


                SqlCommand cmd = new SqlCommand("sp_insertMP_v2", con);
                cmd.CommandType = CommandType.StoredProcedure;
                Tarima tam1 = new Tarima();
                Ubicaciones infoUbicacion = new Ubicaciones();

               // CantidadUnidades = tam1.Cantidad;
                PesoPorTarima = DEFAULT_VALUE;
                FactorTarima = DEFAULT_VALUE;
                decimal cantidadMP = tam1.Cantidad;

                frm_seleccionUD frm = new frm_seleccionUD(cantidadMP, "Solo para diferenciar");
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    cantidadMP = frm.Ud;
                }
                else
                {

                    return;
                }
                
                if (tam1.RecuperarRegistro(idTarima, ""))
                {
                    if (tam1.IdUnidadMedida > 0)
                    { 
                        cmd.Parameters.AddWithValue("@unidad_medida", tam1.IdUnidadMedida);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@unidad_medida", DBNull.Value);
                    }

                    cantidadMP = tam1.Cantidad;

                    cmd.Parameters.AddWithValue("@idTarima", idTarima);
                    cmd.Parameters.AddWithValue("@cantidad", cantidadMP);
                    
                    cmd.Parameters.AddWithValue("@id_usuario", Usuariologeado.Id);
                    cmd.Parameters.AddWithValue("@fecha", dtFecha.EditValue);
                    if (infoUbicacion.RecuperarRegistro(idUbicacion, ""))
                    {
                        if (infoUbicacion.IdBodega > 0)
                        {
                            cmd.Parameters.AddWithValue("@id_bodega_destino", infoUbicacion.IdBodega);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@id_bodega_destino", DBNull.Value);
                        }
                        
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@id_bodega_destino", DBNull.Value);
                    }

                    cmd.Parameters.AddWithValue("@id_bodega_origen", 9);
                    cmd.Parameters.AddWithValue("@idUbicacion", this.idUbicacion);
                    cmd.ExecuteNonQuery();
                    Guardado = true;
                }
                con.Close();
    
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }

            if(Guardado)
            {
                //CajaDialogo.Information("DATOS GUARDADOS EXITOSAMENTE");
                frmMensaje frm = new frmMensaje(frmMensaje.TipoMsj.info, "DATOS GUARDADOS EXITOSAMENTE!", 2000);
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.ShowDialog();

                BeTarima_ButtonClick(null, null);
                //BeUbicacion_ButtonClick(null, null);
            }
            beTarima.Focus();
           // CantidadUnidades = DEFAULT_VALUE;
            PesoPorTarima = DEFAULT_VALUE;
            FactorTarima = DEFAULT_VALUE;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (idTarima == 0 || idUbicacion== 0)
                CajaDialogo.Error("DEBE DE SELECCIONAR UNA TARIMA Y SU UBICACIÓN VALIDA");
            else
                if (dtFecha.EditValue == null)
                    CajaDialogo.Error("DEBE DE SELECCIONAR UNA FECHA CORRECTA");
            else
                insertarData();
        }

        private void BeTarima_Enter(object sender, EventArgs e)
        {
            Teclado.abrirTeclado();
        }

        private void BeUbicacion_Enter(object sender, EventArgs e)
        {
            Teclado.abrirTeclado();
        }

        private DataTable CreateDataUbicacion(string pRack, string pBodega, string pPasillo)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Detalle", typeof(string));
            dt.Columns.Add("Valor", typeof(string));

            dt.Rows.Add("Bodega", pBodega);
            dt.Rows.Add("PASILLO", pPasillo);
            dt.Rows.Add("RACK", pRack);
            //dt.Rows.Add("PROFUNDIDAD", pProfundidad);

            return dt;
        }

        private void frmEntradaMP_new_Load(object sender, EventArgs e)
        {
            //beTarima.Focus();
            beUbicacion.Focus();
        }

        private void frmEntradaMP_new_Activated(object sender, EventArgs e)
        {
            //beTarima.Focus();
            if (string.IsNullOrEmpty(beUbicacion.Text))
            {
                beUbicacion.Focus();
            }
            else
            {
                beTarima.Focus();
            }
        }

        private void frmEntradaMP_new_Click(object sender, EventArgs e)
        {
            //beTarima.Focus();
            if (string.IsNullOrEmpty(beUbicacion.Text))
            {
                beUbicacion.Focus();
            }
            else
            {
                beTarima.Focus();
            }
            Teclado.cerrarTeclado();
        }

        private void beTarima_EditValueChanged(object sender, EventArgs e)
        {

        }

        private DataTable CreateDataUbicacion_v2(string pRack, string pBodega)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Detalle", typeof(string));
            dt.Columns.Add("Valor", typeof(string));

            dt.Rows.Add("Bodega", pBodega);
            //dt.Rows.Add("PASILLO", pPasillo);
            dt.Rows.Add("RACK", pRack);
            //dt.Rows.Add("PROFUNDIDAD", pProfundidad);

            return dt;
        }
    }
}
