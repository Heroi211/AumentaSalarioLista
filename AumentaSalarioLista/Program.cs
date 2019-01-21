using System;
using System.Collections.Generic;
using System.Globalization;

namespace AumentaSalarioLista
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Fazer um programa para ler um número inteiro N e depois os dados (id, nome e salario) de
                N funcionários. Não deve haver repetição de id.
                Em seguida, efetuar o aumento de X por cento no salário de um determinado funcionário.
                Para isso, o programa deve ler um id e o valor X. Se o id informado não existir, mostrar uma
                mensagem e abortar a operação. Ao final, mostrar a listagem atualizada dos funcionários,
                conforme exemplos.
                Lembre-se de aplicar a técnica de encapsulamento para não permitir que o salário possa
                ser mudado livremente. Um salário só pode ser aumentado com base em uma operação de
                aumento por porcentagem dada.*/

            
            List<Employee> employees = new List<Employee>(); 
            Console.Write("How many employess will be registered? ");
            int n = int.Parse(Console.ReadLine());

            for(int i =0;i<n;i++)
            {

                Console.WriteLine("Employee #" + (i + 1)+ ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employees.Add(new Employee(id, name, salario));
                Console.WriteLine();

            }

            Console.Write("Enter the employee id that will have salary increase : ");
            int IdSearch = int.Parse(Console.ReadLine());

            Employee search = employees.Find(x => x.Id == IdSearch);

            if( search != null)
            {
                Console.Write("Enter de percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                search.increaseSalary(percentage);
            }
            else
            {
                Console.Write("This id does not exist!");
            }

            Console.WriteLine();

            foreach(Employee obj in employees)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
