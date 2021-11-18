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

namespace LOSA.Liquidos
{
    public partial class xfrmTanqueCRUD : DevExpress.XtraEditors.XtraForm
    {
        public enum ModoForm
        {
            nuevo = 1,
            editar = 2
        }

        int modoForm = 0,id=0;
        string description;
        public xfrmTanqueCRUD(int pId,string descripcion, int pModoForm)
        {
            InitializeComponent();

            description = descripcion;
            modoForm = pModoForm;
            id = pId;
        }

        private void xfrmTanqueCRUD_Load(object sender, EventArgs e)
        {
            if (modoForm==2)
            {
                txtTanque.Text = description;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTanque.Text))
            {
                CajaDialogo.Error("DEBE DE INGRESAR UN NOMBRE PARA EL TANQUE");
                return;
            }

            switch (modoForm)
            {
                case 1:
                    SaveData();
                    this.DialogResult = DialogResult.OK;
                    break;

                case 2:
                    UpdateData();
                    this.DialogResult = DialogResult.OK;
                    break;
            }
        }

        private void SaveData()
        {

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringCostos);

                using (SqlCommand cmd = new SqlCommand("dbo.sp_insert_tanque", cnx))
                {
                    cnx.Open();

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@descripcion",SqlDbType.VarChar).Value=txtTanque.Text;

                    cmd.ExecuteNonQuery();

                    cnx.Close();
                }

                CajaDialogo.Information("DATOS GUARDADOS");

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateData()
        {

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringCostos);

                using (SqlCommand cmd = new SqlCommand("dbo.sp_update_tanque", cnx))
                {
                    cnx.Open();

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = txtTanque.Text;

                    cmd.ExecuteNonQuery();

                    cnx.Close();
                }

                CajaDialogo.Information("DATOS GUARDADOS");

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }


    }
}