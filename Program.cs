using System;/*biblioteca*/

namespace RevisaoNT
{
    class Program
    {
        static void Main(string[] args)/*Principal */
        {
            string nome = "Dolavan Gomes Silva";/*variavel nome recebe "nome"*/
            int idade = 23; /*variavel idade int recebe numeros inteiros "idade"*/
            double salario = 500.50; /*variavel double salario recebe numeros quebrados "salario" */
            bool bonito = false; /*variavel bool bonito recebe false ou true */
           
            Console.WriteLine("Seja, Bem Vindo!");/*comando para aparecer algo na prompt*/
            Console.WriteLine(nome);
            Console.WriteLine(idade + " Anos");/*Comando para aparecer a variavel idade com uma concatenização */
            Console.WriteLine(salario);
            Console.WriteLine(bonito);

            string nome1 = null;
            int idade1 = 0;
            double salario1 = 0;

         /*double soma = valor1 + valor2;
           double subtracao = valor1 - valor2;
           double multiplicacao = valor1 * valor2;
           double divisao = valor1 / valor2;
           double media = soma / 2;*/

            Console.WriteLine("Digite seu nome: ");/*solicitando o nome da pessoa*/
            nome1 = Console.ReadLine();/*adicionando o nome na variavel*/

            Console.WriteLine("Digite sua idade: ");/*solicitando a idade da pessoa*/
            idade1 = int.Parse(Console.ReadLine());/*adicionando a idade na variavel e transformando a string em int com o comando int.Parse*/

            Console.WriteLine("Digite seu salario: ");/*solicitando o salario da pessoa*/
            salario1 = double.Parse(Console.ReadLine());/*adicionando o salario na variavel e transformando a string em double com o comando double.Parse*/

            Console.WriteLine("Seu nome é: " + nome1);
            Console.WriteLine("Sua idade é: " + idade1 + " Anos");
            Console.WriteLine("Seu salario é: " + salario1 + " Reais");

            double valor1 = 0; /*operações aritimeticas*/
            double valor2 = 0;

            Console.WriteLine("Digite primeiro numero para ser somado: ");/*solicitando um numero a pessoa*/
            valor1 = double.Parse(Console.ReadLine());/*adicionando o numero solicitado na variavel valor1 e transformando a string em double com o comando double.Parse*/
            Console.WriteLine("Digite o segundo para ser somado: ");
            valor2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"A soma é: {valor1 + valor2}");/*apresentando na tela o resultado da soma do valor1+valor2 atribuido na string*/

            Console.WriteLine("Digite primeiro numero para ser subtraido: ");
            valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo para ser subtraido: ");
            valor2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"A ssubtração é: {valor1 - valor2}");

            Console.WriteLine("Digite primeiro numero para ser multiplicado: ");
            valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo para ser multiplicado: ");
            valor2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"A multiplicação é: {valor1 * valor2}");

            Console.WriteLine("Digite primeiro numero para ser dividido: ");
            valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo para ser dividido: ");
            valor2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"A divisão é: {valor1 / valor2}");

        /*  Console.WriteLine("Digite primeiro numero da média: ");
            valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo da média: ");
            valor2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"A média de: {(valor1 + valor2) / 2}");

            /*estrutura de decisão IF e ELSE*/
            //criando um sistema para a aprovação e reprovação do aluno Com operadores relacionas
            string aluno;
            double nota1, nota2, nota3, media;

            Console.WriteLine("Digite o nome do aluno: ");
            aluno = Console.ReadLine();
            
            Console.WriteLine($"Digite a nota1 do aluno: ");
            nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine($"Digite a nota2 do aluno: ");
            nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"Digite a nota3 do aluno: ");
            nota3 = double.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3) / 3;//Sempre quando for fazer a media temos que colocar aspas, para seguir a Precêndencia.

            Console.WriteLine($"Olá! {aluno}");
            Console.WriteLine($"Sua média foi: {media}");
            //comando IF. é um comando para realizar a decisao.
            if (media > 6)//IF se media for maior que 6 aparecer na tela aprovado
            {
                Console.WriteLine("Parabéns voçe foi APROVADO!");
            }
            else if(media == 6)//ELSE IF 'ou se'  media for igual a 6 aparecer na tela aprovado
            {
                Console.WriteLine("Parabéns voçe foi APROVADO! Mas foi por pouco.");
            }
            else//ELSE 'ou' se a media nao for igual ou maior que 6 aparecer na tela reprovado
            {
                Console.WriteLine("Estude mais, voçe foi REPROVADO!");
            }

            //Criando estrura de decisao com operadore logicos
            string nome2;
            int idade2;

            Console.WriteLine("Digite o nome: ");
            nome2 = Console.ReadLine();

            Console.WriteLine($"Digite a idade: ");
            idade2 = int.Parse(Console.ReadLine());
            //verificando se todas as condiçoes estao verdadeiras se sim eu tenho acesso ao que ta dentro do IF
            if (nome2 == "Dolavan" && idade2 == 23)
            {
                Console.WriteLine($"Seu nome é Dolavan Gomes Silva e voçe tem 23 anos!");
            }
            //verificando se uma das condiçoes esta verdadeira se sim eu tenho acesso ao que ta dentro do IF
            if (nome2 == "Dolavan" || idade2 == 23)
            {
                Console.WriteLine($"Seu nome talvez seja, Dolavan Gomes Silva e voçe talvez tenha 23 anos!");
            }
            bool v = false;
            bool f = false;
            if (!v)//se v for falso ira aparecer a mensagem na tela. se for verdadeiro nao aparecera. com operador negação !
            {
                Console.WriteLine($"A primeira condição é verdadeira");
            }
            if (!f)
            {
                Console.WriteLine($"A segunda condição é verdadeira");
            }

            int numero;
            Console.WriteLine("Digite um numero: ");
            numero = int.Parse(Console.ReadLine());

            switch (numero)//é uma função para aparecer uma mensagem ou um codigo após digitar uma variavel.
            {
                case 1://a função e que caso o nmr digitado for 1, 2 ,3 ou 4 vouter acesso a mensagem ou a um trecho de codigo.
                case 2:
                case 3:
                case 4:
                    {
                        Console.WriteLine("A variavel tem o valor de 1 até 4");
                        break;
                    }
                case 5:
                case 6:
                case 7:
                case 8:
                    {
                        Console.WriteLine("A variavel tem o valor de 5 até 8");
                        break;
                    }
                default://a função e que se a variavel ter o valor maior que 8 aperecerar uma mensagem informando 
                    {
                        Console.WriteLine("A variavel tem o valor maior que 8 tente um valor inferior");
                        break;
                    }
            }
        }
    }
}
