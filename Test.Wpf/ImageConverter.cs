using System;
using System.Globalization;
using System.IO;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Test.Wpf
{
	[ValueConversion(typeof(string), typeof(ImageSource))]
	public class ImageConverter : IValueConverter
	{
		public Object Convert(Object value, Type targetType, Object parameter, CultureInfo culture)
		{
			string fileName = value as string;
			return !string.IsNullOrEmpty(fileName)
				? new BitmapImage(new Uri(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Languages", fileName)))
				: null;
		}

		public Object ConvertBack(Object value, Type targetType, Object parameter, CultureInfo culture)
		{
			throw new NotSupportedException();
		}
	}
}
