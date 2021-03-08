using System;

class Conta{

	//Declaração dos atributos da classe
	private int numero;
	private SituacaoConta situacao;
	private DateTime dataAbertura;
	private DateTime dataEncerramento;
	private double saldo;
	private Cliente cliente;


	//Implementação dos construtores 
	public Conta(){}

	public Conta(Cliente c, int numero){
		this.cliente = c;
		this.situacao = SituacaoConta.Aberta;
		this.dataAbertura = DateTime.Now;
		this.numero = numero;
	}

	//Implementação dos métodos acessores
	public void SetNumero(int num){
		this.numero = num;
	}

	public void SetCliente(Cliente c){
		this.cliente = c;
	}

	public void SetSaldo(double valor){
		this.saldo = valor;
	}

	public void SetSituacao(SituacaoConta sitconta){
		this.situacao = sitconta;
	}

	public void SetDataAbertura(DateTime dt_abertura){
		this.dataAbertura = dt_abertura;
	}

	public void SetDataEncerramento(DateTime dt_fechamento){
		this.dataEncerramento = dt_fechamento;
	}

	public DateTime GetDataAbertura(){
		return this.dataAbertura;
	}

	public DateTime GetDataEncerramento(){
		return this.dataEncerramento;
	}

	public SituacaoConta GetSituacao(){
		return this.situacao;
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

 //Implementação dos métodos de negócio 
	public bool Sacar(double valor){
		if(valor<=0){
			Console.WriteLine ("\nValor inválido!!\n");
			return false;
		}
		if(valor > saldo){
			Console.WriteLine ("\nSaldo Insuficiente!!\n");
			return false;
		}else{
				saldo -= valor;
				return true;
		}
	}

	public bool Depositar(double valor){
		if(valor <= 0 ){
				Console.WriteLine("\nValor de depósito inválido.\n");
				return false;
		}		
			else{
				saldo += valor;
				return true;
			}
	}

	public bool Fechar(){
		if(saldo > 0 ){
			Console.WriteLine($"\nConta com saldo positvo.\nRealize um saque de {saldo:c2} para fechar a conta.");
			return false;
		}else{
			this.situacao = SituacaoConta.Fechada;
		//	Console.WriteLine($"\nConta fechada com SUCESSO!\n");
			return true;
		}
		
	}

	//Reescrita do método ToString() 
	public override string ToString(){
		return $"Dados do Conta \n\nConta: {this.numero}; Saldo: {this.saldo:0.00}; Situação: {this.situacao}; Data Abertura: {this.dataAbertura} Cliente:{cliente.GetNome()}; CPF:{cliente.GetCPF()};";
	}

	
}