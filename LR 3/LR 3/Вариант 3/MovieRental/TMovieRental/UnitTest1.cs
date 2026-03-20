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
        public void  StorageFilm_Film_ShouldLoadDataFromCsv() // Проверка загрузки данных из CSV-файла
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
        public void FilterFilms_ByGenre_ReturnsOnlyMatchingFilms() // Проверка фильтрации фильмов по жанру
        {

            List<CharacteristicsFilms> films = new List<CharacteristicsFilms>
            {
                new CharacteristicsFilms("Пункт назначения", "Джеймс Вонг", "Девон Сава", 250, new DateTime(2025, 1, 30), "photo1.jpg", "Хоррор"),
                new CharacteristicsFilms("Заклятие", "Джеймс Ван", "Вера Фармига", 300, new DateTime(2025, 1, 31), "photo2.jpg", "Хоррор"),
                new CharacteristicsFilms("Властелин колец", "Питер Джексон", "Элайджа Вуд", 350, new DateTime(2025, 2, 1), "photo3.jpg", "Фэнтези"),
                new CharacteristicsFilms("Гарри Поттер", "Крис Коламбус", "Дэниел Рэдклифф", 320, new DateTime(2025, 2, 1), "photo4.jpg", "Фэнтези")
            };
            
            List<CharacteristicsFilms> allFilms = films;
            List<CharacteristicsFilms> fantasyFilms = new List<CharacteristicsFilms>();
            foreach (CharacteristicsFilms film in allFilms)
            {
               
                if (film.Genre == "Фэнтези")
                {
                    fantasyFilms.Add(film);
                }
            }

            List<CharacteristicsFilms> result = fantasyFilms;
            
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual("Властелин колец", result[0].Name);
            Assert.AreEqual("Гарри Поттер", result[1].Name);
        }
        [TestMethod]
        public void CharacteristicsFilms_NameProperty_ReturnsCorrectName() // Проверка получения названия фильма через свойство Name
        {
            CharacteristicsFilms film = new CharacteristicsFilms("Заклятие", "Джеймс Ван", "Вера Фармига", 300, new DateTime(2025, 1, 31), "photo2.jpg", "Хоррор");
            string filmName = film.Name;
            Assert.IsNotNull(filmName, "название фильма не должно быть null");
            Assert.AreEqual("Заклятие", filmName, "Свойство Name должно возвращать 'Заклятие'");
        }


    }
}
