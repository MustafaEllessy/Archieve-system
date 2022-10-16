namespace ArchieveApplication
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
            this.btnImportSend = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFileNO = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFilesCount = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.pnlDeparts = new System.Windows.Forms.Panel();
            this.axAcroPDFImport = new AxAcroPDFLib.AxAcroPDF();
            this.pnlExport = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFileNO2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblFilesCount2 = new System.Windows.Forms.Label();
            this.btnNext1 = new System.Windows.Forms.Button();
            this.btnPrev1 = new System.Windows.Forms.Button();
            this.btnViewAfterSign = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnClose2 = new System.Windows.Forms.Button();
            this.btnAssing = new System.Windows.Forms.Button();
            this.btnTypicalErrors = new System.Windows.Forms.Button();
            this.btnWait = new System.Windows.Forms.Button();
            this.btnHandShow = new System.Windows.Forms.Button();
            this.axAcroPDFExport = new AxAcroPDFLib.AxAcroPDF();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblExport = new System.Windows.Forms.Label();
            this.lblImport = new System.Windows.Forms.Label();
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
            this.btnImport.Location = new System.Drawing.Point(677, 96);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(193, 55);
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
            this.btnExport.Location = new System.Drawing.Point(478, 96);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(193, 55);
            this.btnExport.TabIndex = 39;
            this.btnExport.Text = "صادر";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // pnlImport
            // 
            this.pnlImport.Controls.Add(this.btnClose);
            this.pnlImport.Controls.Add(this.btnImportSend);
            this.pnlImport.Controls.Add(this.label5);
            this.pnlImport.Controls.Add(this.lblFileNO);
            this.pnlImport.Controls.Add(this.label3);
            this.pnlImport.Controls.Add(this.lblFilesCount);
            this.pnlImport.Controls.Add(this.btnNext);
            this.pnlImport.Controls.Add(this.btnPrev);
            this.pnlImport.Controls.Add(this.pnlDeparts);
            this.pnlImport.Controls.Add(this.axAcroPDFImport);
            this.pnlImport.Location = new System.Drawing.Point(2, 157);
            this.pnlImport.Name = "pnlImport";
            this.pnlImport.Size = new System.Drawing.Size(1298, 574);
            this.pnlImport.TabIndex = 40;
            this.pnlImport.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlImport_Paint_2);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Green;
            this.btnClose.Location = new System.Drawing.Point(949, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(168, 40);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "إغلاق";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAgree_MouseDown);
            this.btnClose.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnAgree_MouseUp);
            // 
            // btnImportSend
            // 
            this.btnImportSend.BackColor = System.Drawing.Color.White;
            this.btnImportSend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImportSend.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportSend.ForeColor = System.Drawing.Color.Green;
            this.btnImportSend.Location = new System.Drawing.Point(1119, 1);
            this.btnImportSend.Name = "btnImportSend";
            this.btnImportSend.Size = new System.Drawing.Size(169, 40);
            this.btnImportSend.TabIndex = 20;
            this.btnImportSend.Text = "إرسال";
            this.btnImportSend.UseVisualStyleBackColor = false;
            this.btnImportSend.Click += new System.EventHandler(this.btnImportSend_Click);
            this.btnImportSend.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAgree_MouseDown);
            this.btnImportSend.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnAgree_MouseUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(50, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 35);
            this.label5.TabIndex = 15;
            this.label5.Text = "من";
            // 
            // lblFileNO
            // 
            this.lblFileNO.AutoSize = true;
            this.lblFileNO.BackColor = System.Drawing.Color.Transparent;
            this.lblFileNO.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileNO.ForeColor = System.Drawing.Color.Green;
            this.lblFileNO.Location = new System.Drawing.Point(94, 4);
            this.lblFileNO.Name = "lblFileNO";
            this.lblFileNO.Size = new System.Drawing.Size(32, 35);
            this.lblFileNO.TabIndex = 18;
            this.lblFileNO.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(126, 4);
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
            this.lblFilesCount.Location = new System.Drawing.Point(17, 4);
            this.lblFilesCount.Name = "lblFilesCount";
            this.lblFilesCount.Size = new System.Drawing.Size(32, 35);
            this.lblFilesCount.TabIndex = 16;
            this.lblFilesCount.Text = "0";
            this.lblFilesCount.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Green;
            this.btnNext.Location = new System.Drawing.Point(469, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(70, 37);
            this.btnNext.TabIndex = 13;
            this.btnNext.Text = "<";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            this.btnNext.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAgree_MouseDown);
            this.btnNext.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnAgree_MouseUp);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.White;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrev.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.ForeColor = System.Drawing.Color.Green;
            this.btnPrev.Location = new System.Drawing.Point(399, 3);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(67, 37);
            this.btnPrev.TabIndex = 14;
            this.btnPrev.Text = ">";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            this.btnPrev.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAgree_MouseDown);
            this.btnPrev.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnAgree_MouseUp);
            // 
            // pnlDeparts
            // 
            this.pnlDeparts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDeparts.Location = new System.Drawing.Point(948, 42);
            this.pnlDeparts.Name = "pnlDeparts";
            this.pnlDeparts.Size = new System.Drawing.Size(343, 528);
            this.pnlDeparts.TabIndex = 19;
            // 
            // axAcroPDFImport
            // 
            this.axAcroPDFImport.Enabled = true;
            this.axAcroPDFImport.Location = new System.Drawing.Point(6, 42);
            this.axAcroPDFImport.Name = "axAcroPDFImport";
            this.axAcroPDFImport.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDFImport.OcxState")));
            this.axAcroPDFImport.Size = new System.Drawing.Size(936, 522);
            this.axAcroPDFImport.TabIndex = 21;
            this.axAcroPDFImport.Enter += new System.EventHandler(this.axAcroPDFImport_Enter);
            // 
            // pnlExport
            // 
            this.pnlExport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlExport.Controls.Add(this.label2);
            this.pnlExport.Controls.Add(this.lblFileNO2);
            this.pnlExport.Controls.Add(this.label6);
            this.pnlExport.Controls.Add(this.lblFilesCount2);
            this.pnlExport.Controls.Add(this.btnNext1);
            this.pnlExport.Controls.Add(this.btnPrev1);
            this.pnlExport.Controls.Add(this.btnViewAfterSign);
            this.pnlExport.Controls.Add(this.btnSend);
            this.pnlExport.Controls.Add(this.btnClose2);
            this.pnlExport.Controls.Add(this.btnAssing);
            this.pnlExport.Controls.Add(this.btnTypicalErrors);
            this.pnlExport.Controls.Add(this.btnWait);
            this.pnlExport.Controls.Add(this.btnHandShow);
            this.pnlExport.Controls.Add(this.axAcroPDFExport);
            this.pnlExport.Location = new System.Drawing.Point(2, 158);
            this.pnlExport.Name = "pnlExport";
            this.pnlExport.Size = new System.Drawing.Size(1298, 574);
            this.pnlExport.TabIndex = 41;
            this.pnlExport.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlImport_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(38, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 35);
            this.label2.TabIndex = 21;
            this.label2.Text = "من";
            // 
            // lblFileNO2
            // 
            this.lblFileNO2.AutoSize = true;
            this.lblFileNO2.BackColor = System.Drawing.Color.Transparent;
            this.lblFileNO2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileNO2.ForeColor = System.Drawing.Color.Green;
            this.lblFileNO2.Location = new System.Drawing.Point(81, 5);
            this.lblFileNO2.Name = "lblFileNO2";
            this.lblFileNO2.Size = new System.Drawing.Size(32, 35);
            this.lblFileNO2.TabIndex = 24;
            this.lblFileNO2.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(113, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 35);
            this.label6.TabIndex = 23;
            this.label6.Text = "صادر";
            // 
            // lblFilesCount2
            // 
            this.lblFilesCount2.AutoSize = true;
            this.lblFilesCount2.BackColor = System.Drawing.Color.Transparent;
            this.lblFilesCount2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilesCount2.ForeColor = System.Drawing.Color.Green;
            this.lblFilesCount2.Location = new System.Drawing.Point(6, 5);
            this.lblFilesCount2.Name = "lblFilesCount2";
            this.lblFilesCount2.Size = new System.Drawing.Size(32, 35);
            this.lblFilesCount2.TabIndex = 22;
            this.lblFilesCount2.Text = "0";
            // 
            // btnNext1
            // 
            this.btnNext1.BackColor = System.Drawing.Color.White;
            this.btnNext1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext1.ForeColor = System.Drawing.Color.Green;
            this.btnNext1.Location = new System.Drawing.Point(579, 4);
            this.btnNext1.Name = "btnNext1";
            this.btnNext1.Size = new System.Drawing.Size(70, 37);
            this.btnNext1.TabIndex = 19;
            this.btnNext1.Text = "<";
            this.btnNext1.UseVisualStyleBackColor = false;
            this.btnNext1.Click += new System.EventHandler(this.btnNext1_Click);
            // 
            // btnPrev1
            // 
            this.btnPrev1.BackColor = System.Drawing.Color.White;
            this.btnPrev1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrev1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev1.ForeColor = System.Drawing.Color.Green;
            this.btnPrev1.Location = new System.Drawing.Point(509, 4);
            this.btnPrev1.Name = "btnPrev1";
            this.btnPrev1.Size = new System.Drawing.Size(67, 37);
            this.btnPrev1.TabIndex = 20;
            this.btnPrev1.Text = ">";
            this.btnPrev1.UseVisualStyleBackColor = false;
            this.btnPrev1.Click += new System.EventHandler(this.btnPrev1_Click);
            // 
            // btnViewAfterSign
            // 
            this.btnViewAfterSign.BackColor = System.Drawing.Color.White;
            this.btnViewAfterSign.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewAfterSign.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAfterSign.ForeColor = System.Drawing.Color.Green;
            this.btnViewAfterSign.Location = new System.Drawing.Point(1088, 329);
            this.btnViewAfterSign.Name = "btnViewAfterSign";
            this.btnViewAfterSign.Size = new System.Drawing.Size(196, 63);
            this.btnViewAfterSign.TabIndex = 14;
            this.btnViewAfterSign.Text = "عرض النسخة الموقعة";
            this.btnViewAfterSign.UseVisualStyleBackColor = false;
            this.btnViewAfterSign.Click += new System.EventHandler(this.btnViewAfterSign_Click);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.White;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSend.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.Green;
            this.btnSend.Location = new System.Drawing.Point(1088, 398);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(196, 53);
            this.btnSend.TabIndex = 14;
            this.btnSend.Text = "إرسال";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnClose2
            // 
            this.btnClose2.BackColor = System.Drawing.Color.White;
            this.btnClose2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose2.ForeColor = System.Drawing.Color.Green;
            this.btnClose2.Location = new System.Drawing.Point(1088, 457);
            this.btnClose2.Name = "btnClose2";
            this.btnClose2.Size = new System.Drawing.Size(196, 53);
            this.btnClose2.TabIndex = 13;
            this.btnClose2.Text = "إغلاق";
            this.btnClose2.UseVisualStyleBackColor = false;
            this.btnClose2.Click += new System.EventHandler(this.btnClose2_Click);
            // 
            // btnAssing
            // 
            this.btnAssing.BackColor = System.Drawing.Color.White;
            this.btnAssing.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAssing.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssing.ForeColor = System.Drawing.Color.Green;
            this.btnAssing.Location = new System.Drawing.Point(1088, 269);
            this.btnAssing.Name = "btnAssing";
            this.btnAssing.Size = new System.Drawing.Size(196, 53);
            this.btnAssing.TabIndex = 10;
            this.btnAssing.Text = "توقيع";
            this.btnAssing.UseVisualStyleBackColor = false;
            this.btnAssing.Click += new System.EventHandler(this.btnAssing_Click);
            // 
            // btnTypicalErrors
            // 
            this.btnTypicalErrors.BackColor = System.Drawing.Color.White;
            this.btnTypicalErrors.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTypicalErrors.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTypicalErrors.ForeColor = System.Drawing.Color.Green;
            this.btnTypicalErrors.Location = new System.Drawing.Point(1090, 210);
            this.btnTypicalErrors.Name = "btnTypicalErrors";
            this.btnTypicalErrors.Size = new System.Drawing.Size(196, 53);
            this.btnTypicalErrors.TabIndex = 6;
            this.btnTypicalErrors.Text = "أخطاء إملائية وتنسيق";
            this.btnTypicalErrors.UseVisualStyleBackColor = false;
            this.btnTypicalErrors.Click += new System.EventHandler(this.btnTypicalErrors_Click);
            // 
            // btnWait
            // 
            this.btnWait.BackColor = System.Drawing.Color.White;
            this.btnWait.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnWait.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWait.ForeColor = System.Drawing.Color.Green;
            this.btnWait.Location = new System.Drawing.Point(1088, 152);
            this.btnWait.Name = "btnWait";
            this.btnWait.Size = new System.Drawing.Size(196, 53);
            this.btnWait.TabIndex = 7;
            this.btnWait.Text = "تأجيل";
            this.btnWait.UseVisualStyleBackColor = false;
            this.btnWait.Click += new System.EventHandler(this.btnWait_Click);
            // 
            // btnHandShow
            // 
            this.btnHandShow.BackColor = System.Drawing.Color.White;
            this.btnHandShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHandShow.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHandShow.ForeColor = System.Drawing.Color.Green;
            this.btnHandShow.Location = new System.Drawing.Point(1088, 95);
            this.btnHandShow.Name = "btnHandShow";
            this.btnHandShow.Size = new System.Drawing.Size(196, 53);
            this.btnHandShow.TabIndex = 9;
            this.btnHandShow.Text = "عرض باليد";
            this.btnHandShow.UseVisualStyleBackColor = false;
            this.btnHandShow.Click += new System.EventHandler(this.btnHandShow_Click);
            // 
            // axAcroPDFExport
            // 
            this.axAcroPDFExport.Enabled = true;
            this.axAcroPDFExport.Location = new System.Drawing.Point(3, 44);
            this.axAcroPDFExport.Name = "axAcroPDFExport";
            this.axAcroPDFExport.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDFExport.OcxState")));
            this.axAcroPDFExport.Size = new System.Drawing.Size(1079, 524);
            this.axAcroPDFExport.TabIndex = 12;
            this.axAcroPDFExport.Enter += new System.EventHandler(this.axAcroPDFExport_Enter);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ArchieveApplication.Properties.Resources.logoLastT;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1298, 85);
            this.panel1.TabIndex = 44;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(299, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 32);
            this.label1.TabIndex = 47;
            this.label1.Text = "رئيس الهيئة";
            // 
            // lblExport
            // 
            this.lblExport.AutoSize = true;
            this.lblExport.BackColor = System.Drawing.Color.Red;
            this.lblExport.ForeColor = System.Drawing.Color.White;
            this.lblExport.Location = new System.Drawing.Point(634, 108);
            this.lblExport.Name = "lblExport";
            this.lblExport.Size = new System.Drawing.Size(30, 33);
            this.lblExport.TabIndex = 50;
            this.lblExport.Text = "0";
            // 
            // lblImport
            // 
            this.lblImport.AutoSize = true;
            this.lblImport.BackColor = System.Drawing.Color.Red;
            this.lblImport.ForeColor = System.Drawing.Color.White;
            this.lblImport.Location = new System.Drawing.Point(831, 109);
            this.lblImport.Name = "lblImport";
            this.lblImport.Size = new System.Drawing.Size(30, 33);
            this.lblImport.TabIndex = 49;
            this.lblImport.Text = "0";
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
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnImport);
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
            this.Load += new System.EventHandler(this.MainMenu_Load);
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
        private System.Windows.Forms.Button btnTypicalErrors;
        private System.Windows.Forms.Button btnWait;
        private System.Windows.Forms.Button btnHandShow;
        private System.Windows.Forms.Button btnAssing;
        private System.Windows.Forms.Label lblFileNO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFilesCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel pnlDeparts;
        private System.Windows.Forms.Button btnImportSend;
        private AxAcroPDFLib.AxAcroPDF axAcroPDFImport;
        private System.Windows.Forms.Panel panel1;
        public AxAcroPDFLib.AxAcroPDF axAcroPDFExport;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClose2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFileNO2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblFilesCount2;
        private System.Windows.Forms.Button btnNext1;
        private System.Windows.Forms.Button btnPrev1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnViewAfterSign;
        private System.Windows.Forms.Label lblExport;
        private System.Windows.Forms.Label lblImport;
    }
}