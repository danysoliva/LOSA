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

namespace LOSA.MigracionACS.Ttracer
{
    public partial class TT_addpt : Form
    {
        string ItemCode = ""; // Articulo
        string ItemName = ""; // Descripcion de articulo
        string Cardcode = ""; // Proveedor
        string CardName = ""; // Descripcion
        DateTime orderdate = DateTime.MinValue;
        decimal Quantity = 0; // cantidad
        int Type = 8; // tipo
        int status = 30; // status
        string comentarios = ""; // comentarios
        int idconf = 0; // id vehiculo
        int idh = 0 ; // encabezado
        int Docentry = 0; // SAP 
        int linemun = 0; // Numero
        int idcompany = 0; // id compa;ia de transporte
        int Idconductor = 0; // id conductor
        int unidades = 0;
        DataOperations dp = new DataOperations();
        public TT_addpt(string usercode)
        {
            InitializeComponent();
            txtsap.Focus();
            load_factura();
            if (MessageBox.Show("Tiene una factura para crear el arribo?", "Creacion de un nuevo arribo de producto terminado?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {

                flyfactura.ShowPopup(true);
            }
            else
            {
                TT_Load_Vehiculo loadd = new TT_Load_Vehiculo();
                if (loadd.ShowDialog() == DialogResult.OK)
                {
                    idconf = loadd.idConfVehiculo;
                    txtplaca.Text = loadd.placa;
                    txtfurgon.Text = loadd.furgon;
                    idcompany = loadd.company;
                    if (loadd.company != 0)
                    {
                        TT_Seleccionempre slect = new TT_Seleccionempre(loadd.company);
                        txtempresa.Text = slect.Descripcion;


                        txtempresa.Text = slect.name;
                        TT_conductor data = new TT_conductor(loadd.company);
                        if (data.ShowDialog() == DialogResult.OK)
                        {
                            txtconductor.Text = data.Nombre + " - " + data.Cedula;
                            Idconductor = data.IdSelected;

                            //TT_add_taras taras = new TT_add_taras(Convert.ToInt32(txtsap.Text), Convert.ToInt32(Convert.ToDecimal(txtunidades.Text)));
                            //if (taras.ShowDialog() == DialogResult.OK)
                            //{
                            //    txttaras.Text = Convert.ToString(taras.Totaltara);
                            //}
                        }
                    }

                    TT_SocioNegocio sod = new TT_SocioNegocio("PT");
                    if (sod.ShowDialog() == DialogResult.OK)
                    {
                        Cardcode = sod.CardCode;
                        CardName = sod.CardName;
                        if (Cardcode == "CL00002")
                        {
                            ItemCode = "";
                            ItemName = "Producto terminado de Camaron";

                            txtcliente.Text = "(" + Cardcode + ")" + " - " + CardName;
                            txtproduct.Text = ItemName;
                        }
                        else
                        {
                            if (Cardcode == "CL00009")
                            {
                                ItemCode = "";
                                ItemName = "Producto terminado de Camaron";

                                txtcliente.Text = "(" + Cardcode + ")" + " - " + CardName;
                                txtproduct.Text = ItemName;
                            }
                            else
                            {

                                ItemCode = "";
                                ItemName = "Producto terminado de Tilapia";
                                txtproduct.Text = ItemName;

                                txtcliente.Text = "(" + Cardcode + ")" + " - " + CardName;
                            }

                            ItemCode = "";
                            ItemName = "Producto terminado de Tilapia";
                            txtproduct.Text = ItemName;

                            txtcliente.Text = "(" + Cardcode + ")" + " - " + CardName;

                        }
                    }
                }
                else
                {
                   
                }

            }
        }
        

        public void load_factura()
        {
            String query = @"Select T0.DocEntry
	                                    , T1.LineNum
	                                    ,t1.quantity
	                                    ,t0.TaxDate
	                                    ,T0.CardCode
	                                    ,T0.CardName
	                                    ,t0.Comments
	                                    ,T1.ItemCode
	                                    ,T1.Dscription as ItemName
	                                    , 0 as granel
										,coalesce(T1.U_Sacos,0) as u_sacos
                                        ,Coalesce(T0.Docnum,' ') as Nfiscal
                                    from OINV T0 JOIN INV1 T1 ON T0.DocEntry = T1.DocEntry
									order by T0.TaxDate desc";
            SqlConnection cn = new SqlConnection(dp.ConnectionSAP_OnlySELECT);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dSTtracer.factura.Clear();
                da.Fill(dSTtracer.factura);

                
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void pndata_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnclose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnfacturaSAP_Click(object sender, EventArgs e)
        {
           
            flyfactura.ShowPopup(true);


        }

        private void btnocultar_Click(object sender, EventArgs e)
        {
            flyfactura.HidePopup(true);
        }

        private void btnseleccionar_Click(object sender, EventArgs e)
        {

            try
            {
                var gridview = (GridView)grd_fatura.FocusedView;
                var row = (dSTtracer.facturaRow)gridview.GetFocusedDataRow();
                flyfactura.HidePopup(true);
                Docentry = row.DocEntry;
                txtsap.Text = row.DocEntry.ToString();
                linemun = row.LineNum;
                Cardcode = row.CardCode;
                Quantity = row.quantity;
                switch (Cardcode)
                {
                    case "CL00001":
                        CardName = row.CardName;
                        txtcliente.Text = "(" + Cardcode + ")" + " - " + CardName;
                        ItemCode = "";
                        ItemName = "Producto terminado de Tilapia";
                        Docentry = row.LineNum;
                        comentarios = row.Comments;
                        txtproduct.Text = ItemName;
                        txtfiscal.Text = row.Nfiscal;
                        unidades = row.u_sacos;
                        spinEdit1.Text = Convert.ToString(unidades);
                        break;
                    case "CL00009":
                        CardName = row.CardName;
                        txtcliente.Text = "(" + Cardcode + ")" + " - " + CardName;
                        ItemCode = "";
                        ItemName = "Producto terminado de Camaron";
                        Docentry = row.LineNum;
                        comentarios = row.Comments;
                        txtproduct.Text = ItemName;
                        txtfiscal.Text = row.Nfiscal;
                        unidades = row.u_sacos;
                        spinEdit1.Text = Convert.ToString(unidades);
                        break;
                    case "CL00002":
                        CardName = row.CardName;
                        txtcliente.Text = "(" + Cardcode + ")" + " - " + CardName;
                        ItemCode = "";
                        ItemName = "Producto terminado de Camaron";
                        Docentry = row.LineNum;
                        comentarios = row.Comments;
                        txtproduct.Text = ItemName;
                        txtfiscal.Text = row.Nfiscal;
                        unidades = row.u_sacos;
                        spinEdit1.Text = Convert.ToString(unidades);
                        break;
                    default:
                        break;
                }
                TT_Load_Vehiculo load = new TT_Load_Vehiculo();
                if (load.ShowDialog() == DialogResult.OK)
                {
                    idconf = load.idConfVehiculo;
                    txtplaca.Text = load.placa;
                    txtfurgon.Text = load.furgon;
                    idcompany = load.company;
                    if (load.company != 0)
                    {
                        TT_Seleccionempre slect = new TT_Seleccionempre(load.company);
                        txtempresa.Text = slect.Descripcion;


                        txtempresa.Text = slect.name;
                        TT_conductor data = new TT_conductor(load.company);
                        if (data.ShowDialog() == DialogResult.OK)
                        {
                            txtconductor.Text = data.Nombre + " - " + data.Cedula;
                            Idconductor = data.IdSelected;

                            //TT_add_taras taras = new TT_add_taras(Convert.ToInt32(txtsap.Text), Convert.ToInt32(Convert.ToDecimal(txtunidades.Text)));
                            //if (taras.ShowDialog() == DialogResult.OK)
                            //{
                            //    txttaras.Text = Convert.ToString(taras.Totaltara);
                            //}
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnvehiculo_Click(object sender, EventArgs e)
        {
            TT_Load_Vehiculo load = new TT_Load_Vehiculo();
            if (load.ShowDialog() == DialogResult.OK)
            {
                idconf = load.idConfVehiculo;
                txtplaca.Text = load.placa;
                txtfurgon.Text = load.furgon;
                idcompany = load.company;
                if (load.company != 0)
                {
                    TT_Seleccionempre slect = new TT_Seleccionempre(load.company);
                    txtempresa.Text = slect.Descripcion;


                    txtempresa.Text = slect.name;
                    TT_conductor data = new TT_conductor(load.company);
                    if (data.ShowDialog() == DialogResult.OK)
                    {
                        txtconductor.Text = data.Nombre + " - " + data.Cedula;
                        Idconductor = data.IdSelected;

                        //TT_add_taras taras = new TT_add_taras(Convert.ToInt32(txtsap.Text), Convert.ToInt32(Convert.ToDecimal(txtunidades.Text)));
                        //if (taras.ShowDialog() == DialogResult.OK)
                        //{
                        //    txttaras.Text = Convert.ToString(taras.Totaltara);
                        //}
                    }
                }
            }
        }

        private void btnempresa_Click(object sender, EventArgs e)
        {
            TT_Seleccionempre empr = new TT_Seleccionempre(idcompany);
            if (empr.ShowDialog() == DialogResult.OK)
            {
                txtempresa.Text = empr.Descripcion;

            }
        }

        private void btnconductor_Click(object sender, EventArgs e)
        {
            TT_conductor data = new TT_conductor(idcompany);
            if (data.ShowDialog() == DialogResult.OK)
            {
                txtconductor.Text = data.Nombre + " - " + data.Cedula;
                Idconductor = data.IdSelected;

                //TT_add_taras taras = new TT_add_taras(Convert.ToInt32(txtsap.Text), Convert.ToInt32(Convert.ToDecimal(txtunidades.Text)));
                //if (taras.ShowDialog() == DialogResult.OK)
                //{
                //    txttaras.Text = Convert.ToString(taras.Totaltara);
                //}
            }
        }

        private void btnsave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (idconf == 0)
            {// Vehiculo no asignado
                if (MessageBox.Show("Se esta dejando la configuracion de vehiculo vacia, Desea guardar igual el plan?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    status = 20;
                }
                else
                {
                    btnvehiculo_Click(sender, e);
                }
            }
            else
            {
                status = 30;

            }
            if (Idconductor == 0)
            {
               
            }
            if (txtcliente.Text == "")
            {
                MessageBox.Show("Ingrese una factura de SAP");
                txtsap.Focus();
                return;
            }
            if (txtproduct.Text == "")
            {
                MessageBox.Show("Ingrese una factura de SAP");
                txtsap.Focus();
                return;
            }
            if (dtfecha.EditValue == DBNull.Value)
            {
                MessageBox.Show("Ingrese la fecha esperada");
                dtfecha.Focus();
                return;
            }
            //if (spinEdit1.Text == "0")
            //{
            //    unidades = 0;
            //}
            //else
            //{
            //    unidades = Convert.ToInt32(spinEdit1.Text);
            //}
            using (SqlConnection cn = new SqlConnection(dp.ConnectionStringBascula))
            {
                cn.Open();
                SqlCommand cmd = cn.CreateCommand();
                SqlTransaction trans;
                trans = cn.BeginTransaction("SampleTransaction");
                cmd.Connection = cn;
                cmd.Transaction = trans;
                try
                {
                    //cmd.CommandText = @"INSERT INTO [dbo].[DC_workplan_h]
                    //                            ([codigo]
                    //                            ,[withship]
                    //                            ,[date_create]
                    //                            ,[date_inicio]
                    //                            ,[date_fin]
                    //                            ,[close]
                    //                            ,[comment]
                    //                            ,[tonaprox]
                    //                            ,[enable])
                    //                        VALUES
                    //                            (@codigo
                    //                            ,0
                    //                            ,SYSDATETIME()
                    //                            ,@datein
                    //                            ,@datein
                    //                            ,0
                    //                            ,'Venta de PT'
                    //                            , @tonaprox
                    //                            , 1) Select SCOPE_IDENTITY()";
                    //cmd.Parameters.Add("@codigo", SqlDbType.VarChar).Value = dp.Nexcode(3);
                    //cmd.Parameters.Add("@datein", SqlDbType.DateTime).Value = dtfecha.Text;
                    //cmd.Parameters.Add("@tonaprox", SqlDbType.Decimal).Value = Quantity;
                    //int IDHeader = 0;
                    //IDHeader = Convert.ToInt32(cmd.ExecuteScalar());
                    //cmd.Parameters.Clear();
                    cmd.CommandText = @"INSERT INTO [dbo].[DC_workplan_d]
                                                       ([docnum]
                                                       ,[provecode]
                                                       ,[descriprove]
                                                       ,[prodcode]
                                                       ,[descripitem]
                                                       ,[quantityplan]
                                                       ,[unt]
                                                       ,[dateplanarribe]
                                                       ,[printed]
                                                       ,[idconfvehi]
                                                       ,[enable]
                                                       ,[status]
                                                       ,[typeid]
                                                       ,[comment]
                                                       ,[idh]
                                                       ,[codigoGen]
                                                       ,[granel]
                                                       ,[line]
                                                       ,[idconductor]
                                                       ,[linenum]
                                                       ,nfiscal)
                                                 VALUES
                                                       (@Docnum
                                                       ,@clientecodigo
                                                       ,@descripcioncliente
                                                       ,@ptcodigo
                                                       ,@ptdescripcion
                                                       ,@cantidad
                                                       ,0
                                                       ,@dtfecha
                                                       ,0
                                                       ,@idconfigveiculo
                                                       ,1
                                                       ,@status
                                                       ,2
                                                       ,@comentario
                                                       ,null
                                                       ,@codigoarribo
                                                       ,0
                                                       ,@linenum
                                                       ,@idconductor
                                                       ,@linenum
                                                       ,@nfiscal
                                                       )";
                    cmd.Parameters.Add("@Docnum", SqlDbType.Int).Value = Docentry;
                    cmd.Parameters.Add("@clientecodigo", SqlDbType.VarChar).Value = Cardcode;
                    cmd.Parameters.Add("@descripcioncliente", SqlDbType.VarChar).Value = CardName;
                    cmd.Parameters.Add("@ptcodigo", SqlDbType.VarChar).Value = ItemCode;
                    cmd.Parameters.Add("@ptdescripcion", SqlDbType.VarChar).Value = ItemName;
                    cmd.Parameters.Add("@cantidad", SqlDbType.Decimal).Value = Quantity;
                    cmd.Parameters.Add("@dtfecha", SqlDbType.DateTime).Value = Convert.ToDateTime(dtfecha.EditValue).Date;
                    cmd.Parameters.Add("@idconfigveiculo", SqlDbType.Int).Value = idconf;
                    cmd.Parameters.Add("@status", SqlDbType.Int).Value = status;
                    cmd.Parameters.Add("@comentario", SqlDbType.VarChar).Value = "Entrada de producto terminado";
                    cmd.Parameters.Add("@linenum", SqlDbType.Int).Value = linemun;
                    cmd.Parameters.Add("@idconductor", SqlDbType.Int).Value = Idconductor;
                    cmd.Parameters.Add("@codigoarribo", SqlDbType.VarChar).Value = dp.Nexcode(6);
                    cmd.Parameters.Add("@nfiscal", SqlDbType.VarChar).Value = txtfiscal.Text;
                    cmd.ExecuteNonQuery();
                    trans.Commit();
                    cn.Close();
                    this.Close();
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {

                    try
                    {
                        
                        trans.Rollback();
                        MessageBox.Show(ex.Message);
                    }
                    catch (Exception ex2)
                    {
                        MessageBox.Show(ex2.Message);

                    }
                }
            }
        }

        private void dtfecha_EditValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToDateTime(dtfecha.EditValue).Date < DateTime.Now.Date )
            {
                MessageBox.Show("La fecha no puede ser menor que la actual.");
                dtfecha.Focus();
                return;
            }
        }

        private void TT_addpt_Load(object sender, EventArgs e)
        {
            dtfecha.EditValue = DateTime.Now;
        }
    }
}
 