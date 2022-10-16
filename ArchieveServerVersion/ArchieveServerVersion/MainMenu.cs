using Ghostscript.NET;
using iTextSharp.text;
using iTextSharp.text.pdf;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ArchieveServerVersion
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        bool firstLoad = true;
        SortedDictionary<string, SortedDictionary<string, decimal>> controlsDetails = new SortedDictionary<string, SortedDictionary<string, decimal>>();
        SortedDictionary<string, SortedDictionary<string, decimal>> controlsResult = new SortedDictionary<string, SortedDictionary<string, decimal>>();
       
        private void MainMenu_Resize(object sender, EventArgs e)
        {
            if (firstLoad)
            {
                formApplication.ResizeForm.initialFormHeight = 757;
                formApplication.ResizeForm.initialFormWidth = 1303;
                formApplication.ResizeForm.setContolDetails(this, controlsDetails);

                formApplication.ResizeForm.setControlResult(this,controlsDetails, controlsResult);
                firstLoad = false;
            }
            formApplication.ResizeForm.changeControls(this, controlsResult);
        }



    
    
        private void btnExport_Click(object sender, EventArgs e)
        {
            btnExport.BackColor = Color.Green;
            btnExport.ForeColor = Color.White;
            btnImport.BackColor = Color.White;
            btnImport.ForeColor = Color.Green;
            pnlExport.Visible = true;
            pnlImport.Visible = false;
            lblExport.Text = "0";
            lblExport.Hide();
            lblImport.Show();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            btnImport.BackColor = Color.Green;
            btnImport.ForeColor = Color.White;
            btnExport.BackColor = Color.White;
            btnExport.ForeColor = Color.Green;
            pnlExport.Visible = false;
            pnlImport.Visible = true;
            lblImport.Text = "0";
            lblExport.Show();
            lblImport.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnImport_MouseHover(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.White;
            ((Button)sender).ForeColor = Color.Blue;
        }

        private void pnlImport_Paint(object sender, PaintEventArgs e)
        {

        }

        public List<string> lblStatusList = new List<string>();
  
        private void MainMenu_Load(object sender, EventArgs e)
        {
            depNames = (Program.dtDeparts).AsEnumerable().Select(x => x[1].ToString()).ToList();
            server = new SimpleTcpServer();
            server.Delimiter = 0x13;
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Server_DataRecieved;
            System.Net.IPAddress ip = System.Net.IPAddress.Any;
            server.Start(ip, Convert.ToInt32("8910"));
            destPlace = "";
        }
        List<List<int>> dataIndeces;
        List<string> fileNames = new List<string>();
        List<string> fileNames2 = new List<string>();
        int filesArrow = 0;
        string destPlace = "";
        SimpleTcpServer server;
        SimpleTCP.Message clientMessage;
        List<string> depNames;
        private void Server_DataRecieved(object sender, SimpleTCP.Message e)
        {
            clientMessage = e;
            string msg = e.MessageString.Trim('\u0013');
            string[] recievedData = msg.Split('\n');
            if (recievedData[0] == "0")
            {
                dataIndeces = new List<List<int>>();
                for (int i = 1; i < recievedData.Count(); i++)
                {
                    if (recievedData[i] == "") continue;
                    string[] listIndeces = recievedData[i].Split(',');
                    List<int> listIndx = new List<int>();
                    for (int k = 0; k < listIndeces.Count(); k++)
                    {
                        if (listIndeces[k] == "") continue;
                        listIndx.Add(int.Parse(listIndeces[k]));
                    }
                    dataIndeces.Add(listIndx);
                }
                departs = new List<List<string>>();
                pnlDeparts.Invoke((MethodInvoker)delegate
                {
                    for (int i = 0; i < dataIndeces.Count; i++)
                    {
                        List<string> lst = new List<string>();
                        for (int k = 0; k < dataIndeces[i].Count; k++)
                        {
                            ((BigCheckedListBox)pnlDeparts.Controls["ch" + (i + 1)]).SetItemChecked(dataIndeces[i][k],  true);
                            lst.Add(((BigCheckedListBox)pnlDeparts.Controls["ch" + (i + 1)]).Items[dataIndeces[i][k]].ToString());
                        }
                        departs.Add(lst);
                    }
                });
              
                btnImport.Invoke((MethodInvoker)delegate {
                    if (btnImport.BackColor == Color.White)
                        lblImport.Text = lblFilesCount.Text;
                });
                btnPrint.Invoke((MethodInvoker)delegate { btnPrint.Enabled = true; });
            }
             if (recievedData[0] == "1")
            {
                List<string> getData = new List<string>();

                for (int i = 1; i < recievedData.Length; i++)
                {
                    if (recievedData[i] == "") continue;
                    getData.Add(recievedData[i]);
                }
                //update exportFiles
                for (int i = 0; i < getData.Count; i++)
                {
                    if (getData[i].Length > 1)
                    {
                        if (getData[i] == "-1")
                        {
                            MessageBox.Show("يوجد مشكلة فى الإرسال");
                            return;
                        }
                       else if (getData[i][0]=='3')
                        {
                            fileNames2[i] = getData[i].Substring(1);
                            lblStatusList[i] = "عرض النسخة الموقعة";
                        }
                        else
                        {
                            fileNames2[i] = getData[i];
                            lblStatusList[i] = "جاهز للطباعة";
                        }
                
                    }
                    else
                    {
                        for (int k = 0; k < getData.Count; k++)
                        {
                        

                            if (getData[k] =="0")
                            {
                                lblStatusList[k] = "عرض باليد";
                            }
                            else if (getData[k] == "1")
                            {
                                lblStatusList[k] = "تأجيل";
                            }
                            else if (getData[k] == "2")
                            {
                                lblStatusList[k] = "أخطاء املائية";
                            }
                          
                        }
                    }
                   

                }
               axAcroPDFExport.Invoke((MethodInvoker)delegate { axAcroPDFExport.src = fileNames2[filesArrow2]; });
                lblStatus.Invoke((MethodInvoker)delegate { lblStatus.Text=lblStatusList[filesArrow2]; });
                btnExport.Invoke((MethodInvoker)delegate {
                    if (btnExport.BackColor == Color.White)
                        lblExport.Text = lblFilesCount2.Text;
                });
            }   
           
           
        }

        private void clear()
        {
            fileNames = new List<string>();
            filesArrow = 0;
            lblFileNO.Text = "0";
            lblFilesCount.Text = "0";
            pnlDeparts.Controls.Clear();
        }
        class BigCheckedListBox : CheckedListBox
        {
          
            public override SelectionMode SelectionMode
            {
                
                get
                {
                    return base.SelectionMode;
                }

                set
                {
                    base.SelectionMode = SelectionMode.None;
                }
            }
            public BigCheckedListBox()
            {
                ForeColor = Color.Blue;
                Font = new System.Drawing.Font("Segoe UI", 12f,FontStyle.Bold);
            }
            protected override void OnDrawItem(DrawItemEventArgs e)
            {
                e.DrawBackground();

                var b = e.Bounds;
                var state = GetItemChecked(e.Index) ? CheckBoxState.CheckedNormal : CheckBoxState.UncheckedNormal;
                Size glyphSize = CheckBoxRenderer.GetGlyphSize(e.Graphics, state);
                int checkPad = (b.Height - glyphSize.Height) / 2;
                var pt = new Point(b.X + checkPad-3, b.Y + checkPad-3);

                System.Drawing.Rectangle rect = new System.Drawing.Rectangle(pt, new Size(20, 20));
                e.Graphics.DrawRectangle(Pens.Green, rect);//This is for Checkbox rectangle

                //This is for drawing string text
                using (SolidBrush brush = new SolidBrush(ForeColor))
                    e.Graphics.DrawString(this.Items[e.Index].ToString(), Font, brush, pt.X + 27f, pt.Y);
                if (state == CheckBoxState.CheckedNormal)
                {
                    using (SolidBrush brush = new SolidBrush(ForeColor))
                    using (System.Drawing.Font wing = new System.Drawing.Font("Wingdings", 17f, FontStyle.Bold))
                        e.Graphics.DrawString("ü", wing, brush, pt.X - 4, pt.Y - 1); //This is For tick mark
                }
              //  SelectionMode=SelectionMode.One;
            }
        }
        //public string sharedFolder = @"\\10.10.21.2\UDA Share\Archieving UDA\Archieving\الأرشيف الألكترونى\الوارد" + @"\";
        public string sharedFolder = "";

        private void btnAttachImports_Click(object sender, EventArgs e)
        {
            try
            {
                ofdImports.Multiselect = true;
                //ofdImports.InitialDirectory = @"C:\Users\NanoChip\Desktop\Test\";
                //ofdImports.InitialDirectory = sharedFolder;
                if (ofdImports.ShowDialog() == DialogResult.OK)
                {
                    sharedFolder = Path.GetDirectoryName(ofdImports.FileNames[0]);
                    sharedFolder += @"\";
                    clear();
                    foreach (var fileName in ofdImports.FileNames)
                    {
                        fileNames.Add(fileName);
                    }
                    axAcroPDFImport.src = fileNames[0];
                    lblFilesCount.Text = fileNames.Count + "";
                    lblFileNO.Text = "1";
                    filesArrow = 0;
                    axAcroPDFImport.Visible = true;
                    for (int i = 0; i < fileNames.Count; i++)
                    {
                        BigCheckedListBox ch = new BigCheckedListBox();
                        ch.Location = new Point(-5, 0);
                        ch.CheckOnClick = true;
                        ch.Size = pnlDeparts.Size;
                        ch.SelectionMode = SelectionMode.None;
                        for (int l = 0; l < depNames.Count; l++)
                        {
                            ch.Items.Add(depNames[l]);
                        }
                        ch.Name = "ch" + (i + 1);
                        pnlDeparts.Controls.Add(ch);
                    }
                    for (int i = 1; i <= pnlDeparts.Controls.Count; i++)
                    {
                        pnlDeparts.Controls["ch" + i].Visible = false;
                    }
                    pnlDeparts.Controls["ch1"].Visible = true;

                     fileNamesTxt = "\n";
                    for (int i = 0; i < fileNames.Count; i++)
                    {
                        fileNamesTxt += fileNames[i];
                        fileNamesTxt += "\n";
                    }
                    btnSendImports.Enabled = true;
                    btnPrint.Enabled = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        string fileNamesTxt="";
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (filesArrow < fileNames.Count - 1)
            {
                pnlDeparts.Controls["ch" + (filesArrow + 1)].Visible = false;
                filesArrow++;
                pnlDeparts.Controls["ch" + (filesArrow + 1)].Visible = true;
                lblFileNO.Text = (filesArrow + 1) + "";
                axAcroPDFImport.src = fileNames[filesArrow];
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (filesArrow > 0)
            {
                pnlDeparts.Controls["ch" + (filesArrow + 1)].Visible = false;
                filesArrow--;
                pnlDeparts.Controls["ch" + (filesArrow + 1)].Visible = true;
                lblFileNO.Text = (filesArrow + 1) + "";
                axAcroPDFImport.src = fileNames[filesArrow];
            }
        }

        private void lblFileNO_Click(object sender, EventArgs e)
        {

        }

        private void pnlImport_Paint_1(object sender, PaintEventArgs e)
        {

        }
        string fileName = "";
        private void btnAttachExport_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
           // ofd.InitialDirectory = @"\\10.10.21.2\UDA Share\Archieving UDA\Archieving\الأرشيف الألكترونى\الصادر";
          //  ofd.InitialDirectory = @"C:\Users\NanoChip\Desktop\Test\";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                lblStatusList.Clear();
                fileNames2.Clear();
                foreach (var fileName in ofd.FileNames)
                {
                    fileNames2.Add(fileName);
                }
                btnSend.Enabled = true;
                filesArrow2 = 0;
             
                axAcroPDFExport.src = fileNames2[filesArrow2];
                lblFilesCount2.Text = fileNames2.Count + "";
            
                lblFileNO2.Text = 1 + "";

                fileNamesTxt2 = "\n";
                for (int i = 0; i < fileNames2.Count; i++)
                {
                    fileNamesTxt2 += fileNames2[i];
                    fileNamesTxt2 += "\n";
                }
                for (int i = 0; i < fileNames2.Count; i++)
                {
                    lblStatusList.Add("لا يوجد رد");
                }
                lblStatus.Text = lblStatusList[filesArrow2];
                btnSend.Enabled = true;
            }

        }
        string fileNamesTxt2="";
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (fileNamesTxt2 != "")
            {
                //send filename path + revised or not -> 0 for revised 1 for not

                server.BroadcastLine("1" + fileNamesTxt2);
                MessageBox.Show("تم الإرسال");
                btnSend.Enabled = false;
            }
        }


         List< List<string>> departs = new List<List<string>>();
        private void MainMenu_Load_1(object sender, EventArgs e)
        {
           depNames = (Program.dtDeparts).AsEnumerable().Select(x => x[1].ToString()).ToList();
            server = new SimpleTcpServer();
            server.Delimiter = 0x13;
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Server_DataRecieved;
            System.Net.IPAddress ip = System.Net.IPAddress.Any;
            server.Start(ip, Convert.ToInt32("8910"));
            destPlace = "";
            pnlImport.Visible = false;
            pnlExport.Visible = false;
            btnExport.PerformClick();
            btnSend.Enabled = false;
            btnSendImports.Enabled = false;
        }

        private void btnExport_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Blue;
            ((Button)sender).ForeColor = Color.White;
        }

        private void btnAttachExport_MouseDown(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackColor = Color.Green;
            ((Button)sender).ForeColor = Color.White;
        }

        private void btnAttachExport_MouseUp(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackColor = Color.White;
            ((Button)sender).ForeColor = Color.Green;
        }

       

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        
        private void pnlClose_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void axAcroPDFExport_Enter(object sender, EventArgs e)
        {
        //    AllowDrop = DragDropEffects.All;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClose2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSendImports_Click(object sender, EventArgs e)
        {
            if (fileNamesTxt != "")
            {
                server.BroadcastLine("0" + fileNamesTxt);
                MessageBox.Show("تم الإرسال");
                btnSendImports.Enabled = false;
            }
        }
        int filesArrow2 = 0;
        private void btnNext1_Click(object sender, EventArgs e)
        {
            if (filesArrow2 < fileNames2.Count - 1)
            {
                filesArrow2++;
                lblFileNO2.Text = (filesArrow2 + 1) + "";
                lblStatus.Text = lblStatusList[filesArrow2];
                axAcroPDFExport.src = fileNames2[filesArrow2];
            }
        }

        private void btnPrev1_Click(object sender, EventArgs e)
        {
            if (filesArrow2 > 0)
            {
                filesArrow2--;
                lblFileNO2.Text = (filesArrow2 + 1) + "";
                lblStatus.Text = lblStatusList[filesArrow2];
                axAcroPDFExport.src = fileNames2[filesArrow2];
            }
        }
        public void LoadImage(string InputPDFFile, int PageNumber,string path)
        {
            GhostscriptPngDevice dev = new GhostscriptPngDevice(GhostscriptPngDeviceType.Png256);
            dev.GraphicsAlphaBits = GhostscriptImageDeviceAlphaBits.V_4;
            dev.TextAlphaBits = GhostscriptImageDeviceAlphaBits.V_4;
            dev.ResolutionXY = new GhostscriptImageDeviceResolution(290, 290);
            dev.InputFiles.Add(InputPDFFile);
            dev.Pdf.FirstPage = PageNumber;
            dev.Pdf.LastPage = PageNumber;
            dev.CustomSwitches.Add("-dDOINTERPOLATE");
            dev.OutputPath = path;
            dev.Process();
        }
        string filePath;
        private void convertFromPDFToImages(string fName,string path)
        {

            string pdfFilePath = fName;
            string outputPath = path;
            iTextSharp.text.pdf.PdfReader readerAll = new iTextSharp.text.pdf.PdfReader(pdfFilePath);
           int lastPage = readerAll.NumberOfPages;
            //first page
            filePath = sharedFolder + "a.png";
            LoadImage(pdfFilePath, 1,filePath);
            ((Form)printPreviewDialog1).WindowState = FormWindowState.Maximized;
            if(printPreviewDialog1.ShowDialog()==DialogResult.OK)
            {
                printDocument1.Print();
            }
            //preferedHeight = Convert.ToInt32(assignPage.Pages[0].Height);
            //preferedWidth = Convert.ToInt32(assignPage.Pages[0].Width);
            //convert from pdf to image
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            convertFromPDFToImages(ofdImports.FileName,sharedFolder);
            /*axAcroPDFImport.printAll();
            ((Form)printPreviewDialog1).WindowState = FormWindowState.Maximized;
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }*/

        }
   
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            byte[] imageBytes = File.ReadAllBytes(filePath);

            System.Drawing.Image image;
            using (var ms = new MemoryStream(imageBytes))
            {
               image = System.Drawing.Image.FromStream(ms);

            }
            
            Bitmap bmp1 = (System.Drawing.Bitmap)(new Bitmap(image, new Size(e.PageBounds.Width-100, (e.PageBounds.Height - 150))));
            int x = 50;
            int y = 150;
            int xS = e.PageBounds.Width- 20;
            int yS = 20;
            System.Drawing.Font fnt = new System.Drawing.Font("Arial", 22,FontStyle.Bold);
            for (int i = 0; i < departs[filesArrow].Count; i++)
            {
                SizeF s = e.Graphics.MeasureString(departs[filesArrow][i], fnt);
                if (xS-Convert.ToInt32(s.Width)  <=20)
                {
                    yS +=Convert.ToInt32 (5 + s.Height);
                    xS = e.PageBounds.Width - 20;
                }
                xS -= Convert.ToInt32(s.Width);
                e.Graphics.DrawString(departs[filesArrow][i], fnt, Brushes.Black, new Point(xS, yS));
                
                SizeF s2 = e.Graphics.MeasureString(" - ", fnt);
                if (xS -Convert.ToInt32(s2.Width) <=20 || i== departs[filesArrow].Count-1)
                {
                    continue;
                }
                else
                {
                    SizeF s3 = e.Graphics.MeasureString(departs[filesArrow][i+1], fnt);
                    if (xS - Convert.ToInt32(s2.Width + s3.Width) <= 20) continue;
                    xS -= Convert.ToInt32(s2.Width);
                    e.Graphics.DrawString(" - ", fnt, Brushes.Black, new Point(xS, yS));
               
                }
            }

            e.Graphics.DrawImage(bmp1, new Point(x, y));

        }

        private void btnPrintExport_Click(object sender, EventArgs e)
        {
            axAcroPDFExport.printAllFit(true);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
