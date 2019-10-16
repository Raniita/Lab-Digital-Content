using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Practica1_ConvertImg
{
    public partial class Form1 : Form
    {
        public Bitmap init_img;
        public ImageFormat format;
        private String extension;

        public Form1()
        {
            InitializeComponent();
        }

        // Open Button
        private void button1_Click(object sender, EventArgs e)
        {   
            // Abrimos el dialogo de seleccion de archivo
            OpenFileDialog ofd = new OpenFileDialog();
            // Filtramos por lo preseleccionado en el combobox
            ofd.Filter = this.comboBox1.Text + "|" + this.comboBox1.Text;
            DialogResult dr = ofd.ShowDialog();

            if (dr == DialogResult.OK) {
                // Path of specified file
                string img_path = ofd.FileName;

                // Saving img on bitmap
                try
                {
                    init_img = new Bitmap(img_path);
                    this.pictureBox1.Image = init_img;
                    var init_img_size = new FileInfo(img_path).Length; 
                    this.label1.Text = "Size: " + init_img_size.ToString();
                    this.label3.Text = "Image loaded!";
                    
                }
                catch(ArgumentException)
                {
                    // La imagen no tiene info o es null
                    MessageBox.Show("Error. Image is null");
                }
            }
        }

        // Save button
        private void button2_Click(object sender, EventArgs e)
        {
            // Abrimos el dialogo
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = this.comboBox2.Text + "|" + this.comboBox2.Text;
            DialogResult dr = sfd.ShowDialog();

            if (dr == DialogResult.OK)
            {
                string new_img_path = sfd.FileName;
                extension = System.IO.Path.GetExtension(sfd.FileName);
                switch (extension)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                    case ".gif":
                        format = ImageFormat.Gif;
                        break;
                    case ".tiff":
                        format = ImageFormat.Tiff;
                        break;
                }

                this.pictureBox1.Image.Save(sfd.FileName, format);
                this.label3.Text = "Image saved!";
                var new_img_size = new FileInfo(new_img_path).Length;
                this.label2.Text = "Size: " + new_img_size.ToString();
            }
        }
    }
}
