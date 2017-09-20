
using System;
using System.IO;

namespace Interview_Exercise
{
    public class CountryCodeRepository
    {
        public string dataPath = Path.Combine(
        System.Environment.GetFolderPath(System.Environment.SpecialFolder.CommonApplicationData),
        "Interview-Exercise"); // i.e. C:\ProgramData\Interview-Exercise

        public void Add(Country country) {

            

                
                string[] lines = System.IO.File.ReadAllLines(dataPath);

                // Display the file contents by using a foreach loop.
                System.Console.WriteLine("Contents of WriteLines2.txt = ");
                foreach (string line in lines)
                {
                    // if Country is not found
                    if (!(line.Contains(country.Code) && line.Contains(country.Name)))
                    {
                        string text = System.IO.File.ReadAllText(dataPath);
                        System.Console.WriteLine(country.Code + " - " + country.Name, text);
                    }
                    else Console.WriteLine("Country already stored.");

                }


        }

        public Country Get(string countryCode)
        {

            string[] lines = System.IO.File.ReadAllLines(dataPath);
            foreach (string line in lines)
            {
                // if Country is not found
                if (line.Contains(countryCode))
                {
                    string[] splitStrings = line.Split('-');
                    foreach (string s in splitStrings)
                    {
                        s.Trim();
                    }

                    Country newCountry = new Country();
                    newCountry.Code = splitStrings[0];
                    newCountry.Name = splitStrings[1];

                    return newCountry;
                }

            }

                    Console.WriteLine("Country not found");
                    return null;
                

            }




        void Update(Country country) { }
        void Delete(string countryCode) { }





        void Clear() { }
    }
}
