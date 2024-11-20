namespace WinFormsApp_34_45
{
    partial class UserListForm
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
            components = new System.ComponentModel.Container();
            UsersDataGridView = new DataGridView();
            loginDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            passwordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            birthDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fullNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            genderDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userBindingSource = new BindingSource(components);
            SaveButton = new Button();
            UsersSaveFileDialog = new SaveFileDialog();
            UsersOpenFileDialog = new OpenFileDialog();
            LoadButton = new Button();
            ((System.ComponentModel.ISupportInitialize)UsersDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            SuspendLayout();
            // 
            // UsersDataGridView
            // 
            UsersDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UsersDataGridView.AutoGenerateColumns = false;
            UsersDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            UsersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UsersDataGridView.Columns.AddRange(new DataGridViewColumn[] { loginDataGridViewTextBoxColumn, passwordDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, birthDateDataGridViewTextBoxColumn, fullNameDataGridViewTextBoxColumn, genderDataGridViewTextBoxColumn });
            UsersDataGridView.DataSource = userBindingSource;
            UsersDataGridView.Location = new Point(15, 13);
            UsersDataGridView.Margin = new Padding(4);
            UsersDataGridView.Name = "UsersDataGridView";
            UsersDataGridView.Size = new Size(841, 335);
            UsersDataGridView.TabIndex = 0;
            UsersDataGridView.CellDoubleClick += UsersDataGridView_CellDoubleClick;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            loginDataGridViewTextBoxColumn.HeaderText = "Логин";
            loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            loginDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            passwordDataGridViewTextBoxColumn.Visible = false;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // birthDateDataGridViewTextBoxColumn
            // 
            birthDateDataGridViewTextBoxColumn.DataPropertyName = "BirthDate";
            birthDateDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            birthDateDataGridViewTextBoxColumn.Name = "birthDateDataGridViewTextBoxColumn";
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            fullNameDataGridViewTextBoxColumn.HeaderText = "ФИО";
            fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            genderDataGridViewTextBoxColumn.HeaderText = "Пол";
            genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(User);
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(636, 355);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(220, 31);
            SaveButton.TabIndex = 1;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // UsersSaveFileDialog
            // 
            UsersSaveFileDialog.FileName = "users.json";
            UsersSaveFileDialog.Filter = "JSON|*.json";
            // 
            // UsersOpenFileDialog
            // 
            UsersOpenFileDialog.FileName = "openFileDialog1";
            UsersOpenFileDialog.Filter = "JSON|*.json";
            // 
            // LoadButton
            // 
            LoadButton.Location = new Point(410, 355);
            LoadButton.Name = "LoadButton";
            LoadButton.Size = new Size(220, 31);
            LoadButton.TabIndex = 2;
            LoadButton.Text = "Загрузить";
            LoadButton.UseVisualStyleBackColor = true;
            LoadButton.Click += LoadButton_Click;
            // 
            // UserListForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 433);
            Controls.Add(LoadButton);
            Controls.Add(SaveButton);
            Controls.Add(UsersDataGridView);
            Margin = new Padding(5, 6, 5, 6);
            Name = "UserListForm";
            Text = "Пользователи";
            Load += UserListForm_Load;
            Controls.SetChildIndex(UsersDataGridView, 0);
            Controls.SetChildIndex(SaveButton, 0);
            Controls.SetChildIndex(LoadButton, 0);
            ((System.ComponentModel.ISupportInitialize)UsersDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView UsersDataGridView;
        private BindingSource userBindingSource;
        private DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private Button SaveButton;
        private SaveFileDialog UsersSaveFileDialog;
        private OpenFileDialog UsersOpenFileDialog;
        private Button LoadButton;
    }
}