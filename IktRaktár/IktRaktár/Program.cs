using IktRaktár.Models;

namespace IktRaktár
{
    /*CsapatTag 2 - Kereső és listázó funkciók []
- 1 - Keresés ID alapján
- 2 - Keresés név részlet alapján
- 3 - Teljes lista formázott megjelenítése
    A keresések során az ISearchable-t kell használni.

    Táblázatos listázás:
    ID | Név        | Készlet
    ----------------------------
    1  | Ceruza     | 100
    2  | Toll       | 50
        */
    internal class Program
    {
        static void Main(string[] args)
        {   /*ISearchable interface*/
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
            return list.Where(item => item.name.Contains(namePart)).ToList();
        }

            
        /*Teljes lista formázott megjelenítése*/
        public static void PrintTable(List<ISearchable> list)
        {
            Console.WriteLine("ID | Név        | Készlet");
            Console.WriteLine("----------------------------");
            foreach (var item in list)
            {
                Console.WriteLine($"{item.id}  | {item.name} | {item.stock}");
            }
        }   
    }
}
