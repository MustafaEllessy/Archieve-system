namespace ArchieveServerVersion
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.btnImport = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.pnlImport = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSendImports = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnAttachImports = new System.Windows.Forms.Button();
            this.pnlDeparts = new System.Windows.Forms.Panel();
            this.lblFileNO = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFilesCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.axAcroPDFImport = new AxAcroPDFLib.AxAcroPDF();
            this.pnlExport = new System.Windows.Forms.Panel();
            this.btnPrintExport = new System.Windows.Forms.Button();
            this.lblFileNO2 = new System.Windows.Forms.Label();
            this.btnNext1 = new System.Windows.Forms.Button();
            this.btnPrev1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblFilesCount2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClose2 = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnAttachExport = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.axAcroPDFExport = new AxAcroPDFLib.AxAcroPDF();
            this.label4 = new System.Windows.Forms.Label();
            this.ofdImports = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.lblImport = new System.Windows.Forms.Label();
            this.lblExport = new System.Windows.Forms.Label();
            this.pnlImport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDFImport)).BeginInit();
            this.pnlExport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDFExport)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.White;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImport.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ForeColor = System.Drawing.Color.Green;
            this.btnImport.Location = new System.Drawing.Point(681, 96);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(193, 56);
            this.btnImport.TabIndex = 39;
            this.btnImport.Text = "وارد";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.White;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExport.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.Green;
            this.btnExport.Location = new System.Drawing.Point(482, 96);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(193, 56);
            this.btnExport.TabIndex = 39;
            this.btnExport.Text = "صادر";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // pnlImport
            // 
            this.pnlImport.BackColor = System.Drawing.Color.Khaki;
            this.pnlImport.Controls.Add(this.btnClose);
            this.pnlImport.Controls.Add(this.btnSendImports);
            this.pnlImport.Controls.Add(this.btnPrint);
            this.pnlImport.Controls.Add(this.btnAttachImports);
            this.pnlImport.Controls.Add(this.pnlDeparts);
            this.pnlImport.Controls.Add(this.lblFileNO);
            this.pnlImport.Controls.Add(this.btnNext);
            this.pnlImport.Controls.Add(this.btnPrev);
            this.pnlImport.Controls.Add(this.label3);
            this.pnlImport.Controls.Add(this.lblFilesCount);
            this.pnlImport.Controls.Add(this.label5);
            this.pnlImport.Controls.Add(this.axAcroPDFImport);
            this.pnlImport.Location = new System.Drawing.Point(2, 157);
            this.pnlImport.Name = "pnlImport";
            this.pnlImport.Size = new System.Drawing.Size(1298, 574);
            this.pnlImport.TabIndex = 40;
            this.pnlImport.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlImport_Paint_1);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Green;
            this.btnClose.Location = new System.Drawing.Point(942, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(81, 40);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "إغلاق";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.button1_Click_1);
            this.btnClose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAttachExport_MouseDown);
            this.btnClose.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnAttachExport_MouseUp);
            // 
            // btnSendImports
            // 
            this.btnSendImports.BackColor = System.Drawing.Color.White;
            this.btnSendImports.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSendImports.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendImports.ForeColor = System.Drawing.Color.Green;
            this.btnSendImports.Location = new System.Drawing.Point(1021, 5);
            this.btnSendImports.Name = "btnSendImports";
            this.btnSendImports.Size = new System.Drawing.Size(107, 40);
            this.btnSendImports.TabIndex = 20;
            this.btnSendImports.Text = "إرسال";
            this.btnSendImports.UseVisualStyleBackColor = false;
            this.btnSendImports.Click += new System.EventHandler(this.btnSendImports_Click);
            this.btnSendImports.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAttachExport_MouseDown);
            this.btnSendImports.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnAttachExport_MouseUp);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.White;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrint.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.Green;
            this.btnPrint.Location = new System.Drawing.Point(808, 6);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(121, 40);
            this.btnPrint.TabIndex = 20;
            this.btnPrint.Text = "طباعة";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            this.btnPrint.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAttachExport_MouseDown);
            this.btnPrint.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnAttachExport_MouseUp);
            // 
            // btnAttachImports
            // 
            this.btnAttachImports.BackColor = System.Drawing.Color.White;
            this.btnAttachImports.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAttachImports.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttachImports.ForeColor = System.Drawing.Color.Green;
            this.btnAttachImports.Location = new System.Drawing.Point(1127, 5);
            this.btnAttachImports.Name = "btnAttachImports";
            this.btnAttachImports.Size = new System.Drawing.Size(159, 40);
            this.btnAttachImports.TabIndex = 20;
            this.btnAttachImports.Text = "إرفاق الواردات";
            this.btnAttachImports.UseVisualStyleBackColor = false;
            this.btnAttachImports.Click += new System.EventHandler(this.btnAttachImports_Click);
            this.btnAttachImports.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAttachExport_MouseDown);
            this.btnAttachImports.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnAttachExport_MouseUp);
            // 
            // pnlDeparts
            // 
            this.pnlDeparts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDeparts.Location = new System.Drawing.Point(935, 54);
            this.pnlDeparts.Name = "pnlDeparts";
            this.pnlDeparts.Size = new System.Drawing.Size(353, 506);
            this.pnlDeparts.TabIndex = 19;
            // 
            // lblFileNO
            // 
            this.lblFileNO.AutoSize = true;
            this.lblFileNO.BackColor = System.Drawing.Color.Transparent;
            this.lblFileNO.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileNO.ForeColor = System.Drawing.Color.Green;
            this.lblFileNO.Location = new System.Drawing.Point(84, 11);
            this.lblFileNO.Name = "lblFileNO";
            this.lblFileNO.Size = new System.Drawing.Size(32, 35);
            this.lblFileNO.TabIndex = 18;
            this.lblFileNO.Text = "0";
            this.lblFileNO.Click += new System.EventHandler(this.lblFileNO_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Green;
            this.btnNext.Location = new System.Drawing.Point(456, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(70, 40);
            this.btnNext.TabIndex = 13;
            this.btnNext.Text = "<";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            this.btnNext.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAttachExport_MouseDown);
            this.btnNext.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnAttachExport_MouseUp);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.White;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrev.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.ForeColor = System.Drawing.Color.Green;
            this.btnPrev.Location = new System.Drawing.Point(384, 5);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(70, 40);
            this.btnPrev.TabIndex = 14;
            this.btnPrev.Text = ">";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            this.btnPrev.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAttachExport_MouseDown);
            this.btnPrev.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnAttachExport_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(120, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 35);
            this.label3.TabIndex = 17;
            this.label3.Text = "وارد ";
            // 
            // lblFilesCount
            // 
            this.lblFilesCount.AutoSize = true;
            this.lblFilesCount.BackColor = System.Drawing.Color.Transparent;
            this.lblFilesCount.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilesCount.ForeColor = System.Drawing.Color.Green;
            this.lblFilesCount.Location = new System.Drawing.Point(1, 11);
            this.lblFilesCount.Name = "lblFilesCount";
            this.lblFilesCount.Size = new System.Drawing.Size(32, 35);
            this.lblFilesCount.TabIndex = 16;
            this.lblFilesCount.Text = "0";
            this.lblFilesCount.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(37, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 35);
            this.label5.TabIndex = 15;
            this.label5.Text = "من";
            // 
            // axAcroPDFImport
            // 
            this.axAcroPDFImport.Enabled = true;
            this.axAcroPDFImport.Location = new System.Drawing.Point(3, 54);
            this.axAcroPDFImport.Name = "axAcroPDFImport";
            this.axAcroPDFImport.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDFImport.OcxState")));
            this.axAcroPDFImport.Size = new System.Drawing.Size(926, 506);
            this.axAcroPDFImport.TabIndex = 21;
            // 
            // pnlExport
            // 
            this.pnlExport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlExport.Controls.Add(this.btnPrintExport);
            this.pnlExport.Controls.Add(this.lblFileNO2);
            this.pnlExport.Controls.Add(this.btnNext1);
            this.pnlExport.Controls.Add(this.btnPrev1);
            this.pnlExport.Controls.Add(this.label6);
            this.pnlExport.Controls.Add(this.lblFilesCount2);
            this.pnlExport.Controls.Add(this.label8);
            this.pnlExport.Controls.Add(this.btnClose2);
            this.pnlExport.Controls.Add(this.btnSend);
            this.pnlExport.Controls.Add(this.btnAttachExport);
            this.pnlExport.Controls.Add(this.lblStatus);
            this.pnlExport.Controls.Add(this.axAcroPDFExport);
            this.pnlExport.Controls.Add(this.label4);
            this.pnlExport.Location = new System.Drawing.Point(2, 158);
            this.pnlExport.Name = "pnlExport";
            this.pnlExport.Size = new System.Drawing.Size(1298, 574);
            this.pnlExport.TabIndex = 41;
            this.pnlExport.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlImport_Paint);
            // 
            // btnPrintExport
            // 
            this.btnPrintExport.BackColor = System.Drawing.Color.White;
            this.btnPrintExport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrintExport.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintExport.ForeColor = System.Drawing.Color.Green;
            this.btnPrintExport.Location = new System.Drawing.Point(1103, 376);
            this.btnPrintExport.Name = "btnPrintExport";
            this.btnPrintExport.Size = new System.Drawing.Size(184, 65);
            this.btnPrintExport.TabIndex = 29;
            this.btnPrintExport.Text = "طباعة";
            this.btnPrintExport.UseVisualStyleBackColor = false;
            this.btnPrintExport.Click += new System.EventHandler(this.btnPrintExport_Click);
            // 
            // lblFileNO2
            // 
            this.lblFileNO2.AutoSize = true;
            this.lblFileNO2.BackColor = System.Drawing.Color.Transparent;
            this.lblFileNO2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileNO2.ForeColor = System.Drawing.Color.Green;
            this.lblFileNO2.Location = new System.Drawing.Point(92, 4);
            this.lblFileNO2.Name = "lblFileNO2";
            this.lblFileNO2.Size = new System.Drawing.Size(32, 35);
            this.lblFileNO2.TabIndex = 28;
            this.lblFileNO2.Text = "0";
            // 
            // btnNext1
            // 
            this.btnNext1.BackColor = System.Drawing.Color.White;
            this.btnNext1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext1.ForeColor = System.Drawing.Color.Green;
            this.btnNext1.Location = new System.Drawing.Point(571, 4);
            this.btnNext1.Name = "btnNext1";
            this.btnNext1.Size = new System.Drawing.Size(70, 37);
            this.btnNext1.TabIndex = 23;
            this.btnNext1.Text = "<";
            this.btnNext1.UseVisualStyleBackColor = false;
            this.btnNext1.Click += new System.EventHandler(this.btnNext1_Click);
            // 
            // btnPrev1
            // 
            this.btnPrev1.BackColor = System.Drawing.Color.White;
            this.btnPrev1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrev1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev1.ForeColor = System.Drawing.Color.Green;
            this.btnPrev1.Location = new System.Drawing.Point(499, 4);
            this.btnPrev1.Name = "btnPrev1";
            this.btnPrev1.Size = new System.Drawing.Size(70, 37);
            this.btnPrev1.TabIndex = 24;
            this.btnPrev1.Text = ">";
            this.btnPrev1.UseVisualStyleBackColor = false;
            this.btnPrev1.Click += new System.EventHandler(this.btnPrev1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(128, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 35);
            this.label6.TabIndex = 27;
            this.label6.Text = "صادر";
            // 
            // lblFilesCount2
            // 
            this.lblFilesCount2.AutoSize = true;
            this.lblFilesCount2.BackColor = System.Drawing.Color.Transparent;
            this.lblFilesCount2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilesCount2.ForeColor = System.Drawing.Color.Green;
            this.lblFilesCount2.Location = new System.Drawing.Point(9, 4);
            this.lblFilesCount2.Name = "lblFilesCount2";
            this.lblFilesCount2.Size = new System.Drawing.Size(32, 35);
            this.lblFilesCount2.TabIndex = 26;
            this.lblFilesCount2.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Green;
            this.label8.Location = new System.Drawing.Point(45, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 35);
            this.label8.TabIndex = 25;
            this.label8.Text = "من";
            // 
            // btnClose2
            // 
            this.btnClose2.BackColor = System.Drawing.Color.White;
            this.btnClose2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose2.ForeColor = System.Drawing.Color.Green;
            this.btnClose2.Location = new System.Drawing.Point(1104, 460);
            this.btnClose2.Name = "btnClose2";
            this.btnClose2.Size = new System.Drawing.Size(183, 64);
            this.btnClose2.TabIndex = 21;
            this.btnClose2.Text = "إغلاق";
            this.btnClose2.UseVisualStyleBackColor = false;
            this.btnClose2.Click += new System.EventHandler(this.btnClose2_Click);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.White;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSend.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.Green;
            this.btnSend.Location = new System.Drawing.Point(1101, 294);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(187, 64);
            this.btnSend.TabIndex = 20;
            this.btnSend.Text = "إرسال";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            this.btnSend.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAttachExport_MouseDown);
            this.btnSend.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnAttachExport_MouseUp);
            // 
            // btnAttachExport
            // 
            this.btnAttachExport.BackColor = System.Drawing.Color.White;
            this.btnAttachExport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAttachExport.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttachExport.ForeColor = System.Drawing.Color.Green;
            this.btnAttachExport.Location = new System.Drawing.Point(1101, 214);
            this.btnAttachExport.Name = "btnAttachExport";
            this.btnAttachExport.Size = new System.Drawing.Size(187, 65);
            this.btnAttachExport.TabIndex = 18;
            this.btnAttachExport.Text = "إرفاق الصادرات";
            this.btnAttachExport.UseVisualStyleBackColor = false;
            this.btnAttachExport.Click += new System.EventHandler(this.btnAttachExport_Click);
            this.btnAttachExport.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAttachExport_MouseDown);
            this.btnAttachExport.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnAttachExport_MouseUp);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.White;
            this.lblStatus.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Green;
            this.lblStatus.Location = new System.Drawing.Point(1125, 75);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblStatus.Size = new System.Drawing.Size(111, 32);
            this.lblStatus.TabIndex = 16;
            this.lblStatus.Text = "لا يوجد رد";
            // 
            // axAcroPDFExport
            // 
            this.axAcroPDFExport.Enabled = true;
            this.axAcroPDFExport.Location = new System.Drawing.Point(1, 46);
            this.axAcroPDFExport.Name = "axAcroPDFExport";
            this.axAcroPDFExport.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDFExport.OcxState")));
            this.axAcroPDFExport.Size = new System.Drawing.Size(1090, 522);
            this.axAcroPDFExport.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.ForestGreen;
            this.label4.Location = new System.Drawing.Point(1112, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 43);
            this.label4.TabIndex = 15;
            this.label4.Text = "حالة الصادر:";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ArchieveServerVersion.Properties.Resources.logoLastT;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1298, 85);
            this.panel1.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(278, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 32);
            this.label1.TabIndex = 46;
            this.label1.Text = "إدارة الأرشيف";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // lblImport
            // 
            this.lblImport.AutoSize = true;
            this.lblImport.BackColor = System.Drawing.Color.Red;
            this.lblImport.ForeColor = System.Drawing.Color.White;
            this.lblImport.Location = new System.Drawing.Point(825, 105);
            this.lblImport.Name = "lblImport";
            this.lblImport.Size = new System.Drawing.Size(30, 33);
            this.lblImport.TabIndex = 47;
            this.lblImport.Text = "0";
            // 
            // lblExport
            // 
            this.lblExport.AutoSize = true;
            this.lblExport.BackColor = System.Drawing.Color.Red;
            this.lblExport.ForeColor = System.Drawing.Color.White;
            this.lblExport.Location = new System.Drawing.Point(631, 105);
            this.lblExport.Name = "lblExport";
            this.lblExport.Size = new System.Drawing.Size(30, 33);
            this.lblExport.TabIndex = 48;
            this.lblExport.Text = "0";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1301, 733);
            this.Controls.Add(this.lblExport);
            this.Controls.Add(this.lblImport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.pnlExport);
            this.Controls.Add(this.pnlImport);
            this.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainMenu";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Client Version";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainMenu_Load_1);
            this.Resize += new System.EventHandler(this.MainMenu_Resize);
            this.pnlImport.ResumeLayout(false);
            this.pnlImport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDFImport)).EndInit();
            this.pnlExport.ResumeLayout(false);
            this.pnlExport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDFExport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Panel pnlImport;
        private System.Windows.Forms.Panel pnlExport;
        private System.Windows.Forms.Label lblFileNO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFilesCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel pnlDeparts;
        private System.Windows.Forms.Button btnAttachImports;
        private AxAcroPDFLib.AxAcroPDF axAcroPDFImport;
        private System.Windows.Forms.OpenFileDialog ofdImports;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnAttachExport;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClose2;
        private System.Windows.Forms.Label label1;
        private AxAcroPDFLib.AxAcroPDF axAcroPDFExport;
        private System.Windows.Forms.Button btnSendImports;
        private System.Windows.Forms.Label lblFileNO2;
        private System.Windows.Forms.Button btnNext1;
        private System.Windows.Forms.Button btnPrev1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblFilesCount2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button btnPrintExport;
        private System.Windows.Forms.Label lblImport;
        private System.Windows.Forms.Label lblExport;
    }
}