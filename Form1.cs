using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;
using System.Threading;
using System.Runtime.InteropServices;

namespace AutoTune
{
    public partial class Form1 : Form
    {
        const int MAX_WIDTH = 234;
        const int MAX_HEIGHT = 77;

        const string FAIL = "failed";
        const string SUCCESS = "success";

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {

            Bitmap bmp = loadImage();

            ImageMapper.Image = bmp;

            

            //var ocr = new TesseractEngine("./tessdata", "eng", EngineMode.TesseractAndCube);
            //var page = ocr.Process(bmp);

            //MessageBox.Show(page.GetText());

            //if (page.GetText().Contains(SUCCESS))
            //{
            //    MessageBox.Show("good!!");
            //}else if(page.GetText().Contains(FAIL))
            //{
            //    MessageBox.Show("no!!!!");
            //}

            

        }

        public Bitmap loadImage()
        {
            Bitmap bmp = new Bitmap(MAX_WIDTH, MAX_HEIGHT);
            Graphics g = Graphics.FromImage(bmp);
            Size size = new Size(MAX_WIDTH, MAX_HEIGHT);
            g.CopyFromScreen(150, 50, 0, 0, size);
            g.Dispose();

            return bmp;
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            Thread.Sleep(3000);

            MouseController mc = new MouseController();
            mc.BuyItem((uint)Cursor.Position.X, (uint)Cursor.Position.Y);


            
        }
    }

   
}
