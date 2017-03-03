using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Test.Wpf
{
	public partial class MainWindow
	{
		public MainWindow()
		{
			InitializeComponent();

			comboBoxLanguages.ItemsSource = Localization.Language.Load();
			comboBoxLanguages.SelectedIndex = 0;
		}

		private void button1Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show(getSelectedLanguage().Messages.Text1);
		}

		private void button2Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show(getSelectedLanguage().Messages.Text2);
		}

		private Localization.Language getSelectedLanguage()
		{
			return (Localization.Language) comboBoxLanguages.SelectedItem;
		}

		private bool languageWasLoaded;

		private void comboBox1_SelectedValueChanged(object sender, SelectionChangedEventArgs e)
		{
			var languageProvider = (ObjectDataProvider) Resources["language"];
			if (!languageWasLoaded)
			{
				languageProvider.ObjectType = null;
				languageWasLoaded = true;
			}
			languageProvider.ObjectInstance = getSelectedLanguage();
		}
	}
}
