namespace TimeTracker
{
    partial class frmTimeTracker
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
            this.components = new System.ComponentModel.Container();
            this.lblProjectNumber = new System.Windows.Forms.Label();
            this.btnNewProject = new System.Windows.Forms.Button();
            this.tBoxPjtNumber = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddOnly = new System.Windows.Forms.Button();
            this.btnNewDay = new System.Windows.Forms.Button();
            this.lbl_CurrentInfo = new System.Windows.Forms.Label();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.chBoxCreateButton = new System.Windows.Forms.CheckBox();
            this.btnFinished = new System.Windows.Forms.Button();
            this.cBoxDiscipline = new System.Windows.Forms.ComboBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblDiscipline = new System.Windows.Forms.Label();
            this.tBoxDescription = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvProjectList = new System.Windows.Forms.DataGridView();
            this.btnProjectColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDisciplineColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete_Row = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnClearProjects = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAssistPM = new System.Windows.Forms.Button();
            this.btnLunch = new System.Windows.Forms.Button();
            this.btnMisc = new System.Windows.Forms.Button();
            this.btnAssistCAD = new System.Windows.Forms.Button();
            this.btnAssistDesigner = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dGViewTotals = new System.Windows.Forms.DataGridView();
            this.ProjectNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDiscipline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvTotals = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dGViewRecords = new System.Windows.Forms.DataGridView();
            this.recordProjectNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordProjectDiscipline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordProjectDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordTotalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRecordsOpen = new System.Windows.Forms.Button();
            this.comboBoxRecords = new System.Windows.Forms.ComboBox();
            this.projectTotalsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectTotalsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectList)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGViewTotals)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotals)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGViewRecords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectTotalsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectTotalsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProjectNumber
            // 
            this.lblProjectNumber.AutoSize = true;
            this.lblProjectNumber.Location = new System.Drawing.Point(3, 0);
            this.lblProjectNumber.Name = "lblProjectNumber";
            this.lblProjectNumber.Size = new System.Drawing.Size(80, 13);
            this.lblProjectNumber.TabIndex = 0;
            this.lblProjectNumber.Text = "Project Number";
            // 
            // btnNewProject
            // 
            this.btnNewProject.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnNewProject.Location = new System.Drawing.Point(4, 42);
            this.btnNewProject.Name = "btnNewProject";
            this.btnNewProject.Size = new System.Drawing.Size(75, 23);
            this.btnNewProject.TabIndex = 4;
            this.btnNewProject.Text = "Enter";
            this.btnNewProject.UseVisualStyleBackColor = true;
            this.btnNewProject.Click += new System.EventHandler(this.btnNewProject_Click);
            // 
            // tBoxPjtNumber
            // 
            this.tBoxPjtNumber.Location = new System.Drawing.Point(6, 17);
            this.tBoxPjtNumber.Name = "tBoxPjtNumber";
            this.tBoxPjtNumber.Size = new System.Drawing.Size(163, 20);
            this.tBoxPjtNumber.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddOnly);
            this.panel1.Controls.Add(this.btnNewDay);
            this.panel1.Controls.Add(this.lbl_CurrentInfo);
            this.panel1.Controls.Add(this.lblCurrent);
            this.panel1.Controls.Add(this.chBoxCreateButton);
            this.panel1.Controls.Add(this.btnFinished);
            this.panel1.Controls.Add(this.cBoxDiscipline);
            this.panel1.Controls.Add(this.lblDescription);
            this.panel1.Controls.Add(this.lblDiscipline);
            this.panel1.Controls.Add(this.lblProjectNumber);
            this.panel1.Controls.Add(this.btnNewProject);
            this.panel1.Controls.Add(this.tBoxDescription);
            this.panel1.Controls.Add(this.tBoxPjtNumber);
            this.panel1.Location = new System.Drawing.Point(6, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 79);
            this.panel1.TabIndex = 3;
            // 
            // btnAddOnly
            // 
            this.btnAddOnly.Location = new System.Drawing.Point(85, 42);
            this.btnAddOnly.Name = "btnAddOnly";
            this.btnAddOnly.Size = new System.Drawing.Size(75, 23);
            this.btnAddOnly.TabIndex = 15;
            this.btnAddOnly.Text = "Add Only";
            this.btnAddOnly.UseVisualStyleBackColor = true;
            this.btnAddOnly.Click += new System.EventHandler(this.btnAddOnly_Click);
            // 
            // btnNewDay
            // 
            this.btnNewDay.Location = new System.Drawing.Point(247, 42);
            this.btnNewDay.Name = "btnNewDay";
            this.btnNewDay.Size = new System.Drawing.Size(75, 23);
            this.btnNewDay.TabIndex = 14;
            this.btnNewDay.Text = "New Day";
            this.btnNewDay.UseVisualStyleBackColor = true;
            this.btnNewDay.Click += new System.EventHandler(this.btnNewDay_Click);
            // 
            // lbl_CurrentInfo
            // 
            this.lbl_CurrentInfo.AutoSize = true;
            this.lbl_CurrentInfo.Location = new System.Drawing.Point(372, 47);
            this.lbl_CurrentInfo.Name = "lbl_CurrentInfo";
            this.lbl_CurrentInfo.Size = new System.Drawing.Size(0, 13);
            this.lbl_CurrentInfo.TabIndex = 13;
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Location = new System.Drawing.Point(328, 47);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(44, 13);
            this.lblCurrent.TabIndex = 12;
            this.lblCurrent.Text = "Current:";
            // 
            // chBoxCreateButton
            // 
            this.chBoxCreateButton.AutoSize = true;
            this.chBoxCreateButton.Checked = true;
            this.chBoxCreateButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chBoxCreateButton.Location = new System.Drawing.Point(510, 17);
            this.chBoxCreateButton.Name = "chBoxCreateButton";
            this.chBoxCreateButton.Size = new System.Drawing.Size(91, 17);
            this.chBoxCreateButton.TabIndex = 11;
            this.chBoxCreateButton.Text = "Create Button";
            this.chBoxCreateButton.UseVisualStyleBackColor = true;
            // 
            // btnFinished
            // 
            this.btnFinished.Location = new System.Drawing.Point(166, 42);
            this.btnFinished.Name = "btnFinished";
            this.btnFinished.Size = new System.Drawing.Size(75, 23);
            this.btnFinished.TabIndex = 9;
            this.btnFinished.Text = "Finish Day";
            this.btnFinished.UseVisualStyleBackColor = true;
            this.btnFinished.Click += new System.EventHandler(this.btnFinished_Click);
            // 
            // cBoxDiscipline
            // 
            this.cBoxDiscipline.AutoCompleteCustomSource.AddRange(new string[] {
            "Audiovisual",
            "Telecom",
            "Security",
            "Lighting",
            "Other"});
            this.cBoxDiscipline.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBoxDiscipline.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxDiscipline.FormattingEnabled = true;
            this.cBoxDiscipline.Items.AddRange(new object[] {
            "Audiovisual",
            "Telecom",
            "Security",
            "Lighting",
            "Other"});
            this.cBoxDiscipline.Location = new System.Drawing.Point(176, 16);
            this.cBoxDiscipline.Name = "cBoxDiscipline";
            this.cBoxDiscipline.Size = new System.Drawing.Size(158, 21);
            this.cBoxDiscipline.TabIndex = 2;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(337, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Description";
            // 
            // lblDiscipline
            // 
            this.lblDiscipline.AutoSize = true;
            this.lblDiscipline.Location = new System.Drawing.Point(172, 0);
            this.lblDiscipline.Name = "lblDiscipline";
            this.lblDiscipline.Size = new System.Drawing.Size(52, 13);
            this.lblDiscipline.TabIndex = 0;
            this.lblDiscipline.Text = "Discipline";
            // 
            // tBoxDescription
            // 
            this.tBoxDescription.Location = new System.Drawing.Point(340, 16);
            this.tBoxDescription.Name = "tBoxDescription";
            this.tBoxDescription.Size = new System.Drawing.Size(163, 20);
            this.tBoxDescription.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(649, 474);
            this.tabControl1.TabIndex = 10;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(641, 448);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Enter Information";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvProjectList);
            this.panel4.Controls.Add(this.btnClearProjects);
            this.panel4.Location = new System.Drawing.Point(121, 94);
            this.panel4.MaximumSize = new System.Drawing.Size(500, 300);
            this.panel4.MinimumSize = new System.Drawing.Size(500, 300);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(500, 300);
            this.panel4.TabIndex = 5;
            // 
            // dgvProjectList
            // 
            this.dgvProjectList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjectList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnProjectColumn,
            this.btnDisciplineColumn,
            this.btnDescriptionColumn,
            this.Delete_Row});
            this.dgvProjectList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProjectList.Location = new System.Drawing.Point(0, 0);
            this.dgvProjectList.Name = "dgvProjectList";
            this.dgvProjectList.RowHeadersVisible = false;
            this.dgvProjectList.Size = new System.Drawing.Size(500, 300);
            this.dgvProjectList.TabIndex = 11;
            this.dgvProjectList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProjectList_CellContentClick);
            // 
            // btnProjectColumn
            // 
            this.btnProjectColumn.HeaderText = "Project";
            this.btnProjectColumn.MinimumWidth = 100;
            this.btnProjectColumn.Name = "btnProjectColumn";
            // 
            // btnDisciplineColumn
            // 
            this.btnDisciplineColumn.HeaderText = "Discipline";
            this.btnDisciplineColumn.MinimumWidth = 150;
            this.btnDisciplineColumn.Name = "btnDisciplineColumn";
            this.btnDisciplineColumn.Width = 150;
            // 
            // btnDescriptionColumn
            // 
            this.btnDescriptionColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.btnDescriptionColumn.HeaderText = "Description";
            this.btnDescriptionColumn.Name = "btnDescriptionColumn";
            // 
            // Delete_Row
            // 
            this.Delete_Row.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Delete_Row.FillWeight = 40F;
            this.Delete_Row.HeaderText = "Delete";
            this.Delete_Row.Name = "Delete_Row";
            this.Delete_Row.Width = 40;
            // 
            // btnClearProjects
            // 
            this.btnClearProjects.Location = new System.Drawing.Point(4, 324);
            this.btnClearProjects.Name = "btnClearProjects";
            this.btnClearProjects.Size = new System.Drawing.Size(75, 23);
            this.btnClearProjects.TabIndex = 10;
            this.btnClearProjects.Text = "Clear";
            this.btnClearProjects.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAssistPM);
            this.panel3.Controls.Add(this.btnLunch);
            this.panel3.Controls.Add(this.btnMisc);
            this.panel3.Controls.Add(this.btnAssistCAD);
            this.panel3.Controls.Add(this.btnAssistDesigner);
            this.panel3.Location = new System.Drawing.Point(3, 94);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(112, 182);
            this.panel3.TabIndex = 4;
            // 
            // btnAssistPM
            // 
            this.btnAssistPM.Location = new System.Drawing.Point(7, 70);
            this.btnAssistPM.Name = "btnAssistPM";
            this.btnAssistPM.Size = new System.Drawing.Size(100, 23);
            this.btnAssistPM.TabIndex = 10;
            this.btnAssistPM.Text = "Assist PM";
            this.btnAssistPM.UseVisualStyleBackColor = true;
            this.btnAssistPM.Click += new System.EventHandler(this.btnAssistPM_Click);
            // 
            // btnLunch
            // 
            this.btnLunch.Location = new System.Drawing.Point(7, 129);
            this.btnLunch.Name = "btnLunch";
            this.btnLunch.Size = new System.Drawing.Size(100, 23);
            this.btnLunch.TabIndex = 9;
            this.btnLunch.Text = "Lunch";
            this.btnLunch.UseVisualStyleBackColor = true;
            this.btnLunch.Click += new System.EventHandler(this.btnLunch_Click);
            // 
            // btnMisc
            // 
            this.btnMisc.Location = new System.Drawing.Point(7, 99);
            this.btnMisc.Name = "btnMisc";
            this.btnMisc.Size = new System.Drawing.Size(100, 23);
            this.btnMisc.TabIndex = 8;
            this.btnMisc.Text = "Misc.";
            this.btnMisc.UseVisualStyleBackColor = true;
            this.btnMisc.Click += new System.EventHandler(this.btnMisc_Click);
            // 
            // btnAssistCAD
            // 
            this.btnAssistCAD.Location = new System.Drawing.Point(7, 40);
            this.btnAssistCAD.Name = "btnAssistCAD";
            this.btnAssistCAD.Size = new System.Drawing.Size(101, 23);
            this.btnAssistCAD.TabIndex = 7;
            this.btnAssistCAD.Text = "Assist CAD";
            this.btnAssistCAD.UseVisualStyleBackColor = true;
            this.btnAssistCAD.Click += new System.EventHandler(this.btnAssistCAD_Click);
            // 
            // btnAssistDesigner
            // 
            this.btnAssistDesigner.Location = new System.Drawing.Point(7, 11);
            this.btnAssistDesigner.Name = "btnAssistDesigner";
            this.btnAssistDesigner.Size = new System.Drawing.Size(101, 23);
            this.btnAssistDesigner.TabIndex = 6;
            this.btnAssistDesigner.Text = "Assist Designer";
            this.btnAssistDesigner.UseVisualStyleBackColor = true;
            this.btnAssistDesigner.Click += new System.EventHandler(this.btnAssistDesigner_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dGViewTotals);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(641, 448);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "View Information";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dGViewTotals
            // 
            this.dGViewTotals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGViewTotals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProjectNumber,
            this.TimeStart,
            this.TimeEnd,
            this.TimeTotal,
            this.timeDiscipline,
            this.TimeDescription});
            this.dGViewTotals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGViewTotals.Location = new System.Drawing.Point(3, 3);
            this.dGViewTotals.Name = "dGViewTotals";
            this.dGViewTotals.RowHeadersVisible = false;
            this.dGViewTotals.Size = new System.Drawing.Size(635, 442);
            this.dGViewTotals.TabIndex = 0;
            // 
            // ProjectNumber
            // 
            this.ProjectNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ProjectNumber.HeaderText = "Project Number";
            this.ProjectNumber.MinimumWidth = 100;
            this.ProjectNumber.Name = "ProjectNumber";
            // 
            // TimeStart
            // 
            this.TimeStart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TimeStart.HeaderText = "Start";
            this.TimeStart.MinimumWidth = 100;
            this.TimeStart.Name = "TimeStart";
            // 
            // TimeEnd
            // 
            this.TimeEnd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TimeEnd.HeaderText = "End";
            this.TimeEnd.MinimumWidth = 100;
            this.TimeEnd.Name = "TimeEnd";
            // 
            // TimeTotal
            // 
            this.TimeTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TimeTotal.HeaderText = "Total";
            this.TimeTotal.MinimumWidth = 100;
            this.TimeTotal.Name = "TimeTotal";
            // 
            // timeDiscipline
            // 
            this.timeDiscipline.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.timeDiscipline.HeaderText = "Discipline";
            this.timeDiscipline.MinimumWidth = 100;
            this.timeDiscipline.Name = "timeDiscipline";
            // 
            // TimeDescription
            // 
            this.TimeDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TimeDescription.HeaderText = "Description";
            this.TimeDescription.Name = "TimeDescription";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvTotals);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(641, 448);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Totals";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvTotals
            // 
            this.dgvTotals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTotals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn4});
            this.dgvTotals.Location = new System.Drawing.Point(3, 6);
            this.dgvTotals.Name = "dgvTotals";
            this.dgvTotals.RowHeadersVisible = false;
            this.dgvTotals.Size = new System.Drawing.Size(635, 410);
            this.dgvTotals.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.HeaderText = "Project Number";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn5.HeaderText = "Discipline";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.HeaderText = "Description";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn4.HeaderText = "Total";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dGViewRecords);
            this.tabPage4.Controls.Add(this.btnRecordsOpen);
            this.tabPage4.Controls.Add(this.comboBoxRecords);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(641, 448);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Past Records";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dGViewRecords
            // 
            this.dGViewRecords.AllowUserToDeleteRows = false;
            this.dGViewRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGViewRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recordProjectNumber,
            this.recordProjectDiscipline,
            this.recordProjectDescription,
            this.recordTotalTime});
            this.dGViewRecords.Location = new System.Drawing.Point(6, 35);
            this.dGViewRecords.Name = "dGViewRecords";
            this.dGViewRecords.ReadOnly = true;
            this.dGViewRecords.RowHeadersVisible = false;
            this.dGViewRecords.Size = new System.Drawing.Size(623, 410);
            this.dGViewRecords.TabIndex = 3;
            // 
            // recordProjectNumber
            // 
            this.recordProjectNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.recordProjectNumber.HeaderText = "Project Number";
            this.recordProjectNumber.MinimumWidth = 100;
            this.recordProjectNumber.Name = "recordProjectNumber";
            this.recordProjectNumber.ReadOnly = true;
            // 
            // recordProjectDiscipline
            // 
            this.recordProjectDiscipline.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.recordProjectDiscipline.HeaderText = "Discipline";
            this.recordProjectDiscipline.MinimumWidth = 100;
            this.recordProjectDiscipline.Name = "recordProjectDiscipline";
            this.recordProjectDiscipline.ReadOnly = true;
            // 
            // recordProjectDescription
            // 
            this.recordProjectDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.recordProjectDescription.HeaderText = "Description";
            this.recordProjectDescription.Name = "recordProjectDescription";
            this.recordProjectDescription.ReadOnly = true;
            // 
            // recordTotalTime
            // 
            this.recordTotalTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.recordTotalTime.HeaderText = "Total Time";
            this.recordTotalTime.MinimumWidth = 100;
            this.recordTotalTime.Name = "recordTotalTime";
            this.recordTotalTime.ReadOnly = true;
            // 
            // btnRecordsOpen
            // 
            this.btnRecordsOpen.Location = new System.Drawing.Point(134, 5);
            this.btnRecordsOpen.Name = "btnRecordsOpen";
            this.btnRecordsOpen.Size = new System.Drawing.Size(75, 23);
            this.btnRecordsOpen.TabIndex = 2;
            this.btnRecordsOpen.Text = "Open";
            this.btnRecordsOpen.UseVisualStyleBackColor = true;
            this.btnRecordsOpen.Click += new System.EventHandler(this.btnRecordsOpen_Click);
            // 
            // comboBoxRecords
            // 
            this.comboBoxRecords.FormattingEnabled = true;
            this.comboBoxRecords.Location = new System.Drawing.Point(6, 8);
            this.comboBoxRecords.Name = "comboBoxRecords";
            this.comboBoxRecords.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRecords.TabIndex = 1;
            // 
            // projectTotalsBindingSource
            // 
            this.projectTotalsBindingSource.DataSource = typeof(TimeTracker.frmTimeTracker.ProjectTotals);
            // 
            // projectTotalsBindingSource1
            // 
            this.projectTotalsBindingSource1.DataSource = typeof(TimeTracker.frmTimeTracker.ProjectTotals);
            // 
            // frmTimeTracker
            // 
            this.AcceptButton = this.btnNewProject;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 497);
            this.Controls.Add(this.tabControl1);
            this.MaximumSize = new System.Drawing.Size(685, 535);
            this.MinimumSize = new System.Drawing.Size(685, 535);
            this.Name = "frmTimeTracker";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Time Tracker";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTimeTracker_FormClosing);
            this.Load += new System.EventHandler(this.frmTimeTracker_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectList)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGViewTotals)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotals)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGViewRecords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectTotalsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectTotalsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblProjectNumber;
        private System.Windows.Forms.Button btnNewProject;
        private System.Windows.Forms.TextBox tBoxPjtNumber;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cBoxDiscipline;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblDiscipline;
        private System.Windows.Forms.TextBox tBoxDescription;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAssistCAD;
        private System.Windows.Forms.Button btnAssistDesigner;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dGViewTotals;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDiscipline;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeDescription;
        private System.Windows.Forms.Button btnFinished;
        private System.Windows.Forms.Button btnMisc;
        private System.Windows.Forms.CheckBox chBoxCreateButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvProjectList;
        private System.Windows.Forms.Button btnClearProjects;
        private System.Windows.Forms.Button btnLunch;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvTotals;
        private System.Windows.Forms.Label lbl_CurrentInfo;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.DataGridViewButtonColumn btnProjectColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn btnDisciplineColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn btnDescriptionColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Delete_Row;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button btnNewDay;
        private System.Windows.Forms.Button btnAssistPM;
        private System.Windows.Forms.Button btnAddOnly;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnRecordsOpen;
        private System.Windows.Forms.ComboBox comboBoxRecords;
        private System.Windows.Forms.BindingSource projectTotalsBindingSource;
        private System.Windows.Forms.BindingSource projectTotalsBindingSource1;
        public System.Windows.Forms.DataGridView dGViewRecords;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordProjectNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordProjectDiscipline;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordProjectDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordTotalTime;
    }
}

