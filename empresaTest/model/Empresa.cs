using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empresaTest.model
{
	public class Empresa
	{
		public string UF { get; set; }
		public string NomeFantasia { get; set; }
		public string CNPJ { get; set; }
		public ObservableCollection<Fornecedor> Fornecedores { get; set; }

		public Empresa(string uf, string nomeFantasia, string cnpj, ObservableCollection<Fornecedor> fornecedors)
		{
			UF = uf;
			NomeFantasia = nomeFantasia;
			CNPJ = cnpj;
			Fornecedores = fornecedors;
		}
	}
}
