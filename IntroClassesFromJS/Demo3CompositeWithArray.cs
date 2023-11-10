using IntroClassesFromJS.V3;

namespace IntroClassesFromJS
{
    internal class Demo3CompositeWithArray
    {
        public static void Run()
        {
            var model = new Model
            {
                App = new App
                {
                    CurrentUser = "Terje",
                    CurrentPage = "Main",
                },
                People = new Person[]
                {
                    new Person
                    {
                        FirstName = "Terje",
                        BirthYear = 1975
                    }
                },
            };



            /*
             let model = {      
                app: {
                    currentUser: 'terje',
                    currentPage: 'main',
                },
                people: [{
                    firstName: 'Terje',
                    birthYear: 1975,
                }],
             }
             */
        }
    }
}
