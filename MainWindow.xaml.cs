using System;
using System.Drawing;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using JocDameAnicaiBogdan.Entities;

namespace JocDameAnicaiBogdan
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public int boardSize = 8;
		public MainWindow()
		{
			InitializeComponent();
		}

		private void menuItemNewGame_Click(object sender, RoutedEventArgs e)
		{
			
			
			bool isMultipleMoveAllowed = true; // Same as before
			Game g = new Game(isMultipleMoveAllowed, boardSize);
			
			boardSize = int.Parse(Option.size);

			
			
			int numberOfBlackSquares = 0;
			foreach (BoardSquare square in g.getBoard().getSquares()
				)
			{
				if (square.getIsBlack())
					numberOfBlackSquares++; //= g.getBoard().getSquares().Count;
			}

			StringBuilder sb = new StringBuilder(string.Empty);
			sb.Append("New game! ");
			sb.Append(g.getStartTime());
			sb.Append(" | ");
			sb.Append(numberOfBlackSquares.ToString());
			sb.Append(" black squares!");
			lbl.Content = sb.ToString();
			txtBoxPlayer1.Text = "0";
			txtBoxPlayer2.Text = "0";
			g.StartGame(boardSize);
			//buttonGenerator(boardSize);
		}

		private void menuItemAbout_Click(object sender, RoutedEventArgs e)
		{
			AboutWindow wndAbout = new AboutWindow();
			wndAbout.Show();
		}

        private void menuOptionClick(object sender, RoutedEventArgs e)
        {   
			Option opt = new Option();
			opt.Show();

		}

        private void menuExit(object sender, RoutedEventArgs e)
        {
			this.Close();
        }

//private void buttonGenerator(int brdSize)
//        {
//			for (int i = 0; i <brdSize*brdSize; i++)
//            {
//				Button newButton = new Button();
//				newButton.Width =double.NaN;
//				newButton.Height =double.NaN;
//				stckPanel.Children.Add(newButton);
//            }
        
    }
}

