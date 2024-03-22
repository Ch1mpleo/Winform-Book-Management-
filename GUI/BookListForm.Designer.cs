namespace GUI
{
    partial class ListBookForm
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
            lblLibrary = new Label();
            groupBox1 = new GroupBox();
            btnReset = new Button();
            txtDescription = new TextBox();
            txtName = new TextBox();
            btnSearch = new Button();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnQuit = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            dtgBookList = new DataGridView();
            label3 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgBookList).BeginInit();
            SuspendLayout();
            // 
            // lblLibrary
            // 
            lblLibrary.AutoSize = true;
            lblLibrary.Font = new Font("Book Antiqua", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblLibrary.Location = new Point(423, 24);
            lblLibrary.Name = "lblLibrary";
            lblLibrary.Size = new Size(343, 44);
            lblLibrary.TabIndex = 0;
            lblLibrary.Text = "Book Management";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnReset);
            groupBox1.Controls.Add(txtDescription);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 71);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1175, 130);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search";
            // 
            // btnReset
            // 
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Location = new Point(1018, 58);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(151, 35);
            btnReset.TabIndex = 6;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(586, 63);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(240, 27);
            txtDescription.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(170, 59);
            txtName.Name = "txtName";
            txtName.Size = new Size(208, 27);
            txtName.TabIndex = 4;
            // 
            // btnSearch
            // 
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Location = new Point(847, 58);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(151, 35);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(401, 63);
            label2.Name = "label2";
            label2.Size = new Size(179, 24);
            label2.TabIndex = 2;
            label2.Text = "Search Description";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(34, 62);
            label1.Name = "label1";
            label1.Size = new Size(130, 24);
            label1.TabIndex = 1;
            label1.Text = "Search Name";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnQuit);
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Controls.Add(btnUpdate);
            groupBox2.Location = new Point(947, 219);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(234, 356);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Action";
            // 
            // btnQuit
            // 
            btnQuit.FlatStyle = FlatStyle.Flat;
            btnQuit.Location = new Point(44, 284);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(151, 35);
            btnQuit.TabIndex = 6;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(44, 168);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(151, 35);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete a book";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Location = new Point(44, 50);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(151, 35);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add a book";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Location = new Point(44, 107);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(151, 35);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update a book";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dtgBookList
            // 
            dtgBookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgBookList.Location = new Point(19, 219);
            dtgBookList.Name = "dtgBookList";
            dtgBookList.RowHeadersWidth = 51;
            dtgBookList.RowTemplate.Height = 29;
            dtgBookList.Size = new Size(911, 356);
            dtgBookList.TabIndex = 3;
            dtgBookList.CellContentDoubleClick += dtgBookList_CellContentClick;
            dtgBookList.SelectionChanged += dtgBookList_SelectionChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Book Antiqua", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(12, 578);
            label3.Name = "label3";
            label3.Size = new Size(148, 22);
            label3.TabIndex = 4;
            label3.Text = "© Ch1mple | 2024";
            // 
            // ListBookForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1199, 609);
            Controls.Add(label3);
            Controls.Add(dtgBookList);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblLibrary);
            Name = "ListBookForm";
            Text = "Library";
            Load += ListBookForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgBookList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLibrary;
        private GroupBox groupBox1;
        private Button btnSearch;
        private Label label2;
        private Label label1;
        private TextBox txtDescription;
        private TextBox txtName;
        private GroupBox groupBox2;
        private Button btnQuit;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnUpdate;
        private DataGridView dtgBookList;
        private Label label3;
        private Button btnReset;
    }
}