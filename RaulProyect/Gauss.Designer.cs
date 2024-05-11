
namespace RaulProyect
{
    partial class gauss
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gauss));
            this.box1 = new System.Windows.Forms.ComboBox();
            this.dtgv3 = new System.Windows.Forms.DataGridView();
            this.resolver = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.atras = new System.Windows.Forms.Button();
            this.textBoxResultados = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv3)).BeginInit();
            this.SuspendLayout();
            // 
            // box1
            // 
            this.box1.FormattingEnabled = true;
            this.box1.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5"});
            this.box1.Location = new System.Drawing.Point(268, 28);
            this.box1.Name = "box1";
            this.box1.Size = new System.Drawing.Size(206, 21);
            this.box1.TabIndex = 0;
            this.box1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // dtgv3
            // 
            this.dtgv3.AllowUserToAddRows = false;
            this.dtgv3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dtgv3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv3.Location = new System.Drawing.Point(31, 104);
            this.dtgv3.Name = "dtgv3";
            this.dtgv3.Size = new System.Drawing.Size(319, 179);
            this.dtgv3.TabIndex = 1;
            this.dtgv3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv3_CellContentClick);
            // 
            // resolver
            // 
            this.resolver.BackColor = System.Drawing.Color.Transparent;
            this.resolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.resolver.Location = new System.Drawing.Point(682, 105);
            this.resolver.Name = "resolver";
            this.resolver.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.resolver.Size = new System.Drawing.Size(117, 72);
            this.resolver.TabIndex = 2;
            this.resolver.Text = "Resolver";
            this.resolver.UseVisualStyleBackColor = false;
            this.resolver.Click += new System.EventHandler(this.resolver_Click);
            // 
            // limpiar
            // 
            this.limpiar.BackColor = System.Drawing.Color.Transparent;
            this.limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.limpiar.ForeColor = System.Drawing.Color.Fuchsia;
            this.limpiar.Location = new System.Drawing.Point(682, 211);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(117, 72);
            this.limpiar.TabIndex = 3;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = false;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // atras
            // 
            this.atras.BackColor = System.Drawing.Color.Transparent;
            this.atras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.atras.ForeColor = System.Drawing.Color.Fuchsia;
            this.atras.Location = new System.Drawing.Point(295, 298);
            this.atras.Name = "atras";
            this.atras.Size = new System.Drawing.Size(138, 51);
            this.atras.TabIndex = 4;
            this.atras.Text = "Atras";
            this.atras.UseVisualStyleBackColor = false;
            this.atras.Click += new System.EventHandler(this.atras_Click);
            // 
            // textBoxResultados
            // 
            this.textBoxResultados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.textBoxResultados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxResultados.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResultados.Location = new System.Drawing.Point(383, 105);
            this.textBoxResultados.Multiline = true;
            this.textBoxResultados.Name = "textBoxResultados";
            this.textBoxResultados.Size = new System.Drawing.Size(270, 178);
            this.textBoxResultados.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(340, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Columas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Fuchsia;
            this.label2.Location = new System.Drawing.Point(159, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tabla";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Fuchsia;
            this.label3.Location = new System.Drawing.Point(478, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "Resultados";
            // 
            // gauss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(827, 361);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxResultados);
            this.Controls.Add(this.atras);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.resolver);
            this.Controls.Add(this.dtgv3);
            this.Controls.Add(this.box1);
            this.Name = "gauss";
            this.Text = "Gauss";
            this.Load += new System.EventHandler(this.gauss_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox box1;
        private System.Windows.Forms.DataGridView dtgv3;
        private System.Windows.Forms.Button resolver;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Button atras;
        private System.Windows.Forms.TextBox textBoxResultados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}