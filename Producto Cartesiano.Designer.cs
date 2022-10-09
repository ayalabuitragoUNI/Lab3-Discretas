
namespace Lab3_Discretas
{
    partial class Producto_Cartesiano
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
            this.LbAxA = new System.Windows.Forms.ListBox();
            this.LbAxB = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LbBxA = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LbBxB = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "AxA";
            // 
            // LbAxA
            // 
            this.LbAxA.FormattingEnabled = true;
            this.LbAxA.Location = new System.Drawing.Point(12, 56);
            this.LbAxA.Name = "LbAxA";
            this.LbAxA.Size = new System.Drawing.Size(209, 277);
            this.LbAxA.TabIndex = 1;
            // 
            // LbAxB
            // 
            this.LbAxB.FormattingEnabled = true;
            this.LbAxB.Location = new System.Drawing.Point(258, 56);
            this.LbAxB.Name = "LbAxB";
            this.LbAxB.Size = new System.Drawing.Size(209, 277);
            this.LbAxB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "AxB";
            // 
            // LbBxA
            // 
            this.LbBxA.FormattingEnabled = true;
            this.LbBxA.Location = new System.Drawing.Point(500, 56);
            this.LbBxA.Name = "LbBxA";
            this.LbBxA.Size = new System.Drawing.Size(209, 277);
            this.LbBxA.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(579, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "BxA";
            // 
            // LbBxB
            // 
            this.LbBxB.FormattingEnabled = true;
            this.LbBxB.Location = new System.Drawing.Point(740, 56);
            this.LbBxB.Name = "LbBxB";
            this.LbBxB.Size = new System.Drawing.Size(209, 277);
            this.LbBxB.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(819, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "BxB";
            // 
            // Producto_Cartesiano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 373);
            this.Controls.Add(this.LbBxB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LbBxA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LbAxB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LbAxA);
            this.Controls.Add(this.label1);
            this.Name = "Producto_Cartesiano";
            this.Text = "Producto Cartesiano";
            this.Load += new System.EventHandler(this.Producto_Cartesiano_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox LbAxA;
        private System.Windows.Forms.ListBox LbAxB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox LbBxA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox LbBxB;
        private System.Windows.Forms.Label label4;
    }
}