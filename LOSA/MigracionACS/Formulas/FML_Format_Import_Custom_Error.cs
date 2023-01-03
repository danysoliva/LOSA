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
using System.IO;
using System.Collections;

namespace LOSA.MigracionACS.Formulas
{
    public partial class FML_Format_Import_Custom_Error : DevExpress.XtraEditors.XtraForm
    {
        public DataSet datos { get; set; }
        StreamReader reader;

        #region Developer Defined Functions

        private int checked_number() 
        {
            int number = 0;

            if (chk_RMCode.Checked)
                number++;
            if (chk_RMName.Checked)
                number++;
            if (chk_Group.Checked)
                number++;
            if (chk_Bin.Checked)
                number++;
            if (chk_Percentage.Checked)
                number++;
            if (chk_CumPerc.Checked)
                number++;
            if (chk_Kg.Checked)
                number++;
            if (chk_CumKg.Checked)
                number++;

            return number;
        }

        private void repeated_value(int compare_value) 
        {
            int count = 0;

            if (int.Parse(OrderRMCode.EditValue.ToString()) == compare_value && compare_value != 0)
                count++;
            if (int.Parse(OrderRMName.EditValue.ToString()) == compare_value && compare_value != 0)
                count++;
            if (int.Parse(OrderGroup.EditValue.ToString()) == compare_value && compare_value != 0)
                count++;
            if (int.Parse(OrderBin.EditValue.ToString()) == compare_value && compare_value != 0)
                count++;
            if (int.Parse(OrderPercentage.EditValue.ToString()) == compare_value && compare_value != 0)
                count++;
            if (int.Parse(OrderCumPerc.EditValue.ToString()) == compare_value && compare_value != 0)
                count++;
            if (int.Parse(OrderKG.EditValue.ToString()) == compare_value && compare_value != 0)
                count++;
            if (int.Parse(OrderCumKG.EditValue.ToString()) == compare_value && compare_value != 0)
                count++;

            if (count > 1)
            {
                lbl_repeatedError.Visible = true;
                btn_accept.Enabled = false;
            }
            else 
            {
                lbl_repeatedError.Visible = false;
                btn_accept.Enabled = true;
            }
        }

        #endregion

        public FML_Format_Import_Custom_Error(StreamReader reader, DataSet columns)
        {
            InitializeComponent();
            this.reader = reader;
            this.datos = columns;
        }

        private void FML_Format_Import_Custom_Error_Load(object sender, EventArgs e)
        {
            try
            {
                txt_File.Text = reader.ReadToEnd();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error al cargar la información\nCódigo del Error: {0}\nDetalle del Error: {1}\n\nStack Trace: {2}", ex.HResult, ex.Message, ex.StackTrace), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chk_RMCode_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_RMCode.Checked)
            {
                OrderRMCode.Enabled = true;
                OrderRMCode.EditValue = checked_number();
            }
            else 
            {
                OrderRMCode.Enabled = false;
                OrderRMCode.EditValue = 0;
            }
        }

        private void chk_RMName_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_RMName.Checked)
            {
                OrderRMName.Enabled = true;
                OrderRMName.EditValue = checked_number();
            }
            else
            {
                OrderRMName.Enabled = false;
                OrderRMName.EditValue = 0;
            }
        }

        private void chk_Group_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Group.Checked)
            {
                OrderGroup.Enabled = true;
                OrderGroup.EditValue = checked_number();
            }
            else
            {
                OrderGroup.Enabled = false;
                OrderGroup.EditValue = 0;
            }
        }

        private void chk_Bin_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Bin.Checked)
            {
                OrderBin.Enabled = true;
                OrderBin.EditValue = checked_number();
            }
            else
            {
                OrderBin.Enabled = false;
                OrderBin.EditValue = 0;
            }
        }

        private void chk_Percentage_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Percentage.Checked)
            {
                OrderPercentage.Enabled = true;
                OrderPercentage.EditValue = checked_number();
            }
            else
            {
                OrderPercentage.Enabled = false;
                OrderPercentage.EditValue = 0;
            }
        }

        private void chk_CumPerc_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_CumPerc.Checked)
            {
                OrderCumPerc.Enabled = true;
                OrderCumPerc.EditValue = checked_number();
            }
            else
            {
                OrderCumPerc.Enabled = false;
                OrderCumPerc.EditValue = 0;
            }
        }

        private void chk_Kg_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Kg.Checked)
            {
                OrderKG.Enabled = true;
                OrderKG.EditValue = checked_number();
            }
            else
            {
                OrderKG.Enabled = false;
                OrderKG.EditValue = 0;
            }
        }

        private void chk_CumKg_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_CumKg.Checked)
            {
                OrderCumKG.Enabled = true;
                OrderCumKG.EditValue = checked_number();
            }
            else
            {
                OrderCumKG.Enabled = false;
                OrderCumKG.EditValue = 0;
            }
        }

        private void OrderRMCode_EditValueChanged(object sender, EventArgs e)
        {
            //if(chk_RMCode.Checked)
                repeated_value(int.Parse(OrderRMCode.EditValue.ToString()));
        }

        private void OrderRMName_EditValueChanged(object sender, EventArgs e)
        {
            //if(chk_RMName.Checked)
                repeated_value(int.Parse(OrderRMName.EditValue.ToString()));
        }

        private void OrderGroup_EditValueChanged(object sender, EventArgs e)
        {
            //if(chk_Group.Checked)
                repeated_value(int.Parse(OrderGroup.EditValue.ToString()));
        }

        private void OrderBin_EditValueChanged(object sender, EventArgs e)
        {
            //if(chk_Bin.Checked)
                repeated_value(int.Parse(OrderBin.EditValue.ToString()));
        }

        private void OrderPercentage_EditValueChanged(object sender, EventArgs e)
        {
            //if (chk_Percentage.Checked)
                repeated_value(int.Parse(OrderPercentage.EditValue.ToString()));
        }

        private void OrderCumPerc_EditValueChanged(object sender, EventArgs e)
        {
            //if(chk_CumPerc.Checked)
                repeated_value(int.Parse(OrderCumPerc.EditValue.ToString()));
        }

        private void OrderKG_EditValueChanged(object sender, EventArgs e)
        {
            //if(chk_Kg.Checked)
                repeated_value(int.Parse(OrderKG.EditValue.ToString()));
        }

        private void OrderCumKG_EditValueChanged(object sender, EventArgs e)
        {
            //if(chk_CumKg.Checked)
                repeated_value(int.Parse(OrderCumKG.EditValue.ToString()));
        }

        private void btn_cancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void btn_accept_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //*************CODIGO***************//
            if (chk_RMCode.Checked)
            {
                datos.Tables[0].Rows[0]["Visible"] = true;
                datos.Tables[0].Rows[0]["Order"] = int.Parse(OrderRMCode.EditValue.ToString());
            }
            else 
            {
                datos.Tables[0].Rows[0].Delete();
                //datos.Tables[0].Rows[0]["Visible"] = false;
                //datos.Tables[0].Rows[0]["Order"] = 0;
            }

            //*************MATERIA PRIMA***************//
            if (chk_RMName.Checked)
            {
                datos.Tables[0].Rows[1]["Visible"] = true;
                datos.Tables[0].Rows[1]["Order"] = int.Parse(OrderRMName.EditValue.ToString());
            }
            else
            {
                datos.Tables[0].Rows[1].Delete();
                //datos.Tables[0].Rows[1]["Visible"] = false;
                //datos.Tables[0].Rows[1]["Order"] = 0;
            }

            //*************GRUPO***************//
            //if (chk_Group.Checked)
            //{
            //    datos.Tables[0].Rows[2]["Visible"] = true;
            //    datos.Tables[0].Rows[2]["Order"] = int.Parse(OrderGroup.EditValue.ToString());
            //}
            //else
            //{
            //    datos.Tables[0].Rows[2].Delete();
            //    //datos.Tables[0].Rows[2]["Visible"] = false;
            //    //datos.Tables[0].Rows[2]["Order"] = 0;
            //}

            //*************BIN***************//
            if (chk_Bin.Checked)
            {
                datos.Tables[0].Rows[2]["Visible"] = true;
                datos.Tables[0].Rows[2]["Order"] = int.Parse(OrderBin.EditValue.ToString());
            }
            else
            {
                datos.Tables[0].Rows[2].Delete();
                //datos.Tables[0].Rows[3]["Visible"] = false;
                //datos.Tables[0].Rows[3]["Order"] = 0;
            }

            //*************PERCENTAGE***************//
            if (chk_Percentage.Checked)
            {
                datos.Tables[0].Rows[3]["Visible"] = true;
                datos.Tables[0].Rows[3]["Order"] = int.Parse(OrderPercentage.EditValue.ToString());
            }
            else
            {
                datos.Tables[0].Rows[3].Delete();
                //datos.Tables[0].Rows[4]["Visible"] = false;
                //datos.Tables[0].Rows[4]["Order"] = 0;
            }

            //*************CUM. PERCENTAGE***************//
            if (chk_CumPerc.Checked)
            {
                datos.Tables[0].Rows[4]["Visible"] = true;
                datos.Tables[0].Rows[4]["Order"] = int.Parse(OrderCumPerc.EditValue.ToString());
            }
            else
            {
                datos.Tables[0].Rows[4].Delete();
                //datos.Tables[0].Rows[5]["Visible"] = false;
                //datos.Tables[0].Rows[5]["Order"] = 0;
            }

            //*************KG***************//
            if (chk_Kg.Checked)
            {
                datos.Tables[0].Rows[5]["Visible"] = true;
                datos.Tables[0].Rows[5]["Order"] = int.Parse(OrderKG.EditValue.ToString());
            }
            else
            {
                datos.Tables[0].Rows[5].Delete();
                //datos.Tables[0].Rows[6]["Visible"] = false;
                //datos.Tables[0].Rows[6]["Order"] = 0;
            }

            //*************CUM. KG***************//
            if (chk_CumKg.Checked)
            {
                datos.Tables[0].Rows[6]["Visible"] = true;
                datos.Tables[0].Rows[6]["Order"] = int.Parse(OrderCumKG.EditValue.ToString());
            }
            else
            {
                datos.Tables[0].Rows[6].Delete();
                //datos.Tables[0].Rows[7]["Visible"] = false;
                //datos.Tables[0].Rows[7]["Order"] = 0;
            }

            datos.AcceptChanges();

            //**********LENGTH OF EACH COLUMN**********//
            //**********According to the order*********//
            ArrayList Len = new ArrayList();
            Len.Add(0);
            Len.Add(0);
            Len.Add(0);
            Len.Add(0);
            Len.Add(0);
            Len.Add(0);
            Len.Add(0);
            Len.Add(0);

            foreach (DataRow row in datos.Tables[0].Rows) 
            {
                if (Convert.ToBoolean(row["Visible"].ToString()) == true) 
                {
                    switch (int.Parse(row["Order"].ToString()))
                    {
                        case 1:
                            Len[0] = int.Parse(row["Length"].ToString());
                            break;
                        case 2:
                            Len[1] = int.Parse(row["Length"].ToString());
                            break;
                        case 3:
                            Len[2] = int.Parse(row["Length"].ToString());
                            break;
                        case 4:
                            Len[3] = int.Parse(row["Length"].ToString());
                            break;
                        case 5:
                            Len[4] = int.Parse(row["Length"].ToString());
                            break;
                        case 6:
                            Len[5] = int.Parse(row["Length"].ToString());
                            break;
                        case 7:
                            Len[6] = int.Parse(row["Length"].ToString());
                            break;
                        case 8:
                            Len[7] = int.Parse(row["Length"].ToString());
                            break;
                    }
                }
            }

            foreach (DataRow row in datos.Tables[0].Rows)
            {
                int cum = 0;
                if (int.Parse(row["Order"].ToString()) == 1)
                {
                    row["Start"] = 0;
                }
                else 
                {
                    if (Convert.ToBoolean(row["Visible"].ToString()) == true) 
                    {
                        for (int i = 0; i < (int.Parse(row["Order"].ToString()) - 1); i++) 
                        {
                            cum += int.Parse(Len[i].ToString())+1;
                        }
                        row["Start"] = (cum);
                    }
                }
            }

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}