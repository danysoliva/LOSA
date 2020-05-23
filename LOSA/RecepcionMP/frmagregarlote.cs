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
using LOSA.Tools;
using ACS.Classes;
using LOSA.Clases;
using System.Data.SqlClient;


namespace LOSA.RecepcionMP
{
    public partial class frmagregarlote : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();

        public frmagregarlote(int id_ingreso, int numero_referencia)
        {
            InitializeComponent();
            Load_Data();

        }
        public void Load_Data()
        {
            string query = @"";
            SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                }

            }
            catch (Exception ex)
            {
                
            }
        }
    }
}