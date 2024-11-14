namespace WinFormsApp_31
{
    partial class RoleForm
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
            UsersListBox = new ListBox();
            AdminsListBox = new ListBox();
            ToAdminButton = new Button();
            ToUserButton = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // UsersListBox
            // 
            UsersListBox.DisplayMember = "Login";
            UsersListBox.FormattingEnabled = true;
            UsersListBox.ItemHeight = 15;
            UsersListBox.Location = new Point(12, 32);
            UsersListBox.Name = "UsersListBox";
            UsersListBox.Size = new Size(269, 229);
            UsersListBox.TabIndex = 0;
            UsersListBox.ValueMember = "Login";
            // 
            // AdminsListBox
            // 
            AdminsListBox.DisplayMember = "Login";
            AdminsListBox.FormattingEnabled = true;
            AdminsListBox.ItemHeight = 15;
            AdminsListBox.Location = new Point(357, 32);
            AdminsListBox.Name = "AdminsListBox";
            AdminsListBox.Size = new Size(251, 229);
            AdminsListBox.TabIndex = 1;
            AdminsListBox.ValueMember = "Login";
            // 
            // ToAdminButton
            // 
            ToAdminButton.Location = new Point(287, 108);
            ToAdminButton.Name = "ToAdminButton";
            ToAdminButton.Size = new Size(64, 38);
            ToAdminButton.TabIndex = 2;
            ToAdminButton.Text = "▶";
            ToAdminButton.UseVisualStyleBackColor = true;
            // 
            // ToUserButton
            // 
            ToUserButton.Location = new Point(287, 152);
            ToUserButton.Name = "ToUserButton";
            ToUserButton.Size = new Size(64, 38);
            ToUserButton.TabIndex = 2;
            ToUserButton.Text = "◀";
            ToUserButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 12);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 3;
            label1.Text = "Холопы";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(355, 10);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 4;
            label2.Text = "Господа";
            // 
            // RoleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 273);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ToUserButton);
            Controls.Add(ToAdminButton);
            Controls.Add(AdminsListBox);
            Controls.Add(UsersListBox);
            Name = "RoleForm";
            Text = "RoleForm";
            Load += RoleForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox UsersListBox;
        private ListBox AdminsListBox;
        private Button ToAdminButton;
        private Button ToUserButton;
        private Label label1;
        private Label label2;
    }
}