namespace calculator6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txt_result = new System.Windows.Forms.TextBox();
            this.btn_sqrt = new System.Windows.Forms.Button();
            this.btn_fact = new System.Windows.Forms.Button();
            this.btn_percent = new System.Windows.Forms.Button();
            this.btn_exp = new System.Windows.Forms.Button();
            this.btn_divide = new System.Windows.Forms.Button();
            this.btn_multi = new System.Windows.Forms.Button();
            this.btn_subs = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_equals = new System.Windows.Forms.Button();
            this.btn_n0 = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_n9 = new System.Windows.Forms.Button();
            this.btn_n8 = new System.Windows.Forms.Button();
            this.btn_n7 = new System.Windows.Forms.Button();
            this.btn_n6 = new System.Windows.Forms.Button();
            this.btn_n5 = new System.Windows.Forms.Button();
            this.btn_n4 = new System.Windows.Forms.Button();
            this.btn_n3 = new System.Windows.Forms.Button();
            this.btn_n2 = new System.Windows.Forms.Button();
            this.btn_n1 = new System.Windows.Forms.Button();
            this.btn_ce = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn_store = new System.Windows.Forms.Button();
            this.btn_empty = new System.Windows.Forms.Button();
            this.btn_call = new System.Windows.Forms.Button();
            this.btn_undo = new System.Windows.Forms.Button();
            this.btn_strClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_result
            // 
            this.txt_result.BackColor = System.Drawing.Color.Khaki;
            this.txt_result.Location = new System.Drawing.Point(10, 84);
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(337, 27);
            this.txt_result.TabIndex = 42;
            this.txt_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_sqrt
            // 
            this.btn_sqrt.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_sqrt.ForeColor = System.Drawing.Color.White;
            this.btn_sqrt.Location = new System.Drawing.Point(268, 117);
            this.btn_sqrt.Name = "btn_sqrt";
            this.btn_sqrt.Size = new System.Drawing.Size(80, 38);
            this.btn_sqrt.TabIndex = 41;
            this.btn_sqrt.Text = "√";
            this.btn_sqrt.UseVisualStyleBackColor = false;
            this.btn_sqrt.Click += new System.EventHandler(this.optEvent);
            this.btn_sqrt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_sqrt_MouseClick);
            // 
            // btn_fact
            // 
            this.btn_fact.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_fact.ForeColor = System.Drawing.Color.White;
            this.btn_fact.Location = new System.Drawing.Point(182, 117);
            this.btn_fact.Name = "btn_fact";
            this.btn_fact.Size = new System.Drawing.Size(80, 38);
            this.btn_fact.TabIndex = 40;
            this.btn_fact.Text = "!";
            this.btn_fact.UseVisualStyleBackColor = false;
            this.btn_fact.Click += new System.EventHandler(this.optEvent);
            this.btn_fact.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_fact_MouseClick);
            // 
            // btn_percent
            // 
            this.btn_percent.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_percent.ForeColor = System.Drawing.Color.White;
            this.btn_percent.Location = new System.Drawing.Point(96, 117);
            this.btn_percent.Name = "btn_percent";
            this.btn_percent.Size = new System.Drawing.Size(80, 38);
            this.btn_percent.TabIndex = 39;
            this.btn_percent.Text = "%";
            this.btn_percent.UseVisualStyleBackColor = false;
            this.btn_percent.Click += new System.EventHandler(this.optEvent);
            this.btn_percent.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_percent_MouseClick);
            // 
            // btn_exp
            // 
            this.btn_exp.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_exp.ForeColor = System.Drawing.Color.White;
            this.btn_exp.Location = new System.Drawing.Point(10, 117);
            this.btn_exp.Name = "btn_exp";
            this.btn_exp.Size = new System.Drawing.Size(80, 38);
            this.btn_exp.TabIndex = 38;
            this.btn_exp.Text = "^";
            this.btn_exp.UseVisualStyleBackColor = false;
            this.btn_exp.Click += new System.EventHandler(this.optEvent);
            this.btn_exp.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_exp_MouseClick);
            // 
            // btn_divide
            // 
            this.btn_divide.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_divide.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_divide.ForeColor = System.Drawing.Color.White;
            this.btn_divide.Location = new System.Drawing.Point(270, 467);
            this.btn_divide.Name = "btn_divide";
            this.btn_divide.Size = new System.Drawing.Size(80, 80);
            this.btn_divide.TabIndex = 37;
            this.btn_divide.Text = "÷";
            this.btn_divide.UseVisualStyleBackColor = false;
            this.btn_divide.Click += new System.EventHandler(this.optEvent);
            this.btn_divide.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_divide_MouseClick);
            // 
            // btn_multi
            // 
            this.btn_multi.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_multi.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_multi.ForeColor = System.Drawing.Color.White;
            this.btn_multi.Location = new System.Drawing.Point(270, 381);
            this.btn_multi.Name = "btn_multi";
            this.btn_multi.Size = new System.Drawing.Size(80, 80);
            this.btn_multi.TabIndex = 36;
            this.btn_multi.Text = "X";
            this.btn_multi.UseVisualStyleBackColor = false;
            this.btn_multi.Click += new System.EventHandler(this.optEvent);
            this.btn_multi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_multi_MouseClick);
            // 
            // btn_subs
            // 
            this.btn_subs.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_subs.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_subs.ForeColor = System.Drawing.Color.White;
            this.btn_subs.Location = new System.Drawing.Point(270, 295);
            this.btn_subs.Name = "btn_subs";
            this.btn_subs.Size = new System.Drawing.Size(80, 80);
            this.btn_subs.TabIndex = 35;
            this.btn_subs.Text = "-";
            this.btn_subs.UseVisualStyleBackColor = false;
            this.btn_subs.Click += new System.EventHandler(this.optEvent);
            this.btn_subs.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_subs_MouseClick);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(270, 209);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(80, 80);
            this.btn_add.TabIndex = 34;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.optEvent);
            this.btn_add.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_add_MouseClick);
            // 
            // btn_equals
            // 
            this.btn_equals.BackColor = System.Drawing.Color.Khaki;
            this.btn_equals.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_equals.ForeColor = System.Drawing.Color.Black;
            this.btn_equals.Location = new System.Drawing.Point(184, 467);
            this.btn_equals.Name = "btn_equals";
            this.btn_equals.Size = new System.Drawing.Size(80, 80);
            this.btn_equals.TabIndex = 33;
            this.btn_equals.Text = "=";
            this.btn_equals.UseVisualStyleBackColor = false;
            this.btn_equals.Click += new System.EventHandler(this.btn_equals_Click);
            this.btn_equals.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_equals_MouseClick);
            // 
            // btn_n0
            // 
            this.btn_n0.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_n0.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_n0.ForeColor = System.Drawing.Color.White;
            this.btn_n0.Location = new System.Drawing.Point(98, 467);
            this.btn_n0.Name = "btn_n0";
            this.btn_n0.Size = new System.Drawing.Size(80, 80);
            this.btn_n0.TabIndex = 32;
            this.btn_n0.Text = "0";
            this.btn_n0.UseVisualStyleBackColor = false;
            this.btn_n0.Click += new System.EventHandler(this.numberEvent);
            this.btn_n0.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_n0_MouseClick);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.LightCoral;
            this.btn_clear.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(12, 467);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(80, 80);
            this.btn_clear.TabIndex = 31;
            this.btn_clear.Text = "C";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            this.btn_clear.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_clear_MouseClick);
            // 
            // btn_n9
            // 
            this.btn_n9.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_n9.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_n9.ForeColor = System.Drawing.Color.White;
            this.btn_n9.Location = new System.Drawing.Point(184, 381);
            this.btn_n9.Name = "btn_n9";
            this.btn_n9.Size = new System.Drawing.Size(80, 80);
            this.btn_n9.TabIndex = 30;
            this.btn_n9.Text = "9";
            this.btn_n9.UseVisualStyleBackColor = false;
            this.btn_n9.Click += new System.EventHandler(this.numberEvent);
            this.btn_n9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_n9_MouseClick);
            // 
            // btn_n8
            // 
            this.btn_n8.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_n8.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_n8.ForeColor = System.Drawing.Color.White;
            this.btn_n8.Location = new System.Drawing.Point(98, 381);
            this.btn_n8.Name = "btn_n8";
            this.btn_n8.Size = new System.Drawing.Size(80, 80);
            this.btn_n8.TabIndex = 29;
            this.btn_n8.Text = "8";
            this.btn_n8.UseVisualStyleBackColor = false;
            this.btn_n8.Click += new System.EventHandler(this.numberEvent);
            this.btn_n8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_n8_MouseClick);
            // 
            // btn_n7
            // 
            this.btn_n7.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_n7.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_n7.ForeColor = System.Drawing.Color.White;
            this.btn_n7.Location = new System.Drawing.Point(12, 381);
            this.btn_n7.Name = "btn_n7";
            this.btn_n7.Size = new System.Drawing.Size(80, 80);
            this.btn_n7.TabIndex = 28;
            this.btn_n7.Text = "7";
            this.btn_n7.UseVisualStyleBackColor = false;
            this.btn_n7.Click += new System.EventHandler(this.numberEvent);
            this.btn_n7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_n7_MouseClick);
            // 
            // btn_n6
            // 
            this.btn_n6.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_n6.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_n6.ForeColor = System.Drawing.Color.White;
            this.btn_n6.Location = new System.Drawing.Point(184, 295);
            this.btn_n6.Name = "btn_n6";
            this.btn_n6.Size = new System.Drawing.Size(80, 80);
            this.btn_n6.TabIndex = 27;
            this.btn_n6.Text = "6";
            this.btn_n6.UseVisualStyleBackColor = false;
            this.btn_n6.Click += new System.EventHandler(this.numberEvent);
            this.btn_n6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_n6_MouseClick);
            // 
            // btn_n5
            // 
            this.btn_n5.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_n5.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_n5.ForeColor = System.Drawing.Color.White;
            this.btn_n5.Location = new System.Drawing.Point(98, 295);
            this.btn_n5.Name = "btn_n5";
            this.btn_n5.Size = new System.Drawing.Size(80, 80);
            this.btn_n5.TabIndex = 26;
            this.btn_n5.Text = "5";
            this.btn_n5.UseVisualStyleBackColor = false;
            this.btn_n5.Click += new System.EventHandler(this.numberEvent);
            this.btn_n5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_n5_MouseClick);
            // 
            // btn_n4
            // 
            this.btn_n4.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_n4.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_n4.ForeColor = System.Drawing.Color.White;
            this.btn_n4.Location = new System.Drawing.Point(12, 295);
            this.btn_n4.Name = "btn_n4";
            this.btn_n4.Size = new System.Drawing.Size(80, 80);
            this.btn_n4.TabIndex = 25;
            this.btn_n4.Text = "4";
            this.btn_n4.UseVisualStyleBackColor = false;
            this.btn_n4.Click += new System.EventHandler(this.numberEvent);
            this.btn_n4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_n4_MouseClick);
            // 
            // btn_n3
            // 
            this.btn_n3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_n3.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_n3.ForeColor = System.Drawing.Color.White;
            this.btn_n3.Location = new System.Drawing.Point(184, 209);
            this.btn_n3.Name = "btn_n3";
            this.btn_n3.Size = new System.Drawing.Size(80, 80);
            this.btn_n3.TabIndex = 24;
            this.btn_n3.Text = "3";
            this.btn_n3.UseVisualStyleBackColor = false;
            this.btn_n3.Click += new System.EventHandler(this.numberEvent);
            this.btn_n3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_n3_MouseClick);
            // 
            // btn_n2
            // 
            this.btn_n2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_n2.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_n2.ForeColor = System.Drawing.Color.White;
            this.btn_n2.Location = new System.Drawing.Point(98, 209);
            this.btn_n2.Name = "btn_n2";
            this.btn_n2.Size = new System.Drawing.Size(80, 80);
            this.btn_n2.TabIndex = 23;
            this.btn_n2.Text = "2";
            this.btn_n2.UseVisualStyleBackColor = false;
            this.btn_n2.Click += new System.EventHandler(this.numberEvent);
            this.btn_n2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_n2_MouseClick);
            // 
            // btn_n1
            // 
            this.btn_n1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_n1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_n1.ForeColor = System.Drawing.Color.White;
            this.btn_n1.Location = new System.Drawing.Point(12, 209);
            this.btn_n1.Name = "btn_n1";
            this.btn_n1.Size = new System.Drawing.Size(80, 80);
            this.btn_n1.TabIndex = 22;
            this.btn_n1.Text = "1";
            this.btn_n1.UseVisualStyleBackColor = false;
            this.btn_n1.Click += new System.EventHandler(this.numberEvent);
            this.btn_n1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_n1_MouseClick);
            // 
            // btn_ce
            // 
            this.btn_ce.BackColor = System.Drawing.Color.LightCoral;
            this.btn_ce.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ce.ForeColor = System.Drawing.Color.White;
            this.btn_ce.Location = new System.Drawing.Point(12, 553);
            this.btn_ce.Name = "btn_ce";
            this.btn_ce.Size = new System.Drawing.Size(338, 80);
            this.btn_ce.TabIndex = 43;
            this.btn_ce.Text = "CE";
            this.btn_ce.UseVisualStyleBackColor = false;
            this.btn_ce.Click += new System.EventHandler(this.btn_ce_Click);
            this.btn_ce.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_ce_MouseClick);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(335, 75);
            this.richTextBox1.TabIndex = 44;
            this.richTextBox1.Text = "";
            // 
            // btn_store
            // 
            this.btn_store.BackColor = System.Drawing.Color.LightCoral;
            this.btn_store.ForeColor = System.Drawing.Color.White;
            this.btn_store.Location = new System.Drawing.Point(10, 161);
            this.btn_store.Name = "btn_store";
            this.btn_store.Size = new System.Drawing.Size(80, 38);
            this.btn_store.TabIndex = 45;
            this.btn_store.Text = "M+";
            this.btn_store.UseVisualStyleBackColor = false;
            this.btn_store.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_empty
            // 
            this.btn_empty.BackColor = System.Drawing.Color.LightCoral;
            this.btn_empty.ForeColor = System.Drawing.Color.White;
            this.btn_empty.Location = new System.Drawing.Point(94, 161);
            this.btn_empty.Name = "btn_empty";
            this.btn_empty.Size = new System.Drawing.Size(80, 38);
            this.btn_empty.TabIndex = 46;
            this.btn_empty.Text = "M-";
            this.btn_empty.UseVisualStyleBackColor = false;
            this.btn_empty.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_call
            // 
            this.btn_call.BackColor = System.Drawing.Color.LightCoral;
            this.btn_call.ForeColor = System.Drawing.Color.White;
            this.btn_call.Location = new System.Drawing.Point(180, 161);
            this.btn_call.Name = "btn_call";
            this.btn_call.Size = new System.Drawing.Size(80, 38);
            this.btn_call.TabIndex = 47;
            this.btn_call.Text = "MR";
            this.btn_call.UseVisualStyleBackColor = false;
            this.btn_call.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_undo
            // 
            this.btn_undo.BackColor = System.Drawing.Color.LightCoral;
            this.btn_undo.ForeColor = System.Drawing.Color.White;
            this.btn_undo.Location = new System.Drawing.Point(267, 40);
            this.btn_undo.Name = "btn_undo";
            this.btn_undo.Size = new System.Drawing.Size(80, 38);
            this.btn_undo.TabIndex = 48;
            this.btn_undo.Text = "<-";
            this.btn_undo.UseVisualStyleBackColor = false;
            this.btn_undo.Click += new System.EventHandler(this.btn_undo_Click);
            // 
            // btn_strClear
            // 
            this.btn_strClear.BackColor = System.Drawing.Color.LightCoral;
            this.btn_strClear.ForeColor = System.Drawing.Color.White;
            this.btn_strClear.Location = new System.Drawing.Point(270, 161);
            this.btn_strClear.Name = "btn_strClear";
            this.btn_strClear.Size = new System.Drawing.Size(80, 38);
            this.btn_strClear.TabIndex = 49;
            this.btn_strClear.Text = "MC";
            this.btn_strClear.UseVisualStyleBackColor = false;
            this.btn_strClear.Click += new System.EventHandler(this.btn_strClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btn_clear;
            this.ClientSize = new System.Drawing.Size(359, 641);
            this.Controls.Add(this.btn_strClear);
            this.Controls.Add(this.btn_undo);
            this.Controls.Add(this.btn_call);
            this.Controls.Add(this.btn_empty);
            this.Controls.Add(this.btn_store);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btn_ce);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.btn_sqrt);
            this.Controls.Add(this.btn_fact);
            this.Controls.Add(this.btn_percent);
            this.Controls.Add(this.btn_exp);
            this.Controls.Add(this.btn_divide);
            this.Controls.Add(this.btn_multi);
            this.Controls.Add(this.btn_subs);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_equals);
            this.Controls.Add(this.btn_n0);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_n9);
            this.Controls.Add(this.btn_n8);
            this.Controls.Add(this.btn_n7);
            this.Controls.Add(this.btn_n6);
            this.Controls.Add(this.btn_n5);
            this.Controls.Add(this.btn_n4);
            this.Controls.Add(this.btn_n3);
            this.Controls.Add(this.btn_n2);
            this.Controls.Add(this.btn_n1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_result;
        private Button btn_sqrt;
        private Button btn_fact;
        private Button btn_percent;
        private Button btn_exp;
        private Button btn_divide;
        private Button btn_multi;
        private Button btn_subs;
        private Button btn_add;
        private Button btn_equals;
        private Button btn_n0;
        private Button btn_clear;
        private Button btn_n9;
        private Button btn_n8;
        private Button btn_n7;
        private Button btn_n6;
        private Button btn_n5;
        private Button btn_n4;
        private Button btn_n3;
        private Button btn_n2;
        private Button btn_n1;
        private Button btn_ce;
        private RichTextBox richTextBox1;
        private Button btn_store;
        private Button btn_empty;
        private Button btn_call;
        private Button btn_undo;
        private Button btn_strClear;
    }
}