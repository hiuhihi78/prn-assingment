
namespace Project.GUI
{
    partial class ViewOrderDetailGUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblId = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblStaff = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Detail";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.lblStaff);
            this.groupBox1.Controls.Add(this.lblAddress);
            this.groupBox1.Controls.Add(this.lblPhone);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(76, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 297);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order\'s Info";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(101, 38);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(50, 20);
            this.lblId.TabIndex = 13;
            this.lblId.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "ID:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(101, 259);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(58, 20);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "label13";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(101, 220);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(58, 20);
            this.lblDate.TabIndex = 10;
            this.lblDate.Text = "label12";
            // 
            // lblStaff
            // 
            this.lblStaff.AutoSize = true;
            this.lblStaff.Location = new System.Drawing.Point(101, 184);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(58, 20);
            this.lblStaff.TabIndex = 9;
            this.lblStaff.Text = "label11";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(101, 147);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(58, 20);
            this.lblAddress.TabIndex = 8;
            this.lblAddress.Text = "label10";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(101, 109);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(50, 20);
            this.lblPhone.TabIndex = 7;
            this.lblPhone.Text = "label9";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(101, 75);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(50, 20);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Total:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Staff:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Phone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 346);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(696, 230);
            this.dataGridView1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(330, 591);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ViewOrderDetailGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 632);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "ViewOrderDetailGUI";
            this.Text = "ViewOrderDetailGUI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblStaff;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}