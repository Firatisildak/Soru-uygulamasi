using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soru_uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru = 0, yanlıs = 0;
        
        private void btna_Click(object sender, EventArgs e)
        {
            btnsonrakisoru.Enabled = true;
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            if (btna.Text==lbdoğrucevap.Text)
            {
                dogru++;
                lbdoğrusayısı.Text = dogru.ToString();

                pictureBox1.Visible = true;
                
            }

            else
            {
                yanlıs++;
                lbyanlışsayısı.Text = yanlıs.ToString();
                pictureBox2.Visible = true;
               
            }

            
        }

        private void btnb_Click(object sender, EventArgs e)
        {
            btnsonrakisoru.Enabled = true;
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            if (btnb.Text == lbdoğrucevap.Text)
            {
                dogru++;
                lbdoğrusayısı.Text = dogru.ToString();

                pictureBox1.Visible = true;

            }

            else
            {
                yanlıs++;
                lbyanlışsayısı.Text = yanlıs.ToString();
                pictureBox2.Visible = true;

            }
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            btnsonrakisoru.Enabled = true;
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            if (btnc.Text == lbdoğrucevap.Text)
            {
                dogru++;
                lbdoğrusayısı.Text = dogru.ToString();

                pictureBox1.Visible = true;

            }
            else
            {
                yanlıs++;
                lbyanlışsayısı.Text = yanlıs.ToString();
                pictureBox2.Visible = true;

            }
        }
        private void btnd_Click(object sender, EventArgs e)
        {
            btnsonrakisoru.Enabled = true;
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            if (btnd.Text == lbdoğrucevap.Text)
            {
                dogru++;
                lbdoğrusayısı.Text = dogru.ToString();

                pictureBox1.Visible = true;

            }

            else
            {
                yanlıs++;
                lbyanlışsayısı.Text = yanlıs.ToString();
                pictureBox2.Visible = true;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            button1.Visible = false;
            richTextBox1.Visible = true;
            btna.Visible = true;
            btnb.Visible = true;
            btnc.Visible = true;
            btnd.Visible = true;
            btnsonrakisoru.Visible = true;
            sorusayısı.Visible = true;
            label6.Visible = true;
            lbyanlış.Visible = true;
            lbyanlışsayısı.Visible = true;
            lbdoğru.Visible = true;
            lbdoğrusayısı.Visible = true;
               
        }

        private void btnsonrakisoru_Click(object sender, EventArgs e)
        {
           
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            btna.Enabled = true;
            btnb.Enabled = true;
            btnc.Enabled = true;
            btnd.Enabled = true;
            btnsonrakisoru.Enabled = false;
            
            soruno++;
            label6.Text = soruno.ToString();
            if(soruno==1)
            {
                richTextBox1.Text = "SUÇ ve CEZA romanı aşağıdaki hangi yazara ayittir?";
                btna.Text = "Victor Hugo";
                btnb.Text = "Orhan Veli";
                btnc.Text = "Fyodor Mihayloviç Dostoyevski";
                btnd.Text = "Yaşar Kemal";
                lbdoğrucevap.Text = "Fyodor Mihayloviç Dostoyevski";
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Türkiye'nin başkenti hangi ilimizdir?";
                btna.Text = "Ankara";
                btnb.Text = "İzmir";
                btnc.Text = "Hatay";
                btnd.Text = "antalya";
                lbdoğrucevap.Text = "Ankara";
            }
            if(soruno==3)
            {
                richTextBox1.Text = "Titus tüneli hangi ilimizdedir?";
                btna.Text = "Kars";
                btnb.Text = "Sivas";
                btnc.Text = "Malatya";
                btnd.Text = "Hatay";
                lbdoğrucevap.Text = "Hatay";
                btnsonrakisoru.Text = "Sonuçlar";
            }
            if(soruno==4)
            {
                btna.Enabled = false;
                btnb.Enabled = false;
                btnc.Enabled = false;
                btnd.Enabled = false;
                btnsonrakisoru.Enabled = false;
                richTextBox2.Text="doğru sayısı:" +dogru+"yanlış sayısı:"+yanlıs;
                
                richTextBox2.Visible = true;
               
            }
        }
    }
}
