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
            connectToMySql();
            search();
            updateGUI();
        }

        MySqlConnection dbConn;
        public void connectToMySql()
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

        private void buttonSearch_Click(object sender, EventArgs e)
        {

           listViewData.Items.Clear();
            search();

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
            KyloFrys,
            Hem,
            Tvätt,
            Städ,
            Kök,
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

        private void search()
        {
            connectToMySql();

            string sql;
            MySqlCommand cmd;
            MySqlDataReader rdr;

            sql = CreateSQLQuery(txtNamn.Text, cmbCatagories.SelectedIndex, cmbVaruGrupp.SelectedIndex);

            cmd = new MySqlCommand(sql, dbConn);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {

                string[] productData = { rdr.GetString(1), rdr.GetString(2), rdr.GetString(3), rdr.GetString(4), rdr.GetString(5), rdr.GetString(6) };

                listViewData.Items.Add(rdr.GetString(0)).SubItems.AddRange(productData);

            }

            updateGUI();
        }

        private string CreateSQLQuery(string textboxtext, int energiKlassPosition, int varugruppPosition)
        {
            string sqlQuery = "SELECT namn, energiklass, modell, tillverkare, lagersaldo, pris, artikelnummer FROM produkt ";

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
                        sqlQuery += " AND varugrupp = \"" + "KyloFrys\"";
                        break;
                    case 2:
                        sqlQuery += " AND varugrupp = \"" + "Hem\"";
                        break;
                    case 3:
                        sqlQuery += " AND varugrupp = \"" + "Tvätt\"";
                        break;
                    case 4:
                        sqlQuery += " AND varugrupp = \"" + "Städ\"";
                        break;
                    case 5:
                        sqlQuery += " AND varugrupp = \"" + "Kök\"";
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
                        sqlQuery += maybeAnd + " varugrupp = \"" + "KyloFrys\"";
                        break;
                    case 2:
                        sqlQuery += maybeAnd + " varugrupp = \"" + "Hem\"";
                        break;
                    case 3:
                        sqlQuery += maybeAnd + " varugrupp = \"" + "Tvätt\"";
                        break;
                    case 4:
                        sqlQuery += maybeAnd + " varugrupp = \"" + "Städ\"";
                        break;
                    case 5:
                        sqlQuery += maybeAnd + " varugrupp = \"" + "Kök\"";
                        break;
                }
            }
            return sqlQuery;
        }

        private void buttonOpenProdukt_Click(object sender, EventArgs e)
        {

            string inputParam = listViewData.SelectedItems[0].SubItems[6].Text;
            DetaliedForm newDetailedForm = new DetaliedForm(inputParam);
               
             newDetailedForm.Show();


        }
    }
}

