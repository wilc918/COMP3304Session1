
namespace COMP3304Session1
{
    partial class FishyNotes
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
            this.MoreFishButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MoreFishButton
            // 
            this.MoreFishButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoreFishButton.Location = new System.Drawing.Point(0, 0);
            this.MoreFishButton.Name = "MoreFishButton";
            this.MoreFishButton.Size = new System.Drawing.Size(200, 50);
            this.MoreFishButton.TabIndex = 0;
            this.MoreFishButton.Text = "More Fish!";
            this.MoreFishButton.UseVisualStyleBackColor = true;
            this.MoreFishButton.Click += new System.EventHandler(this.MoreFishButton_Click);
            // 
            // FishyNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 51);
            this.Controls.Add(this.MoreFishButton);
            this.Name = "FishyNotes";
            this.Text = "FishyNotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MoreFishButton;
    }
}

