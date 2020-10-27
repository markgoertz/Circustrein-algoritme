namespace Circustrein_algoritme
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
            this.Wagonlist = new System.Windows.Forms.ListBox();
            this.Animallist = new System.Windows.Forms.ListBox();
            this.Orginisebtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.smallRbtn = new System.Windows.Forms.RadioButton();
            this.mediumRbtn = new System.Windows.Forms.RadioButton();
            this.bigRbtn = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.carnivoreRbtn = new System.Windows.Forms.RadioButton();
            this.herbivoreRbtn = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddAnimalbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Wagonlist
            // 
            this.Wagonlist.FormattingEnabled = true;
            this.Wagonlist.Location = new System.Drawing.Point(407, 36);
            this.Wagonlist.Margin = new System.Windows.Forms.Padding(2);
            this.Wagonlist.Name = "Wagonlist";
            this.Wagonlist.Size = new System.Drawing.Size(199, 225);
            this.Wagonlist.TabIndex = 31;
            this.Wagonlist.SelectedIndexChanged += new System.EventHandler(this.Wagonlist_SelectedIndexChanged);
            // 
            // Animallist
            // 
            this.Animallist.FormattingEnabled = true;
            this.Animallist.Location = new System.Drawing.Point(204, 34);
            this.Animallist.Margin = new System.Windows.Forms.Padding(2);
            this.Animallist.Name = "Animallist";
            this.Animallist.Size = new System.Drawing.Size(199, 277);
            this.Animallist.TabIndex = 30;
            // 
            // Orginisebtn
            // 
            this.Orginisebtn.BackColor = System.Drawing.Color.Silver;
            this.Orginisebtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Orginisebtn.Location = new System.Drawing.Point(407, 265);
            this.Orginisebtn.Margin = new System.Windows.Forms.Padding(2);
            this.Orginisebtn.Name = "Orginisebtn";
            this.Orginisebtn.Size = new System.Drawing.Size(199, 48);
            this.Orginisebtn.TabIndex = 29;
            this.Orginisebtn.Text = "Get wagons";
            this.Orginisebtn.UseVisualStyleBackColor = false;
            this.Orginisebtn.Click += new System.EventHandler(this.Orginisebtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.smallRbtn);
            this.groupBox2.Controls.Add(this.mediumRbtn);
            this.groupBox2.Controls.Add(this.bigRbtn);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(8, 148);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(192, 101);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Animal Size";
            // 
            // smallRbtn
            // 
            this.smallRbtn.AutoSize = true;
            this.smallRbtn.Location = new System.Drawing.Point(10, 23);
            this.smallRbtn.Margin = new System.Windows.Forms.Padding(2);
            this.smallRbtn.Name = "smallRbtn";
            this.smallRbtn.Size = new System.Drawing.Size(60, 20);
            this.smallRbtn.TabIndex = 9;
            this.smallRbtn.TabStop = true;
            this.smallRbtn.Text = "Small";
            this.smallRbtn.UseVisualStyleBackColor = true;
            // 
            // mediumRbtn
            // 
            this.mediumRbtn.AutoSize = true;
            this.mediumRbtn.Location = new System.Drawing.Point(10, 45);
            this.mediumRbtn.Margin = new System.Windows.Forms.Padding(2);
            this.mediumRbtn.Name = "mediumRbtn";
            this.mediumRbtn.Size = new System.Drawing.Size(74, 20);
            this.mediumRbtn.TabIndex = 10;
            this.mediumRbtn.TabStop = true;
            this.mediumRbtn.Text = "Medium";
            this.mediumRbtn.UseVisualStyleBackColor = true;
            // 
            // bigRbtn
            // 
            this.bigRbtn.AutoSize = true;
            this.bigRbtn.Location = new System.Drawing.Point(10, 67);
            this.bigRbtn.Margin = new System.Windows.Forms.Padding(2);
            this.bigRbtn.Name = "bigRbtn";
            this.bigRbtn.Size = new System.Drawing.Size(46, 20);
            this.bigRbtn.TabIndex = 9;
            this.bigRbtn.TabStop = true;
            this.bigRbtn.Text = "Big";
            this.bigRbtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.carnivoreRbtn);
            this.groupBox1.Controls.Add(this.herbivoreRbtn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 34);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(192, 101);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Animal Type";
            // 
            // carnivoreRbtn
            // 
            this.carnivoreRbtn.AutoSize = true;
            this.carnivoreRbtn.Location = new System.Drawing.Point(10, 37);
            this.carnivoreRbtn.Margin = new System.Windows.Forms.Padding(2);
            this.carnivoreRbtn.Name = "carnivoreRbtn";
            this.carnivoreRbtn.Size = new System.Drawing.Size(84, 20);
            this.carnivoreRbtn.TabIndex = 7;
            this.carnivoreRbtn.TabStop = true;
            this.carnivoreRbtn.Text = "Carnivore";
            this.carnivoreRbtn.UseVisualStyleBackColor = true;
            // 
            // herbivoreRbtn
            // 
            this.herbivoreRbtn.AutoSize = true;
            this.herbivoreRbtn.Location = new System.Drawing.Point(10, 61);
            this.herbivoreRbtn.Margin = new System.Windows.Forms.Padding(2);
            this.herbivoreRbtn.Name = "herbivoreRbtn";
            this.herbivoreRbtn.Size = new System.Drawing.Size(86, 20);
            this.herbivoreRbtn.TabIndex = 8;
            this.herbivoreRbtn.TabStop = true;
            this.herbivoreRbtn.Text = "Herbivore";
            this.herbivoreRbtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(435, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 18);
            this.label2.TabIndex = 26;
            this.label2.Text = "Wagons on train";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "Animal Collection";
            // 
            // AddAnimalbtn
            // 
            this.AddAnimalbtn.BackColor = System.Drawing.Color.Silver;
            this.AddAnimalbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddAnimalbtn.Location = new System.Drawing.Point(8, 260);
            this.AddAnimalbtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddAnimalbtn.Name = "AddAnimalbtn";
            this.AddAnimalbtn.Size = new System.Drawing.Size(192, 48);
            this.AddAnimalbtn.TabIndex = 24;
            this.AddAnimalbtn.Text = "Add Animal";
            this.AddAnimalbtn.UseVisualStyleBackColor = false;
            this.AddAnimalbtn.Click += new System.EventHandler(this.AddAnimalbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 18);
            this.label3.TabIndex = 32;
            this.label3.Text = "Enter the animals below";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(614, 319);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Wagonlist);
            this.Controls.Add(this.Animallist);
            this.Controls.Add(this.Orginisebtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddAnimalbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Wagonlist;
        private System.Windows.Forms.ListBox Animallist;
        private System.Windows.Forms.Button Orginisebtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton smallRbtn;
        private System.Windows.Forms.RadioButton mediumRbtn;
        private System.Windows.Forms.RadioButton bigRbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton carnivoreRbtn;
        private System.Windows.Forms.RadioButton herbivoreRbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddAnimalbtn;
        private System.Windows.Forms.Label label3;
    }
}

