using System.CodeDom.Compiler;
using System.Text.Json;

namespace Module7JsonStudentRecords
{
    public partial class Form1 : Form
    {
        private List<Student> students = new List<Student>();
        private List<Student> results = new List<Student>();
        public Form1()
        {
            InitializeComponent();
            LoadStudents();
        }

        private void DisplayStudents(List<Student> results)
        {
            dgvStudents.DataSource = null;
            dgvStudents.DataSource = results;
            dgvStudents.Columns[0].HeaderText = "ID";
            dgvStudents.Columns[1].HeaderText = "First Name";
            dgvStudents.Columns[2].HeaderText = "Last Name";
            dgvStudents.Columns[3].HeaderText = "Program";
            dgvStudents.Columns[4].HeaderText = "GPA";
            dgvStudents.Columns[4].DefaultCellStyle.Format = "N1";
            if (results.Count() == 0)
            {
                lblResults.Text = "No results found.";
            }
            else
            {
                lblResults.Text = results.Count() + " matching students.";
            }
        }

        private void LoadStudents()
        {
            try
            {
                string fileName = "students.json";
                string filePath = Path.Combine(Application.StartupPath, fileName);
                string jsonString = File.ReadAllText(filePath);
                students = JsonSerializer.Deserialize<List<Student>>(jsonString);
                DisplayStudents(students);
                lblResults.Text = "Records loaded.";
            }
            catch (FileNotFoundException)
            {
                lblResults.Text = "File not found.";
            }
            catch (JsonException)
            {
                lblResults.Text = "JSON is invalid.";
            }
            catch (IOException)
            {
                lblResults.Text = "Error processing file.";
            }
            catch (UnauthorizedAccessException)
            {
                lblResults.Text = "Access denied.";

            }
            catch (Exception)
            {
                lblResults.Text = "An error has occurred.";
            }
        }

        private bool ValidateProgram()
        {
            bool isValid = false;
            if (comboProgram.Text == "")
            {
                lblResults.Text = "Please enter a program to filter by program.";
            }
            else
            {
                isValid = true;
            }
            return isValid;
        }

        private bool ValidateGpa()
        {
            bool isValid = false;
            if (nudMinimumGpa.Value == 0.0m)
            {
                lblResults.Text = "Please enter a GPA above 0.";
            }
            else
            {
                isValid = true;
            }
            return isValid;
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            DisplayStudents(students);
        }


        private void btnSortGpa_Click(object sender, EventArgs e)
        {

            SortByGpa();

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchStudents();
        }
        private bool ValidateSearch()
        {
            bool isValid = false;
            if (txtSearch.Text == "")
            {
                lblResults.Text = "Please enter an ID or name to search.";
            }
            else
            {
                isValid = true;
            }
            return isValid;
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            DisplaySummary();
        }

        private void btnFilterProgram_Click(object sender, EventArgs e)
        {
            FilterByProgram();

        }

        private void btnFilterGpa_Click(object sender, EventArgs e)
        {

            FilterByGpa();
        }

        private void btnSortName_Click(object sender, EventArgs e)
        {
            SortByName();
        }

        private void FilterByProgram()
        {

            bool isValid;
            isValid = ValidateProgram();
            if (isValid == true)
            {
                var results = students.Where(student => string.Equals(student.ProgramName, comboProgram.Text, StringComparison.OrdinalIgnoreCase)).ToList();
                DisplayStudents(results);
                int count = results.Count();
                lblResults.Text = count + " matching students.";
            }
        }

        private void FilterByGpa()
        {

            var results = students.Where(student => student.GPA >= nudMinimumGpa.Value).ToList();
            int count = results.Count();
            DisplayStudents(results);
            lblResults.Text = count + " matching students.";
        }

        // Search relies on TryParse. I didn't understand FirstOrDefault and couldn't get it to work.
        private void SearchStudents()
        {
            int value;
            string textBox = txtSearch.Text;
            bool isValid;
            isValid = ValidateSearch();
            if (isValid == true)
            {
                bool numberSearch = Int32.TryParse(textBox, out value);

                if (numberSearch == true)
                {
                    int numberText = Convert.ToInt32(textBox);
                    var results = (students.Where(student => student.StudentId == numberText)).ToList();
                    DisplayStudents(results);
                }
                else
                {
                    var results = students.Where(student => student.FirstName.Contains(txtSearch.Text, StringComparison.OrdinalIgnoreCase)
                        || student.LastName.Contains(txtSearch.Text, StringComparison.OrdinalIgnoreCase)).ToList();
                    DisplayStudents(results);
                }

            }

        }
        private void SortByName()
        {
            var results = students.OrderBy(student => student.LastName).ThenBy(student => student.FirstName).ToList();
            int count = results.Count();
            DisplayStudents(results);
            lblResults.Text = count + " matching students.";
        }
        // Can't get FirstOrDefault to work. I don't understand what I'm supposed to pass into DisplayStudents
        private void SortByGpa()
        {
            var results = students.OrderByDescending(student => student.GPA).ToList();
            DisplayStudents(results);
        }

        // Combined query to run
        private void RunUnderGpaByProgram()

        {
            bool isValidProgram;
            isValidProgram = ValidateProgram();
            bool isValidGpa;
            isValidGpa = ValidateGpa();
            if (isValidProgram == true && isValidGpa == true)
            {
                var results = students.Where(student => student.ProgramName ==
                comboProgram.Text && student.GPA <= nudMinimumGpa.Value)
                    .OrderByDescending(student => student.GPA).ToList();

                DisplayStudents(results);
                int count = results.Count();
                lblResults.Text = count + " matching students.";
            }
        }
        private void DisplaySummary()
        {
            if (students.Count() == 0)
            {
                lblResults.Text = "No student records available.";
                
            }
            else
            {
                int totalCount = students.Count();
                decimal studentAverage = students.Average(student => student.GPA);
                decimal studentMax = students.Max(student => student.GPA);
                decimal studentMin = students.Min(student => student.GPA);
                int threeOrHigherGPA = students.Count(student => student.GPA >= 3.0m);

                lblResults.Text = totalCount + " total students" + "\nHighest GPA: " + studentMax
                    + "\nLowest GPA: " + studentMin + "\n" + threeOrHigherGPA + " students with 3.0 or higher.";
            }

        }

        private void btnUnderGpaByProgram_Click(object sender, EventArgs e)
        {
            RunUnderGpaByProgram();
        }
    }
}
