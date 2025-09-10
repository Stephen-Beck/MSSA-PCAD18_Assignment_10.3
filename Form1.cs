using Assignment_10._3.Data;
using Assignment_10._3.Services;

namespace Assignment_10._3
{
    public partial class Form1 : Form
    {
        CRUD crud = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = crud.GetAllCars();
            dataGridView1.Columns["Dealership"].Visible = false;
            dataGridView1.Columns["Price"].DefaultCellStyle.Format = "C0";
            dataGridView1.AutoResizeColumns();
            txtVIN.ReadOnly = true;
            btnSubmit.Enabled = false;
            btnUpdate.Enabled = false;
            foreach (var dealership in crud.GetAllDealerships())
            {
                cmbDealership.Items.Add(dealership.DealershipName);
            }
        }
        private void RefreshDataSource()
        {
            dataGridView1.DataSource = crud.GetAllCars();
        }
        private string GetVIN()
        {
            return dataGridView1.CurrentRow.Cells["VIN"].Value.ToString();
        }
        private bool IsCompleteRecord()
        {
            return
                !string.IsNullOrEmpty(txtVIN.Text) &&
                !string.IsNullOrEmpty(txtYear.Text) &&
                !string.IsNullOrEmpty(txtMake.Text) &&
                !string.IsNullOrEmpty(txtModel.Text) &&
                !string.IsNullOrEmpty(txtColor.Text) &&
                !string.IsNullOrEmpty(txtPrice.Text) &&
                cmbDealership.SelectedIndex != -1;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtVIN.Text = CarContext.GenerateVIN();
            txtVIN.ReadOnly = true;
            txtYear.Clear();
            txtMake.Clear();
            txtModel.Clear();
            txtColor.Clear();
            txtPrice.Clear();
            cmbDealership.SelectedIndex = -1;
            btnSubmit.Enabled = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (IsCompleteRecord())
            {
                Models.Car car = new Models.Car()
                {
                    VIN = txtVIN.Text,
                    Year = Convert.ToInt32(txtYear.Text),
                    Make = txtMake.Text,
                    Model = txtModel.Text,
                    Color = txtColor.Text,
                    Price = Convert.ToDouble(txtPrice.Text),
                    DealershipID = cmbDealership.SelectedIndex + 1
                };

                crud.AddCar(car);
                RefreshDataSource();
                btnSubmit.Enabled = false;
                txtVIN.ReadOnly = false;

                MessageBox.Show("Record added successfully");
            }
            else MessageBox.Show("Please fill all fields");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var vin = GetVIN();
            crud.DeleteCar(vin);
            RefreshDataSource();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            var vin = GetVIN();
            var car = crud.GetCarByVIN(vin);

            if (car != null)
            {
                txtVIN.Text = car.VIN;
                txtYear.Text = car.Year.ToString();
                txtMake.Text = car.Make;
                txtModel.Text = car.Model;
                txtColor.Text = car.Color;
                txtPrice.Text = car.Price.ToString();
                cmbDealership.SelectedIndex = car.DealershipID - 1;

                btnUpdate.Enabled = true;
                btnSubmit.Enabled = false;
                txtVIN.ReadOnly = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (IsCompleteRecord())
            {
                var vin = txtVIN.Text;
                var carToUpdate = crud.GetCarByVIN(vin);
                carToUpdate.Year = Convert.ToInt32(txtYear.Text);
                carToUpdate.Make = txtMake.Text;
                carToUpdate.Model = txtModel.Text;
                carToUpdate.Color = txtColor.Text;
                carToUpdate.Price = Convert.ToDouble(txtPrice.Text);
                carToUpdate.DealershipID = cmbDealership.SelectedIndex + 1;

                crud.UpdateCar(vin, carToUpdate);
                RefreshDataSource();
                btnUpdate.Enabled = true;

                MessageBox.Show("Record updated successfully");
            }
            else MessageBox.Show("Please fill all fields");
        }
    }
}
