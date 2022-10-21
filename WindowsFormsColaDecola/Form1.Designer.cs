namespace WindowsFormsColaDecola
{
    partial class Form1
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
            this.btninsertardetras = new System.Windows.Forms.Button();
            this.eliminardetras = new System.Windows.Forms.Button();
            this.txtdato = new System.Windows.Forms.TextBox();
            this.btninsertardelante = new System.Windows.Forms.Button();
            this.btneliminardelante = new System.Windows.Forms.Button();
            this.colalista = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btninsertardetras
            // 
            this.btninsertardetras.BackColor = System.Drawing.Color.Lime;
            this.btninsertardetras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninsertardetras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsertardetras.ForeColor = System.Drawing.Color.White;
            this.btninsertardetras.Location = new System.Drawing.Point(360, 71);
            this.btninsertardetras.Name = "btninsertardetras";
            this.btninsertardetras.Size = new System.Drawing.Size(147, 36);
            this.btninsertardetras.TabIndex = 0;
            this.btninsertardetras.Text = "INSERTAR DETRAS";
            this.btninsertardetras.UseVisualStyleBackColor = false;
            this.btninsertardetras.Click += new System.EventHandler(this.btninsertardetras_Click);
            // 
            // eliminardetras
            // 
            this.eliminardetras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.eliminardetras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminardetras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminardetras.ForeColor = System.Drawing.Color.White;
            this.eliminardetras.Location = new System.Drawing.Point(360, 113);
            this.eliminardetras.Name = "eliminardetras";
            this.eliminardetras.Size = new System.Drawing.Size(147, 35);
            this.eliminardetras.TabIndex = 0;
            this.eliminardetras.Text = "ELIMINAR DETRAS";
            this.eliminardetras.UseVisualStyleBackColor = false;
            this.eliminardetras.Click += new System.EventHandler(this.eliminardetras_Click);
            // 
            // txtdato
            // 
            this.txtdato.Location = new System.Drawing.Point(174, 73);
            this.txtdato.Name = "txtdato";
            this.txtdato.Size = new System.Drawing.Size(180, 20);
            this.txtdato.TabIndex = 1;
            // 
            // btninsertardelante
            // 
            this.btninsertardelante.BackColor = System.Drawing.Color.Lime;
            this.btninsertardelante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninsertardelante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsertardelante.ForeColor = System.Drawing.Color.White;
            this.btninsertardelante.Location = new System.Drawing.Point(12, 70);
            this.btninsertardelante.Name = "btninsertardelante";
            this.btninsertardelante.Size = new System.Drawing.Size(156, 37);
            this.btninsertardelante.TabIndex = 0;
            this.btninsertardelante.Text = "INSERTAR DELANTE";
            this.btninsertardelante.UseVisualStyleBackColor = false;
            this.btninsertardelante.Click += new System.EventHandler(this.btninsertardelante_Click);
            // 
            // btneliminardelante
            // 
            this.btneliminardelante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btneliminardelante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminardelante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminardelante.ForeColor = System.Drawing.Color.White;
            this.btneliminardelante.Location = new System.Drawing.Point(12, 113);
            this.btneliminardelante.Name = "btneliminardelante";
            this.btneliminardelante.Size = new System.Drawing.Size(156, 35);
            this.btneliminardelante.TabIndex = 0;
            this.btneliminardelante.Text = "ELIMIINAR DELATE";
            this.btneliminardelante.UseVisualStyleBackColor = false;
            this.btneliminardelante.Click += new System.EventHandler(this.btneliminardelante_Click);
            // 
            // colalista
            // 
            this.colalista.FormattingEnabled = true;
            this.colalista.Location = new System.Drawing.Point(174, 126);
            this.colalista.Name = "colalista";
            this.colalista.Size = new System.Drawing.Size(180, 160);
            this.colalista.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "DECOLA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dato";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(174, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lista Cola";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 300);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.colalista);
            this.Controls.Add(this.txtdato);
            this.Controls.Add(this.btneliminardelante);
            this.Controls.Add(this.btninsertardelante);
            this.Controls.Add(this.eliminardetras);
            this.Controls.Add(this.btninsertardetras);
            this.Name = "Form1";
            this.Text = "DECOLA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btninsertardetras;
        private System.Windows.Forms.Button eliminardetras;
        private System.Windows.Forms.TextBox txtdato;
        private System.Windows.Forms.Button btninsertardelante;
        private System.Windows.Forms.Button btneliminardelante;
        private System.Windows.Forms.ListBox colalista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

