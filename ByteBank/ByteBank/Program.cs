using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using System;

namespace ByteBank
{
	class Program
	{
		static void Main(string[] args)
		{
			UsarSistema();
			Console.ReadLine();
		}

		public static void UsarSistema()
		{
			SistemaInterno sistemaInterno = new SistemaInterno();

			Diretor roberta = new Diretor("141.969.888-99");
			roberta.Nome = "Roberta";
			roberta.Senha = "123";

			GerenteDeConta camila = new GerenteDeConta("145.256.414-88");
			camila.Nome = "Camila";
			camila.Senha = "abc";

			ParceiroComercial parceiro = new ParceiroComercial();
			parceiro.Senha = "123456";


			Funcionario pedro = new Designer("833.222.048-39");
			pedro.Nome = "Pedro";

			sistemaInterno.Logar(parceiro, "123456");
			//sistemaInterno.Logar(pedro, "123");
			sistemaInterno.Logar(roberta, "123");
			sistemaInterno.Logar(camila, "abc");
		}
	}
}
