using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.MigracionACS.Ttracer
{
    public partial class TT_shipmant : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        DataOperations dp = new DataOperations();
        string usercode;
        int IdOfPlan;
        int estadoOfPLan;
        
        public TT_shipmant( string usercode)
        {
            InitializeComponent();

            this.usercode = usercode;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TT_NuevoShip algo = new TT_NuevoShip(usercode);
            if (algo.ShowDialog() == DialogResult.OK)
            {
                lblCodigo.Text = algo.codigoGen;
                lblship.Text = algo.shipname;
                IdOfPlan = algo.IdCreate;
                btnorden.Enabled = true;
                btneditar.Enabled = true;

                if (dSTtracer.shipd.Rows.Count >= 1)
                {
                    MessageBox.Show("Solo se puede agregar una orden de compra por barco.", "Advertencia!");
                    return;
                }
                TT_LoadOrder order = new TT_LoadOrder(IdOfPlan, usercode, 0, DateTime.Now.Date);
                if (order.ShowDialog() == DialogResult.OK)
                {
                    load_shipd(IdOfPlan);
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TT_mship tt = new TT_mship();
            tt.Show();
        }

        private void panelControl1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnloadoldplan_Click(object sender, EventArgs e)
        {
            TT_CargoPlan plan = new TT_CargoPlan();
            if (plan.ShowDialog() == DialogResult.OK)
            {
                lblCodigo.Text = plan.codigoGen;
                lblship.Text = plan.shipname;
                IdOfPlan = plan.IdSelected;
                estadoOfPLan = plan.Estado;
                btnorden.Enabled = true;
                btneditar.Enabled = true;
                switch (estadoOfPLan)
                {
                    case 10: //planificado
                        btneditar.Enabled = true;
                        break;
                    case 20: //Asignado
                        btneditar.Enabled = true;
                        break;
                    case 30: //Finalizado
                        btneditar.Enabled = false;
                        btneditar.Text = "Plan ya finalizado";
                        btnorden.Enabled = false;
                        break;
                    case 99: //Cancelado
                        btneditar.Enabled = false;
                        btneditar.Text = "Plan cancelado, cree otro";
                        btnorden.Enabled = false;
                        break;
                    default:
                        break;
                }
                load_shipd(IdOfPlan);
            }
        }
        public void load_shipd(int id)
        {
            string Query = @"Select 
                        T2.id as ID	
                        ,T1.id as IDH
                        ,t3.descripcion AS [nombre del barco]
                        ,T2.ItemCode as [Codigo]
                        ,T2.ItemName as [Descripcion]
                        ,T2.CardCode as [Cod. Prov]
                        ,T2.DocNum as docentry
                        ,t2.Cardname as [Prov. Nombre]
                        ,t2.peso as [Kg/unit]
                        ,t2.status as [estatus]
                        ,t2.enable as [enable]
                        ,T2.Granel as [applicagranel]
                        ,T1.date_begin as [fechain]
                        ,T1.date_end as [fechafin]
                        ,Case when T2.ItemCode like 'MP%%' then 'Materia Prima'
	                          when T2.ItemCode like 'CO%%' then 'Combustible'
	                          when T2.ItemCode like 'RS%%' then 'Repuesto y suministro'
	                          when T2.ItemCode like 'ME%%' then 'Material de empaque'
	                          when T2.ItemCode like 'DS%%' then 'Desechos'
	                          when T2.ItemCode like 'RM%%' then 'Repuestos Muyang'
	                          when T2.ItemCode like 'SV%%' then 'Servicios'
	                          end as tipo
                        from TS_ship_h T1 inner join TS_ship_d T2 on T1.id = T2.id_shiph
				                          inner join M_ship T3 on T3.id = T1.shipid
				                          where T2.id_shiph =" + id + @" and T2.enable = 1 and t1.enable = 1 Order by 1 desc";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringBascula);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dSTtracer.shipd.Clear();
                da.Fill(dSTtracer.shipd);
               
            }
            catch (Exception)
            {
                
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            TT_shipconfig algo = new TT_shipconfig(usercode, IdOfPlan);
            if (algo.ShowDialog() == DialogResult.OK)
            {
                lblCodigo.Text = algo.codigoGen;
                lblship.Text = algo.shipname;
                IdOfPlan = algo.Idtoedit;
                btnorden.Enabled = true;
                btneditar.Enabled = true;
            }


        }

        private void btnorden_Click(object sender, EventArgs e)
        {
            if (dSTtracer.shipd.Rows.Count >= 1)
            {
                MessageBox.Show("Solo se puede agregar una orden de compra por barco.", "Advertencia!");
                return;
            }
            TT_LoadOrder order = new TT_LoadOrder(IdOfPlan, usercode, 0, DateTime.Now.Date);
              if (order.ShowDialog() == DialogResult.OK)
            {
                load_shipd(IdOfPlan);
            }
        }

        private void btnkik_Click(object sender, EventArgs e)
        {
            var gridview = (GridView)grd_shipd.FocusedView;
            var row = (dSTtracer.shipdRow)gridview.GetFocusedDataRow();
            string Query = @"UPDATE [dbo].[TS_ship_d]
                           SET [status] = 99
	                          ,[enable] = "+0+@"
                         WHERE id ="+row.ID;
            dp.ACS_DoSmallDBOperationBas(Query);
            load_shipd(IdOfPlan);
        }
    }
}
