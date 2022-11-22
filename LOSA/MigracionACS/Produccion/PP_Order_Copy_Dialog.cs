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
using System.Data.SqlClient;
using ACS.Classes;

namespace LOSA.MigracionACS.Produccion
{
    public partial class PP_Order_Copy_Dialog : DevExpress.XtraEditors.XtraForm
    {
        int id_order;
        int id_plan; 
        int id_pt; 
        int id_formula; 
        string form_wincc; 
        DateTime date_prouction; 
        int priority;
        Double pesoBatch;
        Double bag_weight;

        string ActiveUserCode;

        DataOperations dp = new DataOperations();

        private string Get_Prod_Orden_Code()
        {
            string ProdPlan = "PP-ERROR";
            string newPP = dp.ACS_GetSelectData(@"SELECT ((COUNT([id]) + 1)) AS New_ID FROM [dbo].[PP_Plan_Ordenes]").Tables[0].Rows[0][0].ToString();

            switch (newPP.Length)
            {
                case 1:
                    ProdPlan = "PP-000000" + newPP;
                    break;
                case 2:
                    ProdPlan = "PP-00000" + newPP;
                    break;
                case 3:
                    ProdPlan = "PP-0000" + newPP;
                    break;
                case 4:
                    ProdPlan = "PP-000" + newPP;
                    break;
                case 5:
                    ProdPlan = "PP-00" + newPP;
                    break;
                case 6:
                    ProdPlan = "PP-0" + newPP;
                    break;
                case 7:
                    ProdPlan = "PP-" + newPP;
                    break;
                default:
                    ProdPlan = "PP-" + newPP;
                    break;
            }

            return ProdPlan;
        }

        public PP_Order_Copy_Dialog(int id_order, int id_plan, int id_pt, int id_formula, string form_wincc, DateTime date_prouction, int priority, string ActiveUserCode)
        {
            InitializeComponent();

            this.id_order = id_order;
            this.id_plan = id_plan;
            this.id_pt = id_pt;
            this.id_formula = id_formula;
            this.form_wincc = form_wincc;
            this.date_prouction = date_prouction;
            this.priority = priority;
            this.ActiveUserCode = ActiveUserCode;
        }

        private void btn_Cancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void btn_Accept_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txt_Paradas.EditValue) <= 0) {
                    MessageBox.Show("Debe ingresar número de paradas mayor a cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (Convert.ToInt32(txt_Paradas.EditValue) > 10)
                {
                    MessageBox.Show("No está autorizado a ingresar mas de 10 paradas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (MessageBox.Show("¿Seguro que desea copiar la orden de produccion?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@id_plan", SqlDbType.Int));
                    cmd.Parameters.Add(new SqlParameter("@pp_code", SqlDbType.VarChar, 10));
                    cmd.Parameters.Add(new SqlParameter("@id_pt", SqlDbType.Int));
                    cmd.Parameters.Add(new SqlParameter("@id_formula", SqlDbType.Int));
                    cmd.Parameters.Add(new SqlParameter("@form_wincc", SqlDbType.VarChar, 18));
                    cmd.Parameters.Add(new SqlParameter("@kg_production", SqlDbType.Decimal));
                    cmd.Parameters.Add(new SqlParameter("@date_prouction", SqlDbType.Date));
                    cmd.Parameters.Add(new SqlParameter("@priority", SqlDbType.Int));
                    cmd.Parameters.Add(new SqlParameter("@status", SqlDbType.Int));
                    cmd.Parameters.Add(new SqlParameter("@created_by", SqlDbType.Int));
                    cmd.Parameters.Add(new SqlParameter("@last_mod_by", SqlDbType.Int));
                    cmd.Parameters.Add(new SqlParameter("@kg_reached", SqlDbType.Decimal));
                    cmd.Parameters.Add(new SqlParameter("@kg_difference", SqlDbType.Decimal));
                    cmd.Parameters.Add(new SqlParameter("@cant_paradas", SqlDbType.Int));
                    cmd.Parameters.Add(new SqlParameter("@bag_production", SqlDbType.Int));
                    cmd.Parameters.Add(new SqlParameter("@line_id", SqlDbType.Int));

                    cmd.Parameters["@id_plan"].Value = id_plan;
                    cmd.Parameters["@pp_code"].Value = Get_Prod_Orden_Code();
                    cmd.Parameters["@id_pt"].Value = id_pt;
                    cmd.Parameters["@id_formula"].Value = id_formula;
                    cmd.Parameters["@form_wincc"].Value = (form_wincc.Substring(0, 11) + Get_Prod_Orden_Code().Substring(3, 7));
                    cmd.Parameters["@kg_production"].Value = txt_KgProduccion.EditValue;
                    cmd.Parameters["@date_prouction"].Value = date_prouction;
                    cmd.Parameters["@priority"].Value = priority;
                    cmd.Parameters["@status"].Value = 40;
                    cmd.Parameters["@created_by"].Value = int.Parse(ActiveUserCode);
                    cmd.Parameters["@last_mod_by"].Value = int.Parse(ActiveUserCode);
                    cmd.Parameters["@kg_reached"].Value = 0.00;
                    cmd.Parameters["@kg_difference"].Value = 0.00;
                    cmd.Parameters["@cant_paradas"].Value = txt_Paradas.EditValue;
                    cmd.Parameters["@bag_production"].Value = txt_Sacos.EditValue;
                    cmd.Parameters["@line_id"].Value = int.Parse(dp.ACS_GetSelectData(string.Format(@"SELECT [line_id] FROM [dbo].[PP_Plan_Ordenes] WHERE [id] = {0}", id_order)).Tables[0].Rows[0][0].ToString());

                    dp.ACS_Exec_SP("PP_Plan_Ordenes_Insert", cmd);

                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo resulto mal, contacta al departamento de sistemas Detalle:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_Paradas_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                txt_KgProduccion.EditValue = (int.Parse(txt_Paradas.Text.ToString()) * pesoBatch);
                txt_KgProduccion.Text = (int.Parse(txt_Paradas.Text.ToString()) * pesoBatch).ToString();
                Double sacos = Math.Round(Convert.ToDouble((Double.Parse(txt_KgProduccion.Text.ToString()) / bag_weight).ToString()), 0);
                txt_Sacos.EditValue = sacos;
                txt_Sacos.Text = sacos.ToString();//Convert.ToInt32(Math.Round(Convert.ToDouble((Double.Parse(txt_KgProduccion.Text.ToString()) / bag_weight).ToString()),0)).ToString();
            }
            catch { }
        }

        private void PP_Order_Copy_Dialog_Load(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@formula_id", SqlDbType.Int));

                cmd.Parameters["@formula_id"].Value = id_formula;

                pesoBatch = Convert.ToDouble(dp.ACS_Exec_SP_Get_Data("FM_Get_Formula_Weight", cmd).Rows[0]["peso"].ToString());

                bag_weight = Convert.ToInt32(Math.Round(Convert.ToDouble(dp.ACS_GetSelectData(string.Format("SELECT [PesoSaco] FROM [dbo].[PT_Productos] WHERE [id] = {0}", id_pt)).Tables[0].Rows[0][0].ToString())));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo resulto mal, contacta al departamento de sistemas Detalle:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}