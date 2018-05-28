namespace License
{
    partial class Form1
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
            this.browseFilesBtn = new System.Windows.Forms.Button();
            this.selectedPathLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.appendLicenseBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.selectedLicensePathLbl = new System.Windows.Forms.Label();
            this.browseLicenseFileBtrn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.csCheckBox = new System.Windows.Forms.CheckBox();
            this.inoCheckBox = new System.Windows.Forms.CheckBox();
            this.headerCheckBox = new System.Windows.Forms.CheckBox();
            this.cppCheckBox = new System.Windows.Forms.CheckBox();
            this.folderRadioBtn = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fileRadioBtn = new System.Windows.Forms.RadioButton();
            this.workTimeProgressBar = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // browseFilesBtn
            // 
            this.browseFilesBtn.Location = new System.Drawing.Point(38, 132);
            this.browseFilesBtn.Name = "browseFilesBtn";
            this.browseFilesBtn.Size = new System.Drawing.Size(52, 34);
            this.browseFilesBtn.TabIndex = 1;
            this.browseFilesBtn.Text = "Browse";
            this.browseFilesBtn.UseVisualStyleBackColor = true;
            this.browseFilesBtn.Click += new System.EventHandler(this.browseFilesBtn_Click);
            // 
            // selectedPathLbl
            // 
            this.selectedPathLbl.AutoSize = true;
            this.selectedPathLbl.Location = new System.Drawing.Point(197, 143);
            this.selectedPathLbl.Name = "selectedPathLbl";
            this.selectedPathLbl.Size = new System.Drawing.Size(10, 13);
            this.selectedPathLbl.TabIndex = 2;
            this.selectedPathLbl.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Selected Path: ";
            // 
            // appendLicenseBtn
            // 
            this.appendLicenseBtn.Enabled = false;
            this.appendLicenseBtn.Location = new System.Drawing.Point(216, 172);
            this.appendLicenseBtn.Name = "appendLicenseBtn";
            this.appendLicenseBtn.Size = new System.Drawing.Size(96, 59);
            this.appendLicenseBtn.TabIndex = 4;
            this.appendLicenseBtn.Text = "Append License";
            this.appendLicenseBtn.UseVisualStyleBackColor = true;
            this.appendLicenseBtn.Click += new System.EventHandler(this.appendLicenseBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(405, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Selected Path: ";
            // 
            // selectedLicensePathLbl
            // 
            this.selectedLicensePathLbl.AutoSize = true;
            this.selectedLicensePathLbl.Location = new System.Drawing.Point(491, 105);
            this.selectedLicensePathLbl.Name = "selectedLicensePathLbl";
            this.selectedLicensePathLbl.Size = new System.Drawing.Size(10, 13);
            this.selectedLicensePathLbl.TabIndex = 7;
            this.selectedLicensePathLbl.Text = "-";
            // 
            // browseLicenseFileBtrn
            // 
            this.browseLicenseFileBtrn.Location = new System.Drawing.Point(347, 94);
            this.browseLicenseFileBtrn.Name = "browseLicenseFileBtrn";
            this.browseLicenseFileBtrn.Size = new System.Drawing.Size(52, 34);
            this.browseLicenseFileBtrn.TabIndex = 6;
            this.browseLicenseFileBtrn.Text = "Browse";
            this.browseLicenseFileBtrn.UseVisualStyleBackColor = true;
            this.browseLicenseFileBtrn.Click += new System.EventHandler(this.browseLicenseFileBtrn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(344, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Choose license file";
            // 
            // csCheckBox
            // 
            this.csCheckBox.AutoSize = true;
            this.csCheckBox.Location = new System.Drawing.Point(43, 172);
            this.csCheckBox.Name = "csCheckBox";
            this.csCheckBox.Size = new System.Drawing.Size(39, 17);
            this.csCheckBox.TabIndex = 9;
            this.csCheckBox.Text = "c#";
            this.csCheckBox.UseVisualStyleBackColor = true;
            // 
            // inoCheckBox
            // 
            this.inoCheckBox.AutoSize = true;
            this.inoCheckBox.Location = new System.Drawing.Point(43, 246);
            this.inoCheckBox.Name = "inoCheckBox";
            this.inoCheckBox.Size = new System.Drawing.Size(40, 17);
            this.inoCheckBox.TabIndex = 12;
            this.inoCheckBox.Text = "ino";
            this.inoCheckBox.UseVisualStyleBackColor = true;
            // 
            // headerCheckBox
            // 
            this.headerCheckBox.AutoSize = true;
            this.headerCheckBox.Location = new System.Drawing.Point(43, 223);
            this.headerCheckBox.Name = "headerCheckBox";
            this.headerCheckBox.Size = new System.Drawing.Size(59, 17);
            this.headerCheckBox.TabIndex = 13;
            this.headerCheckBox.Text = "header";
            this.headerCheckBox.UseVisualStyleBackColor = true;
            // 
            // cppCheckBox
            // 
            this.cppCheckBox.AutoSize = true;
            this.cppCheckBox.Location = new System.Drawing.Point(43, 195);
            this.cppCheckBox.Name = "cppCheckBox";
            this.cppCheckBox.Size = new System.Drawing.Size(44, 17);
            this.cppCheckBox.TabIndex = 14;
            this.cppCheckBox.Text = "cpp";
            this.cppCheckBox.UseVisualStyleBackColor = true;
            // 
            // folderRadioBtn
            // 
            this.folderRadioBtn.AutoSize = true;
            this.folderRadioBtn.Location = new System.Drawing.Point(19, 19);
            this.folderRadioBtn.Name = "folderRadioBtn";
            this.folderRadioBtn.Size = new System.Drawing.Size(51, 17);
            this.folderRadioBtn.TabIndex = 15;
            this.folderRadioBtn.Text = "folder";
            this.folderRadioBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fileRadioBtn);
            this.groupBox1.Controls.Add(this.folderRadioBtn);
            this.groupBox1.Location = new System.Drawing.Point(34, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 65);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose file or directory";
            // 
            // fileRadioBtn
            // 
            this.fileRadioBtn.AutoSize = true;
            this.fileRadioBtn.Location = new System.Drawing.Point(18, 38);
            this.fileRadioBtn.Name = "fileRadioBtn";
            this.fileRadioBtn.Size = new System.Drawing.Size(38, 17);
            this.fileRadioBtn.TabIndex = 16;
            this.fileRadioBtn.TabStop = true;
            this.fileRadioBtn.Text = "file";
            this.fileRadioBtn.UseVisualStyleBackColor = true;
            // 
            // workTimeProgressBar
            // 
            this.workTimeProgressBar.Location = new System.Drawing.Point(106, 341);
            this.workTimeProgressBar.Name = "workTimeProgressBar";
            this.workTimeProgressBar.Size = new System.Drawing.Size(206, 23);
            this.workTimeProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.workTimeProgressBar.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 431);
            this.Controls.Add(this.workTimeProgressBar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cppCheckBox);
            this.Controls.Add(this.headerCheckBox);
            this.Controls.Add(this.inoCheckBox);
            this.Controls.Add(this.csCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectedLicensePathLbl);
            this.Controls.Add(this.browseLicenseFileBtrn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.appendLicenseBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.selectedPathLbl);
            this.Controls.Add(this.browseFilesBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button browseFilesBtn;
        private System.Windows.Forms.Label selectedPathLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button appendLicenseBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label selectedLicensePathLbl;
        private System.Windows.Forms.Button browseLicenseFileBtrn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox csCheckBox;
        private System.Windows.Forms.CheckBox inoCheckBox;
        private System.Windows.Forms.CheckBox headerCheckBox;
        private System.Windows.Forms.CheckBox cppCheckBox;
        private System.Windows.Forms.RadioButton folderRadioBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton fileRadioBtn;
        private System.Windows.Forms.ProgressBar workTimeProgressBar;
    }
}

