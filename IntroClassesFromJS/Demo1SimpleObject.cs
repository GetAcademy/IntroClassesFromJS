namespace IntroClassesFromJS
{
    internal class Demo1SimpleObject
    {
        public static void Run()
        {
            // alt A
            var terje1 = new Person
            {
                FirstName = "Terje",
                BirthYear = 1975
            };
            Console.WriteLine(terje1.FirstName);

            // alt B
            var terje2 = new Person();
            terje2.FirstName = "Terje";
            terje2.BirthYear = 1975;


            /*
             Alt A
             let terje = {
                firstName: 'Terje',
                birthYear: 1975,
             }

             Alt B
             let terje = {};
             terje.firstName = 'Terje'
             terje.birthYear = 1975;


             terje.newField = 1; => ikke lov i C#

             */

        }
    }
}
