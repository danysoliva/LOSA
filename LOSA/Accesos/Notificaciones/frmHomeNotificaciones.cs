using ACS.Classes;
using DevExpress.XtraEditors;
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

namespace LOSA.Accesos.Notificaciones
{
    public partial class frmHomeNotificaciones : DevExpress.XtraEditors.XtraForm
    {
        public frmHomeNotificaciones()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA);
                string sql = @"SELECT id ,
                                       descripcion 
                                 FROM dbo.ALOSY_notificaciones_tipo
                                WHERE enable = 1";

                dsNotificaciones.TipoNotificaciones.Clear();
                SqlDataAdapter da = new SqlDataAdapter(sql,cnx);
                da.Fill(dsNotificaciones.TipoNotificaciones);
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}