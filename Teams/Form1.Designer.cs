namespace Teams
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TextBoxTeamName = new System.Windows.Forms.TextBox();
            this.TextBoxCoachName = new System.Windows.Forms.TextBox();
            this.TextBoxScoreSumm = new System.Windows.Forms.TextBox();
            this.ComboBoxKindOfSport = new System.Windows.Forms.ComboBox();
            this.TextBoxTeams = new System.Windows.Forms.TextBox();
            this.NumericUpDownDeleteTeam = new System.Windows.Forms.NumericUpDown();
            this.ButtonDeleteAllTeams = new System.Windows.Forms.Button();
            this.LabelDeleteTeam = new System.Windows.Forms.Label();
            this.ButtonAddTeam = new System.Windows.Forms.Button();
            this.ButtonDeleteTeam = new System.Windows.Forms.Button();
            this.LabelTeamName = new System.Windows.Forms.Label();
            this.LabelCoachName = new System.Windows.Forms.Label();
            this.LabelAmountOfPlayers = new System.Windows.Forms.Label();
            this.LabelScoreSumm = new System.Windows.Forms.Label();
            this.LabelKindOfSport = new System.Windows.Forms.Label();
            this.CheckBoxIsProfessional = new System.Windows.Forms.CheckBox();
            this.TextBoxAmountOfPlayers = new System.Windows.Forms.TextBox();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemTeams = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAddTeam = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemDeleteTeam = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItemDeleteAllTeams = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuStripMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.ToolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButtonOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButtonAddTeam = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButtonDeleteTeam = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButtonDeleteAllTeams = new System.Windows.Forms.ToolStripButton();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ButtonOpenData = new System.Windows.Forms.Button();
            this.ButtonSaveData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownDeleteTeam)).BeginInit();
            this.MenuStrip.SuspendLayout();
            this.ContextMenuStripMain.SuspendLayout();
            this.ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxTeamName
            // 
            this.TextBoxTeamName.Location = new System.Drawing.Point(134, 64);
            this.TextBoxTeamName.MaxLength = 30;
            this.TextBoxTeamName.Name = "TextBoxTeamName";
            this.TextBoxTeamName.Size = new System.Drawing.Size(149, 20);
            this.TextBoxTeamName.TabIndex = 6;
            // 
            // TextBoxCoachName
            // 
            this.TextBoxCoachName.Location = new System.Drawing.Point(134, 97);
            this.TextBoxCoachName.MaxLength = 30;
            this.TextBoxCoachName.Name = "TextBoxCoachName";
            this.TextBoxCoachName.Size = new System.Drawing.Size(149, 20);
            this.TextBoxCoachName.TabIndex = 8;
            // 
            // TextBoxScoreSumm
            // 
            this.TextBoxScoreSumm.Location = new System.Drawing.Point(210, 159);
            this.TextBoxScoreSumm.MaxLength = 9;
            this.TextBoxScoreSumm.Name = "TextBoxScoreSumm";
            this.TextBoxScoreSumm.Size = new System.Drawing.Size(73, 20);
            this.TextBoxScoreSumm.TabIndex = 13;
            this.TextBoxScoreSumm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxAmountOfPlayers_KeyPress);
            // 
            // ComboBoxKindOfSport
            // 
            this.ComboBoxKindOfSport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxKindOfSport.FormattingEnabled = true;
            this.ComboBoxKindOfSport.Items.AddRange(new object[] {
            "Баскетбол",
            "Регби",
            "Бейсбол",
            "Волейбол",
            "Футбол",
            "Хоккей"});
            this.ComboBoxKindOfSport.Location = new System.Drawing.Point(134, 188);
            this.ComboBoxKindOfSport.MaxLength = 30;
            this.ComboBoxKindOfSport.Name = "ComboBoxKindOfSport";
            this.ComboBoxKindOfSport.Size = new System.Drawing.Size(149, 21);
            this.ComboBoxKindOfSport.TabIndex = 18;
            // 
            // TextBoxTeams
            // 
            this.TextBoxTeams.Location = new System.Drawing.Point(466, 64);
            this.TextBoxTeams.Multiline = true;
            this.TextBoxTeams.Name = "TextBoxTeams";
            this.TextBoxTeams.ReadOnly = true;
            this.TextBoxTeams.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxTeams.Size = new System.Drawing.Size(309, 345);
            this.TextBoxTeams.TabIndex = 19;
            // 
            // NumericUpDownDeleteTeam
            // 
            this.NumericUpDownDeleteTeam.Location = new System.Drawing.Point(113, 347);
            this.NumericUpDownDeleteTeam.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDownDeleteTeam.Name = "NumericUpDownDeleteTeam";
            this.NumericUpDownDeleteTeam.Size = new System.Drawing.Size(94, 20);
            this.NumericUpDownDeleteTeam.TabIndex = 20;
            this.NumericUpDownDeleteTeam.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ButtonDeleteAllTeams
            // 
            this.ButtonDeleteAllTeams.Location = new System.Drawing.Point(113, 386);
            this.ButtonDeleteAllTeams.Name = "ButtonDeleteAllTeams";
            this.ButtonDeleteAllTeams.Size = new System.Drawing.Size(94, 23);
            this.ButtonDeleteAllTeams.TabIndex = 22;
            this.ButtonDeleteAllTeams.Text = "Удалить все";
            this.ButtonDeleteAllTeams.UseVisualStyleBackColor = true;
            this.ButtonDeleteAllTeams.Click += new System.EventHandler(this.ButtonDeleteAllTeams_Click);
            // 
            // LabelDeleteTeam
            // 
            this.LabelDeleteTeam.AutoSize = true;
            this.LabelDeleteTeam.Location = new System.Drawing.Point(12, 349);
            this.LabelDeleteTeam.Name = "LabelDeleteTeam";
            this.LabelDeleteTeam.Size = new System.Drawing.Size(89, 13);
            this.LabelDeleteTeam.TabIndex = 23;
            this.LabelDeleteTeam.Text = "№ для удаления";
            // 
            // ButtonAddTeam
            // 
            this.ButtonAddTeam.Location = new System.Drawing.Point(15, 257);
            this.ButtonAddTeam.Name = "ButtonAddTeam";
            this.ButtonAddTeam.Size = new System.Drawing.Size(75, 23);
            this.ButtonAddTeam.TabIndex = 24;
            this.ButtonAddTeam.Text = "Добавить";
            this.ButtonAddTeam.UseVisualStyleBackColor = true;
            this.ButtonAddTeam.Click += new System.EventHandler(this.ButtonAddTeam_Click);
            // 
            // ButtonDeleteTeam
            // 
            this.ButtonDeleteTeam.Location = new System.Drawing.Point(15, 386);
            this.ButtonDeleteTeam.Name = "ButtonDeleteTeam";
            this.ButtonDeleteTeam.Size = new System.Drawing.Size(81, 23);
            this.ButtonDeleteTeam.TabIndex = 25;
            this.ButtonDeleteTeam.Text = "Удалить";
            this.ButtonDeleteTeam.UseVisualStyleBackColor = true;
            this.ButtonDeleteTeam.Click += new System.EventHandler(this.ButtonDeleteTeam_Click);
            // 
            // LabelTeamName
            // 
            this.LabelTeamName.AutoSize = true;
            this.LabelTeamName.Location = new System.Drawing.Point(12, 67);
            this.LabelTeamName.Name = "LabelTeamName";
            this.LabelTeamName.Size = new System.Drawing.Size(106, 13);
            this.LabelTeamName.TabIndex = 26;
            this.LabelTeamName.Text = "Название команды";
            // 
            // LabelCoachName
            // 
            this.LabelCoachName.AutoSize = true;
            this.LabelCoachName.Location = new System.Drawing.Point(12, 100);
            this.LabelCoachName.Name = "LabelCoachName";
            this.LabelCoachName.Size = new System.Drawing.Size(100, 13);
            this.LabelCoachName.TabIndex = 27;
            this.LabelCoachName.Text = "Фамилия тренера";
            // 
            // LabelAmountOfPlayers
            // 
            this.LabelAmountOfPlayers.AutoSize = true;
            this.LabelAmountOfPlayers.Location = new System.Drawing.Point(12, 132);
            this.LabelAmountOfPlayers.Name = "LabelAmountOfPlayers";
            this.LabelAmountOfPlayers.Size = new System.Drawing.Size(110, 13);
            this.LabelAmountOfPlayers.TabIndex = 28;
            this.LabelAmountOfPlayers.Text = "Количество игроков";
            // 
            // LabelScoreSumm
            // 
            this.LabelScoreSumm.AutoSize = true;
            this.LabelScoreSumm.Location = new System.Drawing.Point(12, 162);
            this.LabelScoreSumm.Name = "LabelScoreSumm";
            this.LabelScoreSumm.Size = new System.Drawing.Size(195, 13);
            this.LabelScoreSumm.TabIndex = 29;
            this.LabelScoreSumm.Text = "Количество очков в прошлом сезоне";
            // 
            // LabelKindOfSport
            // 
            this.LabelKindOfSport.AutoSize = true;
            this.LabelKindOfSport.Location = new System.Drawing.Point(12, 188);
            this.LabelKindOfSport.Name = "LabelKindOfSport";
            this.LabelKindOfSport.Size = new System.Drawing.Size(64, 13);
            this.LabelKindOfSport.TabIndex = 30;
            this.LabelKindOfSport.Text = "Вид спорта";
            // 
            // CheckBoxIsProfessional
            // 
            this.CheckBoxIsProfessional.AutoSize = true;
            this.CheckBoxIsProfessional.Location = new System.Drawing.Point(15, 222);
            this.CheckBoxIsProfessional.Name = "CheckBoxIsProfessional";
            this.CheckBoxIsProfessional.Size = new System.Drawing.Size(173, 17);
            this.CheckBoxIsProfessional.TabIndex = 31;
            this.CheckBoxIsProfessional.Text = "Профессиональная команда";
            this.CheckBoxIsProfessional.UseVisualStyleBackColor = true;
            // 
            // TextBoxAmountOfPlayers
            // 
            this.TextBoxAmountOfPlayers.Location = new System.Drawing.Point(134, 129);
            this.TextBoxAmountOfPlayers.MaxLength = 9;
            this.TextBoxAmountOfPlayers.Name = "TextBoxAmountOfPlayers";
            this.TextBoxAmountOfPlayers.Size = new System.Drawing.Size(149, 20);
            this.TextBoxAmountOfPlayers.TabIndex = 32;
            this.TextBoxAmountOfPlayers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxAmountOfPlayers_KeyPress);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.DefaultExt = "txt";
            this.OpenFileDialog.FileName = "TeamsData";
            this.OpenFileDialog.Filter = "Текстовый документ|*.txt";
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.DefaultExt = "txt";
            this.SaveFileDialog.FileName = "TeamsData";
            this.SaveFileDialog.Filter = "Текстовый документ|*.txt";
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.ToolStripMenuItemTeams});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(787, 24);
            this.MenuStrip.TabIndex = 37;
            this.MenuStrip.Text = "MenuStrip";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemSave,
            this.ToolStripMenuItemOpen,
            this.toolStripSeparator2,
            this.ToolStripMenuItemExit});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // ToolStripMenuItemSave
            // 
            this.ToolStripMenuItemSave.Name = "ToolStripMenuItemSave";
            this.ToolStripMenuItemSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.ToolStripMenuItemSave.Size = new System.Drawing.Size(172, 22);
            this.ToolStripMenuItemSave.Text = "Сохранить";
            this.ToolStripMenuItemSave.Click += new System.EventHandler(this.ButtonSaveData_Click);
            // 
            // ToolStripMenuItemOpen
            // 
            this.ToolStripMenuItemOpen.Name = "ToolStripMenuItemOpen";
            this.ToolStripMenuItemOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.ToolStripMenuItemOpen.Size = new System.Drawing.Size(172, 22);
            this.ToolStripMenuItemOpen.Text = "Открыть";
            this.ToolStripMenuItemOpen.Click += new System.EventHandler(this.ButtonOpenData_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(169, 6);
            // 
            // ToolStripMenuItemExit
            // 
            this.ToolStripMenuItemExit.Name = "ToolStripMenuItemExit";
            this.ToolStripMenuItemExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.ToolStripMenuItemExit.Size = new System.Drawing.Size(172, 22);
            this.ToolStripMenuItemExit.Text = "Выход";
            this.ToolStripMenuItemExit.Click += new System.EventHandler(this.ToolStripMenuItemExit_Click);
            // 
            // ToolStripMenuItemTeams
            // 
            this.ToolStripMenuItemTeams.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemAddTeam,
            this.ToolStripMenuItemDeleteTeam,
            this.toolStripSeparator3,
            this.ToolStripMenuItemDeleteAllTeams});
            this.ToolStripMenuItemTeams.Name = "ToolStripMenuItemTeams";
            this.ToolStripMenuItemTeams.Size = new System.Drawing.Size(70, 20);
            this.ToolStripMenuItemTeams.Text = "Команды";
            // 
            // ToolStripMenuItemAddTeam
            // 
            this.ToolStripMenuItemAddTeam.Name = "ToolStripMenuItemAddTeam";
            this.ToolStripMenuItemAddTeam.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.ToolStripMenuItemAddTeam.Size = new System.Drawing.Size(257, 22);
            this.ToolStripMenuItemAddTeam.Text = "Добавить команду";
            this.ToolStripMenuItemAddTeam.Click += new System.EventHandler(this.ButtonAddTeam_Click);
            // 
            // ToolStripMenuItemDeleteTeam
            // 
            this.ToolStripMenuItemDeleteTeam.Name = "ToolStripMenuItemDeleteTeam";
            this.ToolStripMenuItemDeleteTeam.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.ToolStripMenuItemDeleteTeam.Size = new System.Drawing.Size(257, 22);
            this.ToolStripMenuItemDeleteTeam.Text = "Удалить команду";
            this.ToolStripMenuItemDeleteTeam.Click += new System.EventHandler(this.ButtonDeleteTeam_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(254, 6);
            // 
            // ToolStripMenuItemDeleteAllTeams
            // 
            this.ToolStripMenuItemDeleteAllTeams.Name = "ToolStripMenuItemDeleteAllTeams";
            this.ToolStripMenuItemDeleteAllTeams.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.D)));
            this.ToolStripMenuItemDeleteAllTeams.Size = new System.Drawing.Size(257, 22);
            this.ToolStripMenuItemDeleteAllTeams.Text = "Удалить все команды";
            this.ToolStripMenuItemDeleteAllTeams.Click += new System.EventHandler(this.ButtonDeleteAllTeams_Click);
            // 
            // ContextMenuStripMain
            // 
            this.ContextMenuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.ContextMenuStripMain.Name = "MainContextMenuStrip";
            this.ContextMenuStripMain.Size = new System.Drawing.Size(68, 70);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            // 
            // ToolStrip
            // 
            this.ToolStrip.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripButtonSave,
            this.ToolStripButtonOpen,
            this.toolStripSeparator1,
            this.ToolStripButtonAddTeam,
            this.ToolStripButtonDeleteTeam,
            this.ToolStripButtonDeleteAllTeams});
            this.ToolStrip.Location = new System.Drawing.Point(0, 24);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(787, 32);
            this.ToolStrip.TabIndex = 39;
            this.ToolStrip.Text = "toolStrip1";
            // 
            // ToolStripButtonSave
            // 
            this.ToolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButtonSave.Image = global::Teams.Properties.Resources.icons8_downloads_folder_64;
            this.ToolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonSave.Name = "ToolStripButtonSave";
            this.ToolStripButtonSave.Size = new System.Drawing.Size(29, 29);
            this.ToolStripButtonSave.Text = "toolStripButton1";
            this.ToolStripButtonSave.ToolTipText = "Сохранить";
            this.ToolStripButtonSave.Click += new System.EventHandler(this.ButtonSaveData_Click);
            // 
            // ToolStripButtonOpen
            // 
            this.ToolStripButtonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButtonOpen.Image = global::Teams.Properties.Resources.icons8_browse_folder_64;
            this.ToolStripButtonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonOpen.Name = "ToolStripButtonOpen";
            this.ToolStripButtonOpen.Size = new System.Drawing.Size(29, 29);
            this.ToolStripButtonOpen.Text = "toolStripButton2";
            this.ToolStripButtonOpen.ToolTipText = "Открыть файл";
            this.ToolStripButtonOpen.Click += new System.EventHandler(this.ButtonOpenData_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // ToolStripButtonAddTeam
            // 
            this.ToolStripButtonAddTeam.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButtonAddTeam.Image = global::Teams.Properties.Resources.icons8_plus_32;
            this.ToolStripButtonAddTeam.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonAddTeam.Name = "ToolStripButtonAddTeam";
            this.ToolStripButtonAddTeam.Size = new System.Drawing.Size(29, 29);
            this.ToolStripButtonAddTeam.Text = "toolStripButton3";
            this.ToolStripButtonAddTeam.ToolTipText = "Добавить команду";
            this.ToolStripButtonAddTeam.Click += new System.EventHandler(this.ButtonAddTeam_Click);
            // 
            // ToolStripButtonDeleteTeam
            // 
            this.ToolStripButtonDeleteTeam.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButtonDeleteTeam.Image = global::Teams.Properties.Resources.icons8_cancel_32;
            this.ToolStripButtonDeleteTeam.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonDeleteTeam.Name = "ToolStripButtonDeleteTeam";
            this.ToolStripButtonDeleteTeam.Size = new System.Drawing.Size(29, 29);
            this.ToolStripButtonDeleteTeam.Text = "toolStripButton4";
            this.ToolStripButtonDeleteTeam.ToolTipText = "Удалить команду";
            this.ToolStripButtonDeleteTeam.Click += new System.EventHandler(this.ButtonDeleteTeam_Click);
            // 
            // ToolStripButtonDeleteAllTeams
            // 
            this.ToolStripButtonDeleteAllTeams.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButtonDeleteAllTeams.Image = global::Teams.Properties.Resources.icons8_trash_32;
            this.ToolStripButtonDeleteAllTeams.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonDeleteAllTeams.Name = "ToolStripButtonDeleteAllTeams";
            this.ToolStripButtonDeleteAllTeams.Size = new System.Drawing.Size(29, 29);
            this.ToolStripButtonDeleteAllTeams.Text = "toolStripButton5";
            this.ToolStripButtonDeleteAllTeams.ToolTipText = "Удалить все команды";
            this.ToolStripButtonDeleteAllTeams.Click += new System.EventHandler(this.ButtonDeleteAllTeams_Click);
            // 
            // ButtonOpenData
            // 
            this.ButtonOpenData.Image = global::Teams.Properties.Resources.icons8_browse_folder_64;
            this.ButtonOpenData.Location = new System.Drawing.Point(338, 143);
            this.ButtonOpenData.Name = "ButtonOpenData";
            this.ButtonOpenData.Size = new System.Drawing.Size(77, 72);
            this.ButtonOpenData.TabIndex = 36;
            this.ToolTip.SetToolTip(this.ButtonOpenData, "Открыть файл");
            this.ButtonOpenData.UseVisualStyleBackColor = true;
            this.ButtonOpenData.Click += new System.EventHandler(this.ButtonOpenData_Click);
            // 
            // ButtonSaveData
            // 
            this.ButtonSaveData.Image = global::Teams.Properties.Resources.icons8_downloads_folder_64;
            this.ButtonSaveData.Location = new System.Drawing.Point(338, 64);
            this.ButtonSaveData.Name = "ButtonSaveData";
            this.ButtonSaveData.Size = new System.Drawing.Size(77, 73);
            this.ButtonSaveData.TabIndex = 35;
            this.ToolTip.SetToolTip(this.ButtonSaveData, "Сохранить");
            this.ButtonSaveData.UseVisualStyleBackColor = true;
            this.ButtonSaveData.Click += new System.EventHandler(this.ButtonSaveData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 440);
            this.ContextMenuStrip = this.ContextMenuStripMain;
            this.Controls.Add(this.ToolStrip);
            this.Controls.Add(this.ButtonOpenData);
            this.Controls.Add(this.ButtonSaveData);
            this.Controls.Add(this.TextBoxAmountOfPlayers);
            this.Controls.Add(this.CheckBoxIsProfessional);
            this.Controls.Add(this.LabelKindOfSport);
            this.Controls.Add(this.LabelScoreSumm);
            this.Controls.Add(this.LabelAmountOfPlayers);
            this.Controls.Add(this.LabelCoachName);
            this.Controls.Add(this.LabelTeamName);
            this.Controls.Add(this.ButtonDeleteTeam);
            this.Controls.Add(this.ButtonAddTeam);
            this.Controls.Add(this.LabelDeleteTeam);
            this.Controls.Add(this.ButtonDeleteAllTeams);
            this.Controls.Add(this.NumericUpDownDeleteTeam);
            this.Controls.Add(this.TextBoxTeams);
            this.Controls.Add(this.ComboBoxKindOfSport);
            this.Controls.Add(this.TextBoxScoreSumm);
            this.Controls.Add(this.TextBoxCoachName);
            this.Controls.Add(this.TextBoxTeamName);
            this.Controls.Add(this.MenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teams";
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownDeleteTeam)).EndInit();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ContextMenuStripMain.ResumeLayout(false);
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TextBoxTeamName;
        private System.Windows.Forms.TextBox TextBoxCoachName;
        private System.Windows.Forms.TextBox TextBoxScoreSumm;
        private System.Windows.Forms.ComboBox ComboBoxKindOfSport;
        private System.Windows.Forms.TextBox TextBoxTeams;
        private System.Windows.Forms.NumericUpDown NumericUpDownDeleteTeam;
        private System.Windows.Forms.Button ButtonDeleteAllTeams;
        private System.Windows.Forms.Label LabelDeleteTeam;
        private System.Windows.Forms.Button ButtonDeleteTeam;
        private System.Windows.Forms.Label LabelTeamName;
        private System.Windows.Forms.Label LabelCoachName;
        private System.Windows.Forms.Label LabelAmountOfPlayers;
        private System.Windows.Forms.Label LabelScoreSumm;
        private System.Windows.Forms.Label LabelKindOfSport;
        private System.Windows.Forms.CheckBox CheckBoxIsProfessional;
        private System.Windows.Forms.TextBox TextBoxAmountOfPlayers;
        private System.Windows.Forms.Button ButtonSaveData;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.Button ButtonOpenData;
        private System.Windows.Forms.Button ButtonAddTeam;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSave;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemOpen;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemExit;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStripMain;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStrip ToolStrip;
        private System.Windows.Forms.ToolStripButton ToolStripButtonSave;
        private System.Windows.Forms.ToolStripButton ToolStripButtonOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ToolStripButtonAddTeam;
        private System.Windows.Forms.ToolStripButton ToolStripButtonDeleteTeam;
        private System.Windows.Forms.ToolStripButton ToolStripButtonDeleteAllTeams;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemTeams;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAddTeam;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDeleteTeam;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDeleteAllTeams;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}

