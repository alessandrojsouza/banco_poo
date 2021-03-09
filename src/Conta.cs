using System;

class Conta{

	//Declaração dos atributos da classe
	public int Numero {get; }
	public SituacaoConta Situacao {get; set; }
	public DateTime DataAbertura {get; }
	public DateTime DataEncerramento {get; }
	public double Saldo {get; set;}
	public Cliente Cliente {get;}


	//Implementação dos construtores 
	public Conta(){}

	public Conta(Cliente c, int numero){
		this.Cliente = c;
		this.Situacao = SituacaoConta.Aberta;
		this.DataAbertura = DateTime.Now;
		this.Numero = numero;
	}

 //Implementação dos métodos de negócio 
	public bool Sacar(double valor){
		if(valor<=0){
			Console.WriteLine ("\nValor inválido!!\n");
			return false;
		}
		if(valor > Saldo){
			Console.WriteLine ("\nSaldo Insuficiente!!\n");
			return false;
		}else{
				this.Saldo -= valor;
				return true;
		}
	}

	public bool Depositar(double valor){
		if(valor <= 0 ){
				Console.WriteLine("\nValor de depósito inválido.\n");
				return false;
		}		
			else{
				Saldo += valor;
				return true;
			}
	}

	public bool Fechar(){
		if(Saldo > 0 ){
			Console.WriteLine($"\nConta com saldo positvo.\nRealize um saque de {Saldo:c2} para fechar a conta.");
			return false;
		}else{
			this.Situacao = SituacaoConta.Fechada;
		//	Console.WriteLine($"\nConta fechada com SUCESSO!\n");
			return true;
		}
		
	}

	//Reescrita do método ToString() 
	public override string ToString(){
		return $"Dados do Conta \n\nConta: {this.Numero}; Saldo: {this.Saldo:0.00}; Situação: {this.Situacao}; Data Abertura: {this.DataAbertura} Cliente:{Cliente.Nome}; CPF:{Cliente.Cpf};";
	}

	
}