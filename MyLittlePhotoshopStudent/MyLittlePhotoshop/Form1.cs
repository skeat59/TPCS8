using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace MyLittlePhotoshop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                pictureBox.Image = Image.FromFile(openFileDialog.FileName);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                pictureBox.Image.Save(saveFileDialog.FileName, ImageFormat.Png);
        }

        private void greyscaleButton_Click(object sender, EventArgs e)
        {
            pictureBox.Image = Filters.MapPixels(new Bitmap(pictureBox.Image), Filters.Greyscale);
        }

        private void pinkifyButton_Click(object sender, EventArgs e)
        {
            pictureBox.Image = Filters.MapPixels(new Bitmap(pictureBox.Image), Filters.Pinkify);
        }

        private void binarizeButton_Click(object sender, EventArgs e)
        {
            pictureBox.Image = Filters.MapPixels(new Bitmap(pictureBox.Image), Filters.Binarize);
        }

        private void invertColorsButton_Click(object sender, EventArgs e)
        {
            pictureBox.Image = Filters.MapPixels(new Bitmap(pictureBox.Image), Filters.Invert);
        }

        private void averageButton_Click(object sender, EventArgs e)
        {
            pictureBox.Image = Filters.Convolution(new Bitmap(pictureBox.Image), Filters.AverageMat);
        }

        private void gaussianButton_Click(object sender, EventArgs e)
        {
            pictureBox.Image = Filters.Convolution(new Bitmap(pictureBox.Image), Filters.GaussMat);
        }

        private void edgeDetectButton_Click(object sender, EventArgs e)
        {
            pictureBox.Image = Filters.Convolution(new Bitmap(pictureBox.Image), Filters.EdgeMat);
        }

        private void filtersSplitButton_ButtonClick(object sender, EventArgs e)
        {

        }

        private void horizontalButton_Click(object sender, EventArgs e)
        {
            pictureBox.Image = Filters.MirrorH(new Bitmap(pictureBox.Image));
        }

        private void verticalButton_Click(object sender, EventArgs e)
        {
            pictureBox.Image = Filters.MirrorV(new Bitmap(pictureBox.Image));
        }
    }
}
