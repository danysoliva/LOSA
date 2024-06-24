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

namespace ACS.MP
{
    public partial class MP_UltimoCosto_Prompt : DevExpress.XtraEditors.XtraForm
    {
        #region Variables_Globales
        DataOperations dp = new DataOperations();
        #endregion

        public MP_UltimoCosto_Prompt()
        {
            InitializeComponent();
            cargarPeriodos();
        }

        void cargarPeriodos()
        {
            try
            {
                cmb_Period.Properties.DataSource = dp.ACS_GetSelectData(@"SELECT  id, period_name period FROM    MP_Inventario_Inicial where enable = 1 order by id desc").Tables[0];
                cmb_Period.ItemIndex = 0;
            }
            catch (Exception ex) { MessageBox.Show(string.Format("Error\n\nDetalle: {0}\n\nStacktrace: {1}", ex.Message, ex.StackTrace), "Planchaste", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            if (cmb_Period.EditValue == null) { MessageBox.Show("Debe seleccionar periodo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;}

            DialogResult resultado = MessageBox.Show("¿Esta realmente seguro?, los costos serán actualizados.", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado != System.Windows.Forms.DialogResult.Yes) return;

            if (cmb_Period.EditValue != null)
            {
     
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}