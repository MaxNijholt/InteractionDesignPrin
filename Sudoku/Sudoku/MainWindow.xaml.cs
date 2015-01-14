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
using SudokuBasic;
using System.Data;

namespace Sudoku {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow ( ) {
			InitializeComponent( );
			Wrapper c = new Wrapper();
			c.Create( );
			DataTable table = new DataTable( );

			for ( int y = 0; y < 9; y++ ) {
				DataRow dr = table.NewRow( );
				for ( int x = 0; x < 9; x++ ) {
					string temp = ""+c.Get( (short) x, (short) y );
					dr[x] = x;
				}
				table.Rows.Add( dr );
			}

			datagrid.DataContext = table;
		}
	}
}
