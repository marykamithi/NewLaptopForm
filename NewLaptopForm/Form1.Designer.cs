namespace NewLaptopForm
{
    partial class Form1
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
            brandTextBox = new TextBox();
            modelTextBox = new TextBox();
            processorTextBox = new TextBox();
            memoryTextBox = new TextBox();
            harddiskTextBox = new TextBox();
            priceTextBox = new TextBox();
            insrtButton = new Button();
            band = new Label();
            Model = new Label();
            Processor = new Label();
            Memory = new Label();
            Harddisk = new Label();
            Price = new Label();
            retrieveButton = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // brandTextBox
            // 
            brandTextBox.Location = new Point(33, 12);
            brandTextBox.Name = "brandTextBox";
            brandTextBox.Size = new Size(150, 31);
            brandTextBox.TabIndex = 0;
            // 
            // modelTextBox
            // 
            modelTextBox.Location = new Point(33, 61);
            modelTextBox.Name = "modelTextBox";
            modelTextBox.Size = new Size(150, 31);
            modelTextBox.TabIndex = 1;
            // 
            // processorTextBox
            // 
            processorTextBox.Location = new Point(33, 113);
            processorTextBox.Name = "processorTextBox";
            processorTextBox.Size = new Size(150, 31);
            processorTextBox.TabIndex = 2;
            // 
            // memoryTextBox
            // 
            memoryTextBox.Location = new Point(33, 163);
            memoryTextBox.Name = "memoryTextBox";
            memoryTextBox.Size = new Size(150, 31);
            memoryTextBox.TabIndex = 3;
            // 
            // harddiskTextBox
            // 
            harddiskTextBox.Location = new Point(33, 217);
            harddiskTextBox.Name = "harddiskTextBox";
            harddiskTextBox.Size = new Size(150, 31);
            harddiskTextBox.TabIndex = 4;
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(33, 269);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(150, 31);
            priceTextBox.TabIndex = 5;
            // 
            // insrtButton
            // 
            insrtButton.Location = new Point(62, 340);
            insrtButton.Name = "insrtButton";
            insrtButton.Size = new Size(112, 34);
            insrtButton.TabIndex = 6;
            insrtButton.Text = "insert";
            insrtButton.UseVisualStyleBackColor = true;
            // 
            // band
            // 
            band.AutoSize = true;
            band.Location = new Point(219, 15);
            band.Name = "band";
            band.Size = new Size(58, 25);
            band.TabIndex = 7;
            band.Text = "Brand";
            // 
            // Model
            // 
            Model.AutoSize = true;
            Model.Location = new Point(219, 64);
            Model.Name = "Model";
            Model.Size = new Size(63, 25);
            Model.TabIndex = 8;
            Model.Text = "Model";
            // 
            // Processor
            // 
            Processor.AutoSize = true;
            Processor.Location = new Point(219, 119);
            Processor.Name = "Processor";
            Processor.Size = new Size(89, 25);
            Processor.TabIndex = 9;
            Processor.Text = "Processor";
            // 
            // Memory
            // 
            Memory.AutoSize = true;
            Memory.Location = new Point(219, 166);
            Memory.Name = "Memory";
            Memory.Size = new Size(79, 25);
            Memory.TabIndex = 10;
            Memory.Text = "Memory";
            // 
            // Harddisk
            // 
            Harddisk.AutoSize = true;
            Harddisk.Location = new Point(219, 220);
            Harddisk.Name = "Harddisk";
            Harddisk.Size = new Size(83, 25);
            Harddisk.TabIndex = 11;
            Harddisk.Text = "Harddisk";
            // 
            // Price
            // 
            Price.AutoSize = true;
            Price.Location = new Point(219, 275);
            Price.Name = "Price";
            Price.Size = new Size(49, 25);
            Price.TabIndex = 12;
            Price.Text = "Price";
            // 
            // retrieveButton
            // 
            retrieveButton.Location = new Point(485, 25);
            retrieveButton.Name = "retrieveButton";
            retrieveButton.Size = new Size(112, 34);
            retrieveButton.TabIndex = 13;
            retrieveButton.Text = "Retrieve";
            retrieveButton.UseVisualStyleBackColor = true;
            retrieveButton.Click += retrieveButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(391, 75);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(683, 225);
            dataGridView1.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1226, 450);
            Controls.Add(dataGridView1);
            Controls.Add(retrieveButton);
            Controls.Add(Price);
            Controls.Add(Harddisk);
            Controls.Add(Memory);
            Controls.Add(Processor);
            Controls.Add(Model);
            Controls.Add(band);
            Controls.Add(insrtButton);
            Controls.Add(priceTextBox);
            Controls.Add(harddiskTextBox);
            Controls.Add(memoryTextBox);
            Controls.Add(processorTextBox);
            Controls.Add(modelTextBox);
            Controls.Add(brandTextBox);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox brandTextBox;
        private TextBox modelTextBox;
        private TextBox processorTextBox;
        private TextBox memoryTextBox;
        private TextBox harddiskTextBox;
        private TextBox priceTextBox;
        private Button insrtButton;
        private Label band;
        private Label Model;
        private Label Processor;
        private Label Memory;
        private Label Harddisk;
        private Label Price;
        private Button retrieveButton;
        private DataGridView dataGridView1;
    }
}
