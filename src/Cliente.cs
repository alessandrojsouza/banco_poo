using System;

class Cliente{
		private string nome;
		private string cpf;
		private DateTime dtNasc;

		public Cliente(){

		}
		public Cliente(string nome, string cpf, DateTime dtnasc){
			this.nome = nome;
			this.cpf = cpf;
			this.dtNasc = dtnasc;
		}
		public void SetNome(string nome){
			this.nome = nome;
		}
		public void SetCPF(string cpf){
			this.cpf = cpf;
		}
		public void SetDtNasc(DateTime dt){
			this.dtNasc = dt;
		}
		public string GetNome(){
			return this.nome;
		}
		public string GetCPF(){
			return this.cpf;
		}
		public DateTime GetDtNasc(){
			return this.dtNasc;
		}

		public override string ToString(){
			return $"\n Dados do Cliente \n Cliente: {this.nome}; CPF: {this.cpf}; Data nasc.: {this.dtNasc.ToString("dd/MM/yyyy")}";
		}
}