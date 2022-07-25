
namespace Project.GUI
{
    partial class AddProductGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.numDiscount = new System.Windows.Forms.NumericUpDown();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(39, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "New product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Discount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 384);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Country";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(74, 437);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Category";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(216, 97);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(233, 27);
            this.txtName.TabIndex = 8;
            // 
            // txtDes
            // 
            this.txtDes.Location = new System.Drawing.Point(216, 146);
            this.txtDes.Multiline = true;
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(233, 66);
            this.txtDes.TabIndex = 9;
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(216, 241);
            this.numQuantity.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(150, 27);
            this.numQuantity.TabIndex = 10;
            // 
            // numPrice
            // 
            this.numPrice.Location = new System.Drawing.Point(216, 290);
            this.numPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(150, 27);
            this.numPrice.TabIndex = 11;
            // 
            // numDiscount
            // 
            this.numDiscount.Location = new System.Drawing.Point(216, 334);
            this.numDiscount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numDiscount.Name = "numDiscount";
            this.numDiscount.Size = new System.Drawing.Size(150, 27);
            this.numDiscount.TabIndex = 12;
            this.numDiscount.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(216, 384);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(233, 27);
            this.txtCountry.TabIndex = 13;
            // 
            // cboCategory
            // 
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(216, 437);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(194, 28);
            this.cboCategory.TabIndex = 14;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(416, 437);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(33, 29);
            this.btnAddCategory.TabIndex = 15;
            this.btnAddCategory.Text = "+";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(159, 517);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(316, 517);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AddProductGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 612);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.numDiscount);
            this.Controls.Add(this.numPrice);
            this.Controls.Add(this.numQuantity);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddProductGUI";
            this.Text = "AddProductGUI";
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.NumericUpDown numDiscount;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
    }
}