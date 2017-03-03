using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Test.Localization
{
	[XmlType]
	public class Language
	{
		[XmlElement]
		public string Button1
		{ get; set; }

		[XmlElement]
		public string Button2
		{ get; set; }

		[XmlElement]
		public string Image
		{ get; set; }

		[XmlElement]
		public LanguageMessages Messages
		{ get; set; }

		[XmlIgnore]
		public string Name
		{ get; set; }

		public override string ToString()
		{
			return Name;
		}

		public static List<Language> Load()
		{
			var xmlSerializer = new XmlSerializer(typeof (Language));
			string pathToLocales = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Languages");
			var result = new List<Language>();
			foreach (var file in new DirectoryInfo(pathToLocales).GetFiles("*.xml"))
			{
				using (var reader = new XmlTextReader(file.FullName))
				{
					var language = (Language) xmlSerializer.Deserialize(reader);
					language.Name = Path.GetFileNameWithoutExtension(file.Name);
					result.Add(language);
				}
			}
			return result;
		}
	}

	[XmlType]
	public class LanguageMessages
	{
		[XmlElement]
		public string Text1
		{ get; set; }

		[XmlElement]
		public string Text2
		{ get; set; }
	}
}
