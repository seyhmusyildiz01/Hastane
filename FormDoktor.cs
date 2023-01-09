using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Hastane
{
    
    //değiştirildi
    
    public partial class FormDoktor : Form
    {

        public FormDoktor()
        {
            InitializeComponent();
        }

        private void FormDoktor_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Btn_pdf_Click(object sender, EventArgs e)
        {
            iTextSharp.text.Document raporum = new iTextSharp.text.Document();
            PdfWriter.GetInstance(raporum, new FileStream("C:HASTA RAPORU.Pdf ", FileMode.Create));
            raporum.AddTitle(Txt_HastaAdı.Text);
            raporum.AddCreationDate();
            
            if (raporum.IsOpen()== false)
            {
                raporum.Open();

            }
            raporum.Add(new Paragraph(Txt_HastaAdı  + Txt_DoktorGorusu.Text ));
            raporum.Close();

        }
    }
}
