using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data.SqlClient;
using ACS.Classes;
namespace ACS.Ttracer.Reportes
{
    public partial class TTR_Arribo_Doc : DevExpress.XtraReports.UI.XtraReport
    {
        DataOperations dp = new DataOperations();
        public TTR_Arribo_Doc(int Id)
        {
            InitializeComponent();
            xrBarCode1.Text = Id.ToString();
            xrBarCode1.ShowText = true;
            lblid.Text = Convert.ToString(Id);
            load_data(Id);
        }
        //public void encored(int id)
        //{
        //    BarcodeWriter write = new BarcodeWriter() { Format = BarcodeFormat.CODE_93 };
        //    ptbarcode.Image = write.Write(Convert.ToString(id));
        //}
        public void load_data(int id)
        {
            string Query = @"Select   T1.id --0
		                            ,T1.codigoGen --1
		                            ,T1.docnum --2
		                            ,T1.comment --3 
		                            ,coalesce(T1.granel,0) as granel --4
		                            ,T1.printed --5
		                            ,T1.prodcode as ItemCode --6
		                            ,T1.provecode as CardCode  --7
		                            ,Coalesce((Select T0.withship from DC_workplan_h T0 where T0.id = T1.idh),0) as withship  --8
		                            ,T1.descripitem as ItemName  --9
		                            ,T1.descriprove as CardName  --10
		                            ,T1.dateplanarribe  as Fecha --11
		                            ,T1.quantityplan as Cantidad  --12 
		                            ,(Select Top 1 t3.placa from dbo.conf_vehiculos T2 Join dbo.M_vehiculo T3 On T2.idvehiculo = t3.id where T1.idconfvehi = T2.id) AS Placa  --13
		                            ,Coalesce((Select Top 1 t4.container from dbo.conf_vehiculos T2 join dbo.M_furgon T4 ON T2.idfurgon = t4.id
																			where T1.idconfvehi = T2.id),'No admite') AS Contenedor  --14
		                            ,(Select Top 1 t5.descripcion from dbo.conf_vehiculos T2 Join dbo.M_vehiculo T3 On T2.idvehiculo = t3.id
													                            join dbo.M_tipos_vehi T5 On T5.id = T3.idtipo where T1.idconfvehi = T2.id) AS Tipo --15
                                    ,Coalesce((Select top 1 
	                                      T4.[descripcion] 
	                                      from [dbo].[M_unidades] T4 where t4.id=  Coalesce(T1.Idunidad, 0)), 'N/A') -- 16
                            from  DC_workplan_d T1 
                        where T1.id = " + id;
            SqlConnection CN = new SqlConnection(dp.ConnectionStringBascula);

            try
            {
                CN.Open();
                SqlCommand cmd = new SqlCommand(Query, CN);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                  
                    lblCodigoGen.Text = dr[1].ToString();
                    lbldocnum.Text = dr[2].ToString();
                    lblcomentario.Text = dr[3].ToString();
                    if (dr[4].ToString() == "True")
                    {
                        chgranel.Checked = true;
                        chsacos.Checked = false;
                    }
                    else
                    {
                        chgranel.Checked = false;
                        chsacos.Checked = true;
                    }
                    if (dr[5].ToString()== "True")
                    {
                        lblprinted.Visible = true;
                    }
                    else
                    {
                        lblprinted.Visible = false;
                    }
                    lblitemcode.Text = dr[6].ToString();
                    lblCardcode.Text = dr[7].ToString();
                   
                    lblitemname.Text = dr[9].ToString();
                    lblCardName.Text = dr[10].ToString();
                    dtfecha.Text = dr[11].ToString();
                    lblcantidad.Text = dr[12].ToString();
                    lblplaca.Text = dr[13].ToString();
                    lblfurgon.Text = dr[14].ToString();
                    lbltipovehi.Text = dr[15].ToString();
                    txtpresentacion.Text = dr[16].ToString();
                }
            }
            catch (Exception ex)
            {
                lblitemname.Text = ex.Message;
            }
        }
    }
}
