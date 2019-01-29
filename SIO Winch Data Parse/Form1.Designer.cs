namespace SIO_Winch_Data_Parse
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
            this.folderSelect = new System.Windows.Forms.Button();
            this.runProcess = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.logFileView = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cruiseNameInput = new System.Windows.Forms.TextBox();
            this.labelCombinedFileName = new System.Windows.Forms.Label();
            this.labelProcessedFileNameDisplay = new System.Windows.Forms.Label();
            this.applyNameButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelOpenFile = new System.Windows.Forms.Label();
            this.labelStringData = new System.Windows.Forms.Label();
            this.buttonProcessCasts = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxPayoutMin = new System.Windows.Forms.ComboBox();
            this.comboBoxTensionMin = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxSelectWinch = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // folderSelect
            // 
            this.folderSelect.Location = new System.Drawing.Point(30, 674);
            this.folderSelect.Name = "folderSelect";
            this.folderSelect.Size = new System.Drawing.Size(215, 68);
            this.folderSelect.TabIndex = 0;
            this.folderSelect.Text = "Folder Select";
            this.folderSelect.UseVisualStyleBackColor = true;
            this.folderSelect.Click += new System.EventHandler(this.folderSelect_Click);
            // 
            // runProcess
            // 
            this.runProcess.Location = new System.Drawing.Point(885, 674);
            this.runProcess.Name = "runProcess";
            this.runProcess.Size = new System.Drawing.Size(199, 68);
            this.runProcess.TabIndex = 1;
            this.runProcess.Text = "Combine Files";
            this.runProcess.UseVisualStyleBackColor = true;
            this.runProcess.Click += new System.EventHandler(this.runProcess_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // logFileView
            // 
            this.logFileView.Location = new System.Drawing.Point(30, 87);
            this.logFileView.Name = "logFileView";
            this.logFileView.Size = new System.Drawing.Size(694, 558);
            this.logFileView.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(771, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Combined File Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(771, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Processed File Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(771, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cruise Name";
            // 
            // cruiseNameInput
            // 
            this.cruiseNameInput.Location = new System.Drawing.Point(1008, 28);
            this.cruiseNameInput.Name = "cruiseNameInput";
            this.cruiseNameInput.Size = new System.Drawing.Size(256, 31);
            this.cruiseNameInput.TabIndex = 6;
            this.cruiseNameInput.Text = "Enter Name";
            // 
            // labelCombinedFileName
            // 
            this.labelCombinedFileName.AutoSize = true;
            this.labelCombinedFileName.Location = new System.Drawing.Point(1003, 87);
            this.labelCombinedFileName.Name = "labelCombinedFileName";
            this.labelCombinedFileName.Size = new System.Drawing.Size(70, 25);
            this.labelCombinedFileName.TabIndex = 7;
            this.labelCombinedFileName.Text = "label4";
            // 
            // labelProcessedFileNameDisplay
            // 
            this.labelProcessedFileNameDisplay.AutoSize = true;
            this.labelProcessedFileNameDisplay.Location = new System.Drawing.Point(1003, 144);
            this.labelProcessedFileNameDisplay.Name = "labelProcessedFileNameDisplay";
            this.labelProcessedFileNameDisplay.Size = new System.Drawing.Size(70, 25);
            this.labelProcessedFileNameDisplay.TabIndex = 8;
            this.labelProcessedFileNameDisplay.Text = "label5";
            // 
            // applyNameButton
            // 
            this.applyNameButton.Location = new System.Drawing.Point(1294, 28);
            this.applyNameButton.Name = "applyNameButton";
            this.applyNameButton.Size = new System.Drawing.Size(75, 36);
            this.applyNameButton.TabIndex = 9;
            this.applyNameButton.Text = "OK";
            this.applyNameButton.UseVisualStyleBackColor = true;
            this.applyNameButton.Click += new System.EventHandler(this.applyNameButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(771, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Open File";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(771, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Data";
            // 
            // labelOpenFile
            // 
            this.labelOpenFile.AutoSize = true;
            this.labelOpenFile.Location = new System.Drawing.Point(890, 204);
            this.labelOpenFile.Name = "labelOpenFile";
            this.labelOpenFile.Size = new System.Drawing.Size(70, 25);
            this.labelOpenFile.TabIndex = 12;
            this.labelOpenFile.Text = "label6";
            // 
            // labelStringData
            // 
            this.labelStringData.AutoSize = true;
            this.labelStringData.Location = new System.Drawing.Point(895, 246);
            this.labelStringData.Name = "labelStringData";
            this.labelStringData.Size = new System.Drawing.Size(70, 25);
            this.labelStringData.TabIndex = 13;
            this.labelStringData.Text = "label7";
            // 
            // buttonProcessCasts
            // 
            this.buttonProcessCasts.Location = new System.Drawing.Point(1148, 674);
            this.buttonProcessCasts.Name = "buttonProcessCasts";
            this.buttonProcessCasts.Size = new System.Drawing.Size(186, 67);
            this.buttonProcessCasts.TabIndex = 14;
            this.buttonProcessCasts.Text = "Process Casts";
            this.buttonProcessCasts.UseVisualStyleBackColor = true;
            this.buttonProcessCasts.Click += new System.EventHandler(this.buttonProcessCasts_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(771, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Minimum Payout";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(771, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Minimum Tension";
            // 
            // comboBoxPayoutMin
            // 
            this.comboBoxPayoutMin.FormattingEnabled = true;
            this.comboBoxPayoutMin.Location = new System.Drawing.Point(994, 290);
            this.comboBoxPayoutMin.Name = "comboBoxPayoutMin";
            this.comboBoxPayoutMin.Size = new System.Drawing.Size(121, 33);
            this.comboBoxPayoutMin.TabIndex = 17;
            // 
            // comboBoxTensionMin
            // 
            this.comboBoxTensionMin.FormattingEnabled = true;
            this.comboBoxTensionMin.Location = new System.Drawing.Point(994, 350);
            this.comboBoxTensionMin.Name = "comboBoxTensionMin";
            this.comboBoxTensionMin.Size = new System.Drawing.Size(121, 33);
            this.comboBoxTensionMin.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "Selected Winch";
            // 
            // comboBoxSelectWinch
            // 
            this.comboBoxSelectWinch.FormattingEnabled = true;
            this.comboBoxSelectWinch.Location = new System.Drawing.Point(211, 28);
            this.comboBoxSelectWinch.Name = "comboBoxSelectWinch";
            this.comboBoxSelectWinch.Size = new System.Drawing.Size(437, 33);
            this.comboBoxSelectWinch.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1686, 781);
            this.Controls.Add(this.comboBoxSelectWinch);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxTensionMin);
            this.Controls.Add(this.comboBoxPayoutMin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonProcessCasts);
            this.Controls.Add(this.labelStringData);
            this.Controls.Add(this.labelOpenFile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.applyNameButton);
            this.Controls.Add(this.labelProcessedFileNameDisplay);
            this.Controls.Add(this.labelCombinedFileName);
            this.Controls.Add(this.cruiseNameInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logFileView);
            this.Controls.Add(this.runProcess);
            this.Controls.Add(this.folderSelect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button folderSelect;
        private System.Windows.Forms.Button runProcess;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TreeView logFileView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cruiseNameInput;
        private System.Windows.Forms.Label labelCombinedFileName;
        private System.Windows.Forms.Label labelProcessedFileNameDisplay;
        private System.Windows.Forms.Button applyNameButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelOpenFile;
        private System.Windows.Forms.Label labelStringData;
        private System.Windows.Forms.Button buttonProcessCasts;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxPayoutMin;
        private System.Windows.Forms.ComboBox comboBoxTensionMin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxSelectWinch;
    }
}

