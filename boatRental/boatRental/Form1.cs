using csharp_1;
using MySql.Data.MySqlClient;
using System.Threading;

namespace boatRental
{
    public partial class Form1 : Form
    {

        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;

        List<Boat> dbBoats;
        List<Rent> dbRents;

        AboutBox1 aboutBox = new AboutBox1();
        public Form1()
        {
            Thread t = new Thread(new ThreadStart(startSplashscreen));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();

            dbBoats = new List<Boat>();
            dbRents = new List<Rent>();
            con = new MySqlConnection("Server=localhost;Database=boat_rental;user=stenden;Pwd=stenden;SslMode=none");
            cmd = new MySqlCommand();
            cmd.Connection = con;

            this.getAllBoats();
            this.showBoats();
            this.getAllRents();
        }

        public void startSplashscreen()
        {
            Application.Run(new Splashscreen());
        }

        public void getAllBoats()
        {
            con.Open();
            cmd.CommandText = "SELECT * FROM boat";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                this.dbBoats.Add(new Boat(int.Parse(dr.GetString("id")), double.Parse(dr.GetString("weight")), int.Parse(dr.GetString("power")), double.Parse(dr.GetString("length")), double.Parse(dr.GetString("rent"))));
            }
            con.Close();
        }

        public void getAllRents()
        {
            con.Open();
            cmd.CommandText = "SELECT * FROM rent";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                this.dbRents.Add(new Rent(long.Parse(dr.GetString("id")),
                                            getBoatByNumber(int.Parse(dr.GetString("boat_id"))),
                                            DateTime.Parse(dr.GetString("start")),
                                            DateTime.Parse(dr.GetString("end")),
                                            int.Parse(dr.GetString("usedFuel")),
                                            DateTime.Parse(dr.GetString("date")),
                                            System.Convert.ToBoolean(dr.GetString("damage"))
                                            ));
            }
            con.Close();
        }

        public void showBoats()
        {

            if (this.dbBoats.Count >= 0)
            {
                foreach (Boat boat in dbBoats)
                {
                    boats.Text += $"Number: {boat.number}, Weight: {boat.weight}, Power: {boat.power}, Length: {boat.length}, Rent: {boat.rent}\n";
                    boatInput.Items.Add(boat.number);
                }


            }
            else
            {
                boats.Text = "No boats";
            }

        }

        public Boolean checkRentAvailable(int boatNumber, DateTime date)
        {
            Boolean available = true;

            foreach(Rent rent in dbRents)
            {
                if (rent.boat.number == boatNumber)
                {
                    bool res = DateTime.Equals(date, rent.rentDate);
                    if (res)
                    {
                        available = false;
                    }
                }
            }
            
            return available;

        }

        public void addRent(int boatNumber, DateTime start, DateTime end, int usedFuel, Boolean damage)
        {
            con.Open();
            cmd.CommandText = "INSERT INTO `rent`(`boat_id`, `start`, `end`, `usedFuel`, `date`, `damage`) VALUES (@boat_id, @start, @end, @usedFuel, @rentDate, @damage)";
            cmd.Parameters.AddWithValue("@boat_id", boatNumber);
            cmd.Parameters.AddWithValue("@start", start);
            cmd.Parameters.AddWithValue("@end", end);
            cmd.Parameters.AddWithValue("@usedFuel", usedFuel);
            cmd.Parameters.AddWithValue("@rentDate", DateTime.Now.Date);
            cmd.Parameters.AddWithValue("@damage", damage);
            cmd.Prepare();

            cmd.ExecuteNonQuery();
            Boat boat = getBoatByNumber(boatNumber);
            dbRents.Add(new Rent(cmd.LastInsertedId, boat, start, end, usedFuel, DateTime.Now.Date, damage));
            cmd.Parameters.Clear();
            con.Close();
        }

        private Boat getBoatByNumber(int number)
        {
            foreach(Boat boat in dbBoats)
            {
                if(boat.number == number)
                {
                    return boat;
                }
            }
            return null;
        }

        private void addRentButton_Click(object sender, EventArgs e)
        {
            

                string startStr = startInput.Text.ToString();
                string endStr = endInput.Text.ToString();
                string usedFuelStr = usedFuelInput.Text.ToString();
                int damageStr = damageInput.SelectedIndex;

                if (!string.IsNullOrEmpty(startStr) && !string.IsNullOrEmpty(endStr) && !string.IsNullOrEmpty(usedFuelStr) && boatInput.SelectedIndex != -1 && damageInput.SelectedIndex != -1)
                {

                    try
                    {
                        Boat boat = this.getBoatByNumber(int.Parse(boatInput.SelectedItem.ToString()));
                        DateTime start = DateTime.ParseExact(startStr, "HH:mm", null);
                        DateTime end = DateTime.ParseExact(endStr, "HH:mm", null);
                        int usedFuel = int.Parse(usedFuelStr);
                        Boolean damage = false;

                        switch (damageStr)
                        {
                            case 1:
                                damage = true;
                                break;
                            case 0:
                                damage = false;
                                break;
                        }

                        if (checkRentAvailable(boat.number, DateTime.Now.Date))
                        {
                            addRent(boat.number, start, end, usedFuel, damage);
                            MessageBox.Show("New rent added");
                        }
                        else
                        {
                            MessageBox.Show("Boat already rented out today");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }



                }
                else
                {
                    MessageBox.Show("Please fill all the forms in");
                }

        }

        private void totalRevenueButton_Click(object sender, EventArgs e)
        {
            double revenue = 0.0;
            foreach (Rent rent in dbRents)
            {
                revenue += rent.getRevenue(rent.boat.rent);
            }

            totalRevenue.Text += revenue;
        }

        private void totalRentTimeButton_Click(object sender, EventArgs e)
        {
            double totalTime = 0;
            foreach (Rent rent in dbRents)
            {
                totalTime += rent.calculateRentTime();
            }

            totalRentTime.Text = totalTime.ToString() + " minute";
        }

        private void mostConsumedButton_Click(object sender, EventArgs e)
        {
            int boat = 0;
            double mostConsumedFuel = 0.0;

            foreach (Rent rent in this.dbRents)
            {
                if (rent.usedFuel > mostConsumedFuel)
                {
                    boat = rent.boat.number;
                    mostConsumedFuel = rent.usedFuel;
                }
            }

            mostConsumed.Text += boat.ToString();
        }

        private void damageButton_Click(object sender, EventArgs e)
        {
            int totalRents = this.dbRents.Count;
            int totalDamage = 0;

            foreach (Rent rent in dbRents)
            {
                if (rent.damage)
                {
                    totalDamage++;
                }
            }

            totalDamageLabel.Text += (100 / totalRents * totalDamage) + " % are damage";
        }

        private void leastUsedButton_Click(object sender, EventArgs e)
        {
            int boatNumber = 0;
            int shortestTime = 1000;
            foreach (Rent rent in dbRents)
            {
                int compare = shortestTime.CompareTo(rent.calculateRentTime());
                if (rent.calculateRentTime() < shortestTime)
                {
                    boatNumber = rent.boat.number;
                    shortestTime = rent.calculateRentTime();
                }
            }

            leastUsed.Text += boatNumber.ToString();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.aboutBox.Show();
        }

        private void overviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(overviewTab);
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void rentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(rentTab);
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void boatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(boatTab);
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }
    }
}