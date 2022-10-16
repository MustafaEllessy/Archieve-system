using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SimpleTCP;
using System.IO;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System.Drawing.Imaging;
using System.Collections;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Ghostscript.NET;

namespace ArchieveApplication
{

    public partial class ElectronicSigning : Form
    {
        //pdf to image
        public void LoadImage(string InputPDFFile, int PageNumber)
        {
            string outImageName = MainMenu.sharedFolder + Path.GetFileNameWithoutExtension(InputPDFFile) + ".png";
           if(File.Exists(outImageName) )
                File.Delete(outImageName);
            GhostscriptPngDevice dev = new GhostscriptPngDevice(GhostscriptPngDeviceType.Png256);
            dev.GraphicsAlphaBits = GhostscriptImageDeviceAlphaBits.V_4;
            dev.TextAlphaBits = GhostscriptImageDeviceAlphaBits.V_4;
            dev.ResolutionXY = new GhostscriptImageDeviceResolution(290, 290);
            dev.InputFiles.Add(InputPDFFile);
            dev.Pdf.FirstPage = PageNumber;
            dev.Pdf.LastPage = PageNumber;
            dev.CustomSwitches.Add("-dDOINTERPOLATE");
            dev.OutputPath = outImageName;
            dev.Process();
        }
        public void ImageToPdf()
        {
            Document document = new Document();
            using (var stream = new FileStream("result.pdf", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                PdfWriter.GetInstance(document, stream);
                document.Open();
                using (var imageStream = new FileStream("Sample.jpg", FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {

                    var image = iTextSharp.text.Image.GetInstance(imageStream);
                    document.Add(image);
                }
                document.Close();
            }
        }
        public void ImagesToPdf(string[] imagepaths, string pdfpath)
        {
            iTextSharp.text.Rectangle pageSize = null;
            
            using (var srcImage = new Bitmap(imagepaths[0].ToString()))
            {
                pageSize = new iTextSharp.text.Rectangle(0, 0, srcImage.Width, srcImage.Height);
            }

            using (var ms = new MemoryStream())
            {
                var document = new iTextSharp.text.Document(pageSize, 0, 0, 0, 0);
                iTextSharp.text.pdf.PdfWriter.GetInstance(document, ms).SetFullCompression();
                document.Open();
                var image = iTextSharp.text.Image.GetInstance(imagepaths[0].ToString());
                document.Add(image);
                document.Close();
                File.WriteAllBytes(pdfpath, ms.ToArray());
            }
        }
        public void convertFromPDFToImg(string fileName, string fileName2)
        {

            using (Stream inputPdfStream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read))
            using (Stream inputImageStream = new FileStream(fileName2, FileMode.Open, FileAccess.Read, FileShare.Read))
            using (Stream outputPdfStream = new FileStream("result.pdf", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                var reader = new iTextSharp.text.pdf.PdfReader(inputPdfStream);
                var stamper = new PdfStamper(reader, outputPdfStream);
                var pdfContentByte = stamper.GetOverContent(1);

                iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(inputImageStream);
                image.SetAbsolutePosition(100, 100);
                pdfContentByte.AddImage(image);
                stamper.Close();
            }
        }
        public ElectronicSigning()
        {
            InitializeComponent();
        }
        bool firstLoad = true;
        SortedDictionary<string, SortedDictionary<string, decimal>> controlsDetails = new SortedDictionary<string, SortedDictionary<string, decimal>>();
        SortedDictionary<string, SortedDictionary<string, decimal>> controlsResult = new SortedDictionary<string, SortedDictionary<string, decimal>>();
        SimpleTcpClient client;

        private void MainMenu_Resize(object sender, EventArgs e)
        {
            if (firstLoad)
            {
                formApplication.ResizeForm.initialFormHeight = 757;
                formApplication.ResizeForm.initialFormWidth = 1303;
                formApplication.ResizeForm.setContolDetails(this, controlsDetails);
                formApplication.ResizeForm.setControlResult(this, controlsDetails, controlsResult);
                firstLoad = false;
            }
            formApplication.ResizeForm.changeControls(this, controlsResult);
        }
        List<string> depNames;
        string sourcePath = "";
        string targetPath = "";

        PdfSharp.Pdf.PdfDocument exportPDFRemain = new PdfSharp.Pdf.PdfDocument();
        string assignFileName = MainMenu.sharedFolder + "p.pdf";

        List<string> fileNames = new List<string>();
        int filesArrow = 0;

        private void Import_FormClosing(object sender, FormClosingEventArgs e)
        {
            client.Disconnect();
        }

        private void pnlClose_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void pnlClose_Click(object sender, EventArgs e)
        {

        }

        private void pnlClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }
        public string convertToArabicNumbers(string str)
        {
            string strNew = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '1')
                {
                    strNew += "١";
                }
                else if (str[i] == '2')
                {
                    strNew += "٢";
                }
                else if (str[i] == '3')
                {
                    strNew += "٣";
                }
                else if (str[i] == '4')
                {
                    strNew += "٤";
                }
                else if (str[i] == '5')
                {
                    strNew += "٥";
                }
                else if (str[i] == '6')
                {
                    strNew += "٦";
                }
                else if (str[i] == '7')
                {
                    strNew += "٧";
                }
                else if (str[i] == '8')
                {
                    strNew += "٨";
                }
                else if (str[i] == '9')
                {
                    strNew += "٩";
                }
                else if (str[i] == '0')
                {
                    strNew += "٠";
                }
                else
                {
                    strNew += str[i];
                }

            }
            return strNew;
        }
        public void resizeMainPage(int mWidth, int mHeight, int sX, int sY, int sWidth, int sHeight, string imgP)
        {
            decimal rationalWidth = Convert.ToDecimal(sWidth) / Convert.ToDecimal(mWidth);
            decimal rationalHeight = Convert.ToDecimal(sHeight) / Convert.ToDecimal(mHeight);
            decimal rationalX = Convert.ToDecimal(sX) / Convert.ToDecimal(mWidth);
            decimal rationalY = Convert.ToDecimal(sY) / Convert.ToDecimal(mHeight);
            int newWidth = Convert.ToInt32(rationalWidth * signedWidth);
            int newHeight = Convert.ToInt32(rationalHeight * signedHeight);
            int newX = Convert.ToInt32(rationalX * signedWidth);
            int newY = Convert.ToInt32(rationalY * signedHeight);
            System.Drawing.Image SigImg = resizeImage(sigImg, new Size(newWidth, newHeight));
            string mainImageFileName = MainMenu.sharedFolder + signedPage +".png";
            System.Drawing.Image img = System.Drawing.Image.FromFile(mainImageFileName);
            Bitmap bitmap = new Bitmap(img);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.DrawImage(SigImg, newX, newY);
                string arNum =convertToArabicNumbers( DateTime.Now.ToString("yyyy/MM/dd"));
                SizeF s= g.MeasureString(arNum, new System.Drawing.Font("Arial", 24, FontStyle.Bold));
                g.DrawString(arNum, new System.Drawing.Font("Arial", 24, FontStyle.Bold), Brushes.Black, new Point(newX+SigImg.Width -Convert.ToInt32( s.Width), newY+ SigImg.Height- Convert.ToInt32(s.Height)));
            }
            /*  System.Drawing.Image preferedSize = resizeImage(bitmap, new Size(preferedWidth, preferedHeight));
              Bitmap bp = new Bitmap(preferedSize);
              bp.SetResolution(bitmap.HorizontalResolution, bitmap.VerticalResolution);*/
            bitmap.Save(imgP);

        }
        public static System.Drawing.Image resizeImage(System.Drawing.Image imgToResize, Size size)
        {
            return (System.Drawing.Image)(new Bitmap(imgToResize, size));
        }
        int preferedX = 0;
        int preferedY = 0;
        int signedPage = -1;
      
        private void pnlMainImport_DragDrop(object sender, DragEventArgs e)
        {
            Bitmap bp = (Bitmap)e.Data.GetData(DataFormats.Bitmap, true);
            Point clientPoint = pnlMainImport.PointToClient(new Point(e.X, e.Y));
            //set date
            Label lbl = new Label();
            lbl.Font = new System.Drawing.Font("Arial", 8, FontStyle.Bold);
            lbl.BackColor = Color.Transparent;
            lbl.Text = DateTime.Now.ToString("yyyy/MM/dd");
            lbl.Name = "lblDate";
            pnlSignture.Controls.Add(lbl);
            pnlSignture.Controls["lblDate"].Location = new Point(pnlSignture.Width-lbl.Width+2, pnlSignture.Height-lbl.Height+10);
            Bitmap bmp1 = new Bitmap(pnlMainImport.Width, pnlMainImport.Height);
            pnlMainImport.DrawToBitmap(bmp1, new System.Drawing.Rectangle(0, 0, pnlMainImport.Width, pnlMainImport.Height));
            pnlSignture.BorderStyle = BorderStyle.None;
            Bitmap bmp2 = new Bitmap(pnlSignture.Width, pnlSignture.Height);
            pnlSignture.DrawToBitmap(bmp2, new System.Drawing.Rectangle(0, 0, pnlSignture.Width, pnlSignture.Height));

            System.Drawing.Image backImg = bmp1;
            System.Drawing.Image mrkImg = bmp2;
            Graphics g = Graphics.FromImage(backImg);
            preferedX = clientPoint.X - (pnlSignture.Width / 2);
            preferedY = clientPoint.Y - (pnlSignture.Height / 2);
            g.DrawImage(mrkImg, preferedX, preferedY);
            //update the panel with signing image
            pnlMainImport.BackgroundImage = backImg;
            pnlSignture.BorderStyle = BorderStyle.Fixed3D;
            pnlSignture.Controls.Remove(pnlSignture.Controls["lblDate"]);
            signedPage = currentPage;
            btnAgree.Enabled = true;
        }
        public string finalName = "";
        private void pnlMainImport_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void pnlSignture_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void pnlSignture_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pnlSignture.DoDragDrop(pnlSignture.BackgroundImage, DragDropEffects.Copy);
            }
        }

        private void pnlMainImport_Paint(object sender, PaintEventArgs e)
        {

        }
        System.Drawing.Image sigImg;
        private void btnReturn_Click(object sender, EventArgs e)
        {
            string mainImageFileName = MainMenu.sharedFolder + currentPage +".png";
            byte[] imageBytes = File.ReadAllBytes(mainImageFileName);
            using (var ms = new MemoryStream(imageBytes))
            {
                var image = System.Drawing.Image.FromStream(ms);
                pnlMainImport.BackgroundImage = (System.Drawing.Image)(image.Clone());
            }
            btnAgree.Enabled = false;

        }
        // public static int preferedHeight = 0;
        // public static int preferedWidth = 0;
        public int signedWidth = 0;
        public int signedHeight = 0;
  
        //load image in panel ,convert the first page and split the pdf
        int currentPage = 1;
        int firstPage = 1;
        int lastPage = 0;
        private void ElectronicSigning_Load(object sender, EventArgs e)
        {
            try
            {
          
                convertFromPDFToImages();
                string mainImageFileName = MainMenu.sharedFolder +@"\" + "1.png";
                byte[] imageBytes = File.ReadAllBytes(mainImageFileName);

                using (var ms = new MemoryStream(imageBytes))
                {
                    var image = System.Drawing.Image.FromStream(ms);
                    signedHeight = image.Height;
                    signedWidth = image.Width;

                    pnlMainImport.BackgroundImage = (System.Drawing.Image)(image).Clone();
                }
               
                //sign from program place
                sigImg = System.Drawing.Image.FromFile("Black.png");
                pnlSignture.BackgroundImage = (System.Drawing.Image)(sigImg.Clone());
                depNames = (Program.dtDeparts).AsEnumerable().Select(x => x[1].ToString()).ToList();
            }


                catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void convertFromPDFToImages()
        {
            Form frm = Application.OpenForms[0];
            string pdfFilePath = MainMenu.signatureFilePath;
            string outputPath = MainMenu.sharedFolder;
            iTextSharp.text.pdf.PdfReader readerAll = new iTextSharp.text.pdf.PdfReader(pdfFilePath);
            lastPage = readerAll.NumberOfPages;
            for (int i = 1; i <= lastPage; i++)
            {
              using (iTextSharp.text.pdf.PdfReader reader = new iTextSharp.text.pdf.PdfReader(pdfFilePath))
                {
                    Document document = new Document();
                    PdfCopy copy = new PdfCopy(document, new FileStream(outputPath  + i+ ".pdf", FileMode.Create));
                    document.Open();
                    copy.AddPage(copy.GetImportedPage(reader, i));
                    document.Close();
                }
                LoadImage(outputPath + i + ".pdf",1);
            }
            btnAgree.Enabled = false;
            //preferedHeight = Convert.ToInt32(assignPage.Pages[0].Height);
            //preferedWidth = Convert.ToInt32(assignPage.Pages[0].Width);
            //convert from pdf to image
        }
        private void btnAgree_Click(object sender, EventArgs e)
        {
            try
            {
                if(signedPage==-1)
                {
                    MessageBox.Show("لم يتم التوقيع");
                    return;
                }
                string resizedImagePath = MainMenu.sharedFolder  + signedPage +"-" + ".png";
                resizeMainPage(pnlMainImport.Width, pnlMainImport.Height, preferedX, preferedY, pnlSignture.Width, pnlSignture.Height, resizedImagePath);
                string filePath = MainMenu.sharedFolder  + signedPage + ".pdf";
                ImagesToPdf(new string[] { resizedImagePath }, filePath);
                mergePdfPages();
                Form frm = Application.OpenForms[0];
                ((MainMenu)frm).axAcroPDFExport.src = signedPath;
                //   ((SimpleTCP.Message)((MainMenu)frm).serverMessage).ReplyLine("5" + "\n" + signedPath);
                MainMenu.signed[MainMenu.filesArrow2] = true;
                MainMenu.actions[MainMenu.filesArrow2] = signedPath;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
      public string signedPath = "";
        private void mergePdfPages()
        {
            Form frm = Application.OpenForms[0];
            string outputPath = MainMenu.sharedFolder + Path.GetFileNameWithoutExtension(MainMenu.signatureFilePath) + "(موقع).pdf";
            signedPath = outputPath;
       
            Document document = new Document();
            PdfCopy copy = new PdfCopy(document, new FileStream(outputPath, FileMode.Create));
            document.Open();
            for (int i = 1; i <= lastPage; i++)
            {
                string filePath = MainMenu.sharedFolder + i + ".pdf";
                using (iTextSharp.text.pdf.PdfReader reader = new iTextSharp.text.pdf.PdfReader(filePath))
                {
                    copy.AddPage(copy.GetImportedPage(reader, 1));
                }
            }
            document.Close();
            for (int i = 1; i <= lastPage; i++)
            {
                if(File.Exists(MainMenu.sharedFolder + i + ".pdf"))
                File.Delete(MainMenu.sharedFolder + i + ".pdf");
                if (File.Exists(MainMenu.sharedFolder + i + ".png"))
                    File.Delete(MainMenu.sharedFolder + i + ".png");
            }
            if (File.Exists(MainMenu.sharedFolder + signedPage  +"-" + ".png"))
                File.Delete(MainMenu.sharedFolder + signedPage  +"-" + ".png");
            if (File.Exists(MainMenu.sharedFolder + signedPage  +"-" + ".pdf"))
                File.Delete(MainMenu.sharedFolder  + signedPage +"-" + ".pdf");
        }

        private void pnlSignture_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (currentPage > firstPage)
            {
                currentPage--;
                string imgPath = MainMenu.sharedFolder + @"\" + currentPage + ".png";
            
                byte[] imageBytes = File.ReadAllBytes(imgPath);
                using (var ms = new MemoryStream(imageBytes))
                {
                    var image = System.Drawing.Image.FromStream(ms);
                    signedHeight = image.Height;
                    signedWidth = image.Width;
                    pnlMainImport.BackgroundImage = (System.Drawing.Image)(image).Clone();
                }

            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
          if(currentPage<lastPage)
            {
                currentPage++;
                string imgPath = MainMenu.sharedFolder + @"\" + currentPage + ".png";
                byte[] imageBytes = File.ReadAllBytes(imgPath);

                using (var ms = new MemoryStream(imageBytes))
                {
                    var image = System.Drawing.Image.FromStream(ms);
                    signedHeight = image.Height;
                    signedWidth = image.Width;
                    pnlMainImport.BackgroundImage = (System.Drawing.Image)(image).Clone();
                }

                
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            pnlMainImport.Controls.Clear();
            for (int i = 1; i <= lastPage; i++)
            {
                if(File.Exists(MainMenu.sharedFolder + @"/" + i + ".pdf"))
                File.Delete(MainMenu.sharedFolder + @"/" + i + ".pdf");
                if (File.Exists(MainMenu.sharedFolder + @"/" + i + ".png"))
                    File.Delete(MainMenu.sharedFolder + @"/" + i + ".png");
            }
            if (File.Exists(MainMenu.sharedFolder + @"/" + signedPage + "-" + ".png"))
                File.Delete(MainMenu.sharedFolder + @"/" + signedPage + "-" + ".png");
            if (File.Exists(MainMenu.sharedFolder + @"/" + signedPage + "-" + ".pdf"))
                File.Delete(MainMenu.sharedFolder + @"/" + signedPage + "-" + ".pdf");
            Close();
         
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
