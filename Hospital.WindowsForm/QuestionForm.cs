using Hospital.DAL;
using Hospital.WindowsForm.Models;
using Hospital.WindowsForm.Models.Question;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hospital.WindowsForm
{
    public partial class QuestionForm : Form
    {
        //Списко питань
        private List<QuestionModel> _listQuestions;
        //Поточне питання
        private int indexQuestion = 0;
        private QuestionResultModel[] result;
        public QuestionForm(MyContext context)
        {
            _listQuestions = new List<QuestionModel>();

            foreach(var item in context.Questions.ToList())
            {
                QuestionModel question = new QuestionModel
                {
                    Text = item.Text,
                    Answers = new List<QuestionAnswerModel>()
                };
                int id = 1;
                foreach(var answer in context.Answers
                    .Where(x=>x.QuestionId==item.Id))
                {
                    var answerModel = new QuestionAnswerModel
                    {
                        Id = id++,
                        Text = answer.Text,
                        IsTrue = answer.IsTrue
                    };
                    question.Answers.Add(answerModel);
                }
                _listQuestions.Add(question);
            }

            
            InitializeComponent();
            result = new QuestionResultModel[_listQuestions.Count];
        }

        /// <summary>
        /// Початкова загрузка
        /// </summary>
        private void LoadQuestion()
        {
            lblQuestion.Text = _listQuestions[indexQuestion].Text;
            var answers = _listQuestions[indexQuestion].Answers;
            int dy = 25;
            int startPosition = 30;
            gbAnswers.Controls.Clear();
            for (int i=0;i<answers.Count;i++)
            {
                RadioButton gbOneItem;
                gbOneItem = new System.Windows.Forms.RadioButton();
                gbOneItem.AutoSize = true;
                gbOneItem.Location = new System.Drawing.Point(25, startPosition);
                gbOneItem.Name = $"gbItem{i}";
                gbOneItem.Tag = answers[i];
                gbOneItem.Size = new System.Drawing.Size(67, 19);
                gbOneItem.TabIndex = 1;
                gbOneItem.TabStop = true;
                gbOneItem.Text = answers[i].Text;
                gbOneItem.UseVisualStyleBackColor = true;

                if (this.result[indexQuestion] != null) 
                {
                    if (this.result[indexQuestion].Id == i+1) 
                    {
                        gbOneItem.Checked = true;
                    }
                }

                gbAnswers.Controls.Add(gbOneItem);
                startPosition += dy;
            }

            this.lblCount.Text = $"Питання: {indexQuestion + 1} із {this._listQuestions.Count()}";
        }

        private void QuestionForm_Load(object sender, EventArgs e)
        {
            LoadQuestion();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            var radioButtons = gbAnswers.Controls.OfType<RadioButton>();
            foreach (RadioButton rb in radioButtons)
            {
                if (rb.Checked)
                {
                    var answer = rb.Tag as QuestionAnswerModel;
                    if (result[indexQuestion] == null)
                    {
                        result[indexQuestion] = new QuestionResultModel();
                    }
                    result[indexQuestion].IsTrue = answer.IsTrue;
                    result[indexQuestion].Id = answer.Id;
                }
            }
            if (indexQuestion < this._listQuestions.Count() - 1)
            {
                indexQuestion++;
                if (indexQuestion == this._listQuestions.Count() - 1)
                {
                    this.btnNext.Text = "Результат >>";
                }
                else
                {
                    this.btnNext.Text = "Далі >>";
                }
                LoadQuestion();
            }
            else 
            {
                int count = this.result.Where(x => x == null).Count();
                if (count > 0)
                {
                    MessageBox.Show("Заповніть усі поля!");
                }
                else 
                {
                    ResultForm form = new ResultForm(this._listQuestions.Count(), 
                        this.result.Where(x => x.IsTrue == true).Count());
                    form.ShowDialog();
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (indexQuestion > 0) 
            {
                var radioButtons = gbAnswers.Controls.OfType<RadioButton>();
                foreach (RadioButton rb in radioButtons)
                {
                    if (rb.Checked)
                    {
                        var answer = rb.Tag as QuestionAnswerModel;
                        if (result[indexQuestion] == null)
                        {
                            result[indexQuestion] = new QuestionResultModel();
                        }
                        result[indexQuestion].IsTrue = answer.IsTrue;
                        result[indexQuestion].Id = answer.Id;
                    }
                }
                indexQuestion--;
                if (indexQuestion < this._listQuestions.Count() - 1)
                {
                    this.btnNext.Text = "Далі >>";
                }
                LoadQuestion();
            }

        }
    }
}
