using System; 

class minhaClasse {

    static void Main(string[] args) { 

            double salario, reajuste, novoSalario, percentual;
            salario = Convert.ToDouble(Console.ReadLine());

                       //insira os valores corretos de acordo com o enunciado

            if(salario >= 0.00 && salario <= 400.00)
            {
                reajuste = salario * 0.15; 
                novoSalario = salario + reajuste;
                percentual = ((novoSalario - salario) * 15) /salario;
                Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
                Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
                Console.WriteLine("Em percentual: {0} %", percentual);
            }
    }
}