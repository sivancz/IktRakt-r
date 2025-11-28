using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IktRaktár.Models.Interfaces
{
    internal interface ISearchable
    {
        public interface ISearchable

        {

            int id

            {

                get; set;

            }

            string name

            {

                get; set;

            }


        }

        /*Keresés ID alapján*/

        public static ISearchable FindByID(int id, List<ISearchable> list)

        {

            return list.FirstOrDefault(item => item.id == id);

        }

        /*Keresés név részlet alapján*/

        public static List<ISearchable> FindByName(string namePart, List<ISearchable> list)

        {

            return list.Where(item => item.name.Contains(namePart, StringComparison.OrdinalIgnoreCase)).ToList();

        }
    }
}
