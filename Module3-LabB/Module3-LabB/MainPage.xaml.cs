using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Module3_LabB
{
    public partial class MainPage : ContentPage
    {
        //ObservableCollection<Question> questions = new ObservableCollection<Question>();
        //public ObservableCollection<Question> Questions { get { return questions; } }

        public MainPage()
        {
           
            InitializeComponent();

            CompletedView.IsVisible = false;

            //QuestionView.ItemsSource = questions;

            //questions.Add(new Question("Seahorses have stomachs, which aid in the digestion of food.", false, "seahorses dont have stomachs, only intestines"));
            //questions.Add(new Question("The first living animal sent into space were fruit flies.", true, ""));
            //questions.Add(new Question("The Atlantic Ocean is the world’s biggest ocean. ", false, "The Pacific Ocean is the largest ocean"));
            //questions.Add(new Question("The United Kingdom is almost the same size as France.", false, "the UK is smaller than France."));
            //questions.Add(new Question("In Scotland, the unicorn is their national animal.", true, ""));
            //questions.Add(new Question("The letter ‘A’ is the most commonly used in the English language.", false, "'e' is the most commonly used letter"));
            //questions.Add(new Question("Zeus is referred to as the king of the Greek gods and goddesses.", true, ""));
            //questions.Add(new Question("Among the letters of the alphabet, only the letter J is not included in the periodic table.", true, ""));

        }

        //public class Question
        //{
        //    public string QuestionText { get; set;}
        //    public bool Answer { get; set; }
        //    public string CorrectAnswer { get; set; }

        //    public Question(string q, bool a, string c)
        //    {
        //        QuestionText = q;
        //        Answer = a;
        //        CorrectAnswer = c;

        //    }
        //    public string DisplayCorrect(){return "Correct!";}
        //    public string DisplayIncorrect(){return "Incorrect, the correct answer was: " + this.CorrectAnswer + ".";}
        //}

        void Handle_Clicked(Object sender, System.EventArgs e)
        {
            double correctAnswers = 0;

            if (Question_1_False.IsChecked)
            {
                
                correctAnswers++; 
            }

            if (Question_2_True.IsChecked)
            {
                correctAnswers++;
            }

            if (Question_3_False.IsChecked)
            {
                correctAnswers++;
            }

            if (Question_4_False.IsChecked)
            {
                correctAnswers++;
            }

            if (Question_5_True.IsChecked)
            {
                correctAnswers++;
            }

            QuestionsView.IsVisible = false;
            CompletedView.IsVisible = true;

            CorrectAnswersCount.Text = correctAnswers.ToString();
        }

    }
}

