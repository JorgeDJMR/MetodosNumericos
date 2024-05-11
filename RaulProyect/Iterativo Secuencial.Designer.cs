
namespace RaulProyect
{
    partial class iterativosecuencial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(iterativosecuencial));
            this.atras = new System.Windows.Forms.Button();
            this.dgv_Ecua = new System.Windows.Forms.DataGridView();
            this.Expresiones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbEs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.tbValorIn = new System.Windows.Forms.TextBox();
            this.resolverEcuaciones = new System.Windows.Forms.Button();
            this.agregarNuevaEcuacion = new System.Windows.Forms.Button();
            this.aña = new System.Windows.Forms.Button();
            this.lbEcuacion = new System.Windows.Forms.Label();
            this.tbEcuaciones = new System.Windows.Forms.TextBox();
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.i = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ecua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // atras
            // 
            this.atras.BackColor = System.Drawing.Color.Red;
            this.atras.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.atras.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atras.Location = new System.Drawing.Point(229, 544);
            this.atras.Name = "atras";
            this.atras.Size = new System.Drawing.Size(164, 53);
            this.atras.TabIndex = 50;
            this.atras.Text = "Atras";
            this.atras.UseVisualStyleBackColor = false;
            this.atras.Click += new System.EventHandler(this.atras_Click);
            // 
            // dgv_Ecua
            // 
            this.dgv_Ecua.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgv_Ecua.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Ecua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Ecua.ColumnHeadersVisible = false;
            this.dgv_Ecua.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Expresiones});
            this.dgv_Ecua.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_Ecua.Location = new System.Drawing.Point(210, 142);
            this.dgv_Ecua.Name = "dgv_Ecua";
            this.dgv_Ecua.RowHeadersVisible = false;
            this.dgv_Ecua.Size = new System.Drawing.Size(204, 143);
            this.dgv_Ecua.TabIndex = 48;
            // 
            // Expresiones
            // 
            this.Expresiones.HeaderText = "Expresiones";
            this.Expresiones.Name = "Expresiones";
            this.Expresiones.Width = 200;
            // 
            // tbEs
            // 
            this.tbEs.BackColor = System.Drawing.Color.Red;
            this.tbEs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEs.Location = new System.Drawing.Point(179, 13);
            this.tbEs.Name = "tbEs";
            this.tbEs.Size = new System.Drawing.Size(251, 13);
            this.tbEs.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(138, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Es:";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.BackColor = System.Drawing.Color.Transparent;
            this.lb2.ForeColor = System.Drawing.Color.Red;
            this.lb2.Location = new System.Drawing.Point(96, 82);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(64, 13);
            this.lb2.TabIndex = 45;
            this.lb2.Text = "Valor Inicial ";
            // 
            // tbValorIn
            // 
            this.tbValorIn.BackColor = System.Drawing.Color.Red;
            this.tbValorIn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbValorIn.Location = new System.Drawing.Point(179, 82);
            this.tbValorIn.Name = "tbValorIn";
            this.tbValorIn.Size = new System.Drawing.Size(251, 13);
            this.tbValorIn.TabIndex = 44;
            // 
            // resolverEcuaciones
            // 
            this.resolverEcuaciones.BackColor = System.Drawing.Color.Red;
            this.resolverEcuaciones.Enabled = false;
            this.resolverEcuaciones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resolverEcuaciones.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resolverEcuaciones.Location = new System.Drawing.Point(445, 142);
            this.resolverEcuaciones.Name = "resolverEcuaciones";
            this.resolverEcuaciones.Size = new System.Drawing.Size(82, 143);
            this.resolverEcuaciones.TabIndex = 43;
            this.resolverEcuaciones.Text = "Resultados";
            this.resolverEcuaciones.UseVisualStyleBackColor = false;
            this.resolverEcuaciones.Click += new System.EventHandler(this.resolverEcuaciones_Click);
            // 
            // agregarNuevaEcuacion
            // 
            this.agregarNuevaEcuacion.BackColor = System.Drawing.Color.Red;
            this.agregarNuevaEcuacion.Enabled = false;
            this.agregarNuevaEcuacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.agregarNuevaEcuacion.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarNuevaEcuacion.Location = new System.Drawing.Point(445, 13);
            this.agregarNuevaEcuacion.Name = "agregarNuevaEcuacion";
            this.agregarNuevaEcuacion.Size = new System.Drawing.Size(82, 89);
            this.agregarNuevaEcuacion.TabIndex = 42;
            this.agregarNuevaEcuacion.Text = "Agregar ecuación";
            this.agregarNuevaEcuacion.UseVisualStyleBackColor = false;
            this.agregarNuevaEcuacion.Click += new System.EventHandler(this.agregarNuevaEcuacion_Click);
            // 
            // aña
            // 
            this.aña.BackColor = System.Drawing.Color.Red;
            this.aña.Enabled = false;
            this.aña.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.aña.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aña.Location = new System.Drawing.Point(99, 142);
            this.aña.Name = "aña";
            this.aña.Size = new System.Drawing.Size(75, 143);
            this.aña.TabIndex = 41;
            this.aña.Text = "Añadir\r\n";
            this.aña.UseVisualStyleBackColor = false;
            this.aña.Click += new System.EventHandler(this.aña_Click);
            // 
            // lbEcuacion
            // 
            this.lbEcuacion.AutoSize = true;
            this.lbEcuacion.BackColor = System.Drawing.Color.Transparent;
            this.lbEcuacion.ForeColor = System.Drawing.Color.Red;
            this.lbEcuacion.Location = new System.Drawing.Point(108, 46);
            this.lbEcuacion.Name = "lbEcuacion";
            this.lbEcuacion.Size = new System.Drawing.Size(52, 13);
            this.lbEcuacion.TabIndex = 40;
            this.lbEcuacion.Text = "Ecuación";
            // 
            // tbEcuaciones
            // 
            this.tbEcuaciones.BackColor = System.Drawing.Color.Red;
            this.tbEcuaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEcuaciones.Location = new System.Drawing.Point(179, 46);
            this.tbEcuaciones.Name = "tbEcuaciones";
            this.tbEcuaciones.Size = new System.Drawing.Size(251, 13);
            this.tbEcuaciones.TabIndex = 39;
            this.tbEcuaciones.TextChanged += new System.EventHandler(this.tbEcuaciones_TextChanged);
            // 
            // dgvTabla
            // 
            this.dgvTabla.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.i});
            this.dgvTabla.Location = new System.Drawing.Point(32, 301);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.Size = new System.Drawing.Size(563, 237);
            this.dgvTabla.TabIndex = 38;
            // 
            // i
            // 
            this.i.HeaderText = "i";
            this.i.Name = "i";
            // 
            // iterativosecuencial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(624, 627);
            this.Controls.Add(this.atras);
            this.Controls.Add(this.dgv_Ecua);
            this.Controls.Add(this.tbEs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.tbValorIn);
            this.Controls.Add(this.resolverEcuaciones);
            this.Controls.Add(this.agregarNuevaEcuacion);
            this.Controls.Add(this.aña);
            this.Controls.Add(this.lbEcuacion);
            this.Controls.Add(this.tbEcuaciones);
            this.Controls.Add(this.dgvTabla);
            this.Name = "iterativosecuencial";
            this.Text = "Iterativo_Secuencial";
            this.Load += new System.EventHandler(this.iterativosecuencial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ecua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button atras;
        private System.Windows.Forms.DataGridView dgv_Ecua;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expresiones;
        private System.Windows.Forms.TextBox tbEs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.TextBox tbValorIn;
        private System.Windows.Forms.Button resolverEcuaciones;
        private System.Windows.Forms.Button agregarNuevaEcuacion;
        private System.Windows.Forms.Button aña;
        private System.Windows.Forms.Label lbEcuacion;
        private System.Windows.Forms.TextBox tbEcuaciones;
        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn i;
    }
}