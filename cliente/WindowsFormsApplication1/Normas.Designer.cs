namespace WindowsFormsApplication1
{
    partial class Normas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Normas));
            this.Titulo = new System.Windows.Forms.Label();
            this.texto1 = new System.Windows.Forms.Label();
            this.Siguiente = new System.Windows.Forms.Button();
            this.Atras = new System.Windows.Forms.Button();
            this.Cerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(12, 9);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(668, 38);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "Reglas del juego de Parchís";
            // 
            // texto1
            // 
            this.texto1.Font = new System.Drawing.Font("Miriam Libre", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto1.Location = new System.Drawing.Point(12, 69);
            this.texto1.Name = "texto1";
            this.texto1.Size = new System.Drawing.Size(776, 318);
            this.texto1.TabIndex = 1;
            this.texto1.Text = resources.GetString("texto1.Text");
            // 
            // Siguiente
            // 
            this.Siguiente.Location = new System.Drawing.Point(691, 390);
            this.Siguiente.Name = "Siguiente";
            this.Siguiente.Size = new System.Drawing.Size(75, 37);
            this.Siguiente.TabIndex = 2;
            this.Siguiente.Text = "Siguiente";
            this.Siguiente.UseVisualStyleBackColor = true;
            this.Siguiente.Click += new System.EventHandler(this.Siguiente_Click);
            // 
            // Atras
            // 
            this.Atras.Location = new System.Drawing.Point(41, 390);
            this.Atras.Name = "Atras";
            this.Atras.Size = new System.Drawing.Size(75, 37);
            this.Atras.TabIndex = 3;
            this.Atras.Text = "Atras";
            this.Atras.UseVisualStyleBackColor = true;
            this.Atras.Click += new System.EventHandler(this.Atras_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.Location = new System.Drawing.Point(360, 390);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(75, 37);
            this.Cerrar.TabIndex = 4;
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.UseVisualStyleBackColor = true;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // Normas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.Atras);
            this.Controls.Add(this.Siguiente);
            this.Controls.Add(this.texto1);
            this.Controls.Add(this.Titulo);
            this.Name = "Normas";
            this.Text = "Normas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label texto1;
        private System.Windows.Forms.Button Siguiente;
        private System.Windows.Forms.Button Atras;
        private System.Windows.Forms.Button Cerrar;
    }
}