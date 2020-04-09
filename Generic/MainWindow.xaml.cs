using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Generic
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			MojaKlasa<int, object, string> asd = new MojaKlasa<int, object, string>();
			asd.bla = 6;
			asd.ProveriNull(5);


			MojaKlasa<string, object, string> dsa = new MojaKlasa<string, object, string>();
			dsa.bla = "asd";
		}
	}

	public class MojaKlasa<T, U, zklj>
	{
		List<T> nekaLista;
		public T bla;
		public U asd;
		public zklj treci;

		public bool ProveriNull(T nesto)
		{
			switch(nesto)
			{
				case int i:
					if (i == 0)
						return true;
					break;
				case string s:
					if (s == null)
						return true;
					break;
			}
			return false;
		}

	}
}
