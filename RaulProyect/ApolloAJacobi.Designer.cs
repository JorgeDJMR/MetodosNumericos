
namespace RaulProyect
{
    partial class ApolloJacobi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApolloJacobi));
            this.dgvRealizarCalcs = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.botonRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRealizarCalcs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRealizarCalcs
            // 
            this.dgvRealizarCalcs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRealizarCalcs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvRealizarCalcs.Location = new System.Drawing.Point(16, 60);
            this.dgvRealizarCalcs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvRealizarCalcs.Name = "dgvRealizarCalcs";
            this.dgvRealizarCalcs.RowHeadersVisible = false;
            this.dgvRealizarCalcs.RowHeadersWidth = 51;
            this.dgvRealizarCalcs.Size = new System.Drawing.Size(1035, 394);
            this.dgvRealizarCalcs.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "i";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // botonRegresar
            // 
            this.botonRegresar.BackColor = System.Drawing.Color.Transparent;
            this.botonRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRegresar.Font = new System.Drawing.Font("Perpetua", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonRegresar.ForeColor = System.Drawing.Color.Aqua;
            this.botonRegresar.Location = new System.Drawing.Point(386, 482);
            this.botonRegresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botonRegresar.Name = "botonRegresar";
            this.botonRegresar.Size = new System.Drawing.Size(242, 49);
            this.botonRegresar.TabIndex = 5;
            this.botonRegresar.Text = "Regresar";
            this.botonRegresar.UseVisualStyleBackColor = false;

            // 
            // ResolucionMetodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.botonRegresar);
            this.Controls.Add(this.dgvRealizarCalcs);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ResolucionMetodos";
            this.Text = "ResolucionMetodos";
            this.Load += new System.EventHandler(this.ResolucionMetodos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRealizarCalcs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRealizarCalcs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button botonRegresar;
    }
}