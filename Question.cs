using System.Collections.Generic;
using System;

namespace HW3Site.Models
{
  public class Question
  {
     public static int num;

       public string QuestionText {get; set;} //the asking of the question
       public List<Answer> Answers;
    

    public static Question[] Initial()
    {
       Question[] QArray = new Question[3];

        
            QArray[0] = new Question{QuestionText="What is 2+2?"};
           QArray[0].Answers = new List<Answer>();

            QArray[0].Answers.Add(new Answer() {AnswerText = "8", IsCorrect=false} );
           QArray[0].Answers.Add(new Answer() {AnswerText = "4", IsCorrect=true} );
           QArray[0].Answers.Add(new Answer() {AnswerText = "17", IsCorrect=false} );
           QArray[0].Answers.Add(new Answer() {AnswerText = "333333", IsCorrect=false} );
          
           QArray[1] = new Question{QuestionText="Who is the Queen of the World?"};
           QArray[1].Answers = new List<Answer>();
           QArray[1].Answers.Add(new Answer() {AnswerText = "Jennifer Lopez", IsCorrect=false} );
           QArray[1].Answers.Add(new Answer() {AnswerText = "Minnie Mouse", IsCorrect=false} );
           QArray[1].Answers.Add(new Answer() {AnswerText = "Michelle Obama", IsCorrect=true} );
           QArray[1].Answers.Add(new Answer() {AnswerText = "Mariah Carey", IsCorrect=false} );

           QArray[2] = new Question{QuestionText="Where is the Idea Center?"};
           QArray[2].Answers = new List<Answer>();
           QArray[2].Answers.Add(new Answer() {AnswerText = "America", IsCorrect=false} );
           QArray[2].Answers.Add(new Answer() {AnswerText = "Miami", IsCorrect=true} );
           QArray[2].Answers.Add(new Answer() {AnswerText = "Bayside", IsCorrect=false} );
           QArray[2].Answers.Add(new Answer() {AnswerText = "Earth", IsCorrect=false} );

           return QArray;
            }

  }

   public class Answer 
        {
            //Values
           public string AnswerText {get; set;}
           public bool IsCorrect {get; set;}//each Answer has a bool value, either right or wrong
        }


  
  

  // public static List<Questions> GetAll() //don't know if i need this
  //   {
  //     return GlobalVariables.Questions;
  //   }

}


