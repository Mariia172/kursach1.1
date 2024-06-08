using kursach.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursach.Forms
{
    public partial class MainForm : Form
    {
        Library library = new Library();
        public MainForm()
        {
            InitializeComponent();
            library.LoadData(PathToData);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = library.Search(NameBox.Text, SurnameBox.Text, AliasBox.Text, YearBox.Text, HometownBox.Text, FemaleGenderBox.Checked, FilmsBox.Text, GenresBox.Text, RewardsBox.Text);
            actorBindingSource.DataSource = result;
            if (result.Count == 0)
            {
                MessageBox.Show("Акторів з такими даними не було знайдено");
            }
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            Actor actor = new Actor();
            var actorAddForm = new AddActorForm(actor);
            actorAddForm.ShowDialog();
            library.Add(actor);
        }

        private void MaleGenderBox_CheckedChanged(object sender, EventArgs e)
        {
            FemaleGenderBox.Checked = !MaleGenderBox.Checked;
        }

        private void FemaleGenderBox_CheckedChanged(object sender, EventArgs e)
        {
            MaleGenderBox.Checked = !FemaleGenderBox.Checked;
        }

        private void resultlist_DoubleClick(object sender, EventArgs e)
        {
            if (resultlist.SelectedItems.Count > 0)
            {
                Actor actor = resultlist.SelectedItem as Actor;
                var actorEditForm = new EditActorForm(actor);
                actorEditForm.ShowDialog();
                if (actor.Year == -1)
                {
                    library.Remove(actor);
                }
                button1_Click(null, null);
            }
        }
        const string PathToData = ".\\library.txt";
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            library.SaveData(PathToData);
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            library.LoadData(PathToData);
        }

        private void searchbutton_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void NameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void SurnameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void AliasBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void YearBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void HometownBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void MaleGenderBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void FilmsBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void GenresBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void RewardsBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }
    }
}
