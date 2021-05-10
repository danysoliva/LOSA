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


namespace LOSA.TransaccionesPT
{
    public partial class frm_ajustes_inventario_PT_def : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        DataOperations dp = new DataOperations();
        public int id_insered = 0;
        public enum TipoOp
        {
              Nuevo,
              Editar
        }
        TipoOp Operacion;
     
        public frm_ajustes_inventario_PT_def(UserLogin Puser, TipoOp Pop, int P_id)
        {
            InitializeComponent();
            UsuarioLogeado = Puser;
            dt_fecha.EditValue = DateTime.Now;
            Operacion = Pop;
            switch (Operacion)
            {
                case TipoOp.Nuevo:
                    break;
                case TipoOp.Editar:
                    id_insered = P_id;
                    Load_data();
                    break;
                default:
                    break;
            }
        }
          public void Load_data() 
        {
            try                                         
            {
                string query = @"sp_load_informacion_ajuste_producto_terminado";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_inserted", id_insered);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dt_fecha.EditValue = dr.GetDateTime(0);
                    txtcomentario.Text = dr.GetString(1);
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }

        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_ajustes_inventario_PT_def_Activated(object sender, EventArgs e)
        {

            txtcomentario.Focus();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtcomentario.Text == "")
                {
                    CajaDialogo.Error("Debe especificar el motivo por el cual se va a realizar el ajuste de inventario.");
                    return;
                }
                string query = @"";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                SqlCommand cmd = new SqlCommand();
                cn.Open();
                switch (Operacion)
                {
                    case TipoOp.Nuevo:
                        query = @"sp_insert_ajuste_de_inventario_header";
                         cmd = new SqlCommand(query,cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@user", UsuarioLogeado.Id);
                        cmd.Parameters.AddWithValue("@date_create", dt_fecha.EditValue);
                        cmd.Parameters.AddWithValue("@bit_aprove", 1);
                        cmd.Parameters.AddWithValue("@comentario", txtcomentario.Text);
                        id_insered = Convert.ToInt32(cmd.ExecuteScalar());
                        frm_tarimas_to_ajustar_PT frm2 = new frm_tarimas_to_ajustar_PT(UsuarioLogeado, id_insered, frm_tarimas_to_ajustar_PT.TipoOp.Nuevo);
                        if ((frm2.ShowDialog() == DialogResult.OK))
                        {
                            this.DialogResult = DialogResult.OK;
                        }
                        break;
                    case TipoOp.Editar:

                        query = @"sp_update_ajuste_de_inventario_pt_h";
                         cmd = new SqlCommand(query, cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@datetime",  dt_fecha.EditValue);
                        cmd.Parameters.AddWithValue("@comentario", txtcomentario.Text);
                        cmd.Parameters.AddWithValue("@id_inserted", id_insered);
                        id_insered = Convert.ToInt32(cmd.ExecuteScalar());
                        frm_tarimas_to_ajustar_PT frm = new frm_tarimas_to_ajustar_PT(UsuarioLogeado, id_insered, frm_tarimas_to_ajustar_PT.TipoOp.Editar );
                        if ((frm.ShowDialog() == DialogResult.OK))
                        {
                            this.DialogResult = DialogResult.OK;
                        }
                        break;
                    default:
                        break;
                }

                
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
    }
}