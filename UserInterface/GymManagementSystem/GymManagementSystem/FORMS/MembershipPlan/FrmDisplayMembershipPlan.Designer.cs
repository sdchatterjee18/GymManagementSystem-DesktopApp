namespace GymManagementSystem.FORMS.MembershipPlan
{
    partial class FrmDisplayMembershipPlan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDisplayMembershipPlan));
            this.tlpMembershipPlanEntireForm = new System.Windows.Forms.TableLayoutPanel();
            this.pnlMembershipPlanGridview = new System.Windows.Forms.TableLayoutPanel();
            this.dgvMembershipPlan = new System.Windows.Forms.DataGridView();
            this.SerialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MembershipPlanName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlanType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DurationInDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Deactivate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlClickAddNewMembershipPlan = new System.Windows.Forms.Panel();
            this.tlpAddNewMembarshipPlan = new System.Windows.Forms.TableLayoutPanel();
            this.lblAddNewMembershipPlan = new System.Windows.Forms.Label();
            this.picAddButtonMembershipPlan = new System.Windows.Forms.PictureBox();
            this.tlpAllMembershipPlanTitle = new System.Windows.Forms.TableLayoutPanel();
            this.lblAllMembershipPlan = new System.Windows.Forms.Label();
            this.tlpMembershipPlanSearch = new System.Windows.Forms.TableLayoutPanel();
            this.tlpSearchPlan = new System.Windows.Forms.TableLayoutPanel();
            this.txtMembershipPlanSearchBox = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tlpMembershipPlanEntireForm.SuspendLayout();
            this.pnlMembershipPlanGridview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembershipPlan)).BeginInit();
            this.pnlClickAddNewMembershipPlan.SuspendLayout();
            this.tlpAddNewMembarshipPlan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddButtonMembershipPlan)).BeginInit();
            this.tlpAllMembershipPlanTitle.SuspendLayout();
            this.tlpMembershipPlanSearch.SuspendLayout();
            this.tlpSearchPlan.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMembershipPlanEntireForm
            // 
            this.tlpMembershipPlanEntireForm.ColumnCount = 1;
            this.tlpMembershipPlanEntireForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMembershipPlanEntireForm.Controls.Add(this.pnlMembershipPlanGridview, 0, 2);
            this.tlpMembershipPlanEntireForm.Controls.Add(this.tlpAllMembershipPlanTitle, 0, 0);
            this.tlpMembershipPlanEntireForm.Controls.Add(this.tlpMembershipPlanSearch, 0, 1);
            this.tlpMembershipPlanEntireForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMembershipPlanEntireForm.Location = new System.Drawing.Point(0, 0);
            this.tlpMembershipPlanEntireForm.Margin = new System.Windows.Forms.Padding(2);
            this.tlpMembershipPlanEntireForm.Name = "tlpMembershipPlanEntireForm";
            this.tlpMembershipPlanEntireForm.RowCount = 3;
            this.tlpMembershipPlanEntireForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.573812F));
            this.tlpMembershipPlanEntireForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.188704F));
            this.tlpMembershipPlanEntireForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.03272F));
            this.tlpMembershipPlanEntireForm.Size = new System.Drawing.Size(936, 609);
            this.tlpMembershipPlanEntireForm.TabIndex = 0;
            this.tlpMembershipPlanEntireForm.Click += new System.EventHandler(this.tlpMembershipPlanEntireForm_Click);
            // 
            // pnlMembershipPlanGridview
            // 
            this.pnlMembershipPlanGridview.ColumnCount = 3;
            this.pnlMembershipPlanGridview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.pnlMembershipPlanGridview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.pnlMembershipPlanGridview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.pnlMembershipPlanGridview.Controls.Add(this.dgvMembershipPlan, 1, 0);
            this.pnlMembershipPlanGridview.Controls.Add(this.pnlClickAddNewMembershipPlan, 1, 1);
            this.pnlMembershipPlanGridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMembershipPlanGridview.Location = new System.Drawing.Point(2, 91);
            this.pnlMembershipPlanGridview.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMembershipPlanGridview.Name = "pnlMembershipPlanGridview";
            this.pnlMembershipPlanGridview.RowCount = 2;
            this.pnlMembershipPlanGridview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.56165F));
            this.pnlMembershipPlanGridview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.43836F));
            this.pnlMembershipPlanGridview.Size = new System.Drawing.Size(932, 516);
            this.pnlMembershipPlanGridview.TabIndex = 5;
            this.pnlMembershipPlanGridview.Click += new System.EventHandler(this.pnlMembershipPlanGridview_Click);
            // 
            // dgvMembershipPlan
            // 
            this.dgvMembershipPlan.AllowUserToAddRows = false;
            this.dgvMembershipPlan.AllowUserToDeleteRows = false;
            this.dgvMembershipPlan.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvMembershipPlan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMembershipPlan.BackgroundColor = System.Drawing.Color.White;
            this.dgvMembershipPlan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMembershipPlan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Variable Display", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMembershipPlan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMembershipPlan.ColumnHeadersHeight = 50;
            this.dgvMembershipPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMembershipPlan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SerialNo,
            this.MembershipPlanName,
            this.PlanType,
            this.DurationInDays,
            this.Price,
            this.Description,
            this.IsActive,
            this.Update,
            this.Deactivate});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMembershipPlan.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMembershipPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMembershipPlan.GridColor = System.Drawing.Color.Black;
            this.dgvMembershipPlan.Location = new System.Drawing.Point(48, 2);
            this.dgvMembershipPlan.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMembershipPlan.MultiSelect = false;
            this.dgvMembershipPlan.Name = "dgvMembershipPlan";
            this.dgvMembershipPlan.ReadOnly = true;
            this.dgvMembershipPlan.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMembershipPlan.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMembershipPlan.RowHeadersVisible = false;
            this.dgvMembershipPlan.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvMembershipPlan.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMembershipPlan.RowTemplate.Height = 24;
            this.dgvMembershipPlan.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMembershipPlan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvMembershipPlan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvMembershipPlan.Size = new System.Drawing.Size(834, 427);
            this.dgvMembershipPlan.TabIndex = 0;
            this.dgvMembershipPlan.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMembershipPlan_CellMouseEnter);
            this.dgvMembershipPlan.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMembershipPlan_CellMouseLeave);
            // 
            // SerialNo
            // 
            this.SerialNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SerialNo.FillWeight = 90F;
            this.SerialNo.HeaderText = "Sl No.";
            this.SerialNo.Name = "SerialNo";
            this.SerialNo.ReadOnly = true;
            this.SerialNo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SerialNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // MembershipPlanName
            // 
            this.MembershipPlanName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MembershipPlanName.FillWeight = 180F;
            this.MembershipPlanName.HeaderText = "Membership Plan Name";
            this.MembershipPlanName.Name = "MembershipPlanName";
            this.MembershipPlanName.ReadOnly = true;
            this.MembershipPlanName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MembershipPlanName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PlanType
            // 
            this.PlanType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PlanType.HeaderText = "Plan Type ";
            this.PlanType.Name = "PlanType";
            this.PlanType.ReadOnly = true;
            this.PlanType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PlanType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DurationInDays
            // 
            this.DurationInDays.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DurationInDays.FillWeight = 130F;
            this.DurationInDays.HeaderText = "Duration In Days";
            this.DurationInDays.Name = "DurationInDays";
            this.DurationInDays.ReadOnly = true;
            this.DurationInDays.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DurationInDays.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price.HeaderText = "Amount";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // IsActive
            // 
            this.IsActive.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IsActive.HeaderText = "Status";
            this.IsActive.Name = "IsActive";
            this.IsActive.ReadOnly = true;
            this.IsActive.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsActive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Update
            // 
            this.Update.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Update.HeaderText = "Update";
            this.Update.Name = "Update";
            this.Update.ReadOnly = true;
            this.Update.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Update.Text = "✏️Update";
            this.Update.UseColumnTextForButtonValue = true;
            // 
            // Deactivate
            // 
            this.Deactivate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Deactivate.HeaderText = "Deactivate";
            this.Deactivate.Name = "Deactivate";
            this.Deactivate.ReadOnly = true;
            this.Deactivate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Deactivate.Text = "✂️";
            this.Deactivate.UseColumnTextForButtonValue = true;
            // 
            // pnlClickAddNewMembershipPlan
            // 
            this.pnlClickAddNewMembershipPlan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnlClickAddNewMembershipPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(195)))), ((int)(((byte)(179)))));
            this.pnlClickAddNewMembershipPlan.Controls.Add(this.tlpAddNewMembarshipPlan);
            this.pnlClickAddNewMembershipPlan.Location = new System.Drawing.Point(48, 444);
            this.pnlClickAddNewMembershipPlan.Margin = new System.Windows.Forms.Padding(2);
            this.pnlClickAddNewMembershipPlan.Name = "pnlClickAddNewMembershipPlan";
            this.pnlClickAddNewMembershipPlan.Size = new System.Drawing.Size(311, 58);
            this.pnlClickAddNewMembershipPlan.TabIndex = 1;
            this.pnlClickAddNewMembershipPlan.Click += new System.EventHandler(this.pnlClickAddNewMembershipPlan_Click);
            // 
            // tlpAddNewMembarshipPlan
            // 
            this.tlpAddNewMembarshipPlan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tlpAddNewMembarshipPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(195)))), ((int)(((byte)(179)))));
            this.tlpAddNewMembarshipPlan.ColumnCount = 2;
            this.tlpAddNewMembarshipPlan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.38554F));
            this.tlpAddNewMembarshipPlan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.61446F));
            this.tlpAddNewMembarshipPlan.Controls.Add(this.lblAddNewMembershipPlan, 1, 0);
            this.tlpAddNewMembarshipPlan.Controls.Add(this.picAddButtonMembershipPlan, 0, 0);
            this.tlpAddNewMembarshipPlan.Location = new System.Drawing.Point(1, 1);
            this.tlpAddNewMembarshipPlan.Margin = new System.Windows.Forms.Padding(2);
            this.tlpAddNewMembarshipPlan.Name = "tlpAddNewMembarshipPlan";
            this.tlpAddNewMembarshipPlan.RowCount = 1;
            this.tlpAddNewMembarshipPlan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAddNewMembarshipPlan.Size = new System.Drawing.Size(310, 58);
            this.tlpAddNewMembarshipPlan.TabIndex = 0;
            this.tlpAddNewMembarshipPlan.Click += new System.EventHandler(this.pnlAddNewMembarshipPlan_Click);
            // 
            // lblAddNewMembershipPlan
            // 
            this.lblAddNewMembershipPlan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAddNewMembershipPlan.AutoSize = true;
            this.lblAddNewMembershipPlan.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewMembershipPlan.Location = new System.Drawing.Point(52, 16);
            this.lblAddNewMembershipPlan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddNewMembershipPlan.Name = "lblAddNewMembershipPlan";
            this.lblAddNewMembershipPlan.Size = new System.Drawing.Size(246, 25);
            this.lblAddNewMembershipPlan.TabIndex = 1;
            this.lblAddNewMembershipPlan.Text = "Add New Membership Plan";
            this.lblAddNewMembershipPlan.Click += new System.EventHandler(this.pnlClickAddNewMembershipPlan_Click);
            // 
            // picAddButtonMembershipPlan
            // 
            this.picAddButtonMembershipPlan.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.picAddButtonMembershipPlan.Image = ((System.Drawing.Image)(resources.GetObject("picAddButtonMembershipPlan.Image")));
            this.picAddButtonMembershipPlan.Location = new System.Drawing.Point(11, 14);
            this.picAddButtonMembershipPlan.Margin = new System.Windows.Forms.Padding(2);
            this.picAddButtonMembershipPlan.Name = "picAddButtonMembershipPlan";
            this.picAddButtonMembershipPlan.Size = new System.Drawing.Size(37, 30);
            this.picAddButtonMembershipPlan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAddButtonMembershipPlan.TabIndex = 2;
            this.picAddButtonMembershipPlan.TabStop = false;
            this.picAddButtonMembershipPlan.Click += new System.EventHandler(this.pnlClickAddNewMembershipPlan_Click);
            // 
            // tlpAllMembershipPlanTitle
            // 
            this.tlpAllMembershipPlanTitle.ColumnCount = 2;
            this.tlpAllMembershipPlanTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.991949F));
            this.tlpAllMembershipPlanTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95.00805F));
            this.tlpAllMembershipPlanTitle.Controls.Add(this.lblAllMembershipPlan, 1, 0);
            this.tlpAllMembershipPlanTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAllMembershipPlanTitle.Location = new System.Drawing.Point(2, 2);
            this.tlpAllMembershipPlanTitle.Margin = new System.Windows.Forms.Padding(2);
            this.tlpAllMembershipPlanTitle.Name = "tlpAllMembershipPlanTitle";
            this.tlpAllMembershipPlanTitle.RowCount = 1;
            this.tlpAllMembershipPlanTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAllMembershipPlanTitle.Size = new System.Drawing.Size(932, 42);
            this.tlpAllMembershipPlanTitle.TabIndex = 6;
            this.tlpAllMembershipPlanTitle.Click += new System.EventHandler(this.tlpAllMembershipPlanTitle_Click);
            // 
            // lblAllMembershipPlan
            // 
            this.lblAllMembershipPlan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAllMembershipPlan.AutoSize = true;
            this.lblAllMembershipPlan.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllMembershipPlan.Location = new System.Drawing.Point(48, 6);
            this.lblAllMembershipPlan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAllMembershipPlan.Name = "lblAllMembershipPlan";
            this.lblAllMembershipPlan.Size = new System.Drawing.Size(220, 30);
            this.lblAllMembershipPlan.TabIndex = 2;
            this.lblAllMembershipPlan.Text = "All Membership Plan";
            // 
            // tlpMembershipPlanSearch
            // 
            this.tlpMembershipPlanSearch.ColumnCount = 2;
            this.tlpMembershipPlanSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.48792F));
            this.tlpMembershipPlanSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.51208F));
            this.tlpMembershipPlanSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tlpMembershipPlanSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tlpMembershipPlanSearch.Controls.Add(this.tlpSearchPlan, 0, 0);
            this.tlpMembershipPlanSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMembershipPlanSearch.Location = new System.Drawing.Point(2, 48);
            this.tlpMembershipPlanSearch.Margin = new System.Windows.Forms.Padding(2);
            this.tlpMembershipPlanSearch.Name = "tlpMembershipPlanSearch";
            this.tlpMembershipPlanSearch.RowCount = 1;
            this.tlpMembershipPlanSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMembershipPlanSearch.Size = new System.Drawing.Size(932, 39);
            this.tlpMembershipPlanSearch.TabIndex = 7;
            this.tlpMembershipPlanSearch.Click += new System.EventHandler(this.tlpMembershipPlanSearch_Click);
            // 
            // tlpSearchPlan
            // 
            this.tlpSearchPlan.ColumnCount = 3;
            this.tlpSearchPlan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.628006F));
            this.tlpSearchPlan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.81329F));
            this.tlpSearchPlan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.48481F));
            this.tlpSearchPlan.Controls.Add(this.txtMembershipPlanSearchBox, 1, 0);
            this.tlpSearchPlan.Controls.Add(this.btnSearch, 2, 0);
            this.tlpSearchPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSearchPlan.Location = new System.Drawing.Point(2, 2);
            this.tlpSearchPlan.Margin = new System.Windows.Forms.Padding(2);
            this.tlpSearchPlan.Name = "tlpSearchPlan";
            this.tlpSearchPlan.RowCount = 1;
            this.tlpSearchPlan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSearchPlan.Size = new System.Drawing.Size(531, 35);
            this.tlpSearchPlan.TabIndex = 3;
            // 
            // txtMembershipPlanSearchBox
            // 
            this.txtMembershipPlanSearchBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMembershipPlanSearchBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMembershipPlanSearchBox.Location = new System.Drawing.Point(47, 2);
            this.txtMembershipPlanSearchBox.Margin = new System.Windows.Forms.Padding(2);
            this.txtMembershipPlanSearchBox.Name = "txtMembershipPlanSearchBox";
            this.txtMembershipPlanSearchBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMembershipPlanSearchBox.Size = new System.Drawing.Size(398, 29);
            this.txtMembershipPlanSearchBox.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(449, 2);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 29);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // FrmDisplayMembershipPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 609);
            this.Controls.Add(this.tlpMembershipPlanEntireForm);
            this.Name = "FrmDisplayMembershipPlan";
            this.Text = "FrmDisplayMembershipPlan";
            this.Load += new System.EventHandler(this.FrmDisplayMembershipPlan_Load);
            this.Click += new System.EventHandler(this.FrmDisplayMembershipPlan_Click);
            this.tlpMembershipPlanEntireForm.ResumeLayout(false);
            this.pnlMembershipPlanGridview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembershipPlan)).EndInit();
            this.pnlClickAddNewMembershipPlan.ResumeLayout(false);
            this.tlpAddNewMembarshipPlan.ResumeLayout(false);
            this.tlpAddNewMembarshipPlan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddButtonMembershipPlan)).EndInit();
            this.tlpAllMembershipPlanTitle.ResumeLayout(false);
            this.tlpAllMembershipPlanTitle.PerformLayout();
            this.tlpMembershipPlanSearch.ResumeLayout(false);
            this.tlpSearchPlan.ResumeLayout(false);
            this.tlpSearchPlan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMembershipPlanEntireForm;
        private System.Windows.Forms.TableLayoutPanel pnlMembershipPlanGridview;
        private System.Windows.Forms.DataGridView dgvMembershipPlan;
        private System.Windows.Forms.Panel pnlClickAddNewMembershipPlan;
        private System.Windows.Forms.TableLayoutPanel tlpAddNewMembarshipPlan;
        private System.Windows.Forms.Label lblAddNewMembershipPlan;
        private System.Windows.Forms.PictureBox picAddButtonMembershipPlan;
        private System.Windows.Forms.TableLayoutPanel tlpMembershipPlanSearch;
        private System.Windows.Forms.TableLayoutPanel tlpSearchPlan;
        private System.Windows.Forms.TextBox txtMembershipPlanSearchBox;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MembershipPlanName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlanType;
        private System.Windows.Forms.DataGridViewTextBoxColumn DurationInDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsActive;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.DataGridViewButtonColumn Deactivate;
        private System.Windows.Forms.TableLayoutPanel tlpAllMembershipPlanTitle;
        private System.Windows.Forms.Label lblAllMembershipPlan;


    }
}