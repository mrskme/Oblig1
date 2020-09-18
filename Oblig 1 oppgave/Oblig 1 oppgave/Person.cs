using System.Collections.Generic;

namespace Oblig_1_oppgave
{
	public class Person
	{
		public int Id;
		public string FirstName;
		public string LastName;
		public int BirthYear;
		public int DeathYear;
		public Person Father;
		public Person Mother;

        public string GetDescription()
        {
            string description = "";
            if (FirstName != null) description += $"{FirstName} ";
            if (LastName != null) description += $"{LastName} ";
            description += $"(Id={Id})";
            if (BirthYear != 0) description += $" Født: {BirthYear}";
            if (DeathYear != 0) description += $" Død: {DeathYear}";

            if (Father != null && Father.FirstName == null) description += $" Far: (Id={Father.Id})";
            if (Father != null && Father.FirstName != null) description += $" Far: {Father.FirstName} (Id={Father.Id})";

            if (Mother != null && Mother.FirstName == null) description += $" Mor: (Id={Mother.Id})";
            if (Mother != null && Mother.FirstName != null) description += $" Mor: {Mother.FirstName} (Id={Mother.Id})";

            return description;
        }
    }
}
