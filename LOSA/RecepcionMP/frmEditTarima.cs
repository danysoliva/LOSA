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
    public partial class frmEditTarima : Form
    {
        int IdSerie;
        public frmEditTarima(int pIdTarima)
        {
            InitializeComponent();
            LoadPresentaciones();
            IdSerie = pIdTarima;
            LoadDataTarima(pIdTarima);
        }


        private void LoadPresentaciones()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_presentaciones_activas", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsRecepcionMPx1.presentaciones.Clear();
                adat.Fill(dsRecepcionMPx1.presentaciones);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadDataTarima(int pIdTarima)
        {     
            //LoadDatosBoleta();
            Tarima tam = new Tarima();
            if (tam.RecuperarRegistro(this.IdSerie))
            {
                dtFechaIngreso.EditValue = string.Format("{0:dd/MM/yyyy}", tam.FechaIngreso);
                gridLookUpEditPresentacion.EditValue = tam.IdPresentacion;
                txtUnidades.Text = string.Format("{0:###,##0.00}", tam.Cantidad);
                txtNumIngreso.Text = string.Format("{0:###,##0}", tam.NumeroTransaccion);
                txtLote.Text = tam.LoteMP;
                txtPesoKg.Text = string.Format("{0:###,##0.00}", tam.Peso);
                dtFechaProduccion.EditValue = string.Format("{0:dd/MM/yyyy}", tam.FechaProduccion);
                dtFechaVencimiento.EditValue = string.Format("{0:dd/MM/yyyy}", tam.FechaVencimiento);
                txtIdBoleta.Text = tam.IdBoleta.ToString();
                MateriaPrima mp = new MateriaPrima();
                if (mp.RecuperarRegistroFromID_RM(tam.Id_materiaprima))
                {
                    txtCodigoMP.Text = mp.Codigo;
                    txtMP_Name.Text = mp.Name;
                }
            }
        }

        //private void LoadDatosBoleta()
        //{
        //    try
        //    {
        //        DataOperations dp = new DataOperations();
        //        SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
        //        con.Open();
        //        SqlCommand cmd = new SqlCommand("sp_get_detalles_boleta", con);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@SerieBoleta", this.IdSerie);
        //        SqlDataReader dr = cmd.ExecuteReader();
        //        if (dr.Read())
        //        {
        //            txtCodigoMP.Text = dr.GetString(1);
        //            txtMP_Name.Text = dr.GetString(2);
        //            txtCodigoProveedor.Text = dr.GetString(3);
        //            txtProveedorName.Text = dr.GetString(4);
        //        }
        //        dr.Close();
        //        con.Close();
        //    }
        //    catch (Exception ec)
        //    {
        //        CajaDialogo.Error(ec.Message);
        //    }
        //}








        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnAtras_Click_1(object sender, EventArgs e)
        {
            Teclado.cerrarTeclado();
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }//end public partial class frmEditTarima
}//end namespace LOSA.RecepcionMP
