using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VitVaruButik
{
    public partial class DetaliedForm : Form
    {
        public DetaliedForm(string artNr)
        {
            InitializeComponent();
            connectToMySql();
            this.artNr = artNr;
            Start();

        }

        public string artNr;
        MySqlConnection dbConn;
        string[] theData;

        private void connectToMySql()
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

        private void search()
        {
            connectToMySql();

            string sql;
            MySqlCommand cmd;
            MySqlDataReader rdr;

            sql = "select * from produkt where artikelnummer=\"" + artNr + "\"";

            cmd = new MySqlCommand(sql, dbConn);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {

                string[] productData = { rdr.GetString(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3), rdr.GetString(4), rdr.GetString(5), rdr.GetString(6), rdr.GetString(7) };
                theData = productData;
            }

           
        }

        public void Start()
        {

            search();
            labelArtikelNummer.Text = theData[0];
            labelProduktNamn.Text = theData[1];
            labelProduktEnergiklass.Text = theData[7];
            labelProduktPris.Text = theData[2];
            labelProduktTillverkare.Text = theData[3];
            labelProduktModell.Text = theData[4];
            produktBeskrivning.Text = theData[5];
            labelProduktLagersaldo.Text = theData[6];

        }


    }
}
