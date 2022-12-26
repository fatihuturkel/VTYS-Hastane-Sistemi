using System;
using System.Windows.Forms;

namespace hastane_deneme_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //open doctor form
            Doktor doktor = new Doktor();
            doktor.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sigorta sigorta = new sigorta();
            sigorta.Show();
        }

        private void ilac_Click(object sender, EventArgs e)
        {
            ilac ilac = new ilac();
            ilac.Show();

        }

        private void hasta_Click(object sender, EventArgs e)
        {
            Hastacs hasta = new Hastacs();
            hasta.Show();
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            ekipman ekipman = new ekipman();
            ekipman.Show();

        }

        private void hemsire_button_Click(object sender, EventArgs e)
        {
            Hemsire hemsire = new Hemsire();
            hemsire.Show();
        }

        private void islem_Click(object sender, EventArgs e)
        {
            islem islem = new islem();
            islem.Show();
        }

        private void randevu_button_Click(object sender, EventArgs e)
        {
            Randevu randevu = new Randevu();
            randevu.Show();
        }

        private void Tedavi_button_Click(object sender, EventArgs e)
        {
            Tedavi tedavi = new Tedavi();
            tedavi.Show();
        }

        private void envanter_Click(object sender, EventArgs e)
        {
            envanter envanter = new envanter();
            envanter.Show();
        }

        private void duyurular_Click(object sender, EventArgs e)
        {
            duyurular duyurular = new duyurular();
            duyurular.Show();
        }

        private void gorusoneri_Click(object sender, EventArgs e)
        {
            gorusoneri gorusoneri = new gorusoneri();
            gorusoneri.Show();
        }

        private void Recete_Click(object sender, EventArgs e)
        {
            Recete recete = new Recete();
            recete.Show();
        }
    }
}
