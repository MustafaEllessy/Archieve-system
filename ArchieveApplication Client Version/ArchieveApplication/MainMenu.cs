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

namespace ArchieveApplication
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

        private void button1_Click(object sender, EventArgs e)
        {
            Export frm = new Export();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ElectronicSigning frm = new ElectronicSigning();
            frm.ShowDialog();
        }

        private void closeTool1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

       // bool MainClicked = false;

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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnImport_MouseHover(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.White;
            ((Button)sender).ForeColor = Color.Blue;
        }
        string decision = "no";
        public static List<string> actions = new List<string>();
        private void pnlImport_Paint(object sender, PaintEventArgs e)
        {

        }
        class BigCheckedListBox : CheckedListBox
        {

            /*public override SelectionMode SelectionMode
            {
                get
                {
                    return base.SelectionMode;
                }

                set
                {
                    base.SelectionMode = SelectionMode.One;
                }
            }*/
            public BigCheckedListBox()
            {
                ForeColor = Color.Blue;
                Font = new Font("Segoe UI", 12f, FontStyle.Bold);
            }
            protected override void OnDrawItem(DrawItemEventArgs e)
            {
                e.DrawBackground();

                var b = e.Bounds;
                var state = GetItemChecked(e.Index) ? CheckBoxState.CheckedNormal : CheckBoxState.UncheckedNormal;
                Size glyphSize = CheckBoxRenderer.GetGlyphSize(e.Graphics, state);
                int checkPad = (b.Height - glyphSize.Height) / 2;
                var pt = new Point(b.X + checkPad - 2, b.Y + checkPad - 2);

                Rectangle rect = new Rectangle(pt, new Size(20, 20));
                e.Graphics.DrawRectangle(Pens.Green, rect);//This is for Checkbox rectangle

                //This is for drawing string text
                using (SolidBrush brush = new SolidBrush(ForeColor))
                    e.Graphics.DrawString(this.Items[e.Index].ToString(), Font, brush, pt.X + 27f, pt.Y);
                if (state == CheckBoxState.CheckedNormal)
                {
                    using (SolidBrush brush = new SolidBrush(ForeColor))
                    using (Font wing = new Font("Wingdings", 17f, FontStyle.Bold))
                        e.Graphics.DrawString("ü", wing, brush, pt.X - 4, pt.Y - 1); //This is For tick mark
                }
                //  SelectionMode=SelectionMode.One;
            }
        }

       public  SimpleTCP.Message serverMessage;
        private void client_DataRecieved(object sender, SimpleTCP.Message e)
        {
            //0 for recieve imports
            serverMessage = e;

            string clientTxt = serverMessage.MessageString.Trim('\u0013');
            string[] clientMsgLines = clientTxt.Split('\n');
            if (clientMsgLines[0] == "0")
            {
                fileNames.Clear();
           
                for (int i = 1; i < clientMsgLines.Length; i++)
                {
                    if (clientMsgLines[i] == "") continue;
                    fileNames.Add(clientMsgLines[i]);
                }
                axAcroPDFImport.Invoke((MethodInvoker)delegate { axAcroPDFImport.src = fileNames[0]; });
                lblFilesCount.Invoke((MethodInvoker)delegate { lblFilesCount.Text = fileNames.Count + ""; });
                lblFileNO.Invoke((MethodInvoker)delegate { lblFileNO.Text = 1 + ""; });
                filesArrow = 0;
                pnlDeparts.Invoke((MethodInvoker)delegate {
                pnlDeparts.Controls.Clear();
                    for (int i = 0; i < fileNames.Count; i++)
                    {
                        BigCheckedListBox ch = new BigCheckedListBox();
                        ch.Location = new Point(-5, 0);
                        ch.Size = pnlDeparts.Size;
                        ch.CheckOnClick = true;
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
                });
                btnImportSend.Invoke((MethodInvoker)delegate
                {
                    btnImportSend.Enabled = true;
                });
                btnImport.Invoke((MethodInvoker)delegate {
                    if (btnImport.BackColor == Color.White)
                        lblImport.Text = lblFilesCount.Text;
                });
            }
           else if (clientMsgLines[0] == "1")
            {
                fileNames2.Clear();
                actions.Clear();
                for (int i = 1; i < clientMsgLines.Length; i++)
                {
                    if (clientMsgLines[i] == "") continue;
                    fileNames2.Add(clientMsgLines[i]);
                }
                for (int i = 0; i < fileNames2.Count; i++)
                {
                    actions.Add("-1");
                }
                sharedFolder = Path.GetDirectoryName(fileNames2[0]);
                sharedFolder += @"\";

                signatureFilePath = sharedFolder;
                axAcroPDFExport.Invoke((MethodInvoker)delegate { axAcroPDFExport.src = fileNames2[0]; });
                lblFilesCount2.Invoke((MethodInvoker)delegate { lblFilesCount2.Text = fileNames2.Count + ""; });
                lblFileNO2.Invoke((MethodInvoker)delegate { lblFileNO2.Text = 1 + ""; });
                filesArrow2 = 0;
                thereIsExport = true;
                btnSend.Invoke((MethodInvoker)delegate
                {
                    btnSend.Enabled = true;
                });
                activatedActions = new List<int>();
                for (int i = 0; i <fileNames2.Count ; i++)
                {
                    activatedActions.Add(-1);
                }
                signed = new List<bool>();
                for (int i = 0; i < fileNames2.Count; i++)
                {
                    signed.Add(false);
                }
                btnHandShow.Invoke((MethodInvoker)delegate {
                    btnHandShow.Enabled = true;
                    btnHandShow.BackColor = Color.White;
                    btnHandShow.ForeColor = Color.Green;
                });
                btnWait.Invoke((MethodInvoker)delegate {
                    btnWait.Enabled = true;
                    btnWait.BackColor = Color.White;
                    btnWait.ForeColor = Color.Green;
                });
                btnTypicalErrors.Invoke((MethodInvoker)delegate {
                    btnTypicalErrors.Enabled = true;
                    btnTypicalErrors.BackColor = Color.White;
                    btnTypicalErrors.ForeColor = Color.Green;
                });
                btnAssing.Invoke((MethodInvoker)delegate {
                    btnAssing.Enabled = true;
                    btnAssing.BackColor = Color.White;
                    btnAssing.ForeColor = Color.Green;
                });
                btnViewAfterSign.Invoke((MethodInvoker)delegate {
                    btnViewAfterSign.Enabled = true;
                    btnViewAfterSign.BackColor = Color.White;
                    btnViewAfterSign.ForeColor = Color.Green;
                });
                btnExport.Invoke((MethodInvoker)delegate {
                    if (btnExport.BackColor == Color.White)
                        lblExport.Text = lblFilesCount2.Text;
                });
            }

        }
        bool thereIsExport = false; 
       //public static string sharedFolder = @"\\10.10.21.2\UDA Share\Archieving UDA\Archieving\الأرشيف الألكترونى";
   
         public static string sharedFolder = "";

        public static string signatureFilePath = "";
        List<string> fileNames = new List<string>();
        List<string> fileNames2 = new List<string>();

       int filesArrow = 0;
        public static int filesArrow2 = 0;
        SimpleTcpClient client;
        List<string> depNames;
     public static List<bool> signed; 
        private void MainMenu_Load(object sender, EventArgs e)
        {
            btnSend.Enabled = false;
            btnImportSend.Enabled = false;
            depNames = (Program.dtDeparts).AsEnumerable().Select(x => x[1].ToString()).ToList();
            client = new SimpleTcpClient();
            client.StringEncoder = Encoding.UTF8;
            client.DataReceived += client_DataRecieved;
            try
            {
                client.Connect("127.0.0.1", Convert.ToInt32("8910"));
               //string d= File.ReadAllText("ip.txt").Trim('\n');
                 //client.Connect(d, Convert.ToInt32("8910"));
            }
            catch (Exception ex)
            {
                MessageBox.Show("يوجد خطأ فى الإتصال");
                this.Close();
            }
            pnlImport.Visible = false;
            pnlExport.Visible = false;
            btnExport.PerformClick();
            deActivateActions();
        }

        private void button8_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnExport_MouseHover(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.White;
            ((Button)sender).ForeColor = Color.Blue;
        }

        private void pnlImport_Paint_1(object sender, PaintEventArgs e)
        {

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

        private void axAcroPDFImport_Enter(object sender, EventArgs e)
        {

        }
        List<List<int>> dataIndeces;
        private void btnImportSend_Click(object sender, EventArgs e)
        {
            dataIndeces = new List<List<int>>();
            for (int i = 0; i < pnlDeparts.Controls.Count; i++)
            {
                BigCheckedListBox ch = (BigCheckedListBox)pnlDeparts.Controls["ch" + (i + 1)];
                List<int> inds = new List<int>();
                for (int k = 0; k < ch.CheckedIndices.Count; k++)
                {
                    inds.Add(ch.CheckedIndices[k]);
                }
                dataIndeces.Add(inds);
            }
            //validation condition
            List<int> emptyInds = new List<int>();
            for (int i = 0; i < dataIndeces.Count; i++)
            {
                if (dataIndeces[i].Count == 0)
                {
                    emptyInds.Add(i + 1);
                }
            }
            if (emptyInds.Count != 0)
            {
                string dataStr = "";
                for (int i = 0; i < emptyInds.Count; i++)
                {
                    if (i == emptyInds.Count - 1)
                    {
                        dataStr += ((emptyInds[i]) + "\n");
                        continue;
                    }
                    dataStr += ((emptyInds[i]) + ",");
                }
                MessageBox.Show("وارد رقم " + dataStr + "لم يتم التأشير عليه");
            }
            else
            {

                string replayMain = "0";
                for (int i = 0; i < dataIndeces.Count; i++)
                {
                    replayMain += "\n";
                    for (int k = 0; k < dataIndeces[i].Count; k++)
                    {
                        replayMain += (dataIndeces[i][k] + ",");
                    }
                }
                serverMessage.ReplyLine(replayMain);
                MessageBox.Show("تم الإرسال ");
                btnImportSend.Enabled = false;
            }
        }

        List<int> activatedActions = new List<int>();
        
        private void btnHandShow_Click(object sender, EventArgs e)
        {
            if (thereIsExport)
            {
                if (signed[filesArrow2])
                {
                    if (activatedActions[filesArrow2] == 4)
                    {
                        fileNames2[filesArrow2] = actions[filesArrow2].Substring(1);
                        fileNames2[filesArrow2] = fileNames2[filesArrow2].Replace("(موقع)", "");
                        axAcroPDFExport.src = fileNames2[filesArrow2];
                        File.Delete(actions[filesArrow2].Substring(1));
                        signed[filesArrow2] = false;
                    }
                    else
                    {
                        fileNames2[filesArrow2] = actions[filesArrow2];
                        fileNames2[filesArrow2] = fileNames2[filesArrow2].Replace("(موقع)", "");
                        axAcroPDFExport.src = fileNames2[filesArrow2];
                        File.Delete(actions[filesArrow2]);
                        signed[filesArrow2] = false;
                    }

                }
                decision = "0";
                actions[filesArrow2] = decision;

                activatedActions[filesArrow2] = 0;
                updateActionList();

            }


        }

     

        private void btnWait_Click(object sender, EventArgs e)
        {
            if (thereIsExport)
            {
                if (signed[filesArrow2])
                {
                    if (activatedActions[filesArrow2] == 4)
                    {
                        fileNames2[filesArrow2] = actions[filesArrow2].Substring(1);
                        fileNames2[filesArrow2] = fileNames2[filesArrow2].Replace("(موقع)", "");
                        axAcroPDFExport.src = fileNames2[filesArrow2];
                        File.Delete(actions[filesArrow2].Substring(1));
                        signed[filesArrow2] = false;
                    }
                    else
                    {
                        fileNames2[filesArrow2] = actions[filesArrow2];
                        fileNames2[filesArrow2] = fileNames2[filesArrow2].Replace("(موقع)", "");
                        axAcroPDFExport.src = fileNames2[filesArrow2];
                        File.Delete(actions[filesArrow2]);
                        signed[filesArrow2] = false;
                    }

                }
                decision = "1";
                actions[filesArrow2] = decision;
                activatedActions[filesArrow2] = 1;
                updateActionList();


            }
        }

        private void btnTypicalErrors_Click(object sender, EventArgs e)
        {
            if (thereIsExport)
            {
                if (signed[filesArrow2])
                {
                    if (activatedActions[filesArrow2] == 4)
                    {
                        fileNames2[filesArrow2] = actions[filesArrow2].Substring(1);
                        fileNames2[filesArrow2] = fileNames2[filesArrow2].Replace("(موقع)", "");
                        axAcroPDFExport.src = fileNames2[filesArrow2];
                        File.Delete(actions[filesArrow2].Substring(1));
                        signed[filesArrow2] = false;
                    }
                    else
                    {
                        fileNames2[filesArrow2] = actions[filesArrow2];
                        fileNames2[filesArrow2] = fileNames2[filesArrow2].Replace("(موقع)", "");
                        axAcroPDFExport.src = fileNames2[filesArrow2];
                        File.Delete(actions[filesArrow2]);
                        signed[filesArrow2] = false;
                    }

                }
                decision = "2";
                actions[filesArrow2] = decision;
                activatedActions[filesArrow2] = 2;
                updateActionList();

            }
        }
        private void btnAssing_Click(object sender, EventArgs e)
        {
         if (thereIsExport)
            {
                if (signed[filesArrow2])
                {
                    MessageBox.Show("تم التوقيع");
                    return;
                }
                signatureFilePath = fileNames2[filesArrow2];
                ElectronicSigning frm = new ElectronicSigning();
                frm.ShowDialog();
                if(signed[filesArrow2])
                {
                    fileNames2[filesArrow2] = actions[filesArrow2];
                    activatedActions[filesArrow2] = 3;
                    updateActionList();
                }

            }
        }
       

        private void btnImport_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Blue;
            ((Button)sender).ForeColor = Color.White;
        }

        private void btnAgree_MouseDown(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackColor = Color.Green;
            ((Button)sender).ForeColor = Color.White;
        }

        private void btnAgree_MouseUp(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackColor = Color.White;
            ((Button)sender).ForeColor = Color.Green;
        }

 
   

        private void pnlClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void axAcroPDFExport_Enter(object sender, EventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClose2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (thereIsExport)
            {
                List<int> exNu = new List<int>();
                for (int i = 0; i < actions.Count; i++)
                {
                    if (actions[i] == "-1")
                    {
                        exNu.Add(i+1);
                    }
                }
                if (exNu.Count == 0)
                {
                    string msg = "1\n";
                    for (int i = 0; i < actions.Count; i++)
                    {
                        msg += actions[i];
                        msg += "\n";
                    }
                    serverMessage.ReplyLine(msg);
                    MessageBox.Show("تم الإرسال");
                    actions.Clear();
                    btnSend.Enabled = false;
                    deActivateActions();
                }
                else
                {
                    string errMSG = "الصادرات ارقام " + "\n";
                    for (int i = 0; i < exNu.Count; i++)
                    {
                        if (i == exNu.Count - 1)
                        {
                            errMSG += "(" + (exNu[i]) + ")" + "\n";
                            errMSG += "لم يتم أخذ قرار بشأنها";
                            break;
                        }
                        errMSG += "(" + (exNu[i]) + ")" + " ,";
                    }
                    MessageBox.Show(errMSG);
                }
            }
        }

        private void deActivateActions()
        {
            btnHandShow.Enabled = false;
            btnWait.Enabled = false;
            btnTypicalErrors.Enabled = false;
            btnAssing.Enabled = false;
            btnViewAfterSign.Enabled = false;
        }


        private void btnNext1_Click(object sender, EventArgs e)
        {
            if (filesArrow2 < fileNames2.Count - 1)
            {
                filesArrow2++;
                lblFileNO2.Text = (filesArrow2 + 1) + "";
                axAcroPDFExport.src = fileNames2[filesArrow2];
                updateActionList();
            }
        }

        private void pnlImport_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void btnPrev1_Click(object sender, EventArgs e)
        {
            if (filesArrow2 > 0)
            {
                filesArrow2--;
                lblFileNO2.Text = (filesArrow2 + 1) + "";
                axAcroPDFExport.src = fileNames2[filesArrow2];
                updateActionList();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnViewAfterSign_Click(object sender, EventArgs e)
        {
            if (thereIsExport)
            {
          
               if(signed[filesArrow2])
                { 
                    decision = "3" + fileNames2[filesArrow2];
                    actions[filesArrow2] = decision;
                    activatedActions[filesArrow2] =4 ;
                    updateActionList();
                }
                else
                {
                    MessageBox.Show("يجب توقيع الوثيقة اولاً");
                }
              
            }
        }

        private void updateActionList()
        {
          if(activatedActions[filesArrow2]==0)
            {
                btnHandShow.BackColor = Color.Green;
                btnHandShow.ForeColor = Color.White;
                btnWait.BackColor = Color.White;
                btnWait.ForeColor = Color.Green;
                btnTypicalErrors.BackColor = Color.White;
                btnTypicalErrors.ForeColor = Color.Green;
                btnAssing.BackColor = Color.White;
                btnAssing.ForeColor = Color.Green;
                btnViewAfterSign.BackColor = Color.White;
                btnViewAfterSign.ForeColor = Color.Green;
            }
           else if (activatedActions[filesArrow2] == 1)
            {
                btnHandShow.BackColor = Color.White;
                btnHandShow.ForeColor = Color.Green;
                btnWait.BackColor = Color.Green;
                btnWait.ForeColor = Color.White;
                btnTypicalErrors.BackColor = Color.White;
                btnTypicalErrors.ForeColor = Color.Green;
                btnAssing.BackColor = Color.White;
                btnAssing.ForeColor = Color.Green;
                btnViewAfterSign.BackColor = Color.White;
                btnViewAfterSign.ForeColor = Color.Green;
            }
            else if (activatedActions[filesArrow2] == 2)
            {
                btnHandShow.BackColor = Color.White;
                btnHandShow.ForeColor = Color.Green;
                btnWait.BackColor = Color.White;
                btnWait.ForeColor = Color.Green;
                btnTypicalErrors.BackColor = Color.Green;
                btnTypicalErrors.ForeColor = Color.White;
                btnAssing.BackColor = Color.White;
                btnAssing.ForeColor = Color.Green;
                btnViewAfterSign.BackColor = Color.White;
                btnViewAfterSign.ForeColor = Color.Green;
            }
            else if (activatedActions[filesArrow2] == 3)
            {
                btnHandShow.BackColor = Color.White;
                btnHandShow.ForeColor = Color.Green;
                btnWait.BackColor = Color.White;
                btnWait.ForeColor = Color.Green;
                btnTypicalErrors.BackColor = Color.White;
                btnTypicalErrors.ForeColor = Color.Green;
                btnAssing.BackColor = Color.Green;
                btnAssing.ForeColor = Color.White;
                btnViewAfterSign.BackColor = Color.White;
                btnViewAfterSign.ForeColor = Color.Green;
            }
            else if (activatedActions[filesArrow2] == 4)
            {
                btnHandShow.BackColor = Color.White;
                btnHandShow.ForeColor = Color.Green;
                btnWait.BackColor = Color.White;
                btnWait.ForeColor = Color.Green;
                btnTypicalErrors.BackColor = Color.White;
                btnTypicalErrors.ForeColor = Color.Green;
                btnAssing.BackColor = Color.White;
                btnAssing.ForeColor = Color.Green;
                btnViewAfterSign.BackColor = Color.Green;
                btnViewAfterSign.ForeColor = Color.White;
            }
            else if (activatedActions[filesArrow2] == -1)
            {
                btnHandShow.BackColor = Color.White;
                btnHandShow.ForeColor = Color.Green;
                btnWait.BackColor = Color.White;
                btnWait.ForeColor = Color.Green;
                btnTypicalErrors.BackColor = Color.White;
                btnTypicalErrors.ForeColor = Color.Green;
                btnAssing.BackColor = Color.White;
                btnAssing.ForeColor = Color.Green;
                btnViewAfterSign.BackColor = Color.White;
                btnViewAfterSign.ForeColor = Color.Green;
            }
        }
    }
}
