namespace Assignments_3._4._1
{
    public partial class Form1 : Form
    {
        private List<Coffee> _coffeeList = new List<Coffee>();
        private BindingSource _coffeeBindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;        // When Form1 is loaded, also call Form1_Load
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initalize the list with 5 coffees
            _coffeeList.Add(new Coffee
            {
                BevId = 1,
                Brand = "Starbucks",
                VolumeInOz = 20,
                Roast = RoastType.Dark,
                IsDecaf = false

            });

            _coffeeList.Add(new Coffee
            {
                BevId = 2,
                Brand = "Dunkin",
                VolumeInOz = 8,
                Roast = RoastType.Light,
                IsDecaf = true

            });

            _coffeeList.Add(new Coffee
            {
                BevId = 3,
                Brand = "Seattle's Best",
                VolumeInOz = 12,
                Roast = RoastType.Medium,
                IsDecaf = false

            });

            _coffeeList.Add(new Coffee
            {
                BevId = 4,
                Brand = "Pete's",
                VolumeInOz = 16,
                Roast = RoastType.Medium_Dark,
                IsDecaf = false

            });

            _coffeeList.Add(new Coffee
            {
                BevId = 5,
                Brand = "Olympia's Coffee",
                VolumeInOz = 20,
                Roast = RoastType.Dark,
                IsDecaf = false

            });

            // Bind the Roast Type to combo
            cmbRoast.DataSource = Enum.GetValues(typeof(RoastType));

            // Bind volume in oz to cup sizes to combo.
            cmbVolume.DataSource = new List<double> { 8, 12, 16, 20 };

            // Bind list to grid.
            _coffeeBindingSource.DataSource = _coffeeList;
            dataGridView1.DataSource = _coffeeBindingSource;

            // Show the grid in the following order
            dataGridView1.Columns["BevId"].DisplayIndex = 0;
            dataGridView1.Columns["Brand"].DisplayIndex = 1;
            dataGridView1.Columns["VolumeInOz"].DisplayIndex = 2;
            dataGridView1.Columns["Roast"].DisplayIndex = 3;
            dataGridView1.Columns["IsDecaf"].DisplayIndex = 4;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtBrand.Text))
            {
                MessageBox.Show("Incorrect input please enter a name.");
                return;
            }
            // Create the new coffee
            Coffee coffee = new Coffee()
            {
                BevId = _coffeeList.Count + 1,
                Brand = txtBrand.Text.Trim(),
                VolumeInOz = (double)cmbVolume.SelectedItem,
                Roast = (RoastType)cmbRoast.SelectedItem,
                IsDecaf = chkIsDecaf.Checked
            };

            // Add to list
            _coffeeList.Add(coffee);
            _coffeeBindingSource.ResetBindings(false);

            // Clear the list
            txtBrand.Clear();
            cmbVolume.SelectedIndex = 0;
            cmbRoast.SelectedIndex = 0;
            chkIsDecaf.Checked = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_coffeeList.Count == 0)
            {
                MessageBox.Show("There are no coffees left to delete.");
                return;
            }

            _coffeeList.RemoveAt(_coffeeList.Count - 1);   // Deletes last coffee
            _coffeeBindingSource.ResetBindings(false);
        }
    }
}
