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
namespace ArchieveApplication
{
    public partial class Export : Form
    {
        public Export()
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
        SimpleTcpClient client;
        SimpleTCP.Message serverMessage;
        //int convCounter = 0;
        private void Export_Load(object sender, EventArgs e)
        {
            //convCounter = 0;
            //label2.Text = convCounter+"";
            //label1.Text = "";
            //textBox2.Text = "";
            client = new SimpleTcpClient();
            client.StringEncoder = Encoding.UTF8;
            client.DataReceived += client_DataRecieved;
            try
            {
                client.Connect("127.0.0.1", Convert.ToInt32("8910"));
            }
            catch (Exception ex)
            {
                MessageBox.Show("يوجد خطأ فى الإتصال");
                this.Close();
            }

        }
        private void client_DataRecieved(object sender, SimpleTCP.Message e)
        {
            serverMessage = e;
            string fileName = "";
            string clientTxt = serverMessage.MessageString.Trim('\u0013');
            string[] clientMsgLines = clientTxt.Split('\n');
            if(clientMsgLines[0]=="1")
            {
                fileName = clientMsgLines[1];
                textBox1.Invoke((MethodInvoker)delegate { textBox1.Text = (clientMsgLines[2] == "1") ? "تمت المراجعة" : "لم تتم المراجعة"; });
                axAcroPDF1.Invoke((MethodInvoker)delegate { axAcroPDF1.src = fileName; });
            }
            //if (clientMsgLines[0] == "5")
            //{
            //    convCounter++;
            //    label2.Invoke((MethodInvoker)delegate { label2.Text = convCounter + ""; });
            //    label1.Invoke((MethodInvoker)delegate { label1.Text += ("حسن عامر: " + clientMsgLines[1])+"\n"; });
            //}


        }
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            if(ofd.ShowDialog()==DialogResult.OK)
            {
                axAcroPDF1.src = ofd.FileName;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            serverMessage.ReplyLine("0");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serverMessage.ReplyLine("1");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            serverMessage.ReplyLine("2");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            serverMessage.ReplyLine("3");
        }

        private void axAcroPDF1_Enter(object sender, EventArgs e)
        {

        }

        //private void button6_Click(object sender, EventArgs e)
        //{
        //    panel1.Visible = true;
        //    convCounter = 0;
        //    label2.Text = convCounter + "";
        //}

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        //private void button8_Click(object sender, EventArgs e)
        //{
        //    panel1.Visible = false;
        //    convCounter = 0;
        //    label2.Text = convCounter + "";
        //}

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //private void button7_Click(object sender, EventArgs e)
        //{
        //    serverMessage.ReplyLine("5\n"+textBox2.Text);
        //}
    }
}
