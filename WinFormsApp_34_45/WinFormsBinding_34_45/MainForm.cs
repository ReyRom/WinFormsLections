namespace WinFormsBinding_34_45
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            DataContext = new MainViewModel();

            NameTextBox.DataBindings.Add(new Binding("Text",DataContext,"Name",false,DataSourceUpdateMode.OnPropertyChanged));

            NameLabel.DataBindings.Add(new Binding("Text", DataContext, "Hello", false, DataSourceUpdateMode.OnPropertyChanged));

            PersonLabel.DataBindings.Add(new Binding("Text", DataContext, "Person", false, DataSourceUpdateMode.OnPropertyChanged));

            PersonsListBox.DataBindings.Add(new Binding("DataSource", DataContext, "Persons", false, DataSourceUpdateMode.OnPropertyChanged));
        }
    }
}
