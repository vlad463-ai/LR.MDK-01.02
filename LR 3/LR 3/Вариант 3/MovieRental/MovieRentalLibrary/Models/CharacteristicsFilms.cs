using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental
{
    internal class CharacteristicsFilms
    {
        private string name_;
        private string director_;
        private string actors_;
        private int cost_;
        private DateTime endDate_;
        private string photo_;
        private string genre_;

        public CharacteristicsFilms(string name, string director, string actors, int cost, DateTime endDate, string photo, string genre)
        {
            name_ = name;
            director_ = director;
            actors_ = actors;
            cost_ = cost;
            endDate_ = endDate;
            photo_ = photo;
            genre_ = genre;
        }

        public string Name
        {
            get { return name_; }
        }
        public string Genre
        {
            get { return genre_; }
        }


        public string Director
        {
            get { return director_; }
        }
        public string Actors
        {
            get { return actors_; }
        }
        public int Cost
        {
            get { return cost_; }
        }
        public DateTime EndDate
        {
            get { return endDate_; }
        }
        public string Photo
        {
            get { return photo_; }
        }
        public string GetFullInfo()
        {
            return $"Название: {name_}\n" +
                   $"Режиссер: {director_}\n" +
                   $"Актеры: {actors_}\n" +
                   $"Стоимость проката: {cost_} руб.\n" +
                   $"Срок завершения проката: {endDate_:dd.MM.yyyy}\n";
        }

    }
}
