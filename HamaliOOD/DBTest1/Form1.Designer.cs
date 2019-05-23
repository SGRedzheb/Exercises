namespace DBTest1
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.HiltiCheckBox = new System.Windows.Forms.CheckBox();
            this.MeterCheckBox = new System.Windows.Forms.CheckBox();
            this.HammerCheckBox = new System.Windows.Forms.CheckBox();
            this.BeerCheckBox = new System.Windows.Forms.CheckBox();
            this.ClippersCheckBox = new System.Windows.Forms.CheckBox();
            this.SteakCheckBox = new System.Windows.Forms.CheckBox();
            this.MixerCheckBox = new System.Windows.Forms.CheckBox();
            this.MarlboroCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.Location = new System.Drawing.Point(12, 99);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(644, 249);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(112, 7);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 1;
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Location = new System.Drawing.Point(112, 33);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(100, 20);
            this.AgeTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Age";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(166, 69);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(356, 68);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(261, 68);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 7;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // HiltiCheckBox
            // 
            this.HiltiCheckBox.AutoSize = true;
            this.HiltiCheckBox.Location = new System.Drawing.Point(246, 9);
            this.HiltiCheckBox.Name = "HiltiCheckBox";
            this.HiltiCheckBox.Size = new System.Drawing.Size(43, 17);
            this.HiltiCheckBox.TabIndex = 8;
            this.HiltiCheckBox.Text = "Hilti";
            this.HiltiCheckBox.UseVisualStyleBackColor = true;
            // 
            // MeterCheckBox
            // 
            this.MeterCheckBox.AutoSize = true;
            this.MeterCheckBox.Location = new System.Drawing.Point(246, 32);
            this.MeterCheckBox.Name = "MeterCheckBox";
            this.MeterCheckBox.Size = new System.Drawing.Size(53, 17);
            this.MeterCheckBox.TabIndex = 9;
            this.MeterCheckBox.Text = "Meter";
            this.MeterCheckBox.UseVisualStyleBackColor = true;
            // 
            // HammerCheckBox
            // 
            this.HammerCheckBox.AutoSize = true;
            this.HammerCheckBox.Location = new System.Drawing.Point(332, 32);
            this.HammerCheckBox.Name = "HammerCheckBox";
            this.HammerCheckBox.Size = new System.Drawing.Size(65, 17);
            this.HammerCheckBox.TabIndex = 11;
            this.HammerCheckBox.Text = "Hammer";
            this.HammerCheckBox.UseVisualStyleBackColor = true;
            // 
            // BeerCheckBox
            // 
            this.BeerCheckBox.AutoSize = true;
            this.BeerCheckBox.Location = new System.Drawing.Point(332, 9);
            this.BeerCheckBox.Name = "BeerCheckBox";
            this.BeerCheckBox.Size = new System.Drawing.Size(48, 17);
            this.BeerCheckBox.TabIndex = 10;
            this.BeerCheckBox.Text = "Beer";
            this.BeerCheckBox.UseVisualStyleBackColor = true;
            // 
            // ClippersCheckBox
            // 
            this.ClippersCheckBox.AutoSize = true;
            this.ClippersCheckBox.Location = new System.Drawing.Point(418, 32);
            this.ClippersCheckBox.Name = "ClippersCheckBox";
            this.ClippersCheckBox.Size = new System.Drawing.Size(63, 17);
            this.ClippersCheckBox.TabIndex = 13;
            this.ClippersCheckBox.Text = "Clippers";
            this.ClippersCheckBox.UseVisualStyleBackColor = true;
            // 
            // SteakCheckBox
            // 
            this.SteakCheckBox.AutoSize = true;
            this.SteakCheckBox.Location = new System.Drawing.Point(418, 9);
            this.SteakCheckBox.Name = "SteakCheckBox";
            this.SteakCheckBox.Size = new System.Drawing.Size(54, 17);
            this.SteakCheckBox.TabIndex = 12;
            this.SteakCheckBox.Text = "Steak";
            this.SteakCheckBox.UseVisualStyleBackColor = true;
            // 
            // MixerCheckBox
            // 
            this.MixerCheckBox.AutoSize = true;
            this.MixerCheckBox.Location = new System.Drawing.Point(504, 32);
            this.MixerCheckBox.Name = "MixerCheckBox";
            this.MixerCheckBox.Size = new System.Drawing.Size(51, 17);
            this.MixerCheckBox.TabIndex = 15;
            this.MixerCheckBox.Text = "Mixer";
            this.MixerCheckBox.UseVisualStyleBackColor = true;
            // 
            // MarlboroCheckBox
            // 
            this.MarlboroCheckBox.AutoSize = true;
            this.MarlboroCheckBox.Location = new System.Drawing.Point(504, 9);
            this.MarlboroCheckBox.Name = "MarlboroCheckBox";
            this.MarlboroCheckBox.Size = new System.Drawing.Size(67, 17);
            this.MarlboroCheckBox.TabIndex = 14;
            this.MarlboroCheckBox.Text = "Marlboro";
            this.MarlboroCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(668, 360);
            this.Controls.Add(this.MixerCheckBox);
            this.Controls.Add(this.MarlboroCheckBox);
            this.Controls.Add(this.ClippersCheckBox);
            this.Controls.Add(this.SteakCheckBox);
            this.Controls.Add(this.HammerCheckBox);
            this.Controls.Add(this.BeerCheckBox);
            this.Controls.Add(this.MeterCheckBox);
            this.Controls.Add(this.HiltiCheckBox);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AgeTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Hamali OOD";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.CheckBox HiltiCheckBox;
        private System.Windows.Forms.CheckBox MeterCheckBox;
        private System.Windows.Forms.CheckBox HammerCheckBox;
        private System.Windows.Forms.CheckBox BeerCheckBox;
        private System.Windows.Forms.CheckBox ClippersCheckBox;
        private System.Windows.Forms.CheckBox SteakCheckBox;
        private System.Windows.Forms.CheckBox MixerCheckBox;
        private System.Windows.Forms.CheckBox MarlboroCheckBox;
    }
}

