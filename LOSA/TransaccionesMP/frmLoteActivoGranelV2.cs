using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ACS.Classes;
using LOSA.Clases;

namespace LOSA.TransaccionesMP
{
    public partial class frmLoteActivoGranelV2 : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        DataOperations dp = new DataOperations();
        
        public frmLoteActivoGranelV2(UserLogin pUser)
        {
            InitializeComponent();
            UsuarioLogeado = pUser;
            Cargar_Existencias();
        }
        public void Cargar_Existencias()
        {
            try
            {
                string Query = @"sp_load_inventario_granel";
                SqlConnection conexion = new SqlConnection(dp.ConnectionStringLOSA);
                conexion.Open();
                SqlCommand comando = new SqlCommand(Query, conexion);
                comando.CommandType = CommandType.StoredProcedure;
                //comando.Parameters.AddWithValue("@itemcode", ItemCode);
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                dsGranelLoteactivo1.GranelExistencias.Clear();
                adapter.Fill(dsGranelLoteactivo1.GranelExistencias);
                conexion.Close();
                
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
    }
}