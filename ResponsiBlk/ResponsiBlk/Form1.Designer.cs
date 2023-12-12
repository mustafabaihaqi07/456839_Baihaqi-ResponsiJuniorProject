namespace ResponsiBlk
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
            label1 = new Label();
            label2 = new Label();
            namaTb = new TextBox();
            depCb = new ComboBox();
            viewDGV = new DataGridView();
            insertBtn = new Button();
            editBtn = new Button();
            deleteBtn = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            loadBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)viewDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 71);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 0;
            label1.Text = "Nama Karyawan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 106);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 1;
            label2.Text = "Dep. Karyawan";
            // 
            // namaTb
            // 
            namaTb.Location = new Point(140, 68);
            namaTb.Name = "namaTb";
            namaTb.Size = new Size(170, 23);
            namaTb.TabIndex = 2;
            // 
            // depCb
            // 
            depCb.FormattingEnabled = true;
            depCb.Items.AddRange(new object[] { "HR", "Engineer", "Developer", "Product Manager", "Finance" });
            depCb.Location = new Point(140, 103);
            depCb.Name = "depCb";
            depCb.Size = new Size(170, 23);
            depCb.TabIndex = 4;
            // 
            // viewDGV
            // 
            viewDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewDGV.Location = new Point(12, 176);
            viewDGV.Name = "viewDGV";
            viewDGV.Size = new Size(488, 191);
            viewDGV.TabIndex = 5;
            // 
            // insertBtn
            // 
            insertBtn.Location = new Point(12, 147);
            insertBtn.Name = "insertBtn";
            insertBtn.Size = new Size(75, 23);
            insertBtn.TabIndex = 6;
            insertBtn.Text = "Insert";
            insertBtn.UseVisualStyleBackColor = true;
            insertBtn.Click += insertBtn_Click;
            // 
            // editBtn
            // 
            editBtn.Location = new Point(224, 147);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(75, 23);
            editBtn.TabIndex = 7;
            editBtn.Text = "Edit";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += editBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(425, 147);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(75, 23);
            deleteBtn.TabIndex = 8;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(332, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(168, 114);
            panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // loadBtn
            // 
            loadBtn.Location = new Point(425, 373);
            loadBtn.Name = "loadBtn";
            loadBtn.Size = new Size(75, 23);
            loadBtn.TabIndex = 11;
            loadBtn.Text = "Load Data";
            loadBtn.UseVisualStyleBackColor = true;
            loadBtn.Click += loadBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 406);
            Controls.Add(loadBtn);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(deleteBtn);
            Controls.Add(editBtn);
            Controls.Add(insertBtn);
            Controls.Add(viewDGV);
            Controls.Add(depCb);
            Controls.Add(namaTb);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)viewDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox namaTb;
        private ComboBox depCb;
        private DataGridView viewDGV;
        private Button insertBtn;
        private Button editBtn;
        private Button deleteBtn;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button loadBtn;
    }
}
