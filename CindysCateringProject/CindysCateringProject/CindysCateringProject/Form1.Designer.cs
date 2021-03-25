namespace CindysCateringProject
{
    partial class Catering
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
            this.submitOrderButton = new System.Windows.Forms.Button();
            this.reviewOrderCheckBox = new System.Windows.Forms.CheckBox();
            this.entreeComboBox = new System.Windows.Forms.ComboBox();
            this.sideOneComboBox = new System.Windows.Forms.ComboBox();
            this.sideTwoComboBox = new System.Windows.Forms.ComboBox();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.numberOfGuestTextBox = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.TextBox();
            this.customerName = new System.Windows.Forms.Label();
            this.customerPhoneNumber = new System.Windows.Forms.Label();
            this.numberOfGuests = new System.Windows.Forms.Label();
            this.entree = new System.Windows.Forms.Label();
            this.sideOne = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.costOfEventLabel = new System.Windows.Forms.Label();
            this.dessertComboBox = new System.Windows.Forms.ComboBox();
            this.totalCostTextBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // submitOrderButton
            // 
            this.submitOrderButton.Location = new System.Drawing.Point(269, 375);
            this.submitOrderButton.Name = "submitOrderButton";
            this.submitOrderButton.Size = new System.Drawing.Size(123, 23);
            this.submitOrderButton.TabIndex = 0;
            this.submitOrderButton.Text = "Submit Order";
            this.submitOrderButton.UseVisualStyleBackColor = true;
            this.submitOrderButton.Click += new System.EventHandler(this.submitOrderButton_Click);
            // 
            // reviewOrderCheckBox
            // 
            this.reviewOrderCheckBox.AutoSize = true;
            this.reviewOrderCheckBox.Location = new System.Drawing.Point(283, 330);
            this.reviewOrderCheckBox.Name = "reviewOrderCheckBox";
            this.reviewOrderCheckBox.Size = new System.Drawing.Size(91, 17);
            this.reviewOrderCheckBox.TabIndex = 1;
            this.reviewOrderCheckBox.Text = "Review Order";
            this.reviewOrderCheckBox.UseVisualStyleBackColor = true;
            this.reviewOrderCheckBox.CheckedChanged += new System.EventHandler(this.reviewOrderChecked);
            // 
            // entreeComboBox
            // 
            this.entreeComboBox.FormattingEnabled = true;
            this.entreeComboBox.Items.AddRange(new object[] {
            "Steak",
            "Lamb",
            "Salmon",
            "Chicken"});
            this.entreeComboBox.Location = new System.Drawing.Point(120, 126);
            this.entreeComboBox.Name = "entreeComboBox";
            this.entreeComboBox.Size = new System.Drawing.Size(121, 21);
            this.entreeComboBox.TabIndex = 2;
            // 
            // sideOneComboBox
            // 
            this.sideOneComboBox.FormattingEnabled = true;
            this.sideOneComboBox.Items.AddRange(new object[] {
            "Mashed Potatos",
            "Green Beans",
            "Rice",
            "House Salad"});
            this.sideOneComboBox.Location = new System.Drawing.Point(120, 153);
            this.sideOneComboBox.Name = "sideOneComboBox";
            this.sideOneComboBox.Size = new System.Drawing.Size(121, 21);
            this.sideOneComboBox.TabIndex = 3;
            // 
            // sideTwoComboBox
            // 
            this.sideTwoComboBox.FormattingEnabled = true;
            this.sideTwoComboBox.Items.AddRange(new object[] {
            "Mashed Potatos",
            "Green Beans",
            "Rice",
            "House Salad"});
            this.sideTwoComboBox.Location = new System.Drawing.Point(120, 180);
            this.sideTwoComboBox.Name = "sideTwoComboBox";
            this.sideTwoComboBox.Size = new System.Drawing.Size(121, 21);
            this.sideTwoComboBox.TabIndex = 4;
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(120, 66);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.customerNameTextBox.TabIndex = 5;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(120, 95);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneNumberTextBox.TabIndex = 6;
            // 
            // numberOfGuestTextBox
            // 
            this.numberOfGuestTextBox.Location = new System.Drawing.Point(494, 66);
            this.numberOfGuestTextBox.Name = "numberOfGuestTextBox";
            this.numberOfGuestTextBox.Size = new System.Drawing.Size(100, 20);
            this.numberOfGuestTextBox.TabIndex = 7;
            this.numberOfGuestTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.SystemColors.HotTrack;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.Menu;
            this.title.Location = new System.Drawing.Point(269, 12);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(121, 26);
            this.title.TabIndex = 9;
            this.title.Text = "Cindy\'s Catering";
            // 
            // customerName
            // 
            this.customerName.AutoSize = true;
            this.customerName.Location = new System.Drawing.Point(26, 73);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(88, 13);
            this.customerName.TabIndex = 10;
            this.customerName.Text = "Customer Name :";
            // 
            // customerPhoneNumber
            // 
            this.customerPhoneNumber.AutoSize = true;
            this.customerPhoneNumber.Location = new System.Drawing.Point(26, 102);
            this.customerPhoneNumber.Name = "customerPhoneNumber";
            this.customerPhoneNumber.Size = new System.Drawing.Size(84, 13);
            this.customerPhoneNumber.TabIndex = 11;
            this.customerPhoneNumber.Text = "Phone Number :";
            // 
            // numberOfGuests
            // 
            this.numberOfGuests.AutoSize = true;
            this.numberOfGuests.Location = new System.Drawing.Point(390, 73);
            this.numberOfGuests.Name = "numberOfGuests";
            this.numberOfGuests.Size = new System.Drawing.Size(98, 13);
            this.numberOfGuests.TabIndex = 12;
            this.numberOfGuests.Text = "Number of Guests :";
            // 
            // entree
            // 
            this.entree.AutoSize = true;
            this.entree.Location = new System.Drawing.Point(26, 134);
            this.entree.Name = "entree";
            this.entree.Size = new System.Drawing.Size(38, 13);
            this.entree.TabIndex = 13;
            this.entree.Text = "Entree";
            // 
            // sideOne
            // 
            this.sideOne.AutoSize = true;
            this.sideOne.Location = new System.Drawing.Point(26, 161);
            this.sideOne.Name = "sideOne";
            this.sideOne.Size = new System.Drawing.Size(57, 13);
            this.sideOne.TabIndex = 14;
            this.sideOne.Text = "Side One :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Side Two :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Dessert :";
            // 
            // costOfEventLabel
            // 
            this.costOfEventLabel.AutoSize = true;
            this.costOfEventLabel.Location = new System.Drawing.Point(381, 98);
            this.costOfEventLabel.Name = "costOfEventLabel";
            this.costOfEventLabel.Size = new System.Drawing.Size(104, 13);
            this.costOfEventLabel.TabIndex = 17;
            this.costOfEventLabel.Text = "Total Cost of Event :";
            this.costOfEventLabel.Click += new System.EventHandler(this.label8_Click);
            // 
            // dessertComboBox
            // 
            this.dessertComboBox.FormattingEnabled = true;
            this.dessertComboBox.Items.AddRange(new object[] {
            "Cake",
            "Brownies",
            "Ice Cream",
            "Pie"});
            this.dessertComboBox.Location = new System.Drawing.Point(120, 207);
            this.dessertComboBox.Name = "dessertComboBox";
            this.dessertComboBox.Size = new System.Drawing.Size(121, 21);
            this.dessertComboBox.TabIndex = 18;
            // 
            // totalCostTextBox
            // 
            this.totalCostTextBox.AutoSize = true;
            this.totalCostTextBox.Location = new System.Drawing.Point(491, 102);
            this.totalCostTextBox.Name = "totalCostTextBox";
            this.totalCostTextBox.Size = new System.Drawing.Size(0, 13);
            this.totalCostTextBox.TabIndex = 19;
            // 
            // Catering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.totalCostTextBox);
            this.Controls.Add(this.dessertComboBox);
            this.Controls.Add(this.costOfEventLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sideOne);
            this.Controls.Add(this.entree);
            this.Controls.Add(this.numberOfGuests);
            this.Controls.Add(this.customerPhoneNumber);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.title);
            this.Controls.Add(this.numberOfGuestTextBox);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(this.sideTwoComboBox);
            this.Controls.Add(this.sideOneComboBox);
            this.Controls.Add(this.entreeComboBox);
            this.Controls.Add(this.reviewOrderCheckBox);
            this.Controls.Add(this.submitOrderButton);
            this.Name = "Catering";
            this.Text = "Cindy\'s Catering";
            this.Load += new System.EventHandler(this.Catering_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitOrderButton;
        private System.Windows.Forms.CheckBox reviewOrderCheckBox;
        private System.Windows.Forms.ComboBox entreeComboBox;
        private System.Windows.Forms.ComboBox sideOneComboBox;
        private System.Windows.Forms.ComboBox sideTwoComboBox;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.TextBox numberOfGuestTextBox;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Label customerName;
        private System.Windows.Forms.Label customerPhoneNumber;
        private System.Windows.Forms.Label numberOfGuests;
        private System.Windows.Forms.Label entree;
        private System.Windows.Forms.Label sideOne;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label costOfEventLabel;
        private System.Windows.Forms.ComboBox dessertComboBox;
        private System.Windows.Forms.Label totalCostTextBox;
    }
}

