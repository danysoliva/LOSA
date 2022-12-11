using ACS.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.MigracionACS.RRHH.Encuesta
{
    public partial class frmNewAccesoEncuesta : Form
    {
        public frmNewAccesoEncuesta()
        {
            InitializeComponent();
        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            int total = Convert.ToInt32(spinEditCantidad.EditValue);
            int centinela = 0;
            
            while (centinela < total)
            {
                string codigo = "";
                for (int i = 0; i <= 1; i++)
                {
                    var guid = Guid.NewGuid();
                    var justNumbers = new String(guid.ToString().Where(Char.IsDigit).ToArray());
                    var seed = int.Parse(justNumbers.Substring(0, 4));

                    var random = new Random(seed);
                    var value = random.Next(0, 5);

                    //Console.WriteLine($"Iteración {i} - semilla {seed} - valor {value}");
                    //Console.WriteLine(i.ToString() + seed.ToString() + value.ToString());
                    codigo = i.ToString() + seed.ToString() + value.ToString();
                }

                //
                DataOperations dp = new DataOperations();
                string Query = @"sp_encuesta_valida_codigo_available";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringAMS);

                try
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(Query, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigo", codigo);
                    bool Used = Convert.ToBoolean(cmd.ExecuteScalar());

                    while (Used)
                    {
                        var guid = Guid.NewGuid();
                        var justNumbers = new String(guid.ToString().Where(Char.IsDigit).ToArray());
                        var seed = int.Parse(justNumbers.Substring(0, 4));

                        var random = new Random(seed);
                        var value = random.Next(0, 5);

                        //Console.WriteLine($"Iteración {i} - semilla {seed} - valor {value}");
                        //Console.WriteLine(i.ToString() + seed.ToString() + value.ToString());
                        codigo = seed.ToString() + value.ToString();
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@codigo", codigo);
                        Used = Convert.ToBoolean(cmd.ExecuteScalar());
                    }

                    textEdit1.Text = codigo;

                    //Insert the code
                    SqlCommand cmd1 = new SqlCommand("dbo.sp_insert_new_code_access_enc_V2", cn);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@code", codigo);
                    cmd1.ExecuteNonQuery();

                    cn.Close();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);
                }
                centinela++;
            }
            

        }
    }
}
