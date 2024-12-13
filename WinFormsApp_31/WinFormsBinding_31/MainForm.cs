namespace WinFormsBinding_31
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            DataContext = new MainViewModel();

            NameTextBox.DataBindings.Add(new Binding("Text", DataContext, "Name", false, DataSourceUpdateMode.OnPropertyChanged));
            NameLabel.DataBindings.Add(new Binding("Text", DataContext, "Name", false, DataSourceUpdateMode.OnPropertyChanged));

            PersonsListBox.DataBindings.Add(new Binding("DataSource", DataContext, "Persons", false, DataSourceUpdateMode.OnPropertyChanged));
            PersonsListBox.DisplayMember = "Name";
            PersonsListBox.DataBindings.Add(new Binding("SelectedItem", DataContext, "SelectedPerson", false, DataSourceUpdateMode.OnPropertyChanged));

            PersonLabel.DataBindings.Add(new Binding("Text", DataContext, "SelectedPerson", false, DataSourceUpdateMode.OnPropertyChanged));

            CounterButton.DataBindings.Add(new Binding("Command", DataContext, "IncrementCommand", true));
            CounterLabel.DataBindings.Add(new Binding("Text", DataContext, "Count", false, DataSourceUpdateMode.OnPropertyChanged));
        }
    }
}
