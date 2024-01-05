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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Berberim
{
    public partial class KisiselBilgi : Form
    {
        private int musteriid1;
        public KisiselBilgi(int musteriid)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            musteriid1 = musteriid;
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-CQDL3HM;Initial Catalog=BerberimDB;Integrated Security=True");
            baglanti.Open();
            SqlCommand MusteriCagir = new SqlCommand("Select * from Musteriler", baglanti);
            SqlDataReader MusteriListesi = MusteriCagir.ExecuteReader();
            bool girisBasarili = false;
            textBoxIsim.Enabled = false;
            textBoxSoyisim.Enabled = false;
            textBoxTc.Enabled = false;
            textBoxSifr.Enabled = false;
            textBoxSifr.PasswordChar = '*';
            while (MusteriListesi.Read())
            {
                if (musteriid1 == Convert.ToInt32(MusteriListesi[0]))
                {
                    textBoxIsim.Text = MusteriListesi[1].ToString();
                    textBoxSoyisim.Text = MusteriListesi[2].ToString();
                    textBoxTc.Text = MusteriListesi[3].ToString();
                    textBoxSifr.Text = MusteriListesi[4].ToString();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Anasayfa anasayfa = new Anasayfa(musteriid1);
            anasayfa.Show();
        }

        private void pswrdbtn8_Click(object sender, EventArgs e)
        {

            pswrdbtn9.BringToFront();
            textBoxSifr.UseSystemPasswordChar = true;

        }

        private void pswrdbtn9_Click(object sender, EventArgs e)
        {

            pswrdbtn8.BringToFront();
            textBoxSifr.UseSystemPasswordChar = false;

        }

    }
}
