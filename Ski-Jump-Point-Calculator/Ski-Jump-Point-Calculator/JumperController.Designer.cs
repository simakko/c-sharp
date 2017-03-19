namespace Ski_Jump_Point_Calculator
{
    partial class JumperController
    {
        // <summary> 
        // Required designer variable.
        // </summary>
        private System.ComponentModel.IContainer components = null;

        // <summary> 
        // Clean up any resources being used.
        // </summary>
        // <param name = "disposing" > true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        // <summary> 
        // Required method for Designer support - do not modify 
        // the contents of this method with the code editor.
        // </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.JumperDataGrid = new System.Windows.Forms.DataGridView();
            this.colNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddJumperButton = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.countryInput = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel10.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JumperDataGrid)).BeginInit();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel10.Controls.Add(this.btnRemove);
            this.panel10.Controls.Add(this.panel1);
            this.panel10.Controls.Add(this.JumperDataGrid);
            this.panel10.Controls.Add(this.AddJumperButton);
            this.panel10.Controls.Add(this.label25);
            this.panel10.Controls.Add(this.countryInput);
            this.panel10.Controls.Add(this.label23);
            this.panel10.Controls.Add(this.nameInput);
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Location = new System.Drawing.Point(3, -1);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(740, 360);
            this.panel10.TabIndex = 39;
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnRemove.Location = new System.Drawing.Point(352, 240);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(311, 40);
            this.btnRemove.TabIndex = 44;
            this.btnRemove.Text = "REMOVE JUMPER";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(150)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(352, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 100);
            this.panel1.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(150)))));
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(54, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Registered jumpers";
            // 
            // JumperDataGrid
            // 
            this.JumperDataGrid.AllowUserToAddRows = false;
            this.JumperDataGrid.AllowUserToDeleteRows = false;
            this.JumperDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.JumperDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.JumperDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.JumperDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.JumperDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNumber,
            this.colName,
            this.colCountry});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.JumperDataGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.JumperDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.JumperDataGrid.GridColor = System.Drawing.Color.GhostWhite;
            this.JumperDataGrid.Location = new System.Drawing.Point(352, 111);
            this.JumperDataGrid.MultiSelect = false;
            this.JumperDataGrid.Name = "JumperDataGrid";
            this.JumperDataGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.JumperDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.JumperDataGrid.RowHeadersVisible = false;
            this.JumperDataGrid.RowHeadersWidth = 20;
            this.JumperDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.JumperDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.JumperDataGrid.Size = new System.Drawing.Size(311, 113);
            this.JumperDataGrid.StandardTab = true;
            this.JumperDataGrid.TabIndex = 43;
            // 
            // colNumber
            // 
            this.colNumber.HeaderText = "Num";
            this.colNumber.Name = "colNumber";
            this.colNumber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colNumber.Width = 40;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colCountry
            // 
            this.colCountry.HeaderText = "Country";
            this.colCountry.Name = "colCountry";
            // 
            // AddJumperButton
            // 
            this.AddJumperButton.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddJumperButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.AddJumperButton.Location = new System.Drawing.Point(73, 240);
            this.AddJumperButton.Name = "AddJumperButton";
            this.AddJumperButton.Size = new System.Drawing.Size(225, 40);
            this.AddJumperButton.TabIndex = 42;
            this.AddJumperButton.Text = "ADD JUMPER";
            this.AddJumperButton.UseVisualStyleBackColor = true;
            this.AddJumperButton.Click += new System.EventHandler(this.AddJumperButton_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.AliceBlue;
            this.label25.Location = new System.Drawing.Point(91, 176);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(67, 21);
            this.label25.TabIndex = 39;
            this.label25.Text = "Country";
            // 
            // countryInput
            // 
            this.countryInput.Location = new System.Drawing.Point(160, 175);
            this.countryInput.Name = "countryInput";
            this.countryInput.Size = new System.Drawing.Size(117, 20);
            this.countryInput.TabIndex = 38;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.AliceBlue;
            this.label23.Location = new System.Drawing.Point(91, 147);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(52, 21);
            this.label23.TabIndex = 3;
            this.label23.Text = "Name";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(160, 146);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(117, 20);
            this.nameInput.TabIndex = 2;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(150)))));
            this.panel11.Controls.Add(this.label3);
            this.panel11.Location = new System.Drawing.Point(73, 1);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(225, 100);
            this.panel11.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(150)))));
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(47, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "New jumper";
            // 
            // JumperController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel10);
            this.Name = "JumperController";
            this.Size = new System.Drawing.Size(740, 360);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JumperDataGrid)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button AddJumperButton;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox countryInput;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView JumperDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCountry;
        private System.Windows.Forms.Button btnRemove;
    }
}
