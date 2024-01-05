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
    public partial class GecmisRandevu : Form
    {
        private int durumid;
        private string durumadi;
        private int musteriid1;
        public GecmisRandevu(int musteriid)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            musteriid1 = musteriid;
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-CQDL3HM;Initial Catalog=BerberimDB;Integrated Security=True");
            baglanti.Open();
            SqlCommand RandevuCagir = new SqlCommand("Select * from Randevu", baglanti);
            SqlDataReader RandevuListesi = RandevuCagir.ExecuteReader();

            bool girisBasarili = false;
            string randevusaat = "";
            string randevutarih = "";
            int i = -1;
            List<int> DurumIdListesi = new List<int>();
            List<int> berberIdListesi = new List<int>();
            List<string> randevuTarihListesi = new List<string>();
            List<string> randevusaatListesi = new List<string>();
            while (RandevuListesi.Read())
            {
                if (musteriid == Convert.ToInt32(RandevuListesi[2]) && Convert.ToInt32(RandevuListesi[13]) != 4)
                {
                    randevusaat = RandevuListesi[3].ToString();
                    randevusaatListesi.Add(randevusaat);
                    string Randevutarih = RandevuListesi[4].ToString();
                    randevutarih = Randevutarih.Split(' ')[0];
                    randevuTarihListesi.Add(randevutarih);
                    int berberid = Convert.ToInt32(RandevuListesi[1]);
                    berberIdListesi.Add(berberid);
                    durumid = Convert.ToInt32(RandevuListesi[13]);
                    DurumIdListesi.Add(durumid);
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
                        durumid = DurumIdListesi[index];
                        if (durumid == 1) { durumadi = "Gidildi"; }
                        else if (durumid == 2) { durumadi = "İptal edildi"; }
                        else { durumadi = "Gidilmedi"; }
                        string randevuSaati = randevusaatListesi[index];
                        string randevutarihi = randevuTarihListesi[index];

                        PanelOlusturma(berberAdi, randevuSaati, randevutarihi, i, berberId, durumadi);

                        index++;
                    }
                }

            }

        }

        private void GecmisRandevu_Load(object sender, EventArgs e)
        {

        }

        private void PanelOlusturma(string berberadi, string randevusaat, string randevutarih, int i, int berberid, string durumadi)
        {
            Panel panel = new Panel();
            panel.Text = berberadi;
            panel.Width = 295;
            panel.Height = 145;
            panel.BackColor = Color.Beige;
            panel.Location = new Point((i % 2) * 295, (i / 2) * 145);
            panel.BorderStyle = BorderStyle.FixedSingle;
            panelGecmis.Controls.Add(panel);

            Label label = new Label();
            label.Text = $"Berber Adı: {berberadi}\nTarih: {randevutarih}\nSaat:{randevusaat}\nDurum:{durumadi} ";
            label.AutoSize = true;
            label.Font = new System.Drawing.Font("Tahoma", 10, System.Drawing.FontStyle.Bold);
            label.Location = new Point(15, 15);
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Controls.Add(label);
            panelGecmis.AutoScroll = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Anasayfa anasayfa = new Anasayfa(musteriid1);
            anasayfa.Show();
        }
    }
}
