namespace Assignment_10._3
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtVIN = new TextBox();
            txtYear = new TextBox();
            txtMake = new TextBox();
            txtModel = new TextBox();
            txtColor = new TextBox();
            txtPrice = new TextBox();
            cmbDealership = new ComboBox();
            label9 = new Label();
            btnAdd = new Button();
            btnSubmit = new Button();
            btnSelect = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(341, 9);
            label1.Name = "label1";
            label1.Size = new Size(200, 21);
            label1.TabIndex = 0;
            label1.Text = "Car Management System";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 38);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(656, 405);
            dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(712, 72);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 2;
            label2.Text = "VIN:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(709, 101);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 3;
            label3.Text = "Year:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(702, 130);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 4;
            label4.Text = "Make:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(697, 159);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 5;
            label5.Text = "Model:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(702, 188);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 6;
            label6.Text = "Color:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(705, 217);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 7;
            label7.Text = "Price:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(676, 247);
            label8.Name = "label8";
            label8.Size = new Size(65, 15);
            label8.TabIndex = 8;
            label8.Text = "Dealership:";
            // 
            // txtVIN
            // 
            txtVIN.BorderStyle = BorderStyle.FixedSingle;
            txtVIN.Location = new Point(747, 70);
            txtVIN.Name = "txtVIN";
            txtVIN.Size = new Size(121, 23);
            txtVIN.TabIndex = 9;
            // 
            // txtYear
            // 
            txtYear.BorderStyle = BorderStyle.FixedSingle;
            txtYear.Location = new Point(747, 99);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(121, 23);
            txtYear.TabIndex = 10;
            // 
            // txtMake
            // 
            txtMake.BorderStyle = BorderStyle.FixedSingle;
            txtMake.Location = new Point(747, 128);
            txtMake.Name = "txtMake";
            txtMake.Size = new Size(121, 23);
            txtMake.TabIndex = 11;
            // 
            // txtModel
            // 
            txtModel.BorderStyle = BorderStyle.FixedSingle;
            txtModel.Location = new Point(747, 157);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(121, 23);
            txtModel.TabIndex = 12;
            // 
            // txtColor
            // 
            txtColor.BorderStyle = BorderStyle.FixedSingle;
            txtColor.Location = new Point(747, 186);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(121, 23);
            txtColor.TabIndex = 13;
            // 
            // txtPrice
            // 
            txtPrice.BorderStyle = BorderStyle.FixedSingle;
            txtPrice.Location = new Point(747, 215);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(121, 23);
            txtPrice.TabIndex = 14;
            // 
            // cmbDealership
            // 
            cmbDealership.FormattingEnabled = true;
            cmbDealership.Location = new Point(747, 244);
            cmbDealership.Name = "cmbDealership";
            cmbDealership.Size = new Size(121, 23);
            cmbDealership.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Underline);
            label9.Location = new Point(730, 38);
            label9.Name = "label9";
            label9.Size = new Size(106, 19);
            label9.TabIndex = 16;
            label9.Text = "Car Information";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(730, 282);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(105, 23);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "Add New";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(730, 311);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(105, 23);
            btnSubmit.TabIndex = 18;
            btnSubmit.Text = "Submit Record";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(730, 340);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(105, 23);
            btnSelect.TabIndex = 19;
            btnSelect.Text = "Select to Update";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(730, 369);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(105, 23);
            btnUpdate.TabIndex = 20;
            btnUpdate.Text = "Update Record";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(730, 398);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(105, 23);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "Delete Record";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 452);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSelect);
            Controls.Add(btnSubmit);
            Controls.Add(btnAdd);
            Controls.Add(label9);
            Controls.Add(cmbDealership);
            Controls.Add(txtPrice);
            Controls.Add(txtColor);
            Controls.Add(txtModel);
            Controls.Add(txtMake);
            Controls.Add(txtYear);
            Controls.Add(txtVIN);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CMS";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtVIN;
        private TextBox txtYear;
        private TextBox txtMake;
        private TextBox txtModel;
        private TextBox txtColor;
        private TextBox txtPrice;
        private ComboBox cmbDealership;
        private Label label9;
        private Button btnAdd;
        private Button btnSubmit;
        private Button btnSelect;
        private Button btnUpdate;
        private Button btnDelete;
    }
}
