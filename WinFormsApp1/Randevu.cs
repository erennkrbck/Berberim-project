using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Berberim
{
    public partial class Randevu : Form
    {

        List<string> time = new List<string>();
        List<string> timecopy = new List<string>();

        private int musteriid1 = -1;
        public int berberid = -1;
        public int sackesimi = -1;
        public int sakalkesimi = -1;
        public int agda = -1;
        public int fon = -1;
        public int sacboyama = -1;
        public int sacyikama = -1;
        public int yuzbakimi = -1;
        public Randevu(int musteriid)
        {

            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            panel2.Hide();
            musteriid1 = musteriid;
        }


        public string secilenTarih;

        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-CQDL3HM;Initial Catalog=BerberimDB;Integrated Security=True");

            string BerberAdi = comboBoxBerber.Text;
            string RandevuSaat = comboBoxSaat.Text;
            DateTime RandevuTarih = monthCalendar1.SelectionRange.Start;
            string RandevuTarihString = RandevuTarih.ToString("dd-MM-yyyy");


            if (!checkBox1.Checked && !checkBox2.Checked && !checkBox3.Checked && !checkBox4.Checked && !checkBox5.Checked && !checkBox6.Checked && !checkBox7.Checked)
            {
                MessageBox.Show("Lütfen bir işlem seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                baglanti.Open();
                int berberid = -1;
                SqlCommand BerberCagir = new SqlCommand("SELECT * FROM Berberler", baglanti);
                SqlDataReader BerberListesi = BerberCagir.ExecuteReader();
                while (BerberListesi.Read())
                {
                    if (BerberAdi == BerberListesi["BerberAdi"].ToString())
                    {
                        berberid = Convert.ToInt32(BerberListesi["BerberID"]);
                    }
                }
                baglanti.Close();
                baglanti.Open();
                bool sackesim = checkBox1.Checked;
                bool sakalkesim = checkBox7.Checked;
                bool agda = checkBox3.Checked;
                bool sacboyama = checkBox4.Checked;
                bool sacyikama = checkBox5.Checked;
                bool yuzbakim = checkBox6.Checked;
                bool fon = checkBox2.Checked;
                string[] toplamfiyatbolunmus = textToplamFiyat.Text.Split(' ');
                int toplamtutar = Convert.ToInt32(toplamfiyatbolunmus[0]);
                SqlCommand Ekle = new SqlCommand("Insert into Randevu (BerberID,MusteriID,RandevuSaat,RandevuTarih,SacKesim,SakalKesim,Agda,SacBoyama,SacYikama,YuzBakim,Fon,ToplamTutar,DurumID)\r\nValues (" + berberid + "," + musteriid1 + "," + "'" + RandevuSaat + "'" + "," + "'" + RandevuTarih + "'" + "," + "'" + sackesim + "'" + "," + "'" + sakalkesim + "'" + "," + "'" + agda + "'" + "," + "'" + sacboyama + "'" + "," + "'" + sacyikama + "'" + "," + "'" + yuzbakim + "'" + "," + "'" + fon + "'" + "," + toplamtutar + " , 4)", baglanti);
                Ekle.ExecuteNonQuery();
                MessageBox.Show("Ödemeniz Başarıyla Alınmıştır.", "Ödeme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                baglanti.Close();
                this.Hide();
                Anasayfa anasayfa = new Anasayfa(musteriid1);
                anasayfa.Show();
            }
        }

        private void Randevu_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-CQDL3HM;Initial Catalog=BerberimDB;Integrated Security=True");
            baglanti.Open();
            SqlCommand SehirCagir = new SqlCommand("SELECT * FROM Sehirler", baglanti);
            SqlDataReader SehirListesi = SehirCagir.ExecuteReader();
            while (SehirListesi.Read())
            {
                comboBoxSehir.Items.Add(SehirListesi["SehirAdi"].ToString());
            }
            time.Add("09:00");
            time.Add("10:00");
            time.Add("11:00");
            time.Add("12:00");
            time.Add("13:00");
            time.Add("14:00");
            time.Add("15:00");
            time.Add("16:00");
            time.Add("17:00");
            time.Add("18:00");
            time.Add("19:00");
            time.Add("20:00");
            time.Add("21:00");

            monthCalendar1.MinDate = DateTime.Now.AddDays(1);

        }

        private void comboBoxSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxIlce.DroppedDown = true;
            comboBoxIlce.Items.Clear();
            comboBoxBerber.Items.Clear();
            string secilensehiradi = comboBoxSehir.SelectedItem.ToString();
            int secilensehirid = -1;
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-CQDL3HM;Initial Catalog=BerberimDB;Integrated Security=True");

            baglanti.Open();

            SqlCommand SehirCagir = new SqlCommand("SELECT * FROM Sehirler", baglanti);
            SqlDataReader SehirListesi = SehirCagir.ExecuteReader();
            while (SehirListesi.Read())
            {
                string sehiradi = SehirListesi[1].ToString();
                if (sehiradi == secilensehiradi)
                {
                    secilensehirid = Convert.ToInt32(SehirListesi[0]);
                }
            }
            baglanti.Close();
            baglanti.Open();
            SqlCommand IlceCagir = new SqlCommand("SELECT * FROM İlceler", baglanti);
            SqlDataReader IlceListesi = IlceCagir.ExecuteReader();
            while (IlceListesi.Read())
            {
                int ilcesehirid = Convert.ToInt32(IlceListesi[2]);
                if (ilcesehirid == secilensehirid)
                {
                    comboBoxIlce.Items.Add(IlceListesi["IlceAdi"].ToString());
                }
            }
            comboBoxIlce.Text = "";
            comboBoxBerber.Text = "";
            comboBoxSaat.Text = "";
        }

        private void comboBoxIlce_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxBerber.DroppedDown = true;
            comboBoxBerber.Items.Clear();
            string secilenilceadi = comboBoxIlce.SelectedItem.ToString();
            int secilenilceid = -1;
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-CQDL3HM;Initial Catalog=BerberimDB;Integrated Security=True");

            baglanti.Open();

            SqlCommand IlceCagir = new SqlCommand("SELECT * FROM İlceler", baglanti);
            SqlDataReader IlceListesi = IlceCagir.ExecuteReader();
            while (IlceListesi.Read())
            {
                string ilceadi = IlceListesi[1].ToString();
                if (ilceadi == secilenilceadi)
                {
                    secilenilceid = Convert.ToInt32(IlceListesi[0]);
                }
            }

            baglanti.Close();
            baglanti.Open();

            SqlCommand BerberCagir = new SqlCommand("SELECT * FROM Berberler", baglanti);
            SqlDataReader BerberListesi = BerberCagir.ExecuteReader();
            while (BerberListesi.Read())
            {
                int berberilceID = Convert.ToInt32(BerberListesi[2]);
                if (berberilceID == secilenilceid)
                {
                    comboBoxBerber.Items.Add(BerberListesi["BerberAdi"].ToString());
                }

            }
            comboBoxBerber.Text = "";
            comboBoxSaat.Text = "";
        }

        private void comboBoxBerber_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilenberberadi = comboBoxBerber.SelectedItem.ToString();
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-CQDL3HM;Initial Catalog=BerberimDB;Integrated Security=True");
            baglanti.Open();
            SqlCommand BerberCagir = new SqlCommand("SELECT * FROM Berberler", baglanti);
            SqlDataReader BerberListesi = BerberCagir.ExecuteReader();
            while (BerberListesi.Read())
            {
                if (secilenberberadi == BerberListesi[1].ToString())
                {
                    berberid = Convert.ToInt32(BerberListesi[0]);
                    sackesimi = Convert.ToInt32(BerberListesi[4]);
                    sakalkesimi = Convert.ToInt32(BerberListesi[3]);
                    agda = Convert.ToInt32(BerberListesi[5]);
                    fon = Convert.ToInt32(BerberListesi[6]);
                    sacboyama = Convert.ToInt32(BerberListesi[7]);
                    sacyikama = Convert.ToInt32(BerberListesi[8]);
                    yuzbakimi = Convert.ToInt32(BerberListesi[9]);

                    checkBox1.Text = "Saç Kesim \n" + sackesimi + " TL";
                    checkBox2.Text = "Fön \n" + fon + " TL";
                    checkBox3.Text = "Ağda \n" + agda + " TL";
                    checkBox4.Text = "Saç Boyama \n" + sacboyama + " TL";
                    checkBox5.Text = "Saç Yıkama \n" + sacyikama + " TL";
                    checkBox6.Text = "Yüz Bakım \n" + yuzbakimi + " TL";
                    checkBox7.Text = "Sakal Kesim \n" + sakalkesimi + " TL";
                }

            }

            comboBoxSaat.Text = "";
            monthCalendar1.SetDate(DateTime.Now.AddDays(1));
            DateTime suankiZaman = DateTime.Now.AddDays(1);
            baglanti.Close();

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            secilenTarih = e.Start.ToShortDateString();

            DateTime rndvdaSecilenTarih = monthCalendar1.SelectionStart.Date;

            comboBoxSaat.Text = "";
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-CQDL3HM;Initial Catalog=BerberimDB;Integrated Security=True");
            comboBoxSaat.Items.Clear();
            timecopy.Clear();
            timecopy.AddRange(time);
            baglanti.Open();
            SqlCommand RandevuCagir = new SqlCommand("SELECT * FROM Randevu", baglanti);
            SqlDataReader RandevuListesi = RandevuCagir.ExecuteReader();
            while (RandevuListesi.Read())
            {
                if (berberid == Convert.ToInt32(RandevuListesi[1]))
                {
                    string bulunansaat = RandevuListesi[3].ToString();
                    string bulunantarih = RandevuListesi[4].ToString();
                    string[] tarihVeSaat = bulunantarih.Split(' ');
                    string tarih = tarihVeSaat[0];
                    if (secilenTarih == tarih)
                    {
                        if (Convert.ToInt32(RandevuListesi[13]) == 4 )
                        {
                            if (timecopy.Contains(bulunansaat))
                            {
                                timecopy.Remove(bulunansaat);
                            }
                        }
                    }
                }
            }
            foreach (string item in timecopy)
            {
                comboBoxSaat.Items.Add(item);
            }

        }

        private void btnOdemeGec_Click(object sender, EventArgs e)
        {
            if (comboBoxSehir.SelectedIndex == -1 || comboBoxIlce.SelectedIndex == -1 || comboBoxBerber.SelectedIndex == -1 || comboBoxSaat.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen alanları doldurunuz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                panel1.Hide();
                panel2.Show();
            }
        }

        private void FiyatToplama()
        {
            int toplamfiyat = 0;
            if (checkBox1.Checked)
            {
                toplamfiyat += sackesimi;
            }

            if (checkBox2.Checked)
            {
                toplamfiyat += fon;
            }

            if (checkBox3.Checked)
            {
                toplamfiyat += agda;
            }

            if (checkBox4.Checked)
            {
                toplamfiyat += sacboyama;
            }

            if (checkBox5.Checked)
            {
                toplamfiyat += sacyikama;
            }

            if (checkBox6.Checked)
            {
                toplamfiyat += yuzbakimi;
            }

            if (checkBox7.Checked)
            {
                toplamfiyat += sakalkesimi;
            }

            textToplamFiyat.Text = toplamfiyat.ToString() + " TL";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            FiyatToplama();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            FiyatToplama();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            FiyatToplama();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            FiyatToplama();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            FiyatToplama();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            FiyatToplama();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            FiyatToplama();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Anasayfa anasayfa = new Anasayfa(musteriid1);
            anasayfa.Show();
        }
    }
}