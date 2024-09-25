namespace WalutaLol
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
            inputCurrency = new ComboBox();
            outputCurrency = new ComboBox();
            controlButton = new Button();
            inputValue = new NumericUpDown();
            outputValue = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)inputValue).BeginInit();
            SuspendLayout();
            // 
            // inputCurrency
            // 
            inputCurrency.DropDownStyle = ComboBoxStyle.DropDownList;
            inputCurrency.FormattingEnabled = true;
            inputCurrency.Location = new Point(138, 27);
            inputCurrency.Name = "inputCurrency";
            inputCurrency.Size = new Size(121, 23);
            inputCurrency.TabIndex = 0;
            // 
            // outputCurrency
            // 
            outputCurrency.DropDownStyle = ComboBoxStyle.DropDownList;
            outputCurrency.FormattingEnabled = true;
            outputCurrency.Location = new Point(138, 71);
            outputCurrency.Name = "outputCurrency";
            outputCurrency.Size = new Size(121, 23);
            outputCurrency.TabIndex = 3;
            // 
            // controlButton
            // 
            controlButton.Location = new Point(12, 100);
            controlButton.Name = "controlButton";
            controlButton.Size = new Size(247, 23);
            controlButton.TabIndex = 4;
            controlButton.Text = "Przmień";
            controlButton.UseVisualStyleBackColor = true;
            controlButton.Click += controlButton_Click;
            // 
            // inputValue
            // 
            inputValue.DecimalPlaces = 2;
            inputValue.Location = new Point(12, 27);
            inputValue.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
            inputValue.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            inputValue.Name = "inputValue";
            inputValue.Size = new Size(120, 23);
            inputValue.TabIndex = 5;
            inputValue.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // outputValue
            // 
            outputValue.Location = new Point(12, 71);
            outputValue.Name = "outputValue";
            outputValue.ReadOnly = true;
            outputValue.Size = new Size(120, 23);
            outputValue.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 7;
            label1.Text = "Wartość wejściowa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(138, 9);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 8;
            label2.Text = "Waluta wejściowa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 53);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 9;
            label3.Text = "Wartość wyjściowa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(138, 53);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 10;
            label4.Text = "Waluta wyjściowa";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(271, 135);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(outputValue);
            Controls.Add(inputValue);
            Controls.Add(controlButton);
            Controls.Add(outputCurrency);
            Controls.Add(inputCurrency);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)inputValue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox inputCurrency;
        private ComboBox outputCurrency;
        private Button controlButton;
        private NumericUpDown inputValue;
        private TextBox outputValue;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
