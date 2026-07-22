namespace GymManagementSystem.FORMS.Expenses
{
    partial class FrmAddExpenseCategory
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
            this.tlpExpenseCategoty = new System.Windows.Forms.TableLayoutPanel();
            this.tlpNewExpenseCategoryHeader = new System.Windows.Forms.TableLayoutPanel();
            this.lblNewExpensesCategoryHeader = new System.Windows.Forms.Label();
            this.lblCancel = new System.Windows.Forms.Label();
            this.tlpCategoryName = new System.Windows.Forms.TableLayoutPanel();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.tlpCategoryNameSection = new System.Windows.Forms.TableLayoutPanel();
            this.txtNewExpensesCategoryName = new System.Windows.Forms.TextBox();
            this.txtCategoryNameErrorMessage = new System.Windows.Forms.TextBox();
            this.tlpAddButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tlpCategory = new System.Windows.Forms.TableLayoutPanel();
            this.lblCategory = new System.Windows.Forms.Label();
            this.tlpCategorySection = new System.Windows.Forms.TableLayoutPanel();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtCategoryErrorMessage = new System.Windows.Forms.TextBox();
            this.tlpExpenseCategoty.SuspendLayout();
            this.tlpNewExpenseCategoryHeader.SuspendLayout();
            this.tlpCategoryName.SuspendLayout();
            this.tlpCategoryNameSection.SuspendLayout();
            this.tlpAddButton.SuspendLayout();
            this.tlpCategory.SuspendLayout();
            this.tlpCategorySection.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpExpenseCategoty
            // 
            this.tlpExpenseCategoty.ColumnCount = 1;
            this.tlpExpenseCategoty.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpExpenseCategoty.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpExpenseCategoty.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpExpenseCategoty.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpExpenseCategoty.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpExpenseCategoty.Controls.Add(this.tlpNewExpenseCategoryHeader, 0, 0);
            this.tlpExpenseCategoty.Controls.Add(this.tlpCategoryName, 0, 2);
            this.tlpExpenseCategoty.Controls.Add(this.tlpAddButton, 0, 4);
            this.tlpExpenseCategoty.Controls.Add(this.tlpCategory, 0, 3);
            this.tlpExpenseCategoty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpExpenseCategoty.Location = new System.Drawing.Point(0, 0);
            this.tlpExpenseCategoty.Name = "tlpExpenseCategoty";
            this.tlpExpenseCategoty.RowCount = 5;
            this.tlpExpenseCategoty.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.20202F));
            this.tlpExpenseCategoty.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.030303F));
            this.tlpExpenseCategoty.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.60943F));
            this.tlpExpenseCategoty.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.95623F));
            this.tlpExpenseCategoty.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.86532F));
            this.tlpExpenseCategoty.Size = new System.Drawing.Size(779, 388);
            this.tlpExpenseCategoty.TabIndex = 0;
            // 
            // tlpNewExpenseCategoryHeader
            // 
            this.tlpNewExpenseCategoryHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpNewExpenseCategoryHeader.ColumnCount = 3;
            this.tlpNewExpenseCategoryHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.545455F));
            this.tlpNewExpenseCategoryHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.12121F));
            this.tlpNewExpenseCategoryHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpNewExpenseCategoryHeader.Controls.Add(this.lblNewExpensesCategoryHeader, 1, 0);
            this.tlpNewExpenseCategoryHeader.Controls.Add(this.lblCancel, 2, 0);
            this.tlpNewExpenseCategoryHeader.Location = new System.Drawing.Point(3, 3);
            this.tlpNewExpenseCategoryHeader.Name = "tlpNewExpenseCategoryHeader";
            this.tlpNewExpenseCategoryHeader.RowCount = 1;
            this.tlpNewExpenseCategoryHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpNewExpenseCategoryHeader.Size = new System.Drawing.Size(773, 72);
            this.tlpNewExpenseCategoryHeader.TabIndex = 0;
            // 
            // lblNewExpensesCategoryHeader
            // 
            this.lblNewExpensesCategoryHeader.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNewExpensesCategoryHeader.AutoSize = true;
            this.lblNewExpensesCategoryHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewExpensesCategoryHeader.Location = new System.Drawing.Point(38, 17);
            this.lblNewExpensesCategoryHeader.Name = "lblNewExpensesCategoryHeader";
            this.lblNewExpensesCategoryHeader.Size = new System.Drawing.Size(322, 38);
            this.lblNewExpensesCategoryHeader.TabIndex = 0;
            this.lblNewExpensesCategoryHeader.Text = "New Expenses Category";
            // 
            // lblCancel
            // 
            this.lblCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCancel.AutoSize = true;
            this.lblCancel.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.lblCancel.Location = new System.Drawing.Point(742, 0);
            this.lblCancel.Name = "lblCancel";
            this.lblCancel.Size = new System.Drawing.Size(28, 25);
            this.lblCancel.TabIndex = 1;
            this.lblCancel.Text = " X";
            this.lblCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCancel.Click += new System.EventHandler(this.lblCancel_Click);
            this.lblCancel.MouseEnter += new System.EventHandler(this.lblCancel_MouseEnter);
            this.lblCancel.MouseLeave += new System.EventHandler(this.lblCancel_MouseLeave);
            this.lblCancel.MouseHover += new System.EventHandler(this.lblCancel_MouseHover);
            // 
            // tlpCategoryName
            // 
            this.tlpCategoryName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpCategoryName.ColumnCount = 4;
            this.tlpCategoryName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.118881F));
            this.tlpCategoryName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.49547F));
            this.tlpCategoryName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.14877F));
            this.tlpCategoryName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.40492F));
            this.tlpCategoryName.Controls.Add(this.lblCategoryName, 1, 0);
            this.tlpCategoryName.Controls.Add(this.tlpCategoryNameSection, 2, 0);
            this.tlpCategoryName.Location = new System.Drawing.Point(3, 92);
            this.tlpCategoryName.Name = "tlpCategoryName";
            this.tlpCategoryName.RowCount = 1;
            this.tlpCategoryName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCategoryName.Size = new System.Drawing.Size(773, 101);
            this.tlpCategoryName.TabIndex = 1;
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryName.Location = new System.Drawing.Point(50, 0);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(221, 101);
            this.lblCategoryName.TabIndex = 0;
            this.lblCategoryName.Text = " Category Name :";
            // 
            // tlpCategoryNameSection
            // 
            this.tlpCategoryNameSection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpCategoryNameSection.ColumnCount = 1;
            this.tlpCategoryNameSection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCategoryNameSection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCategoryNameSection.Controls.Add(this.txtNewExpensesCategoryName, 0, 0);
            this.tlpCategoryNameSection.Controls.Add(this.txtCategoryNameErrorMessage, 0, 1);
            this.tlpCategoryNameSection.Location = new System.Drawing.Point(277, 3);
            this.tlpCategoryNameSection.Name = "tlpCategoryNameSection";
            this.tlpCategoryNameSection.RowCount = 2;
            this.tlpCategoryNameSection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpCategoryNameSection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpCategoryNameSection.Size = new System.Drawing.Size(342, 95);
            this.tlpCategoryNameSection.TabIndex = 1;
            // 
            // txtNewExpensesCategoryName
            // 
            this.txtNewExpensesCategoryName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNewExpensesCategoryName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewExpensesCategoryName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewExpensesCategoryName.Location = new System.Drawing.Point(3, 3);
            this.txtNewExpensesCategoryName.Name = "txtNewExpensesCategoryName";
            this.txtNewExpensesCategoryName.Size = new System.Drawing.Size(336, 34);
            this.txtNewExpensesCategoryName.TabIndex = 1;
            // 
            // txtCategoryNameErrorMessage
            // 
            this.txtCategoryNameErrorMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCategoryNameErrorMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtCategoryNameErrorMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCategoryNameErrorMessage.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryNameErrorMessage.Location = new System.Drawing.Point(3, 41);
            this.txtCategoryNameErrorMessage.Name = "txtCategoryNameErrorMessage";
            this.txtCategoryNameErrorMessage.ReadOnly = true;
            this.txtCategoryNameErrorMessage.Size = new System.Drawing.Size(336, 23);
            this.txtCategoryNameErrorMessage.TabIndex = 2;
            this.txtCategoryNameErrorMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tlpAddButton
            // 
            this.tlpAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpAddButton.ColumnCount = 3;
            this.tlpAddButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.52448F));
            this.tlpAddButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.75525F));
            this.tlpAddButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.895105F));
            this.tlpAddButton.Controls.Add(this.btnAdd, 1, 0);
            this.tlpAddButton.Location = new System.Drawing.Point(3, 311);
            this.tlpAddButton.Name = "tlpAddButton";
            this.tlpAddButton.RowCount = 1;
            this.tlpAddButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAddButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tlpAddButton.Size = new System.Drawing.Size(773, 74);
            this.tlpAddButton.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(585, 15);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 43);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // tlpCategory
            // 
            this.tlpCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpCategory.ColumnCount = 4;
            this.tlpCategory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.209573F));
            this.tlpCategory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.49547F));
            this.tlpCategory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.40751F));
            this.tlpCategory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.14618F));
            this.tlpCategory.Controls.Add(this.lblCategory, 1, 0);
            this.tlpCategory.Controls.Add(this.tlpCategorySection, 2, 0);
            this.tlpCategory.Location = new System.Drawing.Point(3, 199);
            this.tlpCategory.Name = "tlpCategory";
            this.tlpCategory.RowCount = 1;
            this.tlpCategory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCategory.Size = new System.Drawing.Size(773, 106);
            this.tlpCategory.TabIndex = 1;
            // 
            // lblCategory
            // 
            this.lblCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(50, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(221, 106);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = " Category :";
            // 
            // tlpCategorySection
            // 
            this.tlpCategorySection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpCategorySection.ColumnCount = 1;
            this.tlpCategorySection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCategorySection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCategorySection.Controls.Add(this.txtCategory, 0, 0);
            this.tlpCategorySection.Controls.Add(this.txtCategoryErrorMessage, 0, 1);
            this.tlpCategorySection.Location = new System.Drawing.Point(277, 3);
            this.tlpCategorySection.Name = "tlpCategorySection";
            this.tlpCategorySection.RowCount = 2;
            this.tlpCategorySection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39F));
            this.tlpCategorySection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61F));
            this.tlpCategorySection.Size = new System.Drawing.Size(344, 100);
            this.tlpCategorySection.TabIndex = 1;
            // 
            // txtCategory
            // 
            this.txtCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategory.Location = new System.Drawing.Point(3, 3);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(338, 34);
            this.txtCategory.TabIndex = 1;
            // 
            // txtCategoryErrorMessage
            // 
            this.txtCategoryErrorMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCategoryErrorMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtCategoryErrorMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCategoryErrorMessage.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryErrorMessage.Location = new System.Drawing.Point(3, 42);
            this.txtCategoryErrorMessage.Name = "txtCategoryErrorMessage";
            this.txtCategoryErrorMessage.ReadOnly = true;
            this.txtCategoryErrorMessage.Size = new System.Drawing.Size(338, 23);
            this.txtCategoryErrorMessage.TabIndex = 2;
            this.txtCategoryErrorMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmAddExpenseCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(779, 388);
            this.Controls.Add(this.tlpExpenseCategoty);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAddExpenseCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmAddExpenseCategory";
            this.tlpExpenseCategoty.ResumeLayout(false);
            this.tlpNewExpenseCategoryHeader.ResumeLayout(false);
            this.tlpNewExpenseCategoryHeader.PerformLayout();
            this.tlpCategoryName.ResumeLayout(false);
            this.tlpCategoryName.PerformLayout();
            this.tlpCategoryNameSection.ResumeLayout(false);
            this.tlpCategoryNameSection.PerformLayout();
            this.tlpAddButton.ResumeLayout(false);
            this.tlpCategory.ResumeLayout(false);
            this.tlpCategory.PerformLayout();
            this.tlpCategorySection.ResumeLayout(false);
            this.tlpCategorySection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpExpenseCategoty;
        private System.Windows.Forms.TableLayoutPanel tlpNewExpenseCategoryHeader;
        private System.Windows.Forms.Label lblNewExpensesCategoryHeader;
        private System.Windows.Forms.TableLayoutPanel tlpCategoryName;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.TextBox txtNewExpensesCategoryName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TableLayoutPanel tlpAddButton;
        private System.Windows.Forms.TableLayoutPanel tlpCategoryNameSection;
        private System.Windows.Forms.TextBox txtCategoryNameErrorMessage;
        private System.Windows.Forms.Label lblCancel;
        private System.Windows.Forms.TableLayoutPanel tlpCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TableLayoutPanel tlpCategorySection;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtCategoryErrorMessage;
    }
}