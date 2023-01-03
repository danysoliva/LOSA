using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACS.Classes;
using System.Data.SqlClient;
using System.Data;
using DevExpress.XtraGrid.Views.Grid;

namespace ACS.Ttracer
{
    public partial class TT_addtara : Form
    {
        int BoletaID = 0;
        decimal pesototal;
        decimal promedio;
        DataOperations dp = new DataOperations();
        decimal Cantidad = 0;
        int selected = 0;
        public TT_addtara(int NumId, decimal cantidad)
        {
            InitializeComponent();
            BoletaID = NumId;
            Cantidad = cantidad;
            load_taras();
            timer1.Enabled = true;
        }
        public void load_taras()
        {
            string Query = @"Select T0.id
		                        ,t0.descrip
		                        ,t0.pesopromedio
                                ,T0.enable
                                ,0 as selected
                        from dbo.M_taras T0
                        where T0.enable = 1 and T0.id not in (Select 
	                                                                T1.id as id_tara
                                                            from dbo.trans_taras T0 join dbo.M_taras T1 On T0.[idtara] = T1.id
                                                            where T0.NumId = @parr and T0.enable = 1)";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringBascula);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.Parameters.Add("@parr", SqlDbType.Int).Value = BoletaID;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dSTtracer.taras.Clear();
                da.Fill(dSTtracer.taras);
                cn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnclose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (selected > 0)
            {
                btnguardar.Enabled = true;
            }
            else
            {
                btnguardar.Enabled = false;
            }
        }

        private void grdv_taras_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            switch (e.Column.Name)
            {
                case "colselected":
                    try
                    {
                        var gridview = (GridView)grd_taras.FocusedView;
                        var row = (dSTtracer.tarasRow)gridview.GetFocusedDataRow();
                        if (Convert.ToBoolean(e.Value))
                        {
                            foreach (DataRow rw in dSTtracer.taras.Rows)
                            {
                                if (rw["id"].ToString() == Convert.ToString(row.id) )
                                {
                                    row["selected"] = e.Value;
                                    selected = selected + 1;
                                }
                            }
                        }
                        else
                        {
                            foreach (DataRow rw in dSTtracer.taras.Rows)
                            {
                                if (rw["id"].ToString() == Convert.ToString(row.id))
                                {
                                    row["selected"] = e.Value;
                                    selected = selected - 1;
                                }
                            }
                        }
                    }
                    catch (Exception)
                    {

                        
                    }
                    break;
                default:
                    break;
            }
        }

        private void btnguardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (DataRow row in dSTtracer.taras.Rows)
            {
                if (Convert.ToBoolean(row["selected"].ToString()))
                {//Calculo de taras insert
                    promedio = Convert.ToDecimal(row["pesopromedio"].ToString());
                    pesototal = promedio * Cantidad;
                    string query = @"INSERT INTO [dbo].[trans_taras]
                                            ([idtara]
                                            ,[NumID]
                                            ,[cantidad]
                                            ,[pesototal]
                                            ,[promedio]
                                            ,[enable])
                                        VALUES
                                            (@idtara
                                            ,@NumId
                                            ,@cantidad
                                            ,@pesototal
                                            ,@promedio
                                            ,1)";
                    try
                    {
                        SqlConnection cn = new SqlConnection(dp.ConnectionStringBascula);
                        cn.Open();
                        SqlCommand cmd = new SqlCommand(query,cn);
                        cmd.Parameters.Add("@idtara", SqlDbType.Int).Value = Convert.ToDecimal(row["id"].ToString());
                        cmd.Parameters.Add("@NumId", SqlDbType.Int).Value = BoletaID;
                        cmd.Parameters.Add("@cantidad", SqlDbType.Decimal).Value = Cantidad;
                        cmd.Parameters.Add("@pesototal" ,SqlDbType.Decimal).Value = pesototal;
                        cmd.Parameters.Add("@promedio", SqlDbType.Decimal).Value = promedio;
                        cmd.ExecuteNonQuery();
                        cn.Close();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Error al cargar la informacion. " + ex.Message);
                    }
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
                
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            load_taras();
        }
    }
}
