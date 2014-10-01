using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VitVaruButik
{
    public partial class DetaliedForm : Form
    {
        public DetaliedForm(string namn)
        {
            InitializeComponent();
            this.namn = namn;
            Start();

        }

        public string namn;

        public void Start()
        {
            labelProduktNamn.Text = namn;
        }


    }
}
