using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ACS.Classes;
using System.Data.SqlClient;
using LOSA.Clases;

namespace LOSA.MigracionACS.OIL
{
    public partial class frmOilSingle : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp;
        int idRM_int1;
        int idRM_int2;
        int idRM_int3;
        int idRM_Ext1;
        int idRM_Ext2;
        int idRM_Ext3;

        int TanqueO;
        int TanqueD;
        int idRM;

        UserLogin UsuarioLogueado;

        public frmOilSingle(UserLogin pUser)
        {
            InitializeComponent();
            dp = new DataOperations();
            GetNamesBins();
            UsuarioLogueado = pUser;
        }

        private void GetNamesBins()
        {
            idRM_int1 = GetMaterialIdBin(44);
            idRM_int2 = GetMaterialIdBin(45);
            idRM_int3 = GetMaterialIdBin(94);
            idRM_Ext1 = GetMaterialIdBin(88);
            idRM_Ext2 = GetMaterialIdBin(90);
            idRM_Ext3 = GetMaterialIdBin(91);

            lblNombreTanque1.Text = GetMaterialName(idRM_Ext1);
            lblNombreTanque2.Text = GetMaterialName(idRM_Ext2);
            lblNombreTanque3.Text = GetMaterialName(idRM_Ext3);

            lblTanqueInt1.Text = GetMaterialName(idRM_int1);
            lblTanqueInt2.Text = GetMaterialName(idRM_int2);
            lblTanqueInt3.Text = GetMaterialName(idRM_int3);
        }

        public string GetMaterialName(int pIdRM)
        {
            string RM = "";
            try
            {
                string sql = @"SELECT short_name
                               FROM [dbo].[MD_Raw_Material]
                               where id = " + pIdRM;
                SqlConnection conn = new SqlConnection(dp.ConnectionStringAPMS);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                RM = cmd.ExecuteScalar().ToString();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Detalle del Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return RM;
        }


        public int GetMaterialIdBin(int pIdBin)
        {
            int idRM = 0;
            try
            {
                string sql = @"SELECT [set_rm_id]
                               FROM [dbo].[MD_Bins]
                               where id = " + pIdBin;
                SqlConnection conn = new SqlConnection(dp.ConnectionStringAPMS);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                idRM = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Detalle del Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return idRM;
        }


        private void xCheckBoxTQExt1_OnCheckedChanged(object sender, EventArgs e)
        {
            xCheckBoxTQExt2.Value = xCheckBoxTQExt3.Value = false;
        }

        private void xCheckBoxTQExt2_OnCheckedChanged(object sender, EventArgs e)
        {
            xCheckBoxTQExt1.Value = xCheckBoxTQExt3.Value = false;
        }

        private void xCheckBoxTQExt3_OnCheckedChanged(object sender, EventArgs e)
        {
            xCheckBoxTQExt2.Value = xCheckBoxTQExt1.Value = false;
        }

        private void xCheckBoxTQInt1_OnCheckedChanged(object sender, EventArgs e)
        {
            xCheckBoxTQInt2.Value = xCheckBoxTQInt3.Value = false;
        }

        private void xCheckBoxTQInt2_OnCheckedChanged(object sender, EventArgs e)
        {
            xCheckBoxTQInt1.Value = xCheckBoxTQInt3.Value = false;
        }

        private void xCheckBoxTQInt3_OnCheckedChanged(object sender, EventArgs e)
        {
            xCheckBoxTQInt2.Value = xCheckBoxTQInt1.Value = false;
        }

        private void txtCantidad_Validated(object sender, EventArgs e)
        {
            int val;
            try
            {
                val = Convert.ToInt32(txtCantidad.Text);
            }
            catch
            {
                CajaDialogo.Error("Debe ingresar un valor Numerico correcto!");
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            int val = 0;
            try 
	        {	        
		        val = Convert.ToInt32(txtCantidad.Text);
	        }
	        catch 
	        {
                CajaDialogo.Error("La cantidad debe ser valida y mayor a cero (0)!!");
		        return;
	        }

            DialogResult r = CajaDialogo.Pregunta("Esta seguro de hacer esta requisicion?");
            if (r != System.Windows.Forms.DialogResult.Yes)
                return;
            
            if (xCheckBoxTQExt1.Value)
            { 
                TanqueO = 88;
                idRM = idRM_Ext1;            
            }
            else
            {
                if (xCheckBoxTQExt2.Value)
                {
                    TanqueO = 90;
                    idRM = idRM_Ext2;
                }
                else
                {
                    if (xCheckBoxTQExt3.Value)
                    {
                        TanqueO = 91;
                        idRM = idRM_Ext3;
                    }
                    else
                    {
                        CajaDialogo.Error("Debe Seleccionar un Bin de Destino!");
                        return; 
                    }
                }
            }
            

            if (xCheckBoxTQInt1.Value)
            {
                TanqueD = 43;
            }
            else
            {
                if (xCheckBoxTQInt2.Value)
                {
                    TanqueD = 44;
                }
                else
                {
                    if (xCheckBoxTQInt3.Value)
                    {
                        TanqueD = 45;
                    }
                    else
                    {
                        CajaDialogo.Error("Debe Seleccionar un Bin de Origen!");
                        return; 
                    }
                }
            }
            

            bool exito = false;
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringAPMS);
                conn.Open();

                string sql = @"INSERT INTO [dbo].[oil_req_h]
                                               ([id_usuario]
                                               ,[motivo]
                                               ,[tipo])
                                         VALUES
                                               ("+ UsuarioLogueado.UserId.ToString() +
                                               ",' ',1); SELECT SCOPE_IDENTITY();";
                SqlCommand cmd = new SqlCommand(sql, conn);
                int idReq = Convert.ToInt32(cmd.ExecuteScalar());

                string sql2 = @"INSERT INTO [dbo].[oil_req_d]
                                                               ([id_requisicion]
                                                               ,[id_rm]
                                                               ,[id_tanq_o]
                                                               ,[id_tanq_d]
                                                               ,[cant]
                                                               ,[complete]
                                                               ,[inclusion]
                                                               ,[process])
                                                         VALUES
                                                               (" + idReq.ToString()+
                                                                "," + idRM.ToString() +
                                                                "," + TanqueO.ToString()+
                                                                "," + TanqueD.ToString()+
                                                                "," + Convert.ToInt32(txtCantidad.Text).ToString() +
                                                                ", 0" + 
                                                                ", 100"+
                                                                ", 0)";
                SqlCommand cmd2 = new SqlCommand(sql2, conn);
                cmd2.ExecuteScalar();

                conn.Close();
                CajaDialogo.Information("Transacción Exitosa!");
                exito = true;
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }

            if (exito)
            {
                xCheckBoxTQExt1.Value = xCheckBoxTQExt2.Value = xCheckBoxTQExt3.Value = false;
                xCheckBoxTQInt1.Value = xCheckBoxTQInt2.Value = xCheckBoxTQInt3.Value = false;
            
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }
    }
}