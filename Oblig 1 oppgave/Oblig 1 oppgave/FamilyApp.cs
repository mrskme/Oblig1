using System;
using System.Collections.Generic;

namespace Oblig_1_oppgave
{
    public class FamilyApp
	{
		public string WelcomeMessage = "Velkommen til et slektstreprogram";
		public string CommandPrompt = "Kommando: ";
		private List<Person> _people;

		public FamilyApp(params Person[] people)
		{
			_people = new List<Person>(people);
		}
		public string HandleCommand(string command) 
		{
			string[] arr = command.Split(" ");

			if (command == "hjelp") 
			{
				return "Skriv hjelp for kommandoer\nSkriv liste for en liste med alle personene\nvis <id> for å vise til en bestemt person gjennom id";
			}
			if (command == "liste")
            {
                return GetListe();
            }
			if (arr[0] == "vis" && arr.Length > 1)
            {
                return GetVis(arr[1]);
            }
			return "";

		}
        private string GetVis(string arr1)
        {
            string info = "";
            string barn = "";
            if (long.TryParse(arr1, out long number))
            {
                foreach (var person in _people)
                {
                    if (person.Father != null && person.Father.Id == number ||
                        person.Mother != null && person.Mother.Id == number)
                    {
                        barn += $"    {person.FirstName} (Id={person.Id}) Født: {person.BirthYear}\n";
                    }

                    if (person.Id == number)
                    {
                        info += person.GetDescription();
                    }
                }

                if (info.Length == 0) return "Det er ingen personer med denne iden";

            }
            else return "du må skrive et siffer";

            string barnellerei = barn.Length > 0 ? "\n  Barn:\n" : "\n";
            return info + barnellerei + barn;
		}

        private string GetListe()
        {
            string list = "";
            foreach (var person in _people) 
            { 
                 list += person.GetDescription() + "\n";
            }
            return list;
        }
	}
}
