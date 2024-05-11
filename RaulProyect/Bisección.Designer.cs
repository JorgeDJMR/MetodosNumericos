
namespace RaulProyect
{
    partial class Bisección
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bisección));
            this.DataGridViewBiseccion = new System.Windows.Forms.DataGridView();
            this.fdex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xele = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equisu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.retroceder1 = new System.Windows.Forms.Button();
            this.resolver = new System.Windows.Forms.Button();
            this.borrar = new System.Windows.Forms.Button();
            this.textboxXl = new System.Windows.Forms.TextBox();
            this.textboxFx = new System.Windows.Forms.TextBox();
            this.textboxP = new System.Windows.Forms.TextBox();
            this.textboxEs = new System.Windows.Forms.TextBox();
            this.textboxXu = new System.Windows.Forms.TextBox();
            this.formula = new System.Windows.Forms.Label();
            this.xi = new System.Windows.Forms.Label();
            this.p = new System.Windows.Forms.Label();
            this.xu = new System.Windows.Forms.Label();
            this.es = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewBiseccion)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewBiseccion
            // 
            this.DataGridViewBiseccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewBiseccion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fdex,
            this.xele,
            this.equisu,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.DataGridViewBiseccion.Location = new System.Drawing.Point(63, 219);
            this.DataGridViewBiseccion.Name = "DataGridViewBiseccion";
            this.DataGridViewBiseccion.Size = new System.Drawing.Size(1148, 170);
            this.DataGridViewBiseccion.TabIndex = 0;
            // 
            // fdex
            // 
            this.fdex.HeaderText = "i";
            this.fdex.Name = "fdex";
            this.fdex.Width = 90;
            // 
            // xele
            // 
            this.xele.HeaderText = "Xl";
            this.xele.Name = "xele";
            this.xele.Width = 145;
            // 
            // equisu
            // 
            this.equisu.HeaderText = "Xu";
            this.equisu.Name = "equisu";
            this.equisu.Width = 145;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Xr";
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "f(Xl)";
            this.Column2.Name = "Column2";
            this.Column2.Width = 120;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "f(Xu)";
            this.Column3.Name = "Column3";
            this.Column3.Width = 120;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "f(Xr)";
            this.Column4.Name = "Column4";
            this.Column4.Width = 120;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "f(Xl)*f(Xr)";
            this.Column5.Name = "Column5";
            this.Column5.Width = 120;
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
            // retroceder1
            // 
            this.retroceder1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retroceder1.Location = new System.Drawing.Point(572, 414);
            this.retroceder1.Name = "retroceder1";
            this.retroceder1.Size = new System.Drawing.Size(122, 61);
            this.retroceder1.TabIndex = 1;
            this.retroceder1.Text = "Atras";
            this.retroceder1.UseVisualStyleBackColor = true;
            this.retroceder1.Click += new System.EventHandler(this.retroceder1_Click);
            // 
            // resolver
            // 
            this.resolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resolver.Location = new System.Drawing.Point(63, 160);
            this.resolver.Name = "resolver";
            this.resolver.Size = new System.Drawing.Size(185, 44);
            this.resolver.TabIndex = 2;
            this.resolver.Text = "Resolver";
            this.resolver.UseVisualStyleBackColor = true;
            this.resolver.Click += new System.EventHandler(this.resolver_Click);
            // 
            // borrar
            // 
            this.borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrar.Location = new System.Drawing.Point(1010, 160);
            this.borrar.Name = "borrar";
            this.borrar.Size = new System.Drawing.Size(201, 44);
            this.borrar.TabIndex = 3;
            this.borrar.Text = "Borrar";
            this.borrar.UseVisualStyleBackColor = true;
            this.borrar.Click += new System.EventHandler(this.borrar_Click);
            // 
            // textboxXl
            // 
            this.textboxXl.Location = new System.Drawing.Point(488, 176);
            this.textboxXl.Name = "textboxXl";
            this.textboxXl.Size = new System.Drawing.Size(124, 20);
            this.textboxXl.TabIndex = 4;
            // 
            // textboxFx
            // 
            this.textboxFx.Location = new System.Drawing.Point(488, 81);
            this.textboxFx.Name = "textboxFx";
            this.textboxFx.Size = new System.Drawing.Size(304, 20);
            this.textboxFx.TabIndex = 5;
            // 
            // textboxP
            // 
            this.textboxP.Location = new System.Drawing.Point(488, 127);
            this.textboxP.Name = "textboxP";
            this.textboxP.Size = new System.Drawing.Size(124, 20);
            this.textboxP.TabIndex = 6;
            // 
            // textboxEs
            // 
            this.textboxEs.Location = new System.Drawing.Point(656, 176);
            this.textboxEs.Name = "textboxEs";
            this.textboxEs.Size = new System.Drawing.Size(136, 20);
            this.textboxEs.TabIndex = 7;
            // 
            // textboxXu
            // 
            this.textboxXu.Location = new System.Drawing.Point(656, 127);
            this.textboxXu.Name = "textboxXu";
            this.textboxXu.Size = new System.Drawing.Size(136, 20);
            this.textboxXu.TabIndex = 8;
            // 
            // formula
            // 
            this.formula.AutoSize = true;
            this.formula.BackColor = System.Drawing.Color.Transparent;
            this.formula.ForeColor = System.Drawing.Color.Aqua;
            this.formula.Location = new System.Drawing.Point(455, 84);
            this.formula.Name = "formula";
            this.formula.Size = new System.Drawing.Size(26, 13);
            this.formula.TabIndex = 9;
            this.formula.Text = "F(X)";
            // 
            // xi
            // 
            this.xi.AutoSize = true;
            this.xi.BackColor = System.Drawing.Color.Transparent;
            this.xi.ForeColor = System.Drawing.Color.Aqua;
            this.xi.Location = new System.Drawing.Point(465, 179);
            this.xi.Name = "xi";
            this.xi.Size = new System.Drawing.Size(16, 13);
            this.xi.TabIndex = 11;
            this.xi.Text = "Xl";
            // 
            // p
            // 
            this.p.AutoSize = true;
            this.p.BackColor = System.Drawing.Color.Transparent;
            this.p.ForeColor = System.Drawing.Color.Aqua;
            this.p.Location = new System.Drawing.Point(467, 130);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(14, 13);
            this.p.TabIndex = 12;
            this.p.Text = "P";
            // 
            // xu
            // 
            this.xu.AutoSize = true;
            this.xu.BackColor = System.Drawing.Color.Transparent;
            this.xu.ForeColor = System.Drawing.Color.Aqua;
            this.xu.Location = new System.Drawing.Point(630, 130);
            this.xu.Name = "xu";
            this.xu.Size = new System.Drawing.Size(20, 13);
            this.xu.TabIndex = 13;
            this.xu.Text = "Xu";
            // 
            // es
            // 
            this.es.AutoSize = true;
            this.es.BackColor = System.Drawing.Color.Transparent;
            this.es.ForeColor = System.Drawing.Color.Aqua;
            this.es.Location = new System.Drawing.Point(631, 180);
            this.es.Name = "es";
            this.es.Size = new System.Drawing.Size(19, 13);
            this.es.TabIndex = 14;
            this.es.Text = "Es";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(529, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 36);
            this.label1.TabIndex = 15;
            this.label1.Text = "Metodo de bisección";
            // 
            // Bisección
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1282, 498);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.es);
            this.Controls.Add(this.xu);
            this.Controls.Add(this.p);
            this.Controls.Add(this.xi);
            this.Controls.Add(this.formula);
            this.Controls.Add(this.textboxXu);
            this.Controls.Add(this.textboxEs);
            this.Controls.Add(this.textboxP);
            this.Controls.Add(this.textboxFx);
            this.Controls.Add(this.textboxXl);
            this.Controls.Add(this.borrar);
            this.Controls.Add(this.resolver);
            this.Controls.Add(this.retroceder1);
            this.Controls.Add(this.DataGridViewBiseccion);
            this.Name = "Bisección";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Bisección_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewBiseccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewBiseccion;
        private System.Windows.Forms.Button retroceder1;
        private System.Windows.Forms.Button resolver;
        private System.Windows.Forms.Button borrar;
        private System.Windows.Forms.TextBox textboxXl;
        private System.Windows.Forms.TextBox textboxFx;
        private System.Windows.Forms.TextBox textboxP;
        private System.Windows.Forms.TextBox textboxEs;
        private System.Windows.Forms.TextBox textboxXu;
        private System.Windows.Forms.Label formula;
        private System.Windows.Forms.Label xi;
        private System.Windows.Forms.Label p;
        private System.Windows.Forms.Label xu;
        private System.Windows.Forms.Label es;
        private System.Windows.Forms.DataGridViewTextBoxColumn fdex;
        private System.Windows.Forms.DataGridViewTextBoxColumn xele;
        private System.Windows.Forms.DataGridViewTextBoxColumn equisu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label label1;
    }
}