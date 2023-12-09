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
                label1.Text = "Sayi �ift ve 10dan b�y�k";
            }
            else
            {
                label1.Text = "say� tek veya 10dan k���k";
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
                lblSonuc.Text = "Ge�tiniz";
            }
            else
            {
                lblSonuc.Text = "Kald�n�z";
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
                case 2: label8.Text = "�ubat"; break;
                case 3: label8.Text = "Mart"; break;
                case 4: label8.Text = "Nisan"; break;
                case 5: label8.Text = "May�s"; break;
                case 6: label8.Text = "Haziran"; break;
                case 7: label8.Text = "Temmuz"; break;
                case 8: label8.Text = "A�ustos"; break;
                case 9: label8.Text = "Eyl�l"; break;
                case 10: label8.Text = "Ekim"; break;
                case 11: label8.Text = "Kas�m"; break;
                case 12: label8.Text = "Aral�k"; break;
                default: label8.Text = "Hatal� Ay"; break;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string mevsim;
            mevsim = textBox7.Text;
            switch (mevsim)
            {
                case "yaz": label10.Text = "Haziran,Temmuz,A�ustos"; break;
                case "sonbahar": label10.Text = "Eyl�l,Ekim,Kas�m"; break;
                case "k��": label10.Text = "Aral�k,Ocak,�ubat"; break;
                case "ilkbahar": label10.Text = "Mart,Nisan,May�s"; break;
                default: label10.Text = "Manas�z Ay"; break;
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
                richTextBox1.Text = "Cumhuriyet ka� y�l�nda kurulmu�tur?";
                btnA.Text = "1920";
                btnB.Text = "1921";
                btnC.Text = "1922";
                btnD.Text = "1923";
                lblCevapAnahtari.Text = "1923";
            }
            if (soruNo == 2)
            {
                richTextBox1.Text = "A�a��daki illerimizden hangisi Ege B�lgesine ait de�ildir?";
                btnA.Text = "�zmir";
                btnB.Text = "Bal�kesir";
                btnC.Text = "Ayd�n";
                btnD.Text = "Manisa";
                lblCevapAnahtari.Text = "Bal�kesir";
            }
            if (soruNo == 3)
            {
                richTextBox1.Text = "'�apkam Dolu �i�eklerle' eseri hangi �airimize aittir?";
                btnA.Text = "Naz�m Hikmet";
                btnB.Text = "Halikarnas Bal�k��s�";
                btnC.Text = "Ya�ar Kemal";
                btnD.Text = "Cemal S�reyya";
                lblCevapAnahtari.Text = "Cemal S�reyya";
                button11.Text = "Sonu�lar";
            }
            if (soruNo==4)
            {
                lblSoruNo.Text = "Sonu�lar";
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                MessageBox.Show("Do�ru= " + dogruCvp + " Yanl��= " + yanlisCvp);
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