
namespace RaulProyect
{
    partial class MenuUnidad4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuUnidad4));
            this.btnIntNum = new System.Windows.Forms.Button();
            this.btnDif = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.atras = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.LlamarEjercicios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIntNum
            // 
            this.btnIntNum.BackColor = System.Drawing.Color.Silver;
            this.btnIntNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIntNum.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntNum.ForeColor = System.Drawing.Color.Black;
            this.btnIntNum.Location = new System.Drawing.Point(237, 124);
            this.btnIntNum.Name = "btnIntNum";
            this.btnIntNum.Size = new System.Drawing.Size(141, 42);
            this.btnIntNum.TabIndex = 4;
            this.btnIntNum.Text = "Integración";
            this.btnIntNum.UseVisualStyleBackColor = false;
            this.btnIntNum.Click += new System.EventHandler(this.btnIntNum_Click);
            // 
            // btnDif
            // 
            this.btnDif.BackColor = System.Drawing.Color.Silver;
            this.btnDif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDif.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDif.Location = new System.Drawing.Point(80, 124);
            this.btnDif.Name = "btnDif";
            this.btnDif.Size = new System.Drawing.Size(141, 42);
            this.btnDif.TabIndex = 3;
            this.btnDif.Text = "Diferenciacion";
            this.btnDif.UseVisualStyleBackColor = false;
            this.btnDif.Click += new System.EventHandler(this.btnDif_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(70, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 57);
            this.label1.TabIndex = 5;
            this.label1.Text = "¿Qué quieres hacer?";
            // 
            // atras
            // 
            this.atras.BackColor = System.Drawing.Color.Silver;
            this.atras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.atras.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atras.Location = new System.Drawing.Point(164, 241);
            this.atras.Name = "atras";
            this.atras.Size = new System.Drawing.Size(132, 36);
            this.atras.TabIndex = 11;
            this.atras.Text = "Atras";
            this.atras.UseVisualStyleBackColor = false;
            this.atras.Click += new System.EventHandler(this.atras_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(80, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 42);
            this.button2.TabIndex = 12;
            this.button2.Text = "Reporte";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LlamarEjercicios
            // 
            this.LlamarEjercicios.BackColor = System.Drawing.Color.Silver;
            this.LlamarEjercicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LlamarEjercicios.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LlamarEjercicios.Location = new System.Drawing.Point(237, 181);
            this.LlamarEjercicios.Name = "LlamarEjercicios";
            this.LlamarEjercicios.Size = new System.Drawing.Size(141, 42);
            this.LlamarEjercicios.TabIndex = 13;
            this.LlamarEjercicios.Text = "Ejercicios";
            this.LlamarEjercicios.UseVisualStyleBackColor = false;
            this.LlamarEjercicios.Click += new System.EventHandler(this.LlamarEjercicios_Click);
            // 
            // MenuUnidad4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(453, 314);
            this.Controls.Add(this.LlamarEjercicios);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.atras);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIntNum);
            this.Controls.Add(this.btnDif);
            this.Name = "MenuUnidad4";
            this.Text = "MenuUnidad4";
            this.Load += new System.EventHandler(this.MenuUnidad4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIntNum;
        private System.Windows.Forms.Button btnDif;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button atras;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button LlamarEjercicios;
    }
}