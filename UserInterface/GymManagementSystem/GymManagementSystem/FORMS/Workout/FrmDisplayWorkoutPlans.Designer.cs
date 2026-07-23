namespace GymManagementSystem.FORMS.Workout
{
    partial class FrmDisplayWorkoutPlans
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDisplayWorkoutPlans));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlClickAddNewWorkoutPlan = new System.Windows.Forms.Panel();
            this.tlpAddNewWorkoutPlan = new System.Windows.Forms.TableLayoutPanel();
            this.picAddNewWorkoutPlan = new System.Windows.Forms.PictureBox();
            this.lbAddNewExercise = new System.Windows.Forms.Label();
            this.dgvAllWorkoutPlans = new System.Windows.Forms.DataGridView();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWorkoutName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSerialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpSearchWorkoutPlanSub = new System.Windows.Forms.TableLayoutPanel();
            this.tlpSearchWorkoutPlanMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblWorkoutName = new System.Windows.Forms.Label();
            this.txrSearchWorkoutName = new System.Windows.Forms.TextBox();
            this.btnSearchWorkoutPlan = new System.Windows.Forms.Button();
            this.pnlAllWorkoutPlansTitle = new System.Windows.Forms.Panel();
            this.lblAllWorkoutPlansTitle = new System.Windows.Forms.Label();
            this.tlpWorkoutPlanEntireForm = new System.Windows.Forms.TableLayoutPanel();
            this.pnlClickAddNewWorkoutPlan.SuspendLayout();
            this.tlpAddNewWorkoutPlan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddNewWorkoutPlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllWorkoutPlans)).BeginInit();
            this.tlpSearchWorkoutPlanSub.SuspendLayout();
            this.tlpSearchWorkoutPlanMain.SuspendLayout();
            this.pnlAllWorkoutPlansTitle.SuspendLayout();
            this.tlpWorkoutPlanEntireForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlClickAddNewWorkoutPlan
            // 
            this.pnlClickAddNewWorkoutPlan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnlClickAddNewWorkoutPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(195)))), ((int)(((byte)(179)))));
            this.pnlClickAddNewWorkoutPlan.Controls.Add(this.tlpAddNewWorkoutPlan);
            this.pnlClickAddNewWorkoutPlan.Location = new System.Drawing.Point(52, 539);
            this.pnlClickAddNewWorkoutPlan.Name = "pnlClickAddNewWorkoutPlan";
            this.pnlClickAddNewWorkoutPlan.Size = new System.Drawing.Size(369, 65);
            this.pnlClickAddNewWorkoutPlan.TabIndex = 12;
            // 
            // tlpAddNewWorkoutPlan
            // 
            this.tlpAddNewWorkoutPlan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tlpAddNewWorkoutPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(195)))), ((int)(((byte)(179)))));
            this.tlpAddNewWorkoutPlan.ColumnCount = 2;
            this.tlpAddNewWorkoutPlan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.20261F));
            this.tlpAddNewWorkoutPlan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.79739F));
            this.tlpAddNewWorkoutPlan.Controls.Add(this.lbAddNewExercise, 1, 0);
            this.tlpAddNewWorkoutPlan.Controls.Add(this.picAddNewWorkoutPlan, 0, 0);
            this.tlpAddNewWorkoutPlan.Location = new System.Drawing.Point(1, -2);
            this.tlpAddNewWorkoutPlan.Name = "tlpAddNewWorkoutPlan";
            this.tlpAddNewWorkoutPlan.RowCount = 1;
            this.tlpAddNewWorkoutPlan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAddNewWorkoutPlan.Size = new System.Drawing.Size(366, 71);
            this.tlpAddNewWorkoutPlan.TabIndex = 0;
            // 
            // picAddNewWorkoutPlan
            // 
            this.picAddNewWorkoutPlan.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.picAddNewWorkoutPlan.Image = ((System.Drawing.Image)(resources.GetObject("picAddNewWorkoutPlan.Image")));
            this.picAddNewWorkoutPlan.Location = new System.Drawing.Point(32, 17);
            this.picAddNewWorkoutPlan.Name = "picAddNewWorkoutPlan";
            this.picAddNewWorkoutPlan.Size = new System.Drawing.Size(49, 37);
            this.picAddNewWorkoutPlan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAddNewWorkoutPlan.TabIndex = 2;
            this.picAddNewWorkoutPlan.TabStop = false;
            // 
            // lbAddNewExercise
            // 
            this.lbAddNewExercise.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbAddNewExercise.AutoSize = true;
            this.lbAddNewExercise.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddNewExercise.Location = new System.Drawing.Point(87, 19);
            this.lbAddNewExercise.Name = "lbAddNewExercise";
            this.lbAddNewExercise.Size = new System.Drawing.Size(264, 32);
            this.lbAddNewExercise.TabIndex = 1;
            this.lbAddNewExercise.Text = "Add New WorkoutPlan";
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
            this.colDescription});
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
            this.dgvAllWorkoutPlans.Location = new System.Drawing.Point(52, 144);
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
            this.dgvAllWorkoutPlans.Size = new System.Drawing.Size(938, 390);
            this.dgvAllWorkoutPlans.TabIndex = 11;
            // 
            // colDescription
            // 
            this.colDescription.DataPropertyName = "Description ";
            this.colDescription.HeaderText = "Description ";
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            // 
            // colWorkoutName
            // 
            this.colWorkoutName.DataPropertyName = "WorkoutName ";
            this.colWorkoutName.HeaderText = "Workout Name ";
            this.colWorkoutName.Name = "colWorkoutName";
            this.colWorkoutName.ReadOnly = true;
            // 
            // colSerialNo
            // 
            this.colSerialNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSerialNo.HeaderText = "Sl No.";
            this.colSerialNo.Name = "colSerialNo";
            this.colSerialNo.ReadOnly = true;
            this.colSerialNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tlpSearchWorkoutPlanSub
            // 
            this.tlpSearchWorkoutPlanSub.ColumnCount = 2;
            this.tlpSearchWorkoutPlanSub.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 610F));
            this.tlpSearchWorkoutPlanSub.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSearchWorkoutPlanSub.Controls.Add(this.tlpSearchWorkoutPlanMain, 0, 0);
            this.tlpSearchWorkoutPlanSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSearchWorkoutPlanSub.Location = new System.Drawing.Point(52, 74);
            this.tlpSearchWorkoutPlanSub.Name = "tlpSearchWorkoutPlanSub";
            this.tlpSearchWorkoutPlanSub.RowCount = 1;
            this.tlpSearchWorkoutPlanSub.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSearchWorkoutPlanSub.Size = new System.Drawing.Size(938, 65);
            this.tlpSearchWorkoutPlanSub.TabIndex = 10;
            // 
            // tlpSearchWorkoutPlanMain
            // 
            this.tlpSearchWorkoutPlanMain.ColumnCount = 3;
            this.tlpSearchWorkoutPlanMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 178F));
            this.tlpSearchWorkoutPlanMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 327F));
            this.tlpSearchWorkoutPlanMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tlpSearchWorkoutPlanMain.Controls.Add(this.btnSearchWorkoutPlan, 2, 0);
            this.tlpSearchWorkoutPlanMain.Controls.Add(this.txrSearchWorkoutName, 1, 0);
            this.tlpSearchWorkoutPlanMain.Controls.Add(this.lblWorkoutName, 0, 0);
            this.tlpSearchWorkoutPlanMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSearchWorkoutPlanMain.Location = new System.Drawing.Point(3, 3);
            this.tlpSearchWorkoutPlanMain.Name = "tlpSearchWorkoutPlanMain";
            this.tlpSearchWorkoutPlanMain.RowCount = 1;
            this.tlpSearchWorkoutPlanMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSearchWorkoutPlanMain.Size = new System.Drawing.Size(604, 59);
            this.tlpSearchWorkoutPlanMain.TabIndex = 2;
            // 
            // lblWorkoutName
            // 
            this.lblWorkoutName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblWorkoutName.AutoSize = true;
            this.lblWorkoutName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkoutName.Location = new System.Drawing.Point(3, 15);
            this.lblWorkoutName.Name = "lblWorkoutName";
            this.lblWorkoutName.Size = new System.Drawing.Size(162, 28);
            this.lblWorkoutName.TabIndex = 5;
            this.lblWorkoutName.Text = "Workout Name :";
            // 
            // txrSearchWorkoutName
            // 
            this.txrSearchWorkoutName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txrSearchWorkoutName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txrSearchWorkoutName.ForeColor = System.Drawing.Color.Gray;
            this.txrSearchWorkoutName.Location = new System.Drawing.Point(181, 12);
            this.txrSearchWorkoutName.Name = "txrSearchWorkoutName";
            this.txrSearchWorkoutName.Size = new System.Drawing.Size(321, 34);
            this.txrSearchWorkoutName.TabIndex = 4;
            this.txrSearchWorkoutName.Text = "Enter Workout Name ";
            // 
            // btnSearchWorkoutPlan
            // 
            this.btnSearchWorkoutPlan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearchWorkoutPlan.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSearchWorkoutPlan.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnSearchWorkoutPlan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnSearchWorkoutPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchWorkoutPlan.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchWorkoutPlan.Location = new System.Drawing.Point(511, 11);
            this.btnSearchWorkoutPlan.Name = "btnSearchWorkoutPlan";
            this.btnSearchWorkoutPlan.Size = new System.Drawing.Size(86, 36);
            this.btnSearchWorkoutPlan.TabIndex = 6;
            this.btnSearchWorkoutPlan.Text = "Search";
            this.btnSearchWorkoutPlan.UseVisualStyleBackColor = false;
            // 
            // pnlAllWorkoutPlansTitle
            // 
            this.pnlAllWorkoutPlansTitle.Controls.Add(this.lblAllWorkoutPlansTitle);
            this.pnlAllWorkoutPlansTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAllWorkoutPlansTitle.Location = new System.Drawing.Point(52, 3);
            this.pnlAllWorkoutPlansTitle.Name = "pnlAllWorkoutPlansTitle";
            this.pnlAllWorkoutPlansTitle.Size = new System.Drawing.Size(938, 65);
            this.pnlAllWorkoutPlansTitle.TabIndex = 9;
            // 
            // lblAllWorkoutPlansTitle
            // 
            this.lblAllWorkoutPlansTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAllWorkoutPlansTitle.AutoSize = true;
            this.lblAllWorkoutPlansTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllWorkoutPlansTitle.Location = new System.Drawing.Point(3, 18);
            this.lblAllWorkoutPlansTitle.Name = "lblAllWorkoutPlansTitle";
            this.lblAllWorkoutPlansTitle.Size = new System.Drawing.Size(235, 38);
            this.lblAllWorkoutPlansTitle.TabIndex = 0;
            this.lblAllWorkoutPlansTitle.Text = "All WorkoutPlans";
            // 
            // tlpWorkoutPlanEntireForm
            // 
            this.tlpWorkoutPlanEntireForm.ColumnCount = 3;
            this.tlpWorkoutPlanEntireForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.761906F));
            this.tlpWorkoutPlanEntireForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.47619F));
            this.tlpWorkoutPlanEntireForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.761905F));
            this.tlpWorkoutPlanEntireForm.Controls.Add(this.pnlAllWorkoutPlansTitle, 1, 0);
            this.tlpWorkoutPlanEntireForm.Controls.Add(this.tlpSearchWorkoutPlanSub, 1, 1);
            this.tlpWorkoutPlanEntireForm.Controls.Add(this.dgvAllWorkoutPlans, 1, 2);
            this.tlpWorkoutPlanEntireForm.Controls.Add(this.pnlClickAddNewWorkoutPlan, 1, 3);
            this.tlpWorkoutPlanEntireForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpWorkoutPlanEntireForm.Location = new System.Drawing.Point(0, 0);
            this.tlpWorkoutPlanEntireForm.Name = "tlpWorkoutPlanEntireForm";
            this.tlpWorkoutPlanEntireForm.RowCount = 5;
            this.tlpWorkoutPlanEntireForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.52632F));
            this.tlpWorkoutPlanEntireForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.52632F));
            this.tlpWorkoutPlanEntireForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.89474F));
            this.tlpWorkoutPlanEntireForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.52632F));
            this.tlpWorkoutPlanEntireForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.52632F));
            this.tlpWorkoutPlanEntireForm.Size = new System.Drawing.Size(1044, 682);
            this.tlpWorkoutPlanEntireForm.TabIndex = 1;
            // 
            // FrmDisplayWorkoutPlans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 682);
            this.Controls.Add(this.tlpWorkoutPlanEntireForm);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDisplayWorkoutPlans";
            this.Text = "FrmDisplayWorkoutPlans";
            this.pnlClickAddNewWorkoutPlan.ResumeLayout(false);
            this.tlpAddNewWorkoutPlan.ResumeLayout(false);
            this.tlpAddNewWorkoutPlan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddNewWorkoutPlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllWorkoutPlans)).EndInit();
            this.tlpSearchWorkoutPlanSub.ResumeLayout(false);
            this.tlpSearchWorkoutPlanMain.ResumeLayout(false);
            this.tlpSearchWorkoutPlanMain.PerformLayout();
            this.pnlAllWorkoutPlansTitle.ResumeLayout(false);
            this.pnlAllWorkoutPlansTitle.PerformLayout();
            this.tlpWorkoutPlanEntireForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlClickAddNewWorkoutPlan;
        private System.Windows.Forms.TableLayoutPanel tlpAddNewWorkoutPlan;
        private System.Windows.Forms.Label lbAddNewExercise;
        private System.Windows.Forms.PictureBox picAddNewWorkoutPlan;
        private System.Windows.Forms.DataGridView dgvAllWorkoutPlans;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSerialNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWorkoutName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.TableLayoutPanel tlpSearchWorkoutPlanSub;
        private System.Windows.Forms.TableLayoutPanel tlpSearchWorkoutPlanMain;
        private System.Windows.Forms.Button btnSearchWorkoutPlan;
        private System.Windows.Forms.TextBox txrSearchWorkoutName;
        private System.Windows.Forms.Label lblWorkoutName;
        private System.Windows.Forms.Panel pnlAllWorkoutPlansTitle;
        private System.Windows.Forms.Label lblAllWorkoutPlansTitle;
        private System.Windows.Forms.TableLayoutPanel tlpWorkoutPlanEntireForm;

    }
}