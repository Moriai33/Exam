using Exam.Application.Interface;
using Exam.Domain;
using System;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;

namespace Exam
{
    public partial class DataManagementForm : Form
    {
        private readonly IBookManagementService _bookManagementService;
        IEnumerable<Author> authors;

        public DataManagementForm(IBookManagementService bookManagementService)
        {
            InitializeComponent();
            _bookManagementService = bookManagementService;
            authors = _bookManagementService.GetAuthors();
        }
        
        private void DataManagementForm_Load(object sender, EventArgs e)
        {
            ReloadAuthorsToComboBox();
        }

        private void ReloadAuthorsToComboBox()
        {
            authors = _bookManagementService.GetAuthors().OrderBy(a => a.Name);
            var bindingSource = new BindingSource
            {
                DataSource = authors.Select(author => author.Name)
            };
            AuthorComboBox.DataSource = bindingSource;
        }

        private void AddAuthorButton_Click(object sender, EventArgs e)
        {
            if (IsValidAuthor())
            {
                if (!_bookManagementService.IsAuthorExists(authorNameTextBox.Text))
                {
                    _bookManagementService.AddAuthor(authorNameTextBox.Text);
                    ReloadAuthorsToComboBox();
                    MessageBox.Show(PresentationResource.DataManagementForm_Add_Success);
                }
                else
                {
                    MessageBox.Show(PresentationResource.DataManagementForm_AuthorAlreadyExists);
                }

                authorNameTextBox.Clear();
            }
            else
            {
                MessageBox.Show(PresentationResource.DataManagementForm_Add_Error);
            }
        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            if (IsValidBook())
            {
                if (!_bookManagementService.IsBookExists(bookTitleTextBox.Text))
                {
                    var authorId = authors.Single(author => author.Name == AuthorComboBox.SelectedItem.ToString()).Id;
                    _bookManagementService.AddBook(new Book(authorId, bookTitleTextBox.Text));
                    MessageBox.Show(PresentationResource.DataManagementForm_Add_Success);
                }
                else
                {
                    MessageBox.Show(PresentationResource.DataManagementForm_BookAlreadyExists);
                }

                bookTitleTextBox.Clear();
            }
            else
            {
                MessageBox.Show(PresentationResource.DataManagementForm_Add_Error);
            }

        }
        private bool IsValidBook()
        {
            return !(string.IsNullOrEmpty(bookTitleTextBox.Text) || string.IsNullOrWhiteSpace(bookTitleTextBox.Text));
        }
        private bool IsValidAuthor()
        {
            return !(string.IsNullOrEmpty(authorNameTextBox.Text) || string.IsNullOrWhiteSpace(authorNameTextBox.Text));
        }

        private void DataManagamentFormCloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}