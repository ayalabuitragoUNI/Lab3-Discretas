
namespace Lab3_Discretas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LbB = new System.Windows.Forms.ListBox();
            this.BtnAddB = new System.Windows.Forms.Button();
            this.tbAddB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LbA = new System.Windows.Forms.ListBox();
            this.BtnAddA = new System.Windows.Forms.Button();
            this.tbAddA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnCleanA = new System.Windows.Forms.Button();
            this.BtnCleanB = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(623, 416);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conjuntos";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnCleanB);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.LbB);
            this.groupBox3.Controls.Add(this.BtnAddB);
            this.groupBox3.Controls.Add(this.tbAddB);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(318, 40);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(286, 359);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Conjunto B";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Elementos Agregados";
            // 
            // LbB
            // 
            this.LbB.FormattingEnabled = true;
            this.LbB.Location = new System.Drawing.Point(6, 99);
            this.LbB.Name = "LbB";
            this.LbB.Size = new System.Drawing.Size(274, 212);
            this.LbB.TabIndex = 0;
            // 
            // BtnAddB
            // 
            this.BtnAddB.Location = new System.Drawing.Point(180, 35);
            this.BtnAddB.Name = "BtnAddB";
            this.BtnAddB.Size = new System.Drawing.Size(75, 23);
            this.BtnAddB.TabIndex = 2;
            this.BtnAddB.Text = "Agregar";
            this.BtnAddB.UseVisualStyleBackColor = true;
            this.BtnAddB.Click += new System.EventHandler(this.BtnAddB_Click);
            // 
            // tbAddB
            // 
            this.tbAddB.Location = new System.Drawing.Point(64, 35);
            this.tbAddB.Name = "tbAddB";
            this.tbAddB.Size = new System.Drawing.Size(110, 20);
            this.tbAddB.TabIndex = 1;
            this.tbAddB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAddB_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Elemento";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnCleanA);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.LbA);
            this.groupBox2.Controls.Add(this.BtnAddA);
            this.groupBox2.Controls.Add(this.tbAddA);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(15, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 359);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Conjunto A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Elementos Agregados";
            // 
            // LbA
            // 
            this.LbA.FormattingEnabled = true;
            this.LbA.Location = new System.Drawing.Point(6, 99);
            this.LbA.Name = "LbA";
            this.LbA.Size = new System.Drawing.Size(274, 212);
            this.LbA.TabIndex = 0;
            // 
            // BtnAddA
            // 
            this.BtnAddA.Location = new System.Drawing.Point(180, 35);
            this.BtnAddA.Name = "BtnAddA";
            this.BtnAddA.Size = new System.Drawing.Size(75, 23);
            this.BtnAddA.TabIndex = 2;
            this.BtnAddA.Text = "Agregar";
            this.BtnAddA.UseVisualStyleBackColor = true;
            this.BtnAddA.Click += new System.EventHandler(this.BtnAddA_Click);
            // 
            // tbAddA
            // 
            this.tbAddA.Location = new System.Drawing.Point(64, 35);
            this.tbAddA.Name = "tbAddA";
            this.tbAddA.Size = new System.Drawing.Size(110, 20);
            this.tbAddA.TabIndex = 1;
            this.tbAddA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAddA_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elemento";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(248, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Producto Cartesiano";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnCleanA
            // 
            this.BtnCleanA.Location = new System.Drawing.Point(99, 317);
            this.BtnCleanA.Name = "BtnCleanA";
            this.BtnCleanA.Size = new System.Drawing.Size(75, 23);
            this.BtnCleanA.TabIndex = 4;
            this.BtnCleanA.Text = "Limpiar";
            this.BtnCleanA.UseVisualStyleBackColor = true;
            this.BtnCleanA.Click += new System.EventHandler(this.BtnCleanA_Click);
            // 
            // BtnCleanB
            // 
            this.BtnCleanB.Location = new System.Drawing.Point(99, 317);
            this.BtnCleanB.Name = "BtnCleanB";
            this.BtnCleanB.Size = new System.Drawing.Size(75, 23);
            this.BtnCleanB.TabIndex = 5;
            this.BtnCleanB.Text = "Limpiar";
            this.BtnCleanB.UseVisualStyleBackColor = true;
            this.BtnCleanB.Click += new System.EventHandler(this.BtnCleanB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 501);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Producto Cartesiano";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnAddA;
        private System.Windows.Forms.TextBox tbAddA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox LbA;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox LbB;
        private System.Windows.Forms.Button BtnAddB;
        private System.Windows.Forms.TextBox tbAddB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnCleanB;
        private System.Windows.Forms.Button BtnCleanA;
    }
}

