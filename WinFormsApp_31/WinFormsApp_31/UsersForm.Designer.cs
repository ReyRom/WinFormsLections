namespace WinFormsApp_31
{
    partial class UsersForm
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
            fullNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            birthDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            genderDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            roleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            DeleteColumn = new DataGridViewButtonColumn();
            userBindingSource = new BindingSource(components);
            RolesButton = new Button();
            SaveUsersButton = new Button();
            LoadUsersButton = new Button();
            UsersOpenFileDialog = new OpenFileDialog();
            UsersSaveFileDialog = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)UsersDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            SuspendLayout();
            // 
            // UsersDataGridView
            // 
            UsersDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UsersDataGridView.AutoGenerateColumns = false;
            UsersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UsersDataGridView.Columns.AddRange(new DataGridViewColumn[] { loginDataGridViewTextBoxColumn, passwordDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, fullNameDataGridViewTextBoxColumn, birthDateDataGridViewTextBoxColumn, genderDataGridViewTextBoxColumn, roleDataGridViewTextBoxColumn, DeleteColumn });
            UsersDataGridView.DataSource = userBindingSource;
            UsersDataGridView.Location = new Point(15, 84);
            UsersDataGridView.Margin = new Padding(4);
            UsersDataGridView.Name = "UsersDataGridView";
            UsersDataGridView.ReadOnly = true;
            UsersDataGridView.Size = new Size(744, 330);
            UsersDataGridView.TabIndex = 0;
            UsersDataGridView.CellClick += UsersDataGridView_CellClick;
            UsersDataGridView.DataError += UsersDataGridView_DataError;
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
            passwordDataGridViewTextBoxColumn.ReadOnly = true;
            passwordDataGridViewTextBoxColumn.Visible = false;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            fullNameDataGridViewTextBoxColumn.HeaderText = "ФИО";
            fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birthDateDataGridViewTextBoxColumn
            // 
            birthDateDataGridViewTextBoxColumn.DataPropertyName = "BirthDate";
            birthDateDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            birthDateDataGridViewTextBoxColumn.Name = "birthDateDataGridViewTextBoxColumn";
            birthDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            genderDataGridViewTextBoxColumn.HeaderText = "Пол";
            genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            genderDataGridViewTextBoxColumn.ReadOnly = true;
            genderDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            roleDataGridViewTextBoxColumn.HeaderText = "Роль";
            roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            roleDataGridViewTextBoxColumn.ReadOnly = true;
            roleDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            // 
            // DeleteColumn
            // 
            DeleteColumn.HeaderText = "Удалить";
            DeleteColumn.Name = "DeleteColumn";
            DeleteColumn.ReadOnly = true;
            DeleteColumn.Resizable = DataGridViewTriState.True;
            DeleteColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(User);
            // 
            // RolesButton
            // 
            RolesButton.Location = new Point(15, 15);
            RolesButton.Margin = new Padding(5, 6, 5, 6);
            RolesButton.Name = "RolesButton";
            RolesButton.Size = new Size(204, 38);
            RolesButton.TabIndex = 2;
            RolesButton.Text = "Роли";
            RolesButton.UseVisualStyleBackColor = true;
            RolesButton.Click += RolesButton_Click;
            // 
            // SaveUsersButton
            // 
            SaveUsersButton.Location = new Point(411, 15);
            SaveUsersButton.Name = "SaveUsersButton";
            SaveUsersButton.Size = new Size(166, 38);
            SaveUsersButton.TabIndex = 3;
            SaveUsersButton.Text = "Сохранить";
            SaveUsersButton.UseVisualStyleBackColor = true;
            SaveUsersButton.Click += SaveUsersButton_Click;
            // 
            // LoadUsersButton
            // 
            LoadUsersButton.Location = new Point(583, 15);
            LoadUsersButton.Name = "LoadUsersButton";
            LoadUsersButton.Size = new Size(176, 38);
            LoadUsersButton.TabIndex = 4;
            LoadUsersButton.Text = "Загрузить";
            LoadUsersButton.UseVisualStyleBackColor = true;
            LoadUsersButton.Click += LoadUsersButton_Click;
            // 
            // UsersOpenFileDialog
            // 
            UsersOpenFileDialog.Filter = "JSON|*.json";
            // 
            // UsersSaveFileDialog
            // 
            UsersSaveFileDialog.FileName = "users.json";
            UsersSaveFileDialog.Filter = "JSON|*.json";
            // 
            // UsersForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(787, 474);
            Controls.Add(LoadUsersButton);
            Controls.Add(SaveUsersButton);
            Controls.Add(RolesButton);
            Controls.Add(UsersDataGridView);
            Margin = new Padding(5, 6, 5, 6);
            Name = "UsersForm";
            Text = "Пользователи";
            Load += UsersForm_Load;
            Controls.SetChildIndex(UsersDataGridView, 0);
            Controls.SetChildIndex(RolesButton, 0);
            Controls.SetChildIndex(SaveUsersButton, 0);
            Controls.SetChildIndex(LoadUsersButton, 0);
            ((System.ComponentModel.ISupportInitialize)UsersDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView UsersDataGridView;
        private BindingSource userBindingSource;
        private Button RolesButton;
        private DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn DeleteColumn;
        private Button SaveUsersButton;
        private Button LoadUsersButton;
        private OpenFileDialog UsersOpenFileDialog;
        private SaveFileDialog UsersSaveFileDialog;
    }
}