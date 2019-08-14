namespace Manager_Customer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.inBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.inClear = new System.Windows.Forms.Button();
            this.inRemove = new System.Windows.Forms.Button();
            this.inAdd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Plum;
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox1.Location = new System.Drawing.Point(21, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(256, 354);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "รหัสสินค้า";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(21, 39);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(201, 254);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Thistle;
            this.groupBox2.Controls.Add(this.inBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox2.Location = new System.Drawing.Point(299, 30);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(213, 79);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ค้นหา หรือ เพิ่ม";
            // 
            // inBox
            // 
            this.inBox.Location = new System.Drawing.Point(11, 30);
            this.inBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inBox.Name = "inBox";
            this.inBox.Size = new System.Drawing.Size(191, 30);
            this.inBox.TabIndex = 0;
            this.inBox.TextChanged += new System.EventHandler(this.inBox_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.HotPink;
            this.groupBox3.Controls.Add(this.inClear);
            this.groupBox3.Controls.Add(this.inRemove);
            this.groupBox3.Controls.Add(this.inAdd);
            this.groupBox3.Location = new System.Drawing.Point(299, 128);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(213, 197);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "คอนโซน";
            // 
            // inClear
            // 
            this.inClear.BackColor = System.Drawing.Color.LightSalmon;
            this.inClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.inClear.Location = new System.Drawing.Point(11, 128);
            this.inClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inClear.Name = "inClear";
            this.inClear.Size = new System.Drawing.Size(192, 39);
            this.inClear.TabIndex = 2;
            this.inClear.Text = "Clear";
            this.inClear.UseVisualStyleBackColor = false;
            this.inClear.Click += new System.EventHandler(this.inClear_Click);
            // 
            // inRemove
            // 
            this.inRemove.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.inRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.inRemove.Location = new System.Drawing.Point(11, 79);
            this.inRemove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inRemove.Name = "inRemove";
            this.inRemove.Size = new System.Drawing.Size(192, 39);
            this.inRemove.TabIndex = 1;
            this.inRemove.Text = "Remove";
            this.inRemove.UseVisualStyleBackColor = false;
            this.inRemove.Click += new System.EventHandler(this.inRemove_Click);
            // 
            // inAdd
            // 
            this.inAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.inAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.inAdd.Location = new System.Drawing.Point(11, 30);
            this.inAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inAdd.Name = "inAdd";
            this.inAdd.Size = new System.Drawing.Size(192, 39);
            this.inAdd.TabIndex = 0;
            this.inAdd.Text = "Add";
            this.inAdd.UseVisualStyleBackColor = false;
            this.inAdd.Click += new System.EventHandler(this.inAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 406);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox inBox;
        private System.Windows.Forms.Button inClear;
        private System.Windows.Forms.Button inRemove;
        private System.Windows.Forms.Button inAdd;

    }
}

