using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class TP5 : Form
    {
        public TP5()
        {
            InitializeComponent();
        }


        double reloj = 0.00;
        double relojDia = 0.00;
        int contDias = 0;



        int idEvento = 0;
        //Eventos
        //0. inizializacion
        //1. llegada auto colon
        //2. llegada auto urquiza
        //3. cambio color colon
        //4. cambio color urquiza
        //5. fin cruce auto
        string evento;

        double nextReloj;
        int nextEvento;

        Random rnd = new Random();

        //estados = 0 verde, 1 amarillo, 2 rojo;
        int estadoSemColon;
        int estadoSemUrquiza;


        double rndLlegadaColon;
        double rndLlegadaUrquiza;
        

        double tiempollegada;
        double tiempollegadaUrquiza;

        double proxLlegadaColon;
        double proxLlegadaUrquiza;

        int colaColon;
        int colaUrquiza;

        double cambioColon;
        double cambioUrquiza;

        double rndCruce;
        double tiempoCruce;

        int contadorAutos = 0;
        int acumPermanencia = 0;

        int contVuelta = 0;
        private void btnSimular_Click(object sender, EventArgs e)
        {



            //while (contDias < 100)
            //{

                DataGridViewRow fila = new DataGridViewRow();


                //EVENTO
                DataGridViewTextBoxCell celdaEvento = new DataGridViewTextBoxCell();
                if (idEvento == 0)
                {
                    evento = "inicializacion";
                }

                idEvento = nextEvento;



                celdaEvento.Value = idEvento;
                fila.Cells.Add(celdaEvento);

                //reloj
                if (contVuelta == 0)
                {
                    reloj = 0;
                }
                else
                {
                    reloj = nextReloj;

                    relojDia = reloj - (7200 * contDias);
                }


                DataGridViewTextBoxCell celdaReloj = new DataGridViewTextBoxCell();
                celdaReloj.Value = reloj;
                fila.Cells.Add(celdaReloj);

                //Dias

                if (idEvento == 0)
                {
                    contDias = 0;
                }

                DataGridViewTextBoxCell celdaDias = new DataGridViewTextBoxCell();
                celdaDias.Value = contDias + 1;
                fila.Cells.Add(celdaDias);

                //-----------------LLEGADAS--------------

                //rnd llegada (colon)
                DataGridViewTextBoxCell celdaRndLlegadaColon = new DataGridViewTextBoxCell();
                if (idEvento == 0)
                {
                    rndLlegadaColon = rnd.NextDouble();
                }


                if (idEvento == 1)
                {
                    rndLlegadaColon = rnd.NextDouble();
                }


                celdaRndLlegadaColon.Value = rndLlegadaColon;
                fila.Cells.Add(celdaRndLlegadaColon);

                //tiempo entre llegadas (colon)
                DataGridViewTextBoxCell celdaTiempoLlegadaColon = new DataGridViewTextBoxCell();

                if (idEvento == 0)
                {
                    tiempollegada = 2 + rndLlegadaColon * 2;
                }

                if (reloj == proxLlegadaColon)
                {
                    if (relojDia >= 3600)
                    {
                        tiempollegada = 2 + rndLlegadaColon * 2;
                    }
                    else
                    {
                        tiempollegada = 1.5 + rndLlegadaColon * 1;
                    }

                }


                celdaTiempoLlegadaColon.Value = tiempollegada;
                fila.Cells.Add(celdaTiempoLlegadaColon);

                // proxima llegada (colon)
                DataGridViewTextBoxCell celdaProxLlegadaColon = new DataGridViewTextBoxCell();

                if (idEvento == 0)
                {
                    proxLlegadaColon = reloj + tiempollegada;
                }

                if (idEvento == 1)
                {
                    proxLlegadaColon = reloj + tiempollegada;
                }



                celdaProxLlegadaColon.Value = proxLlegadaColon;
                fila.Cells.Add(celdaProxLlegadaColon);

                nextReloj = proxLlegadaColon;
                nextEvento = 1;

                //rnd llegada (urquiza)-------------
                DataGridViewTextBoxCell celdaRndLlegadaUrquiza = new DataGridViewTextBoxCell();

                if (idEvento == 0)
                {
                    rndLlegadaUrquiza = rnd.NextDouble();
                }

                if (idEvento == 2)
                {
                    rndLlegadaUrquiza = rnd.NextDouble();

                }


                celdaRndLlegadaUrquiza.Value = rndLlegadaUrquiza;
                fila.Cells.Add(celdaRndLlegadaUrquiza);


                //tiempo entre llegadas (urquiza)
                DataGridViewTextBoxCell celdaTiempoLlegadaUrquiza = new DataGridViewTextBoxCell();

                if (idEvento == 0)
                {
                    tiempollegadaUrquiza = 2 + rndLlegadaUrquiza * 2;
                }

                if (reloj == proxLlegadaUrquiza)
                {

                    tiempollegadaUrquiza = 0 + rndLlegadaUrquiza * 2;

                }


                celdaTiempoLlegadaUrquiza.Value = tiempollegadaUrquiza;
                fila.Cells.Add(celdaTiempoLlegadaUrquiza);


                // proxima llegada (urquiza)
                DataGridViewTextBoxCell celdaProxLlegadaUrquiza = new DataGridViewTextBoxCell();
                if (idEvento == 0)
                {
                    proxLlegadaUrquiza = reloj + tiempollegadaUrquiza;
                }

                if (idEvento == 2)
                {
                    proxLlegadaUrquiza = reloj + tiempollegadaUrquiza;
                }


                celdaProxLlegadaUrquiza.Value = proxLlegadaUrquiza;
                fila.Cells.Add(celdaProxLlegadaUrquiza);

                if (nextReloj > proxLlegadaUrquiza)
                {
                    nextReloj = proxLlegadaUrquiza;
                    nextEvento = 2;
                }



                //-----------------SEMAFOROS--------------

                //estadoColon
                DataGridViewTextBoxCell celdaEstSemColon = new DataGridViewTextBoxCell();


                if (idEvento == 0)
                {
                    estadoSemColon = 0;
                }

                if (idEvento == 3)
                {
                    estadoSemColon = setEstadoSemaforo(estadoSemColon);

                }


                celdaEstSemColon.Value = estadoSemColon;
                fila.Cells.Add(celdaEstSemColon);

                //colaColon
                DataGridViewTextBoxCell celdaColaColon = new DataGridViewTextBoxCell();
                if (idEvento == 0)
                {
                    colaColon = 0;
                }

                if (idEvento == 1 && estadoSemColon == 2)
                {
                    colaColon++;
                }



                celdaColaColon.Value = colaColon;
                fila.Cells.Add(celdaColaColon);

                //cambioColon
                DataGridViewTextBoxCell celdaCambioColon = new DataGridViewTextBoxCell();
                if (idEvento == 0)
                {
                    cambioColon = 20;
                }

                if (idEvento == 3)
                {
                    if (estadoSemColon == 0)
                    {
                        cambioColon = reloj + 20;
                    }

                    if (estadoSemColon == 1)
                    {
                        cambioColon = reloj + 10;
                    }
                    if (estadoSemColon == 2)
                    {
                        cambioColon = reloj + 50;
                    }

                }


                celdaCambioColon.Value = cambioColon;
                fila.Cells.Add(celdaCambioColon);

                if (nextReloj > cambioColon)
                {
                    nextReloj = cambioColon;
                    nextEvento = 3;
                }

                //estadoUrquiza----------
                DataGridViewTextBoxCell celdaEstSemUrquiza = new DataGridViewTextBoxCell();
                if (idEvento == 0)
                {
                    estadoSemUrquiza = 2;
                }

                if (idEvento == 4)
                {
                    estadoSemUrquiza = setEstadoSemaforo(estadoSemUrquiza);

                }



                celdaEstSemUrquiza.Value = estadoSemUrquiza;
                fila.Cells.Add(celdaEstSemUrquiza);

                //colaUrquiza
                DataGridViewTextBoxCell celdaColaUrquiza = new DataGridViewTextBoxCell();

                if (idEvento == 0)
                {
                    colaUrquiza = 0;
                }

                if (idEvento == 2 && estadoSemUrquiza == 2)
                {
                    colaUrquiza++;
                }


                celdaColaUrquiza.Value = colaUrquiza;
                fila.Cells.Add(celdaColaUrquiza);

                //cambioUrquiza
                DataGridViewTextBoxCell celdaCambioUrquiza = new DataGridViewTextBoxCell();

                if (idEvento == 0)
                {
                    cambioUrquiza = 30;
                }

                if (idEvento == 4)
                {
                    if (estadoSemUrquiza == 0)
                    {
                        cambioUrquiza = reloj + 40;
                    }

                    if (estadoSemUrquiza == 1)
                    {
                        cambioUrquiza = reloj + 10;
                    }
                    if (estadoSemUrquiza == 2)
                    {
                        cambioUrquiza = reloj + 30;
                    }

                }



                celdaCambioUrquiza.Value = cambioUrquiza;
                fila.Cells.Add(celdaCambioUrquiza);

                if (nextReloj > cambioUrquiza)
                {
                    nextReloj = cambioUrquiza;
                    nextEvento = 4;
                }

                //-----------------CRUCE---------------------

                //RndCruce
                DataGridViewTextBoxCell celdaRndCruce = new DataGridViewTextBoxCell();

                rndCruce = rnd.NextDouble();
                celdaRndCruce.Value = rndCruce;
                fila.Cells.Add(celdaRndCruce);

                //TiempoCruce
                DataGridViewTextBoxCell celdaTiempoCruce = new DataGridViewTextBoxCell();


                //si colon esta verde
                if (estadoSemColon == 0)
                {
                    tiempoCruce = 3 + rndCruce * 2;
                }

                //si urquiza esta verde
                if (estadoSemUrquiza == 0)
                {
                    tiempoCruce = 2.5 + rndCruce * 1;
                }


                celdaTiempoCruce.Value = tiempoCruce;
                fila.Cells.Add(celdaTiempoCruce);


                //----------------------ESTADISTICAS------------------------------------

                //contador autos que salen del sistema
                DataGridViewTextBoxCell celdaContadorAutos = new DataGridViewTextBoxCell();
                contadorAutos = 0;
                celdaContadorAutos.Value = contadorAutos;
                fila.Cells.Add(celdaContadorAutos);

                //permanencia
                DataGridViewTextBoxCell celdaPermanencia = new DataGridViewTextBoxCell();
                acumPermanencia = 0;
                celdaPermanencia.Value = acumPermanencia;
                fila.Cells.Add(celdaPermanencia);


                grilla.Rows.Add(fila);





                contVuelta++;

                if (relojDia > 7200)
                {
                    relojDia = 0;
                    contDias++;
                }


            //}

        }


        private int setEstadoSemaforo(int estadoSem)
        {
            int estado = -1;
            if (estadoSem == 0)
            {
                estado = 1;
            }

            if (estadoSem == 1)
            {
                estado = 2;
            }
            if (estadoSem == 2)
            {
                estado = 0;
            }

            return estado;


        }





    }
    
    
      
    
    
    
    
    
}

