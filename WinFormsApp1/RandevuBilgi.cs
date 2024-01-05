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

namespace Berberim
{
    public partial class RandevuBilgi : Form
    {
        private int randevuid1;
        private int musteriid;
        private int toplamfiyat;
        public RandevuBilgi(int randevuid)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            randevuid1 = randevuid;
            List<string> randevuListesi = new List<string>();
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
            List<bool> randevuIcerikListesi = new List<bool>();

            while (RandevuListesi.Read())
            {
                if (randevuid1 == Convert.ToInt32(RandevuListesi[0]))
                {
                    musteriid = Convert.ToInt32(RandevuListesi[2]);
                    randevusaat = RandevuListesi[3].ToString();
                    randevusaatListesi.Add(randevusaat);
                    string Randevutarih = RandevuListesi[4].ToString();
                    randevutarih = Randevutarih.Split(' ')[0];
                    randevuTarihListesi.Add(randevutarih);
                    int berberid = Convert.ToInt32(RandevuListesi[1]);
                    berberIdListesi.Add(berberid);
                    randevuIdListesi.Add(randevuid1);
                    randevuIcerikListesi.Add((bool)RandevuListesi[5]);
                    randevuIcerikListesi.Add((bool)RandevuListesi[6]);
                    randevuIcerikListesi.Add((bool)RandevuListesi[7]);
                    randevuIcerikListesi.Add((bool)RandevuListesi[8]);
                    randevuIcerikListesi.Add((bool)RandevuListesi[9]);
                    randevuIcerikListesi.Add((bool)RandevuListesi[10]);
                    randevuIcerikListesi.Add((bool)RandevuListesi[11]);
                    toplamfiyat = Convert.ToInt32(RandevuListesi[12]);

                }
            }
            baglanti.Close();
            baglanti.Open();
            string sackesimi = randevuIcerikListesi[0] ? "✓" : "X";
            string sakalkesimi = randevuIcerikListesi[1] ? "✓" : "X";
            string agda = randevuIcerikListesi[2] ? "✓" : "X";
            string sacboyama = randevuIcerikListesi[3] ? "✓" : "X";
            string sacyikama = randevuIcerikListesi[4] ? "✓" : "X";
            string yuzbakimi = randevuIcerikListesi[5] ? "✓" : "X";
            string fon = randevuIcerikListesi[6] ? "✓" : "X";

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

                        Label label = new Label();
                        label.Text = $"Berber Adı: {berberAdi}\nTarih: {randevutarih}\nSaat:{randevusaat}\nAlınan Hizmetler:\nSaç kesimi: {sackesimi}\nSakal kesimi: {sakalkesimi}\nAgda: {agda}\nSac boyama: {sacboyama}\nSaç yıkama: {sacyikama}\nYüz bakım: {yuzbakimi}\nFön: {fon}\nToplam Tutar: {toplamfiyat}TL";
                        label.AutoSize = true;
                        label.Font = new System.Drawing.Font("Tahoma", 10, System.Drawing.FontStyle.Bold);
                        label.Location = new Point(15, 15);
                        label.Padding = new Padding(0, 0, 0, 5);
                        panel1.BorderStyle = BorderStyle.FixedSingle;
                        panel1.Controls.Add(label);

                        index++;
                    }
                }
            }
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Anasayfa anasayfa = new Anasayfa(musteriid);
            anasayfa.Show();
        }
    }
}
