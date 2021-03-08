using System;
using System.Threading;
using System.Globalization;

class Programa{

	//private static Conta conta;
  
	private static Banco banco = new Banco();

	public static void Main(string [] args){
		Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
		  Menu();
		}

	public static Cliente CadastrarCliente(){
		Cliente cliente = new Cliente();
		
		Console.WriteLine("\nABERTURA DE CONTA\n");
		
		Console.Write("Digite o nome do cliente: ");
		cliente.SetNome(Console.ReadLine());
		
		Console.Write("Digite o nome do cpf: ");
		cliente.SetCPF(Console.ReadLine());
		
		Console.Write("Digite a data nasc.: ");
		cliente.SetDtNasc(DateTime.Parse(Console.ReadLine()));
		
		return cliente;
	}

	public static void Menu(){
		Console.WriteLine("\n Menu de Opções \n" + 
												" (1) Abrir Conta \n" +
												" (2) Saldo \n" +
												" (3) Depósito \n" +
												" (4) Saque \n" +
												" (5) Caixa Banco \n" +
												" (6) Fechar Conta \n" +
												" (7) Sair");
		int opcao = 0;
		while(opcao != 7){
			Console.Write("\nDigite a opção:");
			opcao = int.Parse(Console.ReadLine());
			int numConta;
			switch (opcao){
				case 1: banco.AbrirConta(CadastrarCliente());
								break;

				case 2: 
							Console.WriteLine("\nOPÇÃO SALDO");
							Console.Write("Digite o número da conta: ");
							numConta = int.Parse(Console.ReadLine());
							banco.EmitirSaldo(numConta);
							break;

				case 3:  
							Console.WriteLine("\nOPÇÃO DEPOSITAR");
							Console.Write("Digite o número da conta: ");
							numConta = int.Parse(Console.ReadLine());
							Console.Write("Digite o valor para Depositar: ");
						  double outValor = double.Parse(Console.ReadLine());
							banco.DepositarValor(numConta, outValor);
							break;

				case 4:  
							Console.WriteLine("\nOPÇÃO SACAR");
							Console.Write("Digite o número da conta: ");
							numConta = int.Parse(Console.ReadLine());
							Console.Write("Digite o valor para Sacar: ");
							double inValor = double.Parse(Console.ReadLine());
							banco.SacarValor(numConta, inValor);
							break;

				case 5: 
							Console.WriteLine("\nOPÇÃO VERIFICA CAIXA DO BANCO");
							double saldoBanco = banco.GetCaixaBanco();
							Console.WriteLine($"Saldo do banco {saldoBanco:c2}") ;
							break;

				case 6: 
							Console.WriteLine("\nOPÇÃO FECHAR CONTA");
							Console.Write("Digite o número da conta: ");
							numConta = int.Parse(Console.ReadLine());
							banco.FecharConta(numConta);
							break;

				case 7:  
							Console.WriteLine("\nFIM DE PROGRAMA\n"); 
							break;
			}
			
		}
	}
}