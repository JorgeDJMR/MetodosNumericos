
namespace RaulProyect
{
    partial class metodoJacobi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(metodoJacobi));
            this.label1 = new System.Windows.Forms.Label();
            this.tbEs = new System.Windows.Forms.TextBox();
            this.tbEcNueva = new System.Windows.Forms.TextBox();
            this.botonCalcular = new System.Windows.Forms.Button();
            this.botonBorrar = new System.Windows.Forms.Button();
            this.lbEs = new System.Windows.Forms.Label();
            this.lbEcX = new System.Windows.Forms.Label();
            this.dgvEcuacionesGuardadas = new System.Windows.Forms.DataGridView();
            this.Expresiones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.botonEs = new System.Windows.Forms.Button();
            this.botonInsertar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEcuacionesGuardadas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(24, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Método de Jacobi ";
            // 
            // tbEs
            // 
            this.tbEs.Location = new System.Drawing.Point(138, 109);
            this.tbEs.Name = "tbEs";
            this.tbEs.Size = new System.Drawing.Size(68, 20);
            this.tbEs.TabIndex = 3;
            // 
            // tbEcNueva
            // 
            this.tbEcNueva.Location = new System.Drawing.Point(106, 80);
            this.tbEcNueva.Name = "tbEcNueva";
            this.tbEcNueva.Size = new System.Drawing.Size(100, 20);
            this.tbEcNueva.TabIndex = 3;
            // 
            // botonCalcular
            // 
            this.botonCalcular.BackColor = System.Drawing.Color.Transparent;
            this.botonCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonCalcular.Font = new System.Drawing.Font("Perpetua", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCalcular.ForeColor = System.Drawing.Color.Aqua;
            this.botonCalcular.Location = new System.Drawing.Point(118, 140);
            this.botonCalcular.Name = "botonCalcular";
            this.botonCalcular.Size = new System.Drawing.Size(76, 46);
            this.botonCalcular.TabIndex = 4;
            this.botonCalcular.Text = "Resolver";
            this.botonCalcular.UseVisualStyleBackColor = false;
            this.botonCalcular.Click += new System.EventHandler(this.botonCalcular_Click);
            // 
            // botonBorrar
            // 
            this.botonBorrar.BackColor = System.Drawing.Color.Transparent;
            this.botonBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonBorrar.Font = new System.Drawing.Font("Perpetua", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonBorrar.ForeColor = System.Drawing.Color.Aqua;
            this.botonBorrar.Location = new System.Drawing.Point(114, 354);
            this.botonBorrar.Name = "botonBorrar";
            this.botonBorrar.Size = new System.Drawing.Size(92, 65);
            this.botonBorrar.TabIndex = 4;
            this.botonBorrar.Text = "Limpiar";
            this.botonBorrar.UseVisualStyleBackColor = false;
            // 
            // lbEs
            // 
            this.lbEs.AutoSize = true;
            this.lbEs.BackColor = System.Drawing.Color.Transparent;
            this.lbEs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbEs.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEs.ForeColor = System.Drawing.Color.Aqua;
            this.lbEs.Location = new System.Drawing.Point(38, 110);
            this.lbEs.Name = "lbEs";
            this.lbEs.Size = new System.Drawing.Size(100, 13);
            this.lbEs.TabIndex = 6;
            this.lbEs.Text = "Error aproximado";
            // 
            // lbEcX
            // 
            this.lbEcX.AutoSize = true;
            this.lbEcX.BackColor = System.Drawing.Color.Transparent;
            this.lbEcX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbEcX.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEcX.ForeColor = System.Drawing.Color.Aqua;
            this.lbEcX.Location = new System.Drawing.Point(38, 80);
            this.lbEcX.Name = "lbEcX";
            this.lbEcX.Size = new System.Drawing.Size(53, 13);
            this.lbEcX.TabIndex = 6;
            this.lbEcX.Text = "Ecuación";
            // 
            // dgvEcuacionesGuardadas
            // 
            this.dgvEcuacionesGuardadas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvEcuacionesGuardadas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEcuacionesGuardadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEcuacionesGuardadas.ColumnHeadersVisible = false;
            this.dgvEcuacionesGuardadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Expresiones});
            this.dgvEcuacionesGuardadas.GridColor = System.Drawing.SystemColors.Control;
            this.dgvEcuacionesGuardadas.Location = new System.Drawing.Point(38, 192);
            this.dgvEcuacionesGuardadas.Name = "dgvEcuacionesGuardadas";
            this.dgvEcuacionesGuardadas.RowHeadersVisible = false;
            this.dgvEcuacionesGuardadas.RowHeadersWidth = 51;
            this.dgvEcuacionesGuardadas.Size = new System.Drawing.Size(240, 156);
            this.dgvEcuacionesGuardadas.TabIndex = 7;
            // 
            // Expresiones
            // 
            this.Expresiones.HeaderText = "Expresiones";
            this.Expresiones.MinimumWidth = 6;
            this.Expresiones.Name = "Expresiones";
            this.Expresiones.Width = 200;
            // 
            // botonEs
            // 
            this.botonEs.BackColor = System.Drawing.Color.Transparent;
            this.botonEs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonEs.Font = new System.Drawing.Font("Perpetua", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonEs.ForeColor = System.Drawing.Color.Aqua;
            this.botonEs.Location = new System.Drawing.Point(212, 106);
            this.botonEs.Name = "botonEs";
            this.botonEs.Size = new System.Drawing.Size(67, 26);
            this.botonEs.TabIndex = 4;
            this.botonEs.Text = "Agregar";
            this.botonEs.UseVisualStyleBackColor = false;
            this.botonEs.Click += new System.EventHandler(this.botonEs_Click);
            // 
            // botonInsertar
            // 
            this.botonInsertar.BackColor = System.Drawing.Color.Transparent;
            this.botonInsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonInsertar.Font = new System.Drawing.Font("Perpetua", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonInsertar.ForeColor = System.Drawing.Color.Aqua;
            this.botonInsertar.Location = new System.Drawing.Point(212, 76);
            this.botonInsertar.Name = "botonInsertar";
            this.botonInsertar.Size = new System.Drawing.Size(67, 26);
            this.botonInsertar.TabIndex = 4;
            this.botonInsertar.Text = "Añadir";
            this.botonInsertar.UseVisualStyleBackColor = false;
            this.botonInsertar.Click += new System.EventHandler(this.botonInsertar_Click);
            // 
            // metodoJacobi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(318, 450);
            this.Controls.Add(this.dgvEcuacionesGuardadas);
            this.Controls.Add(this.lbEcX);
            this.Controls.Add(this.lbEs);
            this.Controls.Add(this.botonInsertar);
            this.Controls.Add(this.botonEs);
            this.Controls.Add(this.botonBorrar);
            this.Controls.Add(this.botonCalcular);
            this.Controls.Add(this.tbEcNueva);
            this.Controls.Add(this.tbEs);
            this.Controls.Add(this.label1);
            this.Name = "metodoJacobi";
            this.Text = "metodoJacobi";
            this.Load += new System.EventHandler(this.metodoJacobi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEcuacionesGuardadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEs;
        private System.Windows.Forms.TextBox tbEcNueva;
        private System.Windows.Forms.Button botonBorrar;
        private System.Windows.Forms.Label lbEs;
        private System.Windows.Forms.Label lbEcX;
        private System.Windows.Forms.Button botonCalcular;
        private System.Windows.Forms.DataGridView dgvEcuacionesGuardadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expresiones;
        private System.Windows.Forms.Button botonEs;
        private System.Windows.Forms.Button botonInsertar;
    }
}