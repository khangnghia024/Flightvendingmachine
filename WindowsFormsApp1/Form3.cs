using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;




namespace WindowsFormsApp1
{
    public partial class qrpayment : Form
    {
        public qrpayment()
        {
            InitializeComponent();
            GenerateQRcode("https://www.youtube.com/watch?v=LyAL542UKLM");
        }
        private void GenerateQRcode(string text)
        {
            
            var writer = new BarcodeWriter
            {
                Format = BarcodeFormat.QR_CODE,
                Options = new EncodingOptions
                {
                    Height = 300,
                    Width = 300,
                    Margin = 0
                }
            };

            
            var matrix = writer.Encode(text);

            
            var bitmap = new Bitmap(matrix.Width, matrix.Height);
            for (int x = 0; x < matrix.Width; x++)
            {
                for (int y = 0; y < matrix.Height; y++)
                {
                    bitmap.SetPixel(x, y, matrix[x, y] ? Color.Black : Color.White);
                }
            }

            
            pictureQRBOX.Image = bitmap;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void pictureBoxQR_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
