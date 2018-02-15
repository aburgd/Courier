using System.Collections.Generic;
using System.Windows.Forms;

namespace Courier
{
    public partial class Courier : Form
    {
        public Courier()
        {
            InitializeComponent();
        }

        private void BtnGenerate_Click(object sender, System.EventArgs e)
        {
            Person courier = new Person();
            TextBox[] specialArrayBoxes = TxtSpecialArray();

            if (!chkNameProvided.Checked)
            {
                txtName.Text = courier.Name.ToString();
                txtGender.Text = courier.Gender;
            }
            if (radGhoul.Checked)
            {
                radHuman.Checked = !radGhoul.Checked;
                courier.Age = Person.rnd.Next(16, 300);
            }
            else if (radHuman.Checked)
            {
                radGhoul.Checked = !radHuman.Checked;
                courier.Age = Person.rnd.Next(16, 60);
            }
            txtAge.Text = courier.Age.ToString();
            txtSkills.Text = courier.Skills;
            txtTraits.Text = courier.Traits;
            txtNukaSunset.Text = courier.NukaSunset;
            FillSpecial(courier, specialArrayBoxes);
        }

        private static void FillSpecial(Person courier, TextBox[] specialArrayBoxes)
        {
            for (int boxIndex = 0; boxIndex < specialArrayBoxes.Length; boxIndex++)
            {
                for (int statIndex = 0; statIndex < courier.Special.Length; statIndex++)
                {
                    specialArrayBoxes[statIndex].Text = courier.Special[statIndex].ToString();
                }
            }
        }

        private void BtnExit_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void BtnClear_Click(object sender, System.EventArgs e)
        {
            TextBox[] special = TxtSpecialArray();
            txtAge.Clear();
            txtGender.Clear();
            txtNukaSunset.Clear();
            txtName.Clear();
            txtSkills.Clear();
            txtTraits.Clear();
            foreach (TextBox attrib in special)
            {
                attrib.Clear();
            }
        }

        private void ChkNameProvided_CheckStateChanged(object sender, System.EventArgs e)
        {
            txtGender.ReadOnly = !txtGender.ReadOnly;
        }

        private TextBox[] TxtSpecialArray()
        {
            TextBox[] Special = new TextBox[] {
                txtStrength, txtPerception, txtEndurance,
                txtCharisma, txtIntelligence, txtAgility,
                txtLuck
            };
            return Special;
        }
    }
}
