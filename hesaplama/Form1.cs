using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayi = 0;
        int toplam = 0;
        int i = 0;

        private void btntopla_Click(object sender, EventArgs e)
        {
            sayi = Convert.ToInt32(tboxsayi.Text);

            for (i = 1; i <= sayi; i++)
            {
                toplam += i;
                listBox1.Items.Add(i);
            }
            lbl1.Text = Convert.ToString(toplam);

        }

        private void tboxsayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
