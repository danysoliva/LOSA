using ACS.Classes;
using DevExpress.Utils.Win;
using DevExpress.XtraEditors;
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

namespace LOSA.Produccion
{
    public partial class frmAlimentacionManual : Form
    {
        private int idTolva,idTarima;
        private string shortNameTolva;

        private DataOperations dp = new DataOperations();
        UserLogin UsuarioLogeado;
        public frmAlimentacionManual(UserLogin pUsuarioLogeado)
        {
            InitializeComponent();
            UsuarioLogeado = pUsuarioLogeado;
        }

        private void BtnSelectTolva_Click(object sender, EventArgs e)
        {
            frmTolva frm = new frmTolva();

            if(frm.ShowDialog()== DialogResult.OK)
            {
                this.idTolva = frm.idTolva;
                beTolva.Text = frm.shortNameTolva;
                txtNombreMP.Text = frm.NombreMP;
                beTarima.Focus();
            }
        }

        private void BeTarima_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                datosTarimaPorCodBarra(cn);
            }
        }

        void datosTarimaPorCodBarra(SqlConnection connection)
        {
            Tarima InfoTarima = new Tarima();
            try
            {
                using (connection)
                {
                    string SQL = "exec sp_getTarimas_without_filters @codigo_barra";
                    SqlCommand cmd = new SqlCommand();
                    SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                    cmd.Connection = connection;
                    cmd.CommandText = SQL;

                    cmd.Parameters.AddWithValue("@codigo_barra", beTarima.Text.Replace("H", ""));

                    connection.Open();


                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            idTarima = dr.GetInt32(0);

                             gcTarima.DataSource = CreateDataTarima(dr.GetInt32(0), dr.GetString(2), dr.GetString(1), dr.GetString(5), dr.GetString(6));
                            //gvTarima.InitNewRow += GridView1_InitNewRow;
                            gvTarima.Columns[0].AppearanceCell.Font = new Font("Segoe UI", 13, FontStyle.Bold);
                        }
                    }
                    else
                    {
                        CajaDialogo.Error("TARIMA NO ENCONTRADA");
                        gcTarima.DataSource = null;
                        beTarima.Text = "";
                        //txtTarima.Text = "";
                    }

                    cn.Close();

                }
            }
            catch (Exception error)
            {
                CajaDialogo.Error(error.Message);
            }
        }

        private void CmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            bool Guardado = false;

            if (Convert.ToInt32(txtCantidad.Text) <= 0)
            {
                CajaDialogo.Error("Debe ingresar una cantidad");
                txtCantidad.Focus();
                return;
            }

           if(idTolva==0)
            {
                CajaDialogo.Error("Debe de seleccionar una tolva");
                beTolva.Focus();
                return;
            }

           if(idTarima==0)
            {
                CajaDialogo.Error("Debe de seleccionar una tarima");
                beTarima.Focus();
                return;
            }

            try
            {

                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_insert_alimentacion_manual_tolva", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_tarima", this.idTarima);
                cmd.Parameters.AddWithValue("@id_bin", this.idTolva);
                cmd.Parameters.AddWithValue("@cantidad", Convert.ToDecimal(txtCantidad .Text));
  
                cmd.ExecuteNonQuery();
                Guardado = true;
                con.Close();
                //CajaDialogo.InformationAuto();

            }
            catch (Exception ec)
            {
                Guardado = false;
                CajaDialogo.Error(ec.Message);
            }

            if (Guardado == true)
            {
                CajaDialogo.Information("Datos guardados exitosamente!");
                this.Close();
            }


        }

        private void txtCantidad_Popup(object sender, EventArgs e)
        {
            //Control.ControlCollection buttons = ((IPopupControl)sender).PopupWindow.Controls;
            //((IPopupControl)sender).PopupWindow.Width -= 30;
            //for (int i = 0; i < buttons.Count; i++)
            //{
            //    HideButtonIfNeeded(buttons[i] as CalculatorButton);
            //    OffsetButtons(buttons[i], 30);
            //}
        }

        private void ctl_keypadNumber1_OnItemSeleccionado(object sender, EventArgs e)
        {

        }

        private void ctl_keypadNumber1_OnItemSeleccionado_1(object sender, EventArgs e)
        {
            txtCantidad.Text = ctl_keypadNumber1.KeySeleccionado;
        }

        private void txtCantidad_Click(object sender, EventArgs e)
        {
            ctl_keypadNumber1.Visible = true;
        }

        private void txtCantidad_Leave(object sender, EventArgs e)
        {
            //ctl_keypadNumber1.Visible = false;
        }

        private DataTable CreateDataTarima(int idTarima, string pProveedor, string pNombreTarima, string pLote, string pPpresentacion)
        {
            DataTable dt = new DataTable();

            try
            {
                dt.Columns.Add("Detalle", typeof(string));
                dt.Columns.Add("Valor", typeof(string));


                dt.Rows.Add("TARIMA", idTarima);
                dt.Rows.Add("PROVEEDOR", pProveedor);
                dt.Rows.Add("LOTE", pLote);
                dt.Rows.Add("PRESENTACION", pPpresentacion);

                return dt;
            }
            catch (Exception error)
            {
                CajaDialogo.Information(error.Message);
                return dt;
            }
        }


    }
}
