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
        InstitutionEduc institution = new InstitutionEduc();
        [TestMethod]
        public void TestStudentGroupOne()
        {
     
            //1 тест
            List<Student> expected1 = new List<Student>();
            expected1.Add(new Student("Иван", "Иванов", 40));
            expected1.Add(new Student("Петр", "Петров", 41));
            expected1.Add(new Student("Мария", "Сидорова", 39));

            List<Student> expected2 = new List<Student>();
            expected1.Add(new Student("Влад", "Смирнов", 18));
            expected1.Add(new Student("Кирилл", "Шамарин", 20));
            expected1.Add(new Student("Никита", "Андрианов", 19));

            institution.allGroups_["Группа 1"] = expected1;
            institution.allGroups_["Группа П-30"] = expected2;

            List<Student> result = institution.StudentGroupRequest("Группа 1");
            List<Student> result2 = institution.StudentGroupRequest("Группа П-30");
            List<Student> result3 = institution.StudentGroupRequest("Группа 123");

            CollectionAssert.AreEqual(expected1, result, "Такой группы нету");
            CollectionAssert.AreEqual(expected2, result2, "Такой группы нету");
            Assert.IsNull(result3);



        }
        [TestMethod]
        public void TestStudentGroupTwo()
        {

            // 2 тест
            List<Student> expected2 = new List<Student>();
            expected2.Add(new Student("Анна", "Смирнова", 22));
            expected2.Add(new Student("Дмитрий", "Козлов", 20));

            institution.allGroups_["Группа 2"] = expected2;
            List<Student> result2 = institution.StudentGroupRequest("Группа 2");
            CollectionAssert.AreEqual(expected2, result2, "В группе 2 должно быть 2 студента");
        }
        [TestMethod]
        public void TestStudentGroupThree()
        {
            // 3 тест
            List<Student> expected3 = new List<Student>();

            institution.allGroups_["Группа 3"] = expected3;
            List<Student> result3 = institution.StudentGroupRequest("Группа 3");
            CollectionAssert.AreEqual(expected3, result3, "В группе 3 не должно быть  студентов");
        }
       
       
    }
}
