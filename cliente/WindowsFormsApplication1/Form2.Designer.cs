namespace WindowsFormsApplication1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.picDado2 = new System.Windows.Forms.PictureBox();
            this.picDado1 = new System.Windows.Forms.PictureBox();
            this.Tablero = new System.Windows.Forms.PictureBox();
            this.miPosicion = new System.Windows.Forms.TextBox();
            this.Mover = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picDado2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDado1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tablero)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 457);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Jugar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dados";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // picDado2
            // 
            this.picDado2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDado2.Location = new System.Drawing.Point(12, 274);
            this.picDado2.Name = "picDado2";
            this.picDado2.Size = new System.Drawing.Size(100, 100);
            this.picDado2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDado2.TabIndex = 2;
            this.picDado2.TabStop = false;
            // 
            // picDado1
            // 
            this.picDado1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDado1.Location = new System.Drawing.Point(12, 117);
            this.picDado1.Name = "picDado1";
            this.picDado1.Size = new System.Drawing.Size(100, 100);
            this.picDado1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDado1.TabIndex = 3;
            this.picDado1.TabStop = false;
            // 
            // Tablero
            // 
            this.Tablero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tablero.Image = ((System.Drawing.Image)(resources.GetObject("Tablero.Image")));
            this.Tablero.InitialImage = ((System.Drawing.Image)(resources.GetObject("Tablero.InitialImage")));
            this.Tablero.Location = new System.Drawing.Point(426, -16);
            this.Tablero.Name = "Tablero";
            this.Tablero.Size = new System.Drawing.Size(802, 802);
            this.Tablero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Tablero.TabIndex = 4;
            this.Tablero.TabStop = false;
            this.Tablero.Paint += new System.Windows.Forms.PaintEventHandler(this.Tablero_Paint);
            this.Tablero.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Tablero_MouseMove);
            // 
            // miPosicion
            // 
            this.miPosicion.Location = new System.Drawing.Point(156, 117);
            this.miPosicion.Margin = new System.Windows.Forms.Padding(4);
            this.miPosicion.Name = "miPosicion";
            this.miPosicion.Size = new System.Drawing.Size(217, 22);
            this.miPosicion.TabIndex = 5;
            // 
            // Mover
            // 
            this.Mover.Location = new System.Drawing.Point(15, 500);
            this.Mover.Name = "Mover";
            this.Mover.Size = new System.Drawing.Size(75, 37);
            this.Mover.TabIndex = 6;
            this.Mover.Text = "Mover";
            this.Mover.UseVisualStyleBackColor = true;
            this.Mover.Click += new System.EventHandler(this.Mover_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 782);
            this.Controls.Add(this.Mover);
            this.Controls.Add(this.miPosicion);
            this.Controls.Add(this.Tablero);
            this.Controls.Add(this.picDado1);
            this.Controls.Add(this.picDado2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.picDado2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDado1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tablero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picDado2;
        private System.Windows.Forms.PictureBox picDado1;
        private System.Windows.Forms.PictureBox Tablero;
        private System.Windows.Forms.TextBox miPosicion;
        private System.Windows.Forms.Button Mover;
    }
}