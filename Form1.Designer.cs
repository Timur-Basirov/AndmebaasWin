namespace AndmebaasWin
{
    partial class Form1
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
            this.Nimetus_txt = new System.Windows.Forms.TextBox();
            this.Kogus_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Hind_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nimetusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kogusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hindDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toodeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.andmebaasDataSet = new AndmebaasWin.AndmebaasDataSet();
            this.toodeTableAdapter = new AndmebaasWin.AndmebaasDataSetTableAdapters.ToodeTableAdapter();
            this.LisaBtn = new System.Windows.Forms.Button();
            this.KustutaBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PildiOtsingBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toodeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.andmebaasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nimetus";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Nimetus_txt
            // 
            this.Nimetus_txt.Location = new System.Drawing.Point(94, 71);
            this.Nimetus_txt.Name = "Nimetus_txt";
            this.Nimetus_txt.Size = new System.Drawing.Size(100, 20);
            this.Nimetus_txt.TabIndex = 1;
            // 
            // Kogus_txt
            // 
            this.Kogus_txt.Location = new System.Drawing.Point(94, 120);
            this.Kogus_txt.Name = "Kogus_txt";
            this.Kogus_txt.Size = new System.Drawing.Size(100, 20);
            this.Kogus_txt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kogus";
            // 
            // Hind_txt
            // 
            this.Hind_txt.Location = new System.Drawing.Point(94, 168);
            this.Hind_txt.Name = "Hind_txt";
            this.Hind_txt.Size = new System.Drawing.Size(100, 20);
            this.Hind_txt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hind";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nimetusDataGridViewTextBoxColumn,
            this.kogusDataGridViewTextBoxColumn,
            this.hindDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.toodeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(46, 236);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(616, 150);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nimetusDataGridViewTextBoxColumn
            // 
            this.nimetusDataGridViewTextBoxColumn.DataPropertyName = "Nimetus";
            this.nimetusDataGridViewTextBoxColumn.HeaderText = "Nimetus";
            this.nimetusDataGridViewTextBoxColumn.Name = "nimetusDataGridViewTextBoxColumn";
            // 
            // kogusDataGridViewTextBoxColumn
            // 
            this.kogusDataGridViewTextBoxColumn.DataPropertyName = "Kogus";
            this.kogusDataGridViewTextBoxColumn.HeaderText = "Kogus";
            this.kogusDataGridViewTextBoxColumn.Name = "kogusDataGridViewTextBoxColumn";
            // 
            // hindDataGridViewTextBoxColumn
            // 
            this.hindDataGridViewTextBoxColumn.DataPropertyName = "Hind";
            this.hindDataGridViewTextBoxColumn.HeaderText = "Hind";
            this.hindDataGridViewTextBoxColumn.Name = "hindDataGridViewTextBoxColumn";
            // 
            // toodeBindingSource
            // 
            this.toodeBindingSource.DataMember = "Toode";
            this.toodeBindingSource.DataSource = this.andmebaasDataSet;
            // 
            // andmebaasDataSet
            // 
            this.andmebaasDataSet.DataSetName = "AndmebaasDataSet";
            this.andmebaasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toodeTableAdapter
            // 
            this.toodeTableAdapter.ClearBeforeFill = true;
            // 
            // LisaBtn
            // 
            this.LisaBtn.Location = new System.Drawing.Point(46, 194);
            this.LisaBtn.Name = "LisaBtn";
            this.LisaBtn.Size = new System.Drawing.Size(148, 36);
            this.LisaBtn.TabIndex = 7;
            this.LisaBtn.Text = "Lisa andmed";
            this.LisaBtn.UseVisualStyleBackColor = true;
            this.LisaBtn.Click += new System.EventHandler(this.LisaBtn_Click);
            // 
            // KustutaBtn
            // 
            this.KustutaBtn.Location = new System.Drawing.Point(200, 194);
            this.KustutaBtn.Name = "KustutaBtn";
            this.KustutaBtn.Size = new System.Drawing.Size(148, 36);
            this.KustutaBtn.TabIndex = 8;
            this.KustutaBtn.Text = "Kustuta Andmed";
            this.KustutaBtn.UseVisualStyleBackColor = true;
            this.KustutaBtn.Click += new System.EventHandler(this.KustutaBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(354, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 36);
            this.button2.TabIndex = 9;
            this.button2.Text = "Uuenda Andmed";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.UuendaBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(231, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 141);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // PildiOtsingBtn
            // 
            this.PildiOtsingBtn.Location = new System.Drawing.Point(451, 51);
            this.PildiOtsingBtn.Name = "PildiOtsingBtn";
            this.PildiOtsingBtn.Size = new System.Drawing.Size(148, 36);
            this.PildiOtsingBtn.TabIndex = 11;
            this.PildiOtsingBtn.Text = "Pildi otsing";
            this.PildiOtsingBtn.UseVisualStyleBackColor = true;
            this.PildiOtsingBtn.Click += new System.EventHandler(this.PildiOtsingBtn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(451, 111);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 36);
            this.button3.TabIndex = 12;
            this.button3.Text = "CLEAR";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.PildiOtsingBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.KustutaBtn);
            this.Controls.Add(this.LisaBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Hind_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Kogus_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nimetus_txt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toodeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.andmebaasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nimetus_txt;
        private System.Windows.Forms.TextBox Kogus_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Hind_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AndmebaasDataSet andmebaasDataSet;
        private System.Windows.Forms.BindingSource toodeBindingSource;
        private AndmebaasDataSetTableAdapters.ToodeTableAdapter toodeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nimetusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kogusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hindDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button LisaBtn;
        private System.Windows.Forms.Button KustutaBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button PildiOtsingBtn;
        private System.Windows.Forms.Button button3;
    }
}

