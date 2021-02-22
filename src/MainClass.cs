using System;

class MainClass{

	private static Cliente cliente;
	private static Conta conta;
  private static int numConta;

	public static void Main(string [] args){
		Cadastro();
		Menu();
		Console.WriteLine(conta.ToString());
			
	}

	public static void Cadastro(){
		cliente = new Cliente();
		
		Console.WriteLine("\nCADASTO DE CLIENTES \n");
		
		Console.Write("Digite o nome do cliente: ");
		cliente.SetNome(Console.ReadLine());
		
		Console.Write("Digite o nome do cpf: ");
		cliente.SetCPF(Console.ReadLine());
		
		Console.Write("Digite a data nasc.: ");
		cliente.SetDtNasc(DateTime.Parse(Console.ReadLine()));

		conta = new Conta(cliente, ++numConta);
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
				case 1:  
							Console.WriteLine($"\nO Saldo da conta é {conta.GetSaldo()}"); 
							break;
				case 2:  
							Console.Write("Digite o valor para Depositar: ");
							double outValor = double.Parse(Console.ReadLine());
							conta.Depositar(outValor); 
							break;
				case 3:  
							Console.Write("Digite o valor para Sacar: ");
							double inValor = double.Parse(Console.ReadLine());
							conta.Sacar(inValor); 
							break;
				case 4:  
							Console.WriteLine("\nFIM DE PROGRAMA\n"); 
							break;
			}
			
		}
	}
}


