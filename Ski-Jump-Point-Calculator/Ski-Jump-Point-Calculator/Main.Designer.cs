namespace Ski_Jump_Point_Calculator
{
    partial class Main
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.header = new System.Windows.Forms.Panel();
            this.btnResults = new System.Windows.Forms.Button();
            this.btnPoints = new System.Windows.Forms.Button();
            this.btnJumpers = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.header.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.mainPanel.Location = new System.Drawing.Point(-3, 66);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(740, 359);
            this.mainPanel.TabIndex = 0;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.CornflowerBlue;
            this.header.Controls.Add(this.btnResults);
            this.header.Controls.Add(this.btnPoints);
            this.header.Controls.Add(this.btnJumpers);
            this.header.Controls.Add(this.label2);
            this.header.Controls.Add(this.label1);
            this.header.Location = new System.Drawing.Point(-3, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(740, 60);
            this.header.TabIndex = 1;
            // 
            // btnResults
            // 
            this.btnResults.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResults.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnResults.Location = new System.Drawing.Point(597, 3);
            this.btnResults.Name = "btnResults";
            this.btnResults.Size = new System.Drawing.Size(136, 23);
            this.btnResults.TabIndex = 7;
            this.btnResults.Text = "RESULTS";
            this.btnResults.UseVisualStyleBackColor = true;
            this.btnResults.Click += new System.EventHandler(this.btnResults_Click);
            // 
            // btnPoints
            // 
            this.btnPoints.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoints.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnPoints.Location = new System.Drawing.Point(455, 3);
            this.btnPoints.Name = "btnPoints";
            this.btnPoints.Size = new System.Drawing.Size(136, 23);
            this.btnPoints.TabIndex = 6;
            this.btnPoints.Text = "POINTS";
            this.btnPoints.UseVisualStyleBackColor = true;
            this.btnPoints.Click += new System.EventHandler(this.btnPoints_Click);
            // 
            // btnJumpers
            // 
            this.btnJumpers.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJumpers.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnJumpers.Location = new System.Drawing.Point(313, 3);
            this.btnJumpers.Name = "btnJumpers";
            this.btnJumpers.Size = new System.Drawing.Size(136, 23);
            this.btnJumpers.TabIndex = 5;
            this.btnJumpers.Text = "JUMPERS";
            this.btnJumpers.UseVisualStyleBackColor = true;
            this.btnJumpers.Click += new System.EventHandler(this.btnJumpers_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Magneto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(3, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ski jump point";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(-22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = " CALCULATOR";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(734, 422);
            this.Controls.Add(this.header);
            this.Controls.Add(this.mainPanel);
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Name = "Main";
            this.Text = "Main";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnResults;
        private System.Windows.Forms.Button btnPoints;
        private System.Windows.Forms.Button btnJumpers;
    }
}