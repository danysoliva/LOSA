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

namespace LOSA.MigracionACS.SAR
{
    public partial class SAR_Main : Form
    {
        CajaDialogo caja = new CajaDialogo();
        public SAR_Main()
        {
            InitializeComponent();
            timer1.Interval = 1000;
        }
        DataOperations dp = new DataOperations();
        int tipodeInfor = 10;
        Boolean realtime = false;

        private void btnrealtime_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void btnclose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        
        private void btnrubrox_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tipodeInfor = 30;
            labelControl3.Text = "Reporte de Rubro";
        }
        void inicializar_grid()
        {
            gridControl1.DataSource = null;
            gridView1.Columns.Clear();
        }
        public void Load_selected_inform()
        {
            if (tipodeInfor > 10)
            {
                if (dtbegin.Text == "")
                {
                    CajaDialogo.Error("La fecha inicial no puede quedar vacia");
                    return;
                }
                else
                {
                    if (dtfin.Text == "")
                    {
                        CajaDialogo.Error("La fecha final no puede quedar vacia");
                        return;
                    }
                    if (Convert.ToDateTime(dtbegin.Text) < Convert.ToDateTime(dtfin.Text))
                    {
                        CajaDialogo.Error("La fecha de inicio no puede ser menor que la fecha final.");
                        
                        return;

                    }
                }
                if (dtfin.Text == "")
                {
                    CajaDialogo.Error("La fecha final no puede quedar vacia");
                    return;
                }
                else
                {
                    if (Convert.ToDateTime(dtbegin.Text) < Convert.ToDateTime(dtfin.Text))
                    {
                        CajaDialogo.Error("La fecha de inicio no puede ser menor que la fecha final.");

                        return;

                    }
                }
                
            }
            string query;
            switch (tipodeInfor)
            {
                case 10://Capitulos
                    try
                    {
                        query = @"EXEC [dbo].[SAR_RPT_CAPITULOS]";
                        inicializar_grid();
                        gridControl1.DataSource = dp.ACS_GetSelectData(query).Tables[0];


                    }
                    catch (Exception ex)
                    {


                        MessageBox.Show(ex.Message);
                    }
                    break;
                case 20: //Kardex
                    try
                    {
                        query = @"EXEC [dbo].[SAR_RPT_Kardex]";
                        inicializar_grid();
                        gridControl1.DataSource = dp.ACS_GetSelectData(query).Tables[0];

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                    break;
                case 30://Rubro
                    try
                    {
                        if (dtbegin.Text == "")
                        {
                            MessageBox.Show("Fecha inicial no puede quedar vacía.");
                        }
                        else
                        {
                            if (dtfin.Text == "")
                            {
                                MessageBox.Show("Fecha final no puede quedar vacía");
                            }
                            else
                            {

                                query = @"EXEC	[dbo].[SAR_RPT_RUBRO]
		                                    @fechain = '"+Convert.ToDateTime(dtbegin.Text).Date.ToString("MM-dd-yyyy") +@"',
		                                    @fechafin = '"+ Convert.ToDateTime(dtfin.Text).Date.ToString("MM-dd-yyyy")+@"'";
                                inicializar_grid();
                                gridControl1.DataSource = dp.ACS_GetSelectData(query).Tables[0];
                            }
                        }

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                    break;
                default:
                    break;
            }
        }
        private void btnclose_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnKardex_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tipodeInfor = 20;
            labelControl3.Text = "Reporte de Kardex";
        }

        private void btncapitulo_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            tipodeInfor = 10;
            labelControl3.Text = "Reporte de Capitulo";
        }

        private void btngeneral_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Load_selected_inform();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Load_selected_inform();
        }

        private void v_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                gridControl1.ExportToXlsx(dialog.FileName);
            }
        }

        private void btngeneral_ItemDoubleClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
