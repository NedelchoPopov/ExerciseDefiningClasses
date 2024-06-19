/*
3
Peter 12
Sam 31
Ivan 48

5
Niki 33
Yord 88
Teo 22
Lily 44
Stan 11

 */
namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Person> people = new();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                string name = input[0];
                int age = int.Parse(input[1]);

                Person person = new Person(name, age);

                people.Add(person);
            }

            var peopleWith30PlusYear = people.Where(x => x.Age > 30)
                .OrderBy(x => x.Name).ToList();


            foreach (var item in peopleWith30PlusYear)
            {
                Console.WriteLine($"{item.Name} - {item.Age}");
            }

        }
    }
}