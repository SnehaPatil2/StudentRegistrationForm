namespace StudentForm
{
    partial class Form2
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
            this.zipBox1 = new System.Windows.Forms.TextBox();
            this.phonBox1 = new System.Windows.Forms.TextBox();
            this.emailBox1 = new System.Windows.Forms.TextBox();
            this.nameBox1 = new System.Windows.Forms.TextBox();
            this.musiccheckBox1 = new System.Windows.Forms.CheckBox();
            this.swimmingcheckBox1 = new System.Windows.Forms.CheckBox();
            this.footballcheckBox1 = new System.Windows.Forms.CheckBox();
            this.moviecheckBox1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NAME = new System.Windows.Forms.Label();
            this.updatebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // zipBox1
            // 
            this.zipBox1.Location = new System.Drawing.Point(358, 213);
            this.zipBox1.Multiline = true;
            this.zipBox1.Name = "zipBox1";
            this.zipBox1.Size = new System.Drawing.Size(233, 36);
            this.zipBox1.TabIndex = 28;
            // 
            // phonBox1
            // 
            this.phonBox1.Location = new System.Drawing.Point(358, 172);
            this.phonBox1.Multiline = true;
            this.phonBox1.Name = "phonBox1";
            this.phonBox1.Size = new System.Drawing.Size(233, 35);
            this.phonBox1.TabIndex = 27;
            this.phonBox1.TextChanged += new System.EventHandler(this.phonBox_TextChanged);
            // 
            // emailBox1
            // 
            this.emailBox1.Location = new System.Drawing.Point(358, 129);
            this.emailBox1.Multiline = true;
            this.emailBox1.Name = "emailBox1";
            this.emailBox1.Size = new System.Drawing.Size(233, 37);
            this.emailBox1.TabIndex = 26;
            // 
            // nameBox1
            // 
            this.nameBox1.Location = new System.Drawing.Point(358, 86);
            this.nameBox1.Multiline = true;
            this.nameBox1.Name = "nameBox1";
            this.nameBox1.Size = new System.Drawing.Size(233, 37);
            this.nameBox1.TabIndex = 25;
            // 
            // musiccheckBox1
            // 
            this.musiccheckBox1.AutoSize = true;
            this.musiccheckBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musiccheckBox1.Location = new System.Drawing.Point(267, 372);
            this.musiccheckBox1.Name = "musiccheckBox1";
            this.musiccheckBox1.Size = new System.Drawing.Size(76, 24);
            this.musiccheckBox1.TabIndex = 24;
            this.musiccheckBox1.Text = "Music";
            this.musiccheckBox1.UseVisualStyleBackColor = true;
            // 
            // swimmingcheckBox1
            // 
            this.swimmingcheckBox1.AutoSize = true;
            this.swimmingcheckBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swimmingcheckBox1.Location = new System.Drawing.Point(267, 346);
            this.swimmingcheckBox1.Name = "swimmingcheckBox1";
            this.swimmingcheckBox1.Size = new System.Drawing.Size(108, 24);
            this.swimmingcheckBox1.TabIndex = 23;
            this.swimmingcheckBox1.Text = "Swimming";
            this.swimmingcheckBox1.UseVisualStyleBackColor = true;
            // 
            // footballcheckBox1
            // 
            this.footballcheckBox1.AutoSize = true;
            this.footballcheckBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.footballcheckBox1.Location = new System.Drawing.Point(267, 320);
            this.footballcheckBox1.Name = "footballcheckBox1";
            this.footballcheckBox1.Size = new System.Drawing.Size(90, 24);
            this.footballcheckBox1.TabIndex = 22;
            this.footballcheckBox1.Text = "Football";
            this.footballcheckBox1.UseVisualStyleBackColor = true;
            // 
            // moviecheckBox1
            // 
            this.moviecheckBox1.AutoSize = true;
            this.moviecheckBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moviecheckBox1.Location = new System.Drawing.Point(267, 294);
            this.moviecheckBox1.Name = "moviecheckBox1";
            this.moviecheckBox1.Size = new System.Drawing.Size(75, 24);
            this.moviecheckBox1.TabIndex = 21;
            this.moviecheckBox1.Text = "Movie";
            this.moviecheckBox1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(264, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "HOBBIES";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(264, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "ZIP CODE*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(264, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "PHONE*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(264, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "EMAIL*";
            // 
            // NAME
            // 
            this.NAME.AccessibleName = "Name";
            this.NAME.AutoSize = true;
            this.NAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NAME.Location = new System.Drawing.Point(264, 89);
            this.NAME.Name = "NAME";
            this.NAME.Size = new System.Drawing.Size(63, 20);
            this.NAME.TabIndex = 16;
            this.NAME.Text = "NAME*";
            // 
            // updatebtn
            // 
            this.updatebtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.updatebtn.Location = new System.Drawing.Point(358, 410);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(125, 43);
            this.updatebtn.TabIndex = 29;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = false;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 511);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.zipBox1);
            this.Controls.Add(this.phonBox1);
            this.Controls.Add(this.emailBox1);
            this.Controls.Add(this.nameBox1);
            this.Controls.Add(this.musiccheckBox1);
            this.Controls.Add(this.swimmingcheckBox1);
            this.Controls.Add(this.footballcheckBox1);
            this.Controls.Add(this.moviecheckBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NAME);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox zipBox1;
        private System.Windows.Forms.TextBox phonBox1;
        private System.Windows.Forms.TextBox emailBox1;
        private System.Windows.Forms.TextBox nameBox1;
        private System.Windows.Forms.CheckBox musiccheckBox1;
        private System.Windows.Forms.CheckBox swimmingcheckBox1;
        private System.Windows.Forms.CheckBox footballcheckBox1;
        private System.Windows.Forms.CheckBox moviecheckBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NAME;
        private System.Windows.Forms.Button updatebtn;
    }
}