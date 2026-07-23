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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDisplayWorkoutSchedule));
            this.tlpWorkoutScheduleEntireForm = new System.Windows.Forms.TableLayoutPanel();
            this.pnlAllWorkoutPlansTitle = new System.Windows.Forms.Panel();
            this.lblAllWorkoutScheduleTitle = new System.Windows.Forms.Label();
            this.tlpSearchWorkoutScheduleSub = new System.Windows.Forms.TableLayoutPanel();
            this.tlpSearchWorkoutScheduleMain = new System.Windows.Forms.TableLayoutPanel();
            this.btnSearchWorkoutDay = new System.Windows.Forms.Button();
            this.txrSearchWorkoutDay = new System.Windows.Forms.TextBox();
            this.lblWorkoutDay = new System.Windows.Forms.Label();
            this.dgvAllWorkoutPlans = new System.Windows.Forms.DataGridView();
            this.pnlClickAddNewWorkoutSchedule = new System.Windows.Forms.Panel();
            this.tlpAddNewWorkoutSchedule = new System.Windows.Forms.TableLayoutPanel();
            this.lbAddNewWorkoutSchedule = new System.Windows.Forms.Label();
            this.picAddNewWorkoutSchedule = new System.Windows.Forms.PictureBox();
            this.colSerialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWorkoutName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExerciseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWorkoutDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpWorkoutScheduleEntireForm.SuspendLayout();
            this.pnlAllWorkoutPlansTitle.SuspendLayout();
            this.tlpSearchWorkoutScheduleSub.SuspendLayout();
            this.tlpSearchWorkoutScheduleMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllWorkoutPlans)).BeginInit();
            this.pnlClickAddNewWorkoutSchedule.SuspendLayout();
            this.tlpAddNewWorkoutSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddNewWorkoutSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpWorkoutScheduleEntireForm
            // 
            this.tlpWorkoutScheduleEntireForm.ColumnCount = 3;
            this.tlpWorkoutScheduleEntireForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.761906F));
            this.tlpWorkoutScheduleEntireForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.47619F));
            this.tlpWorkoutScheduleEntireForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.761905F));
            this.tlpWorkoutScheduleEntireForm.Controls.Add(this.pnlAllWorkoutPlansTitle, 1, 0);
            this.tlpWorkoutScheduleEntireForm.Controls.Add(this.tlpSearchWorkoutScheduleSub, 1, 1);
            this.tlpWorkoutScheduleEntireForm.Controls.Add(this.dgvAllWorkoutPlans, 1, 2);
            this.tlpWorkoutScheduleEntireForm.Controls.Add(this.pnlClickAddNewWorkoutSchedule, 1, 3);
            this.tlpWorkoutScheduleEntireForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpWorkoutScheduleEntireForm.Location = new System.Drawing.Point(0, 0);
            this.tlpWorkoutScheduleEntireForm.Name = "tlpWorkoutScheduleEntireForm";
            this.tlpWorkoutScheduleEntireForm.RowCount = 5;
            this.tlpWorkoutScheduleEntireForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.52632F));
            this.tlpWorkoutScheduleEntireForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.52632F));
            this.tlpWorkoutScheduleEntireForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.89474F));
            this.tlpWorkoutScheduleEntireForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.52632F));
            this.tlpWorkoutScheduleEntireForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.52632F));
            this.tlpWorkoutScheduleEntireForm.Size = new System.Drawing.Size(1019, 696);
            this.tlpWorkoutScheduleEntireForm.TabIndex = 2;
            // 
            // pnlAllWorkoutPlansTitle
            // 
            this.pnlAllWorkoutPlansTitle.Controls.Add(this.lblAllWorkoutScheduleTitle);
            this.pnlAllWorkoutPlansTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAllWorkoutPlansTitle.Location = new System.Drawing.Point(51, 3);
            this.pnlAllWorkoutPlansTitle.Name = "pnlAllWorkoutPlansTitle";
            this.pnlAllWorkoutPlansTitle.Size = new System.Drawing.Size(915, 67);
            this.pnlAllWorkoutPlansTitle.TabIndex = 9;
            // 
            // lblAllWorkoutScheduleTitle
            // 
            this.lblAllWorkoutScheduleTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAllWorkoutScheduleTitle.AutoSize = true;
            this.lblAllWorkoutScheduleTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllWorkoutScheduleTitle.Location = new System.Drawing.Point(3, 20);
            this.lblAllWorkoutScheduleTitle.Name = "lblAllWorkoutScheduleTitle";
            this.lblAllWorkoutScheduleTitle.Size = new System.Drawing.Size(303, 38);
            this.lblAllWorkoutScheduleTitle.TabIndex = 0;
            this.lblAllWorkoutScheduleTitle.Text = "All Workout Schedules";
            // 
            // tlpSearchWorkoutScheduleSub
            // 
            this.tlpSearchWorkoutScheduleSub.ColumnCount = 2;
            this.tlpSearchWorkoutScheduleSub.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 610F));
            this.tlpSearchWorkoutScheduleSub.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSearchWorkoutScheduleSub.Controls.Add(this.tlpSearchWorkoutScheduleMain, 0, 0);
            this.tlpSearchWorkoutScheduleSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSearchWorkoutScheduleSub.Location = new System.Drawing.Point(51, 76);
            this.tlpSearchWorkoutScheduleSub.Name = "tlpSearchWorkoutScheduleSub";
            this.tlpSearchWorkoutScheduleSub.RowCount = 1;
            this.tlpSearchWorkoutScheduleSub.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSearchWorkoutScheduleSub.Size = new System.Drawing.Size(915, 67);
            this.tlpSearchWorkoutScheduleSub.TabIndex = 10;
            // 
            // tlpSearchWorkoutScheduleMain
            // 
            this.tlpSearchWorkoutScheduleMain.ColumnCount = 3;
            this.tlpSearchWorkoutScheduleMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 178F));
            this.tlpSearchWorkoutScheduleMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 327F));
            this.tlpSearchWorkoutScheduleMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tlpSearchWorkoutScheduleMain.Controls.Add(this.btnSearchWorkoutDay, 2, 0);
            this.tlpSearchWorkoutScheduleMain.Controls.Add(this.txrSearchWorkoutDay, 1, 0);
            this.tlpSearchWorkoutScheduleMain.Controls.Add(this.lblWorkoutDay, 0, 0);
            this.tlpSearchWorkoutScheduleMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSearchWorkoutScheduleMain.Location = new System.Drawing.Point(3, 3);
            this.tlpSearchWorkoutScheduleMain.Name = "tlpSearchWorkoutScheduleMain";
            this.tlpSearchWorkoutScheduleMain.RowCount = 1;
            this.tlpSearchWorkoutScheduleMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSearchWorkoutScheduleMain.Size = new System.Drawing.Size(604, 61);
            this.tlpSearchWorkoutScheduleMain.TabIndex = 2;
            // 
            // btnSearchWorkoutDay
            // 
            this.btnSearchWorkoutDay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearchWorkoutDay.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSearchWorkoutDay.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnSearchWorkoutDay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnSearchWorkoutDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchWorkoutDay.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchWorkoutDay.Location = new System.Drawing.Point(511, 12);
            this.btnSearchWorkoutDay.Name = "btnSearchWorkoutDay";
            this.btnSearchWorkoutDay.Size = new System.Drawing.Size(86, 36);
            this.btnSearchWorkoutDay.TabIndex = 6;
            this.btnSearchWorkoutDay.Text = "Search";
            this.btnSearchWorkoutDay.UseVisualStyleBackColor = false;
            // 
            // txrSearchWorkoutDay
            // 
            this.txrSearchWorkoutDay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txrSearchWorkoutDay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txrSearchWorkoutDay.ForeColor = System.Drawing.Color.Gray;
            this.txrSearchWorkoutDay.Location = new System.Drawing.Point(181, 13);
            this.txrSearchWorkoutDay.Name = "txrSearchWorkoutDay";
            this.txrSearchWorkoutDay.Size = new System.Drawing.Size(321, 34);
            this.txrSearchWorkoutDay.TabIndex = 4;
            this.txrSearchWorkoutDay.Text = "Enter Workout Day";
            // 
            // lblWorkoutDay
            // 
            this.lblWorkoutDay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblWorkoutDay.AutoSize = true;
            this.lblWorkoutDay.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkoutDay.Location = new System.Drawing.Point(3, 16);
            this.lblWorkoutDay.Name = "lblWorkoutDay";
            this.lblWorkoutDay.Size = new System.Drawing.Size(142, 28);
            this.lblWorkoutDay.TabIndex = 5;
            this.lblWorkoutDay.Text = "Workout Day :";
            // 
            // dgvAllWorkoutPlans
            // 
            this.dgvAllWorkoutPlans.AllowUserToAddRows = false;
            this.dgvAllWorkoutPlans.AllowUserToDeleteRows = false;
            this.dgvAllWorkoutPlans.AllowUserToResizeColumns = false;
            this.dgvAllWorkoutPlans.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvAllWorkoutPlans.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAllWorkoutPlans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllWorkoutPlans.BackgroundColor = System.Drawing.Color.White;
            this.dgvAllWorkoutPlans.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAllWorkoutPlans.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllWorkoutPlans.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAllWorkoutPlans.ColumnHeadersHeight = 50;
            this.dgvAllWorkoutPlans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAllWorkoutPlans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSerialNo,
            this.colWorkoutName,
            this.colExerciseName,
            this.colWorkoutDay});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllWorkoutPlans.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAllWorkoutPlans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAllWorkoutPlans.EnableHeadersVisualStyles = false;
            this.dgvAllWorkoutPlans.GridColor = System.Drawing.Color.Black;
            this.dgvAllWorkoutPlans.Location = new System.Drawing.Point(51, 148);
            this.dgvAllWorkoutPlans.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAllWorkoutPlans.MultiSelect = false;
            this.dgvAllWorkoutPlans.Name = "dgvAllWorkoutPlans";
            this.dgvAllWorkoutPlans.ReadOnly = true;
            this.dgvAllWorkoutPlans.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllWorkoutPlans.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAllWorkoutPlans.RowHeadersVisible = false;
            this.dgvAllWorkoutPlans.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvAllWorkoutPlans.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAllWorkoutPlans.RowTemplate.Height = 24;
            this.dgvAllWorkoutPlans.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllWorkoutPlans.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvAllWorkoutPlans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvAllWorkoutPlans.Size = new System.Drawing.Size(915, 398);
            this.dgvAllWorkoutPlans.TabIndex = 11;
            // 
            // pnlClickAddNewWorkoutSchedule
            // 
            this.pnlClickAddNewWorkoutSchedule.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnlClickAddNewWorkoutSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(195)))), ((int)(((byte)(179)))));
            this.pnlClickAddNewWorkoutSchedule.Controls.Add(this.tlpAddNewWorkoutSchedule);
            this.pnlClickAddNewWorkoutSchedule.Location = new System.Drawing.Point(51, 552);
            this.pnlClickAddNewWorkoutSchedule.Name = "pnlClickAddNewWorkoutSchedule";
            this.pnlClickAddNewWorkoutSchedule.Size = new System.Drawing.Size(393, 65);
            this.pnlClickAddNewWorkoutSchedule.TabIndex = 12;
            // 
            // tlpAddNewWorkoutSchedule
            // 
            this.tlpAddNewWorkoutSchedule.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tlpAddNewWorkoutSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(195)))), ((int)(((byte)(179)))));
            this.tlpAddNewWorkoutSchedule.ColumnCount = 2;
            this.tlpAddNewWorkoutSchedule.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.69087F));
            this.tlpAddNewWorkoutSchedule.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.30914F));
            this.tlpAddNewWorkoutSchedule.Controls.Add(this.lbAddNewWorkoutSchedule, 1, 0);
            this.tlpAddNewWorkoutSchedule.Controls.Add(this.picAddNewWorkoutSchedule, 0, 0);
            this.tlpAddNewWorkoutSchedule.Location = new System.Drawing.Point(1, -2);
            this.tlpAddNewWorkoutSchedule.Name = "tlpAddNewWorkoutSchedule";
            this.tlpAddNewWorkoutSchedule.RowCount = 1;
            this.tlpAddNewWorkoutSchedule.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAddNewWorkoutSchedule.Size = new System.Drawing.Size(391, 71);
            this.tlpAddNewWorkoutSchedule.TabIndex = 0;
            // 
            // lbAddNewWorkoutSchedule
            // 
            this.lbAddNewWorkoutSchedule.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbAddNewWorkoutSchedule.AutoSize = true;
            this.lbAddNewWorkoutSchedule.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddNewWorkoutSchedule.Location = new System.Drawing.Point(64, 19);
            this.lbAddNewWorkoutSchedule.Name = "lbAddNewWorkoutSchedule";
            this.lbAddNewWorkoutSchedule.Size = new System.Drawing.Size(322, 32);
            this.lbAddNewWorkoutSchedule.TabIndex = 1;
            this.lbAddNewWorkoutSchedule.Text = "Add New Workout Schedule";
            // 
            // picAddNewWorkoutSchedule
            // 
            this.picAddNewWorkoutSchedule.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.picAddNewWorkoutSchedule.Image = ((System.Drawing.Image)(resources.GetObject("picAddNewWorkoutSchedule.Image")));
            this.picAddNewWorkoutSchedule.Location = new System.Drawing.Point(9, 17);
            this.picAddNewWorkoutSchedule.Name = "picAddNewWorkoutSchedule";
            this.picAddNewWorkoutSchedule.Size = new System.Drawing.Size(49, 37);
            this.picAddNewWorkoutSchedule.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAddNewWorkoutSchedule.TabIndex = 2;
            this.picAddNewWorkoutSchedule.TabStop = false;
            // 
            // colSerialNo
            // 
            this.colSerialNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSerialNo.HeaderText = "Sl No.";
            this.colSerialNo.Name = "colSerialNo";
            this.colSerialNo.ReadOnly = true;
            this.colSerialNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colWorkoutName
            // 
            this.colWorkoutName.DataPropertyName = "WorkoutName ";
            this.colWorkoutName.HeaderText = "Workout Name ";
            this.colWorkoutName.Name = "colWorkoutName";
            this.colWorkoutName.ReadOnly = true;
            // 
            // colExerciseName
            // 
            this.colExerciseName.DataPropertyName = "ExerciseName";
            this.colExerciseName.HeaderText = "Exercise Name ";
            this.colExerciseName.Name = "colExerciseName";
            this.colExerciseName.ReadOnly = true;
            // 
            // colWorkoutDay
            // 
            this.colWorkoutDay.DataPropertyName = "WorkoutDay";
            this.colWorkoutDay.HeaderText = "WorkoutDay ";
            this.colWorkoutDay.Name = "colWorkoutDay";
            this.colWorkoutDay.ReadOnly = true;
            // 
            // FrmDisplayWorkoutSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 696);
            this.Controls.Add(this.tlpWorkoutScheduleEntireForm);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmDisplayWorkoutSchedule";
            this.Text = "FrmDisplayWorkoutSchedule";
            this.tlpWorkoutScheduleEntireForm.ResumeLayout(false);
            this.pnlAllWorkoutPlansTitle.ResumeLayout(false);
            this.pnlAllWorkoutPlansTitle.PerformLayout();
            this.tlpSearchWorkoutScheduleSub.ResumeLayout(false);
            this.tlpSearchWorkoutScheduleMain.ResumeLayout(false);
            this.tlpSearchWorkoutScheduleMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllWorkoutPlans)).EndInit();
            this.pnlClickAddNewWorkoutSchedule.ResumeLayout(false);
            this.tlpAddNewWorkoutSchedule.ResumeLayout(false);
            this.tlpAddNewWorkoutSchedule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddNewWorkoutSchedule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpWorkoutScheduleEntireForm;
        private System.Windows.Forms.Panel pnlAllWorkoutPlansTitle;
        private System.Windows.Forms.Label lblAllWorkoutScheduleTitle;
        private System.Windows.Forms.TableLayoutPanel tlpSearchWorkoutScheduleSub;
        private System.Windows.Forms.TableLayoutPanel tlpSearchWorkoutScheduleMain;
        private System.Windows.Forms.Button btnSearchWorkoutDay;
        private System.Windows.Forms.TextBox txrSearchWorkoutDay;
        private System.Windows.Forms.Label lblWorkoutDay;
        private System.Windows.Forms.DataGridView dgvAllWorkoutPlans;
        private System.Windows.Forms.Panel pnlClickAddNewWorkoutSchedule;
        private System.Windows.Forms.TableLayoutPanel tlpAddNewWorkoutSchedule;
        private System.Windows.Forms.Label lbAddNewWorkoutSchedule;
        private System.Windows.Forms.PictureBox picAddNewWorkoutSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSerialNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWorkoutName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExerciseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWorkoutDay;
    }
}