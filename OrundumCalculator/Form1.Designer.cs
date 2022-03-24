namespace OrundumCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crntOr = new System.Windows.Forms.NumericUpDown();
            this.crntOP = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.anniCheck = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.weeklyLimit = new System.Windows.Forms.NumericUpDown();
            this.weeklyCheck = new System.Windows.Forms.CheckBox();
            this.cardCheck = new System.Windows.Forms.CheckBox();
            this.dailyCheck = new System.Windows.Forms.CheckBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.CalcBtn = new System.Windows.Forms.Button();
            this.TotalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.crntOr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crntOP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weeklyLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // crntOr
            // 
            this.crntOr.Location = new System.Drawing.Point(180, 12);
            this.crntOr.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.crntOr.Name = "crntOr";
            this.crntOr.Size = new System.Drawing.Size(180, 31);
            this.crntOr.TabIndex = 0;
            // 
            // crntOP
            // 
            this.crntOP.Location = new System.Drawing.Point(180, 49);
            this.crntOP.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.crntOP.Name = "crntOP";
            this.crntOP.Size = new System.Drawing.Size(180, 31);
            this.crntOP.TabIndex = 1;
            this.crntOP.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current Orundum:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(7, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Current OP:";
            // 
            // anniCheck
            // 
            this.anniCheck.AutoSize = true;
            this.anniCheck.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.anniCheck.Location = new System.Drawing.Point(7, 145);
            this.anniCheck.Name = "anniCheck";
            this.anniCheck.Size = new System.Drawing.Size(163, 31);
            this.anniCheck.TabIndex = 4;
            this.anniCheck.Text = "Annihilation";
            this.anniCheck.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(7, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Weekly Limit:";
            // 
            // weeklyLimit
            // 
            this.weeklyLimit.Location = new System.Drawing.Point(180, 84);
            this.weeklyLimit.Maximum = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            this.weeklyLimit.Name = "weeklyLimit";
            this.weeklyLimit.Size = new System.Drawing.Size(180, 31);
            this.weeklyLimit.TabIndex = 6;
            // 
            // weeklyCheck
            // 
            this.weeklyCheck.AutoSize = true;
            this.weeklyCheck.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.weeklyCheck.Location = new System.Drawing.Point(7, 256);
            this.weeklyCheck.Name = "weeklyCheck";
            this.weeklyCheck.Size = new System.Drawing.Size(246, 31);
            this.weeklyCheck.TabIndex = 7;
            this.weeklyCheck.Text = "Weekly Challenges";
            this.weeklyCheck.UseVisualStyleBackColor = true;
            // 
            // cardCheck
            // 
            this.cardCheck.AutoSize = true;
            this.cardCheck.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cardCheck.Location = new System.Drawing.Point(7, 182);
            this.cardCheck.Name = "cardCheck";
            this.cardCheck.Size = new System.Drawing.Size(182, 31);
            this.cardCheck.TabIndex = 8;
            this.cardCheck.Text = "Monthly Card";
            this.cardCheck.UseVisualStyleBackColor = true;
            // 
            // dailyCheck
            // 
            this.dailyCheck.AutoSize = true;
            this.dailyCheck.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dailyCheck.Location = new System.Drawing.Point(7, 219);
            this.dailyCheck.Name = "dailyCheck";
            this.dailyCheck.Size = new System.Drawing.Size(220, 31);
            this.dailyCheck.TabIndex = 9;
            this.dailyCheck.Text = "Daily Challenges";
            this.dailyCheck.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Maria Nearl Rerun",
            "Near Light"});
            this.checkedListBox1.Location = new System.Drawing.Point(7, 313);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(403, 200);
            this.checkedListBox1.TabIndex = 10;
            // 
            // CalcBtn
            // 
            this.CalcBtn.Location = new System.Drawing.Point(712, 479);
            this.CalcBtn.Name = "CalcBtn";
            this.CalcBtn.Size = new System.Drawing.Size(112, 34);
            this.CalcBtn.TabIndex = 11;
            this.CalcBtn.Text = "Calculate";
            this.CalcBtn.UseVisualStyleBackColor = true;
            this.CalcBtn.Click += new System.EventHandler(this.CalcBtn_Click);
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(514, 479);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(59, 25);
            this.TotalLabel.TabIndex = 12;
            this.TotalLabel.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 525);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.CalcBtn);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.dailyCheck);
            this.Controls.Add(this.cardCheck);
            this.Controls.Add(this.weeklyCheck);
            this.Controls.Add(this.weeklyLimit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.anniCheck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crntOP);
            this.Controls.Add(this.crntOr);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.crntOr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crntOP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weeklyLimit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown crntOr;
        private NumericUpDown crntOP;
        private Label label1;
        private Label label2;
        private CheckBox anniCheck;
        private Label label3;
        private NumericUpDown weeklyLimit;
        private CheckBox weeklyCheck;
        private CheckBox cardCheck;
        private CheckBox dailyCheck;
        private CheckedListBox checkedListBox1;
        private Button CalcBtn;
        private Label TotalLabel;
    }
}