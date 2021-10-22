using System;/*biblioteca*/

namespace RevisaoNT
{
    class Program
    {
        static void Main(string[] args)/*Principal */
        {
            string nome = "Dolavan Gomes Silva";/*variavel*/
            int idade = 23; /*variavel number int que so aceita numeros inteiros*/
            double salario = 500.50; /*variavel double so aceita numeros quebrados */
            bool bonito = false; /*variavel bool verdadeiro ou falso */
            
            string nome1 = null;
            int idade1 = 0;
            double salario1 = 0;

            Console.WriteLine("Seja, Bem Vindo!");/*comando para aparecer algo na prompt*/
            Console.WriteLine(nome);
            Console.WriteLine(idade + " Anos");/*Comando para aparecer a variavel idade com uma concatenização string*/
            Console.WriteLine(salario);
            Console.WriteLine(bonito);

            Console.WriteLine("Digite seu nome: ");/*solicitando o nome da pessoa*/
            nome1 = Console.ReadLine();/*adicionando o nome na variavel*/

            Console.WriteLine("Digite sua idade: ");/*solicitando a idade da pessoa*/
            idade1 = int.Parse(Console.ReadLine());/*adicionando a idade na variavel e transformando a string em int com o comando int.Parse*/

            Console.WriteLine("Digite seu salario: ");/*solicitando o salario da pessoa*/
            salario1 = double.Parse(Console.ReadLine());/*adicionando o salario na variavel e transformando a string em double com o comando double.Parse*/


            Console.WriteLine("Seu nome é: " + nome1);
            Console.WriteLine("Sua idade é: " + idade1 + " Anos");
            Console.WriteLine("Seu salario é: " + salario1 + " Reais");

        }
    }
}
