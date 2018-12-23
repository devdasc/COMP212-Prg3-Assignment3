namespace DisplayBooksDatabase
{
    partial class DisplayBooksDatabase_Form
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
            this.queriesComboBox = new System.Windows.Forms.ComboBox();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // queriesComboBox
            // 
            this.queriesComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.queriesComboBox.FormattingEnabled = true;
            this.queriesComboBox.Items.AddRange(new object[] {
            "All the titles and the authors.",
            "All the titles and the authors-sorted.",
            "All design the authors grouped by title"});
            this.queriesComboBox.Location = new System.Drawing.Point(0, 0);
            this.queriesComboBox.Name = "queriesComboBox";
            this.queriesComboBox.Size = new System.Drawing.Size(859, 21);
            this.queriesComboBox.TabIndex = 0;
            this.queriesComboBox.SelectedIndexChanged += new System.EventHandler(this.queriesComboBox_SelectedIndexChanged);
            // 
            // outputTextBox
            // 
            this.outputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputTextBox.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputTextBox.Location = new System.Drawing.Point(0, 21);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(859, 350);
            this.outputTextBox.TabIndex = 1;
            this.outputTextBox.TextChanged += new System.EventHandler(this.outputTextBox_TextChanged);
            // 
            // DisplayBooksDatabase_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 371);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.queriesComboBox);
            this.Name = "DisplayBooksDatabase_Form";
            this.Text = "Display Books Database";
            this.Load += new System.EventHandler(this.DisplayBooksDatabase_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox queriesComboBox;
        private System.Windows.Forms.TextBox outputTextBox;
    }
}

