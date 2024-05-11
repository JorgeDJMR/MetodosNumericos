
namespace RaulProyect
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.Biseccion = new System.Windows.Forms.Button();
            this.NewtonRhapson = new System.Windows.Forms.Button();
            this.Secante = new System.Windows.Forms.Button();
            this.FalsaPosicion = new System.Windows.Forms.Button();
            this.titulo = new System.Windows.Forms.Button();
            this.simple = new System.Windows.Forms.Button();
            this.okokookok = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.retroceder1 = new System.Windows.Forms.Button();
            this.ExcelCompleto = new System.Windows.Forms.Button();
            this.Reportem = new System.Windows.Forms.Button();
            this.Ejercicios = new System.Windows.Forms.Button();
            this.TareaMoment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Biseccion
            // 
            this.Biseccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Biseccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Biseccion.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Biseccion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Biseccion.Location = new System.Drawing.Point(33, 222);
            this.Biseccion.Name = "Biseccion";
            this.Biseccion.Size = new System.Drawing.Size(127, 55);
            this.Biseccion.TabIndex = 1;
            this.Biseccion.Text = "Metodo de bisección";
            this.Biseccion.UseVisualStyleBackColor = false;
            this.Biseccion.Click += new System.EventHandler(this.Biseccion_Click);
            // 
            // NewtonRhapson
            // 
            this.NewtonRhapson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.NewtonRhapson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewtonRhapson.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewtonRhapson.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NewtonRhapson.Location = new System.Drawing.Point(480, 222);
            this.NewtonRhapson.Name = "NewtonRhapson";
            this.NewtonRhapson.Size = new System.Drawing.Size(127, 55);
            this.NewtonRhapson.TabIndex = 2;
            this.NewtonRhapson.Text = "Metodo de Newton-Rhapson";
            this.NewtonRhapson.UseVisualStyleBackColor = false;
            this.NewtonRhapson.Click += new System.EventHandler(this.NewtonRhapson_Click);
            // 
            // Secante
            // 
            this.Secante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Secante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Secante.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Secante.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Secante.Location = new System.Drawing.Point(632, 222);
            this.Secante.Name = "Secante";
            this.Secante.Size = new System.Drawing.Size(119, 55);
            this.Secante.TabIndex = 4;
            this.Secante.Text = "Metodo de la secante";
            this.Secante.UseVisualStyleBackColor = false;
            this.Secante.Click += new System.EventHandler(this.Secante_Click);
            // 
            // FalsaPosicion
            // 
            this.FalsaPosicion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FalsaPosicion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FalsaPosicion.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FalsaPosicion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FalsaPosicion.Location = new System.Drawing.Point(184, 222);
            this.FalsaPosicion.Name = "FalsaPosicion";
            this.FalsaPosicion.Size = new System.Drawing.Size(127, 55);
            this.FalsaPosicion.TabIndex = 6;
            this.FalsaPosicion.Text = "Metodo de falsa posición";
            this.FalsaPosicion.UseVisualStyleBackColor = false;
            this.FalsaPosicion.Click += new System.EventHandler(this.FalsaPosicion_Click);
            // 
            // titulo
            // 
            this.titulo.BackColor = System.Drawing.Color.Aqua;
            this.titulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.titulo.Font = new System.Drawing.Font("Script MT Bold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.Color.Black;
            this.titulo.Location = new System.Drawing.Point(173, 63);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(456, 70);
            this.titulo.TabIndex = 7;
            this.titulo.Text = "Metodos Numericos";
            this.titulo.UseVisualStyleBackColor = false;
            // 
            // simple
            // 
            this.simple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.simple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.simple.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simple.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.simple.Location = new System.Drawing.Point(331, 222);
            this.simple.Name = "simple";
            this.simple.Size = new System.Drawing.Size(127, 55);
            this.simple.TabIndex = 8;
            this.simple.Text = "Metodo simple de punto fijo";
            this.simple.UseVisualStyleBackColor = false;
            this.simple.Click += new System.EventHandler(this.simple_Click);
            // 
            // okokookok
            // 
            this.okokookok.AutoSize = true;
            this.okokookok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.okokookok.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okokookok.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.okokookok.Location = new System.Drawing.Point(363, 162);
            this.okokookok.Name = "okokookok";
            this.okokookok.Size = new System.Drawing.Size(95, 28);
            this.okokookok.TabIndex = 9;
            this.okokookok.Text = "Unidad 2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(690, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(88, 92);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // retroceder1
            // 
            this.retroceder1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.retroceder1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retroceder1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retroceder1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.retroceder1.Location = new System.Drawing.Point(356, 397);
            this.retroceder1.Name = "retroceder1";
            this.retroceder1.Size = new System.Drawing.Size(90, 41);
            this.retroceder1.TabIndex = 12;
            this.retroceder1.Text = "Atras";
            this.retroceder1.UseVisualStyleBackColor = false;
            this.retroceder1.Click += new System.EventHandler(this.retroceder1_Click);
            // 
            // ExcelCompleto
            // 
            this.ExcelCompleto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ExcelCompleto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExcelCompleto.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExcelCompleto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ExcelCompleto.Location = new System.Drawing.Point(112, 293);
            this.ExcelCompleto.Name = "ExcelCompleto";
            this.ExcelCompleto.Size = new System.Drawing.Size(127, 52);
            this.ExcelCompleto.TabIndex = 13;
            this.ExcelCompleto.Text = "Excel";
            this.ExcelCompleto.UseVisualStyleBackColor = false;
            this.ExcelCompleto.Click += new System.EventHandler(this.ExcelCompleto_Click);
            // 
            // Reportem
            // 
            this.Reportem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Reportem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reportem.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reportem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Reportem.Location = new System.Drawing.Point(263, 293);
            this.Reportem.Name = "Reportem";
            this.Reportem.Size = new System.Drawing.Size(127, 52);
            this.Reportem.TabIndex = 14;
            this.Reportem.Text = "Reporte";
            this.Reportem.UseVisualStyleBackColor = false;
            this.Reportem.Click += new System.EventHandler(this.Reportem_Click);
            // 
            // Ejercicios
            // 
            this.Ejercicios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Ejercicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ejercicios.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ejercicios.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Ejercicios.Location = new System.Drawing.Point(413, 293);
            this.Ejercicios.Name = "Ejercicios";
            this.Ejercicios.Size = new System.Drawing.Size(127, 52);
            this.Ejercicios.TabIndex = 15;
            this.Ejercicios.Text = "Ejercicios";
            this.Ejercicios.UseVisualStyleBackColor = false;
            this.Ejercicios.Click += new System.EventHandler(this.Ejercicios_Click);
            // 
            // TareaMoment
            // 
            this.TareaMoment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TareaMoment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TareaMoment.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TareaMoment.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TareaMoment.Location = new System.Drawing.Point(563, 293);
            this.TareaMoment.Name = "TareaMoment";
            this.TareaMoment.Size = new System.Drawing.Size(127, 52);
            this.TareaMoment.TabIndex = 16;
            this.TareaMoment.Text = "Tarea";
            this.TareaMoment.UseVisualStyleBackColor = false;
            this.TareaMoment.Click += new System.EventHandler(this.TareaMoment_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TareaMoment);
            this.Controls.Add(this.Ejercicios);
            this.Controls.Add(this.Reportem);
            this.Controls.Add(this.ExcelCompleto);
            this.Controls.Add(this.retroceder1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.okokookok);
            this.Controls.Add(this.simple);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.FalsaPosicion);
            this.Controls.Add(this.Secante);
            this.Controls.Add(this.NewtonRhapson);
            this.Controls.Add(this.Biseccion);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "Menu";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Biseccion;
        private System.Windows.Forms.Button NewtonRhapson;
        private System.Windows.Forms.Button Secante;
        private System.Windows.Forms.Button FalsaPosicion;
        private System.Windows.Forms.Button titulo;
        private System.Windows.Forms.Button simple;
        private System.Windows.Forms.Label okokookok;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button retroceder1;
        private System.Windows.Forms.Button ExcelCompleto;
        private System.Windows.Forms.Button Reportem;
        private System.Windows.Forms.Button Ejercicios;
        private System.Windows.Forms.Button TareaMoment;
    }
}

