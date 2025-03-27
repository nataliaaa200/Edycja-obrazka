using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edycja_obrazka
{
    public partial class Form1 : Form
    {
        private Bitmap originalImage = null;
        private bool isGreenFilterApplied = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            // Tworzymy okno dialogowe do wyboru pliku
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png|All Files|*.*";  
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Ładowanie obrazu do PictureBox
                pictureBox.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private void btnOnlyGreen_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image == null) return;

            if (!isGreenFilterApplied) // Jeśli filtr nie jest zastosowany, stosujemy go
            {
                originalImage = new Bitmap(pictureBox.Image); // Zapisujemy oryginalny obraz
                Bitmap bmp = new Bitmap(originalImage);

                for (int y = 0; y < bmp.Height; y++)
                {
                    for (int x = 0; x < bmp.Width; x++)
                    {
                        Color pixel = bmp.GetPixel(x, y);

                        if (!(pixel.G > pixel.R && pixel.G > pixel.B))
                        {
                            bmp.SetPixel(x, y, Color.Black);
                        }
                    }
                }
                pictureBox.Image = bmp;
                isGreenFilterApplied = true;
            }
            else // Jeśli filtr jest już zastosowany, przywracamy oryginalny obraz
            {
                pictureBox.Image = new Bitmap(originalImage);
                isGreenFilterApplied = false;
            }
        }
    }
}
