using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental
{
    internal class StorageFilm : IFilm
    {
        public List<CharacteristicsFilms> Film()
        {
            List<CharacteristicsFilms> allMovie = new List<CharacteristicsFilms>();
            string path = @"D:\01.01\LR 3\Фильмы\data.csv";
            StreamReader info = new StreamReader(path);
            string line;
            while ((line = info.ReadLine()) != null)
            {
                string[] lines = line.Split(';');
                allMovie.Add(new CharacteristicsFilms(
                lines[1],  // Название фильма
                lines[2],  // Режиссер
                lines[3],  // Актеры
                Convert.ToInt32(lines[4]),  // Стоимость
                Convert.ToDateTime(lines[5]),  // Дата окончания проката
                lines[6],  // Путь к фото
                lines[0]   // Жанр
                ));
            }
            info.Close();
            return allMovie;



        }
    }
}
