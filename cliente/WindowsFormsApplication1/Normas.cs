using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Normas : Form
    {
        int cont;
        string t1;
        string t2;
        string t3;
        string t4;
        string t5;
        string t6;
        string t7;
        string t8;
        string t9;
        string t10;

        string mensaje;

        public Normas()
        {
            InitializeComponent();
        }

        private void Normas_Load(object sender, EventArgs e)
        {
            cont = 0;
        }
        
        private void Siguiente_Click(object sender, EventArgs e)
        {
            cont++;
            if (cont == 1)
            {
                Titulo.Text = "Tablero, dados y fichas";
                t1 = "Tradicionalmente en el parchís participan 4 jugadores, cada uno de ellos utilizando un color diferente: amarillo, azul, rojo y verde. " +
                    "Se emplean 4 fichas de cada color, y cada jugador utiliza un dado.";
                t2 = "El tablero de parchís tiene varias zonas diferenciadas:";
                t3 = "Zonas de salida o casas, situadas en las esquinas del tablero, de los cuatro colores.";
                t4 = "Un recorrido común de 68 casillas por el que avanzan todas las fichas.";
                t5 = "Pasillo y casilla final de los 4 colores, que convergen en el centro del tablero desde    los cuatro laterales.";

                mensaje = string.Format("{1}{0}{0}  {2}{0}  {3}{0}  {4}{0}  {5}{0}",Environment.NewLine,t1,t2,t3,t4,t5);
                texto1.Text = mensaje;
            }   
            if (cont == 2)
            {
                Titulo.Text = "Movimiento de las ficha";
                t1 = "Inicialmente cada jugador tiene un par de fichas en la casilla inicial del recorrido, y el resto de fichas situadas en casa.";
                t2 = "Los participantes en su turno deben tirar el dado y avanzar con una de sus fichas el número de casillas indicado por el número " +
                    "obtenido, teniendo en cuenta las    siguientes reglas:";
                t3 = "En caso de tirar un 5 y tener fichas en casa, una de ellas entra en juego    obligatoriamente situándose en la casilla de salida.";
                t4 = "Las fichas avanzan siguiendo el recorrido en sentido inverso a las agujas del reloj.";
                t5 = "Cuando una ficha completa una vuelta al tablero y llega a la casilla que conecta con    el pasillo de su color, se desvía hacia la" +
                    " casilla destino (hacia el centro del tablero).";
                t6 = "En caso de tirar un 6 y tener todas las fichas del mismo color fuera de casa, se    avanzan 7 casillas.";
                t7 = "El jugador que ha obtenido un 6 juega de nuevo.";

                mensaje = string.Format("{1}{0}{0}  {2}{0}  {3}{0}  {4}{0}  {5}{0}  {6}{0}  {7}{0}", Environment.NewLine, t1, t2, t3, t4, t5, t6, t7);
                texto1.Text = mensaje;
            }
            if (cont == 3)
            {
                Titulo.Text = "Movimiento de las ficha II";
                t1 = "En cada casilla del recorrido puede haber un máximo de dos fichas. Una ficha no puede jugarse si el movimiento le llevara a una " +
                    "casilla en la que ya hay dos fichas.";
                t2 = "Una ficha no puede moverse si para completar el avance tuviera que atravesar una barrera. Las barreras son pares de fichas de un mismo" +
                    " color situadas en la misma casilla.";
                t3 = "Para alcanzar el final del recorrido es necesario avanzar el número exacto de casillas que restan hasta completarlo. No es posible " +
                    "mover la ficha si el número del dado es superior.";
                t4 = "Cuando una ficha completa su recorrido, el jugador debe avanzar 10 casillas con otra de sus fichas";
                t5 = "Puede darse el caso de que todas las fichas estén bloqueadas (por estar en casa, o tras una barrera, o en el final del recorrido). " +
                    "En este caso, simplemente no se realiza ningún movimiento.";
                

                mensaje = string.Format("  {1}{0}{0}  {2}{0}  {3}{0}  {4}{0}  {5}{0}", Environment.NewLine, t1, t2, t3, t4, t5);
                texto1.Text = mensaje;
            }
            if (cont == 4)
            {
                Titulo.Text = "Capturas";
                t1 = "Una ficha come a otra de diferente color si finaliza su avance en la casilla ocupada por esta última.";
                t2 = "Las casillas de salida y las casillas marcadas con un círculo son seguros, donde las capturas no son posibles. Por tanto, en los seguros" +
                    " pueden coincidir dos fichas de diferente color.";
                t3 = "Si en la casilla de salida se encuentran dos fichas de diferente color y una nueva ficha sale de su casa, la ficha de diferente color (o si" +
                    " ambas lo son, la última ficha que hubiera llegado a la casilla) resulta capturada.";
                t4 = "Las fichas comidas vuelven a su casa, de manera que vuelven a entrar en juego cuando el jugador obtiene un 5 en su tirada.";
                t5 = "Quien come una ficha tiene el premio de avanzar 20 casillas con cualquiera de sus fichas.";
                

                mensaje = string.Format("{1}{0}{0}  {2}{0}  {3}{0}  {4}{0}  {5}{0}", Environment.NewLine, t1, t2, t3, t4, t5);
                texto1.Text = mensaje;
            }

            if (cont == 5)
            {
                Titulo.Text = "Capturas II";
                t1 = " Si un jugador obtiene un 6 tres veces consecutivas, el tercer movimiento no se realiza, y la ficha movida con el segundo 6 vuelve a su casa, " +
                    "salvo que ya hubiese alcanzado el pasillo final del recorrido.";


                mensaje = string.Format("{1}", Environment.NewLine, t1);
                texto1.Text = mensaje;
            }
            if (cont == 6)
            {
                Titulo.Text = "Como jugar";
                t1 = "Norma 1";
                t2 = "Norma 2";
                t3 = "Norma 3";
                t4 = "Norma 4";
               

                mensaje = string.Format("{1}{0}{0}{2}{0}{0}{3}{0}{0}{4}", Environment.NewLine, t1, t2, t3, t4);
                texto1.Text = mensaje;
            }

            if (cont == 7)
            {
                Titulo.Text = "Indivudal a 4";
                t1 = "Es la modalidad más simple: cada jugador maneja un color, y no hay equipos. La partida finaliza en cuanto uno de los 4 participantes gana completando " +
                    "el recorrido con sus 4 fichas.";
               
                mensaje = string.Format("{1}", Environment.NewLine, t1);
                texto1.Text = mensaje;
            }
            if (cont == 8)
            {
                Titulo.Text = "Por parejas";
                t1 = "Juegan 4 personas, formando dos parejas en posiciones alternas: amarillo y rojo contra azul y verde.";
                t2 = "Cada jugador mueve las fichas de su propio color. Sin embargo, si no puede mover (por ejemplo, por haber finalizado el recorrido con sus 4 fichas), debe" +
                    " mover una ficha de su pareja.";
                t3 = "Las fichas de diferente color pueden comerse entre sí aunque pertenezcan al mismo equipo.";
                t4 = "Gana la pareja que completa el recorrido con las 8 fichas de sus dos colores.";

                mensaje = string.Format("{1}{0}{0} {2}{0}{0} {3}{0}{0} {4}{0}{0}", Environment.NewLine, t1, t2, t3, t4);
                texto1.Text = mensaje;
            }


            if (cont == 0)
            {
                Titulo.Text = "Reglas del juego de Parchís";
                t1 = "El Parchís es un juego de carreras, heredero del juego de origen indio denominado Parchisi.";
                t2 = "Se utilizan dados para determinar el avance que las fichas realizan a través de un recorrido en forma de cruz. El objetivo es completar el recorrido con " +
                    "todas las fichas.";

                mensaje = string.Format("{1}{0}{0} {2}{0}{0}", Environment.NewLine, t1, t2);
                texto1.Text = mensaje;
            }
            
            if (cont > 8)
            {
                this.Close();
            }
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Atras_Click(object sender, EventArgs e)
        {
            cont--;
            if (cont == 1)
            {
                Titulo.Text = "Tablero, dados y fichas";
                t1 = "Tradicionalmente en el parchís participan 4 jugadores, cada uno de ellos utilizando un color diferente: amarillo, azul, rojo y verde. " +
                    "Se emplean 4 fichas de cada color, y cada jugador utiliza un dado.";
                t2 = "El tablero de parchís tiene varias zonas diferenciadas:";
                t3 = "Zonas de salida o casas, situadas en las esquinas del tablero, de los cuatro colores.";
                t4 = "Un recorrido común de 68 casillas por el que avanzan todas las fichas.";
                t5 = "Pasillo y casilla final de los 4 colores, que convergen en el centro del tablero desde    los cuatro laterales.";

                mensaje = string.Format("{1}{0}{0}  {2}{0}  {3}{0}  {4}{0}  {5}{0}", Environment.NewLine, t1, t2, t3, t4, t5);
                texto1.Text = mensaje;
            }
            if (cont == 2)
            {
                Titulo.Text = "Movimiento de las ficha";
                t1 = "Inicialmente cada jugador tiene un par de fichas en la casilla inicial del recorrido, y el resto de fichas situadas en casa.";
                t2 = "Los participantes en su turno deben tirar el dado y avanzar con una de sus fichas el número de casillas indicado por el número " +
                    "obtenido, teniendo en cuenta las    siguientes reglas:";
                t3 = "En caso de tirar un 5 y tener fichas en casa, una de ellas entra en juego    obligatoriamente situándose en la casilla de salida.";
                t4 = "Las fichas avanzan siguiendo el recorrido en sentido inverso a las agujas del reloj.";
                t5 = "Cuando una ficha completa una vuelta al tablero y llega a la casilla que conecta con    el pasillo de su color, se desvía hacia la" +
                    " casilla destino (hacia el centro del tablero).";
                t6 = "En caso de tirar un 6 y tener todas las fichas del mismo color fuera de casa, se    avanzan 7 casillas.";
                t7 = "El jugador que ha obtenido un 6 juega de nuevo.";

                mensaje = string.Format("{1}{0}{0}  {2}{0}  {3}{0}  {4}{0}  {5}{0}  {6}{0}  {7}{0}", Environment.NewLine, t1, t2, t3, t4, t5, t6, t7);
                texto1.Text = mensaje;
            }
            if (cont == 3)
            {
                Titulo.Text = "Movimiento de las ficha II";
                t1 = "En cada casilla del recorrido puede haber un máximo de dos fichas. Una ficha no puede jugarse si el movimiento le llevara a una " +
                    "casilla en la que ya hay dos fichas.";
                t2 = "Una ficha no puede moverse si para completar el avance tuviera que atravesar una barrera. Las barreras son pares de fichas de un mismo" +
                    " color situadas en la misma casilla.";
                t3 = "Para alcanzar el final del recorrido es necesario avanzar el número exacto de casillas que restan hasta completarlo. No es posible " +
                    "mover la ficha si el número del dado es superior.";
                t4 = "Cuando una ficha completa su recorrido, el jugador debe avanzar 10 casillas con otra de sus fichas";
                t5 = "Puede darse el caso de que todas las fichas estén bloqueadas (por estar en casa, o tras una barrera, o en el final del recorrido). " +
                    "En este caso, simplemente no se realiza ningún movimiento.";


                mensaje = string.Format("  {1}{0}{0}  {2}{0}  {3}{0}  {4}{0}  {5}{0}", Environment.NewLine, t1, t2, t3, t4, t5);
                texto1.Text = mensaje;
            }
            if (cont == 4)
            {
                Titulo.Text = "Capturas";
                t1 = "Una ficha come a otra de diferente color si finaliza su avance en la casilla ocupada por esta última.";
                t2 = "Las casillas de salida y las casillas marcadas con un círculo son seguros, donde las capturas no son posibles. Por tanto, en los seguros" +
                    " pueden coincidir dos fichas de diferente color.";
                t3 = "Si en la casilla de salida se encuentran dos fichas de diferente color y una nueva ficha sale de su casa, la ficha de diferente color (o si" +
                    " ambas lo son, la última ficha que hubiera llegado a la casilla) resulta capturada.";
                t4 = "Las fichas comidas vuelven a su casa, de manera que vuelven a entrar en juego cuando el jugador obtiene un 5 en su tirada.";
                t5 = "Quien come una ficha tiene el premio de avanzar 20 casillas con cualquiera de sus fichas.";


                mensaje = string.Format("{1}{0}{0}  {2}{0}  {3}{0}  {4}{0}  {5}{0}", Environment.NewLine, t1, t2, t3, t4, t5);
                texto1.Text = mensaje;
            }

            if (cont == 5)
            {
                Titulo.Text = "Capturas II";
                t1 = " Si un jugador obtiene un 6 tres veces consecutivas, el tercer movimiento no se realiza, y la ficha movida con el segundo 6 vuelve a su casa, " +
                    "salvo que ya hubiese alcanzado el pasillo final del recorrido.";


                mensaje = string.Format("{1}", Environment.NewLine, t1);
                texto1.Text = mensaje;
            }
            if (cont == 6)
            {
                Titulo.Text = "Como jugar";
                t1 = "Norma 1";
                t2 = "Norma 2";
                t3 = "Norma 3";
                t4 = "Norma 4";


                mensaje = string.Format("{1}{0}{0}{2}{0}{0}{3}{0}{0}{4}", Environment.NewLine, t1, t2, t3, t4);
                texto1.Text = mensaje;
            }

            if (cont == 7)
            {
                Titulo.Text = "Indivudal a 4";
                t1 = "Es la modalidad más simple: cada jugador maneja un color, y no hay equipos. La partida finaliza en cuanto uno de los 4 participantes gana completando " +
                    "el recorrido con sus 4 fichas.";

                mensaje = string.Format("{1}", Environment.NewLine, t1);
                texto1.Text = mensaje;
            }
            if (cont == 8)
            {
                Titulo.Text = "Por parejas";
                t1 = "Juegan 4 personas, formando dos parejas en posiciones alternas: amarillo y rojo contra azul y verde.";
                t2 = "Cada jugador mueve las fichas de su propio color. Sin embargo, si no puede mover (por ejemplo, por haber finalizado el recorrido con sus 4 fichas), debe" +
                    " mover una ficha de su pareja.";
                t3 = "Las fichas de diferente color pueden comerse entre sí aunque pertenezcan al mismo equipo.";
                t4 = "Gana la pareja que completa el recorrido con las 8 fichas de sus dos colores.";

                mensaje = string.Format("{1}{0}{0} {2}{0}{0} {3}{0}{0} {4}{0}{0}", Environment.NewLine, t1, t2, t3, t4);
                texto1.Text = mensaje;
            }


            if (cont == 0)
            {
                Titulo.Text = "Reglas del juego de Parchís";
                t1 = "El Parchís es un juego de carreras, heredero del juego de origen indio denominado Parchisi.";
                t2 = "Se utilizan dados para determinar el avance que las fichas realizan a través de un recorrido en forma de cruz. El objetivo es completar el recorrido con " +
                    "todas las fichas.";

                mensaje = string.Format("{1}{0}{0} {2}{0}{0}", Environment.NewLine, t1, t2);
                texto1.Text = mensaje;
            }

            if (cont < 0)
            {
                this.Close();
            }
        }
    }
}
