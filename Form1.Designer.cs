namespace RandomNumberGenerator
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtMultiplier = new System.Windows.Forms.TextBox();
            this.txtSeed = new System.Windows.Forms.TextBox();
            this.txtIncrement = new System.Windows.Forms.TextBox();
            this.txtModulus = new System.Windows.Forms.TextBox();
            this.txtIterations = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.RandomNumbers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RandomNumbers});
            this.dataGridView1.Location = new System.Drawing.Point(424, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(167, 518);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtMultiplier
            // 
            this.txtMultiplier.Location = new System.Drawing.Point(288, 89);
            this.txtMultiplier.Name = "txtMultiplier";
            this.txtMultiplier.Size = new System.Drawing.Size(100, 22);
            this.txtMultiplier.TabIndex = 1;
            this.txtMultiplier.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtSeed
            // 
            this.txtSeed.Location = new System.Drawing.Point(288, 152);
            this.txtSeed.Name = "txtSeed";
            this.txtSeed.Size = new System.Drawing.Size(100, 22);
            this.txtSeed.TabIndex = 2;
            // 
            // txtIncrement
            // 
            this.txtIncrement.Location = new System.Drawing.Point(288, 213);
            this.txtIncrement.Name = "txtIncrement";
            this.txtIncrement.Size = new System.Drawing.Size(100, 22);
            this.txtIncrement.TabIndex = 3;
            // 
            // txtModulus
            // 
            this.txtModulus.Location = new System.Drawing.Point(288, 270);
            this.txtModulus.Name = "txtModulus";
            this.txtModulus.Size = new System.Drawing.Size(100, 22);
            this.txtModulus.TabIndex = 4;
            // 
            // txtIterations
            // 
            this.txtIterations.Location = new System.Drawing.Point(288, 326);
            this.txtIterations.Name = "txtIterations";
            this.txtIterations.Size = new System.Drawing.Size(100, 22);
            this.txtIterations.TabIndex = 5;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(288, 512);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Multiplier";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Seed (X0)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Increment";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Modulus";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(73, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Number of Iterations";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(73, 518);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Actual Period Length";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(277, 69);
            this.button1.TabIndex = 13;
            this.button1.Text = "Generate Random Numbers";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RandomNumbers
            // 
            this.RandomNumbers.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.RandomNumbers.HeaderText = "Random Numbers";
            this.RandomNumbers.MinimumWidth = 6;
            this.RandomNumbers.Name = "RandomNumbers";
            this.RandomNumbers.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.RandomNumbers.Width = 111;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 615);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.txtIterations);
            this.Controls.Add(this.txtModulus);
            this.Controls.Add(this.txtIncrement);
            this.Controls.Add(this.txtSeed);
            this.Controls.Add(this.txtMultiplier);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtMultiplier;
        private System.Windows.Forms.TextBox txtSeed;
        private System.Windows.Forms.TextBox txtIncrement;
        private System.Windows.Forms.TextBox txtModulus;
        private System.Windows.Forms.TextBox txtIterations;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RandomNumbers;
    }
}

