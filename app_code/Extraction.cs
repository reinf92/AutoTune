using System.Drawing;
using Tesseract;
using System.Windows.Forms;

namespace AutoTune
{
    class Extraction
    {
        const int PICTURE_BOX_WIDTH = 230;
        const int PICTURE_BOX_HEIGHT = 70;

        public Bitmap Capture()
        {
            Bitmap image = new Bitmap(PICTURE_BOX_WIDTH, PICTURE_BOX_HEIGHT);
            Graphics graphics = Graphics.FromImage(image);
            Size size = new Size(PICTURE_BOX_WIDTH, PICTURE_BOX_HEIGHT);

            graphics.CopyFromScreen(3850, 60, 0, 0, size);
            graphics.Dispose();            

            return image;
        }

        public Page Render(PictureBox box)
        {
            Bitmap image = new Bitmap(PICTURE_BOX_WIDTH, PICTURE_BOX_HEIGHT);
            Graphics graphics = Graphics.FromImage(image);
            Size size = new Size(PICTURE_BOX_WIDTH, PICTURE_BOX_HEIGHT);

            graphics.CopyFromScreen(3850, 60, 0, 0, size);
            graphics.Dispose();

            box.Image = image;

            TesseractEngine ocr = new TesseractEngine("./tessdata", "eng", EngineMode.TesseractAndCube);
            Page page = ocr.Process(image);

            return page;
        }

        
    }
}
