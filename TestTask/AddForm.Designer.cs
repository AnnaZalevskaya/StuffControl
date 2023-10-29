namespace TestTask
{
    partial class AddForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxYearOfBirth = new System.Windows.Forms.TextBox();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.listBoxPositions = new System.Windows.Forms.ListBox();
            this.positionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stuffDataSet = new TestTask.stuffDataSet();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.positionsTableAdapter = new TestTask.stuffDataSetTableAdapters.positionsTableAdapter();
            this.labelNotif = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.positionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuffDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(280, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add empoloyee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(207, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "First name";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(401, 69);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(121, 22);
            this.textBoxFirstName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(207, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last name";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(402, 122);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(120, 22);
            this.textBoxLastName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(207, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Position";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(207, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 26);
            this.label5.TabIndex = 6;
            this.label5.Text = "Year of birth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(207, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 26);
            this.label6.TabIndex = 7;
            this.label6.Text = "Salary";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBoxYearOfBirth
            // 
            this.textBoxYearOfBirth.Location = new System.Drawing.Point(402, 269);
            this.textBoxYearOfBirth.Name = "textBoxYearOfBirth";
            this.textBoxYearOfBirth.Size = new System.Drawing.Size(120, 22);
            this.textBoxYearOfBirth.TabIndex = 8;
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Location = new System.Drawing.Point(401, 324);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(121, 22);
            this.textBoxSalary.TabIndex = 9;
            // 
            // listBoxPositions
            // 
            this.listBoxPositions.DataSource = this.positionsBindingSource;
            this.listBoxPositions.DisplayMember = "pos_name";
            this.listBoxPositions.FormattingEnabled = true;
            this.listBoxPositions.ItemHeight = 16;
            this.listBoxPositions.Location = new System.Drawing.Point(402, 163);
            this.listBoxPositions.Name = "listBoxPositions";
            this.listBoxPositions.Size = new System.Drawing.Size(120, 84);
            this.listBoxPositions.TabIndex = 10;
            // 
            // positionsBindingSource
            // 
            this.positionsBindingSource.DataMember = "positions";
            this.positionsBindingSource.DataSource = this.stuffDataSet;
            // 
            // stuffDataSet
            // 
            this.stuffDataSet.DataSetName = "stuffDataSet";
            this.stuffDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.HighlightText;
            this.buttonAdd.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonAdd.Location = new System.Drawing.Point(318, 400);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(95, 34);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // positionsTableAdapter
            // 
            this.positionsTableAdapter.ClearBeforeFill = true;
            // 
            // labelNotif
            // 
            this.labelNotif.AutoSize = true;
            this.labelNotif.BackColor = System.Drawing.Color.Transparent;
            this.labelNotif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNotif.ForeColor = System.Drawing.Color.Yellow;
            this.labelNotif.Location = new System.Drawing.Point(248, 368);
            this.labelNotif.Name = "labelNotif";
            this.labelNotif.Size = new System.Drawing.Size(0, 20);
            this.labelNotif.TabIndex = 12;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TestTask.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelNotif);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listBoxPositions);
            this.Controls.Add(this.textBoxSalary);
            this.Controls.Add(this.textBoxYearOfBirth);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.AddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.positionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuffDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxYearOfBirth;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.ListBox listBoxPositions;
        private System.Windows.Forms.Button buttonAdd;
        private stuffDataSet stuffDataSet;
        private System.Windows.Forms.BindingSource positionsBindingSource;
        private stuffDataSetTableAdapters.positionsTableAdapter positionsTableAdapter;
        private System.Windows.Forms.Label labelNotif;
    }
}