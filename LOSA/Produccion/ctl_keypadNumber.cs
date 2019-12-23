using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.Produccion
{
    
    public partial class ctl_keypadNumber : UserControl
    {
        string displayNumber = "";
        public ctl_keypadNumber()
        {
            InitializeComponent();
        }

        public event EventHandler OnItemSeleccionado;

        private int Index;

        private void btn1_Click(object sender, EventArgs e)
        {
            displayNumber = displayNumber+ "1" ;
           KeySeleccionado =displayNumber;
            OnItemSeleccionado.Invoke(sender, e);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            displayNumber = displayNumber+"2"  ;
            KeySeleccionado = displayNumber;
            OnItemSeleccionado.Invoke(sender, e);


        }

        private void btn3_Click(object sender, EventArgs e)
        {
            displayNumber = displayNumber+"3";
            KeySeleccionado = displayNumber;
            OnItemSeleccionado.Invoke(sender, e);


        }

        private void btn4_Click(object sender, EventArgs e)
        {

            displayNumber = displayNumber+ "4" ;
            KeySeleccionado = displayNumber;
            OnItemSeleccionado.Invoke(sender, e);

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            displayNumber = displayNumber+ "5" ;
            KeySeleccionado = displayNumber;
            OnItemSeleccionado.Invoke(sender, e);

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            displayNumber = displayNumber + "6";
            KeySeleccionado = displayNumber;
            OnItemSeleccionado.Invoke(sender, e);



        }

        private void btn7_Click(object sender, EventArgs e)
        {
            displayNumber = displayNumber + "7";
            KeySeleccionado = displayNumber;
            OnItemSeleccionado.Invoke(sender, e);

        }

      

        private string NumeroSeleccionado;
        public string KeySeleccionado
        {
            get { return NumeroSeleccionado; }
            set { NumeroSeleccionado = value; }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            displayNumber = displayNumber + "8";
            KeySeleccionado = displayNumber;
            OnItemSeleccionado.Invoke(sender, e);

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            displayNumber = displayNumber + "9";
            KeySeleccionado = displayNumber;
            OnItemSeleccionado.Invoke(sender, e);

        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            displayNumber = displayNumber + ".";
            KeySeleccionado = displayNumber;
            OnItemSeleccionado.Invoke(sender, e);

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            displayNumber = displayNumber + "0";
            KeySeleccionado = displayNumber;
            OnItemSeleccionado.Invoke(sender, e);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            displayNumber = "";
            KeySeleccionado = displayNumber;
            OnItemSeleccionado.Invoke(sender, e);

        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            displayNumber = displayNumber.Remove(displayNumber.Length-1);
            KeySeleccionado = displayNumber;
            OnItemSeleccionado.Invoke(sender, e);

        }
    }
}
