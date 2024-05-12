namespace CALCULATORproject
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
            store_txtbx = new TextBox();
            panel1 = new Panel();
            clear_btn = new Button();
            delete_btn = new Button();
            remainder_btn = new Button();
            division_btn = new Button();
            panel2 = new Panel();
            result_btn = new Button();
            plus_btn = new Button();
            minus_btn = new Button();
            multip_btn = new Button();
            panel3 = new Panel();
            point_btn = new Button();
            nine_btn = new Button();
            eight_btn = new Button();
            seven_btn = new Button();
            zero_btn = new Button();
            six_btn = new Button();
            five_btn = new Button();
            four_btn = new Button();
            one_btn = new Button();
            two_btn = new Button();
            three_btn = new Button();
            result_txtbx = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // store_txtbx
            // 
            store_txtbx.BackColor = Color.FromArgb(128, 128, 255);
            store_txtbx.Cursor = Cursors.IBeam;
            store_txtbx.Font = new Font("Stencil", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            store_txtbx.Location = new Point(1, 3);
            store_txtbx.Multiline = true;
            store_txtbx.Name = "store_txtbx";
            store_txtbx.ReadOnly = true;
            store_txtbx.Size = new Size(387, 58);
            store_txtbx.TabIndex = 1;
            store_txtbx.Text = "0";
            store_txtbx.TextChanged += number_txtbx_TextChanged_1;
            store_txtbx.ControlAdded += number_txtbx_ControlAdded;
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(clear_btn);
            panel1.Controls.Add(delete_btn);
            panel1.Controls.Add(remainder_btn);
            panel1.Controls.Add(division_btn);
            panel1.Location = new Point(1, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(791, 73);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // clear_btn
            // 
            clear_btn.Font = new Font("Stencil", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            clear_btn.ImeMode = ImeMode.NoControl;
            clear_btn.Location = new Point(10, 3);
            clear_btn.Name = "clear_btn";
            clear_btn.Size = new Size(176, 64);
            clear_btn.TabIndex = 3;
            clear_btn.Text = "Clear";
            clear_btn.UseVisualStyleBackColor = true;
            clear_btn.Click += clear_btn_Click;
            // 
            // delete_btn
            // 
            delete_btn.Font = new Font("Stencil", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            delete_btn.ImeMode = ImeMode.NoControl;
            delete_btn.Location = new Point(210, 3);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(176, 64);
            delete_btn.TabIndex = 2;
            delete_btn.Text = "Delete";
            delete_btn.UseVisualStyleBackColor = true;
            delete_btn.Click += delete_btn_Click;
            // 
            // remainder_btn
            // 
            remainder_btn.Font = new Font("Stencil", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            remainder_btn.ImeMode = ImeMode.NoControl;
            remainder_btn.Location = new Point(411, 3);
            remainder_btn.Name = "remainder_btn";
            remainder_btn.Size = new Size(176, 64);
            remainder_btn.TabIndex = 1;
            remainder_btn.Text = "%";
            remainder_btn.UseVisualStyleBackColor = true;
            remainder_btn.Click += division_btn_Click;
            // 
            // division_btn
            // 
            division_btn.Font = new Font("Stencil", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            division_btn.ImeMode = ImeMode.NoControl;
            division_btn.Location = new Point(607, 3);
            division_btn.Name = "division_btn";
            division_btn.Size = new Size(176, 64);
            division_btn.TabIndex = 0;
            division_btn.Text = "/";
            division_btn.UseVisualStyleBackColor = true;
            division_btn.Click += division_btn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.CornflowerBlue;
            panel2.Controls.Add(result_btn);
            panel2.Controls.Add(plus_btn);
            panel2.Controls.Add(minus_btn);
            panel2.Controls.Add(multip_btn);
            panel2.Location = new Point(608, 146);
            panel2.Name = "panel2";
            panel2.Size = new Size(184, 454);
            panel2.TabIndex = 3;
            // 
            // result_btn
            // 
            result_btn.Font = new Font("Stencil", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            result_btn.ImeMode = ImeMode.NoControl;
            result_btn.Location = new Point(3, 341);
            result_btn.Name = "result_btn";
            result_btn.Size = new Size(172, 105);
            result_btn.TabIndex = 4;
            result_btn.Text = "Result";
            result_btn.UseVisualStyleBackColor = true;
            result_btn.Click += result_btn_Click;
            // 
            // plus_btn
            // 
            plus_btn.Font = new Font("Stencil", 48F, FontStyle.Regular, GraphicsUnit.Point);
            plus_btn.ImeMode = ImeMode.NoControl;
            plus_btn.Location = new Point(3, 230);
            plus_btn.Name = "plus_btn";
            plus_btn.Size = new Size(172, 105);
            plus_btn.TabIndex = 3;
            plus_btn.Text = "+";
            plus_btn.UseVisualStyleBackColor = true;
            plus_btn.Click += division_btn_Click;
            // 
            // minus_btn
            // 
            minus_btn.Font = new Font("Stencil", 48F, FontStyle.Regular, GraphicsUnit.Point);
            minus_btn.ImeMode = ImeMode.NoControl;
            minus_btn.Location = new Point(3, 117);
            minus_btn.Name = "minus_btn";
            minus_btn.Size = new Size(172, 105);
            minus_btn.TabIndex = 2;
            minus_btn.Text = "-";
            minus_btn.UseVisualStyleBackColor = true;
            minus_btn.Click += division_btn_Click;
            // 
            // multip_btn
            // 
            multip_btn.Font = new Font("Stencil", 36F, FontStyle.Regular, GraphicsUnit.Point);
            multip_btn.ImeMode = ImeMode.NoControl;
            multip_btn.Location = new Point(3, 3);
            multip_btn.Name = "multip_btn";
            multip_btn.Size = new Size(172, 105);
            multip_btn.TabIndex = 1;
            multip_btn.Text = "X";
            multip_btn.UseVisualStyleBackColor = true;
            multip_btn.Click += division_btn_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(point_btn);
            panel3.Controls.Add(nine_btn);
            panel3.Controls.Add(eight_btn);
            panel3.Controls.Add(seven_btn);
            panel3.Controls.Add(zero_btn);
            panel3.Controls.Add(six_btn);
            panel3.Controls.Add(five_btn);
            panel3.Controls.Add(four_btn);
            panel3.Controls.Add(one_btn);
            panel3.Controls.Add(two_btn);
            panel3.Controls.Add(three_btn);
            panel3.Location = new Point(1, 146);
            panel3.Name = "panel3";
            panel3.Size = new Size(598, 454);
            panel3.TabIndex = 4;
            panel3.Paint += panel3_Paint;
            // 
            // point_btn
            // 
            point_btn.Font = new Font("Stencil", 48F, FontStyle.Bold, GraphicsUnit.Point);
            point_btn.ImeMode = ImeMode.NoControl;
            point_btn.Location = new Point(207, 342);
            point_btn.Name = "point_btn";
            point_btn.Size = new Size(176, 104);
            point_btn.TabIndex = 10;
            point_btn.Text = ".";
            point_btn.UseVisualStyleBackColor = true;
            point_btn.Click += point_btn_Click;
            // 
            // nine_btn
            // 
            nine_btn.Font = new Font("Stencil", 48F, FontStyle.Bold, GraphicsUnit.Point);
            nine_btn.ImeMode = ImeMode.NoControl;
            nine_btn.Location = new Point(408, 227);
            nine_btn.Name = "nine_btn";
            nine_btn.Size = new Size(176, 104);
            nine_btn.TabIndex = 9;
            nine_btn.Text = "9";
            nine_btn.UseVisualStyleBackColor = true;
            nine_btn.Click += point_btn_Click;
            // 
            // eight_btn
            // 
            eight_btn.Font = new Font("Stencil", 48F, FontStyle.Bold, GraphicsUnit.Point);
            eight_btn.ImeMode = ImeMode.NoControl;
            eight_btn.Location = new Point(207, 227);
            eight_btn.Name = "eight_btn";
            eight_btn.Size = new Size(176, 104);
            eight_btn.TabIndex = 8;
            eight_btn.Text = "8";
            eight_btn.UseVisualStyleBackColor = true;
            eight_btn.Click += point_btn_Click;
            // 
            // seven_btn
            // 
            seven_btn.Font = new Font("Stencil", 48F, FontStyle.Bold, GraphicsUnit.Point);
            seven_btn.ImeMode = ImeMode.NoControl;
            seven_btn.Location = new Point(7, 227);
            seven_btn.Name = "seven_btn";
            seven_btn.Size = new Size(176, 104);
            seven_btn.TabIndex = 7;
            seven_btn.Text = "7";
            seven_btn.UseVisualStyleBackColor = true;
            seven_btn.Click += point_btn_Click;
            // 
            // zero_btn
            // 
            zero_btn.Font = new Font("Stencil", 48F, FontStyle.Bold, GraphicsUnit.Point);
            zero_btn.ImeMode = ImeMode.NoControl;
            zero_btn.Location = new Point(7, 337);
            zero_btn.Name = "zero_btn";
            zero_btn.Size = new Size(176, 104);
            zero_btn.TabIndex = 6;
            zero_btn.Text = "0";
            zero_btn.UseVisualStyleBackColor = true;
            zero_btn.Click += point_btn_Click;
            // 
            // six_btn
            // 
            six_btn.Font = new Font("Stencil", 48F, FontStyle.Bold, GraphicsUnit.Point);
            six_btn.ImeMode = ImeMode.NoControl;
            six_btn.Location = new Point(408, 114);
            six_btn.Name = "six_btn";
            six_btn.Size = new Size(176, 104);
            six_btn.TabIndex = 5;
            six_btn.Text = "6";
            six_btn.UseVisualStyleBackColor = true;
            six_btn.Click += point_btn_Click;
            // 
            // five_btn
            // 
            five_btn.Font = new Font("Stencil", 48F, FontStyle.Bold, GraphicsUnit.Point);
            five_btn.ImeMode = ImeMode.NoControl;
            five_btn.Location = new Point(207, 114);
            five_btn.Name = "five_btn";
            five_btn.Size = new Size(176, 104);
            five_btn.TabIndex = 4;
            five_btn.Text = "5";
            five_btn.UseVisualStyleBackColor = true;
            five_btn.Click += point_btn_Click;
            // 
            // four_btn
            // 
            four_btn.Font = new Font("Stencil", 48F, FontStyle.Bold, GraphicsUnit.Point);
            four_btn.ImeMode = ImeMode.NoControl;
            four_btn.Location = new Point(7, 117);
            four_btn.Name = "four_btn";
            four_btn.Size = new Size(176, 104);
            four_btn.TabIndex = 3;
            four_btn.Text = "4";
            four_btn.UseVisualStyleBackColor = true;
            four_btn.Click += point_btn_Click;
            // 
            // one_btn
            // 
            one_btn.Font = new Font("Stencil", 48F, FontStyle.Bold, GraphicsUnit.Point);
            one_btn.ImeMode = ImeMode.NoControl;
            one_btn.Location = new Point(7, 4);
            one_btn.Name = "one_btn";
            one_btn.Size = new Size(176, 104);
            one_btn.TabIndex = 2;
            one_btn.Text = "1";
            one_btn.UseVisualStyleBackColor = true;
            one_btn.Click += point_btn_Click;
            // 
            // two_btn
            // 
            two_btn.BackColor = SystemColors.ControlLight;
            two_btn.Font = new Font("Stencil", 48F, FontStyle.Bold, GraphicsUnit.Point);
            two_btn.ImeMode = ImeMode.NoControl;
            two_btn.Location = new Point(207, 4);
            two_btn.Name = "two_btn";
            two_btn.Size = new Size(176, 104);
            two_btn.TabIndex = 1;
            two_btn.Text = "2";
            two_btn.UseVisualStyleBackColor = false;
            two_btn.Click += point_btn_Click;
            // 
            // three_btn
            // 
            three_btn.Font = new Font("Stencil", 48F, FontStyle.Bold, GraphicsUnit.Point);
            three_btn.ImeMode = ImeMode.NoControl;
            three_btn.Location = new Point(408, 4);
            three_btn.Name = "three_btn";
            three_btn.Size = new Size(176, 104);
            three_btn.TabIndex = 0;
            three_btn.Text = "3";
            three_btn.UseVisualStyleBackColor = true;
            three_btn.Click += point_btn_Click;
            // 
            // result_txtbx
            // 
            result_txtbx.BackColor = Color.FromArgb(128, 128, 255);
            result_txtbx.Cursor = Cursors.IBeam;
            result_txtbx.Font = new Font("Stencil", 18F, FontStyle.Bold, GraphicsUnit.Point);
            result_txtbx.Location = new Point(406, 3);
            result_txtbx.Multiline = true;
            result_txtbx.Name = "result_txtbx";
            result_txtbx.ReadOnly = true;
            result_txtbx.Size = new Size(387, 58);
            result_txtbx.TabIndex = 5;
            result_txtbx.Text = "the result:";
            result_txtbx.TextChanged += result_txtbx_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(806, 621);
            Controls.Add(result_txtbx);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(store_txtbx);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox store_txtbx;
        private Panel panel1;
        private Button clear_btn;
        private Button delete_btn;
        private Button remainder_btn;
        private Button division_btn;
        private Panel panel2;
        private Button result_btn;
        private Button plus_btn;
        private Button minus_btn;
        private Button multip_btn;
        private Panel panel3;
        private Button point_btn;
        private Button nine_btn;
        private Button eight_btn;
        private Button seven_btn;
        private Button zero_btn;
        private Button six_btn;
        private Button five_btn;
        private Button four_btn;
        private Button one_btn;
        private Button two_btn;
        private Button three_btn;
        private TextBox result_txtbx;
    }
}