using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Teams
{

    //Данный класс отвечают за одну команду
    //На вход принимает: Имя команды, Фамилию тренера, Количество игроков, Счёт в последнем сезоне, Вид спорта (Тип перечисления KindsOfSport), и bool, отвечающий на вопрос - является ли команда профессиональной

    class Team
    {

        string _teamName = "NoName"; //Имя команды
        string _coachName = "NoName"; //Фамилия тренера
        int _playersAmount = 0;  //Количество игроков
        int _scoreInLastSeason = 0; //Счёт в последнем сезоне
        KindsOfSport _kindOfSport; //Вид спорта


        public string TeamName //Имя команды
        {
            get => _teamName;


            set
            {
                value = Regex.Replace(value, @"\s+", " "); //Удаляем лишние пробелы
                if (value.Length <= 30 && value != " " && value != "") _teamName = value; //Ограничение поставлено исходя из размеров ListBox-а, в котором имя отображается
            }

        }

        public string CoachName //Фамилия тренера
        {
            get => _coachName;

            set
            {
                value = Regex.Replace(value, @"\s+", " "); //Удаляем лишние пробелы
                if (value.Length <= 30 && value != " " && value != "") _coachName = value; //Ограничение поставлено исходя из размеров ListBox-а, в котором фамилия отображается
            }
        }


        public int PlayersAmount //Количество игроков
        {
            get => _playersAmount;

            set
            {
                if (value >= 0) _playersAmount = value;
            }
        }

        public int ScoreInLastSeason //Счёт в последнем сезоне
        {
            get => _scoreInLastSeason;

            set
            {
                _scoreInLastSeason = value;
            }

        }

        public KindsOfSport KindOfSport //Вид спорта
        {
            get => _kindOfSport;

            set
            {
                if (!Enum.IsDefined(typeof(KindsOfSport), value)) //Проверяем, есть ли такой вид
                {
                    _kindOfSport = 0;
                }
                else _kindOfSport = value;
            }
        }


        public bool IsProfessional { get; set; } = false; //bool-ean отвечающий на вопрос, является ли команда профессиональной


        //Основной конструктор
        public Team (string teamName, string coachName, int playersAmount, int scoreInLastSeason, KindsOfSport kindOfSport, bool isProfessional)
        {

            TeamName = teamName;

            CoachName = coachName;

            PlayersAmount = playersAmount;

            ScoreInLastSeason = scoreInLastSeason;

            KindOfSport = kindOfSport;

            IsProfessional = isProfessional;
        }

        //Метод позволяющий преобразовать в строку данные команды, для последующего отображения в TextBox-е
        public override string ToString()
        {
            string professionalStatus; //Проф. статус команды

            if (IsProfessional) professionalStatus = "Профессиональная команда";
            else professionalStatus = "Непрофессиональная команда";

            int scoreForEachPlayer = 0; //Среднее количество очков на игрока команды
            if (PlayersAmount > 0) scoreForEachPlayer = ScoreInLastSeason / PlayersAmount;

            //Формируем итоговую строку
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append($"Имя команды: {TeamName}");
            stringBuilder.AppendLine();
            stringBuilder.Append($"Имя тренера: {CoachName}");
            stringBuilder.AppendLine();
            stringBuilder.Append($"Количество игроков: {PlayersAmount}");
            stringBuilder.AppendLine();
            stringBuilder.Append($"Очков: {ScoreInLastSeason}");
            stringBuilder.AppendLine();
            stringBuilder.Append($"Вид спорта: {KindOfSport}");
            stringBuilder.AppendLine();
            stringBuilder.Append($"Количество очков на игрока: {scoreForEachPlayer}");
            stringBuilder.AppendLine();
            stringBuilder.Append($"{professionalStatus}");
            stringBuilder.AppendLine();

            return stringBuilder.ToString();
        }

    }
}
