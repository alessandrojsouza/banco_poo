using System;

/*
*	Código estruturado do aplicação
*/
class MainClass{
	// Declaração de variáveis
	static string nomeCliente;
	static string cpf;
	static DateTime dataNasc;
	static double saldo;

	public static void Main(string [] args){
		
		Cadastro();
		Menu();
		//Resumo da conta para finalizar o programa.
		Console.WriteLine($"Cliente:{nomeCliente}; CPF:{cpf}; Data nasc.: {dataNasc.ToString("dd/MM/yyyy")}; Saldo: {saldo:0.00}");
	}	

	public static void Cadastro(){
		Console.WriteLine("\nCADASTO DE CLIENTES \n");
		Console.Write("Digite o nome do cliente: ");
		nomeCliente = Console.ReadLine();
		Console.Write("Digite o nome do cpf: ");
		cpf = Console.ReadLine();
		Console.Write("Digite a data nasc.: ");
		dataNasc = DateTime.Parse(Console.ReadLine());
	}

	public static void Saldo(){
		Console.WriteLine($"\nO saldo do cliente {nomeCliente} é {saldo:0.00}");
	}

	public static void Sacar(){
			Console.Write("\nDigite o valor do Saque: ");
			double valor = double.Parse(Console.ReadLine());
			if(valor > saldo)
				Console.WriteLine ("Saldo Insuficiente!!\n");
			else
				saldo -= valor;
	}

	public static void Depositar(){
		  Console.Write("\nDigite o valor do Depósito: ");
			double valor = double.Parse(Console.ReadLine());
			if(valor <= 0 )
				Console.WriteLine("Valor de depósito errado.\n");
			else
				saldo += valor;
	}

	public static void Menu(){
		Console.WriteLine("\n Menu de Opções \n" + 
												" (1) Saldo \n" +
												" (2) Depósito \n" +
												" (3) Saque \n" +
												" (4) Sair");
		int opcao = 0;
		while(opcao != 4){
			Console.Write("\nDigite a opção:");
			opcao = int.Parse(Console.ReadLine());
			switch (opcao){
				case 1:  Saldo(); break;
				case 2:  Depositar(); break;
				case 3:  Sacar(); break;
				case 4:  Console.WriteLine("\nFIM DE PROGRAMA\n"); break;
			}
			
		}
	}
}