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
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.MigracionACS.SAR
{
    public partial class SAR_Orden_detalle : Form
    {
        OrdenSAP Orden;
        int isedit = 0;
        public int PariD;
        int IdDetalle = 0;
        DataTable ParDt;
        DataOperations dp = new DataOperations();
        public SAR_Orden_detalle(int IDofOCSAP)
        {
            InitializeComponent();
            PariD = IDofOCSAP;
            Orden = new OrdenSAP(PariD);
            load_rubro();
            load_capitulo();
            isedit = 1;
            btnNuevoProducto.Visible = false;
        }
        public SAR_Orden_detalle()
        {
            InitializeComponent();
            load_rubro();
            load_capitulo();
            isedit = 0;
            txttasa.Enabled = true;
            txtordenExcenta.Enabled = true;

        }
        public void load_rubro()
        {
            string Query = @"SELECT Cast(Code as int) as [rubro]
                                  ,[Name]
                              FROM [AQFSVR006\AQFSVR006].AQUA.[dbo].[@RUBRO]
							  Union All
							  Select 0,'SIN RUBRO CONFIGURADO'
                              Order by Cast(Code as int) asc";
            SqlConnection cn = new SqlConnection(dp.ConnectionSAP_OnlySELECT);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dS_SAR.rubro.Clear();
                da.Fill(dS_SAR.rubro);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
            
        }
        public void load_capitulo()
        {
            string Query = @"SELECT [Code], 
                                 [U_AQUA_Desc]
                          FROM [AQFSVR006\AQFSVR006].AQUA.[dbo].[@AQUA_CAEX] T0
                            Union All
	                     Select '0' as Code,'SIN CAPITULO CONFIGURADO' as [U_AQUA_Desc]";
            SqlConnection cn = new SqlConnection(dp.ConnectionSAP_OnlySELECT);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dS_SAR.capitulo.Clear();
                da.Fill(dS_SAR.capitulo);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }

        }

        private void SAR_Orden_detalle_Load(object sender, EventArgs e)
        {
            if (isedit == 0)
            {
               //txtCardcode.Enabled = true;
                dtfecha.Enabled = true;
                txtcomentario.Enabled = true;
            }
            else
            {
                txtcomentario.Text = Orden.comentario;
                txtCardcode.Text = Orden.Cardcode;
                txtCardName.Text = Orden.CardName;
                txtdocnum.Text = Orden.DocNum.ToString();
                Txtmoneda.Text = Orden.moneda;
                txttasa.Text = Orden.tasa.ToString();
                txttotal.Text = Orden.Totaldoc.ToString();
                dtfecha.EditValue = Orden.Datecont;
                ParDt = Orden.dt;
                grd_detalle.DataSource = ParDt;
                txtordenExcenta.Text = Orden.OCEXO;
                tggenable.IsOn = Orden.IsON;
            }
            
        }

        private void txtdocnum_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtdocnum_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                popcopiOrden.ShowPopup(Cursor.Position);
            }
        }

        private void btncopiorden_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Clipboard.SetText(txtdocnum.Text);
        }

        private void grdv_detalle_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_detalle.FocusedView;
                var rows = (dS_SAR.OCDRow)gridView.GetFocusedDataRow();
                if (isedit == 1)
                {
                    if (e.Column.Name == "colrubro")
                    {
                        foreach (DataRow row in ParDt.Rows)
                        {
                            if (IdDetalle.ToString() == row["id"].ToString())
                            {
                                row["rubro"] = e.Value;
                            }
                        }
                        ParDt.AcceptChanges();
                    }
                    if (e.Column.Name == "colcapitulo")
                    {
                        foreach (DataRow row in ParDt.Rows)
                        {
                            if (IdDetalle.ToString() == row["id"].ToString())
                            {
                                row["capitulo"] = e.Value;
                            }
                        }
                        ParDt.AcceptChanges();
                    }
                }
                else
                {
                    if (e.Column.Name == "colrubro")
                    {
                        rows.rubro = Convert.ToInt32(e.Value);
                        rows.AcceptChanges();
                    }
                    if (e.Column.Name == "colcapitulo")
                    {
                        rows.capitulo = Convert.ToString(e.Value);
                        rows.AcceptChanges();
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void grdv_detalle_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            IdDetalle =   int.Parse(grdv_detalle.GetDataRow(e.FocusedRowHandle)["id"].ToString());
        }

        private void btnsave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            //Guardar OCHeader
            if (isedit == 1)
            {
                string OCEx = " ";
                if (txtordenExcenta.Text == "")
                {

                }                                               
                else
                {
                    OCEx = txtordenExcenta.Text;
                }
                string qry = @"UPDATE [dbo].[SAR_Order_H]
                                   SET 
                                   [oc_exo] = @OCEXO,
                                    [enable] = @Ison
                                 WHERE id = @parid";
                SqlConnection Pconection = new SqlConnection(dp.ConnectionStringCostos);
                try
                {
                    int bit = 0;
                    if (tggenable.IsOn)
                    {
                        bit = 1;
                    }
                    else
                    {
                        bit = 0;
                    }
                    Pconection.Open();
                    SqlCommand command = new SqlCommand(qry, Pconection);
                    command.Parameters.Add("@OCEXO", SqlDbType.VarChar).Value = OCEx;
                    command.Parameters.Add("@parid", SqlDbType.Int).Value = PariD;
                    command.Parameters.Add("@Ison", SqlDbType.Bit).Value = bit;
                    command.ExecuteNonQuery();
                    Pconection.Close();
                }
                catch (Exception ex)
                {

                }


                //Guardar Rubro
                //+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=
                foreach (DataRow row in ParDt.Rows)
                {

                    //cambiar el rubro
                    if (row["rubro"].ToString() != "0")
                    {
                        string Query = @"UPDATE [dbo].[SAR_Order_D]
                                    SET [rubro] = @rubro
                                    WHERE id = @iddetalle";
                        SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                        try
                        {
                            cn.Open();
                            SqlCommand cmd = new SqlCommand(Query, cn);
                            cmd.Parameters.Add("@iddetalle", SqlDbType.Int).Value = row["id"].ToString();
                            cmd.Parameters.Add("@rubro", SqlDbType.Int).Value = row["rubro"].ToString();
                            cmd.ExecuteNonQuery();
                            cn.Close();
                        }
                        catch (Exception ex)
                        {

                            CajaDialogo.Error(ex.Message);
                        }
                    }
                    if (row["capitulo"].ToString() != "0")
                    {
                        string Query = @"UPDATE [dbo].[SAR_Order_D]
                                    SET [capitulo] = @rubro
                                    WHERE id = @iddetalle";
                        SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                        try
                        {
                            cn.Open();
                            SqlCommand cmd = new SqlCommand(Query, cn);
                            cmd.Parameters.Add("@iddetalle", SqlDbType.Int).Value = row["id"].ToString();
                            cmd.Parameters.Add("@rubro", SqlDbType.VarChar).Value = row["capitulo"].ToString();
                            cmd.ExecuteNonQuery();
                            cn.Close();
                        }
                        catch (Exception ex)
                        {

                            CajaDialogo.Error(ex.Message);
                        }
                    }


                }
            }
            else
            { /// Nuevo
                if (txtcomentario.Text == "")
                {
                    CajaDialogo.Error("Debe ingresar un comentario");
                    return;

                }
                if (txtCardcode.Text == "")
                {
                    CajaDialogo.Error("Debe ingresar un proveedor");
                    return;
                }
                if (txttotal.Text == "")
                {
                    CajaDialogo.Error("Debe ingresar por lo menos un articulo.");
                    return;
                }
                if (dtfecha.Text == "")
                {
                    CajaDialogo.Error("Debe ingresar por lo menos una fecha.");
                    return;
                }
                string query = @"sp_insert_oc_manual";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                try
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(query,cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CardCode", txtCardcode.Text);
                    cmd.Parameters.AddWithValue("@CardName", txtCardName.Text);
                    cmd.Parameters.AddWithValue("@datadoc", string.Format("{0:yyyy-MM-dd}", dtfecha.DateTime));
                    cmd.Parameters.AddWithValue("@comentario", txtcomentario.Text);
                    cmd.Parameters.AddWithValue("@exonerada", txtordenExcenta.Text);
                    cmd.Parameters.AddWithValue("@total", txttotal.Text);
                    int inserted = Convert.ToInt32(cmd.ExecuteScalar());
                    query = @"sp_insert_oc_manual_detalle";
                    foreach (dS_SAR.OCDRow item in dS_SAR.OCD.Rows)
                    {
                        cmd = new SqlCommand(query,cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", inserted);
                        cmd.Parameters.AddWithValue("@itemcode", item.ItemCode);
                        cmd.Parameters.AddWithValue("@itemname", item.ItemName);
                        cmd.Parameters.AddWithValue("@cantidad", item.Cantidad);
                        cmd.Parameters.AddWithValue("@rubro", item.rubro);
                        cmd.Parameters.AddWithValue("@capitulo", item.capitulo);
                        cmd.Parameters.AddWithValue("@precioU", item.precioU);
                        cmd.Parameters.AddWithValue("@totalline", item.Totallinea);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {

                }

            }
            if (MessageBox.Show("Cambio exitoso", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {

            }
        }

        private void btnclose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void grdrubro_Popup(object sender, EventArgs e)
        {

        }

        private void txttasa_TextChanged(object sender, EventArgs e)
        {

        }

        private void tggenable_Toggled(object sender, EventArgs e)
        {

        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            frmPickArticulo frm = new frmPickArticulo();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                DataRow DR = dS_SAR.OCD.NewRow();
                DR["id"] = 0;
                DR["LineNum"] = 0;
                DR["ItemCode"] = frm.Itemcode ;
                DR["ItemName"] = frm.Descripcion;
                DR["Cantidad"] = 0;
                DR["precioU"] = 0;
                DR["txtlegal"] = "";
                DR["SacosU"] = 0;
                DR["Totallinea"] = 0;
                DR["rubro"] = 0;
                DR["capitulo"] = "";
                dS_SAR.OCD.Rows.Add(DR);
                dS_SAR.OCD.AcceptChanges();
                txttotal.Text = get_total().ToString();

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (isedit == 0)
            {
                grdv_detalle.DeleteRow(grdv_detalle.FocusedRowHandle);
                dS_SAR.OCD.AcceptChanges();

            }
        }
        public decimal get_total()
        {
            decimal total = 0;
            foreach (dS_SAR.OCDRow item in dS_SAR.OCD.Rows)
            {
                total = item.Totallinea + total;
            }

            return total;
        }

        private void grdv_detalle_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var gridView = (GridView)grd_detalle.FocusedView;
            var rows = (dS_SAR.OCDRow)gridView.GetFocusedDataRow();

            if (e.Column.FieldName == "Cantidad")
            {
                rows.Cantidad = Convert.ToDecimal(e.Value);
                rows.Totallinea = Convert.ToDecimal(Convert.ToDecimal(e.Value) * Convert.ToDecimal(rows.precioU));
                rows.AcceptChanges();
                txttotal.Text = get_total().ToString();
            }
            if (e.Column.FieldName == "precioU")
            {
                rows.precioU = Convert.ToDouble(e.Value);
                rows.Totallinea = Convert.ToDecimal(Convert.ToDecimal(e.Value) * Convert.ToDecimal(rows.Cantidad));
                rows.AcceptChanges();
                txttotal.Text = get_total().ToString();
            }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frm_select_pv frm = new frm_select_pv();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtCardName.Text = frm.pv;
                txtCardcode.Text = frm.Cardcode;
            }
        }
    }
}
