using Sandbox1.Buildings;
using Sandbox1.Enums;
using Sandbox1.People;

namespace Sandbox1
{
    public class Program
    {
        static void Main()
        {
            School school = new School("Athene", 1000, new List<Philosopher>());

            Console.WriteLine(school.People.Count);

            school = new School("Megara", 800, new List<Philosopher>(), new List<Person>());

            //PRISON
            Prisoner prisoner1 = new Prisoner("John Doe", new DateTime(2027, 10, 28), 16, "Theft", 1);
            Prisoner prisoner2 = new Prisoner("Jane Doe", new DateTime(2029, 5, 12), 25, "Fraud", 2);
            Prisoner prisoner3 = new Prisoner("Mike Smith", new DateTime(2045, 12, 1), 30, "Murder", 3);
            Prisoner prisoner4 = new Prisoner("Alice Johnson", new DateTime(2035, 3, 14), 12, "Vandalism", 1);
            Prisoner prisoner5 = new Prisoner("Robert Brown", new DateTime(2040, 8, 22), 57, "Drug Trafficking", 3);
            Prisoner prisoner6 = new Prisoner("Emma Davis", new DateTime(2032, 4, 9), 45, "Kidnapping", 2);
            Prisoner prisoner7 = new Prisoner("Liam Garcia", new DateTime(2026, 11, 30), 16, "Theft", 1);
            Prisoner prisoner8 = new Prisoner("Sophia Martinez", new DateTime(2031, 6, 20), 34, "Fraud", 3);
            Prisoner prisoner9 = new Prisoner("Oliver Wilson", new DateTime(2028, 2, 11), 63, "Murder", 3);
            Prisoner prisoner10 = new Prisoner("Isabella Anderson", new DateTime(2036, 12, 25), 21, "Burglary", 2);
            Prisoner prisoner11 = new Prisoner("James Taylor", new DateTime(2033, 9, 5), 50, "Assault", 3);
            Prisoner prisoner12 = new Prisoner("Mia Thomas", new DateTime(2038, 1, 18), 17, "Shoplifting", 1);
            Prisoner prisoner13 = new Prisoner("William Harris", new DateTime(2027, 5, 30), 8, "Property Damage", 1);
            Prisoner prisoner14 = new Prisoner("Charlotte Clark", new DateTime(2042, 4, 7), 92, "Fraud", 3);
            Prisoner prisoner15 = new Prisoner("Ethan Lewis", new DateTime(2029, 10, 10), 33, "Robbery", 2);
            Prisoner prisoner16 = new Prisoner("Amelia Hall", new DateTime(2047, 7, 22), 17, "Cybercrime", 1);
            Prisoner prisoner17 = new Prisoner("Lucas Allen", new DateTime(2030, 11, 14), 64, "Armed Robbery", 3);
            Prisoner prisoner18 = new Prisoner("Harper Young", new DateTime(2026, 6, 9), 25, "Bribery", 2);
            Prisoner prisoner19 = new Prisoner("Elijah King", new DateTime(2034, 8, 5), 42, "Theft", 2);
            Prisoner prisoner20 = new Prisoner("Ava Wright", new DateTime(2039, 3, 17), 71, "Forgery", 3);
            Prisoner prisoner21 = new Prisoner("Benjamin Scott", new DateTime(2032, 2, 28), 36, "Tax Evasion", 2);
            Prisoner prisoner22 = new Prisoner("Luna Green", new DateTime(2041, 5, 12), 10, "Shoplifting", 1);
            Prisoner prisoner23 = new Prisoner("Henry Baker", new DateTime(2037, 12, 1), 88, "Espionage", 3);
            Prisoner prisoner24 = new Prisoner("Evelyn Adams", new DateTime(2028, 7, 19), 19, "Pickpocketing", 2);

            // Список охоронців
            Guard guard1 = new Guard("Officer Smith", 40, 2000);
            Guard guard2 = new Guard("Officer Johnson", 35, 1800);
            Guard guard3 = new Guard("Officer Brown", 45, 2200);
            Guard guard4 = new Guard("Officer Davis", 38, 1900);
            Guard guard5 = new Guard("Officer Wilson", 50, 2500);
            Guard guard6 = new Guard("Officer Martinez", 32, 1700);
            Guard guard7 = new Guard("Officer Anderson", 29, 1600);
            Guard guard8 = new Guard("Officer Taylor", 41, 2100);
            Guard guard9 = new Guard("Officer Thomas", 37, 1850);
            Guard guard10 = new Guard("Officer Moore", 42, 2300);
            Guard guard11 = new Guard("Officer White", 33, 1750);
            Guard guard12 = new Guard("Officer Harris", 47, 2400);
            Guard guard13 = new Guard("Officer Martin", 39, 1950);
            Guard guard14 = new Guard("Officer Garcia", 36, 1820);
            Guard guard15 = new Guard("Officer Clark", 43, 2250);
            Guard guard16 = new Guard("Officer Lewis", 34, 1800);
            Guard guard17 = new Guard("Officer Young", 31, 1680);
            Guard guard18 = new Guard("Officer Hall", 48, 2450);
            Guard guard19 = new Guard("Officer King", 44, 2200);
            Guard guard20 = new Guard("Officer Scott", 30, 1650);
            Guard guard21 = new Guard("Officer Green", 46, 2350);
            Guard guard22 = new Guard("Officer Adams", 37, 1900);
            Guard guard23 = new Guard("Officer Baker", 50, 2500);
            Guard guard24 = new Guard("Officer Gonzalez", 28, 1550);
            Guard guard25 = new Guard("Officer Nelson", 40, 2000);
            Guard guard26 = new Guard("Officer Carter", 33, 1750);
            Guard guard27 = new Guard("Officer Perez", 39, 1950);
            Guard guard28 = new Guard("Officer Roberts", 45, 2200);
            Guard guard29 = new Guard("Officer Turner", 43, 2250);
            Guard guard30 = new Guard("Officer Phillips", 36, 1820);
            Guard guard31 = new Guard("Officer Evans", 47, 2400);
            Guard guard32 = new Guard("Officer Collins", 35, 1800);
            Guard guard33 = new Guard("Officer Stewart", 42, 2300);
            Guard guard34 = new Guard("Officer Sanchez", 38, 1900);
            Guard guard35 = new Guard("Officer Bell", 32, 1700);
            Guard guard36 = new Guard("Officer Richardson", 29, 1600);
            Guard guard37 = new Guard("Officer Price", 48, 2450);
            Guard guard38 = new Guard("Officer Reed", 44, 2200);
            Guard guard39 = new Guard("Officer Bryant", 34, 1800);
            Guard guard40 = new Guard("Officer Bennett", 31, 1680);
            Guard guard41 = new Guard("Officer Wilson", 38, 2100);
            Guard guard42 = new Guard("Officer Martinez", 43, 2300);
            Guard guard43 = new Guard("Officer Lee", 32, 2000);
            Guard guard44 = new Guard("Officer Harris", 29, 1900);
            Guard guard45 = new Guard("Officer Clark", 50, 2500);
            Guard guard46 = new Guard("Officer Scott", 36, 2200);
            Guard guard47 = new Guard("Officer Adams", 41, 2400);
            Guard guard48 = new Guard("Officer Baker", 39, 2150);
            Guard guard49 = new Guard("Officer Perez", 34, 2050);
            Guard guard50 = new Guard("Officer Murko", 65, 1680);



            Director director1 = new Director("Director White", 50, 5000);
            Director director2 = new Director("Director Green", 45, 4800);
            Director director3 = new Director("Director Black", 55, 5200);

            // Створюємо в'язниці з різними типами
            Prison juvenilePrison = new Prison("Juvenile Prison St.", 2000000, new List<Guard> { guard1, guard2, guard3, guard4, guard5, guard6, guard7 }, director1, PrisonType.Juvenal);
            Prison rehabilitationCenterPrison = new Prison("Rehabilitation Center St.", 3000000, new List<Guard> {  guard8, guard9, guard10, guard11, guard12, guard13, guard14, guard15, guard16, guard17, guard18, guard19, guard20, guard21, guard22, guard23, guard24, guard25, guard26 }, director2, PrisonType.RehabilitationCenter);
            Prison dangerousPrison = new Prison("Dangerous Prison St.", 5000000, new List<Guard> {  guard27, guard28, guard29, guard30, guard31, guard32, guard33, guard34, guard35, guard36, guard37, guard38, guard39, guard40, guard41, guard42, guard43, guard44, guard45, guard46, guard47, guard48, guard49,guard50  }, director3, PrisonType.Dangerous);
            
            //бюджет в'язниць
            juvenilePrison.Budget = 2000000;
            rehabilitationCenterPrison.Budget = 3000000;
            dangerousPrison.Budget = 5000000;

            // Додаємо в'язнів до відповідних в'язниць
            juvenilePrison.AddPrisoner(prisoner1);
            juvenilePrison.AddPrisoner(prisoner4);
            juvenilePrison.AddPrisoner(prisoner7);
            juvenilePrison.AddPrisoner(prisoner12);
            juvenilePrison.AddPrisoner(prisoner13);
            juvenilePrison.AddPrisoner(prisoner16);
            juvenilePrison.AddPrisoner(prisoner22);
            juvenilePrison.CheckSafetyAndEscape();

            rehabilitationCenterPrison.AddPrisoner(prisoner2);
            rehabilitationCenterPrison.AddPrisoner(prisoner5);
            rehabilitationCenterPrison.AddPrisoner(prisoner6);
            rehabilitationCenterPrison.AddPrisoner(prisoner10);
            rehabilitationCenterPrison.AddPrisoner(prisoner15);
            rehabilitationCenterPrison.AddPrisoner(prisoner18);
            rehabilitationCenterPrison.AddPrisoner(prisoner19);
            rehabilitationCenterPrison.AddPrisoner(prisoner21);
            rehabilitationCenterPrison.AddPrisoner(prisoner24);
            rehabilitationCenterPrison.CheckSafetyAndEscape();

            dangerousPrison.AddPrisoner(prisoner3);
            dangerousPrison.AddPrisoner(prisoner8);
            dangerousPrison.AddPrisoner(prisoner9);
            dangerousPrison.AddPrisoner(prisoner11);
            dangerousPrison.AddPrisoner(prisoner14);
            dangerousPrison.AddPrisoner(prisoner17);
            dangerousPrison.AddPrisoner(prisoner20);
            dangerousPrison.AddPrisoner(prisoner23);
            dangerousPrison.CheckSafetyAndEscape();

            // Вивести інформацію про директорів та список в'язнів для кожної в'язниці
            Console.WriteLine("Juvenile Prison Director: " + juvenilePrison.Director.Name);
            juvenilePrison.ListPrisoners();

            Console.WriteLine("\nRehabilitation Center Director: " + rehabilitationCenterPrison.Director.Name);
            rehabilitationCenterPrison.ListPrisoners();

            Console.WriteLine("\nDangerous Prison Director: " + dangerousPrison.Director.Name);
            dangerousPrison.ListPrisoners();

        }
    }
}
