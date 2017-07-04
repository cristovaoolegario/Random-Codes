using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_1
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Programadores: Andrew de Oliveira Duchini\n\tCristóvão Olegário\n\n");
            TV tv = new TV();
            tv.ligar();
            tv.aumentar_volume();
            tv.diminuir_volume();
            tv.desligar();
            Console.ReadKey();
        }

        public interface Icontrole_remoto
        {
            void ligar();
            void desligar();
        }

        public class TV : Icontrole_remoto
        {
            int volume, canal;

            public TV()
            {
                volume = 100;
                canal = 1;
            }

            public void aumentar_volume()
            {
                if (volume < 100)
                {
                    volume++;
                }
                else
                {
                    Console.WriteLine("volume máximo");
                }
            }
            public void diminuir_volume()
            {
                if (volume > 1)
                {
                    volume--;
                }
                else
                {
                    Console.WriteLine("volume mínimo");
                }
            }
            public void ligar()
            {
                Console.WriteLine("TV ligada");
            }
            public void desligar()
            {
                Console.WriteLine("TV desligada");
            }
            public void subir_canal()
            {
                if (canal < 83)
                {
                    canal++;
                }
                else
                {
                    Console.WriteLine("Último canal");
                }
            }
            public void descer_canal()
            {
                if (canal > 1)
                {
                    canal--;
                }
                else
                {
                    Console.WriteLine("Canal mínimo");
                }
            }
        }

        public class DVD : Icontrole_remoto
        {
            public void ligar()
            {

            }
            public void desligar()
            {

            }
        }
    }
}
