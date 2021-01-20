
namespace COMP3304Session1
{
    partial class FishyNote
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
            this.FishyTextBox = new System.Windows.Forms.RichTextBox();
            this.FishyDeleteButton = new System.Windows.Forms.Button();
            this.CollapseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FishyTextBox
            // 
            this.FishyTextBox.Location = new System.Drawing.Point(12, 149);
            this.FishyTextBox.Name = "FishyTextBox";
            this.FishyTextBox.Size = new System.Drawing.Size(329, 198);
            this.FishyTextBox.TabIndex = 0;
            this.FishyTextBox.Text = "Enter your note text here...";
            this.FishyTextBox.Click += new System.EventHandler(this.FishyTextBox_Click);
            this.FishyTextBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // FishyDeleteButton
            // 
            this.FishyDeleteButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.FishyDeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FishyDeleteButton.Location = new System.Drawing.Point(311, 12);
            this.FishyDeleteButton.Name = "FishyDeleteButton";
            this.FishyDeleteButton.Size = new System.Drawing.Size(30, 30);
            this.FishyDeleteButton.TabIndex = 1;
            this.FishyDeleteButton.Text = "X";
            this.FishyDeleteButton.UseVisualStyleBackColor = true;
            this.FishyDeleteButton.Click += new System.EventHandler(this.FishyDeleteButton_Click);
            // 
            // CollapseButton
            // 
            this.CollapseButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CollapseButton.Location = new System.Drawing.Point(12, 12);
            this.CollapseButton.Name = "CollapseButton";
            this.CollapseButton.Size = new System.Drawing.Size(75, 50);
            this.CollapseButton.TabIndex = 2;
            this.CollapseButton.UseVisualStyleBackColor = false;
            this.CollapseButton.Click += new System.EventHandler(this.CollapseButton_Click);
            // 
            // FishyNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(353, 372);
            this.Controls.Add(this.CollapseButton);
            this.Controls.Add(this.FishyDeleteButton);
            this.Controls.Add(this.FishyTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FishyNote";
            this.Text = "FishyNote";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FishyNote_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FishyNote_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FishyNote_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox FishyTextBox;
        private System.Windows.Forms.Button FishyDeleteButton;
        private System.Windows.Forms.Button CollapseButton;
    }
}