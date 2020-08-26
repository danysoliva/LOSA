using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.RecepcionMP;
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

namespace LOSA.Reportes
{
    public partial class frmreporteUbicacion : DevExpress.XtraEditors.XtraForm
    {
        
        string UbicacionCode;
        DataOperations dp = new DataOperations();
        public frmreporteUbicacion()
        {
            InitializeComponent();
           
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmreporteUbicacion_Activated(object sender, EventArgs e)
        {
            beUbicacion.Focus();
        }
       
        private void beUbicacion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                UbicacionCode = beUbicacion.Text;
                load_data();
            }


        }
        public void load_data()
        {
            string query = @"sp_obtener_tarimas_por_ubicacion";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UbiCode", UbicacionCode);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsReportes.Tarimas.Clear();
                da.Fill(dsReportes.Tarimas);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdSelectTarima_Click(object sender, EventArgs e)
        {
            if (beUbicacion.Text != "" )
            {
                UbicacionCode = beUbicacion.Text;
                load_data();
            }
        }

        private void grd_ubicacion_Click(object sender, EventArgs e)
        {

        }
    }
}