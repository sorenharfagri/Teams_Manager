using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teams
{

    //Коллекция объектов Team
    class Teams
    {
        public List<Team> Squads;
        public int ProfessionalTeamCount { get; private set; } = 0; //Счётчик, используется для подсчёта проф. команд в коллекции
        public int UnprofessionalTeamCount { get; private set; } = 0; //Счётчик непроф. команд


        public Teams()
        {
            Squads = new List<Team>();
        }

        //Метод для создания нового объекта Team, и добавления его в коллекцию
        public void AddTeam (string teamName, string coachName, int amountOfPlayers, int scoreInLastSeason, KindsOfSport kindOfSport, bool isProfessional)
        {

            if (isProfessional) ProfessionalTeamCount++; //Увеличиваем или уменьшаем счётчик в зависимости от профессионализма команды
            else UnprofessionalTeamCount++;

            Squads.Add( new Team(teamName, coachName, amountOfPlayers, scoreInLastSeason, kindOfSport, isProfessional)); //Создаём объект Team, добавляем в коллекцию
        }

        //Метод для удаления всех команд из коллекции
        public void DeleteAll() 
        {
            Squads.Clear();

            ProfessionalTeamCount = 0; //Не забываем обнулить счётчики проф. непроф. команд
            UnprofessionalTeamCount = 0;
        }

        //Метод для удаления конкретной команды из коллекции
        //Принимает в себя индекс команды, которую необходимо удалить
        //Возвращает bool, в зависимости от успешности удаления
        public bool DeleteTeam(int index)
        {
            if (index > Squads.Count)
            {
                return false; //Если команды нет в коллекции - возвращаем false для обработки ошибки
            }

            //При удалении команды так-же не забываем обновить счётчик
            if (Squads[index -1].IsProfessional) ProfessionalTeamCount--;
            else UnprofessionalTeamCount--;

            Squads.RemoveAt(index - 1); //Удаляем из коллекции
            return true;
        }

        //Метод для получения количества непроф. команд в коллекции
        public int AmountOfUnprofessionals() 
        {
            int unprofessionalTeams = 0;

            foreach (Team team in Squads)
            {
                if (!team.IsProfessional) unprofessionalTeams++; //Пробегаемся по коллекции, проверяем свойство IsProfessional
            }

            return unprofessionalTeams;
        }

        public int AmountOfProfessionals() //Метод для получения количества проф. команд, аналогичен методу выше
        {
            int professionalTeams = 0;

            foreach (Team team in Squads)
            {
                if (team.IsProfessional) professionalTeams++;
            }

            return professionalTeams;
        }

        public int ScoreSummOfProfessionals() //Метод для получения суммарного количества очков всех проф. команд в коллекции
        {
            int summOfPoints = 0;

            foreach (Team team in Squads)
            {
                if (team.IsProfessional) summOfPoints += team.ScoreInLastSeason; //Пробегаемся по коллекции, проверяем свойство IsProfessional, суммируем в счётчик очки проф. команд
            }

            return summOfPoints;
        }

        public int ScoreSummOfUnprofessionals() //Метод для получения суммарного количества очков всех непроф. команд в коллекции, аналогичен методу выше
        {
            int summOfPoints = 0;

            foreach (Team team in Squads)
            {
                if (!team.IsProfessional) summOfPoints += team.ScoreInLastSeason;
            }

            return summOfPoints;
        }

        public int AverageScorePerTeam() //Метод для получения среднего количества очков на одну команду
        {
            int summOfPoints = 0;

            foreach (Team team in Squads)
            {
                summOfPoints += team.ScoreInLastSeason; //Пробегаемся по всем командам в коллекции, суммируем очки
            }


            if (Squads.Count > 0) summOfPoints = summOfPoints / Squads.Count; //Делим сумму очков всех команд, на количество команд. Предотвращаем деление на 0
            return summOfPoints;
        }

        //Метод позволяющий преобразить всю коллекцию в строку
        public override string ToString()
        {

            if (Squads.Count != 0)
            {

                StringBuilder builder = new StringBuilder();
                int i = 0; //Счётчик для отображения индекса команды в TextBox-е, используется для удаления команды из коллекции
                           //Поскольку номер отображён в UI, для удобства пользователя индекс начинается с единицы
                           //Данный фактор учтён при удалении команды

                foreach (Team team in Squads) //Перебираем команды в коллекции
                {
                    i++;
                    builder.Append("N").Append(i).Append(" "); //Добавляем индекс
                    builder.AppendLine();
                    builder.Append(team.ToString()).AppendLine(); //У команды вызываем метод ToString, который возвращает в строковом значении все данные о команде
                }

                //Добавляем итоговую информацию
                builder.AppendLine("=====================");
                builder.AppendFormat($"Количество профессиональных команд: {AmountOfProfessionals()}");
                builder.AppendLine();
                builder.AppendFormat($"Количество непрофессиональных команд: {AmountOfUnprofessionals()}");
                builder.AppendLine();
                builder.AppendFormat($"Сумма очков профессиональных команд: {ScoreSummOfProfessionals()}");
                builder.AppendLine();
                builder.AppendFormat($"Сумма очков непрофессиональных команд: {ScoreSummOfUnprofessionals()}");
                builder.AppendLine();
                builder.AppendFormat($"Среднее количество очков на команду: {AverageScorePerTeam()}");

                return builder.ToString();
            }
            else return "";
        }

    }
}
