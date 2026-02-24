using System;
using System.Collections.Generic;
using System.Linq;
using InstitutionLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Educational_Institution
{
    [TestClass]
    public class TestMetods
    {
        [TestMethod]
        public void TestStudent()
        {
            InstitutionEduc institution = new InstitutionEduc();


            //Ожидаемый список студентов для группы 1
            List<Student> expected1 = new List<Student>();
            expected1.Add(new Student("Иван", "Иванов", 40));
            expected1.Add(new Student("Петр", "Петров", 41));
            expected1.Add(new Student("Мария", "Сидорова", 39));
            institution.allGroups_["Группа 1"] = new List<Student>
            {
                new Student("Иван", "Иванов", 40),
                new Student("Петр", "Петров", 41),
                new Student("Мария", "Сидорова", 39)
            };
            List<Student> result1 = institution.StudentGroupRequest("Группа 1");
            CollectionAssert.AreEqual(expected1, result1,"В группе 1 должно быть 3 студента");


            List<Student> expected2 = new List<Student>();
            expected1.Add(new Student("Анна", "Смирнова", 22));
            expected1.Add(new Student("Дмитрий", "Козлов", 20));
            institution.allGroups_["Группа 2"] = new List<Student>
            {
                new Student("Анна", "Смирнова", 22),
                new Student("Дмитрий", "Козлов", 20),
            };
            List<Student> result2 = institution.StudentGroupRequest("Группа 2");
            CollectionAssert.AreEqual(expected2, result2, "В группе 2 должно быть 2 студента");





        }
    }
}
