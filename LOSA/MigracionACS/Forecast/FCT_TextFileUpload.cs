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
using DevExpress.XtraSplashScreen;
using ACS.Classes;
using System.IO;

namespace LOSA.MigracionACS.Forecast
{
    public partial class FCT_TextFileUpload : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();

        public string ActiveUserCode;
        public string SelectedMRP;

        public string accion;

        DataSet Information = new DataSet();


        #region Developer Defined Functions

        private string GetMes(int MesNum)
        {
            string mes = "";

            switch (MesNum)
            {
                case 1:
                    mes = "ene";
                    break;
                case 2:
                    mes = "feb";
                    break;
                case 3:
                    mes = "mar";
                    break;
                case 4:
                    mes = "abr";
                    break;
                case 5:
                    mes = "may";
                    break;
                case 6:
                    mes = "jun";
                    break;
                case 7:
                    mes = "jul";
                    break;
                case 8:
                    mes = "ago";
                    break;
                case 9:
                    mes = "sep";
                    break;
                case 10:
                    mes = "oct";
                    break;
                case 11:
                    mes = "nov";
                    break;
                case 12:
                    mes = "dic";
                    break;
            }

            return mes;
        }

        private DataSet ReadTextFile()
        {
            try
            {
                DataSet compras = new DataSet();
                compras.Tables.Add();

                string[] columns = null;

                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Archivo de Texto (.txt)|*.txt";
                dialog.FilterIndex = 0;
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var lines = File.ReadAllLines(dialog.FileName);

                    if (lines.Count() > 0)
                    {
                        columns = lines[0].Split(new char[] { '\t' });

                        foreach (var col in columns)
                        {
                            compras.Tables[0].Columns.Add(col);
                        }

                        for (int i = 1; i < lines.Count(); i++)
                        {
                            DataRow row = compras.Tables[0].NewRow();
                            string[] val = lines[i].Split(new char[] { '\t' });

                            for (int r = 0; r < val.Count() && r < columns.Count(); r++)
                            {
                                row[r] = val[r];
                            }

                            compras.Tables[0].Rows.Add(row);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Aparentemente el archivo esta vacio.\n\nDebe seleccionar un archivo valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }

                    txt_file.Text = dialog.FileName;
                }
                return compras;
            }
            catch (Exception ex)
            {
                MessageBox.Show("La carga de datos ha fallado.\n\nComuniquese con el encargado de sitemas.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        #endregion

        public FCT_TextFileUpload()
        {
            InitializeComponent();
        }

        private void rgp_options_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rgp_options.SelectedIndex == 0)
            {
                cmb_meses.Enabled = false;
            }
            else 
            {
                cmb_meses.Enabled = true;
            }
        }

        private void btn_SearchFile_Click(object sender, EventArgs e)
        {
            Information = ReadTextFile();
        }

        private void btn_accept_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                string Kind = "";

                if (accion == "compras")
                {
                    Kind = "2";
                }
                else
                {
                    Kind = "1";
                }

                if (MessageBox.Show("¿Esta seguro que desea subir este archivo, este remplazara la informacion de " + accion + " actualmente contenida en la base de datos?\n\nEste proceso es irreversible.", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) 
                {
                    if (rgp_options.SelectedIndex == 0) 
                    {
                        if (Information.Tables[0].Columns.Count != 15)
                        {
                            MessageBox.Show("El numero de columnas del archivo no es el esperado (15 columnas).\n\nPor favor verifique el archivo de texto e intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else 
                        {
                            lst_estado.Items.Add("Actualizando información...");
                            lst_estado.Items.Add("Actualizando Registros para: ");
                            foreach (DataRow row in Information.Tables[0].Rows) 
                            {
                                lst_estado.Items.Add(row["codigo"].ToString() + " - " + row["material"].ToString());

                                dp.ACS_DoSmallDBOperation(@"UPDATE [dbo].[FCT_MRP_D]
                                                   SET [ene] = " + row["ene"].ToString() + @"
                                                      ,[feb] = " + row["feb"].ToString() + @"
                                                      ,[mar] = " + row["mar"].ToString() + @"
                                                      ,[abr] = " + row["abr"].ToString() + @"
                                                      ,[may] = " + row["may"].ToString() + @"
                                                      ,[jun] = " + row["jun"].ToString() + @"
                                                      ,[jul] = " + row["jul"].ToString() + @"
                                                      ,[ago] = " + row["ago"].ToString() + @"
                                                      ,[sep] = " + row["sep"].ToString() + @"
                                                      ,[oct] = " + row["oct"].ToString() + @"
                                                      ,[nov] = " + row["nov"].ToString() + @"
                                                      ,[dic] = " + row["dic"].ToString() + @"
                                                 WHERE [id_mrp] = " + SelectedMRP + @"
                                                   AND [id_mp] = " + row["id_mp"].ToString() + @"
                                                   AND [kind] = " + Kind + @" ");
                            }

                            lst_estado.Items.Add("Proceso terminado sin problemas.");

                            btn_terminar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                            btn_accept.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                            btn_cancel.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                        }
                    }
                    else if (rgp_options.SelectedIndex == 1)
                    {
                        if (Information.Tables[0].Columns.Count != 4)
                        {
                            MessageBox.Show("El numero de columnas del archivo no es el esperado (4 columnas).\n\nPor favor verifique el archivo de texto e intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string mes = GetMes(cmb_meses.SelectedIndex + 1).ToString();

                            lst_estado.Items.Add("Actualizando información...");
                            lst_estado.Items.Add("Actualizando Registros para: ");

                            foreach (DataRow row in Information.Tables[0].Rows)
                            {
                                lst_estado.Items.Add(row["codigo"].ToString() + " - " + row["material"].ToString());

                                dp.ACS_DoSmallDBOperation(@"UPDATE [dbo].[FCT_MRP_D]
                                                   SET [" + mes + @"] = " + row["Valor_Mes"].ToString() + @"
                                                 WHERE [id_mrp] = " + SelectedMRP + @"
                                                   AND [id_mp] = " + row["id_mp"].ToString() + @"
                                                   AND [kind] = " + Kind + @" ");
                            }

                            lst_estado.Items.Add("Proceso terminado sin problemas.");

                            btn_terminar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                            btn_accept.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                            btn_cancel.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("La carga de datos ha fallado.\n\nComuniquese con el encargado de sitemas.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void btn_terminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void FCT_TextFileUpload_Load(object sender, EventArgs e)
        {
            this.Text = accion;
        }
    }
}