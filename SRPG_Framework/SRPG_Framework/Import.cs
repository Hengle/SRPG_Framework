using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SRPG_Framework
{
    public class Import
    {
        // for importing player units
        public List<PlayerUnit> GetUnits()
        {
            // open a stream
            Stream str = File.OpenRead("units.txt");

            // create stream reader
            StreamReader reader = new StreamReader(str);

            string line;

            List<PlayerUnit> listToReturn = new List<PlayerUnit>();

            while((line = reader.ReadLine()) != null)
            {
                string[] lineArray = line.Split(',');
                PlayerUnit newPlayer = new PlayerUnit(null, 0, 0, 0, 0, true, lineArray[1], lineArray[0], int.Parse(lineArray[2]), int.Parse(lineArray[3]), int.Parse(lineArray[4]),
                                                        int.Parse(lineArray[5]), int.Parse(lineArray[6]), int.Parse(lineArray[7]), int.Parse(lineArray[8]), int.Parse(lineArray[9]), int.Parse(lineArray[10]), int.Parse(lineArray[11]),
                                                        int.Parse(lineArray[12]), int.Parse(lineArray[13]), int.Parse(lineArray[14]), int.Parse(lineArray[15]));
                listToReturn.Add(newPlayer);
            }

            return listToReturn;
        }

        // for importing items
        public List<Item> GetItems()
        {
            // open a stream
            Stream str = File.OpenRead("items.txt");

            // create stream reader
            StreamReader reader = new StreamReader(str);

            string line;

            List<Item> listToReturn = new List<Item>();

            while ((line = reader.ReadLine()) != null)
            {
                string[] lineArray = line.Split(',');
                if(lineArray[0] == "w")
                {
                    Weapon weapon = new Weapon(null, lineArray[1], lineArray[2], int.Parse(lineArray[3]), int.Parse(lineArray[4]));
                    listToReturn.Add(weapon);
                }
            }

            return listToReturn;
        }
    }
}
