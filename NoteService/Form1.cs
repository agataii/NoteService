using System.Net.Http.Headers;
using System.Windows.Forms;

namespace NoteService
{
    public partial class Form1 : Form
    {
        private bool _isDragging;
        private Point _dragStartPosition;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isDragging)
            {
                int deltaX = e.X - _dragStartPosition.X;
                int deltaY = e.Y - _dragStartPosition.Y;

                Location= new Point(deltaX + Location.X, deltaY + Location.Y);
            }
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) 
            {
                _isDragging= true;
                _dragStartPosition = new Point(e.X, e.Y);
            }
        }
        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Left)
            {
                _isDragging= false;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            if(sender is Label label)
            {
                label.ForeColor= Color.White;
                label.BackColor= Color.Red;
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Label label)
            {
                label.ForeColor = Color.Black;
                label.BackColor= Color.White;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            ListViewItem listViewItem = _noteListView.Items.Add("Text");

            Form noteAddForm = new NoteAddForm(listViewItem);
            noteAddForm.Show();
        }

        private void ListView_ItemActivate(object sender, EventArgs e)
        {
            Form noteAddForm = new NoteAddForm(_noteListView.FocusedItem);
            noteAddForm.Show();
        }
    }
}