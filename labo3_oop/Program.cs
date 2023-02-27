﻿using System;
using System.Collections.Generic;

namespace labo3_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher mar = new Teacher("Cedric", "Marchand", 2000);
            Teacher lur = new Teacher("Quentin", "Lurkin", 2200);
            Activity embeeded = new Activity(mar, "Electronique Embarquée", "3BE-EE", 6);
            Activity gpu_computing = new Activity(mar, "GPU Computing", "4MIN-GPU", 6);
            Activity img_processing = new Activity(mar, "Image processing", "4MIN-IP", 5);
            Cote cote1 = new Cote(embeeded, 17);
            Cote cote2 = new Cote(gpu_computing, 14);
            Student s = new Student("Nathan", "Buchin",new List<Evaluations>() {cote1,cote2});
            Cote c = new Cote(img_processing,14);
            s.Add(c);
        
            Console.WriteLine(s.Rapport());
        }
    }
}
