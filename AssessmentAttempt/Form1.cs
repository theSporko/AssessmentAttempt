using System.Numerics;

namespace AssessmentAttempt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Event handler method for when the 'Select' button is pressed
        private void btnFileSelect_Click(object sender, EventArgs e)
        {
            //Dispays window to select a CSV file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Gets a selected file's path
                string filePath = openFileDialog.FileName;

                //Reads all lines in the selected CSV
                string[] lines = File.ReadAllLines(filePath);

                //Calculates the final sum to display
                CalculateFinalDigits(lines);
            }
        }

        //Decided to make this a method in case it would needed to be updated with additional formatting changes
        private string FormatLine(string line)
        {
            //For now, this only removes the quotation mark since excel adds them
            return line.Replace("'", "");
        }
        //method for calculating digits that will be displayed in the Result textbox
        private void CalculateFinalDigits(string[] lines)
        {
            //Initializes variable to store total sum
            BigInteger sum = 0;

            //for loop that iterates through each line of the selected CSV
            foreach (string line in lines)
            {
                //Removes unecessary characters from the selected line
                string cleanedLine = FormatLine(line);

                //If statement that parses the BigInt line
                if (BigInteger.TryParse(cleanedLine, out BigInteger number))
                {
                    //Add new number to the overall sum
                    sum += number;
                }
                else
                {
                    //In case the value isn't parsable, return this error message with the specific line
                    MessageBox.Show("Invalid line in selected file: " + line);
                    return;
                }
            }
            //Take the last 10 digits from the sum and return them to the textbox
            string finalDigits = sum.ToString().Substring(Math.Max(0, sum.ToString().Length - 10));
            txtboxResult.Text = finalDigits;
        }
    }
}