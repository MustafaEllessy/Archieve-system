namespace ArchieveApplication
{
    partial class ElectronicSigning
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
            this.pnlMainImport = new System.Windows.Forms.Panel();
            this.pnlSignture = new System.Windows.Forms.Panel();
            this.btnAgree = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlMainImport
            // 
            this.pnlMainImport.AllowDrop = true;
            this.pnlMainImport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMainImport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMainImport.Location = new System.Drawing.Point(343, 92);
            this.pnlMainImport.Name = "pnlMainImport";
            this.pnlMainImport.Size = new System.Drawing.Size(661, 553);
            this.pnlMainImport.TabIndex = 46;
            this.pnlMainImport.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlMainImport_DragDrop);
            this.pnlMainImport.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnlMainImport_DragEnter);
            this.pnlMainImport.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMainImport_Paint);
            // 
            // pnlSignture
            // 
            this.pnlSignture.AllowDrop = true;
            this.pnlSignture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSignture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSignture.Location = new System.Drawing.Point(570, 656);
            this.pnlSignture.Name = "pnlSignture";
            this.pnlSignture.Size = new System.Drawing.Size(151, 48);
            this.pnlSignture.TabIndex = 0;
            this.pnlSignture.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnlSignture_DragEnter);
            this.pnlSignture.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSignture_Paint);
            this.pnlSignture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlSignture_MouseDown);
            // 
            // btnAgree
            // 
            this.btnAgree.BackColor = System.Drawing.Color.White;
            this.btnAgree.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgree.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgree.ForeColor = System.Drawing.Color.Green;
            this.btnAgree.Location = new System.Drawing.Point(140, 261);
            this.btnAgree.Name = "btnAgree";
            this.btnAgree.Size = new System.Drawing.Size(127, 55);
            this.btnAgree.TabIndex = 48;
            this.btnAgree.Text = "موافق";
            this.btnAgree.UseVisualStyleBackColor = false;
            this.btnAgree.Click += new System.EventHandler(this.btnAgree_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.White;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrev.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.ForeColor = System.Drawing.Color.Green;
            this.btnPrev.Location = new System.Drawing.Point(936, 651);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(68, 44);
            this.btnPrev.TabIndex = 50;
            this.btnPrev.Text = ">";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Green;
            this.btnNext.Location = new System.Drawing.Point(867, 651);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(68, 44);
            this.btnNext.TabIndex = 49;
            this.btnNext.Text = "<";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackgroundImage = global::ArchieveApplication.Properties.Resources.return_icon_png_1;
            this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReturn.Location = new System.Drawing.Point(352, 656);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(46, 39);
            this.btnReturn.TabIndex = 47;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::ArchieveApplication.Properties.Resources.logoLastT;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1298, 85);
            this.panel2.TabIndex = 51;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Green;
            this.btnClose.Location = new System.Drawing.Point(140, 344);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(127, 55);
            this.btnClose.TabIndex = 52;
            this.btnClose.Text = "إغلاق";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ElectronicSigning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1301, 733);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnAgree);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.pnlSignture);
            this.Controls.Add(this.pnlMainImport);
            this.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ElectronicSigning";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "وارد";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ElectronicSigning_Load);
            this.Resize += new System.EventHandler(this.MainMenu_Resize);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlMainImport;
        private System.Windows.Forms.Panel pnlSignture;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnAgree;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClose;
    }
}