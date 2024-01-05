using System.Drawing.Drawing2D;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Berberim
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            btnSign2.Hide();
            btnBack.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();
            label11.Hide();
            panel2.Hide();

            panel1.Size = new Size(750, 450);
            panel2.Size = new Size(800, 600);

            int x = (panel1.Size.Width - title.Size.Width) / 2;
            int y = (panel1.Size.Height - title.Size.Height) / 10;
            title.Location = new Point(x, y);

            int a = panel1.Height / 6;
            int b = panel1.Width / 4;
            label1.Location = new Point(a, b);
            label2.Location = new Point(a, b + 80);
            textBox1.Location = new Point(a + 275, b);
            textBox2.Location = new Point(a + 275, b + 80);
            pswrdbtn5.Location = new Point(a + 531, b + 79);
            pswrdbtn6.Location = new Point(a + 531, b + 79);
            btnSign.Location = new Point(a + 1, b + 175);
            btnLogin.Location = new Point(a + 330, b + 175);

            int l = (panel2.Size.Width - title.Size.Width) / 2;
            int m = (panel2.Size.Height - title.Size.Height) / 16;
            title2.Location = new Point(l, m);

            int q = panel2.Height / 6;
            int z = panel2.Width / 5;
            label7.Location = new Point(q, z);
            label6.Location = new Point(q, z + 50);
            label3.Location = new Point(q, z + 100);
            label4.Location = new Point(q, z + 150);
            label5.Location = new Point(q, z + 200);
            tcbox.Location = new Point(q + 275, z);
            sifrebox2.Location = new Point(q + 275, z + 50);
            textBox3.Location = new Point(q + 275, z + 100);
            textBox4.Location = new Point(q + 275, z + 150);
            textBox5.Location = new Point(q + 275, z + 200);
            checkBox1.Location = new Point(q + 275, z + 250);
            linkLabel1.Location = new Point(q + 295, z + 250);
            pswrdbtn.Location = new Point(q + 531, z + 149);
            pswrdbtn2.Location = new Point(q + 531, z + 149);
            pswrdbtn3.Location = new Point(q + 531, z + 199);
            pswrdbtn4.Location = new Point(q + 531, z + 199);
            label8.Location = new Point(q + 575, z - 3);
            label9.Location = new Point(q + 575, z + 97);
            label10.Location = new Point(q + 575, z + 147);
            label11.Location = new Point(q + 575, z + 197);
            btnBack.Location = new Point(q, z + 325);
            btnSign2.Location = new Point(q + 350, z + 325);
            panel1.BackColor = Color.Bisque;
            panel2.BackColor = Color.Bisque;
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(label8, "Bu alan� doldurmak zorunludur!");
            toolTip1.SetToolTip(label9, "Bu alan� doldurmak zorunludur!");
            toolTip1.SetToolTip(label10, "Bu alan� doldurmak zorunludur!");
            toolTip1.SetToolTip(label11, "Bu alan� doldurmak zorunludur!");

        }

        private void Giris_Load(object sender, EventArgs e)
        {

        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            btnLogin.Hide();
            btnSign.Hide();
            btnSign2.Show();
            btnBack.Show();
            label8.Show();
            label9.Show();
            label10.Show();
            label11.Show();
            panel2.Show();
            panel1.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int musteriid = -1;
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-CQDL3HM;Initial Catalog=BerberimDB;Integrated Security=True");
            baglanti.Open();
            SqlCommand MusteriCagir = new SqlCommand("Select * from Musteriler", baglanti);
            SqlDataReader MusteriListesi = MusteriCagir.ExecuteReader();
            bool girisBasarili = false;
            while (MusteriListesi.Read())
            {
                string Musteritc = MusteriListesi[3].ToString();
                string Musterisifre = MusteriListesi[4].ToString();
                string x = textBox1.Text;
                string y = textBox2.Text;
                if (x == Musteritc && y == Musterisifre)
                {
                    musteriid = Convert.ToInt32(MusteriListesi[0]);
                    girisBasarili = true;
                    break;

                }
            }

            if (girisBasarili)
            {
                this.Hide();
                Anasayfa anasayfa = new Anasayfa(musteriid);
                anasayfa.Show();
            }
            else
            {
                MessageBox.Show("TC veya �ifre hatal�", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            baglanti.Close();
        }


        private void btnSign2_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-CQDL3HM;Initial Catalog=BerberimDB;Integrated Security=True");

            string KullaniciAdi = tcbox.Text;
            string KullaniciSoyadi = sifrebox2.Text;
            string KullaniciTc = textBox3.Text;
            string KullaniciSifre = textBox4.Text;


            if (checkBox1.Checked == false)
            {
                MessageBox.Show("S�zle�meyi Kabul Ediniz", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tcbox.Text == "")
            {
                MessageBox.Show("Zorunlu Alanlar� Doldurunuz", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBox3.Text == "" || textBox3.Text.Length < 11)
            {
                MessageBox.Show("TC Kimlik giri�i hatal�d�r.", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("Zorunlu Alanlar� Doldurunuz", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBox5.Text == "")
            {
                MessageBox.Show("Zorunlu Alanlar� Doldurunuz", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBox4.Text != textBox5.Text)
            {
                MessageBox.Show("�ifreleriniz birbiriyle uyu�muyor", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                baglanti.Open();
                SqlCommand MusteriCagir = new SqlCommand("Select * from Musteriler", baglanti);
                SqlDataReader MusteriListesi = MusteriCagir.ExecuteReader();
                bool kayitBasarili = false;
                while (MusteriListesi.Read())
                {
                    if (KullaniciTc == MusteriListesi[3].ToString())
                    {
                        MessageBox.Show("Bu TC ile kay�tl� biri bulunmaktad�r.", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        kayitBasarili = false;
                        break;
                    }
                    else
                    {

                        kayitBasarili = true;
                    }

                }
                baglanti.Close();
                if (kayitBasarili)
                {
                    baglanti.Open();
                    SqlCommand Ekle = new SqlCommand("Insert into Musteriler (MusteriIsim,MusteriSoyadi,MusteriTc,MusteriSifre)\r\nValues (" + "'" + KullaniciAdi + "'" + "," + "'" + KullaniciSoyadi + "'" + "," + KullaniciTc + "," + "'" + KullaniciSifre + "'" + ")", baglanti);
                    Ekle.ExecuteNonQuery();
                    MessageBox.Show("Kay�t ba�ar�yla ger�ekle�ti!", "Kay�t ol", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    baglanti.Close();
                    btnBack.Hide();
                    btnSign2.Hide();
                    btnLogin.Show();
                    btnSign.Show();
                    panel1.Show();
                    panel2.Hide();
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            btnBack.Hide();
            btnSign2.Hide();
            btnLogin.Show();
            btnSign.Show();
            panel1.Show();
            panel2.Hide();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.MaxLength = 11;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.MaxLength = 11;
        }

        private void pswrdbtn_Click(object sender, EventArgs e)
        {
            if (textBox4.UseSystemPasswordChar == false)
            {
                pswrdbtn2.BringToFront();
                textBox4.UseSystemPasswordChar = true;
            }
        }

        private void pswrdbtn2_Click(object sender, EventArgs e)
        {
            if (textBox4.UseSystemPasswordChar == true)
            {

                pswrdbtn.BringToFront();
                textBox4.UseSystemPasswordChar = false;
            }
        }

        private void pswrdbtn3_Click(object sender, EventArgs e)
        {
            if (textBox5.UseSystemPasswordChar == false)
            {
                pswrdbtn4.BringToFront();
                textBox5.UseSystemPasswordChar = true;
            }
        }

        private void pswrdbtn4_Click(object sender, EventArgs e)
        {
            if (textBox5.UseSystemPasswordChar == true)
            {

                pswrdbtn3.BringToFront();
                textBox5.UseSystemPasswordChar = false;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string message = "Berberim Uygulamas� Kullan�c� S�zle�mesi\r\n\r\nSon G�ncelleme Tarihi: [30.12.2023]\r\n\r\nKabul Edilme �artlar�\r\n\"Berberim\" uygulamas�n� kullanarak, a�a��daki �artlar� ve ko�ullar� kabul etmi� say�l�rs�n�z. L�tfen bu s�zle�meyi dikkatlice okuyun ve anlad���n�zdan emin olun.\r\n\r\nHizmet Kullan�m�\r\n\"Berberim\" uygulamas�, kullan�c�lara berber randevular� olu�turma, de�i�tirme ve iptal etme gibi hizmetleri sunar. Uygulamay� kullanarak, ki�isel bilgilerinizi g�ncellemeniz ve do�ru bilgiler sa�laman�z sorumlulu�unuzdad�r.\r\n\r\nGizlilik Politikas�\r\n\"Berberim\" uygulamas�n�n gizlilik politikas�n� kabul etmi� olursunuz. Bu politika, ki�isel bilgilerinizin nas�l topland���n�, kullan�ld���n� ve korundu�unu a��klar. L�tfen gizlilik politikam�z� inceleyin.\r\n\r\n�cretlendirme ve �demeler\r\nUygulama �zerinden yap�lan randevular i�in belirlenen �cretlendirme ve �deme politikas� ge�erlidir. Kullan�c�lar, bu politikay� anlam�� ve kabul etmi� say�l�rlar.\r\n\r\nKullan�c� Sorumlulu�u\r\nKullan�c�lar, \"Berberim\" uygulamas�n� yasalara uygun ve etik bir �ekilde kullanmal�d�r. Kullan�c�lar, uygulama �zerinden yap�lan ileti�imlerde sayg�l�, d�r�st ve olumlu bir dil kullanmal�d�r.\r\n\r\nHesap G�venli�i\r\nKullan�c�lar, hesaplar�na eri�im yetkilerini g�vende tutmakla sorumludur. Hesap bilgilerinin g�venli�i ve �ifrenin korunmas� kullan�c�n�n sorumlulu�undad�r.\r\n\r\nDe�i�iklikler ve G�ncellemeler\r\n\"Berberim\" uygulamas�, kullan�c� s�zle�mesini g�ncelleme hakk�n� sakl� tutar. Kullan�c�lar, g�ncellemeleri d�zenli olarak kontrol etmeli ve de�i�iklikleri kabul etmelidir.\r\n\r\n�ptal ve Sonland�rma\r\n\"Berberim\" uygulamas�, kullan�c� hesaplar�n� herhangi bir nedenle sonland�rma veya ask�ya alma hakk�n� sakl� tutar.\r\n\r\nBu s�zle�meyi kabul ederek, \"Berberim\" uygulamas�n�n kullan�m �artlar�n� anlad���n�z� ve bu �artlara uyaca��n�z� onaylam�� olursunuz.";
            string title = "berberim - T�m Haklar� Sakl�d�r. �";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.Location = new Point(
            this.ClientSize.Width / 2 - panel2.Size.Width / 2,
            this.ClientSize.Height / 2 - panel2.Size.Height / 2);
            panel2.Anchor = AnchorStyles.None;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.Location = new Point(
            this.ClientSize.Width / 2 - panel1.Size.Width / 2,
            this.ClientSize.Height / 2 - panel1.Size.Height / 2);
            panel1.Anchor = AnchorStyles.None;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void pswrdbtn5_Click_1(object sender, EventArgs e)
        {
            if (textBox2.UseSystemPasswordChar == true)
            {
                pswrdbtn6.BringToFront();
                textBox2.UseSystemPasswordChar = false;
            }
        }

        private void pswrdbtn6_Click_1(object sender, EventArgs e)
        {
            if (textBox2.UseSystemPasswordChar == false)
            {
                pswrdbtn5.BringToFront();
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void pictureBoxCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

