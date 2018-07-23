using System;
using System.Windows.Forms;

namespace ScoutDemoDice
{
    public partial class ScoutDemoDice : Form
    {
        public ScoutDemoDice()
        {
            InitializeComponent();
        }

        private void RoleButton_Click(object sender, EventArgs e)
        {
            Int32 MinimumAmount = 1;
            if (Int32.TryParse(NumberOfSidesComboBox.Text, out Int32 Result))
            {
                if (Int32.TryParse(NumberOfDiceComboBox.Text, out Int32 DiceResult))
                {
                    if (NumberOfDiceComboBox.SelectedIndex == 0)
                    {
                        Int32 MaximumAmount = Int32.Parse(NumberOfSidesComboBox.Text);
                        Random R = new Random();
                        Int32 RandomResult = R.Next(MinimumAmount, MaximumAmount);
                        String ResultString = String.Format("Random role between {0} and {1}: {2}", MinimumAmount, MaximumAmount, RandomResult);
                        ResultsListBox.Items.Add(ResultString);
                    }
                    else
                    {
                        Random R = new Random();
                        String MultipleResultString = String.Empty;
                        Int32 MultipleResultCount = 0;
                        for (int i = 1; i <= Int32.Parse(NumberOfDiceComboBox.Text); i++)
                        {
                            Int32 RandomResult = R.Next(MinimumAmount, Result);
                            MultipleResultCount += RandomResult;
                            if (Int32.Parse(NumberOfDiceComboBox.Text) == i)
                            {
                                MultipleResultString += RandomResult.ToString();
                            }
                            else
                            {
                                MultipleResultString += String.Format("{0}, ", RandomResult);
                            }
                        }
                        String ResultString = String.Format("Random roles between {0} and {1}: {2} : Total Roll: {3}", MinimumAmount, Result, MultipleResultString, MultipleResultCount);
                        ResultsListBox.Items.Add(ResultString);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter numeric digits for the number of dice");
                }
            }
            else
            {
                MessageBox.Show("Please enter numeric digits for the number of sides");
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ResultsListBox.Items.Clear();
        }

        private void ScoutDemoDice_Load(object sender, EventArgs e)
        {
            NumberOfSidesComboBox.SelectedIndex = 1;
            NumberOfDiceComboBox.SelectedIndex = 0;
        }

        private void NumberOfSidesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResultsListBox.Items.Clear();
        }
    }
}
