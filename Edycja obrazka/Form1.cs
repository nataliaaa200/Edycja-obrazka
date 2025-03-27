﻿using System;
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

        private void btnRotate_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image != null)
            {
                Image img = pictureBox.Image;
                if (rdo90.Checked) img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                if (rdo180.Checked) img.RotateFlip(RotateFlipType.Rotate180FlipNone);
                if (rdo270.Checked) img.RotateFlip(RotateFlipType.Rotate270FlipNone);
                pictureBox.Refresh();
            }
        }
    }
}
