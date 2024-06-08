using kursach.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursach.Forms
{
    public partial class AddActorForm : Form
    {
        readonly Actor actor = new Actor();
        string filePath;
        public AddActorForm(Actor actor)
        {
            this.actor = actor;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Errorlabel2.Visible == true)
            {
                MessageBox.Show("Потрібно ввести ім'я");
            }
            if (Errorlabel3.Visible == true)
            {
                MessageBox.Show("Рік повинен бути додатнім та не перевищувати 2024");
            }
            if (Errorlabel2.Visible == false && Errorlabel3.Visible == false)
            {
                actor.Name = NameBox2.Text;
                actor.Surname = SurnameBox2.Text;
                actor.Alias = AliasBox2.Text;
                if (YearBox2.Text == "")
                {
                    actor.Year = int.MinValue;
                }
                else
                {
                    actor.Year = Int32.Parse(YearBox2.Text);
                }
                actor.HomeTown = HometownBox2.Text;
                actor.Gender = FemaleGenderBox2.Checked;
                actor.Films = FilmsBox2.Text;
                actor.Genres = GenresBox2.Text;
                actor.Rewards = RewardsBox2.Text;
                actor.ImageFile = filePath;
                Close();
            }
        }
        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MaleGenderBox2_CheckedChanged(object sender, EventArgs e)
        {
            FemaleGenderBox2.Checked = !MaleGenderBox2.Checked;
        }

        private void FemaleGenderBox2_CheckedChanged(object sender, EventArgs e)
        {
            MaleGenderBox2.Checked = !FemaleGenderBox2.Checked;
        }

        private void NameBox2_Validating(object sender, CancelEventArgs e)
        {
            if (NameBox2.Text.Trim().Length == 0)
            {
                Errorlabel2.Visible = true;
            }
        }

        private void YearBox2_Validating(object sender, CancelEventArgs e)
        {
            if (YearBox2.Text != "")
            {
                bool isNumber = int.TryParse(YearBox2.Text, out int year);
                if (!isNumber || year <= 0 || year >= 2024)
                {
                    Errorlabel3.Visible = true;
                }
            }
        }

        private void NameBox2_Validated(object sender, EventArgs e)
        {
            if (NameBox2.Text.Trim().Length > 0)
            {
                Errorlabel2.Visible = false;
            }
        }

        private void YearBox2_Validated(object sender, EventArgs e)
        {
            if (YearBox2.Text != "")
            {
                bool isNumber = int.TryParse(YearBox2.Text, out int year);
                if (!isNumber || year <= 0 || year >= 2024)
                {
                    Errorlabel3.Visible = true;
                }
                else
                {
                    Errorlabel3.Visible = false;
                }
            }
        }

        private void Photobutton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "e:\\";
            openFileDialog.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                PhotopictureBox2.Image = Image.FromFile(filePath);
            }
        }

        private void AddActorForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
