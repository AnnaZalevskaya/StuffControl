namespace TestTask
{
    partial class StuffForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNotific = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonReport = new System.Windows.Forms.Button();
            this.buttonSortAsc = new System.Windows.Forms.Button();
            this.buttonSortDesc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNotific
            // 
            this.labelNotific.AutoEllipsis = true;
            this.labelNotific.AutoSize = true;
            this.labelNotific.BackColor = System.Drawing.Color.Transparent;
            this.labelNotific.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNotific.ForeColor = System.Drawing.Color.Yellow;
            this.labelNotific.Location = new System.Drawing.Point(21, 85);
            this.labelNotific.Name = "labelNotific";
            this.labelNotific.Size = new System.Drawing.Size(0, 27);
            this.labelNotific.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 144);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(981, 466);
            this.dataGridView1.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonAdd.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(1002, 167);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(130, 55);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add employee";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(1001, 233);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(130, 50);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Delete employee";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonReport
            // 
            this.buttonReport.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReport.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReport.Location = new System.Drawing.Point(1002, 294);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(130, 50);
            this.buttonReport.TabIndex = 4;
            this.buttonReport.Text = "Report";
            this.buttonReport.UseVisualStyleBackColor = false;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // buttonSortAsc
            // 
            this.buttonSortAsc.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonSortAsc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSortAsc.Font = new System.Drawing.Font("Book Antiqua", 7.8F, System.Drawing.FontStyle.Bold);
            this.buttonSortAsc.Location = new System.Drawing.Point(865, 76);
            this.buttonSortAsc.Name = "buttonSortAsc";
            this.buttonSortAsc.Size = new System.Drawing.Size(50, 50);
            this.buttonSortAsc.TabIndex = 5;
            this.buttonSortAsc.Text = "Sort asc";
            this.buttonSortAsc.UseVisualStyleBackColor = false;
            this.buttonSortAsc.Click += new System.EventHandler(this.buttonSortAsc_Click);
            // 
            // buttonSortDesc
            // 
            this.buttonSortDesc.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonSortDesc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSortDesc.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSortDesc.Location = new System.Drawing.Point(931, 76);
            this.buttonSortDesc.Name = "buttonSortDesc";
            this.buttonSortDesc.Size = new System.Drawing.Size(50, 50);
            this.buttonSortDesc.TabIndex = 6;
            this.buttonSortDesc.Text = "Sort desc";
            this.buttonSortDesc.UseVisualStyleBackColor = false;
            this.buttonSortDesc.Click += new System.EventHandler(this.buttonSortDesc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(841, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sorting by position:";
            // 
            // StuffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TestTask.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1141, 624);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSortDesc);
            this.Controls.Add(this.buttonSortAsc);
            this.Controls.Add(this.buttonReport);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelNotific);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "StuffForm";
            this.Text = "StuffForm";
            this.Load += new System.EventHandler(this.StuffForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNotific;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.Button buttonSortAsc;
        private System.Windows.Forms.Button buttonSortDesc;
        private System.Windows.Forms.Label label1;
    }
}

