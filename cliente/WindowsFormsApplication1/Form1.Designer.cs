namespace WindowsFormsApplication1
{
    partial class Amigos
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Amigos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IP = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Consulta_3 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.alturaBox = new System.Windows.Forms.TextBox();
            this.Consulta2 = new System.Windows.Forms.RadioButton();
            this.Conectado = new System.Windows.Forms.RadioButton();
            this.CierreServidor = new System.Windows.Forms.Button();
            this.Jugar = new System.Windows.Forms.Button();
            this.Normas = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Ocultar = new System.Windows.Forms.PictureBox();
            this.Mostrar = new System.Windows.Forms.PictureBox();
            this.Registrarse = new System.Windows.Forms.Button();
            this.Contraseña = new System.Windows.Forms.Label();
            this.Contra_txt = new System.Windows.Forms.TextBox();
            this.Usuario = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.Usuario_txt = new System.Windows.Forms.TextBox();
            this.N_servicios = new System.Windows.Forms.Button();
            this.contLbl = new System.Windows.Forms.Label();
            this.Amigos_dataGridView = new System.Windows.Forms.DataGridView();
            this.Amigos_Conectados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.ActualizarLista = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ocultar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mostrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Amigos_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // IP
            // 
            this.IP.Location = new System.Drawing.Point(112, 64);
            this.IP.Margin = new System.Windows.Forms.Padding(4);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(172, 22);
            this.IP.TabIndex = 2;
            this.IP.Text = "147.83.117.22";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(155, 38);
            this.nombre.Margin = new System.Windows.Forms.Padding(4);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(217, 22);
            this.nombre.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(292, 59);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "conectar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(355, 203);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "Enviar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.Consulta_3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.alturaBox);
            this.groupBox1.Controls.Add(this.Consulta2);
            this.groupBox1.Controls.Add(this.Conectado);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.nombre);
            this.groupBox1.Location = new System.Drawing.Point(19, 342);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(484, 236);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Peticion";
            // 
            // Consulta_3
            // 
            this.Consulta_3.AutoSize = true;
            this.Consulta_3.Location = new System.Drawing.Point(155, 175);
            this.Consulta_3.Margin = new System.Windows.Forms.Padding(4);
            this.Consulta_3.Name = "Consulta_3";
            this.Consulta_3.Size = new System.Drawing.Size(137, 20);
            this.Consulta_3.TabIndex = 11;
            this.Consulta_3.TabStop = true;
            this.Consulta_3.Text = "Partidas Ganadas";
            this.Consulta_3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 31);
            this.label3.TabIndex = 10;
            this.label3.Text = "Altura\r\n";
            // 
            // alturaBox
            // 
            this.alturaBox.Location = new System.Drawing.Point(155, 68);
            this.alturaBox.Margin = new System.Windows.Forms.Padding(4);
            this.alturaBox.Name = "alturaBox";
            this.alturaBox.Size = new System.Drawing.Size(217, 22);
            this.alturaBox.TabIndex = 9;
            // 
            // Consulta2
            // 
            this.Consulta2.AutoSize = true;
            this.Consulta2.Location = new System.Drawing.Point(155, 147);
            this.Consulta2.Margin = new System.Windows.Forms.Padding(4);
            this.Consulta2.Name = "Consulta2";
            this.Consulta2.Size = new System.Drawing.Size(134, 20);
            this.Consulta2.TabIndex = 7;
            this.Consulta2.TabStop = true;
            this.Consulta2.Text = "Partidas Jugadas";
            this.Consulta2.UseVisualStyleBackColor = true;
            this.Consulta2.CheckedChanged += new System.EventHandler(this.Longitud_CheckedChanged);
            // 
            // Conectado
            // 
            this.Conectado.AutoSize = true;
            this.Conectado.Location = new System.Drawing.Point(155, 119);
            this.Conectado.Margin = new System.Windows.Forms.Padding(4);
            this.Conectado.Name = "Conectado";
            this.Conectado.Size = new System.Drawing.Size(129, 20);
            this.Conectado.TabIndex = 8;
            this.Conectado.TabStop = true;
            this.Conectado.Text = "Esta conectado?";
            this.Conectado.UseVisualStyleBackColor = true;
            // 
            // CierreServidor
            // 
            this.CierreServidor.Location = new System.Drawing.Point(412, 59);
            this.CierreServidor.Margin = new System.Windows.Forms.Padding(4);
            this.CierreServidor.Name = "CierreServidor";
            this.CierreServidor.Size = new System.Drawing.Size(112, 38);
            this.CierreServidor.TabIndex = 7;
            this.CierreServidor.Text = "desconectar";
            this.CierreServidor.UseVisualStyleBackColor = true;
            this.CierreServidor.Click += new System.EventHandler(this.CierreServidor_Click_1);
            // 
            // Jugar
            // 
            this.Jugar.Location = new System.Drawing.Point(863, 206);
            this.Jugar.Name = "Jugar";
            this.Jugar.Size = new System.Drawing.Size(75, 38);
            this.Jugar.TabIndex = 9;
            this.Jugar.Text = "Jugar";
            this.Jugar.UseVisualStyleBackColor = true;
            this.Jugar.Click += new System.EventHandler(this.Jugar_Click);
            // 
            // Normas
            // 
            this.Normas.Location = new System.Drawing.Point(863, 317);
            this.Normas.Name = "Normas";
            this.Normas.Size = new System.Drawing.Size(75, 40);
            this.Normas.TabIndex = 10;
            this.Normas.Text = "Normas";
            this.Normas.UseVisualStyleBackColor = true;
            this.Normas.Click += new System.EventHandler(this.Normas_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox2.Controls.Add(this.Ocultar);
            this.groupBox2.Controls.Add(this.Mostrar);
            this.groupBox2.Controls.Add(this.Registrarse);
            this.groupBox2.Controls.Add(this.Contraseña);
            this.groupBox2.Controls.Add(this.Contra_txt);
            this.groupBox2.Controls.Add(this.Usuario);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.Usuario_txt);
            this.groupBox2.Location = new System.Drawing.Point(19, 103);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(484, 236);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Log In";
            // 
            // Ocultar
            // 
            this.Ocultar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Ocultar.Image = ((System.Drawing.Image)(resources.GetObject("Ocultar.Image")));
            this.Ocultar.Location = new System.Drawing.Point(418, 62);
            this.Ocultar.Name = "Ocultar";
            this.Ocultar.Size = new System.Drawing.Size(46, 43);
            this.Ocultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Ocultar.TabIndex = 14;
            this.Ocultar.TabStop = false;
            this.Ocultar.Click += new System.EventHandler(this.Ocultar_Click);
            // 
            // Mostrar
            // 
            this.Mostrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Mostrar.Image = ((System.Drawing.Image)(resources.GetObject("Mostrar.Image")));
            this.Mostrar.Location = new System.Drawing.Point(418, 62);
            this.Mostrar.Name = "Mostrar";
            this.Mostrar.Size = new System.Drawing.Size(46, 43);
            this.Mostrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Mostrar.TabIndex = 13;
            this.Mostrar.TabStop = false;
            this.Mostrar.Click += new System.EventHandler(this.Mostrar_Click);
            // 
            // Registrarse
            // 
            this.Registrarse.Location = new System.Drawing.Point(294, 130);
            this.Registrarse.Margin = new System.Windows.Forms.Padding(4);
            this.Registrarse.Name = "Registrarse";
            this.Registrarse.Size = new System.Drawing.Size(100, 28);
            this.Registrarse.TabIndex = 11;
            this.Registrarse.Text = "Registrase";
            this.Registrarse.UseVisualStyleBackColor = true;
            this.Registrarse.Click += new System.EventHandler(this.button4_Click);
            // 
            // Contraseña
            // 
            this.Contraseña.AutoSize = true;
            this.Contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contraseña.Location = new System.Drawing.Point(31, 62);
            this.Contraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Size = new System.Drawing.Size(155, 31);
            this.Contraseña.TabIndex = 10;
            this.Contraseña.Text = "Contraseña";
            // 
            // Contra_txt
            // 
            this.Contra_txt.Location = new System.Drawing.Point(194, 68);
            this.Contra_txt.Margin = new System.Windows.Forms.Padding(4);
            this.Contra_txt.Name = "Contra_txt";
            this.Contra_txt.Size = new System.Drawing.Size(217, 22);
            this.Contra_txt.TabIndex = 9;
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario.Location = new System.Drawing.Point(31, 31);
            this.Usuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(108, 31);
            this.Usuario.TabIndex = 1;
            this.Usuario.Text = "Usuario";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(86, 130);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 5;
            this.button3.Text = "Entrar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Usuario_txt
            // 
            this.Usuario_txt.Location = new System.Drawing.Point(194, 38);
            this.Usuario_txt.Margin = new System.Windows.Forms.Padding(4);
            this.Usuario_txt.Name = "Usuario_txt";
            this.Usuario_txt.Size = new System.Drawing.Size(217, 22);
            this.Usuario_txt.TabIndex = 3;
            // 
            // N_servicios
            // 
            this.N_servicios.Location = new System.Drawing.Point(35, 632);
            this.N_servicios.Margin = new System.Windows.Forms.Padding(4);
            this.N_servicios.Name = "N_servicios";
            this.N_servicios.Size = new System.Drawing.Size(170, 28);
            this.N_servicios.TabIndex = 13;
            this.N_servicios.Text = "Cuantos Servicios";
            this.N_servicios.UseVisualStyleBackColor = true;
            this.N_servicios.Click += new System.EventHandler(this.N_servicios_Click);
            // 
            // contLbl
            // 
            this.contLbl.Font = new System.Drawing.Font("Miriam Libre", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contLbl.Location = new System.Drawing.Point(230, 635);
            this.contLbl.Name = "contLbl";
            this.contLbl.Size = new System.Drawing.Size(489, 21);
            this.contLbl.TabIndex = 14;
            this.contLbl.Text = "Resultado\r\n";
            // 
            // Amigos_dataGridView
            // 
            this.Amigos_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Amigos_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Amigos_Conectados});
            this.Amigos_dataGridView.Location = new System.Drawing.Point(553, 92);
            this.Amigos_dataGridView.Name = "Amigos_dataGridView";
            this.Amigos_dataGridView.RowHeadersWidth = 51;
            this.Amigos_dataGridView.RowTemplate.Height = 24;
            this.Amigos_dataGridView.Size = new System.Drawing.Size(240, 481);
            this.Amigos_dataGridView.TabIndex = 15;
            // 
            // Amigos_Conectados
            // 
            this.Amigos_Conectados.HeaderText = "Column1";
            this.Amigos_Conectados.MinimumWidth = 6;
            this.Amigos_Conectados.Name = "Amigos_Conectados";
            this.Amigos_Conectados.Width = 125;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Miriam Libre", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(549, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "Amigos";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ActualizarLista
            // 
            this.ActualizarLista.Location = new System.Drawing.Point(553, 592);
            this.ActualizarLista.Name = "ActualizarLista";
            this.ActualizarLista.Size = new System.Drawing.Size(75, 40);
            this.ActualizarLista.TabIndex = 17;
            this.ActualizarLista.Text = "Actualizar";
            this.ActualizarLista.UseVisualStyleBackColor = true;
            this.ActualizarLista.Click += new System.EventHandler(this.ActualizarLista_Click);
            // 
            // Amigos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 692);
            this.Controls.Add(this.ActualizarLista);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Amigos_dataGridView);
            this.Controls.Add(this.contLbl);
            this.Controls.Add(this.N_servicios);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Normas);
            this.Controls.Add(this.Jugar);
            this.Controls.Add(this.CierreServidor);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.IP);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Amigos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ocultar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mostrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Amigos_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IP;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Consulta2;
        private System.Windows.Forms.RadioButton Conectado;
        private System.Windows.Forms.TextBox alturaBox;
        private System.Windows.Forms.RadioButton Consulta_3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CierreServidor;
        private System.Windows.Forms.Button Jugar;
        private System.Windows.Forms.Button Normas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Registrarse;
        private System.Windows.Forms.Label Contraseña;
        private System.Windows.Forms.TextBox Contra_txt;
        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox Usuario_txt;
        private System.Windows.Forms.PictureBox Mostrar;
        private System.Windows.Forms.PictureBox Ocultar;
        private System.Windows.Forms.Button N_servicios;
        private System.Windows.Forms.Label contLbl;
        private System.Windows.Forms.DataGridView Amigos_dataGridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amigos_Conectados;
        private System.Windows.Forms.Button ActualizarLista;
    }
}

