namespace NoteService
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Текст1",
            "Описание",
            "Дата создание",
            "Дата изменение"}, -1);
            this._addButton = new System.Windows.Forms.Label();
            this._closeButton = new System.Windows.Forms.Label();
            this._noteListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // _addButton
            // 
            this._addButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._addButton.Location = new System.Drawing.Point(-2, -1);
            this._addButton.Name = "_addButton";
            this._addButton.Size = new System.Drawing.Size(40, 40);
            this._addButton.TabIndex = 0;
            this._addButton.Text = "+";
            this._addButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._addButton.Click += new System.EventHandler(this.AddButton_Click);
            this._addButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this._addButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // _closeButton
            // 
            this._closeButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._closeButton.Location = new System.Drawing.Point(345, -1);
            this._closeButton.Name = "_closeButton";
            this._closeButton.Size = new System.Drawing.Size(40, 40);
            this._closeButton.TabIndex = 0;
            this._closeButton.Text = "X";
            this._closeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            this._closeButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this._closeButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // _noteListView
            // 
            this._noteListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this._noteListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this._noteListView.Location = new System.Drawing.Point(12, 42);
            this._noteListView.Name = "_noteListView";
            this._noteListView.Size = new System.Drawing.Size(360, 507);
            this._noteListView.TabIndex = 1;
            this._noteListView.UseCompatibleStateImageBehavior = false;
            this._noteListView.View = System.Windows.Forms.View.Details;
            this._noteListView.ItemActivate += new System.EventHandler(this.ListView_ItemActivate);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Заголовок";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Содержание";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Дата создание";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Дата изменение";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this._noteListView);
            this.Controls.Add(this._closeButton);
            this.Controls.Add(this._addButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private Label _addButton;
        private Label _closeButton;
        private ListView _noteListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}