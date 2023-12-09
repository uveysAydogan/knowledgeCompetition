using System.Windows.Forms;

namespace kararYapilari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt16(textBox1.Text);
            if (sayi % 2 == 0 && sayi > 10)
            {
                label1.Text = "Sayi çift ve 10dan büyük";
            }
            else
            {
                label1.Text = "sayý tek veya 10dan küçük";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double snv1, snv2, prj, toplam;
            snv1 = Convert.ToDouble(textBox2.Text);
            snv2 = Convert.ToDouble(textBox3.Text);
            prj = Convert.ToDouble(textBox4.Text);
            toplam = (snv1 * 0.20) + (snv2 * 0.30) + (prj * 0.50);
            if (toplam >= 50)
            {
                lblSonuc.Text = "Geçtiniz";
            }
            else
            {
                lblSonuc.Text = "Kaldýnýz";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int kitapadet;
            double toplam;
            kitapadet = Convert.ToInt16(textBox5.Text);
            toplam = kitapadet * 8;
            if (kitapadet < 20)
            {
                toplam = toplam - (toplam * 0.20);
                textBox6.Text = toplam.ToString();
            }
            if (kitapadet > 20 && kitapadet < 40)
            {
                toplam = toplam - (toplam * 0.40);
                textBox6.Text = toplam.ToString();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int ayNo;
            ayNo = Convert.ToInt16(textBox8.Text);
            switch (ayNo)
            {
                case 1: label8.Text = "Ocak"; break;
                case 2: label8.Text = "Þubat"; break;
                case 3: label8.Text = "Mart"; break;
                case 4: label8.Text = "Nisan"; break;
                case 5: label8.Text = "Mayýs"; break;
                case 6: label8.Text = "Haziran"; break;
                case 7: label8.Text = "Temmuz"; break;
                case 8: label8.Text = "Aðustos"; break;
                case 9: label8.Text = "Eylül"; break;
                case 10: label8.Text = "Ekim"; break;
                case 11: label8.Text = "Kasým"; break;
                case 12: label8.Text = "Aralýk"; break;
                default: label8.Text = "Hatalý Ay"; break;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string mevsim;
            mevsim = textBox7.Text;
            switch (mevsim)
            {
                case "yaz": label10.Text = "Haziran,Temmuz,Aðustos"; break;
                case "sonbahar": label10.Text = "Eylül,Ekim,Kasým"; break;
                case "kýþ": label10.Text = "Aralýk,Ocak,Þubat"; break;
                case "ilkbahar": label10.Text = "Mart,Nisan,Mayýs"; break;
                default: label10.Text = "Manasýz Ay"; break;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2;
            sayi1 = Convert.ToDouble(sayi1TextBox.Text);
            sayi2 = Convert.ToDouble(sayi2TextBox.Text);
            string islem;
            islem = opTextBox.Text;
            switch (islem)
            {
                case "+": sonucTextBox.Text = (sayi1 + sayi2).ToString(); break;
                case "*": sonucTextBox.Text = (sayi1 * sayi2).ToString(); break;
                case "-": sonucTextBox.Text = (sayi1 - sayi2).ToString(); break;
                case "/": sonucTextBox.Text = (sayi1 / sayi2).ToString(); break;
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
        int soruNo = 0, dogruCvp = 0, yanlisCvp = 0;
        private void button11_Click(object sender, EventArgs e)
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            button11.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            soruNo = soruNo + 1;
            lblSoruNo.Text = soruNo.ToString();
            if (soruNo == 1)
            {
                richTextBox1.Text = "Cumhuriyet kaç yýlýnda kurulmuþtur?";
                btnA.Text = "1920";
                btnB.Text = "1921";
                btnC.Text = "1922";
                btnD.Text = "1923";
                lblCevapAnahtari.Text = "1923";
            }
            if (soruNo == 2)
            {
                richTextBox1.Text = "Aþaðýdaki illerimizden hangisi Ege Bölgesine ait deðildir?";
                btnA.Text = "Ýzmir";
                btnB.Text = "Balýkesir";
                btnC.Text = "Aydýn";
                btnD.Text = "Manisa";
                lblCevapAnahtari.Text = "Balýkesir";
            }
            if (soruNo == 3)
            {
                richTextBox1.Text = "'Þapkam Dolu Çiçeklerle' eseri hangi þairimize aittir?";
                btnA.Text = "Nazým Hikmet";
                btnB.Text = "Halikarnas Balýkçýsý";
                btnC.Text = "Yaþar Kemal";
                btnD.Text = "Cemal Süreyya";
                lblCevapAnahtari.Text = "Cemal Süreyya";
                button11.Text = "Sonuçlar";
            }
            if (soruNo==4)
            {
                lblSoruNo.Text = "Sonuçlar";
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                MessageBox.Show("Doðru= " + dogruCvp + " Yanlýþ= " + yanlisCvp);
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            button11.Enabled =true;

            lblKullaniciCevabi.Text = btnA.Text;

            if (lblCevapAnahtari.Text == lblKullaniciCevabi.Text)
            {
                dogruCvp++;
                lblDogru.Text = dogruCvp.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlisCvp++;
                lblYanlis.Text = yanlisCvp.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            button11.Enabled = true;

            lblKullaniciCevabi.Text = btnB.Text;

            if (lblCevapAnahtari.Text == lblKullaniciCevabi.Text)
            {
                dogruCvp++;
                lblDogru.Text = dogruCvp.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlisCvp++;
                lblYanlis.Text = yanlisCvp.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            button11.Enabled = true;

            lblKullaniciCevabi.Text = btnC.Text;

            if (lblCevapAnahtari.Text == lblKullaniciCevabi.Text)
            {
                dogruCvp++;
                lblDogru.Text = dogruCvp.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlisCvp++;
                lblYanlis.Text = yanlisCvp.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            button11.Enabled = true;

            lblKullaniciCevabi.Text = btnD.Text;

            if (lblCevapAnahtari.Text == lblKullaniciCevabi.Text)
            {
                dogruCvp++;
                lblDogru.Text = dogruCvp.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlisCvp++;
                lblYanlis.Text = yanlisCvp.ToString();
                pictureBox2.Visible = true;
            }
        }
    }
}