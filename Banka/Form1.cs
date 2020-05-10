using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        decimal bakiye = 1000;

        private void Form1_Load(object sender, EventArgs e)
        {
            label_bakiye.Text = bakiye.ToString("c2");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bakiye += yatirilacak_tutar.Value;
            label_bakiye.Text = bakiye.ToString("c2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cekilecek_tutar.Value <= bakiye)
            {
                bakiye -= cekilecek_tutar.Value;
                label_bakiye.Text = bakiye.ToString("c2");
            }
            else
            {
                MessageBox.Show("Yeterli bakiye yok");
            }
        }
    }
}