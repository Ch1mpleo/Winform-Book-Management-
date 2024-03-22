namespace GUI
{
    partial class BookDetailForm
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
            lblHeader = new Label();
            groupBox1 = new GroupBox();
            cbCategory = new ComboBox();
            lblCategory = new Label();
            dateTimePicker1 = new DateTimePicker();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            txtDescription = new TextBox();
            txtAuthor = new TextBox();
            txtName = new TextBox();
            lblPrice = new Label();
            label1 = new Label();
            lblDate = new Label();
            label5 = new Label();
            label4 = new Label();
            lblDescription = new Label();
            lblName = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            txtBookId = new TextBox();
            lblBookId = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Book Antiqua", 25.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeader.Location = new Point(372, 40);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(436, 51);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Add | Update a book";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtBookId);
            groupBox1.Controls.Add(lblBookId);
            groupBox1.Controls.Add(cbCategory);
            groupBox1.Controls.Add(lblCategory);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(txtQuantity);
            groupBox1.Controls.Add(txtDescription);
            groupBox1.Controls.Add(txtAuthor);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(lblPrice);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lblDate);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lblDescription);
            groupBox1.Controls.Add(lblName);
            groupBox1.Location = new Point(31, 110);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(842, 464);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Book info";
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(182, 410);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(229, 28);
            cbCategory.TabIndex = 28;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Book Antiqua", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblCategory.Location = new Point(59, 416);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(84, 22);
            lblCategory.TabIndex = 27;
            lblCategory.Text = "Category";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(182, 299);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(282, 27);
            dateTimePicker1.TabIndex = 26;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(539, 363);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(229, 27);
            txtPrice.TabIndex = 25;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(182, 363);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(229, 27);
            txtQuantity.TabIndex = 24;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(182, 192);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(586, 76);
            txtDescription.TabIndex = 23;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(182, 133);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(299, 27);
            txtAuthor.TabIndex = 22;
            // 
            // txtName
            // 
            txtName.Location = new Point(182, 89);
            txtName.Name = "txtName";
            txtName.Size = new Size(299, 27);
            txtName.TabIndex = 21;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Book Antiqua", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrice.Location = new Point(74, 133);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(65, 22);
            lblPrice.TabIndex = 20;
            lblPrice.Text = "Author";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(474, 368);
            label1.Name = "label1";
            label1.Size = new Size(50, 22);
            label1.TabIndex = 19;
            label1.Text = "Price";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Book Antiqua", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblDate.Location = new Point(-3, 299);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(143, 22);
            lblDate.TabIndex = 18;
            lblDate.Text = "Publication Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(182, 222);
            label5.Name = "label5";
            label5.Size = new Size(0, 24);
            label5.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Book Antiqua", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(59, 368);
            label4.Name = "label4";
            label4.Size = new Size(81, 22);
            label4.TabIndex = 17;
            label4.Text = "Quantity";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Book Antiqua", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescription.Location = new Point(36, 194);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(103, 22);
            lblDescription.TabIndex = 15;
            lblDescription.Text = "Description";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Book Antiqua", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(80, 89);
            lblName.Name = "lblName";
            lblName.Size = new Size(59, 22);
            lblName.TabIndex = 14;
            lblName.Text = "Name";
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(910, 161);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(158, 44);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(910, 231);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(158, 44);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtBookId
            // 
            txtBookId.Location = new Point(182, 51);
            txtBookId.Name = "txtBookId";
            txtBookId.Size = new Size(299, 27);
            txtBookId.TabIndex = 30;
            // 
            // lblBookId
            // 
            lblBookId.AutoSize = true;
            lblBookId.Font = new Font("Book Antiqua", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblBookId.Location = new Point(63, 51);
            lblBookId.Name = "lblBookId";
            lblBookId.Size = new Size(76, 22);
            lblBookId.TabIndex = 29;
            lblBookId.Text = "Book ID";
            // 
            // BookDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1098, 586);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(groupBox1);
            Controls.Add(lblHeader);
            Name = "BookDetailForm";
            Text = "Book Detail";
            Load += BookDetailForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private GroupBox groupBox1;
        private ComboBox cbCategory;
        private Label lblCategory;
        private DateTimePicker dateTimePicker1;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private TextBox txtDescription;
        private TextBox txtAuthor;
        private TextBox txtName;
        private Label lblPrice;
        private Label label1;
        private Label lblDate;
        private Label label5;
        private Label label4;
        private Label lblDescription;
        private Label lblName;
        private Button btnSave;
        private Button btnCancel;
        private TextBox txtBookId;
        private Label lblBookId;
    }
}