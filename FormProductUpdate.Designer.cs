namespace FormApp
{
    partial class FormProductUpdate
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
            panel2 = new Panel();
            btnUpdate = new Button();
            txtColor = new TextBox();
            label5 = new Label();
            txtWeight = new TextBox();
            label4 = new Label();
            txtPrice = new TextBox();
            label3 = new Label();
            txtCategory = new TextBox();
            label2 = new Label();
            txtName = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            lblProductAdd = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(txtColor);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtWeight);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtPrice);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtCategory);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(38, 180);
            panel2.Name = "panel2";
            panel2.Size = new Size(448, 454);
            panel2.TabIndex = 1;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(160, 113, 255);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.WhiteSmoke;
            btnUpdate.Location = new Point(45, 389);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(121, 42);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(45, 322);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(362, 23);
            txtColor.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(42, 297);
            label5.Name = "label5";
            label5.Size = new Size(77, 17);
            label5.TabIndex = 0;
            label5.Text = "Color (Hex):";
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(45, 255);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(362, 23);
            txtWeight.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(42, 230);
            label4.Name = "label4";
            label4.Size = new Size(51, 17);
            label4.TabIndex = 0;
            label4.Text = "Weight:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(44, 188);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(362, 23);
            txtPrice.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(42, 163);
            label3.Name = "label3";
            label3.Size = new Size(39, 17);
            label3.TabIndex = 0;
            label3.Text = "Price:";
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(44, 123);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(362, 23);
            txtCategory.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(42, 98);
            label2.Name = "label2";
            label2.Size = new Size(64, 17);
            label2.TabIndex = 0;
            label2.Text = "Category:";
            // 
            // txtName
            // 
            txtName.Location = new Point(43, 58);
            txtName.Name = "txtName";
            txtName.Size = new Size(362, 23);
            txtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(40, 33);
            label1.Name = "label1";
            label1.Size = new Size(46, 17);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(160, 113, 255);
            panel1.Controls.Add(lblProductAdd);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(523, 135);
            panel1.TabIndex = 2;
            // 
            // lblProductAdd
            // 
            lblProductAdd.AutoSize = true;
            lblProductAdd.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblProductAdd.ForeColor = SystemColors.ControlLightLight;
            lblProductAdd.Location = new Point(38, 47);
            lblProductAdd.Name = "lblProductAdd";
            lblProductAdd.Size = new Size(180, 32);
            lblProductAdd.TabIndex = 0;
            lblProductAdd.Text = "Product Update";
            // 
            // FormProductUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 648);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormProductUpdate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormProductUpdate";
            Load += FormProductUpdate_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button btnUpdate;
        private TextBox txtColor;
        private Label label5;
        private TextBox txtWeight;
        private Label label4;
        private TextBox txtPrice;
        private Label label3;
        private TextBox txtCategory;
        private Label label2;
        private TextBox txtName;
        private Label label1;
        private Panel panel1;
        private Label lblProductAdd;
    }
}