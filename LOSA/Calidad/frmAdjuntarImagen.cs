using ACS.Classes;
using DevExpress.XtraEditors;
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

namespace LOSA.Calidad
{
    public partial class frmAdjuntarImagen : DevExpress.XtraEditors.XtraForm
    {
       public string full_path = "";
        public string fileName = "";
        //long id_ot = 0;
        //int id_repuesto = 0;
        //UserLogin userLogin;
        public frmAdjuntarImagen()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarArchivo_Click(object sender, EventArgs e)
        {
            try
            {
                full_path = "";
                fileName = "";

                openFileDialog1.Filter = "Image Files(*.png;*.BMP;*.JPG;*.GIF)| *.png; *.jpg;*.GIF; *.bmp";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    full_path = openFileDialog1.FileName;
                    fileName = openFileDialog1.SafeFileName;
                    //Upload( full_path, fileName);
                    txtFilePath.Text = full_path;
                    //CajaDialogo.Information("ARCHIVO CARGADO SATISFACTORIAMENTE");
                    peImagen.Image = Image.FromFile(full_path);
                }
                else
                {
                    full_path = "";
                    fileName = "";
                    txtFilePath.Text = "";
                    CajaDialogo.Error("OCURRIO UN ERROR");
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            DataOperations dp = new DataOperations();

            if (string.IsNullOrEmpty(full_path) || string.IsNullOrEmpty(fileName))
            {
                CajaDialogo.Error("DEBE DE CARGAR UNA IMAGEN");
            }
            else
            {
                this.DialogResult = DialogResult.OK;

            }
        }


    }
}