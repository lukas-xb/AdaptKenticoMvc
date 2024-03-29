// This code was generated by a cloud-generators-net tool 
// (see https://github.com/Kentico/cloud-generators-net).
// 
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated. 
// For further modifications of the class, create a separate file with the partial class.

using System;
using System.Collections.Generic;
using KenticoCloud.Delivery;

namespace CloudIntegration.Models.Cloud
{
    public partial class MultipleChoiceQuestionWithCode : BaseComponent
    {
        public const string Codename = "multiple_choice_question__with_code_";
        public const string FeedbackTitleCodename = "feedback_title";
        public const string QuestionTextCodename = "question_text";
        public const string FeedbackIfCorrectCodename = "feedback_if_correct";
        public const string FeedbackIfPartlyCorrectCodename = "feedback_if_partly_correct";
        public const string AnswersCodename = "answers";
        public const string FeedbackIfIncorrectCodename = "feedback_if_incorrect";

        public string FeedbackTitle { get; set; }
        public string QuestionText { get; set; }
        public string FeedbackIfCorrect { get; set; }
        public string FeedbackIfPartlyCorrect { get; set; }
        public IEnumerable<AnswerCode> Answers { get; set; }
        public string FeedbackIfIncorrect { get; set; }
    }
}