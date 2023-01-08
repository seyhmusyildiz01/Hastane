using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane
{
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }
        //asdasdasd
        private void FormGiris_Load(object sender, EventArgs e)
        {
            FormSekreter formSekreter = new FormSekreter();
            formSekreter.Show();
            FormHastaEkleSilGüncelle formHastaEkleSilGüncelle = new FormHastaEkleSilGüncelle();
            formHastaEkleSilGüncelle.Show();
            FormBolumEkle formBolumEkle = new FormBolumEkle();
            formBolumEkle.Show();

        }
        
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
