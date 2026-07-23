namespace GymManagementSystem.FORMS.Workout
{
    partial class FrmDisplayExercise
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDisplayExercise));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlClickAddNewExercise = new System.Windows.Forms.Panel();
            this.tlpAddNewExercise = new System.Windows.Forms.TableLayoutPanel();
            this.picAddNewExercise = new System.Windows.Forms.PictureBox();
            this.lbAddNewExercise = new System.Windows.Forms.Label();
            this.dgvAllExercise = new System.Windows.Forms.DataGridView();
            this.colMuscleType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExerciseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSerialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpSearchExerciseSub = new System.Windows.Forms.TableLayoutPanel();
            this.tlpSearchExerciseMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblExerciseName = new System.Windows.Forms.Label();
            this.txrSearchExerciseName = new System.Windows.Forms.TextBox();
            this.btnSearchExercise = new System.Windows.Forms.Button();
            this.pnlAllExerciseTitle = new System.Windows.Forms.Panel();
            this.lblAllExerciseTitle = new System.Windows.Forms.Label();
            this.tlpExerciseEntireForm = new System.Windows.Forms.TableLayoutPanel();
            this.pnlClickAddNewExercise.SuspendLayout();
            this.tlpAddNewExercise.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddNewExercise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllExercise)).BeginInit();
            this.tlpSearchExerciseSub.SuspendLayout();
            this.tlpSearchExerciseMain.SuspendLayout();
            this.pnlAllExerciseTitle.SuspendLayout();
            this.tlpExerciseEntireForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlClickAddNewExercise
            // 
            this.pnlClickAddNewExercise.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnlClickAddNewExercise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(195)))), ((int)(((byte)(179)))));
            this.pnlClickAddNewExercise.Controls.Add(this.tlpAddNewExercise);
            this.pnlClickAddNewExercise.Location = new System.Drawing.Point(53, 557);
            this.pnlClickAddNewExercise.Name = "pnlClickAddNewExercise";
            this.pnlClickAddNewExercise.Size = new System.Drawing.Size(307, 67);
            this.pnlClickAddNewExercise.TabIndex = 12;
            // 
            // tlpAddNewExercise
            // 
            this.tlpAddNewExercise.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tlpAddNewExercise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(195)))), ((int)(((byte)(179)))));
            this.tlpAddNewExercise.ColumnCount = 2;
            this.tlpAddNewExercise.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.20261F));
            this.tlpAddNewExercise.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.79739F));
            this.tlpAddNewExercise.Controls.Add(this.lbAddNewExercise, 1, 0);
            this.tlpAddNewExercise.Controls.Add(this.picAddNewExercise, 0, 0);
            this.tlpAddNewExercise.Location = new System.Drawing.Point(1, -1);
            this.tlpAddNewExercise.Name = "tlpAddNewExercise";
            this.tlpAddNewExercise.RowCount = 1;
            this.tlpAddNewExercise.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAddNewExercise.Size = new System.Drawing.Size(306, 71);
            this.tlpAddNewExercise.TabIndex = 0;
            // 
            // picAddNewExercise
            // 
            this.picAddNewExercise.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.picAddNewExercise.Image = ((System.Drawing.Image)(resources.GetObject("picAddNewExercise.Image")));
            this.picAddNewExercise.Location = new System.Drawing.Point(18, 17);
            this.picAddNewExercise.Name = "picAddNewExercise";
            this.picAddNewExercise.Size = new System.Drawing.Size(49, 37);
            this.picAddNewExercise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAddNewExercise.TabIndex = 2;
            this.picAddNewExercise.TabStop = false;
            // 
            // lbAddNewExercise
            // 
            this.lbAddNewExercise.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbAddNewExercise.AutoSize = true;
            this.lbAddNewExercise.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddNewExercise.Location = new System.Drawing.Point(73, 19);
            this.lbAddNewExercise.Name = "lbAddNewExercise";
            this.lbAddNewExercise.Size = new System.Drawing.Size(208, 32);
            this.lbAddNewExercise.TabIndex = 1;
            this.lbAddNewExercise.Text = "Add New Exercise";
            // 
            // dgvAllExercise
            // 
            this.dgvAllExercise.AllowUserToAddRows = false;
            this.dgvAllExercise.AllowUserToDeleteRows = false;
            this.dgvAllExercise.AllowUserToResizeColumns = false;
            this.dgvAllExercise.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvAllExercise.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAllExercise.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllExercise.BackgroundColor = System.Drawing.Color.White;
            this.dgvAllExercise.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAllExercise.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllExercise.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAllExercise.ColumnHeadersHeight = 50;
            this.dgvAllExercise.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAllExercise.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSerialNo,
            this.colExerciseName,
            this.colMuscleType});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllExercise.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAllExercise.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAllExercise.EnableHeadersVisualStyles = false;
            this.dgvAllExercise.GridColor = System.Drawing.Color.Black;
            this.dgvAllExercise.Location = new System.Drawing.Point(53, 149);
            this.dgvAllExercise.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAllExercise.MultiSelect = false;
            this.dgvAllExercise.Name = "dgvAllExercise";
            this.dgvAllExercise.ReadOnly = true;
            this.dgvAllExercise.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllExercise.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAllExercise.RowHeadersVisible = false;
            this.dgvAllExercise.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvAllExercise.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAllExercise.RowTemplate.Height = 24;
            this.dgvAllExercise.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllExercise.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvAllExercise.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvAllExercise.Size = new System.Drawing.Size(946, 403);
            this.dgvAllExercise.TabIndex = 11;
            // 
            // colMuscleType
            // 
            this.colMuscleType.DataPropertyName = "MuscleType ";
            this.colMuscleType.HeaderText = "Muscle Type ";
            this.colMuscleType.Name = "colMuscleType";
            this.colMuscleType.ReadOnly = true;
            // 
            // colExerciseName
            // 
            this.colExerciseName.DataPropertyName = "ExerciseName ";
            this.colExerciseName.HeaderText = "Exercise Name ";
            this.colExerciseName.Name = "colExerciseName";
            this.colExerciseName.ReadOnly = true;
            // 
            // colSerialNo
            // 
            this.colSerialNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSerialNo.HeaderText = "Sl No.";
            this.colSerialNo.Name = "colSerialNo";
            this.colSerialNo.ReadOnly = true;
            this.colSerialNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tlpSearchExerciseSub
            // 
            this.tlpSearchExerciseSub.ColumnCount = 2;
            this.tlpSearchExerciseSub.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 610F));
            this.tlpSearchExerciseSub.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSearchExerciseSub.Controls.Add(this.tlpSearchExerciseMain, 0, 0);
            this.tlpSearchExerciseSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSearchExerciseSub.Location = new System.Drawing.Point(53, 77);
            this.tlpSearchExerciseSub.Name = "tlpSearchExerciseSub";
            this.tlpSearchExerciseSub.RowCount = 1;
            this.tlpSearchExerciseSub.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSearchExerciseSub.Size = new System.Drawing.Size(946, 67);
            this.tlpSearchExerciseSub.TabIndex = 10;
            // 
            // tlpSearchExerciseMain
            // 
            this.tlpSearchExerciseMain.ColumnCount = 3;
            this.tlpSearchExerciseMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 178F));
            this.tlpSearchExerciseMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 327F));
            this.tlpSearchExerciseMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpSearchExerciseMain.Controls.Add(this.btnSearchExercise, 2, 0);
            this.tlpSearchExerciseMain.Controls.Add(this.txrSearchExerciseName, 1, 0);
            this.tlpSearchExerciseMain.Controls.Add(this.lblExerciseName, 0, 0);
            this.tlpSearchExerciseMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSearchExerciseMain.Location = new System.Drawing.Point(3, 3);
            this.tlpSearchExerciseMain.Name = "tlpSearchExerciseMain";
            this.tlpSearchExerciseMain.RowCount = 1;
            this.tlpSearchExerciseMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSearchExerciseMain.Size = new System.Drawing.Size(604, 61);
            this.tlpSearchExerciseMain.TabIndex = 2;
            // 
            // lblExerciseName
            // 
            this.lblExerciseName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblExerciseName.AutoSize = true;
            this.lblExerciseName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExerciseName.Location = new System.Drawing.Point(3, 16);
            this.lblExerciseName.Name = "lblExerciseName";
            this.lblExerciseName.Size = new System.Drawing.Size(155, 28);
            this.lblExerciseName.TabIndex = 5;
            this.lblExerciseName.Text = "Exercise Name :";
            // 
            // txrSearchExerciseName
            // 
            this.txrSearchExerciseName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txrSearchExerciseName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txrSearchExerciseName.ForeColor = System.Drawing.Color.Gray;
            this.txrSearchExerciseName.Location = new System.Drawing.Point(181, 13);
            this.txrSearchExerciseName.Name = "txrSearchExerciseName";
            this.txrSearchExerciseName.Size = new System.Drawing.Size(321, 34);
            this.txrSearchExerciseName.TabIndex = 4;
            this.txrSearchExerciseName.Text = "Enter Exercise Name";
            // 
            // btnSearchExercise
            // 
            this.btnSearchExercise.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearchExercise.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSearchExercise.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnSearchExercise.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnSearchExercise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchExercise.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchExercise.Location = new System.Drawing.Point(511, 12);
            this.btnSearchExercise.Name = "btnSearchExercise";
            this.btnSearchExercise.Size = new System.Drawing.Size(86, 36);
            this.btnSearchExercise.TabIndex = 6;
            this.btnSearchExercise.Text = "Search";
            this.btnSearchExercise.UseVisualStyleBackColor = false;
            // 
            // pnlAllExerciseTitle
            // 
            this.pnlAllExerciseTitle.Controls.Add(this.lblAllExerciseTitle);
            this.pnlAllExerciseTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAllExerciseTitle.Location = new System.Drawing.Point(53, 3);
            this.pnlAllExerciseTitle.Name = "pnlAllExerciseTitle";
            this.pnlAllExerciseTitle.Size = new System.Drawing.Size(946, 68);
            this.pnlAllExerciseTitle.TabIndex = 9;
            // 
            // lblAllExerciseTitle
            // 
            this.lblAllExerciseTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAllExerciseTitle.AutoSize = true;
            this.lblAllExerciseTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllExerciseTitle.Location = new System.Drawing.Point(3, 21);
            this.lblAllExerciseTitle.Name = "lblAllExerciseTitle";
            this.lblAllExerciseTitle.Size = new System.Drawing.Size(159, 38);
            this.lblAllExerciseTitle.TabIndex = 0;
            this.lblAllExerciseTitle.Text = "All Exercise";
            // 
            // tlpExerciseEntireForm
            // 
            this.tlpExerciseEntireForm.ColumnCount = 3;
            this.tlpExerciseEntireForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.761906F));
            this.tlpExerciseEntireForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.47619F));
            this.tlpExerciseEntireForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.761905F));
            this.tlpExerciseEntireForm.Controls.Add(this.pnlAllExerciseTitle, 1, 0);
            this.tlpExerciseEntireForm.Controls.Add(this.tlpSearchExerciseSub, 1, 1);
            this.tlpExerciseEntireForm.Controls.Add(this.dgvAllExercise, 1, 2);
            this.tlpExerciseEntireForm.Controls.Add(this.pnlClickAddNewExercise, 1, 3);
            this.tlpExerciseEntireForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpExerciseEntireForm.Location = new System.Drawing.Point(0, 0);
            this.tlpExerciseEntireForm.Name = "tlpExerciseEntireForm";
            this.tlpExerciseEntireForm.RowCount = 5;
            this.tlpExerciseEntireForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.52632F));
            this.tlpExerciseEntireForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.52632F));
            this.tlpExerciseEntireForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.89474F));
            this.tlpExerciseEntireForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.52632F));
            this.tlpExerciseEntireForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.52632F));
            this.tlpExerciseEntireForm.Size = new System.Drawing.Size(1053, 703);
            this.tlpExerciseEntireForm.TabIndex = 0;
            this.tlpExerciseEntireForm.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpExerciseEntireForm_Paint);
            // 
            // FrmDisplayExercise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 703);
            this.Controls.Add(this.tlpExerciseEntireForm);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmDisplayExercise";
            this.Text = "FrmDisplayExercise";
            this.pnlClickAddNewExercise.ResumeLayout(false);
            this.tlpAddNewExercise.ResumeLayout(false);
            this.tlpAddNewExercise.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddNewExercise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllExercise)).EndInit();
            this.tlpSearchExerciseSub.ResumeLayout(false);
            this.tlpSearchExerciseMain.ResumeLayout(false);
            this.tlpSearchExerciseMain.PerformLayout();
            this.pnlAllExerciseTitle.ResumeLayout(false);
            this.pnlAllExerciseTitle.PerformLayout();
            this.tlpExerciseEntireForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlClickAddNewExercise;
        private System.Windows.Forms.TableLayoutPanel tlpAddNewExercise;
        private System.Windows.Forms.Label lbAddNewExercise;
        private System.Windows.Forms.PictureBox picAddNewExercise;
        private System.Windows.Forms.DataGridView dgvAllExercise;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSerialNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExerciseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMuscleType;
        private System.Windows.Forms.TableLayoutPanel tlpSearchExerciseSub;
        private System.Windows.Forms.TableLayoutPanel tlpSearchExerciseMain;
        private System.Windows.Forms.Button btnSearchExercise;
        private System.Windows.Forms.TextBox txrSearchExerciseName;
        private System.Windows.Forms.Label lblExerciseName;
        private System.Windows.Forms.Panel pnlAllExerciseTitle;
        private System.Windows.Forms.Label lblAllExerciseTitle;
        private System.Windows.Forms.TableLayoutPanel tlpExerciseEntireForm;

    }
}