namespace DeployAddIns
{
    partial class DeployDialogue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeployDialogue));
            this.buttonDeploy = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonSelectFolder = new System.Windows.Forms.Button();
            this.labelSelectedFolder = new System.Windows.Forms.Label();
            this.listBoxReslts = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSelectTextFile = new System.Windows.Forms.Button();
            this.labelSelectedFile = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDeploy
            // 
            this.buttonDeploy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDeploy.Location = new System.Drawing.Point(12, 477);
            this.buttonDeploy.Name = "buttonDeploy";
            this.buttonDeploy.Size = new System.Drawing.Size(75, 23);
            this.buttonDeploy.TabIndex = 0;
            this.buttonDeploy.Text = "Deploy";
            this.buttonDeploy.UseVisualStyleBackColor = true;
            this.buttonDeploy.Click += new System.EventHandler(this.buttonDeploy_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(93, 477);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSelectFolder
            // 
            this.buttonSelectFolder.Location = new System.Drawing.Point(3, 3);
            this.buttonSelectFolder.Name = "buttonSelectFolder";
            this.buttonSelectFolder.Size = new System.Drawing.Size(92, 23);
            this.buttonSelectFolder.TabIndex = 2;
            this.buttonSelectFolder.Text = "Select Folder";
            this.buttonSelectFolder.UseVisualStyleBackColor = true;
            this.buttonSelectFolder.Click += new System.EventHandler(this.buttonSelectFolder_Click);
            // 
            // labelSelectedFolder
            // 
            this.labelSelectedFolder.AutoSize = true;
            this.labelSelectedFolder.Location = new System.Drawing.Point(3, 33);
            this.labelSelectedFolder.Margin = new System.Windows.Forms.Padding(3);
            this.labelSelectedFolder.Name = "labelSelectedFolder";
            this.labelSelectedFolder.Size = new System.Drawing.Size(93, 13);
            this.labelSelectedFolder.TabIndex = 3;
            this.labelSelectedFolder.Text = "No folder selected";
            // 
            // listBoxReslts
            // 
            this.listBoxReslts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxReslts.FormattingEnabled = true;
            this.listBoxReslts.Location = new System.Drawing.Point(3, 123);
            this.listBoxReslts.Name = "listBoxReslts";
            this.listBoxReslts.Size = new System.Drawing.Size(429, 329);
            this.listBoxReslts.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.buttonSelectFolder, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.listBoxReslts, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelSelectedFolder, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonSelectTextFile, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelSelectedFile, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(435, 459);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // buttonSelectTextFile
            // 
            this.buttonSelectTextFile.Location = new System.Drawing.Point(3, 63);
            this.buttonSelectTextFile.Name = "buttonSelectTextFile";
            this.buttonSelectTextFile.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectTextFile.TabIndex = 5;
            this.buttonSelectTextFile.Text = "Select File";
            this.buttonSelectTextFile.UseVisualStyleBackColor = true;
            this.buttonSelectTextFile.Click += new System.EventHandler(this.buttonSelectTextFile_Click);
            // 
            // labelSelectedFile
            // 
            this.labelSelectedFile.AutoSize = true;
            this.labelSelectedFile.Location = new System.Drawing.Point(3, 93);
            this.labelSelectedFile.Margin = new System.Windows.Forms.Padding(3);
            this.labelSelectedFile.Name = "labelSelectedFile";
            this.labelSelectedFile.Size = new System.Drawing.Size(80, 13);
            this.labelSelectedFile.TabIndex = 6;
            this.labelSelectedFile.Text = "No file selected";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // DeployDialogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(459, 512);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonDeploy);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(475, 550);
            this.Name = "DeployDialogue";
            this.Text = "Deploy Add-Ins";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDeploy;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button buttonSelectFolder;
        private System.Windows.Forms.Label labelSelectedFolder;
        private System.Windows.Forms.ListBox listBoxReslts;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonSelectTextFile;
        private System.Windows.Forms.Label labelSelectedFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

