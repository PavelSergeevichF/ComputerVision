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

namespace OpenCV_ImageProcessingBasic
{
    public partial class ImageProcessing : Form
    {
        public ImageProcessing()
        {
            InitializeComponent();

        }

        private void ImageProcessing_Load(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image File (*.bmp,*.png)|*.bmp;*.png";
            if(DialogResult.OK == open.ShowDialog()) 
            {
                this.pictOriginal.Image = new Bitmap(open.FileName);
                CreateGraph((Bitmap)this.pictOriginal.Image,70);
            }
        }

        private void btnGray_Click(object sender, EventArgs e)
        {
            if(this.pictOriginal.Image!=null)
            {
                Bitmap coppy = new Bitmap((Bitmap)this.pictOriginal.Image);
                Method.ConvertToGray(coppy);
                this.pictResult.Image = coppy;
            }
        }

        private void btnNegative_Click(object sender, EventArgs e)
        {
            if (this.pictOriginal.Image != null)
            {
                Bitmap coppy = new Bitmap((Bitmap)this.pictOriginal.Image);
                Method.ConvertToNegative(coppy);
                this.pictResult.Image = coppy;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.pictOriginal.Image != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "JPEG File (*.jpeg)|*.jpeg";
                if(DialogResult.OK==sfd.ShowDialog()) 
                {
                    this.pictResult.Image.Save(sfd.FileName, ImageFormat.Jpeg);
                }
            }
        }
        private void CreateGraph(Bitmap pictur, int сoefficient)
        {
            GraphicsPicture graphicsPicture = new GraphicsPicture();
            graphicsPicture.DrawGraphics(GraphicsPicture.CreateGraphics(), pictur, сoefficient);
        }

        private void comboBoxCorrection_SelectedIndexChanged(object sender, EventArgs e)
        {
            CorrectionClass correction = new CorrectionClass();
            switch (comboBoxCorrection.SelectedIndex) 
            { 
                case 0:
                    break;
                case 1: 
                    break;
                case 2:
                    break;
            }
        }
    }
}
