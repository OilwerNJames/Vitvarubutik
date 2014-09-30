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

          //  listViewData.Clear();
            DoThis();

            string sql;
            MySqlCommand cmd;
            MySqlDataReader rdr;

            if (cmbVaruGrupp.Text == "Alla" && cmbCatagories.Text != "Alla")
            {
                if (txtNamn.Text != string.Empty && cmbCatagories.Text != "Alla")
                    sql = ("SELECT namn, energiklass, varugrupp FROM produkt WHERE energiklass = " + "'" + cmbCatagories.Text + "'" + "AND namn = '" + txtNamn.Text + "'");
                
                else if (cmbCatagories.Text != "Alla")
                    sql = "SELECT namn, energiklass, varugrupp FROM produkt WHERE energiklass  = " + "'" + cmbCatagories.Text + "'";
                
                else if (cmbCatagories.Text == "Alla" && txtNamn.Text != string.Empty)
                    sql = ("SELECT varugrupp, energiklass, namn FROM produkt WHERE namn = '" + txtNamn.Text + "'");
               
                else
                    sql = "SELECT varugrupp, namn, produkt FROM produkt";
            }
            else if (cmbVaruGrupp.Text != "Alla" && cmbCatagories.Text == "Alla")
            {
                if (txtNamn.Text == string.Empty)
                    sql = ("SELECT varugrupp, namn, energiklass FROM produkt WHERE varugrupp = '" + cmbVaruGrupp.Text + "'");
                
                else if (txtNamn.Text != string.Empty)
                    sql = ("SELECT varugrupp, namn, energiklass FROM produkt WHERE varugrupp = '" + cmbVaruGrupp.Text + "'" + " AND namn = '" + txtNamn.Text + "'");
                
                else
                    sql = "SELECT varugrupp, namn, produkt FROM produkt";
                
            }
           
            else if (cmbVaruGrupp.Text != "Alla" && cmbCatagories.Text != "Alla")
            {
                if (txtNamn.Text == string.Empty)
                    sql = "SELECT varugrupp, namn, energiklass FROM produkt WHERE varugrupp = '" + cmbVaruGrupp.Text + "' AND energiklass = '" + cmbCatagories.Text + "'";
                
                else if (txtNamn.Text != string.Empty)
                    sql = "SELECT varugrupp, namn, energiklass FROM produkt WHERE varugrupp = '" + cmbVaruGrupp.Text + "' AND energiklass = '" + cmbCatagories.Text + "' AND namn = '" + txtNamn.Text + "'";
                
                else
                    sql = "SELECT varugrupp, namn, energiklass FROM produkt";
                
            }
            
            else if (cmbVaruGrupp.Text == "Alla" && cmbCatagories.Text == "Alla")
            {
                if (txtNamn.Text == string.Empty)
                    sql = "SELECT varugrupp, namn, energiklass FROM produkt";

                else
                    sql = "SELECT varugrupp, namn, energiklass FROM produkt WHERE namn = '" + txtNamn.Text + "'";

            }
            
            else
                sql = "Select * FROM produkt";
            

            cmd = new MySqlCommand(sql, dbConn);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                string format = string.Format("{0, 0} {1, 20} {2, 40}", rdr.GetString(0), rdr.GetString(1), rdr.GetString(2));


                ListViewItem item = new ListViewItem(new[] { "1", "2", "3", "4" });
                listViewData.Items.Add(item);

            }
            updateGUI();
        }
        enum EnergiKlass
        {
            Alla,
            A,
            B,
            C,
        }
        enum VaruGrupp
        {
            Alla,
            KylloFrys,
            Kaffe,
            Tvätt,
        }
        private void updateGUI()
        {
            cmbCatagories.Items.Clear();
            cmbVaruGrupp.Items.Clear();
            foreach (var item in Enum.GetValues(typeof(EnergiKlass)))
            {
                cmbCatagories.Items.Add(item);
                cmbCatagories.SelectedIndex = 0;
            }
            foreach (var item in Enum.GetValues(typeof(VaruGrupp)))
            {
                cmbVaruGrupp.Items.Add(item);
                cmbVaruGrupp.SelectedIndex = 0;
            }
        }

    }
}

