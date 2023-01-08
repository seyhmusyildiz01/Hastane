using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD

//

=======
//
>>>>>>> a39df78f70db342974166749cc7065111591e5ca
namespace Hastane
{
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }
        //3333 SAD
        private void FormGiris_Load(object sender, EventArgs e)
        {
            FormSekreter formSekreter = new FormSekreter();
            formSekreter.Show();
            FormHastaEkleSilGüncelle formHastaEkleSilGüncelle = new FormHastaEkleSilGüncelle();
            formHastaEkleSilGüncelle.Show();
            FormBolumEkle formBolumEkle = new FormBolumEkle();
            formBolumEkle.Show();
            FormDoktor formDoktor = new FormDoktor();
            formDoktor.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        { }

        private void groupBox1_Enter(object sender, EventArgs e)

        {

        }
    }
}
