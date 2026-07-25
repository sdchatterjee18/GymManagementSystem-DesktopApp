namespace GymManagementSystem.FORMS.Member
{
    partial class FrmDisplayAllMembers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDisplayAllMembers));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpMainDisplayMembers = new System.Windows.Forms.TableLayoutPanel();
            this.dgvDisplayMemberInformation = new System.Windows.Forms.DataGridView();
            this.tlpTopTitleAndMemberIconPanal = new System.Windows.Forms.TableLayoutPanel();
            this.tlpTopTitleAndSubTitleAndIconInDisplayMember = new System.Windows.Forms.TableLayoutPanel();
            this.lblSubtitleDisplayAllMember = new System.Windows.Forms.Label();
            this.lblTitleDisplayAllMember = new System.Windows.Forms.Label();
            this.pnlSearchMember = new System.Windows.Forms.Panel();
            this.picSearchMember = new System.Windows.Forms.PictureBox();
            this.picDisplayMemberIcon = new System.Windows.Forms.PictureBox();
            this.txtSearchMember = new System.Windows.Forms.TextBox();
            this.colSlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMemberName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMemberProfile = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDeactivate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tlpMainDisplayMembers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayMemberInformation)).BeginInit();
            this.tlpTopTitleAndMemberIconPanal.SuspendLayout();
            this.tlpTopTitleAndSubTitleAndIconInDisplayMember.SuspendLayout();
            this.pnlSearchMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearchMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplayMemberIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMainDisplayMembers
            // 
            this.tlpMainDisplayMembers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tlpMainDisplayMembers.ColumnCount = 3;
            this.tlpMainDisplayMembers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpMainDisplayMembers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlpMainDisplayMembers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpMainDisplayMembers.Controls.Add(this.dgvDisplayMemberInformation, 1, 1);
            this.tlpMainDisplayMembers.Controls.Add(this.tlpTopTitleAndMemberIconPanal, 1, 0);
            this.tlpMainDisplayMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMainDisplayMembers.Location = new System.Drawing.Point(0, 0);
            this.tlpMainDisplayMembers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpMainDisplayMembers.Name = "tlpMainDisplayMembers";
            this.tlpMainDisplayMembers.RowCount = 3;
            this.tlpMainDisplayMembers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.22843F));
            this.tlpMainDisplayMembers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.56853F));
            this.tlpMainDisplayMembers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.117772F));
            this.tlpMainDisplayMembers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMainDisplayMembers.Size = new System.Drawing.Size(1149, 788);
            this.tlpMainDisplayMembers.TabIndex = 4;
            this.tlpMainDisplayMembers.Click += new System.EventHandler(this.tlpMainDisplayMembers_Click);
            // 
            // dgvDisplayMemberInformation
            // 
            this.dgvDisplayMemberInformation.AllowUserToAddRows = false;
            this.dgvDisplayMemberInformation.AllowUserToDeleteRows = false;
            this.dgvDisplayMemberInformation.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.dgvDisplayMemberInformation.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDisplayMemberInformation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDisplayMemberInformation.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvDisplayMemberInformation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDisplayMemberInformation.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDisplayMemberInformation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDisplayMemberInformation.ColumnHeadersHeight = 50;
            this.dgvDisplayMemberInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDisplayMemberInformation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSlNo,
            this.colMemberName,
            this.colPhoneNo,
            this.colIsActive,
            this.colMemberProfile,
            this.colUpdate,
            this.colDeactivate});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDisplayMemberInformation.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDisplayMemberInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDisplayMemberInformation.EnableHeadersVisualStyles = false;
            this.dgvDisplayMemberInformation.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvDisplayMemberInformation.Location = new System.Drawing.Point(61, 124);
            this.dgvDisplayMemberInformation.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDisplayMemberInformation.MultiSelect = false;
            this.dgvDisplayMemberInformation.Name = "dgvDisplayMemberInformation";
            this.dgvDisplayMemberInformation.ReadOnly = true;
            this.dgvDisplayMemberInformation.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDisplayMemberInformation.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDisplayMemberInformation.RowHeadersVisible = false;
            this.dgvDisplayMemberInformation.RowHeadersWidth = 50;
            this.dgvDisplayMemberInformation.RowTemplate.Height = 40;
            this.dgvDisplayMemberInformation.RowTemplate.ReadOnly = true;
            this.dgvDisplayMemberInformation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvDisplayMemberInformation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDisplayMemberInformation.Size = new System.Drawing.Size(1026, 619);
            this.dgvDisplayMemberInformation.TabIndex = 1;
            this.dgvDisplayMemberInformation.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDisplayMemberInformation_CellFormatting);
            this.dgvDisplayMemberInformation.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisplayMemberInformation_CellMouseEnter);
            this.dgvDisplayMemberInformation.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisplayMemberInformation_CellMouseLeave);
            this.dgvDisplayMemberInformation.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvDisplayMemberInformation_CellPainting);
            // 
            // tlpTopTitleAndMemberIconPanal
            // 
            this.tlpTopTitleAndMemberIconPanal.ColumnCount = 4;
            this.tlpTopTitleAndMemberIconPanal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tlpTopTitleAndMemberIconPanal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.95519F));
            this.tlpTopTitleAndMemberIconPanal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.04481F));
            this.tlpTopTitleAndMemberIconPanal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tlpTopTitleAndMemberIconPanal.Controls.Add(this.tlpTopTitleAndSubTitleAndIconInDisplayMember, 1, 0);
            this.tlpTopTitleAndMemberIconPanal.Controls.Add(this.pnlSearchMember, 3, 0);
            this.tlpTopTitleAndMemberIconPanal.Controls.Add(this.picDisplayMemberIcon, 0, 0);
            this.tlpTopTitleAndMemberIconPanal.Controls.Add(this.txtSearchMember, 2, 0);
            this.tlpTopTitleAndMemberIconPanal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTopTitleAndMemberIconPanal.Location = new System.Drawing.Point(60, 2);
            this.tlpTopTitleAndMemberIconPanal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpTopTitleAndMemberIconPanal.Name = "tlpTopTitleAndMemberIconPanal";
            this.tlpTopTitleAndMemberIconPanal.RowCount = 1;
            this.tlpTopTitleAndMemberIconPanal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTopTitleAndMemberIconPanal.Size = new System.Drawing.Size(1028, 116);
            this.tlpTopTitleAndMemberIconPanal.TabIndex = 2;
            this.tlpTopTitleAndMemberIconPanal.Click += new System.EventHandler(this.tlpTopTitleAndMemberIconPanal_Click);
            // 
            // tlpTopTitleAndSubTitleAndIconInDisplayMember
            // 
            this.tlpTopTitleAndSubTitleAndIconInDisplayMember.ColumnCount = 1;
            this.tlpTopTitleAndSubTitleAndIconInDisplayMember.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTopTitleAndSubTitleAndIconInDisplayMember.Controls.Add(this.lblSubtitleDisplayAllMember, 0, 1);
            this.tlpTopTitleAndSubTitleAndIconInDisplayMember.Controls.Add(this.lblTitleDisplayAllMember, 0, 0);
            this.tlpTopTitleAndSubTitleAndIconInDisplayMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTopTitleAndSubTitleAndIconInDisplayMember.Location = new System.Drawing.Point(72, 2);
            this.tlpTopTitleAndSubTitleAndIconInDisplayMember.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpTopTitleAndSubTitleAndIconInDisplayMember.Name = "tlpTopTitleAndSubTitleAndIconInDisplayMember";
            this.tlpTopTitleAndSubTitleAndIconInDisplayMember.RowCount = 3;
            this.tlpTopTitleAndSubTitleAndIconInDisplayMember.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.29678F));
            this.tlpTopTitleAndSubTitleAndIconInDisplayMember.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.8018F));
            this.tlpTopTitleAndSubTitleAndIconInDisplayMember.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.901412F));
            this.tlpTopTitleAndSubTitleAndIconInDisplayMember.Size = new System.Drawing.Size(276, 112);
            this.tlpTopTitleAndSubTitleAndIconInDisplayMember.TabIndex = 3;
            this.tlpTopTitleAndSubTitleAndIconInDisplayMember.Click += new System.EventHandler(this.tlpTopTitleAndSubTitleAndIconInDisplayMember_Click);
            // 
            // lblSubtitleDisplayAllMember
            // 
            this.lblSubtitleDisplayAllMember.AutoSize = true;
            this.lblSubtitleDisplayAllMember.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitleDisplayAllMember.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblSubtitleDisplayAllMember.Location = new System.Drawing.Point(3, 61);
            this.lblSubtitleDisplayAllMember.Name = "lblSubtitleDisplayAllMember";
            this.lblSubtitleDisplayAllMember.Size = new System.Drawing.Size(215, 19);
            this.lblSubtitleDisplayAllMember.TabIndex = 1;
            this.lblSubtitleDisplayAllMember.Text = "Everything About GYM Members";
            this.lblSubtitleDisplayAllMember.Click += new System.EventHandler(this.lblSubtitleDisplayAllMember_Click);
            // 
            // lblTitleDisplayAllMember
            // 
            this.lblTitleDisplayAllMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTitleDisplayAllMember.AutoSize = true;
            this.lblTitleDisplayAllMember.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleDisplayAllMember.Location = new System.Drawing.Point(3, 33);
            this.lblTitleDisplayAllMember.Name = "lblTitleDisplayAllMember";
            this.lblTitleDisplayAllMember.Size = new System.Drawing.Size(245, 28);
            this.lblTitleDisplayAllMember.TabIndex = 0;
            this.lblTitleDisplayAllMember.Text = "All Members Of Our GYM";
            this.lblTitleDisplayAllMember.Click += new System.EventHandler(this.lblTitleDisplayAllMember_Click);
            // 
            // pnlSearchMember
            // 
            this.pnlSearchMember.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pnlSearchMember.Controls.Add(this.picSearchMember);
            this.pnlSearchMember.Location = new System.Drawing.Point(985, 38);
            this.pnlSearchMember.Name = "pnlSearchMember";
            this.pnlSearchMember.Size = new System.Drawing.Size(40, 40);
            this.pnlSearchMember.TabIndex = 3;
            // 
            // picSearchMember
            // 
            this.picSearchMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picSearchMember.Image = ((System.Drawing.Image)(resources.GetObject("picSearchMember.Image")));
            this.picSearchMember.Location = new System.Drawing.Point(0, 0);
            this.picSearchMember.Name = "picSearchMember";
            this.picSearchMember.Size = new System.Drawing.Size(40, 40);
            this.picSearchMember.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSearchMember.TabIndex = 0;
            this.picSearchMember.TabStop = false;
            this.picSearchMember.Click += new System.EventHandler(this.picSearchMember_Click);
            // 
            // picDisplayMemberIcon
            // 
            this.picDisplayMemberIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picDisplayMemberIcon.Image = ((System.Drawing.Image)(resources.GetObject("picDisplayMemberIcon.Image")));
            this.picDisplayMemberIcon.Location = new System.Drawing.Point(3, 2);
            this.picDisplayMemberIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picDisplayMemberIcon.Name = "picDisplayMemberIcon";
            this.picDisplayMemberIcon.Size = new System.Drawing.Size(63, 112);
            this.picDisplayMemberIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDisplayMemberIcon.TabIndex = 4;
            this.picDisplayMemberIcon.TabStop = false;
            this.picDisplayMemberIcon.Click += new System.EventHandler(this.picDisplayMemberIcon_Click);
            // 
            // txtSearchMember
            // 
            this.txtSearchMember.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtSearchMember.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchMember.ForeColor = System.Drawing.Color.Gray;
            this.txtSearchMember.Location = new System.Drawing.Point(654, 43);
            this.txtSearchMember.Name = "txtSearchMember";
            this.txtSearchMember.Size = new System.Drawing.Size(324, 30);
            this.txtSearchMember.TabIndex = 5;
            this.txtSearchMember.Text = "Enter Mobile No.";
            this.txtSearchMember.Click += new System.EventHandler(this.txtSearchMember_Click);
            // 
            // colSlNo
            // 
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.MediumBlue;
            this.colSlNo.DefaultCellStyle = dataGridViewCellStyle3;
            this.colSlNo.FillWeight = 50F;
            this.colSlNo.HeaderText = "SL No";
            this.colSlNo.Name = "colSlNo";
            this.colSlNo.ReadOnly = true;
            this.colSlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colMemberName
            // 
            this.colMemberName.DataPropertyName = "MemberName";
            this.colMemberName.FillWeight = 80.83756F;
            this.colMemberName.HeaderText = "MemberName";
            this.colMemberName.Name = "colMemberName";
            this.colMemberName.ReadOnly = true;
            this.colMemberName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colPhoneNo
            // 
            this.colPhoneNo.DataPropertyName = "PhoneNo";
            this.colPhoneNo.FillWeight = 80.83756F;
            this.colPhoneNo.HeaderText = "Contact No";
            this.colPhoneNo.Name = "colPhoneNo";
            this.colPhoneNo.ReadOnly = true;
            this.colPhoneNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colIsActive
            // 
            this.colIsActive.DataPropertyName = "MemberIsActive";
            this.colIsActive.HeaderText = "Status";
            this.colIsActive.Name = "colIsActive";
            this.colIsActive.ReadOnly = true;
            // 
            // colMemberProfile
            // 
            this.colMemberProfile.HeaderText = "MemberProfile";
            this.colMemberProfile.Name = "colMemberProfile";
            this.colMemberProfile.ReadOnly = true;
            this.colMemberProfile.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMemberProfile.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colMemberProfile.Text = "🙎‍♂️Profile";
            this.colMemberProfile.UseColumnTextForButtonValue = true;
            // 
            // colUpdate
            // 
            this.colUpdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colUpdate.DataPropertyName = "Update";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Fuchsia;
            this.colUpdate.DefaultCellStyle = dataGridViewCellStyle4;
            this.colUpdate.HeaderText = "Action";
            this.colUpdate.Name = "colUpdate";
            this.colUpdate.ReadOnly = true;
            this.colUpdate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colUpdate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colUpdate.Text = "✏️Update";
            this.colUpdate.UseColumnTextForButtonValue = true;
            // 
            // colDeactivate
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colDeactivate.DefaultCellStyle = dataGridViewCellStyle5;
            this.colDeactivate.HeaderText = "Action";
            this.colDeactivate.Name = "colDeactivate";
            this.colDeactivate.ReadOnly = true;
            this.colDeactivate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDeactivate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colDeactivate.Text = "Deactivate";
            this.colDeactivate.UseColumnTextForButtonValue = true;
            // 
            // FrmDisplayAllMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 788);
            this.Controls.Add(this.tlpMainDisplayMembers);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDisplayAllMembers";
            this.Text = "FrmDisplayAllMembers";
            this.Load += new System.EventHandler(this.FrmDisplayAllMembers_Load);
            this.tlpMainDisplayMembers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayMemberInformation)).EndInit();
            this.tlpTopTitleAndMemberIconPanal.ResumeLayout(false);
            this.tlpTopTitleAndMemberIconPanal.PerformLayout();
            this.tlpTopTitleAndSubTitleAndIconInDisplayMember.ResumeLayout(false);
            this.tlpTopTitleAndSubTitleAndIconInDisplayMember.PerformLayout();
            this.pnlSearchMember.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSearchMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplayMemberIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMainDisplayMembers;
        private System.Windows.Forms.DataGridView dgvDisplayMemberInformation;
        private System.Windows.Forms.TableLayoutPanel tlpTopTitleAndMemberIconPanal;
        private System.Windows.Forms.TableLayoutPanel tlpTopTitleAndSubTitleAndIconInDisplayMember;
        private System.Windows.Forms.Label lblSubtitleDisplayAllMember;
        private System.Windows.Forms.Label lblTitleDisplayAllMember;
        private System.Windows.Forms.PictureBox picDisplayMemberIcon;
        private System.Windows.Forms.Panel pnlSearchMember;
        private System.Windows.Forms.TextBox txtSearchMember;
        private System.Windows.Forms.PictureBox picSearchMember;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemberName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhoneNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsActive;
        private System.Windows.Forms.DataGridViewButtonColumn colMemberProfile;
        private System.Windows.Forms.DataGridViewButtonColumn colUpdate;
        private System.Windows.Forms.DataGridViewButtonColumn colDeactivate;
    }
}