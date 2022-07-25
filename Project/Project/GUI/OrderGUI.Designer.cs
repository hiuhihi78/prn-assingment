
namespace Project.GUI
{
    partial class OrderGUI
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(807, 481);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(31, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(851, 496);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total:";
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(860, 533);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(132, 29);
            this.btnCheckout.TabIndex = 4;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(9, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 380);
            this.panel1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(835, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 412);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cart";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(910, 500);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(17, 20);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "0";
            // 
            // OrderGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 577);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "OrderGUI";
            this.Text = "OrderGUI";
            this.Activated += new System.EventHandler(this.OrderGUI_Activated);
            this.Load += new System.EventHandler(this.OrderGUI_Load);
            this.Click += new System.EventHandler(this.OrderGUI_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTotal;
    }
}