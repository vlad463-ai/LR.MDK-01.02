using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieRental;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TMovieRental
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1() // Проверка загрузки данных из CSV-файла
        {
            StorageFilm storage = new StorageFilm();
            List<CharacteristicsFilms> films = storage.Film();
            Assert.IsNotNull(films, "Список фильмов не должен быть пустым");
            Assert.IsTrue(films.Count > 0, "Список фильмов должен содержать хотя бы один элемент");
            if (films.Count > 0)
            {
                CharacteristicsFilms firstFilm = films[0];

                Assert.AreEqual("Пункт назначения", firstFilm.Name, "Название первого фильма не совпадает");

                Assert.AreEqual("Хоррор", firstFilm.Genre, "Жанр первого фильма не совпадает");

                Assert.AreEqual("Джеймс Вонг", firstFilm.Director, "Режиссер первого фильма не совпадает");

                Assert.AreEqual(250, firstFilm.Cost, "Стоимость первого фильма не совпадает");

            }
        }
        [TestMethod]
        public void TestMethod2() //Проверка метода формирования полной информации о фильме
        {
            DateTime testDate = new DateTime(2025, 12, 31);
            CharacteristicsFilms film = new CharacteristicsFilms( "Тестовый фильм","Иванов И.И.", "Петров П.П., Сидоров С.С.",500, testDate, "photo.jpg","Драма");
            string fullInfo = film.GetFullInfo();

            Assert.IsFalse(string.IsNullOrEmpty(fullInfo), "Строка с информацией не должна быть пустой");

            StringAssert.Contains(fullInfo, "Тестовый фильм", "Строка должна содержать название фильма");
           
            StringAssert.Contains(fullInfo, "Иванов И.И.", "Строка должна содержать режиссера");

            StringAssert.Contains(fullInfo, "Петров П.П., Сидоров С.С.", "Строка должна содержать актеров");

            StringAssert.Contains(fullInfo, "500 руб.", "Строка должна содержать стоимость с указанием валюты");

            StringAssert.Contains(fullInfo, "31.12.2025", "Строка должна содержать дату в формате дд.мм.гггг");
        }

        [TestMethod]
        public void TestMethod3() // Проверка фильтрации фильмов по жанру
        {
            List<CharacteristicsFilms> films = new List<CharacteristicsFilms>
            {
                new CharacteristicsFilms("Пункт назначения", "Джеймс Вонг", "Девон Сава", 250, new DateTime(2025, 1, 30), "photo1.jpg", "Хоррор"),
                new CharacteristicsFilms("Заклятие", "Джеймс Ван", "Вера Фармига", 300, new DateTime(2025, 1, 31), "photo2.jpg", "Хоррор"),
                new CharacteristicsFilms("Властелин колец", "Питер Джексон", "Элайджа Вуд", 350, new DateTime(2025, 2, 1), "photo3.jpg", "Фэнтези"),
                new CharacteristicsFilms("Гарри Поттер", "Крис Коламбус", "Дэниел Рэдклифф", 320, new DateTime(2025, 2, 1), "photo4.jpg", "Фэнтези")
            };
            string targetGenre = "Фэнтези";
            List<CharacteristicsFilms> filteredFilms = films.Where(f => f.Genre == targetGenre).ToList();
            Assert.AreEqual(2, filteredFilms.Count, "Должно быть 2 фильма жанра Фэнтези");

            foreach (var film in filteredFilms)
            {
                Assert.AreEqual(targetGenre, film.Genre, $"Фильм '{film.Name}' имеет жанр {film.Genre}, а ожидался {targetGenre}");
            }

            List<string> filmNames = filteredFilms.Select(f => f.Name).ToList();

            Assert.IsTrue(filmNames.Contains("Властелин колец"), "Список должен содержать фильм 'Властелин колец'");
            Assert.IsTrue(filmNames.Contains("Гарри Поттер"), "Список должен содержать фильм 'Гарри Поттер'");
            Assert.IsFalse(filmNames.Contains("Пункт назначения"), "Список НЕ должен содержать фильм 'Пункт назначения'");
            Assert.IsFalse(filmNames.Contains("Заклятие"), "Список НЕ должен содержать фильм 'Заклятие'");
        }


    }
}
