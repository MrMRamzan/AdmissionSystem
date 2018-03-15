namespace DBM_form
{
    partial class frmPreference
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
            this.dataGridViewPreference = new System.Windows.Forms.DataGridView();
            this.btnpreference = new System.Windows.Forms.Button();
            this.comboBoxcategory = new System.Windows.Forms.ComboBox();
            this.label35 = new System.Windows.Forms.Label();
            this.comboBoxdepartment = new System.Windows.Forms.ComboBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPreference)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPreference
            // 
            this.dataGridViewPreference.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPreference.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPreference.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewPreference.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewPreference.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPreference.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridViewPreference.Location = new System.Drawing.Point(49, 119);
            this.dataGridViewPreference.Name = "dataGridViewPreference";
            this.dataGridViewPreference.Size = new System.Drawing.Size(713, 260);
            this.dataGridViewPreference.TabIndex = 79;
            // 
            // btnpreference
            // 
            this.btnpreference.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnpreference.Location = new System.Drawing.Point(645, 77);
            this.btnpreference.Name = "btnpreference";
            this.btnpreference.Size = new System.Drawing.Size(75, 23);
            this.btnpreference.TabIndex = 78;
            this.btnpreference.Text = "Add";
            this.btnpreference.UseVisualStyleBackColor = true;
            this.btnpreference.Click += new System.EventHandler(this.btnpreference_Click);
            // 
            // comboBoxcategory
            // 
            this.comboBoxcategory.FormattingEnabled = true;
            this.comboBoxcategory.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.comboBoxcategory.Location = new System.Drawing.Point(175, 79);
            this.comboBoxcategory.Name = "comboBoxcategory";
            this.comboBoxcategory.Size = new System.Drawing.Size(82, 21);
            this.comboBoxcategory.TabIndex = 77;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.Black;
            this.label35.Location = new System.Drawing.Point(85, 87);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(49, 13);
            this.label35.TabIndex = 76;
            this.label35.Text = "Category";
            // 
            // comboBoxdepartment
            // 
            this.comboBoxdepartment.FormattingEnabled = true;
            this.comboBoxdepartment.Items.AddRange(new object[] {
            "Computer Science",
            "Civil Engineering",
            "Electrical Engineering"});
            this.comboBoxdepartment.Location = new System.Drawing.Point(406, 79);
            this.comboBoxdepartment.Name = "comboBoxdepartment";
            this.comboBoxdepartment.Size = new System.Drawing.Size(147, 21);
            this.comboBoxdepartment.TabIndex = 75;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.Black;
            this.label33.Location = new System.Drawing.Point(308, 87);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(62, 13);
            this.label33.TabIndex = 74;
            this.label33.Text = "Department";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.Color.Black;
            this.label34.Location = new System.Drawing.Point(307, 29);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(162, 24);
            this.label34.TabIndex = 73;
            this.label34.Text = "PREFERENCES\r\n";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(677, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 80;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnExit);
            // 
            // frmPreference
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 454);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewPreference);
            this.Controls.Add(this.btnpreference);
            this.Controls.Add(this.comboBoxcategory);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.comboBoxdepartment);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label34);
            this.Name = "frmPreference";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPreference";
            this.Load += new System.EventHandler(this.frmPreference_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPreference)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPreference;
        private System.Windows.Forms.Button btnpreference;
        private System.Windows.Forms.ComboBox comboBoxcategory;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.ComboBox comboBoxdepartment;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Button button1;
    }
}