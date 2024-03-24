    using System;
    using System.Windows.Forms;

    namespace PeriodicGradeCalculator
    {
        public class MainForm : Form
        {
            private TextBox txtQuiz1;
            private TextBox txtQuiz2;
            private TextBox txtLab1;
            private TextBox txtLab2;
            private TextBox txtLab3;
            private TextBox txtAct1;
            private TextBox txtAct2;
            private TextBox txtAct3;
            private TextBox txtExam;

            private Label lblQuiz1;
            private Label  lblQuiz2;
            private Label lblLab1;
            private Label lblLab2;
            private Label lblLab3;
            private Label lblAct1;
            private Label lblAct2;
            private Label lblAct3;
            private Label lblExam;
            private Label lblPeriodicGrade;
            private Label lblEquivalentGrade;
            private Label lblRemarks;

            

            public MainForm()
            {
                InitializeComponents();
                this.BackColor = System.Drawing.Color.LightGray; 
            }

            private void InitializeComponents()
            {

                Label lblTitle = new Label();
        lblTitle.Text = "Periodic Grade Calculator";
        lblTitle.Font = new Font(lblTitle.Font, FontStyle.Bold); // Make the font bold
        lblTitle.TextAlign = ContentAlignment.MiddleCenter; // Center align text
        lblTitle.Location = new System.Drawing.Point(20, 0); // Adjust the Y-coordinate as needed
        lblTitle.Size = new System.Drawing.Size(260, 30); // Adjust the width and height as needed

    // Add the title label to the form
    this.Controls.Add(lblTitle);
            
                this.Text = "Periodic Grade Calculator";
                this.Size = new System.Drawing.Size(300, 480);
                this.StartPosition = FormStartPosition.CenterScreen;

            
                txtQuiz1 = new TextBox();
                txtQuiz1.Location = new System.Drawing.Point(120, 30);
                txtQuiz1.Size = new System.Drawing.Size(100, 20);
                     txtQuiz1.Size = new System.Drawing.Size(150, 30); // Increase width to 260 and height to 20

                txtQuiz2 = new TextBox();
                txtQuiz2.Location = new System.Drawing.Point(120, 60);
                txtQuiz2.Size = new System.Drawing.Size(100, 20);
                   txtQuiz2.Size = new System.Drawing.Size(150, 30); // Increase width to 260 and height to 20

                txtLab1 = new TextBox();
                txtLab1.Location = new System.Drawing.Point(120, 90);
                txtLab1.Size = new System.Drawing.Size(100, 20);
                   txtLab1.Size = new System.Drawing.Size(150, 30); // Increase width to 260 and height to 20

                txtLab2 = new TextBox();
                txtLab2.Location = new System.Drawing.Point(120, 120);
                txtLab2.Size = new System.Drawing.Size(100, 20);
                   txtLab2.Size = new System.Drawing.Size(150, 30); // Increase width to 260 and height to 20

                txtLab3 = new TextBox();
                txtLab3.Location = new System.Drawing.Point(120, 150);
                txtLab3.Size = new System.Drawing.Size(100, 20);
                   txtLab3.Size = new System.Drawing.Size(150, 30); // Increase width to 260 and height to 20

                txtAct1 = new TextBox();
                txtAct1.Location = new System.Drawing.Point(120, 180);
                txtAct1.Size = new System.Drawing.Size(100, 20);
                   txtAct1.Size = new System.Drawing.Size(150, 30); // Increase width to 260 and height to 20

                txtAct2 = new TextBox();
                txtAct2.Location = new System.Drawing.Point(120, 210);
                txtAct2.Size = new System.Drawing.Size(100, 20);
                   txtAct2.Size = new System.Drawing.Size(150, 30); // Increase width to 260 and height to 20

                txtAct3 = new TextBox();
                txtAct3.Location = new System.Drawing.Point(120, 240);
                txtAct3.Size = new System.Drawing.Size(100, 20);
                   txtAct3.Size = new System.Drawing.Size(150, 30); // Increase width to 260 and height to 20

                txtExam = new TextBox();
                txtExam.Location = new System.Drawing.Point(120, 270);
                txtExam.Size = new System.Drawing.Size(100, 20);
                   txtExam.Size = new System.Drawing.Size(150, 30); // Increase width to 260 and height to 20


                lblQuiz1 = new Label();
                lblQuiz1.Text = "Quiz 1:";
                lblQuiz1.Location = new System.Drawing.Point(20, 30);
        

                lblQuiz2 = new Label();
                lblQuiz2.Text = "Quiz 2:";
                lblQuiz2.Location = new System.Drawing.Point(20, 60);
      

                lblLab1 = new Label();
                lblLab1.Text = "1st Lab:";
                lblLab1.Location = new System.Drawing.Point(20, 90);


                lblLab2 = new Label();
                lblLab2.Text = "2nd Lab:";
                lblLab2.Location = new System.Drawing.Point(20, 120);
    

                lblLab3 = new Label();
                lblLab3.Text = "3rd Lab:";
                lblLab3.Location = new System.Drawing.Point(20, 150);


                lblAct1 = new Label();
                lblAct1.Text = "1st Class:";
                lblAct1.Location = new System.Drawing.Point(20, 180);
             
                lblAct2 = new Label();
                lblAct2.Text = "2nd Class:";
                lblAct2.Location = new System.Drawing.Point(20, 210);
                
         
                lblAct3 = new Label();
                lblAct3.Text = "3rd Class:";
                lblAct3.Location = new System.Drawing.Point(20, 240);
           

                lblExam = new Label();
                lblExam.Text = "Exam:";
                lblExam.Location = new System.Drawing.Point(20, 270);
                   lblExam.AutoSize = true;

                        lblPeriodicGrade = new Label();
        lblPeriodicGrade.Text = "Computed Periodic Grade:";
        lblPeriodicGrade.Location = new System.Drawing.Point(20, 300);
        lblPeriodicGrade.Size = new System.Drawing.Size(400, 30); 

        lblEquivalentGrade = new Label();
        lblEquivalentGrade.Text = "Equivalent Grade:";
        lblEquivalentGrade.Location = new System.Drawing.Point(20, 330);
        lblEquivalentGrade.Size = new System.Drawing.Size(260, 30); // Increase width to 260 and height to 20

        lblRemarks = new Label();
        lblRemarks.Text = "Remarks:";
        lblRemarks.Location = new System.Drawing.Point(20, 360);
        lblRemarks.Size = new System.Drawing.Size(260, 30); // Increase width to 260 and height to 20

           


                Button btnCompute = new Button();
                btnCompute.Text = "Compute";
                btnCompute.Location = new System.Drawing.Point(50, 400); // Adjust X-coordinate as needed
                btnCompute.Size = new System.Drawing.Size(100, 30); // Increase the height to 30
                btnCompute.Click += BtnCompute_Click;

                Button btnClear = new Button();
                btnClear.Text = "Clear";
                btnClear.Location = new System.Drawing.Point(160, 400); // Adjust X-coordinate as needed
                btnClear.Size = new System.Drawing.Size(100, 30); // Increase the height to 30
                btnClear.Click += BtnClear_Click;

                // Add controls to the form
                this.Controls.Add(txtQuiz1);
                this.Controls.Add(txtQuiz2);
                this.Controls.Add(txtLab1);
                this.Controls.Add(txtLab2);
                this.Controls.Add(txtLab3);
                this.Controls.Add(txtAct1);
                this.Controls.Add(txtAct2);
                this.Controls.Add(txtAct3);
                this.Controls.Add(txtExam);

            
                this.Controls.Add(lblQuiz1);
                this.Controls.Add(lblQuiz2);
                this.Controls.Add(lblLab1);
                this.Controls.Add(lblLab2);
                this.Controls.Add(lblLab3);
                this.Controls.Add(lblAct1);
                this.Controls.Add(lblAct2);
                this.Controls.Add(lblAct3);
                this.Controls.Add(lblExam);

                this.Controls.Add(lblPeriodicGrade);
                this.Controls.Add(lblEquivalentGrade);
                this.Controls.Add(lblRemarks);

                this.Controls.Add(btnCompute);
                this.Controls.Add(btnClear);
            }

// Inside BtnCompute_Click method
private void BtnCompute_Click(object sender, EventArgs e)
{
    try
    {
        ScoreValidator validator = new ScoreValidator(); // Create an instance of ScoreValidator

        // Validate each input score
        validator.ValidateQuizScore(double.Parse(txtQuiz1.Text));
        validator.ValidateQuizScore(double.Parse(txtQuiz2.Text));
        validator.ValidateLabActivityScore(double.Parse(txtLab1.Text));
        validator.ValidateLabActivityScore(double.Parse(txtLab2.Text));
        validator.ValidateLabActivityScore(double.Parse(txtLab3.Text));
        validator.ValidateClassroomActivityScore(double.Parse(txtAct1.Text));
        validator.ValidateClassroomActivityScore(double.Parse(txtAct2.Text));
        validator.ValidateClassroomActivityScore(double.Parse(txtAct3.Text));
        validator.ValidateExamScore(double.Parse(txtExam.Text));

        // If all scores are valid, proceed with computing the periodic grade
        // and displaying the result
        double quiz1 = double.Parse(txtQuiz1.Text);
        double quiz2 = double.Parse(txtQuiz2.Text);
        double lab1 = double.Parse(txtLab1.Text);
        double lab2 = double.Parse(txtLab2.Text);
        double lab3 = double.Parse(txtLab3.Text);
        double act1 = double.Parse(txtAct1.Text);
        double act2 = double.Parse(txtAct2.Text);
        double act3 = double.Parse(txtAct3.Text);
        double exam = double.Parse(txtExam.Text);

        PeriodicGradeCalculator calculator = new PeriodicGradeCalculator();

        double periodicGrade = calculator.ComputePeriodicGrade(quiz1, quiz2, lab1, lab2, lab3, act1, act2, act3, exam);

        string equivalentGrade = calculator.ComputeEquivalentSubjectGrade(periodicGrade);

        string remarks = calculator.DetermineRemark(periodicGrade);

        lblPeriodicGrade.Text = "Computed Periodic Grade: " + periodicGrade.ToString();
        lblEquivalentGrade.Text = "Equivalent Grade: " + equivalentGrade;
        lblRemarks.Text = "Remarks: " + remarks;


       /*  Console.WriteLine(periodicGrade);
          Console.WriteLine(equivalentGrade);
          Console.WriteLine(remarks);
         */

    }
    catch (FormatException)
    {
        MessageBox.Show("Please enter valid numeric values for all components.");
    }
    catch (ArgumentException ex)
    {
        MessageBox.Show(ex.Message);
    }
}



 private void BtnClear_Click(object sender, EventArgs e)
            {
            
                txtQuiz1.Clear();
                txtQuiz2.Clear();
                txtLab1.Clear();
                txtLab2.Clear();
                txtLab3.Clear();
                txtAct1.Clear();
                txtAct2.Clear();
                txtAct3.Clear();
                txtExam.Clear();
                

                lblPeriodicGrade.Text = "Computed Periodic Grade:";
                lblEquivalentGrade.Text = "Equivalent Grade:";
                lblRemarks.Text = "Remarks:"; 
            }

        }

public class PeriodicGradeCalculator
        {

    public double ComputePeriodicGrade(double quiz1, double quiz2, double lab1, double lab2, double lab3, double act1, double act2, double act3, double exam)
    {
        return (quiz1 + quiz2 + lab1 + lab2 + lab3 + act1 + act2 + act3 + exam) / 9;
    }
  public string ComputeEquivalentSubjectGrade(double periodicGrade)
    {
        if (periodicGrade >= 97.5)
            return "1.0";
        else if (periodicGrade >= 94.5)
            return "1.25";
        else if (periodicGrade >= 91.5)
            return "1.5";
        else if (periodicGrade >= 88.5)
            return "1.75";
        else if (periodicGrade >= 85.5)
            return "2.0";
        else if (periodicGrade >= 82.5)
            return "2.25";
        else if (periodicGrade >= 79.5)
            return "2.5";
        else if (periodicGrade >= 76.5)
            return "2.75";
        else if (periodicGrade >= 74.5)
            return "3.0";
        else if (periodicGrade >= 50)
            return "5.0";
        else
            return "Failed";
    }
 public string DetermineRemark(double periodicGrade)
    {
        return (periodicGrade >= 50) ? "Passed" : "Failed";
    }
    

        }
public class ScoreValidator
{
    public void ValidateExamScore(double examScore)
    {
        if (examScore < 0 || examScore > 100)
            throw new ArgumentOutOfRangeException("Exam score should be between 0 and 100.");
        if (examScore != 100)
            throw new ArgumentException("Total items for exam must always be 100.");
    }

    public void ValidateQuizScore(double quizScore)
    {
        if (quizScore < 0 || quizScore > 50)
            throw new ArgumentOutOfRangeException("Quiz score should be between 0 and 50.");
    }

    public void ValidateClassroomActivityScore(double activityScore)
    {
        if (activityScore < 0 || activityScore > 100)
            throw new ArgumentOutOfRangeException("Classroom activity score should be between 0 and 100.");
        if (activityScore < 30)
            throw new ArgumentException("Total items for classroom activities should be at least 30.");
    }

    public void ValidateLabActivityScore(double labScore)
    {
        if (labScore < 0 || labScore > 100)
            throw new ArgumentOutOfRangeException("Lab activity score should be between 0 and 100.");
        if (labScore < 50)
            throw new ArgumentException("Total items for laboratory activities should be at least 50.");
    }

    public void ValidateInput(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            throw new ArgumentException("Input cannot be empty or consist only of whitespaces.");
        double result;
        if (!double.TryParse(input, out result))
            throw new ArgumentException("Input must be a valid numeric value.");
    }
}
    
    }
