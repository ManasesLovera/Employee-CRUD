using Microsoft.EntityFrameworkCore;
using UnidadVI.Data;
using UnidadVI.Models;

namespace UnidadVI
{
    public partial class Form1 : Form
    {
        private ApplicationDbContext? _context;
        private User _user = new User();
        public Form1()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            if (_context != null)
            {
                this._context.Users.Load();
                this.DGVEmployees.DataSource = _context.Users.Local.ToBindingList();
            }
        }
        private void Clear()
        {
            btnSave.Text = "Save";

            txtName.Text = String.Empty;
            txtAge.Text = String.Empty;
            txtSalary.Text = String.Empty;
            txtCity.Text = String.Empty;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //base.OnLoad(e);
            this._context = new ApplicationDbContext();
            this._context.Database.EnsureCreated();
            this._context.Users.Load();
            this.DGVEmployees.DataSource = _context.Users.Local.ToBindingList();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //base.OnClosing(e);
            this._context?.Dispose();
            this._context = null;
        }

        private void DGVEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex <= DGVEmployees.RowCount)
                {
                    DataGridViewRow selectedRow = DGVEmployees.Rows[e.RowIndex];

                    _user.Id = Convert.ToInt32(selectedRow.Cells[0].Value.ToString()!);
                    _user.Name = selectedRow.Cells[1].Value.ToString()!;
                    _user.Age = Convert.ToInt32(selectedRow.Cells[2].Value.ToString()!);
                    _user.Salary = Convert.ToDecimal(selectedRow.Cells[3].Value.ToString()!);
                    _user.City = selectedRow.Cells[4].Value.ToString()!;

                    txtName.Text = _user.Name;
                    txtAge.Text = _user.Age.ToString();
                    txtSalary.Text = _user.Salary.ToString();
                    txtCity.Text = _user.City;

                    btnSave.Text = "Update";
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Null reference!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_user.Id > 0 && _context != null)
            {
                var user = _context.Users.Find(_user.Id);
                if (user != null)
                {
                    _context.Users.Remove(user);
                    _context.SaveChanges();
                    MessageBox.Show("Usuario eliminado correctamente.", "Exito!", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Usuario no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Id no es valido, o hay un error con la base de datos, vuelve a abrir la aplicacion.");
            }

            this.Clear();
            this.LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnSave.Text == "Save")
                {
                    if (!String.IsNullOrWhiteSpace(txtName.Text) && !String.IsNullOrWhiteSpace(txtAge.Text) &&
                        !String.IsNullOrWhiteSpace(txtSalary.Text) && !String.IsNullOrWhiteSpace(txtCity.Text))
                    {
                        User newUser = new User(txtName.Text, int.Parse(txtAge.Text), Convert.ToDecimal(txtSalary.Text), txtCity.Text);
                        _context!.Users.Add(newUser);
                        _context!.SaveChanges();

                        MessageBox.Show("Se agrego correctamente");

                        this.Clear();
                    }
                }
                else if (btnSave.Text == "Update" && _context != null)
                {
                    if (!String.IsNullOrWhiteSpace(txtName.Text) && !String.IsNullOrWhiteSpace(txtAge.Text) &&
                        !String.IsNullOrWhiteSpace(txtSalary.Text) && !String.IsNullOrWhiteSpace(txtCity.Text))
                    {
                        User user = _context.Users.Find(_user.Id)!;
                        
                        if (user == null)
                        {
                            MessageBox.Show("Hubo un error! El usuario no se encontro!"); return;
                        }
                        user.Name = txtName.Text;
                        user.Age = int.Parse(txtAge.Text);
                        user.Salary = Convert.ToDecimal(txtSalary.Text);
                        user.City = txtCity.Text;
                        
                        _context!.SaveChanges();

                        MessageBox.Show("Se modifico correctamente");

                        this.Clear();
                    }
                }
                this.LoadData();
            }
            catch (FormatException)
            {
                MessageBox.Show("Se han insertado valores en formato de valor incorrecto, revisa los textbox");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
