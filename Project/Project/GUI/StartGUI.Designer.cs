
namespace Project.GUI
{
    partial class StartGUI
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
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(742, 335);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(45, 9);
            this.panel1.TabIndex = 0;
            // 
            // StartGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project.Properties.Resources.Untitled;
            this.ClientSize = new System.Drawing.Size(1515, 603);
            this.Controls.Add(this.panel1);
            this.Name = "StartGUI";
            this.Text = "StartGUI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
    }
}