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
            this.btninsertardetras.Location = new System.Drawing.Point(360, 71);
            this.btninsertardetras.Name = "btninsertardetras";
            this.btninsertardetras.Size = new System.Drawing.Size(147, 36);
            this.btninsertardetras.TabIndex = 0;
            this.btninsertardetras.Text = "INSERTAR DETRAS";
            this.btninsertardetras.UseVisualStyleBackColor = true;
            // 
            // eliminardetras
            // 
            this.eliminardetras.Location = new System.Drawing.Point(360, 113);
            this.eliminardetras.Name = "eliminardetras";
            this.eliminardetras.Size = new System.Drawing.Size(147, 35);
            this.eliminardetras.TabIndex = 0;
            this.eliminardetras.Text = "ELIMINAR DETRAS";
            this.eliminardetras.UseVisualStyleBackColor = true;
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
            this.btninsertardelante.Location = new System.Drawing.Point(12, 70);
            this.btninsertardelante.Name = "btninsertardelante";
            this.btninsertardelante.Size = new System.Drawing.Size(156, 37);
            this.btninsertardelante.TabIndex = 0;
            this.btninsertardelante.Text = "INSERTAR DELANTE";
            this.btninsertardelante.UseVisualStyleBackColor = true;
            // 
            // btneliminardelante
            // 
            this.btneliminardelante.Location = new System.Drawing.Point(12, 113);
            this.btneliminardelante.Name = "btneliminardelante";
            this.btneliminardelante.Size = new System.Drawing.Size(156, 35);
            this.btneliminardelante.TabIndex = 0;
            this.btneliminardelante.Text = "ELIMIINAR DELATE";
            this.btneliminardelante.UseVisualStyleBackColor = true;
            // 
            // colalista
            // 
            this.colalista.FormattingEnabled = true;
            this.colalista.Location = new System.Drawing.Point(174, 113);
            this.colalista.Name = "colalista";
            this.colalista.Size = new System.Drawing.Size(180, 173);
            this.colalista.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "DECOLA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dato";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lista Cola";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 355);
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

