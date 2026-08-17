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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDisplayWorkoutSchedule));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpAllWorkoutSheduleEntireForm = new System.Windows.Forms.TableLayoutPanel();
            this.tlpWorkoutSheduleHeader = new System.Windows.Forms.TableLayoutPanel();
            this.picWorkoutShedule = new System.Windows.Forms.PictureBox();
            this.tlpAllWorkoutSheduleTitle = new System.Windows.Forms.TableLayoutPanel();
            this.lblViewAllWorkoutSheduleDetails = new System.Windows.Forms.Label();
            this.lblAllWorkoutShedule = new System.Windows.Forms.Label();
            this.tlpWorkoutSheduleTableAndSearch = new System.Windows.Forms.TableLayoutPanel();
            this.tlpSearchAndAddWorkoutShedule = new System.Windows.Forms.TableLayoutPanel();
            this.tlpSearchWorkoutSchedule = new System.Windows.Forms.TableLayoutPanel();
            this.picSearchWorkoutShedule = new System.Windows.Forms.PictureBox();
            this.cmbWorkoutDaySearch = new System.Windows.Forms.ComboBox();
            this.btnWorkoutSheduleDisplayAll = new System.Windows.Forms.Button();
            this.pnlClickToAddNewWorkoutShedule = new System.Windows.Forms.Panel();
            this.tlpAddNewWorkoutSchedule = new System.Windows.Forms.TableLayoutPanel();
            this.picPlusWorkoutShedule = new System.Windows.Forms.PictureBox();
            this.lblAddNewWorkoutShedule = new System.Windows.Forms.Label();
            this.dgvWorkoutShedule = new System.Windows.Forms.DataGridView();
            this.colSerialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWorkoutName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExerciseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWorkoutDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colWorkoutScheduleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpAllWorkoutSheduleFromBack = new System.Windows.Forms.TableLayoutPanel();
            this.tlpAllWorkoutSheduleEntireForm.SuspendLayout();
            this.tlpWorkoutSheduleHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWorkoutShedule)).BeginInit();
            this.tlpAllWorkoutSheduleTitle.SuspendLayout();
            this.tlpWorkoutSheduleTableAndSearch.SuspendLayout();
            this.tlpSearchAndAddWorkoutShedule.SuspendLayout();
            this.tlpSearchWorkoutSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearchWorkoutShedule)).BeginInit();
            this.pnlClickToAddNewWorkoutShedule.SuspendLayout();
            this.tlpAddNewWorkoutSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlusWorkoutShedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkoutShedule)).BeginInit();
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
            this.tlpAllWorkoutSheduleEntireForm.Location = new System.Drawing.Point(45, 23);
            this.tlpAllWorkoutSheduleEntireForm.Margin = new System.Windows.Forms.Padding(2);
            this.tlpAllWorkoutSheduleEntireForm.Name = "tlpAllWorkoutSheduleEntireForm";
            this.tlpAllWorkoutSheduleEntireForm.RowCount = 3;
            this.tlpAllWorkoutSheduleEntireForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tlpAllWorkoutSheduleEntireForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.054018F));
            this.tlpAllWorkoutSheduleEntireForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.72581F));
            this.tlpAllWorkoutSheduleEntireForm.Size = new System.Drawing.Size(771, 574);
            this.tlpAllWorkoutSheduleEntireForm.TabIndex = 4;
            // 
            // tlpWorkoutSheduleHeader
            // 
            this.tlpWorkoutSheduleHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tlpWorkoutSheduleHeader.ColumnCount = 4;
            this.tlpWorkoutSheduleHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tlpWorkoutSheduleHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 239F));
            this.tlpWorkoutSheduleHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.16434F));
            this.tlpWorkoutSheduleHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.83566F));
            this.tlpWorkoutSheduleHeader.Controls.Add(this.picWorkoutShedule, 0, 0);
            this.tlpWorkoutSheduleHeader.Controls.Add(this.tlpAllWorkoutSheduleTitle, 1, 0);
            this.tlpWorkoutSheduleHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpWorkoutSheduleHeader.Location = new System.Drawing.Point(2, 2);
            this.tlpWorkoutSheduleHeader.Margin = new System.Windows.Forms.Padding(2);
            this.tlpWorkoutSheduleHeader.Name = "tlpWorkoutSheduleHeader";
            this.tlpWorkoutSheduleHeader.RowCount = 1;
            this.tlpWorkoutSheduleHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpWorkoutSheduleHeader.Size = new System.Drawing.Size(767, 43);
            this.tlpWorkoutSheduleHeader.TabIndex = 9;
            this.tlpWorkoutSheduleHeader.Click += new System.EventHandler(this.tlpWorkoutSheduleHeader_Click);
            // 
            // picWorkoutShedule
            // 
            this.picWorkoutShedule.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.picWorkoutShedule.Image = ((System.Drawing.Image)(resources.GetObject("picWorkoutShedule.Image")));
            this.picWorkoutShedule.Location = new System.Drawing.Point(2, 2);
            this.picWorkoutShedule.Margin = new System.Windows.Forms.Padding(2);
            this.picWorkoutShedule.Name = "picWorkoutShedule";
            this.picWorkoutShedule.Size = new System.Drawing.Size(44, 39);
            this.picWorkoutShedule.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWorkoutShedule.TabIndex = 0;
            this.picWorkoutShedule.TabStop = false;
            this.picWorkoutShedule.Click += new System.EventHandler(this.tlpWorkoutSheduleHeader_Click);
            // 
            // tlpAllWorkoutSheduleTitle
            // 
            this.tlpAllWorkoutSheduleTitle.ColumnCount = 1;
            this.tlpAllWorkoutSheduleTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAllWorkoutSheduleTitle.Controls.Add(this.lblViewAllWorkoutSheduleDetails, 0, 1);
            this.tlpAllWorkoutSheduleTitle.Controls.Add(this.lblAllWorkoutShedule, 0, 0);
            this.tlpAllWorkoutSheduleTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAllWorkoutSheduleTitle.Location = new System.Drawing.Point(50, 2);
            this.tlpAllWorkoutSheduleTitle.Margin = new System.Windows.Forms.Padding(2);
            this.tlpAllWorkoutSheduleTitle.Name = "tlpAllWorkoutSheduleTitle";
            this.tlpAllWorkoutSheduleTitle.RowCount = 2;
            this.tlpAllWorkoutSheduleTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.49057F));
            this.tlpAllWorkoutSheduleTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.50943F));
            this.tlpAllWorkoutSheduleTitle.Size = new System.Drawing.Size(235, 39);
            this.tlpAllWorkoutSheduleTitle.TabIndex = 1;
            this.tlpAllWorkoutSheduleTitle.Click += new System.EventHandler(this.tlpWorkoutSheduleHeader_Click);
            // 
            // lblViewAllWorkoutSheduleDetails
            // 
            this.lblViewAllWorkoutSheduleDetails.AutoSize = true;
            this.lblViewAllWorkoutSheduleDetails.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewAllWorkoutSheduleDetails.ForeColor = System.Drawing.Color.Gray;
            this.lblViewAllWorkoutSheduleDetails.Location = new System.Drawing.Point(2, 22);
            this.lblViewAllWorkoutSheduleDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblViewAllWorkoutSheduleDetails.Name = "lblViewAllWorkoutSheduleDetails";
            this.lblViewAllWorkoutSheduleDetails.Size = new System.Drawing.Size(219, 13);
            this.lblViewAllWorkoutSheduleDetails.TabIndex = 3;
            this.lblViewAllWorkoutSheduleDetails.Text = "View All Type of Workout Shedule Details";
            // 
            // lblAllWorkoutShedule
            // 
            this.lblAllWorkoutShedule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAllWorkoutShedule.AutoSize = true;
            this.lblAllWorkoutShedule.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllWorkoutShedule.Location = new System.Drawing.Point(2, 1);
            this.lblAllWorkoutShedule.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAllWorkoutShedule.Name = "lblAllWorkoutShedule";
            this.lblAllWorkoutShedule.Size = new System.Drawing.Size(160, 21);
            this.lblAllWorkoutShedule.TabIndex = 2;
            this.lblAllWorkoutShedule.Text = "All Workout Shedule";
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
            this.tlpWorkoutSheduleTableAndSearch.Location = new System.Drawing.Point(2, 55);
            this.tlpWorkoutSheduleTableAndSearch.Margin = new System.Windows.Forms.Padding(2);
            this.tlpWorkoutSheduleTableAndSearch.Name = "tlpWorkoutSheduleTableAndSearch";
            this.tlpWorkoutSheduleTableAndSearch.RowCount = 1;
            this.tlpWorkoutSheduleTableAndSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpWorkoutSheduleTableAndSearch.Size = new System.Drawing.Size(767, 517);
            this.tlpWorkoutSheduleTableAndSearch.TabIndex = 10;
            // 
            // tlpSearchAndAddWorkoutShedule
            // 
            this.tlpSearchAndAddWorkoutShedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tlpSearchAndAddWorkoutShedule.ColumnCount = 1;
            this.tlpSearchAndAddWorkoutShedule.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSearchAndAddWorkoutShedule.Controls.Add(this.tlpSearchWorkoutSchedule, 0, 0);
            this.tlpSearchAndAddWorkoutShedule.Controls.Add(this.pnlClickToAddNewWorkoutShedule, 0, 1);
            this.tlpSearchAndAddWorkoutShedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSearchAndAddWorkoutShedule.Location = new System.Drawing.Point(545, 2);
            this.tlpSearchAndAddWorkoutShedule.Margin = new System.Windows.Forms.Padding(2);
            this.tlpSearchAndAddWorkoutShedule.Name = "tlpSearchAndAddWorkoutShedule";
            this.tlpSearchAndAddWorkoutShedule.RowCount = 3;
            this.tlpSearchAndAddWorkoutShedule.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.347529F));
            this.tlpSearchAndAddWorkoutShedule.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.006814F));
            this.tlpSearchAndAddWorkoutShedule.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.81602F));
            this.tlpSearchAndAddWorkoutShedule.Size = new System.Drawing.Size(220, 513);
            this.tlpSearchAndAddWorkoutShedule.TabIndex = 14;
            this.tlpSearchAndAddWorkoutShedule.Click += new System.EventHandler(this.tlpWorkoutSheduleHeader_Click);
            // 
            // tlpSearchWorkoutSchedule
            // 
            this.tlpSearchWorkoutSchedule.ColumnCount = 3;
            this.tlpSearchWorkoutSchedule.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpSearchWorkoutSchedule.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSearchWorkoutSchedule.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tlpSearchWorkoutSchedule.Controls.Add(this.picSearchWorkoutShedule, 0, 0);
            this.tlpSearchWorkoutSchedule.Controls.Add(this.cmbWorkoutDaySearch, 1, 0);
            this.tlpSearchWorkoutSchedule.Controls.Add(this.btnWorkoutSheduleDisplayAll, 2, 0);
            this.tlpSearchWorkoutSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSearchWorkoutSchedule.Location = new System.Drawing.Point(2, 2);
            this.tlpSearchWorkoutSchedule.Margin = new System.Windows.Forms.Padding(2);
            this.tlpSearchWorkoutSchedule.Name = "tlpSearchWorkoutSchedule";
            this.tlpSearchWorkoutSchedule.RowCount = 1;
            this.tlpSearchWorkoutSchedule.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSearchWorkoutSchedule.Size = new System.Drawing.Size(216, 38);
            this.tlpSearchWorkoutSchedule.TabIndex = 12;
            this.tlpSearchWorkoutSchedule.Click += new System.EventHandler(this.tlpWorkoutSheduleHeader_Click);
            // 
            // picSearchWorkoutShedule
            // 
            this.picSearchWorkoutShedule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picSearchWorkoutShedule.Image = ((System.Drawing.Image)(resources.GetObject("picSearchWorkoutShedule.Image")));
            this.picSearchWorkoutShedule.Location = new System.Drawing.Point(3, 2);
            this.picSearchWorkoutShedule.Margin = new System.Windows.Forms.Padding(2);
            this.picSearchWorkoutShedule.Name = "picSearchWorkoutShedule";
            this.picSearchWorkoutShedule.Size = new System.Drawing.Size(25, 25);
            this.picSearchWorkoutShedule.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSearchWorkoutShedule.TabIndex = 3;
            this.picSearchWorkoutShedule.TabStop = false;
            this.picSearchWorkoutShedule.Click += new System.EventHandler(this.tlpWorkoutSheduleHeader_Click);
            // 
            // cmbWorkoutDaySearch
            // 
            this.cmbWorkoutDaySearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbWorkoutDaySearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWorkoutDaySearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbWorkoutDaySearch.ForeColor = System.Drawing.Color.Black;
            this.cmbWorkoutDaySearch.FormattingEnabled = true;
            this.cmbWorkoutDaySearch.Location = new System.Drawing.Point(32, 2);
            this.cmbWorkoutDaySearch.Margin = new System.Windows.Forms.Padding(2);
            this.cmbWorkoutDaySearch.Name = "cmbWorkoutDaySearch";
            this.cmbWorkoutDaySearch.Size = new System.Drawing.Size(110, 27);
            this.cmbWorkoutDaySearch.TabIndex = 4;
            this.cmbWorkoutDaySearch.SelectionChangeCommitted += new System.EventHandler(this.cmbWorkoutDaySearch_SelectionChangeCommitted);
            // 
            // btnWorkoutSheduleDisplayAll
            // 
            this.btnWorkoutSheduleDisplayAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWorkoutSheduleDisplayAll.AutoSize = true;
            this.btnWorkoutSheduleDisplayAll.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnWorkoutSheduleDisplayAll.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnWorkoutSheduleDisplayAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnWorkoutSheduleDisplayAll.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWorkoutSheduleDisplayAll.ForeColor = System.Drawing.Color.White;
            this.btnWorkoutSheduleDisplayAll.Location = new System.Drawing.Point(144, 0);
            this.btnWorkoutSheduleDisplayAll.Margin = new System.Windows.Forms.Padding(0);
            this.btnWorkoutSheduleDisplayAll.Name = "btnWorkoutSheduleDisplayAll";
            this.btnWorkoutSheduleDisplayAll.Size = new System.Drawing.Size(72, 29);
            this.btnWorkoutSheduleDisplayAll.TabIndex = 2;
            this.btnWorkoutSheduleDisplayAll.Text = "Display All";
            this.btnWorkoutSheduleDisplayAll.UseVisualStyleBackColor = false;
            this.btnWorkoutSheduleDisplayAll.Click += new System.EventHandler(this.btnWorkoutSheduleDisplayAll_Click);
            // 
            // pnlClickToAddNewWorkoutShedule
            // 
            this.pnlClickToAddNewWorkoutShedule.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlClickToAddNewWorkoutShedule.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlClickToAddNewWorkoutShedule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlClickToAddNewWorkoutShedule.Controls.Add(this.tlpAddNewWorkoutSchedule);
            this.pnlClickToAddNewWorkoutShedule.Location = new System.Drawing.Point(65, 48);
            this.pnlClickToAddNewWorkoutShedule.Margin = new System.Windows.Forms.Padding(2);
            this.pnlClickToAddNewWorkoutShedule.Name = "pnlClickToAddNewWorkoutShedule";
            this.pnlClickToAddNewWorkoutShedule.Size = new System.Drawing.Size(90, 29);
            this.pnlClickToAddNewWorkoutShedule.TabIndex = 12;
            this.pnlClickToAddNewWorkoutShedule.Click += new System.EventHandler(this.pnlClickToAddNewWorkoutShedule_Click);
            this.pnlClickToAddNewWorkoutShedule.MouseEnter += new System.EventHandler(this.pnlClickToAddNewWorkoutShedule_MouseEnter);
            this.pnlClickToAddNewWorkoutShedule.MouseLeave += new System.EventHandler(this.pnlClickToAddNewWorkoutShedule_MouseLeave);
            // 
            // tlpAddNewWorkoutSchedule
            // 
            this.tlpAddNewWorkoutSchedule.BackColor = System.Drawing.Color.Transparent;
            this.tlpAddNewWorkoutSchedule.ColumnCount = 2;
            this.tlpAddNewWorkoutSchedule.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpAddNewWorkoutSchedule.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tlpAddNewWorkoutSchedule.Controls.Add(this.picPlusWorkoutShedule, 0, 0);
            this.tlpAddNewWorkoutSchedule.Controls.Add(this.lblAddNewWorkoutShedule, 1, 0);
            this.tlpAddNewWorkoutSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAddNewWorkoutSchedule.Location = new System.Drawing.Point(0, 0);
            this.tlpAddNewWorkoutSchedule.Margin = new System.Windows.Forms.Padding(2);
            this.tlpAddNewWorkoutSchedule.Name = "tlpAddNewWorkoutSchedule";
            this.tlpAddNewWorkoutSchedule.RowCount = 1;
            this.tlpAddNewWorkoutSchedule.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAddNewWorkoutSchedule.Size = new System.Drawing.Size(88, 27);
            this.tlpAddNewWorkoutSchedule.TabIndex = 4;
            this.tlpAddNewWorkoutSchedule.Click += new System.EventHandler(this.pnlClickToAddNewWorkoutShedule_Click);
            this.tlpAddNewWorkoutSchedule.MouseEnter += new System.EventHandler(this.pnlClickToAddNewWorkoutShedule_MouseEnter);
            this.tlpAddNewWorkoutSchedule.MouseLeave += new System.EventHandler(this.pnlClickToAddNewWorkoutShedule_MouseLeave);
            // 
            // picPlusWorkoutShedule
            // 
            this.picPlusWorkoutShedule.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.picPlusWorkoutShedule.Image = global::GymManagementSystem.Properties.Resources.plus;
            this.picPlusWorkoutShedule.Location = new System.Drawing.Point(7, 6);
            this.picPlusWorkoutShedule.Margin = new System.Windows.Forms.Padding(2);
            this.picPlusWorkoutShedule.Name = "picPlusWorkoutShedule";
            this.picPlusWorkoutShedule.Size = new System.Drawing.Size(13, 14);
            this.picPlusWorkoutShedule.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlusWorkoutShedule.TabIndex = 1;
            this.picPlusWorkoutShedule.TabStop = false;
            this.picPlusWorkoutShedule.Click += new System.EventHandler(this.pnlClickToAddNewWorkoutShedule_Click);
            this.picPlusWorkoutShedule.MouseEnter += new System.EventHandler(this.pnlClickToAddNewWorkoutShedule_MouseEnter);
            this.picPlusWorkoutShedule.MouseLeave += new System.EventHandler(this.pnlClickToAddNewWorkoutShedule_MouseLeave);
            // 
            // lblAddNewWorkoutShedule
            // 
            this.lblAddNewWorkoutShedule.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAddNewWorkoutShedule.AutoSize = true;
            this.lblAddNewWorkoutShedule.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewWorkoutShedule.ForeColor = System.Drawing.Color.White;
            this.lblAddNewWorkoutShedule.Location = new System.Drawing.Point(24, 6);
            this.lblAddNewWorkoutShedule.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddNewWorkoutShedule.Name = "lblAddNewWorkoutShedule";
            this.lblAddNewWorkoutShedule.Size = new System.Drawing.Size(58, 15);
            this.lblAddNewWorkoutShedule.TabIndex = 0;
            this.lblAddNewWorkoutShedule.Text = "Add New";
            this.lblAddNewWorkoutShedule.Click += new System.EventHandler(this.pnlClickToAddNewWorkoutShedule_Click);
            this.lblAddNewWorkoutShedule.MouseEnter += new System.EventHandler(this.pnlClickToAddNewWorkoutShedule_MouseEnter);
            this.lblAddNewWorkoutShedule.MouseLeave += new System.EventHandler(this.pnlClickToAddNewWorkoutShedule_MouseLeave);
            // 
            // dgvWorkoutShedule
            // 
            this.dgvWorkoutShedule.AllowUserToAddRows = false;
            this.dgvWorkoutShedule.AllowUserToDeleteRows = false;
            this.dgvWorkoutShedule.AllowUserToResizeRows = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dgvWorkoutShedule.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvWorkoutShedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWorkoutShedule.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvWorkoutShedule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvWorkoutShedule.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWorkoutShedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvWorkoutShedule.ColumnHeadersHeight = 40;
            this.dgvWorkoutShedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvWorkoutShedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSerialNo,
            this.colWorkoutName,
            this.colExerciseName,
            this.colWorkoutDay,
            this.colDelete,
            this.colWorkoutScheduleId});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvWorkoutShedule.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvWorkoutShedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWorkoutShedule.EnableHeadersVisualStyles = false;
            this.dgvWorkoutShedule.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvWorkoutShedule.Location = new System.Drawing.Point(2, 2);
            this.dgvWorkoutShedule.Margin = new System.Windows.Forms.Padding(2);
            this.dgvWorkoutShedule.MultiSelect = false;
            this.dgvWorkoutShedule.Name = "dgvWorkoutShedule";
            this.dgvWorkoutShedule.ReadOnly = true;
            this.dgvWorkoutShedule.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWorkoutShedule.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvWorkoutShedule.RowHeadersVisible = false;
            this.dgvWorkoutShedule.RowHeadersWidth = 50;
            this.dgvWorkoutShedule.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dgvWorkoutShedule.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvWorkoutShedule.RowTemplate.Height = 30;
            this.dgvWorkoutShedule.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvWorkoutShedule.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvWorkoutShedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvWorkoutShedule.Size = new System.Drawing.Size(539, 513);
            this.dgvWorkoutShedule.TabIndex = 11;
            this.dgvWorkoutShedule.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWorkoutShedule_CellContentClick);
            this.dgvWorkoutShedule.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvWorkoutShedule_CellFormatting);
            this.dgvWorkoutShedule.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWorkoutShedule_CellMouseEnter);
            this.dgvWorkoutShedule.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWorkoutShedule_CellMouseLeave);
            this.dgvWorkoutShedule.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvWorkoutShedule_CellPainting);
            // 
            // colSerialNo
            // 
            this.colSerialNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSerialNo.DataPropertyName = "SerialNo";
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Blue;
            this.colSerialNo.DefaultCellStyle = dataGridViewCellStyle10;
            this.colSerialNo.FillWeight = 90F;
            this.colSerialNo.HeaderText = "Sl No.";
            this.colSerialNo.Name = "colSerialNo";
            this.colSerialNo.ReadOnly = true;
            this.colSerialNo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSerialNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colSerialNo.Width = 70;
            // 
            // colWorkoutName
            // 
            this.colWorkoutName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colWorkoutName.DataPropertyName = "WorkoutName";
            this.colWorkoutName.FillWeight = 90.47619F;
            this.colWorkoutName.HeaderText = "Workout Name";
            this.colWorkoutName.Name = "colWorkoutName";
            this.colWorkoutName.ReadOnly = true;
            this.colWorkoutName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colWorkoutName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colExerciseName
            // 
            this.colExerciseName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colExerciseName.DataPropertyName = "ExerciseName";
            this.colExerciseName.FillWeight = 50.26455F;
            this.colExerciseName.HeaderText = "Exercise Name";
            this.colExerciseName.Name = "colExerciseName";
            this.colExerciseName.ReadOnly = true;
            this.colExerciseName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colExerciseName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colWorkoutDay
            // 
            this.colWorkoutDay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colWorkoutDay.DataPropertyName = "WorkoutDay";
            this.colWorkoutDay.HeaderText = "Workout Day ";
            this.colWorkoutDay.Name = "colWorkoutDay";
            this.colWorkoutDay.ReadOnly = true;
            this.colWorkoutDay.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colDelete
            // 
            this.colDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDelete.DefaultCellStyle = dataGridViewCellStyle11;
            this.colDelete.FillWeight = 239.2593F;
            this.colDelete.HeaderText = "Delete";
            this.colDelete.Name = "colDelete";
            this.colDelete.ReadOnly = true;
            this.colDelete.Width = 70;
            // 
            // colWorkoutScheduleId
            // 
            this.colWorkoutScheduleId.HeaderText = "WorkoutSchedule Id";
            this.colWorkoutScheduleId.Name = "colWorkoutScheduleId";
            this.colWorkoutScheduleId.ReadOnly = true;
            this.colWorkoutScheduleId.Visible = false;
            // 
            // tlpAllWorkoutSheduleFromBack
            // 
            this.tlpAllWorkoutSheduleFromBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tlpAllWorkoutSheduleFromBack.ColumnCount = 3;
            this.tlpAllWorkoutSheduleFromBack.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpAllWorkoutSheduleFromBack.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlpAllWorkoutSheduleFromBack.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpAllWorkoutSheduleFromBack.Controls.Add(this.tlpAllWorkoutSheduleEntireForm, 1, 1);
            this.tlpAllWorkoutSheduleFromBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAllWorkoutSheduleFromBack.Location = new System.Drawing.Point(0, 0);
            this.tlpAllWorkoutSheduleFromBack.Margin = new System.Windows.Forms.Padding(2);
            this.tlpAllWorkoutSheduleFromBack.Name = "tlpAllWorkoutSheduleFromBack";
            this.tlpAllWorkoutSheduleFromBack.RowCount = 3;
            this.tlpAllWorkoutSheduleFromBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.553299F));
            this.tlpAllWorkoutSheduleFromBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.92386F));
            this.tlpAllWorkoutSheduleFromBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.399464F));
            this.tlpAllWorkoutSheduleFromBack.Size = new System.Drawing.Size(862, 609);
            this.tlpAllWorkoutSheduleFromBack.TabIndex = 0;
            this.tlpAllWorkoutSheduleFromBack.Click += new System.EventHandler(this.tlpWorkoutSheduleHeader_Click);
            // 
            // FrmDisplayWorkoutSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 609);
            this.Controls.Add(this.tlpAllWorkoutSheduleFromBack);
            this.Name = "FrmDisplayWorkoutSchedule";
            this.Text = "FrmDisplayWorkoutSchedule";
            this.Load += new System.EventHandler(this.FrmDisplayWorkoutSchedule_Load);
            this.tlpAllWorkoutSheduleEntireForm.ResumeLayout(false);
            this.tlpWorkoutSheduleHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picWorkoutShedule)).EndInit();
            this.tlpAllWorkoutSheduleTitle.ResumeLayout(false);
            this.tlpAllWorkoutSheduleTitle.PerformLayout();
            this.tlpWorkoutSheduleTableAndSearch.ResumeLayout(false);
            this.tlpSearchAndAddWorkoutShedule.ResumeLayout(false);
            this.tlpSearchWorkoutSchedule.ResumeLayout(false);
            this.tlpSearchWorkoutSchedule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearchWorkoutShedule)).EndInit();
            this.pnlClickToAddNewWorkoutShedule.ResumeLayout(false);
            this.tlpAddNewWorkoutSchedule.ResumeLayout(false);
            this.tlpAddNewWorkoutSchedule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlusWorkoutShedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkoutShedule)).EndInit();
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
        private System.Windows.Forms.Button btnWorkoutSheduleDisplayAll;
        private System.Windows.Forms.PictureBox picSearchWorkoutShedule;
        private System.Windows.Forms.ComboBox cmbWorkoutDaySearch;
        private System.Windows.Forms.Panel pnlClickToAddNewWorkoutShedule;
        private System.Windows.Forms.TableLayoutPanel tlpAddNewWorkoutSchedule;
        private System.Windows.Forms.PictureBox picPlusWorkoutShedule;
        private System.Windows.Forms.Label lblAddNewWorkoutShedule;
        private System.Windows.Forms.DataGridView dgvWorkoutShedule;
        private System.Windows.Forms.TableLayoutPanel tlpAllWorkoutSheduleFromBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSerialNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWorkoutName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExerciseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWorkoutDay;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWorkoutScheduleId;


    }
}