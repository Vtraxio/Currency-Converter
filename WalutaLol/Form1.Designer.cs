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
            ((System.ComponentModel.ISupportInitialize)inputValue).BeginInit();
            SuspendLayout();
            // 
            // inputCurrency
            // 
            inputCurrency.FormattingEnabled = true;
            inputCurrency.Location = new Point(138, 12);
            inputCurrency.Name = "inputCurrency";
            inputCurrency.Size = new Size(121, 23);
            inputCurrency.TabIndex = 0;
            // 
            // outputCurrency
            // 
            outputCurrency.FormattingEnabled = true;
            outputCurrency.Location = new Point(138, 41);
            outputCurrency.Name = "outputCurrency";
            outputCurrency.Size = new Size(121, 23);
            outputCurrency.TabIndex = 3;
            // 
            // controlButton
            // 
            controlButton.Location = new Point(12, 70);
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
            inputValue.Location = new Point(12, 12);
            inputValue.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
            inputValue.Name = "inputValue";
            inputValue.Size = new Size(120, 23);
            inputValue.TabIndex = 5;
            // 
            // outputValue
            // 
            outputValue.Location = new Point(12, 41);
            outputValue.Name = "outputValue";
            outputValue.ReadOnly = true;
            outputValue.Size = new Size(120, 23);
            outputValue.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(270, 107);
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
    }
}
