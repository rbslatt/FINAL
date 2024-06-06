namespace backupfinals
{
    partial class Inventory
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
            dataGridView1 = new DataGridView();
            txtID = new TextBox();
            txtBrand = new TextBox();
            txtPrice = new TextBox();
            txtFlavor = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnAdd = new Button();
            btnEdit = new Button();
            btnRemove = new Button();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(304, 150);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(460, 250);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // txtID
            // 
            txtID.BackColor = SystemColors.Window;
            txtID.BorderStyle = BorderStyle.None;
            txtID.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtID.Location = new Point(12, 150);
            txtID.Name = "txtID";
            txtID.Size = new Size(248, 18);
            txtID.TabIndex = 1;
            // 
            // txtBrand
            // 
            txtBrand.BackColor = SystemColors.Window;
            txtBrand.BorderStyle = BorderStyle.None;
            txtBrand.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBrand.Location = new Point(12, 213);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(248, 18);
            txtBrand.TabIndex = 2;
            // 
            // txtPrice
            // 
            txtPrice.BackColor = SystemColors.Window;
            txtPrice.BorderStyle = BorderStyle.None;
            txtPrice.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(12, 267);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(248, 18);
            txtPrice.TabIndex = 3;
            // 
            // txtFlavor
            // 
            txtFlavor.BackColor = SystemColors.Window;
            txtFlavor.BorderStyle = BorderStyle.None;
            txtFlavor.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFlavor.Location = new Point(12, 325);
            txtFlavor.Name = "txtFlavor";
            txtFlavor.Size = new Size(248, 18);
            txtFlavor.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 128);
            label1.Name = "label1";
            label1.Size = new Size(28, 19);
            label1.TabIndex = 5;
            label1.Text = "ID";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 191);
            label2.Name = "label2";
            label2.Size = new Size(68, 19);
            label2.TabIndex = 6;
            label2.Text = "BRAND";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 245);
            label3.Name = "label3";
            label3.Size = new Size(60, 19);
            label3.TabIndex = 7;
            label3.Text = "PRICE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 303);
            label4.Name = "label4";
            label4.Size = new Size(74, 19);
            label4.TabIndex = 8;
            label4.Text = "FLAVOR";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 366);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(114, 34);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(12, 404);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(114, 34);
            btnEdit.TabIndex = 10;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(146, 366);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(114, 34);
            btnRemove.TabIndex = 11;
            btnRemove.Text = "REMOVE";
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(146, 406);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(114, 34);
            btnSearch.TabIndex = 12;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSearch);
            Controls.Add(btnRemove);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtFlavor);
            Controls.Add(txtPrice);
            Controls.Add(txtBrand);
            Controls.Add(txtID);
            Controls.Add(dataGridView1);
            Name = "Inventory";
            Text = "Inventory";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtID;
        private TextBox txtBrand;
        private TextBox txtPrice;
        private TextBox txtFlavor;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnRemove;
        private Button btnSearch;
    }
}