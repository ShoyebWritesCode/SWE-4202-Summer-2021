using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem2
{
    public partial class resArticleTypeTextBox : Form
    {
        public resArticleTypeTextBox()
        {
            InitializeComponent();
        }
        List<StudyBook> StudyBooks = new List<StudyBook>();
        List<ResearchArticle> researchArticles = new List<ResearchArticle>();
        private void addStudyBookButton_Click(object sender, EventArgs e)
        {
            int studyBookID = Convert.ToInt32(studyBookIDTextBox.Text);
            string studyBookTitle = studyBookTitleTextBox.Text;
            string Author = studyBookAuthorTextBox.Text;
            string Publisher = studyBookPublisherTextBox.Text;
            int Quantity = Convert.ToInt32(studyBookQuantityTextBox.Text);
            string ISBN = studyBookISBNTextBox.Text;
            string Genre = studyBookGenreTextBox.Text;

            StudyBook studyBook = new StudyBook();
            studyBook.ID = studyBookID;
            studyBook.Title = studyBookTitle;
            studyBook.Author = Author;
            studyBook.Publisher = Publisher;
            studyBook.Quantity = Quantity;
            studyBook.ISBN = ISBN;
            studyBook.Genre = Genre;

            StudyBooks.Add(studyBook);

            MessageBox.Show("Study Book Added!");
        }

        private void addResearchArticleButton_Click(object sender, EventArgs e)
        {
            int resBookID = Convert.ToInt32(resArticleIDTextBox.Text);
            string resBookTitle = resArticleTitleTextBox.Text;
            string Author = resArticleAuthorTextBox.Text;
            string Publisher = resArticlePublisherTextBox.Text;
            int Quantity = Convert.ToInt32(resArticleQuantityTextBox.Text);
            string DOI = resArticleDOITextBox.Text;
            string pubDate = resArticlePubDateTextBox.Text;
            string CorJ = resArticleCorJTextBox.Text;

            ResearchArticle researchArticle = new ResearchArticle();
            researchArticle.ID = resBookID;
            researchArticle.Title = resBookTitle;
            researchArticle.Author = Author;
            researchArticle.Publisher = Publisher;
            researchArticle.Quantity = Quantity;
            researchArticle.DOI = DOI;
            researchArticle.PubDate = pubDate;
            researchArticle.CorJ = CorJ;

            researchArticles.Add(researchArticle);

            MessageBox.Show("Research Article Added");
        }

        private void borrowStudyBookButton_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(borrowBookIDTextBox.Text);

            for(int i = 0; i < StudyBooks.Count; i++)
            {
                if (StudyBooks[i].ID == ID)
                {
                    if (StudyBooks[i].Quantity > 0)
                    {
                        StudyBooks[i].borrowBook();
                    }

                }
            }
            MessageBox.Show("Book Borrowed!");
        }

        private void borrowResArticleButton_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(borrowArticleIDTextBox.Text);

            for (int i = 0; i < researchArticles.Count; i++)
            {
                if (researchArticles[i].ID == ID)
                {
                    if (researchArticles[i].Quantity > 0)
                    {
                        researchArticles[i].borrowBook();
                    }
                }
            }
            MessageBox.Show("Book Borrowed!");
        }

        private void showStudyBookButton_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(showBookIDTextBox.Text);

            studyBookListBox.Items.Clear();
            for(int i=0; i < StudyBooks.Count; i++)
            {
                if(ID == StudyBooks[i].ID)
                {
                    studyBookListBox.Items.Add(StudyBooks[i].getInfo());
                }
            }
        }

        private void showResArticleButton_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(showArticleIDTextBox.Text);

            researchArticleListBox.Items.Clear();
            for (int i = 0; i < researchArticles.Count; i++)
            {
                if (ID == researchArticles[i].ID)
                {
                    researchArticleListBox.Items.Add(researchArticles[i].getInfo());
                }
            }
        }
    }
}
