using System;
using System.Linq;

namespace ConsoleApp2
{

    public struct Contato
    {
        public string nome, sobrenome, nomecompleto, email, endereco, bairro, cidade, estado, tipocontato, observacao;
        public string numero, ddd;

    }

    

   // public static void cadastrar(Contato agenda)
   // {
      
        
    


    class Program
    {
        

        static void Main(string[] args)
        {


            Contato[] agenda = new Contato[100];
            string[] tamanhoagenda = new string[100];
            int quantidade = 1;
            
            int on = 1;
    
            while(on == 1)
            {
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine("Bem-vindo! Selecione uma opção para prosseguir:");
                Console.WriteLine("a - busca por primeiro nome:");
                Console.WriteLine("b - busca por nome completo:");
                Console.WriteLine("c - busca por tipo de contato");
                Console.WriteLine("d - busca por cidade");
                Console.WriteLine("e - inserir um contato");
                Console.WriteLine("f - remover contato\n" +
                    "h - listar contatos");
                Console.WriteLine("g - sair");
                Console.WriteLine("----------------------------------------------------------");

                string opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "a":
                        Console.WriteLine("busca por primeiro nome:");
                        Console.WriteLine("insira o nome que voce deseja pesquisar:");
                        string busca = Console.ReadLine();
                        for (int i = 1; i <= quantidade; i++)
                        {
                            if (busca == agenda[i].nome)
                            {
                                Console.WriteLine($"------------------------------------------\n" +
                                    $"nome:{agenda[i].nomecompleto}\n" +
                                    $"numero: {agenda[i].ddd}" +
                                    $"{agenda[i].numero}\n" +
                                    $"email: {agenda[i].email}\n" +
                                    $"tipo de contato: {agenda[i].tipocontato}\n" +
                                    $"--------------------------------------------------------\n");
                                

                            }
                            else if(i == quantidade && busca != agenda[i].nome)
                            {
                                Console.WriteLine("nome não existe na agenda\n" +
                                     "----------------------------------------------------------\n");
                            }
                            
                        }

                        break;

                    case "b":
                        Console.WriteLine("busca por nome completo:\n" +
                            "insira o nome completo:\n");
                        string buscacompleto = Console.ReadLine();
                        for (int i = 1; i <= quantidade; i++)
                        {
                            if (buscacompleto == agenda[i].nomecompleto)
                            {
                                Console.WriteLine($"------------------------------------------\n" +
                                    $"nome:{agenda[i].nomecompleto}\n" +
                                    $"numero: {agenda[i].ddd}" +
                                    $"{agenda[i].numero}\n" +
                                    $"email: {agenda[i].email}\n" +
                                    $"tipo de contato: {agenda[i].tipocontato}\n" +
                                    $"--------------------------------------------------------\n");

                            }
                            else if(i == quantidade && buscacompleto != agenda[i].nomecompleto)
                            {
                                Console.WriteLine("nome não existe na agenda\n" +
                                     "----------------------------------------------------------\n");
                            }
                        }

                        break;

                    case "c":
                        Console.WriteLine("busca por tipo de contato:");
                        Console.WriteLine("digite o nome de tipo de contato para buscar:\n");
                        Console.WriteLine("1 - celular\n" +
                            "2-Trabalho\n" +
                            "3-Casa\n" +
                            "4-Principal\n" +
                            "5-Pager\n" +
                            "6-Fax Trabalho\n" +
                            "7-Fax Casa\n" +
                            "8-Outro");
                        string tipo = Console.ReadLine();
                        for(int i = 1; i <= quantidade; i++)
                        {
                            if (tipo == agenda[i].tipocontato)
                            {
                                Console.WriteLine($"------------------------------------------\n" +
                                    $"nome:{agenda[i].nomecompleto}\n" +
                                    $"numero: {agenda[i].ddd}" +
                                    $"{agenda[i].numero}\n" +
                                    $"email: {agenda[i].email}\n" +
                                    $"tipo de contato: {agenda[i].tipocontato}\n" +
                                    $"--------------------------------------------------------\n");

                            }
                            else if(i == quantidade && tipo != agenda[i].tipocontato)
                            {
                                Console.WriteLine("tipo não existe na agenda\n" +
                                     "----------------------------------------------------------\n");
                            }
                        }







                        break;

                    case "d":
                        Console.WriteLine("busca por cidade:\n" +
                            "digite o nome da cidade para fazer a busca:\n");
                        String cidadebusca = Console.ReadLine();
                        for(int i = 1; i <= quantidade; i++)
                        {
                            if (cidadebusca == agenda[i].cidade)
                            {
                                Console.WriteLine($"------------------------------------------\n" +
                                    $"nome:{agenda[i].nomecompleto}\n" +
                                    $"numero: {agenda[i].ddd}" +
                                    $"{agenda[i].numero}\n" +
                                    $"email: {agenda[i].email}\n" +
                                    $"tipo de contato: {agenda[i].tipocontato}\n" +
                                    $"--------------------------------------------------------\n");

                            }
                            else if (i == quantidade && cidadebusca != agenda[i].cidade)
                            {
                                Console.WriteLine("cidade não existe na agenda\n" +
                                     "----------------------------------------------------------\n");
                            }
                        }

                        break;


                        // o código até cadastra, mas não consegui fazer com que ele ignore os vetores
                        //que já possuem valores, fazendo com que ele escreva por cima dos valores
                        //no caso de mais de um cadastro

                    case "e":
                        Console.WriteLine("inserir um contato:/n");

                        for(int i = 1; i <= quantidade; i++)
                        {
                            if (quantidade <= 100)
                            {
                                Console.WriteLine("Insira o primeiro nome:");
                                agenda[quantidade].nome = Console.ReadLine();

                                Console.WriteLine("insira o sobrenome:");
                                agenda[quantidade].sobrenome = Console.ReadLine();
                                agenda[quantidade].nomecompleto = (agenda[quantidade].nome + " " + agenda[quantidade].sobrenome);

                                Console.WriteLine("insira o DDD:");
                                agenda[quantidade].ddd = Console.ReadLine();

                                Console.WriteLine("insira o numero:");
                                agenda[quantidade].numero = Console.ReadLine();


                                Console.WriteLine("indique o tipo de contato:");
                                Console.WriteLine("1 - celular\n" +
                                    "2-Trabalho\n" +
                                    "3-Casa\n" +
                                    "4-Principal\n" +
                                    "5-Pager\n" +
                                    "6-Fax Trabalho\n" +
                                    "7-Fax Casa\n" +
                                    "8-Outro");

                                string tipocontato = Console.ReadLine();


                                switch (tipocontato)
                                {
                                    case "1":
                                        agenda[quantidade].tipocontato = "Celular";
                                        break;

                                    case "2":
                                        agenda[quantidade].tipocontato = "Trabalho";
                                        break;

                                    case "3":
                                        agenda[quantidade].tipocontato = "Casa";
                                        break;

                                    case "4":
                                        agenda[quantidade].tipocontato = "Principal";
                                        break;

                                    case "5":
                                        agenda[quantidade].tipocontato = "Pager";
                                        break;

                                    case "6":
                                        agenda[quantidade].tipocontato = "Fax Trabalho";
                                        break;

                                    case "7":
                                        agenda[quantidade].tipocontato = "Fax Casa";
                                        break;

                                    case "8":
                                        agenda[quantidade].tipocontato = "Outro";
                                        break;

                                    default:
                                        Console.WriteLine("tipo invalido");
                                        break;

                                }

                                Console.WriteLine("insira o email:");
                                string email = Console.ReadLine();
                                agenda[quantidade].email = email;

                                Console.WriteLine("insira o endereço:\n" +
                                    "insira o bairro:");
                                string bairro = Console.ReadLine();
                                Console.WriteLine("insira a cidade:");
                                string cidade = Console.ReadLine();
                                Console.WriteLine("insira o estado:");
                                string estado = Console.ReadLine();

                                agenda[quantidade].bairro = bairro;
                                agenda[quantidade].cidade = cidade;
                                agenda[quantidade].estado = estado;

                                Console.WriteLine();


                                Console.WriteLine("observações:\n");
                                string observacao = Console.ReadLine();
                                agenda[quantidade].observacao = observacao;




                                quantidade += 1;
                                break;
                                

                            }
                           
                            else
                            {
                                Console.WriteLine("limite de agenda! remova um contato para liberar espaço!");
                            }

                            break;
                        }






                        break;

                    case "f":
                        Console.WriteLine("remover contato:\n" +
                            "escreva o nome completo do contato que você quer remover da lista\n");
                        string remover = Console.ReadLine();
                        for(int i = 1;i <= quantidade; i++)
                        {
                            if(remover == agenda[i].nomecompleto)
                            {
                                Array.Clear(agenda, i, 1);
                                quantidade -= 1;
                             
                            }
                            else if (i == quantidade && remover != agenda[i].nomecompleto)
                            {
                                Console.WriteLine("nome não existe na agenda\n" +
                                     "----------------------------------------------------------\n");
                            }
                        }
                        break;

                    case "g":
                        Console.WriteLine("progrma encerrado!");
                        on = 0;
                        break;

                    case "h":
                        Console.WriteLine();
                        for(int i = 1; i <= quantidade; i++)
                        {
                            Console.WriteLine($"------------------------------------------\n" +
                                    $"nome:{agenda[i].nomecompleto}\n" +
                                    $"numero: {agenda[i].ddd}" +
                                    $"{agenda[i].numero}\n" +
                                    $"email: {agenda[i].email}\n" +
                                    $"tipo de contato: {agenda[i].tipocontato}\n" +
                                    $"bairro: {agenda[i].bairro}\n" +
                                    $"cidade: {agenda[i].cidade}\n" +
                                    $"estado: {agenda[i].estado}\n" +
                                    $"--------------------------------------------------------\n");

                        }
                        break;

                    default:
                        Console.WriteLine("comando invalido!");
                        break;


                }
            }
        }
    }
}
