using IntroClassesFromJS.V2;

namespace IntroClassesFromJS
{
    internal class Demo2CompositeObject
    {
        public static void Run()
        {
            var model = new Model
            {
                Person = new Person
                {
                    FirstName = "Terje",
                    BirthYear = 1975
                }
            };



            /*
             let model = {            
                person: {
                    firstName: 'Terje',
                    birthYear: 1975,
                }
             }
             */
        }
    }
}
