
namespace RaulProyect
{
    partial class Diferenciación
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Diferenciación));
            this.btnIntNum = new System.Windows.Forms.Button();
            this.btnDif = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.atras = new System.Windows.Forms.Button();
            this.excelDif = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIntNum
            // 
            this.btnIntNum.BackColor = System.Drawing.Color.Silver;
            this.btnIntNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIntNum.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntNum.ForeColor = System.Drawing.Color.Black;
            this.btnIntNum.Location = new System.Drawing.Point(73, 361);
            this.btnIntNum.Name = "btnIntNum";
            this.btnIntNum.Size = new System.Drawing.Size(227, 79);
            this.btnIntNum.TabIndex = 6;
            this.btnIntNum.Text = "Diferencias finitas hacia atras";
            this.btnIntNum.UseVisualStyleBackColor = false;
            this.btnIntNum.Click += new System.EventHandler(this.btnIntNum_Click);
            // 
            // btnDif
            // 
            this.btnDif.BackColor = System.Drawing.Color.Silver;
            this.btnDif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDif.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDif.Location = new System.Drawing.Point(73, 148);
            this.btnDif.Name = "btnDif";
            this.btnDif.Size = new System.Drawing.Size(227, 79);
            this.btnDif.TabIndex = 5;
            this.btnDif.Text = "Diferencias finitas hacia delante";
            this.btnDif.UseVisualStyleBackColor = false;
            this.btnDif.Click += new System.EventHandler(this.btnDif_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(73, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(227, 79);
            this.button2.TabIndex = 7;
            this.button2.Text = "Diferencias finitas centrales";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 57);
            this.label1.TabIndex = 9;
            this.label1.Text = "¿Qué quieres hacer?";
            // 
            // atras
            // 
            this.atras.BackColor = System.Drawing.Color.Silver;
            this.atras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.atras.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atras.Location = new System.Drawing.Point(122, 536);
            this.atras.Name = "atras";
            this.atras.Size = new System.Drawing.Size(132, 36);
            this.atras.TabIndex = 10;
            this.atras.Text = "Atras";
            this.atras.UseVisualStyleBackColor = false;
            this.atras.Click += new System.EventHandler(this.atras_Click);
            // 
            // excelDif
            // 
            this.excelDif.BackColor = System.Drawing.Color.Silver;
            this.excelDif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excelDif.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excelDif.ForeColor = System.Drawing.Color.Black;
            this.excelDif.Location = new System.Drawing.Point(73, 460);
            this.excelDif.Name = "excelDif";
            this.excelDif.Size = new System.Drawing.Size(227, 46);
            this.excelDif.TabIndex = 11;
            this.excelDif.Text = "Excel";
            this.excelDif.UseVisualStyleBackColor = false;
            this.excelDif.Click += new System.EventHandler(this.excelDif_Click);
            // 
            // Diferenciación
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(370, 584);
            this.Controls.Add(this.excelDif);
            this.Controls.Add(this.atras);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnIntNum);
            this.Controls.Add(this.btnDif);
            this.Name = "Diferenciación";
            this.Text = "Diferenciación";
            this.Load += new System.EventHandler(this.Diferenciación_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIntNum;
        private System.Windows.Forms.Button btnDif;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button atras;
        private System.Windows.Forms.Button excelDif;
    }
}