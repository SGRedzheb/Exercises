namespace Event_Manager
{
    partial class EventManagerForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.CreateEventButton = new System.Windows.Forms.Button();
            this.UpdateEventButton = new System.Windows.Forms.Button();
            this.DeleteEventButton = new System.Windows.Forms.Button();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.EventDataGridView = new System.Windows.Forms.DataGridView();
            this.startTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startTimeLabel = new System.Windows.Forms.Label();
            this.endTimeLabel = new System.Windows.Forms.Label();
            this.endTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.EventDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.nameLabel.Location = new System.Drawing.Point(19, 22);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(19, 48);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(48, 13);
            this.locationLabel.TabIndex = 1;
            this.locationLabel.Text = "Location";
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(188, 22);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(55, 13);
            this.startDateLabel.TabIndex = 2;
            this.startDateLabel.Text = "Start Date";
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(188, 48);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(52, 13);
            this.endDateLabel.TabIndex = 3;
            this.endDateLabel.Text = "End Date";
            this.endDateLabel.Click += new System.EventHandler(this.CreateEventButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(72, 19);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // locationTextBox
            // 
            this.locationTextBox.Location = new System.Drawing.Point(72, 45);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(100, 20);
            this.locationTextBox.TabIndex = 5;
            // 
            // CreateEventButton
            // 
            this.CreateEventButton.Location = new System.Drawing.Point(43, 86);
            this.CreateEventButton.Name = "CreateEventButton";
            this.CreateEventButton.Size = new System.Drawing.Size(75, 23);
            this.CreateEventButton.TabIndex = 8;
            this.CreateEventButton.Text = "Create";
            this.CreateEventButton.UseVisualStyleBackColor = true;
            this.CreateEventButton.Click += new System.EventHandler(this.CreateEventButton_Click);
            // 
            // UpdateEventButton
            // 
            this.UpdateEventButton.Location = new System.Drawing.Point(181, 86);
            this.UpdateEventButton.Name = "UpdateEventButton";
            this.UpdateEventButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateEventButton.TabIndex = 9;
            this.UpdateEventButton.Text = "Update";
            this.UpdateEventButton.UseVisualStyleBackColor = true;
            this.UpdateEventButton.Click += new System.EventHandler(this.UpdateEventButton_Click);
            // 
            // DeleteEventButton
            // 
            this.DeleteEventButton.Location = new System.Drawing.Point(318, 86);
            this.DeleteEventButton.Name = "DeleteEventButton";
            this.DeleteEventButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteEventButton.TabIndex = 10;
            this.DeleteEventButton.Text = "Delete";
            this.DeleteEventButton.UseVisualStyleBackColor = true;
            this.DeleteEventButton.Click += new System.EventHandler(this.DeleteEventButton_Click);
            // 
            // startDatePicker
            // 
            this.startDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDatePicker.Location = new System.Drawing.Point(249, 19);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(98, 20);
            this.startDatePicker.TabIndex = 11;
            // 
            // endDatePicker
            // 
            this.endDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDatePicker.Location = new System.Drawing.Point(249, 45);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(98, 20);
            this.endDatePicker.TabIndex = 12;
            // 
            // EventDataGridView
            // 
            this.EventDataGridView.AllowUserToAddRows = false;
            this.EventDataGridView.AllowUserToDeleteRows = false;
            this.EventDataGridView.AllowUserToResizeColumns = false;
            this.EventDataGridView.AllowUserToResizeRows = false;
            this.EventDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.EventDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EventDataGridView.Location = new System.Drawing.Point(12, 147);
            this.EventDataGridView.Name = "EventDataGridView";
            this.EventDataGridView.Size = new System.Drawing.Size(750, 204);
            this.EventDataGridView.TabIndex = 13;
            this.EventDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EventDataGridView_RowHeaderMouseClick);
            // 
            // startTimePicker
            // 
            this.startTimePicker.CustomFormat = "HH:MM";
            this.startTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startTimePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.startTimePicker.Location = new System.Drawing.Point(431, 20);
            this.startTimePicker.Name = "startTimePicker";
            this.startTimePicker.Size = new System.Drawing.Size(80, 20);
            this.startTimePicker.TabIndex = 14;
            this.startTimePicker.Value = new System.DateTime(2018, 6, 15, 12, 29, 0, 0);
            // 
            // startTimeLabel
            // 
            this.startTimeLabel.AutoSize = true;
            this.startTimeLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.startTimeLabel.Location = new System.Drawing.Point(370, 22);
            this.startTimeLabel.Name = "startTimeLabel";
            this.startTimeLabel.Size = new System.Drawing.Size(55, 13);
            this.startTimeLabel.TabIndex = 16;
            this.startTimeLabel.Text = "Start Time";
            // 
            // endTimeLabel
            // 
            this.endTimeLabel.AutoSize = true;
            this.endTimeLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.endTimeLabel.Location = new System.Drawing.Point(370, 48);
            this.endTimeLabel.Name = "endTimeLabel";
            this.endTimeLabel.Size = new System.Drawing.Size(52, 13);
            this.endTimeLabel.TabIndex = 17;
            this.endTimeLabel.Text = "End Time";
            // 
            // endTimePicker
            // 
            this.endTimePicker.CustomFormat = "HH:MM";
            this.endTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endTimePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.endTimePicker.Location = new System.Drawing.Point(431, 48);
            this.endTimePicker.Name = "endTimePicker";
            this.endTimePicker.Size = new System.Drawing.Size(80, 20);
            this.endTimePicker.TabIndex = 18;
            this.endTimePicker.Value = new System.DateTime(2018, 6, 15, 12, 29, 0, 0);
            // 
            // EventManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 363);
            this.Controls.Add(this.endTimePicker);
            this.Controls.Add(this.endTimeLabel);
            this.Controls.Add(this.startTimeLabel);
            this.Controls.Add(this.startTimePicker);
            this.Controls.Add(this.EventDataGridView);
            this.Controls.Add(this.endDatePicker);
            this.Controls.Add(this.startDatePicker);
            this.Controls.Add(this.DeleteEventButton);
            this.Controls.Add(this.UpdateEventButton);
            this.Controls.Add(this.CreateEventButton);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.nameLabel);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Name = "EventManagerForm";
            this.Text = "Event Manager";
            ((System.ComponentModel.ISupportInitialize)(this.EventDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.Button CreateEventButton;
        private System.Windows.Forms.Button UpdateEventButton;
        private System.Windows.Forms.Button DeleteEventButton;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.DataGridView EventDataGridView;
        private System.Windows.Forms.Label startTimeLabel;
        private System.Windows.Forms.Label endTimeLabel;
        private System.Windows.Forms.DateTimePicker startTimePicker;
        private System.Windows.Forms.DateTimePicker endTimePicker;
    }
}

