using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sınıf_ödevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_göster_Click(object sender, EventArgs e)
        {

            if (txt_katnumarası.Text == "")
            {

                MessageBox.Show("Lütfen Bilgi Giriniz.");
            }
            else
            {

                int kat1 = 1;
                int kat2 = 2;
                int kat3 = 3;
                int kat4 = 4;
                int bilgi1 = int.Parse(txt_katnumarası.Text.ToString());

                string[] sınıf9 = new string[5];
                sınıf9[0] = "9/BT";
                sınıf9[1] = "9/A";
                sınıf9[2] = "9/B";
                sınıf9[3] = "9/C";
                sınıf9[4] = "9/M";
                string[] sınıf10 = new string[5];
                sınıf10[0] = "10/BT";
                sınıf10[1] = "10/A";
                sınıf10[2] = "10/B";
                sınıf10[3] = "10/C";
                sınıf10[4] = "10/M";
                string[] sınıf11 = new string[5];
                sınıf11[0] = "11/BT";
                sınıf11[1] = "11/A";
                sınıf11[2] = "11/B";
                sınıf11[3] = "11/C";
                sınıf11[4] = "11/M";
                string[] sınıf12 = new string[5];
                sınıf12[0] = "12/BT";
                sınıf12[1] = "12/A";
                sınıf12[2] = "12/B";
                sınıf12[3] = "12/C";
                sınıf12[4] = "12/M";

                if (bilgi1 == 1)
                {
                    for (int a = 0; a < 5; a++)
                    {
                        Sınıfllar.Items.Add(sınıf9[a]);
                    }

                }
                else if (bilgi1 == 2)
                {
                    for (int b = 0; b < 5; b++)
                    {
                        Sınıfllar.Items.Add(sınıf10[b]);
                    }
                }
                else if (bilgi1 == 3)
                {
                    for (int c = 0; c < 5; c++)
                    {
                        Sınıfllar.Items.Add(sınıf11[c]);
                    }
                }
                else if (bilgi1 == 4)
                {
                    for (int d = 0; d < 5; d++)
                    {
                        Sınıfllar.Items.Add(sınıf12[d]);
                    }
                }
                if (bilgi1 > 4 || bilgi1 < 1)
                {
                    MessageBox.Show("Lütfen 1 İle 4 Arasında Bir Sayı Giriniz.");
                }

            }




        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            Sınıfllar.Items.Clear();
        }
    }
}
