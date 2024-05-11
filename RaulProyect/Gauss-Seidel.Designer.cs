
namespace RaulProyect
{
    partial class gaussseidel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gaussseidel));
            this.txtEcuacion = new System.Windows.Forms.Label();
            this.atras = new System.Windows.Forms.Button();
            this.borrarTodo = new System.Windows.Forms.Button();
            this.resolver = new System.Windows.Forms.Button();
            this.dtgvAñadidas = new System.Windows.Forms.DataGridView();
            this.Datos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insertarValores = new System.Windows.Forms.Button();
            this.dtgvTabla = new System.Windows.Forms.DataGridView();
            this.ecuacionDada = new System.Windows.Forms.TextBox();
            this.errorEsperado = new System.Windows.Forms.TextBox();
            this.nuevaEcuacion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.valorInicial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.limpiarDatos = new System.Windows.Forms.Button();
            this.comienzo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAñadidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEcuacion
            // 
            this.txtEcuacion.AutoSize = true;
            this.txtEcuacion.BackColor = System.Drawing.Color.Transparent;
            this.txtEcuacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtEcuacion.Location = new System.Drawing.Point(18, 40);
            this.txtEcuacion.Name = "txtEcuacion";
            this.txtEcuacion.Size = new System.Drawing.Size(52, 13);
            this.txtEcuacion.TabIndex = 13;
            this.txtEcuacion.Text = "Ecuacion";
            // 
            // atras
            // 
            this.atras.BackColor = System.Drawing.Color.Transparent;
            this.atras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.atras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.atras.Location = new System.Drawing.Point(581, 446);
            this.atras.Name = "atras";
            this.atras.Size = new System.Drawing.Size(138, 59);
            this.atras.TabIndex = 11;
            this.atras.Text = "Atras";
            this.atras.UseVisualStyleBackColor = false;
            this.atras.Click += new System.EventHandler(this.atras_Click);
            // 
            // borrarTodo
            // 
            this.borrarTodo.BackColor = System.Drawing.Color.Transparent;
            this.borrarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrarTodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.borrarTodo.Location = new System.Drawing.Point(726, 70);
            this.borrarTodo.Name = "borrarTodo";
            this.borrarTodo.Size = new System.Drawing.Size(139, 59);
            this.borrarTodo.TabIndex = 10;
            this.borrarTodo.Text = "Borrar todo";
            this.borrarTodo.UseVisualStyleBackColor = false;
            this.borrarTodo.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // resolver
            // 
            this.resolver.BackColor = System.Drawing.Color.Transparent;
            this.resolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.resolver.Location = new System.Drawing.Point(498, 70);
            this.resolver.Name = "resolver";
            this.resolver.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.resolver.Size = new System.Drawing.Size(139, 59);
            this.resolver.TabIndex = 9;
            this.resolver.Text = "Resolver";
            this.resolver.UseVisualStyleBackColor = false;
            this.resolver.Click += new System.EventHandler(this.resolver_Click);
            // 
            // dtgvAñadidas
            // 
            this.dtgvAñadidas.AllowUserToAddRows = false;
            this.dtgvAñadidas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dtgvAñadidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAñadidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Datos});
            this.dtgvAñadidas.Location = new System.Drawing.Point(21, 148);
            this.dtgvAñadidas.Name = "dtgvAñadidas";
            this.dtgvAñadidas.Size = new System.Drawing.Size(229, 199);
            this.dtgvAñadidas.TabIndex = 8;
            // 
            // Datos
            // 
            this.Datos.HeaderText = "Ecuaciones Insertadas";
            this.Datos.Name = "Datos";
            this.Datos.Width = 200;
            // 
            // insertarValores
            // 
            this.insertarValores.BackColor = System.Drawing.Color.Transparent;
            this.insertarValores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.insertarValores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertarValores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.insertarValores.Location = new System.Drawing.Point(21, 102);
            this.insertarValores.Name = "insertarValores";
            this.insertarValores.Size = new System.Drawing.Size(110, 40);
            this.insertarValores.TabIndex = 14;
            this.insertarValores.Text = "Insertar";
            this.insertarValores.UseVisualStyleBackColor = false;
            this.insertarValores.Click += new System.EventHandler(this.insertarValores_Click);
            // 
            // dtgvTabla
            // 
            this.dtgvTabla.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dtgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.comienzo});
            this.dtgvTabla.Location = new System.Drawing.Point(272, 148);
            this.dtgvTabla.Name = "dtgvTabla";
            this.dtgvTabla.Size = new System.Drawing.Size(771, 280);
            this.dtgvTabla.TabIndex = 15;
            // 
            // ecuacionDada
            // 
            this.ecuacionDada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ecuacionDada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ecuacionDada.Location = new System.Drawing.Point(76, 37);
            this.ecuacionDada.Name = "ecuacionDada";
            this.ecuacionDada.Size = new System.Drawing.Size(174, 20);
            this.ecuacionDada.TabIndex = 16;
            this.ecuacionDada.TextChanged += new System.EventHandler(this.ecuacionDada_TextChanged);
            // 
            // errorEsperado
            // 
            this.errorEsperado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.errorEsperado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.errorEsperado.Location = new System.Drawing.Point(76, 70);
            this.errorEsperado.Name = "errorEsperado";
            this.errorEsperado.Size = new System.Drawing.Size(55, 20);
            this.errorEsperado.TabIndex = 19;
            // 
            // nuevaEcuacion
            // 
            this.nuevaEcuacion.BackColor = System.Drawing.Color.Transparent;
            this.nuevaEcuacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.nuevaEcuacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nuevaEcuacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.nuevaEcuacion.Location = new System.Drawing.Point(140, 102);
            this.nuevaEcuacion.Name = "nuevaEcuacion";
            this.nuevaEcuacion.Size = new System.Drawing.Size(110, 40);
            this.nuevaEcuacion.TabIndex = 18;
            this.nuevaEcuacion.Text = "Añadir ecuación";
            this.nuevaEcuacion.UseVisualStyleBackColor = false;
            this.nuevaEcuacion.Click += new System.EventHandler(this.nuevaEcuacion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(137, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Valor inicial";
            // 
            // valorInicial
            // 
            this.valorInicial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.valorInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valorInicial.Location = new System.Drawing.Point(203, 70);
            this.valorInicial.Name = "valorInicial";
            this.valorInicial.Size = new System.Drawing.Size(47, 20);
            this.valorInicial.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(29, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "ErrorEs";
            // 
            // limpiarDatos
            // 
            this.limpiarDatos.BackColor = System.Drawing.Color.Transparent;
            this.limpiarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.limpiarDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.limpiarDatos.Location = new System.Drawing.Point(21, 356);
            this.limpiarDatos.Name = "limpiarDatos";
            this.limpiarDatos.Size = new System.Drawing.Size(229, 72);
            this.limpiarDatos.TabIndex = 22;
            this.limpiarDatos.Text = "Limpiar";
            this.limpiarDatos.UseVisualStyleBackColor = false;
            this.limpiarDatos.Click += new System.EventHandler(this.limpiarDatos_Click);
            // 
            // comienzo
            // 
            this.comienzo.HeaderText = "i";
            this.comienzo.Name = "comienzo";
            // 
            // gaussseidel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1084, 559);
            this.Controls.Add(this.limpiarDatos);
            this.Controls.Add(this.valorInicial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.errorEsperado);
            this.Controls.Add(this.nuevaEcuacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ecuacionDada);
            this.Controls.Add(this.dtgvTabla);
            this.Controls.Add(this.insertarValores);
            this.Controls.Add(this.txtEcuacion);
            this.Controls.Add(this.atras);
            this.Controls.Add(this.borrarTodo);
            this.Controls.Add(this.resolver);
            this.Controls.Add(this.dtgvAñadidas);
            this.Name = "gaussseidel";
            this.Text = "Gauss_Seidel";
            this.Load += new System.EventHandler(this.gaussseidel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAñadidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtEcuacion;
        private System.Windows.Forms.Button atras;
        private System.Windows.Forms.Button borrarTodo;
        private System.Windows.Forms.Button resolver;
        private System.Windows.Forms.DataGridView dtgvAñadidas;
        private System.Windows.Forms.Button insertarValores;
        private System.Windows.Forms.DataGridView dtgvTabla;
        private System.Windows.Forms.TextBox ecuacionDada;
        private System.Windows.Forms.TextBox errorEsperado;
        private System.Windows.Forms.Button nuevaEcuacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox valorInicial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datos;
        private System.Windows.Forms.Button limpiarDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn comienzo;
    }
}