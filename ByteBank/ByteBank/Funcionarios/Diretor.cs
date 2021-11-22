using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank
{
	public class Diretor : FuncionarioAutenticavel
	{
		public Diretor(string cpf) : base (5000,cpf)
		{
		}
		public override void AumentarSalario()
		{
			Salario *= 0.5;
		}

		public override double GetBonificacao()
		{
			return Salario * 1.15;
		}
	}
}
