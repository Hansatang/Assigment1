using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Models;

namespace Assigment_1.Data
{
    public class FamilyService : IFamilyService
    {
        public IList<Family> FamilyList { get;  set; }
        private string productsFile = "families.json";

        public FamilyService()
        {
            // Connect();
            if (!File.Exists(productsFile))
            {
                string productsAsJson = JsonSerializer.Serialize(FamilyList);
                File.WriteAllText(productsFile, productsAsJson);
            }
            else
            {
                string content = File.ReadAllText(productsFile);
                FamilyList = JsonSerializer.Deserialize<List<Family>>(content);
            }
        }


        public IList<Adult> AdultList { get; }

        public void Save()
        {
            string productsAsJson = JsonSerializer.Serialize(FamilyList);
            File.WriteAllText(productsFile, productsAsJson);
        }
        
        
    
    }
}