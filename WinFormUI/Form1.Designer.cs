
namespace WinFormUI
{
    partial class Calculator
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
            this.UserInputText = new System.Windows.Forms.TextBox();
            this.CalculationText = new System.Windows.Forms.Label();
            this.NumberPanel = new System.Windows.Forms.TableLayoutPanel();
            this.EqualButton = new System.Windows.Forms.Button();
            this.DottButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.PercentageButton = new System.Windows.Forms.Button();
            this.PlusButton = new System.Windows.Forms.Button();
            this.Number3Button = new System.Windows.Forms.Button();
            this.Number2Button = new System.Windows.Forms.Button();
            this.Number1Button = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.Number6Button = new System.Windows.Forms.Button();
            this.Number5Button = new System.Windows.Forms.Button();
            this.Number4Button = new System.Windows.Forms.Button();
            this.MultipleButton = new System.Windows.Forms.Button();
            this.Number9Button = new System.Windows.Forms.Button();
            this.Number8Button = new System.Windows.Forms.Button();
            this.Number7Button = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.CButton = new System.Windows.Forms.Button();
            this.CEbutton = new System.Windows.Forms.Button();
            this.NumberPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserInputText
            // 
            this.UserInputText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserInputText.Location = new System.Drawing.Point(7, 7);
            this.UserInputText.Multiline = true;
            this.UserInputText.Name = "UserInputText";
            this.UserInputText.Size = new System.Drawing.Size(340, 27);
            this.UserInputText.TabIndex = 0;
            // 
            // CalculationText
            // 
            this.CalculationText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CalculationText.AutoSize = true;
            this.CalculationText.Location = new System.Drawing.Point(17, 46);
            this.CalculationText.Name = "CalculationText";
            this.CalculationText.Size = new System.Drawing.Size(309, 20);
            this.CalculationText.TabIndex = 1;
            this.CalculationText.Text = "Please enter an equation and press enter or =";
            // 
            // NumberPanel
            // 
            this.NumberPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberPanel.ColumnCount = 4;
            this.NumberPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.NumberPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.NumberPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.NumberPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.NumberPanel.Controls.Add(this.EqualButton, 3, 4);
            this.NumberPanel.Controls.Add(this.DottButton, 2, 4);
            this.NumberPanel.Controls.Add(this.ZeroButton, 1, 4);
            this.NumberPanel.Controls.Add(this.PercentageButton, 0, 4);
            this.NumberPanel.Controls.Add(this.PlusButton, 3, 3);
            this.NumberPanel.Controls.Add(this.Number3Button, 2, 3);
            this.NumberPanel.Controls.Add(this.Number2Button, 1, 3);
            this.NumberPanel.Controls.Add(this.Number1Button, 0, 3);
            this.NumberPanel.Controls.Add(this.MinusButton, 3, 2);
            this.NumberPanel.Controls.Add(this.Number6Button, 2, 2);
            this.NumberPanel.Controls.Add(this.Number5Button, 1, 2);
            this.NumberPanel.Controls.Add(this.Number4Button, 0, 2);
            this.NumberPanel.Controls.Add(this.MultipleButton, 3, 1);
            this.NumberPanel.Controls.Add(this.Number9Button, 2, 1);
            this.NumberPanel.Controls.Add(this.Number8Button, 1, 1);
            this.NumberPanel.Controls.Add(this.Number7Button, 0, 1);
            this.NumberPanel.Controls.Add(this.DeleteButton, 3, 0);
            this.NumberPanel.Controls.Add(this.Divide, 2, 0);
            this.NumberPanel.Controls.Add(this.CButton, 1, 0);
            this.NumberPanel.Controls.Add(this.CEbutton, 0, 0);
            this.NumberPanel.Location = new System.Drawing.Point(7, 69);
            this.NumberPanel.Name = "NumberPanel";
            this.NumberPanel.RowCount = 6;
            this.NumberPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.NumberPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.NumberPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.NumberPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.NumberPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.NumberPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.NumberPanel.Size = new System.Drawing.Size(343, 325);
            this.NumberPanel.TabIndex = 2;
            // 
            // EqualButton
            // 
            this.EqualButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EqualButton.Location = new System.Drawing.Point(258, 263);
            this.EqualButton.Name = "EqualButton";
            this.EqualButton.Size = new System.Drawing.Size(82, 59);
            this.EqualButton.TabIndex = 19;
            this.EqualButton.Text = "=";
            this.EqualButton.UseVisualStyleBackColor = true;
            this.EqualButton.Click += new System.EventHandler(this.EqualButton_Click);
            // 
            // DottButton
            // 
            this.DottButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DottButton.Location = new System.Drawing.Point(173, 263);
            this.DottButton.Name = "DottButton";
            this.DottButton.Size = new System.Drawing.Size(79, 59);
            this.DottButton.TabIndex = 18;
            this.DottButton.Text = ".";
            this.DottButton.UseVisualStyleBackColor = true;
            this.DottButton.Click += new System.EventHandler(this.DottButton_Click);
            // 
            // ZeroButton
            // 
            this.ZeroButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ZeroButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ZeroButton.Location = new System.Drawing.Point(88, 263);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(79, 59);
            this.ZeroButton.TabIndex = 17;
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = true;
            this.ZeroButton.Click += new System.EventHandler(this.ZeroButton_Click);
            // 
            // PercentageButton
            // 
            this.PercentageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PercentageButton.Location = new System.Drawing.Point(3, 263);
            this.PercentageButton.Name = "PercentageButton";
            this.PercentageButton.Size = new System.Drawing.Size(79, 59);
            this.PercentageButton.TabIndex = 16;
            this.PercentageButton.Text = "%";
            this.PercentageButton.UseVisualStyleBackColor = true;
            this.PercentageButton.Click += new System.EventHandler(this.PercentageButton_Click);
            // 
            // PlusButton
            // 
            this.PlusButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlusButton.Location = new System.Drawing.Point(258, 198);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(82, 59);
            this.PlusButton.TabIndex = 15;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = true;
            this.PlusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // Number3Button
            // 
            this.Number3Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Number3Button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Number3Button.Location = new System.Drawing.Point(173, 198);
            this.Number3Button.Name = "Number3Button";
            this.Number3Button.Size = new System.Drawing.Size(79, 59);
            this.Number3Button.TabIndex = 14;
            this.Number3Button.Text = "3";
            this.Number3Button.UseVisualStyleBackColor = true;
            this.Number3Button.Click += new System.EventHandler(this.Number3Button_Click);
            // 
            // Number2Button
            // 
            this.Number2Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Number2Button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Number2Button.Location = new System.Drawing.Point(88, 198);
            this.Number2Button.Name = "Number2Button";
            this.Number2Button.Size = new System.Drawing.Size(79, 59);
            this.Number2Button.TabIndex = 13;
            this.Number2Button.Text = "2";
            this.Number2Button.UseVisualStyleBackColor = true;
            this.Number2Button.Click += new System.EventHandler(this.Number2Button_Click);
            // 
            // Number1Button
            // 
            this.Number1Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Number1Button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Number1Button.Location = new System.Drawing.Point(3, 198);
            this.Number1Button.Name = "Number1Button";
            this.Number1Button.Size = new System.Drawing.Size(79, 59);
            this.Number1Button.TabIndex = 12;
            this.Number1Button.Text = "1";
            this.Number1Button.UseVisualStyleBackColor = true;
            this.Number1Button.Click += new System.EventHandler(this.Number1Button_Click);
            // 
            // MinusButton
            // 
            this.MinusButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MinusButton.Location = new System.Drawing.Point(258, 133);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(82, 59);
            this.MinusButton.TabIndex = 11;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = true;
            this.MinusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // Number6Button
            // 
            this.Number6Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Number6Button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Number6Button.Location = new System.Drawing.Point(173, 133);
            this.Number6Button.Name = "Number6Button";
            this.Number6Button.Size = new System.Drawing.Size(79, 59);
            this.Number6Button.TabIndex = 10;
            this.Number6Button.Text = "6";
            this.Number6Button.UseVisualStyleBackColor = true;
            this.Number6Button.Click += new System.EventHandler(this.Number6Button_Click);
            // 
            // Number5Button
            // 
            this.Number5Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Number5Button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Number5Button.Location = new System.Drawing.Point(88, 133);
            this.Number5Button.Name = "Number5Button";
            this.Number5Button.Size = new System.Drawing.Size(79, 59);
            this.Number5Button.TabIndex = 9;
            this.Number5Button.Text = "5";
            this.Number5Button.UseVisualStyleBackColor = true;
            this.Number5Button.Click += new System.EventHandler(this.Number5Button_Click);
            // 
            // Number4Button
            // 
            this.Number4Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Number4Button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Number4Button.Location = new System.Drawing.Point(3, 133);
            this.Number4Button.Name = "Number4Button";
            this.Number4Button.Size = new System.Drawing.Size(79, 59);
            this.Number4Button.TabIndex = 8;
            this.Number4Button.Text = "4";
            this.Number4Button.UseVisualStyleBackColor = true;
            this.Number4Button.Click += new System.EventHandler(this.Number4Button_Click);
            // 
            // MultipleButton
            // 
            this.MultipleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MultipleButton.Location = new System.Drawing.Point(258, 68);
            this.MultipleButton.Name = "MultipleButton";
            this.MultipleButton.Size = new System.Drawing.Size(82, 59);
            this.MultipleButton.TabIndex = 7;
            this.MultipleButton.Text = "*";
            this.MultipleButton.UseVisualStyleBackColor = true;
            this.MultipleButton.Click += new System.EventHandler(this.MultipleButton_Click);
            // 
            // Number9Button
            // 
            this.Number9Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Number9Button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Number9Button.Location = new System.Drawing.Point(173, 68);
            this.Number9Button.Name = "Number9Button";
            this.Number9Button.Size = new System.Drawing.Size(79, 59);
            this.Number9Button.TabIndex = 6;
            this.Number9Button.Text = "9";
            this.Number9Button.UseVisualStyleBackColor = true;
            this.Number9Button.Click += new System.EventHandler(this.Number9Button_Click);
            // 
            // Number8Button
            // 
            this.Number8Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Number8Button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Number8Button.Location = new System.Drawing.Point(88, 68);
            this.Number8Button.Name = "Number8Button";
            this.Number8Button.Size = new System.Drawing.Size(79, 59);
            this.Number8Button.TabIndex = 5;
            this.Number8Button.Text = "8";
            this.Number8Button.UseVisualStyleBackColor = true;
            this.Number8Button.Click += new System.EventHandler(this.Number8Button_Click);
            // 
            // Number7Button
            // 
            this.Number7Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Number7Button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Number7Button.Location = new System.Drawing.Point(3, 68);
            this.Number7Button.Name = "Number7Button";
            this.Number7Button.Size = new System.Drawing.Size(79, 59);
            this.Number7Button.TabIndex = 4;
            this.Number7Button.Text = "7";
            this.Number7Button.UseVisualStyleBackColor = true;
            this.Number7Button.Click += new System.EventHandler(this.Number7Button_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteButton.Location = new System.Drawing.Point(258, 3);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(82, 59);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "⌦";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // Divide
            // 
            this.Divide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Divide.Location = new System.Drawing.Point(173, 3);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(79, 59);
            this.Divide.TabIndex = 2;
            this.Divide.Text = "/";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new System.EventHandler(this.Divide_Click);
            // 
            // CButton
            // 
            this.CButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CButton.Location = new System.Drawing.Point(88, 3);
            this.CButton.Name = "CButton";
            this.CButton.Size = new System.Drawing.Size(79, 59);
            this.CButton.TabIndex = 1;
            this.CButton.Text = "C";
            this.CButton.UseVisualStyleBackColor = true;
            // 
            // CEbutton
            // 
            this.CEbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CEbutton.Location = new System.Drawing.Point(3, 3);
            this.CEbutton.Name = "CEbutton";
            this.CEbutton.Size = new System.Drawing.Size(79, 59);
            this.CEbutton.TabIndex = 0;
            this.CEbutton.Text = "CE";
            this.CEbutton.UseVisualStyleBackColor = true;
            this.CEbutton.Click += new System.EventHandler(this.CEbutton_Click);
            // 
            // Calculator
            // 
            this.AcceptButton = this.EqualButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(5, 5);
            this.CancelButton = this.CEbutton;
            this.ClientSize = new System.Drawing.Size(360, 401);
            this.Controls.Add(this.NumberPanel);
            this.Controls.Add(this.CalculationText);
            this.Controls.Add(this.UserInputText);
            this.MinimumSize = new System.Drawing.Size(346, 290);
            this.Name = "Calculator";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Basic Calculator";
            this.NumberPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserInputText;
        private System.Windows.Forms.Label CalculationText;
        private System.Windows.Forms.TableLayoutPanel NumberPanel;
        private System.Windows.Forms.Button EqualButton;
        private System.Windows.Forms.Button DottButton;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.Button PercentageButton;
        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.Button Number3Button;
        private System.Windows.Forms.Button Number2Button;
        private System.Windows.Forms.Button Number1Button;
        private System.Windows.Forms.Button MinusButton;
        private System.Windows.Forms.Button Number6Button;
        private System.Windows.Forms.Button Number5Button;
        private System.Windows.Forms.Button Number4Button;
        private System.Windows.Forms.Button MultipleButton;
        private System.Windows.Forms.Button Number9Button;
        private System.Windows.Forms.Button Number8Button;
        private System.Windows.Forms.Button Number7Button;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Button CButton;
        private System.Windows.Forms.Button CEbutton;
    }
}

