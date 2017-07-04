import java.io.IOException;
import java.io.*;
import java.util.Scanner;

    public class Quadrado
    {
        private int Lado;

        public Quadrado()
        {
            this.Lado = 1;
        }
        public Quadrado(int lado)
        {
            this.Lado = lado;
        }
        public int getLado()
        {
            return (this.Lado);
        }
        public void setLado(int lado)
        {
            this.Lado = lado;
        }
        static void main(String[] args)
        {
            Quadrado n = new Quadrado();
			Scanner ler = new Scanner(System.in);
            int lado;

            System.out.println("Digite o novo lado do quadrado");
            lado = ler.nextInt();
            n.setLado(lado);

            System.out.println("O novo valor do lado é :" + n.getLado());
           

        }
    }

