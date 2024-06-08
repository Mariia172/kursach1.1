namespace kursach.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator = new ToolStripSeparator();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripSeparator2 = new ToolStripSeparator();
            выходToolStripMenuItem = new ToolStripMenuItem();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            опрограммеToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            Photobutton = new Button();
            Photolabel = new Label();
            PhotopictureBox = new PictureBox();
            FilmsBox = new TextBox();
            GenresBox = new TextBox();
            RewardsBox = new TextBox();
            Rewardslabel = new Label();
            Genreslabel = new Label();
            Filmslabel = new Label();
            FemaleGenderBox = new CheckBox();
            MaleGenderBox = new CheckBox();
            Genderlabel = new Label();
            HometownBox = new TextBox();
            Hometownlabel = new Label();
            YearBox = new TextBox();
            Yearlabel = new Label();
            Aliaslabel = new Label();
            AliasBox = new TextBox();
            SurnameBox = new TextBox();
            Surnamelabel = new Label();
            NameBox = new TextBox();
            Namelabel = new Label();
            panel2 = new Panel();
            resultlist = new ListBox();
            actorBindingSource = new BindingSource(components);
            panel3 = new Panel();
            Addbutton = new Button();
            searchbutton = new Button();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PhotopictureBox).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)actorBindingSource).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, справкаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(886, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { открытьToolStripMenuItem, toolStripSeparator, сохранитьToolStripMenuItem, toolStripSeparator1, toolStripSeparator2, выходToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "&Файл";
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Image = (Image)resources.GetObject("открытьToolStripMenuItem.Image");
            открытьToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            открытьToolStripMenuItem.Size = new Size(173, 22);
            открытьToolStripMenuItem.Text = "&Открыть";
            открытьToolStripMenuItem.Click += открытьToolStripMenuItem_Click;
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(170, 6);
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Image = (Image)resources.GetObject("сохранитьToolStripMenuItem.Image");
            сохранитьToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            сохранитьToolStripMenuItem.Size = new Size(173, 22);
            сохранитьToolStripMenuItem.Text = "&Сохранить";
            сохранитьToolStripMenuItem.Click += сохранитьToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(170, 6);
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(170, 6);
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(173, 22);
            выходToolStripMenuItem.Text = "Вы&ход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripSeparator5, опрограммеToolStripMenuItem });
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new Size(65, 20);
            справкаToolStripMenuItem.Text = "&Справка";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(177, 6);
            // 
            // опрограммеToolStripMenuItem
            // 
            опрограммеToolStripMenuItem.Name = "опрограммеToolStripMenuItem";
            опрограммеToolStripMenuItem.Size = new Size(180, 22);
            опрограммеToolStripMenuItem.Text = "&О программе…";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = Color.Pink;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(Photobutton);
            panel1.Controls.Add(Photolabel);
            panel1.Controls.Add(PhotopictureBox);
            panel1.Controls.Add(FilmsBox);
            panel1.Controls.Add(GenresBox);
            panel1.Controls.Add(RewardsBox);
            panel1.Controls.Add(Rewardslabel);
            panel1.Controls.Add(Genreslabel);
            panel1.Controls.Add(Filmslabel);
            panel1.Controls.Add(FemaleGenderBox);
            panel1.Controls.Add(MaleGenderBox);
            panel1.Controls.Add(Genderlabel);
            panel1.Controls.Add(HometownBox);
            panel1.Controls.Add(Hometownlabel);
            panel1.Controls.Add(YearBox);
            panel1.Controls.Add(Yearlabel);
            panel1.Controls.Add(Aliaslabel);
            panel1.Controls.Add(AliasBox);
            panel1.Controls.Add(SurnameBox);
            panel1.Controls.Add(Surnamelabel);
            panel1.Controls.Add(NameBox);
            panel1.Controls.Add(Namelabel);
            panel1.Location = new Point(12, 40);
            panel1.MaximumSize = new Size(862, 259);
            panel1.Name = "panel1";
            panel1.Size = new Size(862, 259);
            panel1.TabIndex = 1;
            // 
            // Photobutton
            // 
            Photobutton.BackColor = Color.LavenderBlush;
            Photobutton.Enabled = false;
            Photobutton.Location = new Point(431, 161);
            Photobutton.Name = "Photobutton";
            Photobutton.Size = new Size(96, 23);
            Photobutton.TabIndex = 22;
            Photobutton.Text = "Додати фото";
            Photobutton.UseVisualStyleBackColor = false;
            // 
            // Photolabel
            // 
            Photolabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Photolabel.AutoSize = true;
            Photolabel.Font = new Font("Segoe UI", 12F);
            Photolabel.ForeColor = Color.Maroon;
            Photolabel.Location = new Point(431, 137);
            Photolabel.Name = "Photolabel";
            Photolabel.Size = new Size(47, 21);
            Photolabel.TabIndex = 21;
            Photolabel.Text = "Фото";
            // 
            // PhotopictureBox
            // 
            PhotopictureBox.BackColor = Color.LavenderBlush;
            PhotopictureBox.Enabled = false;
            PhotopictureBox.Location = new Point(533, 137);
            PhotopictureBox.Name = "PhotopictureBox";
            PhotopictureBox.Size = new Size(97, 95);
            PhotopictureBox.TabIndex = 20;
            PhotopictureBox.TabStop = false;
            // 
            // FilmsBox
            // 
            FilmsBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            FilmsBox.Location = new Point(533, 13);
            FilmsBox.MaximumSize = new Size(248, 23);
            FilmsBox.Name = "FilmsBox";
            FilmsBox.Size = new Size(248, 23);
            FilmsBox.TabIndex = 8;
            FilmsBox.KeyDown += FilmsBox_KeyDown;
            // 
            // GenresBox
            // 
            GenresBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GenresBox.Location = new Point(533, 55);
            GenresBox.MaximumSize = new Size(248, 23);
            GenresBox.Name = "GenresBox";
            GenresBox.Size = new Size(248, 23);
            GenresBox.TabIndex = 9;
            GenresBox.KeyDown += GenresBox_KeyDown;
            // 
            // RewardsBox
            // 
            RewardsBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RewardsBox.Location = new Point(533, 100);
            RewardsBox.MaximumSize = new Size(248, 23);
            RewardsBox.Name = "RewardsBox";
            RewardsBox.Size = new Size(248, 23);
            RewardsBox.TabIndex = 10;
            RewardsBox.KeyDown += RewardsBox_KeyDown;
            // 
            // Rewardslabel
            // 
            Rewardslabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Rewardslabel.AutoSize = true;
            Rewardslabel.Font = new Font("Segoe UI", 12F);
            Rewardslabel.ForeColor = Color.Maroon;
            Rewardslabel.Location = new Point(431, 98);
            Rewardslabel.Name = "Rewardslabel";
            Rewardslabel.Size = new Size(96, 21);
            Rewardslabel.TabIndex = 16;
            Rewardslabel.Text = "Винагороди";
            // 
            // Genreslabel
            // 
            Genreslabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Genreslabel.AutoSize = true;
            Genreslabel.Font = new Font("Segoe UI", 12F);
            Genreslabel.ForeColor = Color.Maroon;
            Genreslabel.Location = new Point(431, 57);
            Genreslabel.Name = "Genreslabel";
            Genreslabel.Size = new Size(59, 21);
            Genreslabel.TabIndex = 15;
            Genreslabel.Text = "Жанри";
            // 
            // Filmslabel
            // 
            Filmslabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Filmslabel.AutoSize = true;
            Filmslabel.Font = new Font("Segoe UI", 12F);
            Filmslabel.ForeColor = Color.Maroon;
            Filmslabel.Location = new Point(431, 15);
            Filmslabel.Name = "Filmslabel";
            Filmslabel.Size = new Size(62, 21);
            Filmslabel.TabIndex = 14;
            Filmslabel.Text = "Фільми";
            // 
            // FemaleGenderBox
            // 
            FemaleGenderBox.AutoSize = true;
            FemaleGenderBox.BackColor = Color.LavenderBlush;
            FemaleGenderBox.Location = new Point(251, 213);
            FemaleGenderBox.Name = "FemaleGenderBox";
            FemaleGenderBox.Size = new Size(67, 19);
            FemaleGenderBox.TabIndex = 7;
            FemaleGenderBox.Text = "Жіноча";
            FemaleGenderBox.UseVisualStyleBackColor = false;
            FemaleGenderBox.CheckedChanged += FemaleGenderBox_CheckedChanged;
            // 
            // MaleGenderBox
            // 
            MaleGenderBox.AutoSize = true;
            MaleGenderBox.BackColor = Color.LavenderBlush;
            MaleGenderBox.Checked = true;
            MaleGenderBox.CheckState = CheckState.Checked;
            MaleGenderBox.Location = new Point(168, 213);
            MaleGenderBox.Name = "MaleGenderBox";
            MaleGenderBox.Size = new Size(77, 19);
            MaleGenderBox.TabIndex = 6;
            MaleGenderBox.Text = "Чоловіча";
            MaleGenderBox.UseVisualStyleBackColor = false;
            MaleGenderBox.CheckedChanged += MaleGenderBox_CheckedChanged;
            MaleGenderBox.KeyDown += MaleGenderBox_KeyDown;
            // 
            // Genderlabel
            // 
            Genderlabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Genderlabel.AutoSize = true;
            Genderlabel.Font = new Font("Segoe UI", 12F);
            Genderlabel.ForeColor = Color.Maroon;
            Genderlabel.Location = new Point(17, 213);
            Genderlabel.Name = "Genderlabel";
            Genderlabel.Size = new Size(50, 21);
            Genderlabel.TabIndex = 11;
            Genderlabel.Text = "Стать";
            // 
            // HometownBox
            // 
            HometownBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            HometownBox.Location = new Point(168, 175);
            HometownBox.MaximumSize = new Size(248, 23);
            HometownBox.Name = "HometownBox";
            HometownBox.Size = new Size(248, 23);
            HometownBox.TabIndex = 5;
            HometownBox.KeyDown += HometownBox_KeyDown;
            // 
            // Hometownlabel
            // 
            Hometownlabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Hometownlabel.AutoSize = true;
            Hometownlabel.Font = new Font("Segoe UI", 12F);
            Hometownlabel.ForeColor = Color.Maroon;
            Hometownlabel.Location = new Point(17, 177);
            Hometownlabel.Name = "Hometownlabel";
            Hometownlabel.Size = new Size(145, 21);
            Hometownlabel.TabIndex = 9;
            Hometownlabel.Text = "Місто народження";
            // 
            // YearBox
            // 
            YearBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            YearBox.Location = new Point(168, 137);
            YearBox.MaximumSize = new Size(248, 23);
            YearBox.Name = "YearBox";
            YearBox.Size = new Size(248, 23);
            YearBox.TabIndex = 4;
            YearBox.KeyDown += YearBox_KeyDown;
            // 
            // Yearlabel
            // 
            Yearlabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Yearlabel.AutoSize = true;
            Yearlabel.Font = new Font("Segoe UI", 12F);
            Yearlabel.ForeColor = Color.Maroon;
            Yearlabel.Location = new Point(17, 137);
            Yearlabel.Name = "Yearlabel";
            Yearlabel.Size = new Size(125, 21);
            Yearlabel.TabIndex = 7;
            Yearlabel.Text = "Рік народження";
            // 
            // Aliaslabel
            // 
            Aliaslabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Aliaslabel.AutoSize = true;
            Aliaslabel.Font = new Font("Segoe UI", 12F);
            Aliaslabel.ForeColor = Color.Maroon;
            Aliaslabel.Location = new Point(17, 98);
            Aliaslabel.Name = "Aliaslabel";
            Aliaslabel.Size = new Size(86, 21);
            Aliaslabel.TabIndex = 6;
            Aliaslabel.Text = "Псевдонім";
            // 
            // AliasBox
            // 
            AliasBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AliasBox.Location = new Point(168, 96);
            AliasBox.MaximumSize = new Size(248, 23);
            AliasBox.Name = "AliasBox";
            AliasBox.Size = new Size(248, 23);
            AliasBox.TabIndex = 3;
            AliasBox.KeyDown += AliasBox_KeyDown;
            // 
            // SurnameBox
            // 
            SurnameBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SurnameBox.Location = new Point(168, 55);
            SurnameBox.MaximumSize = new Size(248, 23);
            SurnameBox.Name = "SurnameBox";
            SurnameBox.Size = new Size(248, 23);
            SurnameBox.TabIndex = 2;
            SurnameBox.KeyDown += SurnameBox_KeyDown;
            // 
            // Surnamelabel
            // 
            Surnamelabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Surnamelabel.AutoSize = true;
            Surnamelabel.Font = new Font("Segoe UI", 12F);
            Surnamelabel.ForeColor = Color.Maroon;
            Surnamelabel.Location = new Point(17, 57);
            Surnamelabel.Name = "Surnamelabel";
            Surnamelabel.Size = new Size(79, 21);
            Surnamelabel.TabIndex = 5;
            Surnamelabel.Text = "Прізвище";
            // 
            // NameBox
            // 
            NameBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NameBox.Location = new Point(168, 13);
            NameBox.MaximumSize = new Size(248, 23);
            NameBox.MaxLength = 100;
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(248, 23);
            NameBox.TabIndex = 1;
            NameBox.KeyDown += NameBox_KeyDown;
            // 
            // Namelabel
            // 
            Namelabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Namelabel.AutoSize = true;
            Namelabel.Font = new Font("Segoe UI", 12F);
            Namelabel.ForeColor = Color.Maroon;
            Namelabel.Location = new Point(17, 15);
            Namelabel.Name = "Namelabel";
            Namelabel.Size = new Size(37, 21);
            Namelabel.TabIndex = 0;
            Namelabel.Text = "Ім'я";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(resultlist);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(0, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(886, 426);
            panel2.TabIndex = 3;
            // 
            // resultlist
            // 
            resultlist.DataSource = actorBindingSource;
            resultlist.DisplayMember = "Name";
            resultlist.FormattingEnabled = true;
            resultlist.ItemHeight = 15;
            resultlist.Location = new Point(12, 278);
            resultlist.Name = "resultlist";
            resultlist.Size = new Size(591, 124);
            resultlist.TabIndex = 4;
            resultlist.ValueMember = "Year";
            resultlist.DoubleClick += resultlist_DoubleClick;
            // 
            // actorBindingSource
            // 
            actorBindingSource.DataSource = typeof(Models.Actor);
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top;
            panel3.BackColor = Color.PaleVioletRed;
            panel3.Controls.Add(Addbutton);
            panel3.Controls.Add(searchbutton);
            panel3.Location = new Point(609, 278);
            panel3.MaximumSize = new Size(265, 133);
            panel3.Name = "panel3";
            panel3.Size = new Size(265, 124);
            panel3.TabIndex = 3;
            // 
            // Addbutton
            // 
            Addbutton.Font = new Font("Segoe UI", 11F);
            Addbutton.Location = new Point(77, 72);
            Addbutton.Name = "Addbutton";
            Addbutton.Size = new Size(118, 34);
            Addbutton.TabIndex = 20;
            Addbutton.Text = "Додати актора";
            Addbutton.UseVisualStyleBackColor = true;
            Addbutton.Click += Addbutton_Click;
            // 
            // searchbutton
            // 
            searchbutton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            searchbutton.AutoSize = true;
            searchbutton.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            searchbutton.Location = new Point(77, 16);
            searchbutton.Name = "searchbutton";
            searchbutton.Size = new Size(118, 39);
            searchbutton.TabIndex = 4;
            searchbutton.Text = "&Пошук";
            searchbutton.UseVisualStyleBackColor = true;
            searchbutton.Click += button1_Click;
            searchbutton.KeyPress += searchbutton_KeyPress;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(886, 450);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Controls.Add(panel2);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(902, 489);
            Name = "MainForm";
            Text = "Довідник фаната";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PhotopictureBox).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)actorBindingSource).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem опрограммеToolStripMenuItem;
        private Panel panel1;
        private TextBox NameBox;
        private Label Namelabel;
        private Label Aliaslabel;
        private TextBox AliasBox;
        private TextBox SurnameBox;
        private Label Surnamelabel;
        private Panel panel2;
        private Button searchbutton;
        private Panel panel3;
        private TextBox YearBox;
        private Label Yearlabel;
        private Label Hometownlabel;
        private TextBox HometownBox;
        private Label Genderlabel;
        private CheckBox MaleGenderBox;
        private CheckBox FemaleGenderBox;
        private Label Genreslabel;
        private Label Filmslabel;
        private TextBox RewardsBox;
        private Label Rewardslabel;
        private TextBox FilmsBox;
        private TextBox GenresBox;
        private PictureBox PhotopictureBox;
        private Button Photobutton;
        private Label Photolabel;
        private ListBox resultlist;
        private BindingSource actorBindingSource;
        private Button Addbutton;
    }
}