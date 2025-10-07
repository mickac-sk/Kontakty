namespace Kontakty.WinForms
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
            titleLable = new Label();
            actionBtn = new Button();
            loginTextbox = new TextBox();
            passwordTextbox = new TextBox();
            SuspendLayout();
            // 
            // titleLable
            // 
            titleLable.AutoSize = true;
            titleLable.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            titleLable.Location = new Point(12, 9);
            titleLable.Name = "titleLable";
            titleLable.Size = new Size(85, 25);
            titleLable.TabIndex = 0;
            titleLable.Text = "Kontakty";
            // 
            // actionBtn
            // 
            actionBtn.Location = new Point(176, 114);
            actionBtn.Name = "actionBtn";
            actionBtn.Size = new Size(75, 23);
            actionBtn.TabIndex = 1;
            actionBtn.Text = "Zaloguj";
            actionBtn.UseVisualStyleBackColor = true;
            actionBtn.Click += actionBtn_Click;
            // 
            // loginTextbox
            // 
            loginTextbox.Location = new Point(12, 37);
            loginTextbox.Name = "loginTextbox";
            loginTextbox.Size = new Size(239, 23);
            loginTextbox.TabIndex = 2;
            // 
            // passwordTextbox
            // 
            passwordTextbox.Location = new Point(12, 85);
            passwordTextbox.Name = "passwordTextbox";
            passwordTextbox.Size = new Size(239, 23);
            passwordTextbox.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(passwordTextbox);
            Controls.Add(loginTextbox);
            Controls.Add(actionBtn);
            Controls.Add(titleLable);
            Name = "Form1";
            Text = "Kontakty";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLable;
        private Button actionBtn;
        private TextBox loginTextbox;
        private TextBox passwordTextbox;
    }
}
