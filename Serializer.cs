using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace lab2
{
	[Serializable]
	[XmlRoot("PhoneBook")]
	public class PhoneBook
    {
		[XmlArray("Clients")]
		[XmlArrayItem("Client")]
		public List<PhoneBookEntry> entries { get; set; } = new List<PhoneBookEntry>();
		public void addEntry(PhoneBookEntry entry)
        {
			entries.Add(entry);
        }
		
    }
	[Serializable]
	public class PhoneBookEntry
	{
		[XmlElement("LastName")]
		public string lastName { get; set; }
		[XmlElement("PhoneNumber")]
		public int phoneNumber { get; set; }
		[XmlElement("Year")]
		public int year { get; set; }
		public PhoneBookEntry() { }
		public PhoneBookEntry(string name)
        {
			int minPhoneValue = 10;
			int maxPhoneValue = 99;
			int minYearValue = 1990;
			int maxYearValue = 2021;
			Random random = new Random();

			this.lastName = name;
			this.year = random.Next(minYearValue, maxYearValue);
			this.phoneNumber = random.Next(minPhoneValue, maxPhoneValue) * 100 + random.Next(minYearValue, maxYearValue) / 100;
        }
        public override string ToString()
        {
            return String.Format("{0}, {1}, {2}", lastName, phoneNumber, year);
        }
    }
	public class Serializer
	{
		public XmlDocument log;
		FileStream fs;
		string logName = "PhoneBook.xml";
		string lastNamesList = "LastNames.txt";
		List<PhoneBookEntry> output = new List<PhoneBookEntry>();
		public Serializer()
		{
			log = new XmlDocument();
			if (!File.Exists(logName))
			{
				fs = File.Create(logName);
				fs.Close();
			}
		}

		public void serialize(PhoneBook obj)
        {
			XmlSerializer xmlSerializer = new XmlSerializer(typeof(PhoneBook));
			TextWriter tw = new StreamWriter(logName);
			xmlSerializer.Serialize(tw, obj);
			tw.Close();
        }

		public PhoneBook deserialize()
        {
			PhoneBook book;
			XmlSerializer xmlSerializer = new XmlSerializer(typeof(PhoneBook));
			using (TextReader tr = new StreamReader(logName))
            {
				book = (PhoneBook)xmlSerializer.Deserialize(tr);
			}
			return book;
		}
		public void createPhoneBook()
        {
			PhoneBook book = new PhoneBook();
			Random random = new Random();
			using (StreamReader reader = new StreamReader(lastNamesList))
            {
                while (!reader.EndOfStream) 
				{
					book.addEntry(new PhoneBookEntry(reader.ReadLine()));
				}
			}
			serialize(book);
        }

		public List<PhoneBookEntry> getObject()
        {
			PhoneBook bookDeserialized = deserialize();
            foreach (var entry in bookDeserialized.entries)
            {
                output.Add(entry);
            }
            return output;
        }
	}
}
