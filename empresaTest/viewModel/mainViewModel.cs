using empresaTest.model;
using empresaTest.viewModel.commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace empresaTest.viewModel
{
	public class mainViewModel
	{
		public ObservableCollection<Empresa> Empresas { get; set; }

		public Visibility CadastrarEmpresaVis = Visibility.Visible;

		public Visibility CadastrarFornecedorVis = Visibility.Collapsed;

		private Empresa _selectedEmpresa;

		public Empresa SelectedEmpresa
		{
			get { return _selectedEmpresa; }
			set
			{
				_selectedEmpresa = value;
				OnProperyChanged("SelectedEmpresa");
			}
		}

		public cadastrarEmpresa CadastrarEmpresaCommand { get; set; }

		public cadastrarFornecedor CadastrarFornecedorCommand { get; set; }

		public event PropertyChangedEventHandler PropertyChanged;

		public mainViewModel()
		{
			CadastrarEmpresaCommand = new cadastrarEmpresa(this);
			CadastrarFornecedorCommand = new cadastrarFornecedor(this);
			Empresas = new ObservableCollection<Empresa>();
		}

		private void OnProperyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		public void addNovaEmpresa(Empresa newEmpresa)
		{
			Empresas.Add(newEmpresa);
		}
	}
}
