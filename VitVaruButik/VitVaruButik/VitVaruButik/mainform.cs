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

           listViewData.Items.Clear();
            DoThis();

            string sql;
            MySqlCommand cmd;
            MySqlDataReader rdr;

            sql = CreateSQLQuery(txtNamn.Text, cmbCatagories.SelectedIndex, cmbVaruGrupp.SelectedIndex);            

            cmd = new MySqlCommand(sql, dbConn);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {

                string[] productData = {rdr.GetString(1), rdr.GetString(2) };

                listViewData.Items.Add(rdr.GetString(0)).SubItems.AddRange(productData);

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

        private string CreateSQLQuery(string textboxtext, int energiKlassPosition, int varugruppPosition)
        {
            string sqlQuery = "SELECT namn, energiklass, modell, tillverkare, lagersaldo, pris FROM produkt ";

            if (textboxtext != string.Empty)
            {
                sqlQuery += " WHERE namn = \"" + textboxtext + "\"";
                switch (energiKlassPosition)
                { 
                    case 0:
                        break;

                    case 1:
                        sqlQuery += " AND energiklass = \"" + "A\"";
                        break;
                    case 2:
                        sqlQuery += " AND energiklass = \"" + "B\"";
                        break;
                    case 3:
                        sqlQuery += " AND energiklass = \"" + "C\"";
                        break;
                }

                switch (varugruppPosition)
                {
                    case 0:
                        break;

                    case 1:
                        sqlQuery += " AND varugrupp = \"" + "KylloFrys\"";
                        break;
                    case 2:
                        sqlQuery += " AND varugrupp = \"" + "Kaffe\"";
                        break;
                    case 3:
                        sqlQuery += " AND varugrupp = \"" + "Tvätt\"";
                        break;
                }
            }
            else
            {
                switch (energiKlassPosition)
                {
                    case 0:
                        break;

                    case 1:
                        sqlQuery += "WHERE energiklass = \"" + "A\"";
                        break;
                    case 2:
                        sqlQuery += "WHERE energiklass = \"" + "B\"";
                        break;
                    case 3:
                        sqlQuery += "WHERE energiklass = \"" + "C\"";
                        break;
                }

                string maybeAnd = "";
                if (energiKlassPosition != 0)
                {
                    maybeAnd = "AND";
                }
                else
                {
                    maybeAnd = "WHERE";
                }

                switch (varugruppPosition)
                {
                      
                    case 0:
                        break;

                    case 1:
                        sqlQuery += maybeAnd + " varugrupp = \"" + "KylloFrys\"";
                        break;
                    case 2:
                        sqlQuery += maybeAnd + " varugrupp = \"" + "Kaffe\"";
                        break;
                    case 3:
                        sqlQuery += maybeAnd + " varugrupp = \"" + "Tvätt\"";
                        break;
                }
            }
            return sqlQuery;
        }
    }
}

