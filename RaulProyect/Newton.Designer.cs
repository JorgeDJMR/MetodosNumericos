
namespace RaulProyect
{
    partial class Newton
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Newton));
            this.label1 = new System.Windows.Forms.Label();
            this.es = new System.Windows.Forms.Label();
            this.fdexderivada = new System.Windows.Forms.Label();
            this.p = new System.Windows.Forms.Label();
            this.xx = new System.Windows.Forms.Label();
            this.formula = new System.Windows.Forms.Label();
            this.textboxDFx = new System.Windows.Forms.TextBox();
            this.textboxEs = new System.Windows.Forms.TextBox();
            this.textboxP = new System.Windows.Forms.TextBox();
            this.textboxFx = new System.Windows.Forms.TextBox();
            this.textboxX = new System.Windows.Forms.TextBox();
            this.borrar = new System.Windows.Forms.Button();
            this.resolver = new System.Windows.Forms.Button();
            this.retroceder1 = new System.Windows.Forms.Button();
            this.DataGridViewGuapo = new System.Windows.Forms.DataGridView();
            this.fdex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewGuapo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(171, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 36);
            this.label1.TabIndex = 30;
            this.label1.Text = "Metodo de Newton - Rhapson";
            // 
            // es
            // 
            this.es.AutoSize = true;
            this.es.BackColor = System.Drawing.Color.Transparent;
            this.es.ForeColor = System.Drawing.Color.Aqua;
            this.es.Location = new System.Drawing.Point(163, 253);
            this.es.Name = "es";
            this.es.Size = new System.Drawing.Size(19, 13);
            this.es.TabIndex = 29;
            this.es.Text = "Es";
            // 
            // fdexderivada
            // 
            this.fdexderivada.AutoSize = true;
            this.fdexderivada.BackColor = System.Drawing.Color.Transparent;
            this.fdexderivada.ForeColor = System.Drawing.Color.Aqua;
            this.fdexderivada.Location = new System.Drawing.Point(154, 132);
            this.fdexderivada.Name = "fdexderivada";
            this.fdexderivada.Size = new System.Drawing.Size(28, 13);
            this.fdexderivada.TabIndex = 28;
            this.fdexderivada.Text = "F\'(X)";
            // 
            // p
            // 
            this.p.AutoSize = true;
            this.p.BackColor = System.Drawing.Color.Transparent;
            this.p.ForeColor = System.Drawing.Color.Aqua;
            this.p.Location = new System.Drawing.Point(167, 212);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(14, 13);
            this.p.TabIndex = 27;
            this.p.Text = "P";
            // 
            // xx
            // 
            this.xx.AutoSize = true;
            this.xx.BackColor = System.Drawing.Color.Transparent;
            this.xx.ForeColor = System.Drawing.Color.Aqua;
            this.xx.Location = new System.Drawing.Point(165, 172);
            this.xx.Name = "xx";
            this.xx.Size = new System.Drawing.Size(14, 13);
            this.xx.TabIndex = 26;
            this.xx.Text = "X";
            // 
            // formula
            // 
            this.formula.AutoSize = true;
            this.formula.BackColor = System.Drawing.Color.Transparent;
            this.formula.ForeColor = System.Drawing.Color.Aqua;
            this.formula.Location = new System.Drawing.Point(155, 91);
            this.formula.Name = "formula";
            this.formula.Size = new System.Drawing.Size(26, 13);
            this.formula.TabIndex = 25;
            this.formula.Text = "F(X)";
            // 
            // textboxDFx
            // 
            this.textboxDFx.Location = new System.Drawing.Point(188, 129);
            this.textboxDFx.Name = "textboxDFx";
            this.textboxDFx.Size = new System.Drawing.Size(304, 20);
            this.textboxDFx.TabIndex = 24;
            // 
            // textboxEs
            // 
            this.textboxEs.Location = new System.Drawing.Point(188, 249);
            this.textboxEs.Name = "textboxEs";
            this.textboxEs.Size = new System.Drawing.Size(304, 20);
            this.textboxEs.TabIndex = 23;
            // 
            // textboxP
            // 
            this.textboxP.Location = new System.Drawing.Point(188, 209);
            this.textboxP.Name = "textboxP";
            this.textboxP.Size = new System.Drawing.Size(304, 20);
            this.textboxP.TabIndex = 22;
            // 
            // textboxFx
            // 
            this.textboxFx.Location = new System.Drawing.Point(188, 88);
            this.textboxFx.Name = "textboxFx";
            this.textboxFx.Size = new System.Drawing.Size(304, 20);
            this.textboxFx.TabIndex = 21;
            // 
            // textboxX
            // 
            this.textboxX.Location = new System.Drawing.Point(188, 169);
            this.textboxX.Name = "textboxX";
            this.textboxX.Size = new System.Drawing.Size(304, 20);
            this.textboxX.TabIndex = 20;
            // 
            // borrar
            // 
            this.borrar.BackColor = System.Drawing.Color.Aqua;
            this.borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrar.Location = new System.Drawing.Point(332, 287);
            this.borrar.Name = "borrar";
            this.borrar.Size = new System.Drawing.Size(201, 44);
            this.borrar.TabIndex = 19;
            this.borrar.Text = "Borrar";
            this.borrar.UseVisualStyleBackColor = false;
            this.borrar.Click += new System.EventHandler(this.borrar_Click);
            // 
            // resolver
            // 
            this.resolver.BackColor = System.Drawing.Color.Aqua;
            this.resolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resolver.Location = new System.Drawing.Point(119, 287);
            this.resolver.Name = "resolver";
            this.resolver.Size = new System.Drawing.Size(207, 44);
            this.resolver.TabIndex = 18;
            this.resolver.Text = "Resolver";
            this.resolver.UseVisualStyleBackColor = false;
            this.resolver.Click += new System.EventHandler(this.resolver_Click);
            // 
            // retroceder1
            // 
            this.retroceder1.BackColor = System.Drawing.Color.Aqua;
            this.retroceder1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retroceder1.Location = new System.Drawing.Point(265, 594);
            this.retroceder1.Name = "retroceder1";
            this.retroceder1.Size = new System.Drawing.Size(122, 61);
            this.retroceder1.TabIndex = 17;
            this.retroceder1.Text = "Atras";
            this.retroceder1.UseVisualStyleBackColor = false;
            this.retroceder1.Click += new System.EventHandler(this.retroceder1_Click);
            // 
            // DataGridViewGuapo
            // 
            this.DataGridViewGuapo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewGuapo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fdex,
            this.Column1,
            this.Column6,
            this.Column7});
            this.DataGridViewGuapo.Location = new System.Drawing.Point(32, 352);
            this.DataGridViewGuapo.Name = "DataGridViewGuapo";
            this.DataGridViewGuapo.Size = new System.Drawing.Size(588, 223);
            this.DataGridViewGuapo.TabIndex = 16;
            // 
            // fdex
            // 
            this.fdex.HeaderText = "i";
            this.fdex.Name = "fdex";
            this.fdex.Width = 90;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Xi";
            this.Column1.Name = "Column1";
            this.Column1.Width = 160;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "ERP";
            this.Column6.Name = "Column6";
            this.Column6.Width = 150;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Ea";
            this.Column7.Name = "Column7";
            this.Column7.Width = 150;
            // 
            // Newton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(652, 698);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.es);
            this.Controls.Add(this.fdexderivada);
            this.Controls.Add(this.p);
            this.Controls.Add(this.xx);
            this.Controls.Add(this.formula);
            this.Controls.Add(this.textboxDFx);
            this.Controls.Add(this.textboxEs);
            this.Controls.Add(this.textboxP);
            this.Controls.Add(this.textboxFx);
            this.Controls.Add(this.textboxX);
            this.Controls.Add(this.borrar);
            this.Controls.Add(this.resolver);
            this.Controls.Add(this.retroceder1);
            this.Controls.Add(this.DataGridViewGuapo);
            this.Name = "Newton";
            this.Text = "Newton";
            this.Load += new System.EventHandler(this.Newton_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewGuapo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label es;
        private System.Windows.Forms.Label fdexderivada;
        private System.Windows.Forms.Label p;
        private System.Windows.Forms.Label xx;
        private System.Windows.Forms.Label formula;
        private System.Windows.Forms.TextBox textboxDFx;
        private System.Windows.Forms.TextBox textboxEs;
        private System.Windows.Forms.TextBox textboxP;
        private System.Windows.Forms.TextBox textboxFx;
        private System.Windows.Forms.TextBox textboxX;
        private System.Windows.Forms.Button borrar;
        private System.Windows.Forms.Button resolver;
        private System.Windows.Forms.Button retroceder1;
        private System.Windows.Forms.DataGridView DataGridViewGuapo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fdex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}