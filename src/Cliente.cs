using System;

class Cliente{
		public string Nome {get ; set; }
		public string Cpf {get ; set; }
		public DateTime DtNasc {get ; set; }

		public Cliente(){

		}
		public Cliente(string nome, string cpf, DateTime dtnasc){
			this.Nome = nome;
			this.Cpf = cpf;
			this.DtNasc = dtnasc;
		}
		
		public override string ToString(){
			return $"\n Dados do Cliente \n Cliente: {this.Nome}; CPF: {this.Cpf}; Data nasc.: {this.DtNasc.ToString("dd/MM/yyyy")}";
		}
}