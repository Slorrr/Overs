using hackathon_21._04._23;
using System.Security.Cryptography.Pkcs;

namespace hackathon_21._04._23
{
    public class DB
    {
        public List<project> projects = new List<project>();

        
        
        public DB()
        {
            project p1 = new project();
            p1.Id = 1;
            p1.Name = "ООО Ромашка";
            p1.srok = new DateTime(2023, 8, 15);
            p1.Money = 26500000;
            projects.Add(p1);

            project p2 = new project();
            p2.Id = 2;
            p2.Name = "ООО Росстрой";
            p2.srok = new DateTime(2024, 6, 10);
            p2.Money = 31500000;
            projects.Add(p2);

            project p3 = new project();
            p3.Id = 3;
            p3.Name = "ООО ДорСнаб";
            p3.srok = new DateTime(2023, 10, 5);
            p3.Money = 14750000;
            projects.Add(p3);

            project p4 = new project();
            p4.Id = 4;
            p4.Name = "ООО ГлавСтрой";
            p4.srok = new DateTime(2024, 2, 20);
            p4.Money = 7700000;
            projects.Add(p4);
        }
    }
}
