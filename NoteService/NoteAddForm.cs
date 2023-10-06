using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteService
{
    public partial class NoteAddForm : Form
    {
        private bool _isDragging;
        private Point _dragStartPosition;

        private ListViewItem _listViewItem;

        public NoteAddForm(ListViewItem listViewItem)
        {
            InitializeComponent();

            _listViewItem= listViewItem;

            textBox1.Text = _listViewItem.Text;
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isDragging)
            {
                int deltaX = e.X - _dragStartPosition.X;
                int deltaY = e.Y - _dragStartPosition.Y;

                Location = new Point(deltaX + Location.X, deltaY + Location.Y);
            }
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _isDragging = true;
                _dragStartPosition = new Point(e.X, e.Y);
            }
        }
        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _isDragging = false;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Label label)
            {
                label.ForeColor = Color.White;
                label.BackColor = Color.Red;
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Label label)
            {
                label.ForeColor = Color.Black;
                label.BackColor = Color.White;
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            _listViewItem.Text = textBox1.Text;
        }
    }
}
