namespace CBZCompressor
{
    partial class CBZCompressor
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.coverImage = new System.Windows.Forms.PictureBox();
            this.originFolderFull = new System.Windows.Forms.ListBox();
            this.destinationFiles = new System.Windows.Forms.ListBox();
            this.originFolders = new System.Windows.Forms.ListBox();
            this.loadFolders = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pathFolders = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.originFilesFull = new System.Windows.Forms.ListBox();
            this.destinationFolders = new System.Windows.Forms.ListBox();
            this.originFiles = new System.Windows.Forms.ListBox();
            this.LoadCbrs = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pathCbrs = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.StatusMessage = new System.Windows.Forms.Label();
            this.processBtn = new System.Windows.Forms.Button();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.button2 = new System.Windows.Forms.Button();
            this.cbrNameExceps = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.cbrExc = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coverImage)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1018, 371);
            this.tabControl1.TabIndex = 14;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.checkBox2);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.coverImage);
            this.tabPage1.Controls.Add(this.originFolderFull);
            this.tabPage1.Controls.Add(this.destinationFiles);
            this.tabPage1.Controls.Add(this.originFolders);
            this.tabPage1.Controls.Add(this.loadFolders);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.pathFolders);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(733, 345);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Compress";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(573, 39);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(85, 17);
            this.checkBox2.TabIndex = 59;
            this.checkBox2.Text = "Delete origin";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(573, 15);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(118, 17);
            this.checkBox1.TabIndex = 58;
            this.checkBox1.Text = "Rotate if landscape";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // coverImage
            // 
            this.coverImage.Location = new System.Drawing.Point(524, 70);
            this.coverImage.Name = "coverImage";
            this.coverImage.Size = new System.Drawing.Size(202, 263);
            this.coverImage.TabIndex = 57;
            this.coverImage.TabStop = false;
            // 
            // originFolderFull
            // 
            this.originFolderFull.FormattingEnabled = true;
            this.originFolderFull.Location = new System.Drawing.Point(745, 69);
            this.originFolderFull.Name = "originFolderFull";
            this.originFolderFull.ScrollAlwaysVisible = true;
            this.originFolderFull.Size = new System.Drawing.Size(251, 264);
            this.originFolderFull.TabIndex = 55;
            this.originFolderFull.Visible = false;
            // 
            // destinationFiles
            // 
            this.destinationFiles.FormattingEnabled = true;
            this.destinationFiles.Location = new System.Drawing.Point(266, 70);
            this.destinationFiles.Name = "destinationFiles";
            this.destinationFiles.ScrollAlwaysVisible = true;
            this.destinationFiles.Size = new System.Drawing.Size(251, 264);
            this.destinationFiles.TabIndex = 53;
            // 
            // originFolders
            // 
            this.originFolders.FormattingEnabled = true;
            this.originFolders.Location = new System.Drawing.Point(7, 70);
            this.originFolders.Name = "originFolders";
            this.originFolders.ScrollAlwaysVisible = true;
            this.originFolders.Size = new System.Drawing.Size(251, 264);
            this.originFolders.TabIndex = 52;
            this.originFolders.SelectedIndexChanged += new System.EventHandler(this.OriginFolders_SelectedIndexChanged);
            // 
            // loadFolders
            // 
            this.loadFolders.Location = new System.Drawing.Point(450, 17);
            this.loadFolders.Name = "loadFolders";
            this.loadFolders.Size = new System.Drawing.Size(65, 23);
            this.loadFolders.TabIndex = 51;
            this.loadFolders.Text = "Load";
            this.loadFolders.UseVisualStyleBackColor = true;
            this.loadFolders.Click += new System.EventHandler(this.LoadFolders_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(265, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "Destination Folder";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "File Origin";
            // 
            // pathFolders
            // 
            this.pathFolders.Location = new System.Drawing.Point(78, 19);
            this.pathFolders.Name = "pathFolders";
            this.pathFolders.Size = new System.Drawing.Size(366, 20);
            this.pathFolders.TabIndex = 40;
            this.pathFolders.Text = "D:\\VPK\\Zip";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Path";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.cbrNameExceps);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.cbrExc);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.originFilesFull);
            this.tabPage2.Controls.Add(this.destinationFolders);
            this.tabPage2.Controls.Add(this.originFiles);
            this.tabPage2.Controls.Add(this.LoadCbrs);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.pathCbrs);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1010, 345);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Extract";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // originFilesFull
            // 
            this.originFilesFull.FormattingEnabled = true;
            this.originFilesFull.Location = new System.Drawing.Point(704, 74);
            this.originFilesFull.Name = "originFilesFull";
            this.originFilesFull.Size = new System.Drawing.Size(246, 264);
            this.originFilesFull.TabIndex = 70;
            this.originFilesFull.Visible = false;
            // 
            // destinationFolders
            // 
            this.destinationFolders.FormattingEnabled = true;
            this.destinationFolders.Location = new System.Drawing.Point(389, 74);
            this.destinationFolders.Name = "destinationFolders";
            this.destinationFolders.Size = new System.Drawing.Size(618, 264);
            this.destinationFolders.TabIndex = 68;
            // 
            // originFiles
            // 
            this.originFiles.FormattingEnabled = true;
            this.originFiles.Location = new System.Drawing.Point(194, 74);
            this.originFiles.Name = "originFiles";
            this.originFiles.Size = new System.Drawing.Size(188, 264);
            this.originFiles.TabIndex = 67;
            this.originFiles.SelectedIndexChanged += new System.EventHandler(this.originFiles_SelectedIndexChanged);
            // 
            // LoadCbrs
            // 
            this.LoadCbrs.Location = new System.Drawing.Point(447, 25);
            this.LoadCbrs.Name = "LoadCbrs";
            this.LoadCbrs.Size = new System.Drawing.Size(65, 23);
            this.LoadCbrs.TabIndex = 66;
            this.LoadCbrs.Text = "Load";
            this.LoadCbrs.UseVisualStyleBackColor = true;
            this.LoadCbrs.Click += new System.EventHandler(this.LoadCbrs_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(388, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 13);
            this.label13.TabIndex = 60;
            this.label13.Text = "Destination Folder";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(192, 58);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 13);
            this.label14.TabIndex = 59;
            this.label14.Text = "File Origin";
            // 
            // pathCbrs
            // 
            this.pathCbrs.Location = new System.Drawing.Point(75, 27);
            this.pathCbrs.Name = "pathCbrs";
            this.pathCbrs.Size = new System.Drawing.Size(366, 20);
            this.pathCbrs.TabIndex = 58;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 13);
            this.label15.TabIndex = 57;
            this.label15.Text = "Path";
            // 
            // StatusMessage
            // 
            this.StatusMessage.AutoSize = true;
            this.StatusMessage.Location = new System.Drawing.Point(589, 389);
            this.StatusMessage.Name = "StatusMessage";
            this.StatusMessage.Size = new System.Drawing.Size(80, 13);
            this.StatusMessage.TabIndex = 15;
            this.StatusMessage.Text = "StatusMessage";
            // 
            // processBtn
            // 
            this.processBtn.Location = new System.Drawing.Point(16, 389);
            this.processBtn.Name = "processBtn";
            this.processBtn.Size = new System.Drawing.Size(98, 23);
            this.processBtn.TabIndex = 57;
            this.processBtn.Text = "Process";
            this.processBtn.UseVisualStyleBackColor = true;
            this.processBtn.Click += new System.EventHandler(this.CompressAll_Click_1);
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(120, 389);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(463, 23);
            this.progress.TabIndex = 58;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(163, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 20);
            this.button2.TabIndex = 77;
            this.button2.Text = "x";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbrNameExceps
            // 
            this.cbrNameExceps.FormattingEnabled = true;
            this.cbrNameExceps.Location = new System.Drawing.Point(3, 113);
            this.cbrNameExceps.Name = "cbrNameExceps";
            this.cbrNameExceps.Size = new System.Drawing.Size(185, 225);
            this.cbrNameExceps.TabIndex = 76;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(136, 87);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(21, 20);
            this.button3.TabIndex = 75;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cbrExc
            // 
            this.cbrExc.Location = new System.Drawing.Point(3, 87);
            this.cbrExc.Name = "cbrExc";
            this.cbrExc.Size = new System.Drawing.Size(127, 20);
            this.cbrExc.TabIndex = 74;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 73;
            this.label12.Text = "Name Excep.";
            // 
            // CBZCompressor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 454);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.processBtn);
            this.Controls.Add(this.StatusMessage);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CBZCompressor";
            this.Text = "CBZ Compress / Extract";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coverImage)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox originFolderFull;
        private System.Windows.Forms.ListBox destinationFiles;
        private System.Windows.Forms.ListBox originFolders;
        private System.Windows.Forms.Button loadFolders;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox pathFolders;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox originFilesFull;
        private System.Windows.Forms.ListBox destinationFolders;
        private System.Windows.Forms.ListBox originFiles;
        private System.Windows.Forms.Button LoadCbrs;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox pathCbrs;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label StatusMessage;
        private System.Windows.Forms.PictureBox coverImage;
        private System.Windows.Forms.Button processBtn;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox cbrNameExceps;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox cbrExc;
        private System.Windows.Forms.Label label12;
    }
}

