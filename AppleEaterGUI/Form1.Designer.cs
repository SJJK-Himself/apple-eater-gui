namespace AppleEaterUI
{
    partial class programWindow
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
            this.outputBox = new System.Windows.Forms.TextBox();
            this.guideBox = new System.Windows.Forms.GroupBox();
            this.guide1 = new System.Windows.Forms.Label();
            this.feedButton = new System.Windows.Forms.Button();
            this.guideBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(12, 12);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.Size = new System.Drawing.Size(334, 22);
            this.outputBox.TabIndex = 1;
            this.outputBox.Text = "AI: Feed me an apple!";
            // 
            // guideBox
            // 
            this.guideBox.Controls.Add(this.guide1);
            this.guideBox.Location = new System.Drawing.Point(12, 86);
            this.guideBox.Name = "guideBox";
            this.guideBox.Size = new System.Drawing.Size(334, 39);
            this.guideBox.TabIndex = 4;
            this.guideBox.TabStop = false;
            this.guideBox.Text = "Guide";
            // 
            // guide1
            // 
            this.guide1.AutoSize = true;
            this.guide1.Location = new System.Drawing.Point(6, 16);
            this.guide1.Name = "guide1";
            this.guide1.Size = new System.Drawing.Size(223, 13);
            this.guide1.TabIndex = 0;
            this.guide1.Text = "Click the \'Feed\'-button to feed the AI an apple";
            // 
            // feedButton
            // 
            this.feedButton.Location = new System.Drawing.Point(150, 40);
            this.feedButton.Name = "feedButton";
            this.feedButton.Size = new System.Drawing.Size(74, 23);
            this.feedButton.TabIndex = 5;
            this.feedButton.Text = "Feed";
            this.feedButton.UseVisualStyleBackColor = true;
            this.feedButton.Click += new System.EventHandler(this.onFeedButtonClick);
            // 
            // programWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 137);
            this.Controls.Add(this.feedButton);
            this.Controls.Add(this.guideBox);
            this.Controls.Add(this.outputBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "programWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Apple-eating AI";
            this.guideBox.ResumeLayout(false);
            this.guideBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.GroupBox guideBox;
        private System.Windows.Forms.Label guide1;
        private System.Windows.Forms.Button feedButton;
    }
}

