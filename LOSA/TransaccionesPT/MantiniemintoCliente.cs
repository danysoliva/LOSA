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
using LOSA.Clases;
using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.TransaccionesPT
{
    public partial class MantiniemintoCliente : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogeado;
        public MantiniemintoCliente(UserLogin Puser)
        {
            InitializeComponent();
            UsuarioLogeado = Puser;
            load_informacion();

        }
        public void load_informacion()
        {
            string Query = @"sp_get_clientes_of_clientes";
            try 
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsPT.clientes.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsPT.clientes);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
        public void Cerrar_from()
        {
            this.Close();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Cerrar_from();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            MantenimientoClienteOperaciones frm = new MantenimientoClienteOperaciones(false,0);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                load_informacion();
            }
        }

        private void btnEditar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var gridView = (GridView)ClientesGrid.FocusedView;
                var row = (dsPT.clientesRow)gridView.GetFocusedDataRow();
                MantenimientoClienteOperaciones frm = new MantenimientoClienteOperaciones(true, row.id);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    load_informacion();
                }
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
    }
}