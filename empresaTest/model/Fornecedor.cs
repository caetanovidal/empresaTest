using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empresaTest.model
{
	public class Fornecedor
	{
		public string Name { get; set; }

		public string CNPJ { get; set; }

		public DateTime HorarioCadastro { get; set; }

		public List<string> Telefones { get; set; }
	}
}
