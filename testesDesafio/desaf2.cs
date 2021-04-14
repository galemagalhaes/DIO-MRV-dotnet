using System; 

class desaf2 {

    static void Main(string[] args) { 

            double a, b, c, resultado;
            string[] valor = Console.ReadLine().Split();
            a = Convert.ToDouble(valor[0]);
            b = Convert.ToDouble(valor[1]);
            c = Convert.ToDouble(valor[2]);

            if(((a+b)>c) && ((b+c)>a) && ((c+a)>b)) //complete a condicional
            {
              resultado = (a+b+c);
                Console.WriteLine("Perimetro = {0:0.0}",resultado); //complete a saida
            }
            else
            {
              resultado = ((a+b)*c)/2;
                Console.WriteLine("Area = {0:0.0}",resultado); //complete a saida
            }

    }

}