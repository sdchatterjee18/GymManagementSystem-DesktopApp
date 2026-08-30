namespace GymManagementSystem.FORMS.Member
{
    partial class FrmCropImage
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
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlCropArea = new GymManagementSystem.FORMS.Member.FlickerFreePanel();
            this.picCropImage = new System.Windows.Forms.PictureBox();
            this.tblButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRotate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tblMain.SuspendLayout();
            this.pnlCropArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCropImage)).BeginInit();
            this.tblButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 1;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.Controls.Add(this.pnlCropArea, 0, 0);
            this.tblMain.Controls.Add(this.tblButtons, 0, 1);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Margin = new System.Windows.Forms.Padding(0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 2;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tblMain.Size = new System.Drawing.Size(456, 506);
            this.tblMain.TabIndex = 0;
            // 
            // pnlCropArea
            // 
            this.pnlCropArea.BackColor = System.Drawing.Color.Transparent;
            this.pnlCropArea.Controls.Add(this.picCropImage);
            this.pnlCropArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCropArea.Location = new System.Drawing.Point(0, 0);
            this.pnlCropArea.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCropArea.Name = "pnlCropArea";
            this.pnlCropArea.Padding = new System.Windows.Forms.Padding(10);
            this.pnlCropArea.Size = new System.Drawing.Size(456, 446);
            this.pnlCropArea.TabIndex = 0;
            this.pnlCropArea.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCropArea_Paint);
            this.pnlCropArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlCropArea_MouseDown);
            this.pnlCropArea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlCropArea_MouseMove);
            this.pnlCropArea.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlCropArea_MouseUp);
            this.pnlCropArea.Resize += new System.EventHandler(this.pnlCropArea_Resize);
            // 
            // picCropImage
            // 
            this.picCropImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picCropImage.BackColor = System.Drawing.Color.Silver;
            this.picCropImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCropImage.Location = new System.Drawing.Point(10, 10);
            this.picCropImage.Margin = new System.Windows.Forms.Padding(0);
            this.picCropImage.Name = "picCropImage";
            this.picCropImage.Size = new System.Drawing.Size(436, 426);
            this.picCropImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCropImage.TabIndex = 0;
            this.picCropImage.TabStop = false;
            // 
            // tblButtons
            // 
            this.tblButtons.ColumnCount = 4;
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.01F));
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66333F));
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66333F));
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66333F));
            this.tblButtons.Controls.Add(this.btnSave, 3, 0);
            this.tblButtons.Controls.Add(this.btnRotate, 2, 0);
            this.tblButtons.Controls.Add(this.btnCancel, 1, 0);
            this.tblButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblButtons.Location = new System.Drawing.Point(0, 446);
            this.tblButtons.Margin = new System.Windows.Forms.Padding(0);
            this.tblButtons.Name = "tblButtons";
            this.tblButtons.RowCount = 1;
            this.tblButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblButtons.Size = new System.Drawing.Size(456, 60);
            this.tblButtons.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(383, 5);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(68, 50);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRotate
            // 
            this.btnRotate.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRotate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRotate.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRotate.ForeColor = System.Drawing.Color.White;
            this.btnRotate.Location = new System.Drawing.Point(308, 5);
            this.btnRotate.Margin = new System.Windows.Forms.Padding(5);
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(65, 50);
            this.btnRotate.TabIndex = 0;
            this.btnRotate.Text = "Rotate";
            this.btnRotate.UseVisualStyleBackColor = false;
            this.btnRotate.Click += new System.EventHandler(this.btnRotate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(233, 5);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 50);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmCropImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 506);
            this.Controls.Add(this.tblMain);
            this.MaximumSize = new System.Drawing.Size(474, 553);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(474, 553);
            this.Name = "FrmCropImage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCropImage";
            this.Load += new System.EventHandler(this.FrmCropImage_Load);
            this.tblMain.ResumeLayout(false);
            this.pnlCropArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCropImage)).EndInit();
            this.tblButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMain;
        private GymManagementSystem.FORMS.Member.FlickerFreePanel pnlCropArea;
        private System.Windows.Forms.TableLayoutPanel tblButtons;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRotate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox picCropImage;
    }
}