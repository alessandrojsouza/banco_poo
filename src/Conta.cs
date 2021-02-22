using System;

class Conta{

	private int numero;
	private double saldo;
	private Cliente cliente;

	public Conta(){}

	public Conta(Cliente c, int num){
		this.cliente = c;
		this.numero = num;
	}

	public void SetNumero(int num){
		this.numero = num;
	}

	public void SetCliente(Cliente c){
		this.cliente = c;
	}

	public void SetSaldo(double valor){
		this.saldo = valor;
	}

	public int GetNumero(){
		return this.numero;
	}

	public Cliente GetCliente(){
		return this.cliente;
	}

	public double GetSaldo(){
		return this.saldo;
	}
	public void Sacar(double valor){
		if(valor > saldo)
				Console.WriteLine ("Saldo Insuficiente!!\n");
			else
				saldo -= valor;
	}

	public void Depositar(double valor){
		if(valor <= 0 )
				Console.WriteLine("Valor de depósito errado.\n");
			else
				saldo += valor;
	}

	public override string ToString(){
		return $"\n Dados do Conta \n Conta: {this.numero}; Saldo: {this.saldo:0.00}; Cliente:{cliente.GetNome()}; CPF:{cliente.GetCPF()};";
	}

	
}