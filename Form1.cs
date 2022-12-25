using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void button3_Click(object sender, EventArgs e)
        {
            ilac ilac = new ilac();
            ilac.Show();
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

        private void Duyurular_Click(object sender, EventArgs e)
        {
            duyurular duyurular = new duyurular();
            duyurular.Show();
        }
        
    }
}
