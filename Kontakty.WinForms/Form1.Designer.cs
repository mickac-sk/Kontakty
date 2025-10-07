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
            saveBtn = new Button();
            nameTextbox = new TextBox();
            emailTextbox = new TextBox();
            nameLabel = new Label();
            emailLabel = new Label();
            phoneLabel = new Label();
            phoneTextbox = new TextBox();
            contactsListbox = new ListBox();
            clearBtn = new Button();
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
            // saveBtn
            // 
            saveBtn.Location = new Point(478, 255);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(75, 23);
            saveBtn.TabIndex = 1;
            saveBtn.Text = "Zapisz";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // nameTextbox
            // 
            nameTextbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            nameTextbox.Location = new Point(314, 56);
            nameTextbox.Name = "nameTextbox";
            nameTextbox.Size = new Size(239, 29);
            nameTextbox.TabIndex = 2;
            // 
            // emailTextbox
            // 
            emailTextbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            emailTextbox.Location = new Point(314, 131);
            emailTextbox.Name = "emailTextbox";
            emailTextbox.Size = new Size(239, 29);
            emailTextbox.TabIndex = 3;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            nameLabel.Location = new Point(314, 32);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(119, 21);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Imie i nazwisko:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            emailLabel.Location = new Point(314, 107);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(51, 21);
            emailLabel.TabIndex = 5;
            emailLabel.Text = "Email:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            phoneLabel.Location = new Point(314, 184);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(62, 21);
            phoneLabel.TabIndex = 7;
            phoneLabel.Text = "Telefon:";
            // 
            // phoneTextbox
            // 
            phoneTextbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            phoneTextbox.Location = new Point(314, 208);
            phoneTextbox.Name = "phoneTextbox";
            phoneTextbox.Size = new Size(239, 29);
            phoneTextbox.TabIndex = 6;
            // 
            // contactsListbox
            // 
            contactsListbox.FormattingEnabled = true;
            contactsListbox.ItemHeight = 15;
            contactsListbox.Location = new Point(12, 37);
            contactsListbox.Name = "contactsListbox";
            contactsListbox.Size = new Size(273, 244);
            contactsListbox.TabIndex = 8;
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(314, 255);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(75, 23);
            clearBtn.TabIndex = 9;
            clearBtn.Text = "Wyczyść";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(574, 290);
            Controls.Add(clearBtn);
            Controls.Add(contactsListbox);
            Controls.Add(phoneLabel);
            Controls.Add(phoneTextbox);
            Controls.Add(emailLabel);
            Controls.Add(nameLabel);
            Controls.Add(emailTextbox);
            Controls.Add(nameTextbox);
            Controls.Add(saveBtn);
            Controls.Add(titleLable);
            Name = "Form1";
            Text = "Kontakty";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLable;
        private Button saveBtn;
        private TextBox nameTextbox;
        private TextBox emailTextbox;
        private Label nameLabel;
        private Label emailLabel;
        private Label phoneLabel;
        private TextBox phoneTextbox;
        private ListBox contactsListbox;
        private Button clearBtn;
    }
}
