using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VitVaruButik
{
    public partial class Mainform : Form
    {
        public Mainform()
        { 
            InitializeComponent();
            updateGUI();
        }

        MySqlConnection dbConn;

        public void DoThis()
        {
 

            string strConnect = "server=" + "195.178.235.60" + ";uid=" + "ad3193" + ";pwd=" + "941224" + ";database=" + "ad3193";
            try
            {

                dbConn = new MySqlConnection(strConnect);
                dbConn.Open();
                if (dbConn.State.ToString() != "Open")
                {
                    MessageBox.Show("Could not open database connection");
                    return;
                }
            }
            catch (Exception ex)  // catch on general exceptions, not specific
            {
                MessageBox.Show(ex.Message);
                return;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


            DoThis();   

            string sql;
            MySqlCommand cmd;
            MySqlDataReader rdr;
            if (cmbCatagories.Text == "A")
            {
                sql = "SELECT energiklass, namn FROM produkt WHERE energiklass = 'A'";   
            }
            else if (cmbCatagories.Text == "B")
            {
                sql = "SELECT energiklass, namn FROM produkt WHERE energiklass  = 'B'";  
            }
            else if (cmbCatagories.Text == "C")
            {
                sql = "SELECT energiklass, namn FROM produkt WHERE energiklass  = 'C'"; 
            }
            else
            {
                sql = "error";
            }
         
            cmd = new MySqlCommand(sql, dbConn);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                listView.Items.Add((rdr.GetString(0)) + "   " + rdr.GetString(1));
            }
        }

        enum EnergiKlass
        {
            A,
            B,
            C,
            D,
            E,
        }


        private void updateGUI()
        {
           foreach (var item in Enum.GetValues(typeof(EnergiKlass)))
        {
            cmbCatagories.Items.Add(item);
        }
        }
    

    
     



    }
}

