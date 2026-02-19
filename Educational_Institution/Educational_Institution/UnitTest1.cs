using System;
using System.Collections.Generic;
using InstitutionLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Educational_Institution
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            InstitutionEduc institution = new InstitutionEduc();
            
            institution.allGroups_["Группа 1"] = new List<Student>
            {
                new Student("Иван", "Иванов", 40),
                new Student("Петр", "Петров", 41),
                new Student("Мария", "Сидорова", 39)
            };
            institution.allGroups_["Группа 2"] = new List<Student>
            {
                new Student("Анна", "Смирнова", 22),
                new Student("Дмитрий", "Козлов", 20),
                new Student("Елена", "Морозова", 21)
            };

            //Ожидаемый список студентов для группы 1
            List<Student> expected = new List<Student>();
            expected.Add(new Student("Иван", "Иванов", 40)); 
            expected.Add(new Student("Петр", "Петров", 41));
            expected.Add(new Student("Мария", "Сидорова", 39));

            List<Student> result = institution.studentGroupRequest("Группа 1");

            Assert.AreEqual(expected[0].GetFullName(), result[0].GetFullName());
            Assert.AreEqual(expected[1].GetFullName(), result[1].GetFullName());
            Assert.AreEqual(expected[2].GetFullName(), result[2].GetFullName());

           
        }
    }
}
