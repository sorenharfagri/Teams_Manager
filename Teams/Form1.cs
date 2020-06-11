using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teams
{

    public partial class Form1 : Form
    {

        Teams Squads = new Teams(); //Получаем коллекцию команд
        public Form1()
        {
            InitializeComponent();
        }

        //Кнопка добавления команды
        private void ButtonAddTeam_Click(object sender, EventArgs e)
        {
            string teamName = TextBoxTeamName.Text; //Получаем имя команды

            string coachName = TextBoxCoachName.Text; //Получаем фамилию тренера

            int amountOfPlayers = 0;
            if (TextBoxAmountOfPlayers.Text != "") amountOfPlayers = Convert.ToInt32(TextBoxAmountOfPlayers.Text); //Количество игроков, в случае наличия значения

            int scoreInLastSeason = 0;
            if (TextBoxScoreSumm.Text != "") scoreInLastSeason = Convert.ToInt32(TextBoxScoreSumm.Text); //Количество очков в прошлом сезоне, в случае наличия значения

            KindsOfSport KindOfSport = 0;
            if (ComboBoxKindOfSport.Text != "") KindOfSport = (KindsOfSport)Enum.Parse(typeof(KindsOfSport), ComboBoxKindOfSport.Text, true); //Так-же получаем вид спорта

            bool isProfessional = CheckBoxIsProfessional.Checked; //Узнаём, профессиональная ли команда


            //Добавляем новую команду в коллекцию
            Squads.AddTeam(teamName, coachName, amountOfPlayers, scoreInLastSeason, KindOfSport, isProfessional);

            //Метод ToString преобразует список команд в строку
            TextBoxTeams.Text = Squads.ToString();  //Обновляем TextBox который отображает информацию по всем командам


            //Сбрасываем значения полей
            TextBoxTeamName.Text = "";
            TextBoxCoachName.Text = "";
            TextBoxAmountOfPlayers.Text = "";
            TextBoxScoreSumm.Text = "";
        }

        //Кнопка для удаления конкретной команды из списка
        private void ButtonDeleteTeam_Click(object sender, EventArgs e)
        {

            int index = Convert.ToInt32(NumericUpDownDeleteTeam.Text); //Получаем индекс команды

            //Уточняем, действительно ли пользователь хочет удалить
            DialogResult result = MessageBox.Show($"Удалить команду с номером {index}?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);


            switch (result) {

                case DialogResult.Yes: 
                    {

                        if (!Squads.DeleteTeam(index)) //Вызываем метод для удаления команды. Если он возвращает false (команда не была удалена, её нет в списке), обрабатываем ошибку
                        {
                            string error = String.Format($"Команда с номером {index} не существует");
                            MessageBox.Show(error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else 
                        {
                            TextBoxTeams.Text = Squads.ToString();                 //В ином случае всё отлично, команда удалена, обновляем TextBox
                            MessageBox.Show($"Команда с номером {index} удалена");
                        }
                        break;
                    }

                case DialogResult.No: { //Обрабатываем вариант, если пользователь передумал
                        MessageBox.Show("Отмена удаления данных"); 
                        break;
                }
            }
        }

        //Кнопка для удаления всех команд из списка
        private void ButtonDeleteAllTeams_Click(object sender, EventArgs e) 
        {
            //Уточняем у пользователя, уверен ли он в своём желании
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить все команды?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                Squads.DeleteAll(); //В случае подтверждения вызываем метод, который удаляет все команды из списка
                TextBoxTeams.Text = Squads.ToString(); 
            }
        }

        //Кнопка для сохранения данных о командах в текстовом файле
        private void ButtonSaveData_Click(object sender, EventArgs e)
        {
            if (SaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamwriter = new StreamWriter(SaveFileDialog.FileName, false, System.Text.Encoding.GetEncoding("utf-8")); 

                streamwriter.Write(TextBoxTeams.Text); //Даные получаем из TextBox-а который их отображает
                streamwriter.Close();
            }
        }

        //Кнопка для pзагрузки и отображения данных о командах из текстового файла
        private void ButtonOpenData_Click(object sender, EventArgs e)
        {

            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {

                StreamReader streamReader;

                streamReader = new StreamReader(OpenFileDialog.FileName, System.Text.Encoding.GetEncoding("windows-1252"));

                TextBoxTeams.Text = streamReader.ReadToEnd(); //Данные выводим в TextBox
                streamReader.Close();
            }
        }

        //TextBox отвечающий за получение количества игроков в команде
        private void TextBoxAmountOfPlayers_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8); //Запрещаем ввод чего-либо, кроме цифр и нажатия Backspace
        }

        //Обрабатываем выход из приложения через панель инструемнтов
        private void ToolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
