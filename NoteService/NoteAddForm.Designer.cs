namespace NoteService
{
    partial class NoteAddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._closeButton = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._closeButton.Location = new System.Drawing.Point(343, 0);
            this._closeButton.Name = "_closeButton";
            this._closeButton.Size = new System.Drawing.Size(40, 40);
            this._closeButton.TabIndex = 1;
            this._closeButton.Text = "X";
            this._closeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            this._closeButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this._closeButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 43);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Text Something";
            this.textBox1.Size = new System.Drawing.Size(360, 306);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // NoteAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this._closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NoteAddForm";
            this.Text = "NoteAddForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label _closeButton;
        private TextBox textBox1;
    }
}