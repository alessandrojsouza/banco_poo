using System;

class Banco{
		
	private Conta[] contas;
	private int quatidadeDeContas = 0;
	private int numConta = 1;

	public Banco(){
		contas = new Conta[100];
	}	

	//Abre uma conta no vetor de contas
	public void AbrirConta(Cliente cli){
			if(cli != null){
				Conta c = new Conta(cli, numConta++ );
				contas[quatidadeDeContas++] = c;
				Console.WriteLine("Conta aberta com SUCESSO!!");
			}else
					Console.WriteLine("Conta não foi aberta verificar dados de entrada!");
	}
 
 //Fecha uma conta que se encontra no vetor
	public void FecharConta(int numero){
		for(int i=0; i<100; i++){
			if(contas[i] != null && contas[i].GetNumero() == numero && contas[i].GetSituacao() == SituacaoConta.Aberta){
				if(contas[i].Fechar())
						Console.WriteLine("\nCONTA FECHADA COM SUCESSO");
						break;
			}else{
				Console.WriteLine("\nCONTA INEXISTENTE!!");
				break;
			}
		}
	}

	public void DepositarValor(int numConta, double valor){
		if(GetConta(numConta)!=null){
			if(GetConta(numConta).Depositar(valor))
				Console.WriteLine("\nDEPÓSITO REALIZADO COM SUCESSO!!");
		}else{
			Console.WriteLine("\nCONTA INEXISTENTE!!");		
		}
	}

	public void SacarValor(int numConta, double valor){
		if(GetConta(numConta)!=null){
			if(GetConta(numConta).Sacar(valor))
				 Console.WriteLine("\nSAQUE REALIZADO COM SUCESSO!!"); 
		}else{
			Console.WriteLine("\nCONTA INEXISTENTE!!");
		}
	}

	public void EmitirSaldo(int numConta){
		Conta conta;
		if(GetConta(numConta)!=null){
			conta = GetConta(numConta);
			Console.WriteLine($"\nO Saldo da conta é {conta.GetSaldo():c2}"); 
		}else
			Console.WriteLine("\nCONTA INEXISTENTE!!");
	}

	public double GetCaixaBanco(){
		double caixa= 0.0;
		foreach(Conta c in contas)
			if(c != null && c.GetSituacao() != SituacaoConta.Fechada)
				caixa += c.GetSaldo();
		return caixa;
	}

	public Conta GetConta(int numero){
		for(int i=0; i<100; i++)
			if(contas[i] != null && contas[i].GetNumero() == numero){
				//Console.WriteLine("erro aqui");
				return contas[i];
			}
		return null;
	}


}