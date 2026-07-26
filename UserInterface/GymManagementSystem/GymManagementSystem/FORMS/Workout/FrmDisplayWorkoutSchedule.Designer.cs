namespace GymManagementSystem.FORMS.Workout
{
    partial class FrmDisplayWorkoutSchedule
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDisplayWorkoutSchedule));
            this.tlpAllWorkoutSheduleEntireForm = new System.Windows.Forms.TableLayoutPanel();
            this.tlpWorkoutSheduleTableAndSearch = new System.Windows.Forms.TableLayoutPanel();
            this.dgvWorkoutShedule = new System.Windows.Forms.DataGridView();
            this.colWorkoutDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExerciseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWorkoutName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSerialNo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpSearchAndAddWorkoutShedule = new System.Windows.Forms.TableLayoutPanel();
            this.pnlClickToAddNewWorkoutShedule = new System.Windows.Forms.Panel();
            this.tlpAddNewWorkoutSchedule = new System.Windows.Forms.TableLayoutPanel();
            this.lblAddNewWorkoutShedule = new System.Windows.Forms.Label();
            this.picPlusWorkoutShedule = new System.Windows.Forms.PictureBox();
            this.tlpSearchWorkoutSchedule = new System.Windows.Forms.TableLayoutPanel();
            this.cmbWorkoutDaySearch = new System.Windows.Forms.ComboBox();
            this.picSearchWorkoutShedule = new System.Windows.Forms.PictureBox();
            this.btnWorkoutSheduleSearch = new System.Windows.Forms.Button();
            this.tlpWorkoutSheduleHeader = new System.Windows.Forms.TableLayoutPanel();
            this.tlpAllWorkoutSheduleTitle = new System.Windows.Forms.TableLayoutPanel();
            this.lblAllWorkoutShedule = new System.Windows.Forms.Label();
            this.lblViewAllWorkoutSheduleDetails = new System.Windows.Forms.Label();
            this.picWorkoutShedule = new System.Windows.Forms.PictureBox();
            this.tlpAllWorkoutSheduleFromBack = new System.Windows.Forms.TableLayoutPanel();
            this.tlpAllWorkoutSheduleEntireForm.SuspendLayout();
            this.tlpWorkoutSheduleTableAndSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkoutShedule)).BeginInit();
            this.tlpSearchAndAddWorkoutShedule.SuspendLayout();
            this.pnlClickToAddNewWorkoutShedule.SuspendLayout();
            this.tlpAddNewWorkoutSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlusWorkoutShedule)).BeginInit();
            this.tlpSearchWorkoutSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearchWorkoutShedule)).BeginInit();
            this.tlpWorkoutSheduleHeader.SuspendLayout();
            this.tlpAllWorkoutSheduleTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWorkoutShedule)).BeginInit();
            this.tlpAllWorkoutSheduleFromBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpAllWorkoutSheduleEntireForm
            // 
            this.tlpAllWorkoutSheduleEntireForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tlpAllWorkoutSheduleEntireForm.ColumnCount = 1;
            this.tlpAllWorkoutSheduleEntireForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAllWorkoutSheduleEntireForm.Controls.Add(this.tlpWorkoutSheduleHeader, 0, 0);
            this.tlpAllWorkoutSheduleEntireForm.Controls.Add(this.tlpWorkoutSheduleTableAndSearch, 0, 2);
            this.tlpAllWorkoutSheduleEntireForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAllWorkoutSheduleEntireForm.Location = new System.Drawing.Point(20, 14);
            this.tlpAllWorkoutSheduleEntireForm.Name = "tlpAllWorkoutSheduleEntireForm";
            this.tlpAllWorkoutSheduleEntireForm.RowCount = 3;
            this.tlpAllWorkoutSheduleEntireForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.5942F));
            this.tlpAllWorkoutSheduleEntireForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.054018F));
            this.tlpAllWorkoutSheduleEntireForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.35178F));
            this.tlpAllWorkoutSheduleEntireForm.Size = new System.Drawing.Size(1009, 759);
            this.tlpAllWorkoutSheduleEntireForm.TabIndex = 4;
            // 
            // tlpWorkoutSheduleTableAndSearch
            // 
            this.tlpWorkoutSheduleTableAndSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tlpWorkoutSheduleTableAndSearch.ColumnCount = 2;
            this.tlpWorkoutSheduleTableAndSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.88734F));
            this.tlpWorkoutSheduleTableAndSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.11266F));
            this.tlpWorkoutSheduleTableAndSearch.Controls.Add(this.tlpSearchAndAddWorkoutShedule, 1, 0);
            this.tlpWorkoutSheduleTableAndSearch.Controls.Add(this.dgvWorkoutShedule, 0, 0);
            this.tlpWorkoutSheduleTableAndSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpWorkoutSheduleTableAndSearch.Location = new System.Drawing.Point(3, 97);
            this.tlpWorkoutSheduleTableAndSearch.Name = "tlpWorkoutSheduleTableAndSearch";
            this.tlpWorkoutSheduleTableAndSearch.RowCount = 1;
            this.tlpWorkoutSheduleTableAndSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpWorkoutSheduleTableAndSearch.Size = new System.Drawing.Size(1003, 659);
            this.tlpWorkoutSheduleTableAndSearch.TabIndex = 10;
            // 
            // dgvWorkoutShedule
            // 
            this.dgvWorkoutShedule.AllowUserToAddRows = false;
            this.dgvWorkoutShedule.AllowUserToDeleteRows = false;
            this.dgvWorkoutShedule.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvWorkoutShedule.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvWorkoutShedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWorkoutShedule.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvWorkoutShedule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvWorkoutShedule.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWorkoutShedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvWorkoutShedule.ColumnHeadersHeight = 50;
            this.dgvWorkoutShedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvWorkoutShedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSerialNo1,
            this.colWorkoutName,
            this.colExerciseName,
            this.colWorkoutDay});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvWorkoutShedule.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvWorkoutShedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWorkoutShedule.EnableHeadersVisualStyles = false;
            this.dgvWorkoutShedule.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvWorkoutShedule.Location = new System.Drawing.Point(3, 2);
            this.dgvWorkoutShedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvWorkoutShedule.MultiSelect = false;
            this.dgvWorkoutShedule.Name = "dgvWorkoutShedule";
            this.dgvWorkoutShedule.ReadOnly = true;
            this.dgvWorkoutShedule.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWorkoutShedule.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvWorkoutShedule.RowHeadersVisible = false;
            this.dgvWorkoutShedule.RowHeadersWidth = 50;
            this.dgvWorkoutShedule.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.dgvWorkoutShedule.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvWorkoutShedule.RowTemplate.Height = 40;
            this.dgvWorkoutShedule.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWorkoutShedule.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvWorkoutShedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvWorkoutShedule.Size = new System.Drawing.Size(704, 655);
            this.dgvWorkoutShedule.TabIndex = 11;
            this.dgvWorkoutShedule.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvWorkoutShedule_CellFormatting);
            this.dgvWorkoutShedule.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWorkoutShedule_CellMouseEnter);
            this.dgvWorkoutShedule.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWorkoutShedule_CellMouseLeave);
            // 
            // colWorkoutDay
            // 
            this.colWorkoutDay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colWorkoutDay.DataPropertyName = "WorkoutDay";
            this.colWorkoutDay.HeaderText = "Workout Day ";
            this.colWorkoutDay.Name = "colWorkoutDay";
            this.colWorkoutDay.ReadOnly = true;
            this.colWorkoutDay.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colExerciseName
            // 
            this.colExerciseName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colExerciseName.DataPropertyName = "ExerciseName";
            this.colExerciseName.HeaderText = "Exercise Name";
            this.colExerciseName.Name = "colExerciseName";
            this.colExerciseName.ReadOnly = true;
            this.colExerciseName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colExerciseName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colWorkoutName
            // 
            this.colWorkoutName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colWorkoutName.DataPropertyName = "WorkoutName";
            this.colWorkoutName.FillWeight = 180F;
            this.colWorkoutName.HeaderText = "Workout Name";
            this.colWorkoutName.Name = "colWorkoutName";
            this.colWorkoutName.ReadOnly = true;
            this.colWorkoutName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colWorkoutName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colSerialNo1
            // 
            this.colSerialNo1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSerialNo1.DataPropertyName = "SerialNo";
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Blue;
            this.colSerialNo1.DefaultCellStyle = dataGridViewCellStyle3;
            this.colSerialNo1.FillWeight = 90F;
            this.colSerialNo1.HeaderText = "Sl No.";
            this.colSerialNo1.Name = "colSerialNo1";
            this.colSerialNo1.ReadOnly = true;
            this.colSerialNo1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSerialNo1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tlpSearchAndAddWorkoutShedule
            // 
            this.tlpSearchAndAddWorkoutShedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tlpSearchAndAddWorkoutShedule.ColumnCount = 1;
            this.tlpSearchAndAddWorkoutShedule.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSearchAndAddWorkoutShedule.Controls.Add(this.tlpSearchWorkoutSchedule, 0, 0);
            this.tlpSearchAndAddWorkoutShedule.Controls.Add(this.pnlClickToAddNewWorkoutShedule, 0, 1);
            this.tlpSearchAndAddWorkoutShedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSearchAndAddWorkoutShedule.Location = new System.Drawing.Point(713, 3);
            this.tlpSearchAndAddWorkoutShedule.Name = "tlpSearchAndAddWorkoutShedule";
            this.tlpSearchAndAddWorkoutShedule.RowCount = 3;
            this.tlpSearchAndAddWorkoutShedule.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.347529F));
            this.tlpSearchAndAddWorkoutShedule.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.006814F));
            this.tlpSearchAndAddWorkoutShedule.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.81602F));
            this.tlpSearchAndAddWorkoutShedule.Size = new System.Drawing.Size(287, 653);
            this.tlpSearchAndAddWorkoutShedule.TabIndex = 14;
            this.tlpSearchAndAddWorkoutShedule.Click += new System.EventHandler(this.tlpWorkoutSheduleHeader_Click);
            // 
            // pnlClickToAddNewWorkoutShedule
            // 
            this.pnlClickToAddNewWorkoutShedule.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pnlClickToAddNewWorkoutShedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.pnlClickToAddNewWorkoutShedule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlClickToAddNewWorkoutShedule.Controls.Add(this.tlpAddNewWorkoutSchedule);
            this.pnlClickToAddNewWorkoutShedule.Location = new System.Drawing.Point(147, 62);
            this.pnlClickToAddNewWorkoutShedule.Name = "pnlClickToAddNewWorkoutShedule";
            this.pnlClickToAddNewWorkoutShedule.Size = new System.Drawing.Size(137, 36);
            this.pnlClickToAddNewWorkoutShedule.TabIndex = 12;
            this.pnlClickToAddNewWorkoutShedule.Click += new System.EventHandler(this.pnlClickToAddNewWorkoutShedule_Click);
            this.pnlClickToAddNewWorkoutShedule.MouseEnter += new System.EventHandler(this.pnlClickToAddNewWorkoutShedule_MouseEnter);
            // 
            // tlpAddNewWorkoutSchedule
            // 
            this.tlpAddNewWorkoutSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.tlpAddNewWorkoutSchedule.ColumnCount = 2;
            this.tlpAddNewWorkoutSchedule.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.14286F));
            this.tlpAddNewWorkoutSchedule.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.85714F));
            this.tlpAddNewWorkoutSchedule.Controls.Add(this.picPlusWorkoutShedule, 0, 0);
            this.tlpAddNewWorkoutSchedule.Controls.Add(this.lblAddNewWorkoutShedule, 1, 0);
            this.tlpAddNewWorkoutSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAddNewWorkoutSchedule.Location = new System.Drawing.Point(0, 0);
            this.tlpAddNewWorkoutSchedule.Name = "tlpAddNewWorkoutSchedule";
            this.tlpAddNewWorkoutSchedule.RowCount = 1;
            this.tlpAddNewWorkoutSchedule.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAddNewWorkoutSchedule.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAddNewWorkoutSchedule.Size = new System.Drawing.Size(135, 34);
            this.tlpAddNewWorkoutSchedule.TabIndex = 4;
            this.tlpAddNewWorkoutSchedule.Click += new System.EventHandler(this.pnlClickToAddNewWorkoutShedule_Click);
            this.tlpAddNewWorkoutSchedule.MouseEnter += new System.EventHandler(this.tlpAddNewWorkoutSchedule_MouseEnter);
            this.tlpAddNewWorkoutSchedule.MouseLeave += new System.EventHandler(this.tlpAddNewWorkoutSchedule_MouseLeave);
            // 
            // lblAddNewWorkoutShedule
            // 
            this.lblAddNewWorkoutShedule.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAddNewWorkoutShedule.AutoSize = true;
            this.lblAddNewWorkoutShedule.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewWorkoutShedule.ForeColor = System.Drawing.Color.Blue;
            this.lblAddNewWorkoutShedule.Location = new System.Drawing.Point(46, 7);
            this.lblAddNewWorkoutShedule.Name = "lblAddNewWorkoutShedule";
            this.lblAddNewWorkoutShedule.Size = new System.Drawing.Size(74, 20);
            this.lblAddNewWorkoutShedule.TabIndex = 0;
            this.lblAddNewWorkoutShedule.Text = "Add New";
            this.lblAddNewWorkoutShedule.Click += new System.EventHandler(this.pnlClickToAddNewWorkoutShedule_Click);
            this.lblAddNewWorkoutShedule.MouseEnter += new System.EventHandler(this.tlpAddNewWorkoutSchedule_MouseEnter);
            this.lblAddNewWorkoutShedule.MouseLeave += new System.EventHandler(this.tlpAddNewWorkoutSchedule_MouseLeave);
            // 
            // picPlusWorkoutShedule
            // 
            this.picPlusWorkoutShedule.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.picPlusWorkoutShedule.Image = ((System.Drawing.Image)(resources.GetObject("picPlusWorkoutShedule.Image")));
            this.picPlusWorkoutShedule.Location = new System.Drawing.Point(23, 8);
            this.picPlusWorkoutShedule.Name = "picPlusWorkoutShedule";
            this.picPlusWorkoutShedule.Size = new System.Drawing.Size(17, 17);
            this.picPlusWorkoutShedule.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlusWorkoutShedule.TabIndex = 1;
            this.picPlusWorkoutShedule.TabStop = false;
            this.picPlusWorkoutShedule.Click += new System.EventHandler(this.pnlClickToAddNewWorkoutShedule_Click);
            this.picPlusWorkoutShedule.MouseEnter += new System.EventHandler(this.tlpAddNewWorkoutSchedule_MouseEnter);
            this.picPlusWorkoutShedule.MouseLeave += new System.EventHandler(this.tlpAddNewWorkoutSchedule_MouseLeave);
            // 
            // tlpSearchWorkoutSchedule
            // 
            this.tlpSearchWorkoutSchedule.ColumnCount = 3;
            this.tlpSearchWorkoutSchedule.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpSearchWorkoutSchedule.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSearchWorkoutSchedule.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tlpSearchWorkoutSchedule.Controls.Add(this.btnWorkoutSheduleSearch, 2, 0);
            this.tlpSearchWorkoutSchedule.Controls.Add(this.picSearchWorkoutShedule, 0, 0);
            this.tlpSearchWorkoutSchedule.Controls.Add(this.cmbWorkoutDaySearch, 1, 0);
            this.tlpSearchWorkoutSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSearchWorkoutSchedule.Location = new System.Drawing.Point(3, 3);
            this.tlpSearchWorkoutSchedule.Name = "tlpSearchWorkoutSchedule";
            this.tlpSearchWorkoutSchedule.RowCount = 1;
            this.tlpSearchWorkoutSchedule.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSearchWorkoutSchedule.Size = new System.Drawing.Size(281, 48);
            this.tlpSearchWorkoutSchedule.TabIndex = 12;
            this.tlpSearchWorkoutSchedule.Click += new System.EventHandler(this.tlpWorkoutSheduleHeader_Click);
            // 
            // cmbWorkoutDaySearch
            // 
            this.cmbWorkoutDaySearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbWorkoutDaySearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbWorkoutDaySearch.FormattingEnabled = true;
            this.cmbWorkoutDaySearch.Location = new System.Drawing.Point(43, 3);
            this.cmbWorkoutDaySearch.Name = "cmbWorkoutDaySearch";
            this.cmbWorkoutDaySearch.Size = new System.Drawing.Size(150, 31);
            this.cmbWorkoutDaySearch.TabIndex = 4;
            this.cmbWorkoutDaySearch.Text = "----Select Day----";
            // 
            // picSearchWorkoutShedule
            // 
            this.picSearchWorkoutShedule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picSearchWorkoutShedule.Image = ((System.Drawing.Image)(resources.GetObject("picSearchWorkoutShedule.Image")));
            this.picSearchWorkoutShedule.Location = new System.Drawing.Point(4, 3);
            this.picSearchWorkoutShedule.Name = "picSearchWorkoutShedule";
            this.picSearchWorkoutShedule.Size = new System.Drawing.Size(33, 31);
            this.picSearchWorkoutShedule.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSearchWorkoutShedule.TabIndex = 3;
            this.picSearchWorkoutShedule.TabStop = false;
            this.picSearchWorkoutShedule.Click += new System.EventHandler(this.tlpWorkoutSheduleHeader_Click);
            // 
            // btnWorkoutSheduleSearch
            // 
            this.btnWorkoutSheduleSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWorkoutSheduleSearch.AutoSize = true;
            this.btnWorkoutSheduleSearch.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnWorkoutSheduleSearch.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnWorkoutSheduleSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnWorkoutSheduleSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWorkoutSheduleSearch.ForeColor = System.Drawing.Color.White;
            this.btnWorkoutSheduleSearch.Location = new System.Drawing.Point(220, 0);
            this.btnWorkoutSheduleSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnWorkoutSheduleSearch.Name = "btnWorkoutSheduleSearch";
            this.btnWorkoutSheduleSearch.Size = new System.Drawing.Size(61, 29);
            this.btnWorkoutSheduleSearch.TabIndex = 2;
            this.btnWorkoutSheduleSearch.Text = "Search";
            this.btnWorkoutSheduleSearch.UseVisualStyleBackColor = false;
            // 
            // tlpWorkoutSheduleHeader
            // 
            this.tlpWorkoutSheduleHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tlpWorkoutSheduleHeader.ColumnCount = 4;
            this.tlpWorkoutSheduleHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tlpWorkoutSheduleHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tlpWorkoutSheduleHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.16434F));
            this.tlpWorkoutSheduleHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.83566F));
            this.tlpWorkoutSheduleHeader.Controls.Add(this.picWorkoutShedule, 0, 0);
            this.tlpWorkoutSheduleHeader.Controls.Add(this.tlpAllWorkoutSheduleTitle, 1, 0);
            this.tlpWorkoutSheduleHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpWorkoutSheduleHeader.Location = new System.Drawing.Point(3, 2);
            this.tlpWorkoutSheduleHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpWorkoutSheduleHeader.Name = "tlpWorkoutSheduleHeader";
            this.tlpWorkoutSheduleHeader.RowCount = 1;
            this.tlpWorkoutSheduleHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpWorkoutSheduleHeader.Size = new System.Drawing.Size(1003, 83);
            this.tlpWorkoutSheduleHeader.TabIndex = 9;
            this.tlpWorkoutSheduleHeader.Click += new System.EventHandler(this.tlpWorkoutSheduleHeader_Click);
            // 
            // tlpAllWorkoutSheduleTitle
            // 
            this.tlpAllWorkoutSheduleTitle.ColumnCount = 1;
            this.tlpAllWorkoutSheduleTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAllWorkoutSheduleTitle.Controls.Add(this.lblViewAllWorkoutSheduleDetails, 0, 1);
            this.tlpAllWorkoutSheduleTitle.Controls.Add(this.lblAllWorkoutShedule, 0, 0);
            this.tlpAllWorkoutSheduleTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAllWorkoutSheduleTitle.Location = new System.Drawing.Point(85, 3);
            this.tlpAllWorkoutSheduleTitle.Name = "tlpAllWorkoutSheduleTitle";
            this.tlpAllWorkoutSheduleTitle.RowCount = 3;
            this.tlpAllWorkoutSheduleTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.81967F));
            this.tlpAllWorkoutSheduleTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.5082F));
            this.tlpAllWorkoutSheduleTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.03279F));
            this.tlpAllWorkoutSheduleTitle.Size = new System.Drawing.Size(294, 77);
            this.tlpAllWorkoutSheduleTitle.TabIndex = 1;
            this.tlpAllWorkoutSheduleTitle.Click += new System.EventHandler(this.tlpWorkoutSheduleHeader_Click);
            // 
            // lblAllWorkoutShedule
            // 
            this.lblAllWorkoutShedule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAllWorkoutShedule.AutoSize = true;
            this.lblAllWorkoutShedule.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllWorkoutShedule.Location = new System.Drawing.Point(3, 11);
            this.lblAllWorkoutShedule.Name = "lblAllWorkoutShedule";
            this.lblAllWorkoutShedule.Size = new System.Drawing.Size(200, 28);
            this.lblAllWorkoutShedule.TabIndex = 2;
            this.lblAllWorkoutShedule.Text = "All Workout Shedule";
            // 
            // lblViewAllWorkoutSheduleDetails
            // 
            this.lblViewAllWorkoutSheduleDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblViewAllWorkoutSheduleDetails.AutoSize = true;
            this.lblViewAllWorkoutSheduleDetails.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewAllWorkoutSheduleDetails.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblViewAllWorkoutSheduleDetails.Location = new System.Drawing.Point(3, 43);
            this.lblViewAllWorkoutSheduleDetails.Name = "lblViewAllWorkoutSheduleDetails";
            this.lblViewAllWorkoutSheduleDetails.Size = new System.Drawing.Size(259, 19);
            this.lblViewAllWorkoutSheduleDetails.TabIndex = 3;
            this.lblViewAllWorkoutSheduleDetails.Text = "View All Type of Workout Shedule Details";
            // 
            // picWorkoutShedule
            // 
            this.picWorkoutShedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picWorkoutShedule.Image = ((System.Drawing.Image)(resources.GetObject("picWorkoutShedule.Image")));
            this.picWorkoutShedule.Location = new System.Drawing.Point(3, 3);
            this.picWorkoutShedule.Name = "picWorkoutShedule";
            this.picWorkoutShedule.Size = new System.Drawing.Size(76, 77);
            this.picWorkoutShedule.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWorkoutShedule.TabIndex = 0;
            this.picWorkoutShedule.TabStop = false;
            this.picWorkoutShedule.Click += new System.EventHandler(this.tlpWorkoutSheduleHeader_Click);
            // 
            // tlpAllWorkoutSheduleFromBack
            // 
            this.tlpAllWorkoutSheduleFromBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tlpAllWorkoutSheduleFromBack.ColumnCount = 3;
            this.tlpAllWorkoutSheduleFromBack.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.620591F));
            this.tlpAllWorkoutSheduleFromBack.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96.75882F));
            this.tlpAllWorkoutSheduleFromBack.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.620591F));
            this.tlpAllWorkoutSheduleFromBack.Controls.Add(this.tlpAllWorkoutSheduleEntireForm, 1, 1);
            this.tlpAllWorkoutSheduleFromBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAllWorkoutSheduleFromBack.Location = new System.Drawing.Point(0, 0);
            this.tlpAllWorkoutSheduleFromBack.Name = "tlpAllWorkoutSheduleFromBack";
            this.tlpAllWorkoutSheduleFromBack.RowCount = 3;
            this.tlpAllWorkoutSheduleFromBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.395939F));
            this.tlpAllWorkoutSheduleFromBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 97.08121F));
            this.tlpAllWorkoutSheduleFromBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.395939F));
            this.tlpAllWorkoutSheduleFromBack.Size = new System.Drawing.Size(1049, 788);
            this.tlpAllWorkoutSheduleFromBack.TabIndex = 0;
            this.tlpAllWorkoutSheduleFromBack.Click += new System.EventHandler(this.tlpWorkoutSheduleHeader_Click);
            // 
            // FrmDisplayWorkoutSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 788);
            this.Controls.Add(this.tlpAllWorkoutSheduleFromBack);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1067, 835);
            this.Name = "FrmDisplayWorkoutSchedule";
            this.Text = "FrmDisplayWorkoutSchedule";
            this.Load += new System.EventHandler(this.FrmDisplayWorkoutSchedule_Load);
            this.tlpAllWorkoutSheduleEntireForm.ResumeLayout(false);
            this.tlpWorkoutSheduleTableAndSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkoutShedule)).EndInit();
            this.tlpSearchAndAddWorkoutShedule.ResumeLayout(false);
            this.pnlClickToAddNewWorkoutShedule.ResumeLayout(false);
            this.tlpAddNewWorkoutSchedule.ResumeLayout(false);
            this.tlpAddNewWorkoutSchedule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlusWorkoutShedule)).EndInit();
            this.tlpSearchWorkoutSchedule.ResumeLayout(false);
            this.tlpSearchWorkoutSchedule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearchWorkoutShedule)).EndInit();
            this.tlpWorkoutSheduleHeader.ResumeLayout(false);
            this.tlpAllWorkoutSheduleTitle.ResumeLayout(false);
            this.tlpAllWorkoutSheduleTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWorkoutShedule)).EndInit();
            this.tlpAllWorkoutSheduleFromBack.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpAllWorkoutSheduleEntireForm;
        private System.Windows.Forms.TableLayoutPanel tlpWorkoutSheduleHeader;
        private System.Windows.Forms.PictureBox picWorkoutShedule;
        private System.Windows.Forms.TableLayoutPanel tlpAllWorkoutSheduleTitle;
        private System.Windows.Forms.Label lblViewAllWorkoutSheduleDetails;
        private System.Windows.Forms.Label lblAllWorkoutShedule;
        private System.Windows.Forms.TableLayoutPanel tlpWorkoutSheduleTableAndSearch;
        private System.Windows.Forms.TableLayoutPanel tlpSearchAndAddWorkoutShedule;
        private System.Windows.Forms.TableLayoutPanel tlpSearchWorkoutSchedule;
        private System.Windows.Forms.Button btnWorkoutSheduleSearch;
        private System.Windows.Forms.PictureBox picSearchWorkoutShedule;
        private System.Windows.Forms.ComboBox cmbWorkoutDaySearch;
        private System.Windows.Forms.Panel pnlClickToAddNewWorkoutShedule;
        private System.Windows.Forms.TableLayoutPanel tlpAddNewWorkoutSchedule;
        private System.Windows.Forms.PictureBox picPlusWorkoutShedule;
        private System.Windows.Forms.Label lblAddNewWorkoutShedule;
        private System.Windows.Forms.DataGridView dgvWorkoutShedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSerialNo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWorkoutName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExerciseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWorkoutDay;
        private System.Windows.Forms.TableLayoutPanel tlpAllWorkoutSheduleFromBack;


    }
}