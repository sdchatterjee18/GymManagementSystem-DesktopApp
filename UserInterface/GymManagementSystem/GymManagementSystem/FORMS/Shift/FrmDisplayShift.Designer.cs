namespace GymManagementSystem.FORMS.Shift
{
    partial class FrmDisplayShift
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
            this.tlpMainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.tlpGridLayout = new System.Windows.Forms.TableLayoutPanel();
            this.pnlGridContainer = new System.Windows.Forms.Panel();
            this.tlpTitleLayout = new System.Windows.Forms.TableLayoutPanel();
            this.tlpMainLayout.SuspendLayout();
            this.tlpGridLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMainLayout
            // 
            this.tlpMainLayout.ColumnCount = 1;
            this.tlpMainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainLayout.Controls.Add(this.tlpGridLayout, 0, 1);
            this.tlpMainLayout.Controls.Add(this.tlpTitleLayout, 0, 0);
            this.tlpMainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMainLayout.Location = new System.Drawing.Point(15, 15);
            this.tlpMainLayout.Name = "tlpMainLayout";
            this.tlpMainLayout.RowCount = 3;
            this.tlpMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMainLayout.Size = new System.Drawing.Size(727, 452);
            this.tlpMainLayout.TabIndex = 0;
            // 
            // tlpGridLayout
            // 
            this.tlpGridLayout.ColumnCount = 3;
            this.tlpGridLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpGridLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlpGridLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpGridLayout.Controls.Add(this.pnlGridContainer, 1, 0);
            this.tlpGridLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpGridLayout.Location = new System.Drawing.Point(3, 63);
            this.tlpGridLayout.Name = "tlpGridLayout";
            this.tlpGridLayout.RowCount = 1;
            this.tlpGridLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpGridLayout.Size = new System.Drawing.Size(721, 366);
            this.tlpGridLayout.TabIndex = 1;
            // 
            // pnlGridContainer
            // 
            this.pnlGridContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlGridContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGridContainer.Location = new System.Drawing.Point(75, 3);
            this.pnlGridContainer.Name = "pnlGridContainer";
            this.pnlGridContainer.Size = new System.Drawing.Size(570, 360);
            this.pnlGridContainer.TabIndex = 0;
            // 
            // tlpTitleLayout
            // 
            this.tlpTitleLayout.ColumnCount = 2;
            this.tlpTitleLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tlpTitleLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 93F));
            this.tlpTitleLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTitleLayout.Location = new System.Drawing.Point(3, 3);
            this.tlpTitleLayout.Name = "tlpTitleLayout";
            this.tlpTitleLayout.RowCount = 1;
            this.tlpTitleLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTitleLayout.Size = new System.Drawing.Size(721, 54);
            this.tlpTitleLayout.TabIndex = 2;
            // 
            // FrmDisplayShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(757, 482);
            this.Controls.Add(this.tlpMainLayout);
            this.Name = "FrmDisplayShift";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.Text = "FrmDisplayShift";
            this.tlpMainLayout.ResumeLayout(false);
            this.tlpGridLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMainLayout;
        private System.Windows.Forms.TableLayoutPanel tlpGridLayout;
        private System.Windows.Forms.Panel pnlGridContainer;
        private System.Windows.Forms.TableLayoutPanel tlpTitleLayout;

    }
}