using System;
using System.IO;
using System.Windows.Forms;

namespace Test.WinForms
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			foreach (var language in Localization.Language.Load())
			{
				comboBoxLanguages.Items.Add(language);
			}
			comboBoxLanguages.SelectedIndex = 0;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			MessageBox.Show(getSelectedLanguage().Messages.Text1);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			MessageBox.Show(getSelectedLanguage().Messages.Text2);
		}

		private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
		{
			var language = getSelectedLanguage();
			languageBindingSource.DataSource = language;
			pictureBox1.Load(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Languages", language.Image));
		}

		private Localization.Language getSelectedLanguage()
		{
			return (Localization.Language) comboBoxLanguages.SelectedItem;
		}
	}
}
