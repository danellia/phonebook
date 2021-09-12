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
			if (random.Next(0, 10) == 9)
            {
				this.phoneNumber = random.Next(minPhoneValue, maxPhoneValue) * 100 + year % 100;
			}
            else
            {
				this.phoneNumber = random.Next(minPhoneValue, maxPhoneValue) * 100 + random.Next(minYearValue, maxYearValue) / 100;
			}
		}
        public override string ToString()
        {
            return String.Format("{0}, {1}, {2}", lastName, phoneNumber, year);
        }
    }
	public class Serializer
	{
		XmlSerializer xmlSerializer;
		string logName = "PhoneBook.xml";
		string lastNamesList = "LastNames.txt";
		public Serializer()
		{
			if (!File.Exists(logName))
			{
				FileStream fs = File.Create(logName);
				fs.Close();
			}
		}
		public void serialize(PhoneBook book)
        {
			xmlSerializer = new XmlSerializer(typeof(PhoneBook));
			using (TextWriter reader = new StreamWriter(logName))
			{
				xmlSerializer.Serialize(reader, book);
			}
        }
		public PhoneBook deserialize()
        {
			PhoneBook book;
			xmlSerializer = new XmlSerializer(typeof(PhoneBook));
			using (StreamReader reader = new StreamReader(logName))
            {
				book = (PhoneBook)xmlSerializer.Deserialize(reader);
			}
			return book;
		}
		public void createPhoneBook()
        {
			PhoneBook book = new PhoneBook();
			using (StreamReader reader = new StreamReader(lastNamesList))
            {
                while (!reader.EndOfStream) 
				{
					book.addEntry(new PhoneBookEntry(reader.ReadLine()));
				}
			}
			serialize(book);
        }
	}
}
