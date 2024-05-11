
namespace RaulProyect
{
    partial class Secante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Secante));
            this.es = new System.Windows.Forms.Label();
            this.xisecante = new System.Windows.Forms.Label();
            this.p = new System.Windows.Forms.Label();
            this.ximenos1 = new System.Windows.Forms.Label();
            this.formula = new System.Windows.Forms.Label();
            this.textboxXi = new System.Windows.Forms.TextBox();
            this.textboxEs = new System.Windows.Forms.TextBox();
            this.textboxP = new System.Windows.Forms.TextBox();
            this.textboxFx = new System.Windows.Forms.TextBox();
            this.textboxXimenos1 = new System.Windows.Forms.TextBox();
            this.borrar = new System.Windows.Forms.Button();
            this.resolver = new System.Windows.Forms.Button();
            this.retroceder1 = new System.Windows.Forms.Button();
            this.DataGridViewSecante = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSecante)).BeginInit();
            this.SuspendLayout();
            // 
            // es
            // 
            this.es.AutoSize = true;
            this.es.BackColor = System.Drawing.Color.Transparent;
            this.es.ForeColor = System.Drawing.Color.Aqua;
            this.es.Location = new System.Drawing.Point(172, 141);
            this.es.Name = "es";
            this.es.Size = new System.Drawing.Size(19, 13);
            this.es.TabIndex = 28;
            this.es.Text = "Es";
            // 
            // xisecante
            // 
            this.xisecante.AutoSize = true;
            this.xisecante.BackColor = System.Drawing.Color.Transparent;
            this.xisecante.ForeColor = System.Drawing.Color.Aqua;
            this.xisecante.Location = new System.Drawing.Point(170, 104);
            this.xisecante.Name = "xisecante";
            this.xisecante.Size = new System.Drawing.Size(16, 13);
            this.xisecante.TabIndex = 27;
            this.xisecante.Text = "Xi";
            // 
            // p
            // 
            this.p.AutoSize = true;
            this.p.BackColor = System.Drawing.Color.Transparent;
            this.p.ForeColor = System.Drawing.Color.Aqua;
            this.p.Location = new System.Drawing.Point(378, 144);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(14, 13);
            this.p.TabIndex = 26;
            this.p.Text = "P";
            // 
            // ximenos1
            // 
            this.ximenos1.AutoSize = true;
            this.ximenos1.BackColor = System.Drawing.Color.Transparent;
            this.ximenos1.ForeColor = System.Drawing.Color.Aqua;
            this.ximenos1.Location = new System.Drawing.Point(367, 104);
            this.ximenos1.Name = "ximenos1";
            this.ximenos1.Size = new System.Drawing.Size(25, 13);
            this.ximenos1.TabIndex = 25;
            this.ximenos1.Text = "Xi-1";
            // 
            // formula
            // 
            this.formula.AutoSize = true;
            this.formula.BackColor = System.Drawing.Color.Transparent;
            this.formula.ForeColor = System.Drawing.Color.Aqua;
            this.formula.Location = new System.Drawing.Point(164, 69);
            this.formula.Name = "formula";
            this.formula.Size = new System.Drawing.Size(26, 13);
            this.formula.TabIndex = 24;
            this.formula.Text = "F(X)";
            // 
            // textboxXi
            // 
            this.textboxXi.Location = new System.Drawing.Point(197, 101);
            this.textboxXi.Name = "textboxXi";
            this.textboxXi.Size = new System.Drawing.Size(122, 20);
            this.textboxXi.TabIndex = 23;
            // 
            // textboxEs
            // 
            this.textboxEs.Location = new System.Drawing.Point(197, 138);
            this.textboxEs.Name = "textboxEs";
            this.textboxEs.Size = new System.Drawing.Size(122, 20);
            this.textboxEs.TabIndex = 22;
            // 
            // textboxP
            // 
            this.textboxP.Location = new System.Drawing.Point(398, 141);
            this.textboxP.Name = "textboxP";
            this.textboxP.Size = new System.Drawing.Size(118, 20);
            this.textboxP.TabIndex = 21;
            // 
            // textboxFx
            // 
            this.textboxFx.Location = new System.Drawing.Point(197, 66);
            this.textboxFx.Name = "textboxFx";
            this.textboxFx.Size = new System.Drawing.Size(319, 20);
            this.textboxFx.TabIndex = 20;
            // 
            // textboxXimenos1
            // 
            this.textboxXimenos1.Location = new System.Drawing.Point(398, 101);
            this.textboxXimenos1.Name = "textboxXimenos1";
            this.textboxXimenos1.Size = new System.Drawing.Size(118, 20);
            this.textboxXimenos1.TabIndex = 19;
            // 
            // borrar
            // 
            this.borrar.BackColor = System.Drawing.Color.Aqua;
            this.borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrar.Location = new System.Drawing.Point(292, 174);
            this.borrar.Name = "borrar";
            this.borrar.Size = new System.Drawing.Size(124, 35);
            this.borrar.TabIndex = 18;
            this.borrar.Text = "Borrar";
            this.borrar.UseVisualStyleBackColor = false;
            this.borrar.Click += new System.EventHandler(this.borrar_Click);
            // 
            // resolver
            // 
            this.resolver.BackColor = System.Drawing.Color.Aqua;
            this.resolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resolver.Location = new System.Drawing.Point(26, 174);
            this.resolver.Name = "resolver";
            this.resolver.Size = new System.Drawing.Size(118, 35);
            this.resolver.TabIndex = 17;
            this.resolver.Text = "Resolver";
            this.resolver.UseVisualStyleBackColor = false;
            this.resolver.Click += new System.EventHandler(this.resolver_Click);
            // 
            // retroceder1
            // 
            this.retroceder1.BackColor = System.Drawing.Color.Aqua;
            this.retroceder1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retroceder1.Location = new System.Drawing.Point(575, 174);
            this.retroceder1.Name = "retroceder1";
            this.retroceder1.Size = new System.Drawing.Size(125, 35);
            this.retroceder1.TabIndex = 16;
            this.retroceder1.Text = "Atras";
            this.retroceder1.UseVisualStyleBackColor = false;
            this.retroceder1.Click += new System.EventHandler(this.retroceder1_Click);
            // 
            // DataGridViewSecante
            // 
            this.DataGridViewSecante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewSecante.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.DataGridViewSecante.Location = new System.Drawing.Point(26, 215);
            this.DataGridViewSecante.Name = "DataGridViewSecante";
            this.DataGridViewSecante.Size = new System.Drawing.Size(674, 170);
            this.DataGridViewSecante.TabIndex = 15;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "i";
            this.Column1.Name = "Column1";
            this.Column1.Width = 30;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Xi-1";
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Xi";
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "F(Xi-1)";
            this.Column4.Name = "Column4";
            this.Column4.Width = 120;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "F(Xi)";
            this.Column5.Name = "Column5";
            this.Column5.Width = 110;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "ERP";
            this.Column6.Name = "Column6";
            this.Column6.Width = 60;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Ea";
            this.Column7.Name = "Column7";
            this.Column7.Width = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(246, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 36);
            this.label1.TabIndex = 29;
            this.label1.Text = "Metodo de la secante";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Secante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(734, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.es);
            this.Controls.Add(this.xisecante);
            this.Controls.Add(this.p);
            this.Controls.Add(this.ximenos1);
            this.Controls.Add(this.formula);
            this.Controls.Add(this.textboxXi);
            this.Controls.Add(this.textboxEs);
            this.Controls.Add(this.textboxP);
            this.Controls.Add(this.textboxFx);
            this.Controls.Add(this.textboxXimenos1);
            this.Controls.Add(this.borrar);
            this.Controls.Add(this.resolver);
            this.Controls.Add(this.retroceder1);
            this.Controls.Add(this.DataGridViewSecante);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Secante";
            this.Text = "Secante";
            this.Load += new System.EventHandler(this.Secante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSecante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label es;
        private System.Windows.Forms.Label xisecante;
        private System.Windows.Forms.Label p;
        private System.Windows.Forms.Label ximenos1;
        private System.Windows.Forms.Label formula;
        private System.Windows.Forms.TextBox textboxXi;
        private System.Windows.Forms.TextBox textboxEs;
        private System.Windows.Forms.TextBox textboxP;
        private System.Windows.Forms.TextBox textboxFx;
        private System.Windows.Forms.TextBox textboxXimenos1;
        private System.Windows.Forms.Button borrar;
        private System.Windows.Forms.Button resolver;
        private System.Windows.Forms.Button retroceder1;
        private System.Windows.Forms.DataGridView DataGridViewSecante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}