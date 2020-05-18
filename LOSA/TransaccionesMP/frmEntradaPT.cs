using ACS.Classes;
using Core.Clases.Herramientas;
using LOSA.Clases;
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
    public partial class frmEntradaPT : Form
    {
        private int idTarima, idUbicacion;
        public enum VentanaTarima
        {
            asignarUbicacion = 1,
            cambiarUbicacion = 2,
            productoTerminado = 4
        };
        DataOperations dp = new DataOperations();
        DataTable dtTarima = new DataTable();
        UserLogin Usuariologeado;
        public frmEntradaPT(UserLogin pUser)
        {
            InitializeComponent();
            Usuariologeado = pUser;
            dtFecha.DateTime = dp.Now();
        }

        private void CmdSelectTarima_Click(object sender, EventArgs e)
        {
            frmTarimas frm = new frmTarimas((int) VentanaTarima.productoTerminado);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                idTarima = frm.idTarima;
                beTarima.Text= frm.idTarima.ToString();
                gcTarima.DataSource = CreateDataTarima(frm.idTarima, frm.NombrePro, frm.lote, frm.presentacion);
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
                            //txtTarima.Text = dr.GetString(1);
                            //txtProveedor.Text = dr.GetString(2);
                            //txtLote.Text = dr.GetString(5);
                            //txtPresentacion.Text = dr.GetString(6);
                            Tarima tar1 = new Tarima();
                            if (tar1.RecuperarRegistro(dr.GetInt32(0)))
                            {
                                DataOperations dp = new DataOperations();
                                ProductoTerminado pt = new ProductoTerminado(dp.ConnectionStringCostos);
                                if (pt.Recuperar_producto(tar1.IdProductoterminado))
                                {
                                    BagsPT bag = new BagsPT();
                                    string pres = "";
                                    if (bag.RecuperarRegistro(pt.id_bag))
                                    {
                                        pres = bag.Descripcion;
                                    }
                                    gcTarima.DataSource = CreateDataTarima(tar1.Id, pt.descripcion, tar1.LotePT.ToString(), pres);
                                    gvTarima.InitNewRow += GridView1_InitNewRow;
                                    gvTarima.Columns[0].AppearanceCell.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                                }
                            }
                        }
                    }
                    else
                    {
                        CajaDialogo.Error("TARIMA NO ENCONTRADA O Deshabilitada!");
                        gcTarima.DataSource = null;
                        beTarima.Text = "";
                        //txtTarima.Text = "";
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

        void datosUbicacion(SqlConnection connection)
        {
            try
            {
                using (connection)
                {
                    string SQL = "exec obtenerUbicacionTarima @codigo_barra";
                    SqlCommand cmd = new SqlCommand();
                    SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                    cmd.Connection = connection;
                    cmd.CommandText = SQL;

                   cmd.Parameters.AddWithValue("@codigo_barra", beUbicacion.Text);

                    connection.Open();


                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            idUbicacion = dr.GetInt32(0);
                           

                            gcUbicacion.DataSource = CreateDataUbicacion(dr.GetString(2), dr.GetString(4), dr.GetString(3), dr.GetString(1));
                            gvUbicacion.InitNewRow += GvUbicacion_InitNewRow;
                            gvUbicacion.Columns[0].AppearanceCell.Font = new Font("Segoe UI", 11, FontStyle.Bold);

                        }
                    }
                    else
                    {
                        CajaDialogo.Error("UBICACIÓN NO ENCONTRADA");
                       beUbicacion.Text = "";
                        gcUbicacion.DataSource = null;
                    }

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
            frmUbicacionTarima2 frm = new frmUbicacionTarima2();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                idUbicacion = frm.idUbicacion;
                beUbicacion.Text = frm.idUbicacion.ToString();


                //gcUbicacion.DataSource = CreateDataUbicacion(frm.rack, frm.profundidad, frm.altura, frm.pasillo);
                //                                            RACK           Bodega             Pasillo
                gcUbicacion.DataSource = CreateDataUbicacion_v2(frm.rack, frm.BodegaNombre);
                gvUbicacion.InitNewRow += GvUbicacion_InitNewRow;
                gvUbicacion.Columns[0].AppearanceCell.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            }
            //frmUbicacionTarima frm = new frmUbicacionTarima();

            //if (frm.ShowDialog()==DialogResult.OK)
            //{
            //    idUbicacion = frm.idUbicacion;
            //    beUbicacion.Text = frm.idUbicacion.ToString();


            //    gcUbicacion.DataSource = CreateDataUbicacion_v2(frm.rack);
            //    gvUbicacion.InitNewRow += GvUbicacion_InitNewRow;
            //    gvUbicacion.Columns[0].AppearanceCell.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            //}
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
           
            beUbicacion.Text = "";
        }

        private void GridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gvTarima.SetRowCellValue(e.RowHandle, gvTarima.Columns["Detalle"], true);
        }

        private void BeTarima_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            beTarima.Text = "";
            gcTarima.DataSource = null;
        
        }

        private DataTable CreateDataTarima(int idTarima, string pProducto, string pLote, string pPpresentacion)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Detalle", typeof(string));
            dt.Columns.Add("Valor", typeof(string));

          
            dt.Rows.Add("TARIMA", idTarima);
            dt.Rows.Add("PRODUCTO" , pProducto);
            dt.Rows.Add("LOTE" ,pLote);
            dt.Rows.Add("PRESENTACION",pPpresentacion);

            return dt;
        }

        private void GvUbicacion_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
           gvUbicacion.SetRowCellValue(e.RowHandle, gvUbicacion.Columns["Detalle"], true);
        }

        private void BeUbicacion_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
           beUbicacion.Text = "";
           gcUbicacion.DataSource = null;
        }

        

        void insertarData()
        {
            bool Guardado = false;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);

                
                con.Open();


                SqlCommand cmd = new SqlCommand("sp_insertMP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                Tarima tam1 = new Tarima();
                Ubicaciones infoUbicacion = new Ubicaciones();
                
                decimal cantidadMP = 0;
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
                    if (infoUbicacion.RecuperarRegistro_v2(idUbicacion, ""))
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

                    cmd.Parameters.AddWithValue("@id_bodega_origen",DBNull.Value);
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
                CajaDialogo.Information("DATOS GUARDADOS EXITOSAMENTE");

                BeTarima_ButtonClick(null, null);
                BeUbicacion_ButtonClick(null, null);
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (gvTarima.RowCount <= 0 || gvUbicacion.RowCount <= 0)
                CajaDialogo.Error("DEBE DE SELECCIONAR UNA TARIMA Y SU UBICACIÓN");
            else
                if (dtFecha.EditValue==null)
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

        private DataTable CreateDataUbicacion(string pRack, string pProfundidad, string pAltura, string pPasillo)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Detalle", typeof(string));
            dt.Columns.Add("Valor", typeof(string));


            dt.Rows.Add("PASILLO", pPasillo);
            dt.Rows.Add("RACK", pRack);
            dt.Rows.Add("ALTURA", pAltura);
            dt.Rows.Add("PROFUNDIDAD", pProfundidad);

            return dt;
        }
        private DataTable CreateDataUbicacion_v2(string pRack)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Detalle", typeof(string));
            dt.Columns.Add("Valor", typeof(string));


            //dt.Rows.Add("PASILLO", pPasillo);
            //dt.Rows.Add("RACK", pRack);

            return dt;
        }
    }
}
