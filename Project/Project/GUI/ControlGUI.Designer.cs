
namespace Project.GUI
{
    partial class ControlGUI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.panel1.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnProduct);
            this.panel1.Controls.Add(this.btnImport);
            this.panel1.Controls.Add(this.btnOrder);
            this.panel1.Controls.Add(this.btnProfile);
            this.panel1.Location = new System.Drawing.Point(24, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 550);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "History";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Location = new System.Drawing.Point(12, 186);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(196, 29);
            this.btnProduct.TabIndex = 3;
            this.btnProduct.Text = "Product Manage";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(12, 131);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(196, 29);
            this.btnImport.TabIndex = 2;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(12, 78);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(196, 29);
            this.btnOrder.TabIndex = 1;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(12, 239);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(196, 35);
            this.btnProfile.TabIndex = 0;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1242, 575);
            this.toolStripContainer1.Location = new System.Drawing.Point(249, 28);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(1242, 600);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // ControlGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1503, 630);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "ControlGUI";
            this.Text = "ControlGUI";
            this.panel1.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Button button1;
    }
}