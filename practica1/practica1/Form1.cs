using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace practica1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            char letra;
            int cont = 0;
            string lexema=null;
            int estado = 0;
            String texto = textBox1.Text+" \n\t\r\f";            

            for (int i=0;i<texto.Length;i++)
            {
                letra = texto[i];
                int codigoAscii = letra;
                switch (estado)
                {
                    case 0:
                        
                        if ((codigoAscii >= 65 && codigoAscii <= 90) || (codigoAscii >= 97 && codigoAscii <= 122) )//codgiAscii que verifica si es una letra; ñÑ 164,165
                        {
                            estado = 1;                            
                            lexema = "" + letra;                            
                        }

                        else if (codigoAscii == 34)//comilla doble (")
                        {
                            estado = 2;
                            lexema = "" + letra;                            
                        }                                                
                        else if (codigoAscii == 39)//comilla simple (')
                        {
                            estado = 7;
                            lexema = "" + letra;                            
                        }                        
                        break;


                    case 1:
                        if ((codigoAscii >= 65 && codigoAscii <= 90) || (codigoAscii >= 97 && codigoAscii <= 122))//letra
                        {
                            estado = 1;
                            lexema = lexema + letra;

                        }
                        else if (codigoAscii >= 48 && codigoAscii <= 57)//numero
                        {
                            estado = 1;
                            lexema = lexema + letra;
                        }
                        else if ((codigoAscii >= 35 && codigoAscii <= 36) || (codigoAscii >= 40 && codigoAscii <= 41) || (codigoAscii >= 91 && codigoAscii <= 93) || (codigoAscii == 64) || (codigoAscii == 95))//caracter
                        {
                            estado = 1;
                            lexema = lexema + letra;
                        }

                        else if ((codigoAscii == 32) ||  //espacio 
                            (codigoAscii == 09) ||  //tab_horizontal
                            (codigoAscii == 10)||   //nueva_linea
                            (codigoAscii == 13)     )// retorno_de_carro
                        {
                            //tabla => agregar_lexema()                                                        
                            cont++;

                            Console.WriteLine(lexema);
                            if ((lexema == "iniciarA")||
                                (lexema == "ingresarAPdf")||
                                (lexema == "crear")||
                                (lexema == "Abrir")||
                                (lexema == "escribirTexto")||
                                (lexema == "imagen")||
                                (lexema == "crearTabla")||
                                (lexema == "crearFila")||
                                (lexema == "mostrarManualUsuario")||
                                (lexema == "mostrarManualTecnico")||
                                (lexema == "reporteTokens")||
                                (lexema == "acercaDe")
                                )
                            {
                                if (lexema == "acercaDe")
                                {
                                    MessageBox.Show("Marcos Sebastián Velasquez Cabrera\n" +
                                        "Carnet: 201612190\n" +
                                        "Lenguajes Formales" + cont);
                                }
                                //palabra reservada
                                Console.WriteLine("Palabra reservada\n");
                            }
                            else
                            {   //identificador
                                Console.WriteLine("identificador\n");
                            }                            
                            estado = 0;
                        }                        

                        break;


                    case 2:
                        if ((codigoAscii >= 65 && codigoAscii <= 90) || (codigoAscii >= 97 && codigoAscii <= 122))//letra
                        {
                            estado = 3;
                            lexema = lexema + letra;
                        }                        
                        break;


                    case 3:
                        if ((codigoAscii >= 65 && codigoAscii <= 90) || (codigoAscii >= 97 && codigoAscii <= 122))//letra
                        {
                            estado = 3;
                            lexema = lexema + letra;
                        }
                        else if (codigoAscii >= 48 && codigoAscii <= 57)//numero
                        {
                            estado = 3;
                            lexema = lexema + letra;
                        }
                        else if ((codigoAscii >= 34 && codigoAscii <= 38) || (codigoAscii >= 40 && codigoAscii <= 46) || (codigoAscii >= 58 && codigoAscii <= 59) || (codigoAscii >= 91 && codigoAscii <= 93) || (codigoAscii == 63) || (codigoAscii == 64) || (codigoAscii == 95) || (codigoAscii == 124))//carácter
                        {
                            estado = 3;
                            lexema = lexema + letra;
                        }
                        else if (codigoAscii == 47)// diagonal
                        {
                            estado = 4;
                            lexema = lexema + letra;
                        }//diagonal
                        else if (codigoAscii == 32)// espacio
                        {
                            estado = 14;
                            lexema = lexema + letra;
                        }//espacio
                        else if (codigoAscii == 34)// comilla (puede ser solo "palabra" sin espacios)
                        {
                            estado = 15;
                            lexema = lexema + letra;
                        }//espacio

                        break;


                    case 4:
                        if ((codigoAscii >= 65 && codigoAscii <= 90) || (codigoAscii >= 97 && codigoAscii <= 122))//letra
                        {
                            estado = 4;
                            lexema = lexema + letra;
                        }
                        else if (codigoAscii >= 48 && codigoAscii <= 57)//numero
                        {
                            estado = 4;
                            lexema = lexema + letra;
                        }
                        else if ((codigoAscii >= 35 && codigoAscii <= 36) || (codigoAscii >= 40 && codigoAscii <= 41) || (codigoAscii >= 91 && codigoAscii <= 93) || (codigoAscii == 64) || (codigoAscii == 95))//caracter
                        {
                            estado = 4;
                            lexema = lexema + letra;
                        }
                        else if (codigoAscii == 47)// diagonal
                        {
                            estado = 6;
                            lexema = lexema + letra;
                        }
                        else if (codigoAscii == 34)// ""
                        {   //Estado5  aceptado! :D
                            lexema = lexema + letra;
                            estado = 5;
                        }
                    
                        break;

                    case 5://estado aceptador
                        //tabla => agregar_lexema()                                                        
                        cont++;
                        Console.WriteLine(lexema);
                        Console.WriteLine("ruta\n");
                        estado = 0;                        
                        break;

                    case 6:
                        if ((codigoAscii >= 65 && codigoAscii <= 90) || (codigoAscii >= 97 && codigoAscii <= 122))//letra
                        {
                            estado = 4;
                            lexema = lexema + letra;
                        }
                        else if (codigoAscii >= 48 && codigoAscii <= 57)//numero
                        {
                            estado = 4;
                            lexema = lexema + letra;
                        }
                        else if ((codigoAscii >= 35 && codigoAscii <= 36) || (codigoAscii >= 40 && codigoAscii <= 41) || (codigoAscii >= 91 && codigoAscii <= 93) || (codigoAscii == 64) || (codigoAscii == 95))//caracter
                        {
                            estado = 4;
                            lexema = lexema + letra;
                        }
                        else if (codigoAscii == 34 )//comilla (la ruta puede terminar en diagonal -> comilla)
                        {
                            estado = 5;
                            lexema = lexema + letra;
                        }

                        break;


                    case 7:
                        if ((codigoAscii >= 65 && codigoAscii <= 90) || (codigoAscii >= 97 && codigoAscii <= 122))//letra
                        {
                            estado = 8;
                            lexema = lexema + letra;
                        }                        
                        break;

                    case 8:
                        if ((codigoAscii >= 65 && codigoAscii <= 90) || (codigoAscii >= 97 && codigoAscii <= 122))//letra
                        {
                            estado = 8;
                            lexema = lexema + letra;
                        }
                        else if (codigoAscii >= 48 && codigoAscii <= 57)//numero
                        {
                            estado = 8;
                            lexema = lexema + letra;
                        }
                        else if ((codigoAscii >= 35 && codigoAscii <= 36) || (codigoAscii >= 40 && codigoAscii <= 41) || (codigoAscii >= 91 && codigoAscii <= 93) || (codigoAscii == 64) || (codigoAscii == 95))//caracter
                        {
                            estado = 8;
                            lexema = lexema + letra;
                        }
                        else if (codigoAscii ==47) //diagonal
                        {
                            estado = 9;
                            lexema = lexema + letra;
                        }                        
                        break;

                    case 9:
                        if ((codigoAscii >= 65 && codigoAscii <= 90) || (codigoAscii >= 97 && codigoAscii <= 122))//letra
                        {
                            estado = 9;
                            lexema = lexema + letra;
                        }
                        else if (codigoAscii >= 48 && codigoAscii <= 57)//numero
                        {
                            estado = 9;
                            lexema = lexema + letra;
                        }
                        else if ((codigoAscii >= 35 && codigoAscii <= 36) || (codigoAscii >= 40 && codigoAscii <= 41) || (codigoAscii >= 91 && codigoAscii <= 93) || (codigoAscii == 64) || (codigoAscii == 95))//caracter
                        {
                            estado = 9;
                            lexema = lexema + letra;
                        }
                        else if (codigoAscii == 47) //diagonal
                        {
                            estado = 10;
                            lexema = lexema + letra;
                        }
                        else if (codigoAscii == 46) //punto
                        {
                            estado = 11;
                            lexema = lexema + letra;
                        }
                        
                        break;
                        
                    case 10:
                        if ((codigoAscii >= 65 && codigoAscii <= 90) || (codigoAscii >= 97 && codigoAscii <= 122))//letra
                        {
                            estado = 9;
                            lexema = lexema + letra;
                        }
                        else if (codigoAscii >= 48 && codigoAscii <= 57)//numero
                        {
                            estado = 9;
                            lexema = lexema + letra;
                        }
                        else if ((codigoAscii >= 35 && codigoAscii <= 36) || (codigoAscii >= 40 && codigoAscii <= 41) || (codigoAscii >= 91 && codigoAscii <= 93) || (codigoAscii == 64) || (codigoAscii == 95))//caracter
                        {
                            estado = 9;
                            lexema = lexema + letra;
                        }
                        
                        break;
                        
                    case 11:
                        if ((codigoAscii >= 65 && codigoAscii <= 90) || (codigoAscii >= 97 && codigoAscii <= 122))//letra
                        {
                            estado = 12;
                            lexema = lexema + letra;
                        }
                        
                        break;

                    case 12:
                        if ((codigoAscii >= 65 && codigoAscii <= 90) || (codigoAscii >= 97 && codigoAscii <= 122))//letra
                        {
                            estado = 12;
                            lexema = lexema + letra;
                        }
                         if (codigoAscii == 39) //comilla simple
                        {
                            estado = 13;
                            //Estado13  aceptado! :D
                            lexema = lexema + letra;                            
                        }

                        break;

                    case 13://estado aceptador
                        //tabla => agregar_lexema()                                                        
                        cont++;
                        Console.WriteLine(lexema);
                        Console.WriteLine("ruta imagen\n");
                        estado = 0;

                        break;


                    case 14:
                        if ((codigoAscii >= 65 && codigoAscii <= 90) || (codigoAscii >= 97 && codigoAscii <= 122))//letra
                        {
                            estado = 14;
                            lexema = lexema + letra;
                        }
                        else if (codigoAscii >= 48 && codigoAscii <= 57)//numero
                        {
                            estado = 14;
                            lexema = lexema + letra;
                        }
                        else if ((codigoAscii >= 35 && codigoAscii <= 36) || (codigoAscii >= 40 && codigoAscii <= 41) || (codigoAscii >= 91 && codigoAscii <= 93) || (codigoAscii == 64) || (codigoAscii == 95))//caracter
                        {
                            estado = 14;
                            lexema = lexema + letra;
                        }
                        else if (codigoAscii == 32)// espacio
                        {
                            estado = 14;
                            lexema = lexema + letra;
                        }

                        //--
                        /*else if (codigoAscii == 34)// comillas dentro de un mensaje
                        {
                            estado = 14;
                            lexema = lexema + letra;
                        }*/
                        else if (codigoAscii == 42)// 42-47
                        {
                            estado = 14;
                            lexema = lexema + letra;
                        }
                        else if (codigoAscii == 43)// espacio
                        {
                            estado = 14;
                            lexema = lexema + letra;
                        }
                        else if (codigoAscii == 44)// espacio
                        {
                            estado = 14;
                            lexema = lexema + letra;
                        }
                        else if (codigoAscii == 45)// espacio
                        {
                            estado = 14;
                            lexema = lexema + letra;
                        }
                        else if (codigoAscii == 46)// espacio
                        {
                            estado = 14;
                            lexema = lexema + letra;
                        }
                        else if (codigoAscii == 47)// espacio
                        {
                            estado = 14;
                            lexema = lexema + letra;
                        }
                        else if (codigoAscii == 58)// espacio
                        {
                            estado = 14;
                            lexema = lexema + letra;
                        }
                        else if (codigoAscii == 59)// espacio
                        {
                            estado = 14;
                            lexema = lexema + letra;
                        }
                        else if (codigoAscii == 124)// espacio
                        {
                            estado = 14;
                            lexema = lexema + letra;
                        }


                        //--
                        else if (codigoAscii == 34) //comillas"
                        {
                            estado = 15;
                            lexema = lexema + letra;
                        }
                        break;


                    case 15://estado aceptador
                        //tabla => agregar_lexema()                                                        
                        cont++;
                        Console.WriteLine(lexema);
                        Console.WriteLine("texto\n");
                        estado = 0;
                        break;

                }                

            }




        }

        private void MenuItemA3_Click(object sender, EventArgs e)
        {
            Application.Exit();        
        }
    }
}
