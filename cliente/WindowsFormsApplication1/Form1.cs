using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class Amigos : Form
    {
        //IP:
        string Ip_EP = "147.83.117.22";
        string Ip_Prueba = "192.168.56.101";


        //Variables universales
        Socket server;
        Thread atender;

        public Amigos()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false; //No es necesario que los 
            //elementos de los formularios puedan ser accedidos desde threads 
            //diferentes a los que los crearon.
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           
        }
        private void Amigos_DataGrid(string[] res)
        {
            Amigos_dataGridView.Rows.Clear();
            int i;
            for (i = 2; i < res.Length; i++)
            {
                
                Amigos_dataGridView.Rows.Add(res[i]);
            }
        }
        private void AtenederServidor()
        {
            //try
            //{
                while (true)
                {
                    //Recibimos un mensaje del servidor y creamos un vector con su contenido
                    byte[] msg2 = new byte[80];
                    server.Receive(msg2);
                    string[] res = Encoding.ASCII.GetString(msg2).Split('/');

                    //Usamos el res[0] para averiguar quien es el destinatario del mensaje
                    int codigo = Convert.ToInt32(res[0]);
                    string r;
                    r = res[1].Split('\0')[0];

                    switch (codigo)
                    {
                        case 0: //Desconexion
                            server.Shutdown(SocketShutdown.Both);
                            server.Close();
                            atender.Abort();
                            break;
                        case 1: //Nos conectamos con un usuario existente
                            MessageBox.Show(r);
                            break;
                        case 2: //Creamos un nuevo usuario
                            MessageBox.Show(r);
                            break;
                        case 3: //Buscamos si un jugador concreto esta conectado
                            MessageBox.Show(r);
                            break;
                        case 4: //Partidas ganadas
                            MessageBox.Show(r);
                            break;
                        case 5: //Partidas jugadas
                            MessageBox.Show(r);
                            break;
                        case 6: //Lista conectados
                          Amigos_DataGrid(res);
                          break;
                        case 8: //Contador de peticiones atendidas
                            contLbl.Text = r;
                            break;
                    }
                }
            //}
            //catch
            //{
              //  MessageBox.Show("Vaya parece que ha habido un error asd");
            //}

                
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //Creamos un IPEndPoint con el ip del servidor y puerto del servidor 
            //al que deseamos conectarnos
            IPAddress direc = IPAddress.Parse(IP.Text);
            
            //PRUEBA:
            //IPEndPoint ipep = new IPEndPoint(direc, 9050);

            //PRODUCCION:
            IPEndPoint ipep = new IPEndPoint(direc, 50066);
            

            //Creamos el socket 
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp); 
            // ProtocolType.Tcp nos indica el tipo de conexion cliente-servidor con la que trabajermos
            try
            {
                server.Connect(ipep);//Intentamos conectar el socket
                this.BackColor = Color.Green;
                MessageBox.Show("Conectado");

            }
            catch (SocketException ex)
            {
                //Si hay excepcion imprimimos error y salimos del programa con return 
                MessageBox.Show("No he podido conectar con el servidor");
                return;
            }

        }

        private void CierreServidor_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
            string mensaje = "0/";
            // Enviamos al servidor el nombre tecleado
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Consulta2.Checked)
            {
                string mensaje = "5/" + nombre.Text;
                // Enviamos al servidor el nombre tecleado
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);
            }
            if (Conectado.Checked)
            {
                string mensaje = "3/" + nombre.Text;
                // Enviamos al servidor el nombre tecleado
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);
            }
            if (Consulta_3.Checked)
            {
                string mensaje = "4/" + nombre.Text + "/";
                // Enviamos al servidor el nombre tecleado
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);
            }
        }

        private void Longitud_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CierreServidor_Click_1(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
            string mensaje = "0/";
            // Enviamos al servidor el nombre tecleado
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);
        }

        private void Jugar_Click(object sender, EventArgs e)
        {
            Form partida = new Form2();
            partida.Show();
        }

        private void Normas_Click(object sender, EventArgs e)
        {
            Form normas = new Normas();
            normas.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Creamos un IPEndPoint con el ip del servidor y puerto del servidor 
            //al que deseamos conectarnos
            IPAddress direc = IPAddress.Parse(IP.Text);
            
            //PRUEBA:
            //IPEndPoint ipep = new IPEndPoint(direc, 9050);

            //PRODUCCION:
            IPEndPoint ipep = new IPEndPoint(direc, 50066);


            //Creamos el socket 
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            // ProtocolType.Tcp nos indica el tipo de conexion cliente-servidor con la que trabajermos
            try
            {
                server.Connect(ipep);//Intentamos conectar el socket
                this.BackColor = Color.Green;
                //MessageBox.Show("Conectado");

                try
                {
                    string mensaje = "1/" + Usuario_txt.Text + "/" + Contra_txt.Text;
                    MessageBox.Show(mensaje);
                    // Enviamos al servidor el nombre tecleado
                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                    server.Send(msg);
                }
                catch
                {
                    MessageBox.Show("Vaya parece que ha habido un error");
                }

            }
            catch (SocketException ex)
            {
                //Si hay excepcion imprimimos error y salimos del programa con return 
                MessageBox.Show("No he podido conectar con el servidor");
                return;
            }

            //Ponemos en marcha el thread que atiende a los mensajes del servidor
            ThreadStart ts = delegate { AtenederServidor(); };
            atender = new Thread(ts);
            atender.Start();

        
    }

        private void Mostrar_Click(object sender, EventArgs e)
        {
            //Movemos al frente el el icono de ocultar
            Ocultar.BringToFront();
            //Mostramos la contraseña
            Contra_txt.PasswordChar = '\0';
        }

        private void Ocultar_Click(object sender, EventArgs e)
        {
            //Movemos al frente el el icono de mostrar
            Mostrar.BringToFront();
            //Ocultamos la contraseña
            Contra_txt.PasswordChar = '*';
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Creamos un IPEndPoint con el ip del servidor y puerto del servidor 
            //al que deseamos conectarnos
            IPAddress direc = IPAddress.Parse(IP.Text);

            //PRUEBA:
            //IPEndPoint ipep = new IPEndPoint(direc, 9050);

            //PRODUCCION:
            IPEndPoint ipep = new IPEndPoint(direc, 50066);

            //Creamos el socket 
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            // ProtocolType.Tcp nos indica el tipo de conexion cliente-servidor con la que trabajermos
            try
            {
                server.Connect(ipep);//Intentamos conectar el socket
                this.BackColor = Color.Green;
                //MessageBox.Show("Conectado");

                try
                {
                    string mensaje = "2/" +Usuario_txt.Text + "/" + Contra_txt.Text;
                    MessageBox.Show(mensaje);
                    // Enviamos al servidor el nombre tecleado
                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                    server.Send(msg);
                }
                catch
                {
                    MessageBox.Show("Vaya parece que ha habido un error");
                }

            }
            catch (SocketException ex)
            {
                //Si hay excepcion imprimimos error y salimos del programa con return 
                MessageBox.Show("No he podido conectar con el servidor");
                return;
            }
        }

        private void N_servicios_Click(object sender, EventArgs e)
        {
            //Pedir numero de servicios realizados
            string mensaje = "8/";
            MessageBox.Show(mensaje);
            // Enviamos al servidor el nombre tecleado
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);
        }

        private void ActualizarLista_Click(object sender, EventArgs e)
        {
            string mensaje = "6/";
            MessageBox.Show(mensaje);
            // Enviamos al servidor el nombre tecleado
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
