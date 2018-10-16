using App1_Cell.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1_Cell.Paginas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ImageCellPage : ContentPage
	{
		public ImageCellPage ()
		{
			InitializeComponent ();

            List<Funcionario> Lista = new List<Funcionario>();
            Lista.Add(new Funcionario() { Foto = "https://www.itson.mx/universidad/funcionarios/jesus_alvares_perfil_130.jpg", Nome = "José", Cargo = "Presindente" });
            Lista.Add(new Funcionario() { Foto = "https://www.itson.mx/universidad/funcionarios/jesus_alvares_perfil_130.jpg", Nome = "Maria", Cargo = "Gerente de vendas" });
            Lista.Add(new Funcionario() { Foto = "https://www.itson.mx/universidad/funcionarios/jesus_alvares_perfil_130.jpg", Nome = "Elaine", Cargo = "Gerente de Marketing" });
            Lista.Add(new Funcionario() { Foto = "https://www.itson.mx/universidad/funcionarios/jesus_alvares_perfil_130.jpg", Nome = "Felipe", Cargo = "Entregador" });
            Lista.Add(new Funcionario() { Foto = "https://www.itson.mx/universidad/funcionarios/jesus_alvares_perfil_130.jpg", Nome = "João", Cargo = "Vendedor" });

            ListaFuncionario.ItemsSource = Lista;
        }
	}
}