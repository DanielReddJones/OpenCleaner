namespace OpenCleaner
{
    partial class OpenCleaner
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
            this.contButton = new System.Windows.Forms.Button();
            this.InstLabel = new System.Windows.Forms.Label();
            this.YesTask = new System.Windows.Forms.Button();
            this.NoTask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contButton
            // 
            this.contButton.Location = new System.Drawing.Point(338, 325);
            this.contButton.Name = "contButton";
            this.contButton.Size = new System.Drawing.Size(75, 23);
            this.contButton.TabIndex = 0;
            this.contButton.Text = "Optimize";
            this.contButton.UseVisualStyleBackColor = true;
            this.contButton.Click += new System.EventHandler(this.contButton_Click);
            // 
            // InstLabel
            // 
            this.InstLabel.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InstLabel.Location = new System.Drawing.Point(12, 9);
            this.InstLabel.Name = "InstLabel";
            this.InstLabel.Size = new System.Drawing.Size(776, 287);
            this.InstLabel.TabIndex = 1;
            this.InstLabel.Text = "Press Optimize to begin the process";
            this.InstLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // YesTask
            // 
            this.YesTask.Location = new System.Drawing.Point(137, 372);
            this.YesTask.Name = "YesTask";
            this.YesTask.Size = new System.Drawing.Size(75, 23);
            this.YesTask.TabIndex = 2;
            this.YesTask.Text = "Yes";
            this.YesTask.UseVisualStyleBackColor = true;
            this.YesTask.Visible = false;
            this.YesTask.Click += new System.EventHandler(this.YesTask_Click);
            // 
            // NoTask
            // 
            this.NoTask.Location = new System.Drawing.Point(549, 372);
            this.NoTask.Name = "NoTask";
            this.NoTask.Size = new System.Drawing.Size(75, 23);
            this.NoTask.TabIndex = 3;
            this.NoTask.Text = "No";
            this.NoTask.UseVisualStyleBackColor = true;
            this.NoTask.Visible = false;
            this.NoTask.Click += new System.EventHandler(this.NoTask_Click);
            // 
            // OpenCleaner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NoTask);
            this.Controls.Add(this.YesTask);
            this.Controls.Add(this.InstLabel);
            this.Controls.Add(this.contButton);
            this.Name = "OpenCleaner";
            this.Text = "Open Cleaner";
            this.ResumeLayout(false);

        }

        #endregion

        private Button contButton;
        private Label InstLabel;
        private Button YesTask;
        private Button NoTask;
    }
}