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
using DevExpress.XtraGrid.Views.Grid;
using LOSA.AlmacenesExterno.Models;

namespace LOSA.AlmacenesExterno
{
    public partial class xfrmRevisarOC : DevExpress.XtraEditors.XtraForm
    {
        OrdenCompra_H oc_h = new OrdenCompra_H();
        public xfrmRevisarOC()
        {
            InitializeComponent();
        }

        private void btnOC_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOC_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            xfrmSeleccionarOC frm = new xfrmSeleccionarOC();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                oc_h = frm.oc;
                txtProveedor.Text = frm.oc.Proveedor;
                txtDate.EditValue = frm.oc.FechaDocumento;
                txtComment.Text = frm.oc.Comentario;
                btnOC.Text = frm.oc.DocNum.ToString();

                LoadOCDetail(frm.oc.DocNum);
            }
        }

        private void LoadOCDetail(int id)
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA))
                {

                    cnx.Open();
                    dsAlmacenesExternos.RevisionOC.Clear();
                    SqlDataAdapter da = new SqlDataAdapter("sp_get_OC_Detail_AlmacenesExternos", cnx);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add("@DocEntry", SqlDbType.Int).Value = id;
                    da.Fill(dsAlmacenesExternos.RevisionOC);
                    cnx.Close();

                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        SqlTransaction transaction;
        private void btn_Click(object sender, EventArgs e)
        {
            List<Conf_MP_Ingresada> lista = new List<Conf_MP_Ingresada>();

            var gv = (GridView)gcIngreso.FocusedView;

                       
            foreach (var element in dsAlmacenesExternos.RevisionOC)
            {
                if (element.CantidadIngresar==0)
                {
                    CajaDialogo.Error("DEBE DE INGRESAR UNA CANTIDAD");
                    return;
                }

                if (element.UnidadesIngresar == 0)
                {
                    CajaDialogo.Error("DEBE DE INGRESAR LAS UNIDADES");
                    return;
                }
                lista.Add(new Conf_MP_Ingresada
                {
                    ItemCode = element.ItemCode,
                    CantIngresada = element.CantidadIngresar
                    ,
                    Descripcion = element.Dscription,
                    UnidadesIngresadas= element.UnidadesIngresar,
                    LineNum=element.LineNum,
                    MPID=element.id_mp
                });
            }


            //}
            xfrmAlmacenesExternosDefinirLotes frm = new xfrmAlmacenesExternosDefinirLotes(lista,oc_h );

            if (frm.ShowDialog()== DialogResult.OK)
            {
                this.Close();
            }
            //frm.Show();
        }

        private void gvIngreso_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var gv = (GridView)gcIngreso.FocusedView;
            var row = (dsAlmacenesExternos.RevisionOCRow)gv.GetDataRow(gv.FocusedRowHandle);

            if (row != null)
            {
                if (row.CantidadIngresar > row.kg)
                {
                    CajaDialogo.Error("LA CANTIDAD INGRESADA ES SUPERIOR A LO QUE DISPONE LA ORDEN DE COMPRA");
                    row.CantidadIngresar = 0;
                    return;
                }
            }
        }
    }
}