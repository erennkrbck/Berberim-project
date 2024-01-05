using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Berberim
{
    public partial class Anasayfa : Form
    {
        private int musteriid1;
        public int randevuid;
        public Anasayfa(int musteriid)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            panelRandevu.Click += panelRandevu_Click;
            panelBilgi.Click += panelBilgi_Click;
            panelGecmis.Click += panelGecmis_Click;

            musteriid1 = musteriid;
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-CQDL3HM;Initial Catalog=BerberimDB;Integrated Security=True");
            baglanti.Open();
            SqlCommand RandevuCagir = new SqlCommand("Select * from Randevu", baglanti);
            SqlDataReader RandevuListesi = RandevuCagir.ExecuteReader();
            bool girisBasarili = false;
            string randevusaat = "";
            string randevutarih = "";
            int i = -1;
            List<int> berberIdListesi = new List<int>();
            List<string> randevuTarihListesi = new List<string>();
            List<string> randevusaatListesi = new List<string>();
            List<int> randevuIdListesi = new List<int>();
            while (RandevuListesi.Read())
            {
                if (musteriid == Convert.ToInt32(RandevuListesi[2]) && Convert.ToInt32(RandevuListesi[13]) == 4)
                {
                    randevusaat = RandevuListesi[3].ToString();
                    randevusaatListesi.Add(randevusaat);
                    string Randevutarih = RandevuListesi[4].ToString();
                    randevutarih = Randevutarih.Split(' ')[0];
                    randevuTarihListesi.Add(randevutarih);
                    int berberid = Convert.ToInt32(RandevuListesi[1]);
                    berberIdListesi.Add(berberid);
                    int randevuid = Convert.ToInt32(RandevuListesi[0]);
                    randevuIdListesi.Add(randevuid);
                }
            }
            baglanti.Close();
            baglanti.Open();

            SqlCommand BerberCagir = new SqlCommand("Select * from Berberler", baglanti);
            SqlDataReader BerberListesi = BerberCagir.ExecuteReader();
            int k = -1;
            while (BerberListesi.Read())
            {
                int berberId = Convert.ToInt32(BerberListesi[0]);

                if (berberIdListesi.Contains(berberId))
                {
                    int index = 0;

                    while ((index = berberIdListesi.IndexOf(berberId, index)) != -1)
                    {
                        i++;
                        string berberAdi = BerberListesi[1].ToString();
                        string randevuSaati = randevusaatListesi[index];
                        string randevutarihi = randevuTarihListesi[index];
                        int randevuid = randevuIdListesi[index];
                        PanelOlusturma(berberAdi, randevuSaati, randevutarihi, i, berberId, randevuid);

                        index++;
                    }
                }

            }
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {

        }
        private void PanelOlusturma(string berberadi, string randevusaat, string randevutarih, int i, int berberid, int randevuid)
        {
            Panel panel = new Panel();
            panel.Text = berberadi;
            panel.Width = 295;
            panel.Height = 145;
            panel.BackColor = Color.Beige;
            panel.Location = new Point((i % 2) * 295, (i / 2) * 145);
            panel.BorderStyle = BorderStyle.FixedSingle;
            panelAktif.Controls.Add(panel);

            Label label = new Label();
            label.Text = $"Berber Adı: {berberadi}\nTarih: {randevutarih}\nSaat:{randevusaat}";
            label.AutoSize = true;
            label.Font = new System.Drawing.Font("Tahoma", 10, System.Drawing.FontStyle.Bold);
            label.Location = new Point(15, 15);
            label.Padding = new Padding(0, 0, 0, 5);
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Controls.Add(label);

            PictureBox picturebox = new PictureBox();
            picturebox.Location = new Point(panel.Width - picturebox.Width - 175, panel.Height - picturebox.Height);
            picturebox.SizeMode = PictureBoxSizeMode.Zoom;
            string imagePath = "C:\\Users\\MONSTER\\OneDrive\\Masaüstü\\berberim - final project\\Berberim\\WinFormsApp1\\images\\buyutec.png";
            Image image = Image.FromFile(imagePath);
            picturebox.Image = image;
            picturebox.Width = 35;
            picturebox.Height = 35;
            picturebox.Click += (sender, e) => { PictureBoxClick(randevuid); };
            panel.Controls.Add(picturebox);
            picturebox.Cursor = Cursors.Hand;

            System.Windows.Forms.Button buton = new System.Windows.Forms.Button();
            buton.Size = new System.Drawing.Size(100, 30);
            buton.Text = "İptal Et";
            buton.Font = new System.Drawing.Font("Tahoma", 10, System.Drawing.FontStyle.Regular);
            buton.Cursor = Cursors.Hand;
            buton.Location = new Point(panel.Width - buton.Width - 10, panel.Height - buton.Height - 10);
            buton.Click += (sender, e) => { PaneliSil(panel, berberid, randevutarih, randevusaat); };
            buton.FlatStyle = FlatStyle.System;
            buton.MouseEnter += (sender, e) =>
            {
                buton.BackColor = Color.LightGray;
            };

            buton.MouseLeave += (sender, e) =>
            {
                buton.BackColor = SystemColors.Control;
            };
            panel.Controls.Add(buton);


            panelAktif.AutoScroll = true;
        }
        private void PictureBoxClick(int randevuid)
        {
            this.Close();
            RandevuBilgi randevubilgi = new RandevuBilgi(randevuid);
            randevubilgi.Show();
        }
        private void PaneliSil(Panel panel, int berberid, string randevutarih, string randevusaat)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-CQDL3HM;Initial Catalog=BerberimDB;Integrated Security=True");
            baglanti.Open();
            SqlCommand RandevuCagir = new SqlCommand("SELECT * FROM Randevu", baglanti);
            SqlDataReader RandevuListesi = RandevuCagir.ExecuteReader();
            while (RandevuListesi.Read())
            {
                string bulunantarih = RandevuListesi[4].ToString();
                string[] tarihVeSaat = bulunantarih.Split(' ');
                string tarih = tarihVeSaat[0];
                if (berberid == Convert.ToInt32(RandevuListesi[1]) && randevusaat == RandevuListesi[3].ToString() && randevutarih == tarih)
                {
                    randevuid = Convert.ToInt32(RandevuListesi[0]);
                }
            }

            baglanti.Close();
            baglanti.Open();
            using (SqlCommand cmd = new SqlCommand("UPDATE Randevu SET DurumID = 2 WHERE RandevuID = @RandevuID", baglanti))
            {
                cmd.Parameters.AddWithValue("@RandevuID", randevuid);
                cmd.ExecuteNonQuery();
            }
            panelAktif.Controls.Remove(panel);
            this.Close();
            Anasayfa anasayfa = new Anasayfa(musteriid1);
            anasayfa.Show();

        }

        private void panelRandevu_Click(object sender, EventArgs e)
        {
            this.Close();
            Randevu randevu = new Randevu(musteriid1);
            randevu.Show();
        }
        private void panelBilgi_Click(object sender, EventArgs e)
        {
            this.Close();
            KisiselBilgi kisiselbilgi = new KisiselBilgi(musteriid1);
            kisiselbilgi.Show();
        }
        private void panelGecmis_Click(object sender, EventArgs e)
        {
            this.Close();
            GecmisRandevu gecmisrandevu = new GecmisRandevu(musteriid1);
            gecmisrandevu.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
            Randevu randevu = new Randevu(musteriid1);
            randevu.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
            Randevu randevu = new Randevu(musteriid1);
            randevu.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();
            Randevu randevu = new Randevu(musteriid1);
            randevu.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            KisiselBilgi kisiselbilgi = new KisiselBilgi(musteriid1);
            kisiselbilgi.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Randevu randevu = new Randevu(musteriid1);
            randevu.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
            Giris giris = new Giris();
            giris.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
            GecmisRandevu gecmisrandevu = new GecmisRandevu(musteriid1);
            gecmisrandevu.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.Close();
            GecmisRandevu gecmisrandevu = new GecmisRandevu(musteriid1);
            gecmisrandevu.Show();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            this.Close();
            GecmisRandevu gecmisrandevu = new GecmisRandevu(musteriid1);
            gecmisrandevu.Show();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            this.Close();
            GecmisRandevu gecmisrandevu = new GecmisRandevu(musteriid1);
            gecmisrandevu.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            GecmisRandevu gecmisrandevu = new GecmisRandevu(musteriid1);
            gecmisrandevu.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            KisiselBilgi kisiselbilgi = new KisiselBilgi(musteriid1);
            kisiselbilgi.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
            KisiselBilgi kisiselbilgi = new KisiselBilgi(musteriid1);
            kisiselbilgi.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Close();
            KisiselBilgi kisiselbilgi = new KisiselBilgi(musteriid1);
            kisiselbilgi.Show();
        }
    }
}
