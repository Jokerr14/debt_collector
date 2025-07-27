namespace DebtCollector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            Title = new Label();
            NewReckon = new Button();
            ReckonList = new ListBox();
            OpenReckon = new Button();
            ReckonTitle = new Label();
            DeleteReckon = new Button();
            DeleteDebtor = new Button();
            DebtorTitle = new Label();
            EditDebtor = new Button();
            DebtorList = new ListBox();
            NewDebtor = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1005, 808);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(340, 480);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(836, 751);
            label1.Name = "label1";
            label1.Size = new Size(445, 54);
            label1.TabIndex = 1;
            label1.Text = "GIVE ME YOUR MONEY!";
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Title.Location = new Point(12, 9);
            Title.Name = "Title";
            Title.Size = new Size(334, 65);
            Title.TabIndex = 2;
            Title.Text = "Debt Collector";
            // 
            // NewReckon
            // 
            NewReckon.Location = new Point(31, 708);
            NewReckon.Name = "NewReckon";
            NewReckon.Size = new Size(183, 34);
            NewReckon.TabIndex = 3;
            NewReckon.Text = "New Reckoning";
            NewReckon.UseVisualStyleBackColor = true;
            // 
            // ReckonList
            // 
            ReckonList.FormattingEnabled = true;
            ReckonList.ItemHeight = 25;
            ReckonList.Location = new Point(31, 208);
            ReckonList.Name = "ReckonList";
            ReckonList.Size = new Size(315, 479);
            ReckonList.TabIndex = 4;
            // 
            // OpenReckon
            // 
            OpenReckon.Location = new Point(234, 708);
            OpenReckon.Name = "OpenReckon";
            OpenReckon.Size = new Size(112, 34);
            OpenReckon.TabIndex = 5;
            OpenReckon.Text = "Open";
            OpenReckon.UseVisualStyleBackColor = true;
            // 
            // ReckonTitle
            // 
            ReckonTitle.AutoSize = true;
            ReckonTitle.Font = new Font("Segoe UI", 16F);
            ReckonTitle.Location = new Point(31, 144);
            ReckonTitle.Name = "ReckonTitle";
            ReckonTitle.Size = new Size(182, 45);
            ReckonTitle.TabIndex = 7;
            ReckonTitle.Text = "Reckonings";
            // 
            // DeleteReckon
            // 
            DeleteReckon.Location = new Point(31, 769);
            DeleteReckon.Name = "DeleteReckon";
            DeleteReckon.Size = new Size(183, 34);
            DeleteReckon.TabIndex = 8;
            DeleteReckon.Text = "Delete Reckoning";
            DeleteReckon.UseVisualStyleBackColor = true;
            // 
            // DeleteDebtor
            // 
            DeleteDebtor.Location = new Point(452, 769);
            DeleteDebtor.Name = "DeleteDebtor";
            DeleteDebtor.Size = new Size(183, 34);
            DeleteDebtor.TabIndex = 13;
            DeleteDebtor.Text = "Delete Debtor";
            DeleteDebtor.UseVisualStyleBackColor = true;
            DeleteDebtor.Click += Button1_Click;
            // 
            // DebtorTitle
            // 
            DebtorTitle.AutoSize = true;
            DebtorTitle.Font = new Font("Segoe UI", 16F);
            DebtorTitle.Location = new Point(452, 144);
            DebtorTitle.Name = "DebtorTitle";
            DebtorTitle.Size = new Size(133, 45);
            DebtorTitle.TabIndex = 12;
            DebtorTitle.Text = "Debtors";
            DebtorTitle.Click += Label2_Click;
            // 
            // EditDebtor
            // 
            EditDebtor.Location = new Point(655, 708);
            EditDebtor.Name = "EditDebtor";
            EditDebtor.Size = new Size(112, 34);
            EditDebtor.TabIndex = 11;
            EditDebtor.Text = "Edit";
            EditDebtor.UseVisualStyleBackColor = true;
            EditDebtor.Click += Button2_Click;
            // 
            // DebtorList
            // 
            DebtorList.FormattingEnabled = true;
            DebtorList.ItemHeight = 25;
            DebtorList.Location = new Point(452, 208);
            DebtorList.Name = "DebtorList";
            DebtorList.Size = new Size(315, 479);
            DebtorList.TabIndex = 10;
            DebtorList.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
            // 
            // NewDebtor
            // 
            NewDebtor.Location = new Point(452, 708);
            NewDebtor.Name = "NewDebtor";
            NewDebtor.Size = new Size(183, 34);
            NewDebtor.TabIndex = 9;
            NewDebtor.Text = "New Debtor";
            NewDebtor.UseVisualStyleBackColor = true;
            NewDebtor.Click += Button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1293, 1241);
            Controls.Add(DeleteDebtor);
            Controls.Add(DebtorTitle);
            Controls.Add(EditDebtor);
            Controls.Add(DebtorList);
            Controls.Add(NewDebtor);
            Controls.Add(DeleteReckon);
            Controls.Add(ReckonTitle);
            Controls.Add(OpenReckon);
            Controls.Add(ReckonList);
            Controls.Add(NewReckon);
            Controls.Add(Title);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label Title;
        private Button NewReckon;
        private ListBox ReckonList;
        private Button OpenReckon;
        private Label ReckonTitle;
        private Button DeleteReckon;
        private Button DeleteDebtor;
        private Label DebtorTitle;
        private Button EditDebtor;
        private ListBox DebtorList;
        private Button NewDebtor;
    }
}
