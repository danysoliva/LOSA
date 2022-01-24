using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.TransaccionesMP.TrzMP_fromLote
{
    public partial class frmMP_WithSameLot : DevExpress.XtraEditors.XtraForm
    {
        Clases.LoteMP loteMP_;
        public frmMP_WithSameLot(Clases.LoteMP ploteMP_)
        {
            InitializeComponent();
            this.loteMP_ = ploteMP_;
            lblLote.Text = ploteMP_.Lote_MP;
            foreach (int id in ploteMP_.MateriaPrimasList)
            {
                MateriaPrima Mat = new MateriaPrima();
                if (Mat.RecuperarRegistroFromID_RM(id))
                {
                    dsMP_Lotes.mp_mismo_loteRow row1 = dsMP_Lotes1.mp_mismo_lote.Newmp_mismo_loteRow();
                    row1.idmp = Mat.IdMP_ACS;
                    row1.nombre = Mat.Name;
                    row1.nombre_comercial = Mat.NameComercial;
                    row1.codigo = Mat.Codigo;
                    row1.code_sap = Mat.CodeMP_SAP;
                    dsMP_Lotes1.mp_mismo_lote.Addmp_mismo_loteRow(row1);
                    dsMP_Lotes1.AcceptChanges();
                }
            }
        }

        public string NameMaterialselected { get; internal set; }
        public object IdMP_Selected { get; internal set; }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsMP_Lotes.mp_mismo_loteRow)gridView.GetFocusedDataRow();
            IdMP_Selected = row.idmp;
            NameMaterialselected = row.nombre_comercial;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}