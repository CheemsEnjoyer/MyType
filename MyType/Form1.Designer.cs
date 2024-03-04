namespace MyType
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
            textBoxNum1 = new TextBox();
            textBoxDen1 = new TextBox();
            textBoxNum2 = new TextBox();
            textBoxDen2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            buttonCalculate = new Button();
            comboBoxOperation = new ComboBox();
            buttonCompare = new Button();
            lblResult = new Label();
            buttonSimplifyAnswer = new Button();
            buttonSimplifyFractures = new Button();
            SuspendLayout();
            // 
            // textBoxNum1
            // 
            textBoxNum1.Location = new Point(94, 61);
            textBoxNum1.Name = "textBoxNum1";
            textBoxNum1.Size = new Size(125, 27);
            textBoxNum1.TabIndex = 0;
            // 
            // textBoxDen1
            // 
            textBoxDen1.Location = new Point(238, 61);
            textBoxDen1.Name = "textBoxDen1";
            textBoxDen1.Size = new Size(125, 27);
            textBoxDen1.TabIndex = 1;
            // 
            // textBoxNum2
            // 
            textBoxNum2.Location = new Point(94, 105);
            textBoxNum2.Name = "textBoxNum2";
            textBoxNum2.Size = new Size(125, 27);
            textBoxNum2.TabIndex = 2;
            // 
            // textBoxDen2
            // 
            textBoxDen2.Location = new Point(238, 105);
            textBoxDen2.Name = "textBoxDen2";
            textBoxDen2.Size = new Size(125, 27);
            textBoxDen2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(369, 68);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 4;
            label1.Text = "Дробь 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(369, 112);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 5;
            label2.Text = "Дробь 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(117, 38);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 6;
            label3.Text = "Числитель";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(260, 38);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 7;
            label4.Text = "Знаменатель";
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(248, 139);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(125, 29);
            buttonCalculate.TabIndex = 8;
            buttonCalculate.Text = "Вычислить!";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // comboBoxOperation
            // 
            comboBoxOperation.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOperation.FormattingEnabled = true;
            comboBoxOperation.Items.AddRange(new object[] { "+", "-", "*", "/" });
            comboBoxOperation.Location = new Point(12, 83);
            comboBoxOperation.Name = "comboBoxOperation";
            comboBoxOperation.Size = new Size(43, 28);
            comboBoxOperation.TabIndex = 9;
            // 
            // buttonCompare
            // 
            buttonCompare.Location = new Point(379, 139);
            buttonCompare.Name = "buttonCompare";
            buttonCompare.Size = new Size(94, 29);
            buttonCompare.TabIndex = 10;
            buttonCompare.Text = "Сравнить";
            buttonCompare.UseVisualStyleBackColor = true;
            buttonCompare.Click += buttonCompare_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(12, 148);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(48, 20);
            lblResult.TabIndex = 11;
            lblResult.Text = "Ответ";
            // 
            // buttonSimplifyAnswer
            // 
            buttonSimplifyAnswer.Location = new Point(12, 171);
            buttonSimplifyAnswer.Name = "buttonSimplifyAnswer";
            buttonSimplifyAnswer.Size = new Size(162, 29);
            buttonSimplifyAnswer.TabIndex = 12;
            buttonSimplifyAnswer.Text = "Сократить ответ";
            buttonSimplifyAnswer.UseVisualStyleBackColor = true;
            buttonSimplifyAnswer.Click += buttonSimplify_Click;
            // 
            // buttonSimplifyFractures
            // 
            buttonSimplifyFractures.Location = new Point(248, 174);
            buttonSimplifyFractures.Name = "buttonSimplifyFractures";
            buttonSimplifyFractures.Size = new Size(125, 29);
            buttonSimplifyFractures.TabIndex = 13;
            buttonSimplifyFractures.Text = "Сократить";
            buttonSimplifyFractures.UseVisualStyleBackColor = true;
            buttonSimplifyFractures.Click += buttonSimplifyFractures_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 211);
            Controls.Add(buttonSimplifyFractures);
            Controls.Add(buttonSimplifyAnswer);
            Controls.Add(lblResult);
            Controls.Add(buttonCompare);
            Controls.Add(comboBoxOperation);
            Controls.Add(buttonCalculate);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxDen2);
            Controls.Add(textBoxNum2);
            Controls.Add(textBoxDen1);
            Controls.Add(textBoxNum1);
            Name = "Form1";
            Text = "Калькулятор";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNum1;
        private TextBox textBoxDen1;
        private TextBox textBoxNum2;
        private TextBox textBoxDen2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button buttonCalculate;
        private ComboBox comboBoxOperation;
        private Button buttonCompare;
        private Label lblResult;
        private Button buttonSimplifyAnswer;
        private Button buttonSimplifyFractures;
    }
}
