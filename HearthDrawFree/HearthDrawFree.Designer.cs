namespace HearthDrawFree
{
    partial class HearthDrawFree
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
            this.cardSelect = new System.Windows.Forms.ComboBox();
            this.cardBox = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.drawnBox = new System.Windows.Forms.ListBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.deckBox = new System.Windows.Forms.ComboBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cardSelect
            // 
            this.cardSelect.FormattingEnabled = true;
            this.cardSelect.Location = new System.Drawing.Point(13, 13);
            this.cardSelect.Name = "cardSelect";
            this.cardSelect.Size = new System.Drawing.Size(154, 21);
            this.cardSelect.Sorted = true;
            this.cardSelect.TabIndex = 0;
            // 
            // cardBox
            // 
            this.cardBox.FormattingEnabled = true;
            this.cardBox.Location = new System.Drawing.Point(13, 41);
            this.cardBox.Name = "cardBox";
            this.cardBox.Size = new System.Drawing.Size(208, 199);
            this.cardBox.Sorted = true;
            this.cardBox.TabIndex = 1;
            this.cardBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.cardBox_MouseDoubleClick);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(173, 13);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(48, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // drawnBox
            // 
            this.drawnBox.FormattingEnabled = true;
            this.drawnBox.Location = new System.Drawing.Point(13, 247);
            this.drawnBox.Name = "drawnBox";
            this.drawnBox.Size = new System.Drawing.Size(208, 186);
            this.drawnBox.Sorted = true;
            this.drawnBox.TabIndex = 3;
            this.drawnBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.drawnBox_MouseDoubleClick);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(13, 440);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(64, 23);
            this.resetButton.TabIndex = 4;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(83, 440);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(68, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(157, 440);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(64, 23);
            this.loadButton.TabIndex = 6;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // deckBox
            // 
            this.deckBox.FormattingEnabled = true;
            this.deckBox.Location = new System.Drawing.Point(13, 500);
            this.deckBox.Name = "deckBox";
            this.deckBox.Size = new System.Drawing.Size(208, 21);
            this.deckBox.TabIndex = 7;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(13, 470);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(208, 20);
            this.nameBox.TabIndex = 8;
            // 
            // HearthDrawFree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 533);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.deckBox);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.drawnBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.cardBox);
            this.Controls.Add(this.cardSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "HearthDrawFree";
            this.Text = "HearthDraw Free v1.0";
            this.Load += new System.EventHandler(this.HearthDrawFree_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cardSelect;
        private System.Windows.Forms.ListBox cardBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListBox drawnBox;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.ComboBox deckBox;
        private System.Windows.Forms.TextBox nameBox;
    }
}

