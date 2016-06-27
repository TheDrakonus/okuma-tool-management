namespace OkumaTools
{
    partial class ToolList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolList));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBoxTopFile = new System.Windows.Forms.TextBox();
            this.buttonOpenFileDialog = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listBoxCurrentTools = new System.Windows.Forms.ListBox();
            this.totalToolsTextBox = new System.Windows.Forms.TextBox();
            this.buttonExitProgram = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.machineProgress = new System.Windows.Forms.ProgressBar();
            this.textBoxUsedPotCount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAvailablePotCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMachinePotCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rButtonOkumaABC5X = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.partNumberListBox = new System.Windows.Forms.CheckedListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.partSpecificToolNumbers = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.generateTextButton = new System.Windows.Forms.Button();
            this.mailMessage = new System.Windows.Forms.Button();
            this.richTextBoxEmail = new System.Windows.Forms.RichTextBox();
            this.mailToMe = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.openMachineToolListDlg = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "TOP";
            this.openFileDialog1.FileName = "*.TOP";
            this.openFileDialog1.InitialDirectory = "P:\\";
            this.openFileDialog1.Tag = "Look for TOP file";
            this.openFileDialog1.Title = "Locate .TOP File";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // textBoxTopFile
            // 
            this.textBoxTopFile.Location = new System.Drawing.Point(21, 36);
            this.textBoxTopFile.Name = "textBoxTopFile";
            this.textBoxTopFile.ReadOnly = true;
            this.textBoxTopFile.Size = new System.Drawing.Size(231, 20);
            this.textBoxTopFile.TabIndex = 0;
            // 
            // buttonOpenFileDialog
            // 
            this.buttonOpenFileDialog.Location = new System.Drawing.Point(264, 33);
            this.buttonOpenFileDialog.Name = "buttonOpenFileDialog";
            this.buttonOpenFileDialog.Size = new System.Drawing.Size(76, 23);
            this.buttonOpenFileDialog.TabIndex = 1;
            this.buttonOpenFileDialog.Text = "Browse";
            this.buttonOpenFileDialog.UseVisualStyleBackColor = true;
            this.buttonOpenFileDialog.Click += new System.EventHandler(this.buttonOpenFileDialog_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "TOP File from Machine";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.listBoxCurrentTools);
            this.groupBox1.Controls.Add(this.totalToolsTextBox);
            this.groupBox1.Location = new System.Drawing.Point(264, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(114, 356);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Machine Tools";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 331);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Total Tools";
            // 
            // listBoxCurrentTools
            // 
            this.listBoxCurrentTools.FormattingEnabled = true;
            this.listBoxCurrentTools.Location = new System.Drawing.Point(9, 19);
            this.listBoxCurrentTools.Name = "listBoxCurrentTools";
            this.listBoxCurrentTools.Size = new System.Drawing.Size(98, 277);
            this.listBoxCurrentTools.TabIndex = 0;
            // 
            // totalToolsTextBox
            // 
            this.totalToolsTextBox.Location = new System.Drawing.Point(21, 309);
            this.totalToolsTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.totalToolsTextBox.Name = "totalToolsTextBox";
            this.totalToolsTextBox.ReadOnly = true;
            this.totalToolsTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.totalToolsTextBox.Size = new System.Drawing.Size(72, 20);
            this.totalToolsTextBox.TabIndex = 1;
            this.totalToolsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonExitProgram
            // 
            this.buttonExitProgram.Location = new System.Drawing.Point(16, 566);
            this.buttonExitProgram.Name = "buttonExitProgram";
            this.buttonExitProgram.Size = new System.Drawing.Size(75, 23);
            this.buttonExitProgram.TabIndex = 4;
            this.buttonExitProgram.Text = "Exit";
            this.buttonExitProgram.UseVisualStyleBackColor = true;
            this.buttonExitProgram.Click += new System.EventHandler(this.buttonExitProgram_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(2, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(434, 544);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.machineProgress);
            this.tabPage1.Controls.Add(this.textBoxUsedPotCount);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textBoxAvailablePotCount);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBoxMachinePotCount);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.buttonOpenFileDialog);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBoxTopFile);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(426, 518);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Machine";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // machineProgress
            // 
            this.machineProgress.Location = new System.Drawing.Point(16, 461);
            this.machineProgress.Name = "machineProgress";
            this.machineProgress.Size = new System.Drawing.Size(395, 28);
            this.machineProgress.Step = 1;
            this.machineProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.machineProgress.TabIndex = 11;
            // 
            // textBoxUsedPotCount
            // 
            this.textBoxUsedPotCount.Location = new System.Drawing.Point(109, 251);
            this.textBoxUsedPotCount.Name = "textBoxUsedPotCount";
            this.textBoxUsedPotCount.ReadOnly = true;
            this.textBoxUsedPotCount.Size = new System.Drawing.Size(42, 20);
            this.textBoxUsedPotCount.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Occupied Pots";
            // 
            // textBoxAvailablePotCount
            // 
            this.textBoxAvailablePotCount.Location = new System.Drawing.Point(109, 217);
            this.textBoxAvailablePotCount.Name = "textBoxAvailablePotCount";
            this.textBoxAvailablePotCount.ReadOnly = true;
            this.textBoxAvailablePotCount.Size = new System.Drawing.Size(42, 20);
            this.textBoxAvailablePotCount.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Available Pots";
            // 
            // textBoxMachinePotCount
            // 
            this.textBoxMachinePotCount.Location = new System.Drawing.Point(109, 183);
            this.textBoxMachinePotCount.Name = "textBoxMachinePotCount";
            this.textBoxMachinePotCount.ReadOnly = true;
            this.textBoxMachinePotCount.Size = new System.Drawing.Size(42, 20);
            this.textBoxMachinePotCount.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Machine Pots";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.rButtonOkumaABC5X);
            this.groupBox2.Location = new System.Drawing.Point(21, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(130, 73);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Machine";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(9, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(93, 17);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Okuma A/B/C";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.radioButton2_CheckedChanged_1);
            // 
            // rButtonOkumaABC5X
            // 
            this.rButtonOkumaABC5X.AutoSize = true;
            this.rButtonOkumaABC5X.Location = new System.Drawing.Point(9, 19);
            this.rButtonOkumaABC5X.Name = "rButtonOkumaABC5X";
            this.rButtonOkumaABC5X.Size = new System.Drawing.Size(75, 17);
            this.rButtonOkumaABC5X.TabIndex = 5;
            this.rButtonOkumaABC5X.TabStop = true;
            this.rButtonOkumaABC5X.Text = "Okuma 5X";
            this.rButtonOkumaABC5X.UseVisualStyleBackColor = true;
            this.rButtonOkumaABC5X.Click += new System.EventHandler(this.rButtonOkumaABC5X_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(426, 518);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Parts";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.partNumberListBox);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.partSpecificToolNumbers);
            this.groupBox3.Location = new System.Drawing.Point(21, 97);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(356, 400);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Part Data";
            // 
            // partNumberListBox
            // 
            this.partNumberListBox.CausesValidation = false;
            this.partNumberListBox.FormattingEnabled = true;
            this.partNumberListBox.Location = new System.Drawing.Point(10, 44);
            this.partNumberListBox.Name = "partNumberListBox";
            this.partNumberListBox.Size = new System.Drawing.Size(184, 349);
            this.partNumberListBox.TabIndex = 10;
            this.partNumberListBox.SelectedIndexChanged += new System.EventHandler(this.partNumberListBox_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(209, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Tools for Selected Part";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Parts ";
            // 
            // partSpecificToolNumbers
            // 
            this.partSpecificToolNumbers.FormattingEnabled = true;
            this.partSpecificToolNumbers.Location = new System.Drawing.Point(212, 47);
            this.partSpecificToolNumbers.Name = "partSpecificToolNumbers";
            this.partSpecificToolNumbers.Size = new System.Drawing.Size(129, 342);
            this.partSpecificToolNumbers.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(264, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Machine Specific Tool List";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(21, 36);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(231, 20);
            this.textBox4.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.generateTextButton);
            this.tabPage3.Controls.Add(this.mailMessage);
            this.tabPage3.Controls.Add(this.richTextBoxEmail);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(426, 518);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Pull/Set";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // generateTextButton
            // 
            this.generateTextButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.generateTextButton.Location = new System.Drawing.Point(10, 473);
            this.generateTextButton.Name = "generateTextButton";
            this.generateTextButton.Size = new System.Drawing.Size(125, 29);
            this.generateTextButton.TabIndex = 2;
            this.generateTextButton.Text = "Generate";
            this.generateTextButton.UseVisualStyleBackColor = true;
            this.generateTextButton.Click += new System.EventHandler(this.generateTextButton_Click);
            // 
            // mailMessage
            // 
            this.mailMessage.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.mailMessage.Location = new System.Drawing.Point(295, 473);
            this.mailMessage.Name = "mailMessage";
            this.mailMessage.Size = new System.Drawing.Size(125, 29);
            this.mailMessage.TabIndex = 1;
            this.mailMessage.Text = "Copy all Text";
            this.mailMessage.UseVisualStyleBackColor = true;
            this.mailMessage.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBoxEmail
            // 
            this.richTextBoxEmail.Location = new System.Drawing.Point(7, 29);
            this.richTextBoxEmail.Name = "richTextBoxEmail";
            this.richTextBoxEmail.ReadOnly = true;
            this.richTextBoxEmail.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBoxEmail.Size = new System.Drawing.Size(413, 438);
            this.richTextBoxEmail.TabIndex = 0;
            this.richTextBoxEmail.Text = resources.GetString("richTextBoxEmail.Text");
            // 
            // mailToMe
            // 
            this.mailToMe.AutoSize = true;
            this.mailToMe.Location = new System.Drawing.Point(366, 571);
            this.mailToMe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mailToMe.Name = "mailToMe";
            this.mailToMe.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mailToMe.Size = new System.Drawing.Size(59, 13);
            this.mailToMe.TabIndex = 6;
            this.mailToMe.TabStop = true;
            this.mailToMe.Text = "Eric";
            this.mailToMe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.mailToMe_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(310, 571);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Written by:";
            // 
            // openMachineToolListDlg
            // 
            this.openMachineToolListDlg.FileName = "*.CSV";
            this.openMachineToolListDlg.InitialDirectory = "";
            this.openMachineToolListDlg.Tag = "Open Master Tool List";
            this.openMachineToolListDlg.FileOk += new System.ComponentModel.CancelEventHandler(this.openMachineToolListDlg_FileOk);
            // 
            // ToolList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 597);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mailToMe);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonExitProgram);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ToolList";
            this.Text = "Okuma Tool Management";
            this.Load += new System.EventHandler(this.ToolList_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBoxTopFile;
        private System.Windows.Forms.Button buttonOpenFileDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxCurrentTools;
        private System.Windows.Forms.Button buttonExitProgram;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rButtonOkumaABC5X;
        private System.Windows.Forms.TextBox textBoxUsedPotCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAvailablePotCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMachinePotCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button mailMessage;
        private System.Windows.Forms.RichTextBox richTextBoxEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox totalToolsTextBox;
        private System.Windows.Forms.LinkLabel mailToMe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.OpenFileDialog openMachineToolListDlg;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox partSpecificToolNumbers;
        private System.Windows.Forms.CheckedListBox partNumberListBox;
        private System.Windows.Forms.ProgressBar machineProgress;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button generateTextButton;
    }
}

