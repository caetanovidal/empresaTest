using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace empresaTest.viewModel.commands
{
	public class cadastrarEmpresa : ICommand
	{
		public mainViewModel mainView { get; set; }

		public event EventHandler CanExecuteChanged;

		public cadastrarEmpresa(mainViewModel view)
		{
			mainView = view;
		}

		public bool CanExecute(object parameter)
		{
			return true;
		}

		public void Execute(object parameter)
		{
			mainView.CadastrarEmpresaVis = Visibility.Visible;
			mainView.CadastrarFornecedorVis = Visibility.Hidden;
		}
	}
}
