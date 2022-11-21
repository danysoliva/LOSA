using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.MigracionACS.Controles
{
    public partial class xxSeleccionLookupEdit : UserControl
    {
        public xxSeleccionLookupEdit()
        {
            InitializeComponent();
        }
        public event EventHandler OnItemSeleccionado;

        private int Index;
        private string Descripcion;

        public int ProIndex
        {
            get { return Index; }
            set { Index = value; }
        }

        private string Query;

        public string ProQuery
        {
            get { return Query; }
            set { Query = value; }
        }
        private int IdSeleccionado1;

        public int ProIdSeleccionado
        {
            get { return IdSeleccionado1; }
            set { IdSeleccionado1 = value; }
        }

        public string ProDescripcionItem
        {
            get { return Descripcion; }
            set { Descripcion = value; }
        }

        public SqlConnection ProConnection;

        public void LoadData()
        {
            try
            {
                SqlCommand cmd = new SqlCommand(Query, ProConnection);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsControles1.tab_grid.Clear();
                adat.Fill(dsControles1.tab_grid);
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            //doble click en el row seleccionado
            var gridView = (GridView)gridControl1.FocusedView;
            var actual = (dsControles.tab_gridRow)gridView.GetFocusedDataRow();
            ProIdSeleccionado = actual.id;
            ProDescripcionItem = actual.descripcion;
            OnItemSeleccionado.Invoke(sender, e);
        }

    }
}
