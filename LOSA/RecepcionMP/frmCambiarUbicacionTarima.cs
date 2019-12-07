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
    public partial class frmCambiarUbicacionTarima : Form
    {
        int idUbicacionTarimaActual = 0;
        int idUbicacionNueva = 0;
        private bool EncontroTarima = false;
        public enum VentanaTarima
        {
            asignarUbicacion = 1,
            cambiarUbicacion = 2
        };
        public frmCambiarUbicacionTarima()
        {
            InitializeComponent();
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


        private DataTable CreateDataTarima(int idTarima, string pCodigoBarra)
        {
            DataTable dt = new DataTable();
            Tarima infoTarima = new Tarima();

            dt.Columns.Add("Detalle", typeof(string));
            dt.Columns.Add("Valor", typeof(string));

            if (infoTarima.RecuperarRegistro(idTarima, pCodigoBarra))
            {
                dt.Rows.Add("TARIMA", infoTarima.Id);
                dt.Rows.Add("PROVEEDOR", infoTarima.Proveedor);
                dt.Rows.Add("LOTE", infoTarima.LoteMP);
                dt.Rows.Add("PRESENTACION", infoTarima.TipoTarimaDescripcion);
                EncontroTarima = true;
            }
            else
            {
                CajaDialogo.Error("NO SE ENCONTRÓ LA TARIMA");
                EncontroTarima = false;
            }
            return dt;
        }

        private DataTable CreateDataNuevaUbicacion(int pIdUbicacion, string pCodigoBarra)
        {
            DataTable dt = new DataTable();
            Ubicaciones infoUbicaciones = new Ubicaciones();

            dt.Columns.Add("Detalle", typeof(string));
            dt.Columns.Add("Valor", typeof(string));

            if (infoUbicaciones.RecuperarRegistro(pIdUbicacion, pCodigoBarra))
            {
                //id_um = tam1.IdUnidadMedida.ToString();
                //cantidadMP = tam1.Cantidad;
                idUbicacionNueva = infoUbicaciones.Id;
                dt.Rows.Add("PASILLO", infoUbicaciones.Pasillo);
                dt.Rows.Add("RACK", infoUbicaciones.Rack);
                dt.Rows.Add("ALTURA", infoUbicaciones.Altura);
                dt.Rows.Add("PROFUNDIDAD", infoUbicaciones.Profundidad);
            }

            return dt;
        }

        private void BeTarima_KeyDown(object sender, KeyEventArgs e)
        {
            DataOperations dp = new DataOperations();

            Ubicacion_Tarima infoUbicacionTarima = new Ubicacion_Tarima();
            if (e.KeyCode == Keys.Enter)
            {

                gcTarima.DataSource = CreateDataTarima(0, beIdTarima.Text.Replace("H", ""));
                gvTarima.InitNewRow += GvTarima_InitNewRow;
                gvTarima.Columns[0].AppearanceCell.Font = new Font("Segoe UI", 11, FontStyle.Bold);


                if (infoUbicacionTarima.RecuperarRegistro(0, beIdTarima.Text))
                {
                    gcUbicacionActual.DataSource = CreateDataUbicacion(infoUbicacionTarima.Rack, infoUbicacionTarima.Profundidad, infoUbicacionTarima.Altura, infoUbicacionTarima.Pasillo);
                    gvUbicacionActual.InitNewRow += GvUbicacionActual_InitNewRow;
                    gvUbicacionActual.Columns[0].AppearanceCell.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                }




            }
        }



        void datosUbicacion(SqlConnection connection)
        {
            try
            {
                DataOperations dp = new DataOperations();
                using (connection)
                {
                    string SQL = "exec obtenerUbicacionTarima @codigo_barra";
                    SqlCommand cmd = new SqlCommand();
                    SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                    cmd.Connection = connection;
                    cmd.CommandText = SQL;

                    cmd.Parameters.AddWithValue("@codigo_barra", beIdTarima.Text);

                    connection.Open();


                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            idUbicacionTarimaActual = dr.GetInt32(0);


                            gcUbicacionActual.DataSource = CreateDataUbicacion(dr.GetString(2), dr.GetString(4), dr.GetString(3), dr.GetString(1));
                            gvUbicacionActual.InitNewRow += GvUbicacionActual_InitNewRow;
                            gvUbicacionActual.Columns[0].AppearanceCell.Font = new Font("Segoe UI", 11, FontStyle.Bold);

                            //gcTarima.DataSource = CreateDataTarima(1);
                            gvTarima.InitNewRow += GvTarima_InitNewRow;
                        }
                    }
                    else
                    {
                        CajaDialogo.Error("UBICACIÓN NO ENCONTRADA");
                        beIdTarima.Text = "";
                    }

                    cn.Close();

                }
            }
            catch (Exception error)
            {
                CajaDialogo.Error(error.Message);
            }
        }

        private void GvUbicacionActual_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gvUbicacionActual.SetRowCellValue(e.RowHandle, gvUbicacionActual.Columns["Detalle"], true);
        }

        private void CmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GvTarima_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {

        }

        private void BtnUbicacion_Click(object sender, EventArgs e)
        {
            frmUbicacionTarima frm = new frmUbicacionTarima();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                idUbicacionNueva = frm.idUbicacion;
                gcNuevaUbicación.DataSource = CreateDataNuevaUbicacion(frm.idUbicacion, "");
                gvNuevaUbicacion.InitNewRow += GvNuevaUbicacion_InitNewRow;
                gvNuevaUbicacion.Columns[0].AppearanceCell.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            }
        }

        private void GvNuevaUbicacion_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {

        }

        private void CmdSelectTarima_Click(object sender, EventArgs e)
        {
            frmTarimas frm = new frmTarimas( (int)VentanaTarima.cambiarUbicacion);
            DataOperations dp = new DataOperations();
            Ubicacion_Tarima infoUbicacionTarima = new Ubicacion_Tarima();
            

            if (frm.ShowDialog() == DialogResult.OK)
            {
                gcTarima.DataSource = CreateDataTarima(frm.idTarima,"NULL");
                gvTarima.InitNewRow += GvTarima_InitNewRow;
                gvTarima.Columns[0].AppearanceCell.Font = new Font("Segoe UI", 11, FontStyle.Bold);

                if (EncontroTarima)//Si encontro tarima, buscar ubicacion
                {
                    if (infoUbicacionTarima.RecuperarRegistro(frm.idTarima, beIdTarima.Text))
                    {
                        idUbicacionTarimaActual = infoUbicacionTarima.Id;
                        gcUbicacionActual.DataSource = CreateDataUbicacion(infoUbicacionTarima.Rack, infoUbicacionTarima.Profundidad, infoUbicacionTarima.Altura, infoUbicacionTarima.Pasillo);
                        gvUbicacionActual.InitNewRow += GvUbicacionActual_InitNewRow;
                        gvUbicacionActual.Columns[0].AppearanceCell.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                    }
                }
            }
        }

        private void BeUbicacionActual_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            gcTarima.DataSource = null;
            gcUbicacionActual.DataSource = null;
            beIdTarima.Text = "";
        }

        private void BeNuevaUbicacion_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            gcNuevaUbicación.DataSource = null;
            beNuevaUbicacion.Text = "";
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvTarima.RowCount <= 0 || gvUbicacionActual.RowCount <= 0 || gvNuevaUbicacion.RowCount <= 0)
                    CajaDialogo.Error("INFORMACION INCOMPLETA");
                else
                {
                    DataOperations dp = new DataOperations();
                    SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                    con.Open();


                    SqlCommand cmd = new SqlCommand("sp_cambiar_ubicacion_tarima", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    Tarima tam1 = new Tarima();


                    cmd.Parameters.AddWithValue("@idUbicacionTarimaActual", idUbicacionTarimaActual);
                    cmd.Parameters.AddWithValue("@idUbicacionNueva", idUbicacionNueva);

                    cmd.ExecuteNonQuery();

                    con.Close();
                    CajaDialogo.Information("DATOS GUARDADOS");

                    gcNuevaUbicación.DataSource = null;
                    gcUbicacionActual.DataSource = null;
                    gcTarima.DataSource = null;
                    beIdTarima.Text = "";
                    beNuevaUbicacion.Text = "";

                }
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void BeNuevaUbicacion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                gcNuevaUbicación.DataSource = CreateDataNuevaUbicacion(0, beNuevaUbicacion.Text);
                gvNuevaUbicacion.InitNewRow += GvNuevaUbicacion_InitNewRow;
                gvNuevaUbicacion.Columns[0].AppearanceCell.Font = new Font("Segoe UI", 11, FontStyle.Bold);

            }
        }

        private void BeIdTarima_Enter(object sender, EventArgs e)
        {
            Teclado.abrirTeclado();
        }

        private void BeNuevaUbicacion_Enter(object sender, EventArgs e)
        {
            Teclado.abrirTeclado();
        }
    }
}
