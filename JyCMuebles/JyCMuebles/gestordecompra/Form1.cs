using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;

namespace TP_3
{
    public partial class Form1 : Form
    {
        List<Marca> Marcas = new List<Marca>();
        List<Pais> Paises = new List<Pais>();
        List<Producto> Productos = new List<Producto>();

        List<Producto> Searched = new List<Producto>();

        BindingSource datasource = new BindingSource();

        int SelectedRow = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_AddCountry_Click(object sender, EventArgs e)
        {
            if (txtb_Country.Text.Trim() == "")
            {
                MessageBox.Show("No se pudo ingresar el país.\nNingun dato ingresado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (CountryExists(txtb_Country.Text))
            {
                MessageBox.Show("No se pudo ingresar el país.\nYa existe un país con ese nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Paises.Add(new Pais(txtb_Country.Text.Trim()));
                cbx_Country.Items.Add(Paises[Paises.Count - 1].ToString());
            }
        }

        private void btn_AddBrand_Click(object sender, EventArgs e)
        {
            if (txtb_Brand.Text.Trim() == "")
            {
                MessageBox.Show("No se pudo ingresar la marca.\nNingun dato ingresado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (BrandExists(txtb_Brand.Text))
            {
                MessageBox.Show("No se pudo ingresar la marca.\nYa existe una marca con ese nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Marcas.Add(new Marca(txtb_Brand.Text.Trim()));
                cbx_Brand.Items.Add(Marcas[Marcas.Count - 1].ToString());
            }
        }

        private void btn_Product_Click(object sender, EventArgs e)
        {
            bool insert = true;
            string error = "No se pudo ingresar el producto. Error/es:";

            if (CodeExists(Convert.ToInt32(nud_Code.Value)))
            {
                insert = false;
                error += "\n- El codigo ingresado ya le pertenece a otro producto.";
            }
            if (txtb_Model.Text.Trim() == "")
            {
                insert = false;
                error += "\n- Ningun dato ingresado en \"Modelo\".";
            }
            if (txtb_Desc.Text.Trim() == "")
            {
                insert = false;
                error += "\n- Ningun dato ingresado en \"Descripción\".";
            }
            if (cbx_Brand.Text.Trim() == "")
            {
                insert = false;
                error += "\n- Ninguna marca seleccionada.";
            }
            if (cbx_Country.Text.Trim() == "")
            {
                insert = false;
                error += "\n- Ningun país seleccionado.";
            }
            if (insert)
            {
                Productos.Add(new Producto(Convert.ToInt32(nud_Code.Value), txtb_Model.Text.Trim(), txtb_Desc.Text, Convert.ToSingle(nud_Cost.Value), Convert.ToSingle(nud_UnitPrice.Value), Convert.ToSingle(nud_MayorPrice.Value), cbx_Brand.Text, Convert.ToInt32(nud_MayorCant.Value), cbx_Country.Text, Convert.ToInt32(nud_Warranty.Value)));
            }
            else
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            UpdateData();
        }

        private void UpdateData()
        {
            if (Productos.Count == 0)
            {
                dgv_Prods.DataSource = null;
            }
            else
            {
                dgv_Prods.DataSource = null;
                if (txtb_Search.Text == "")
                {
                    Searched.Clear();
                    datasource.DataSource = Productos;
                }
                else
                {
                    Searched = Productos.Where(x => x.Desc.Contains(txtb_Search.Text.Trim())).ToList();

                    datasource.DataSource = Searched;
                }

                dgv_Prods.DataSource = datasource;
            }
        }

        private bool CodeExists(int auxCode)
        {
            bool exists = false;

            for (int i = 0; i < Productos.Count && !exists; i++)
            {
                if (Productos[i].Code == auxCode)
                {
                    exists = !exists;
                }
            }

            return exists;
        }

        private bool CountryExists(string auxCountry)
        {
            bool exists = false;

            for (int i = 0; i < Paises.Count && !exists; i++)
            {
                if (Paises[i].Name == auxCountry)
                {
                    exists = !exists;
                }
            }

            return exists;
        }

        private bool BrandExists(string auxBrand)
        {
            bool exists = false;

            for (int i = 0; i < Marcas.Count && !exists; i++)
            {
                if (Marcas[i].Name == auxBrand)
                {
                    exists = !exists;
                }
            }

            return exists;
        }

        private void dgv_Prods_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int SelectedRow = e.RowIndex;
        }

        private float CalculateSale()
        {
            int Cant = Convert.ToInt32(nud_Quantity.Value);

            int UnitCant = Cant % Productos[SelectedRow].MayorCant;

            int MayorCant = Cant - UnitCant;

            float TotalSale = Convert.ToSingle(UnitCant) * Productos[SelectedRow].UnitPrice + Convert.ToSingle(MayorCant) * Productos[SelectedRow].MayorPrice;
            return TotalSale;
        }

        private void btn_CalcSale_Click(object sender, EventArgs e)
        {
            if (Productos.Count > 0)
            {
                lbl_Sale.Text = "$ " + CalculateSale().ToString();
                lbl_Sale.ForeColor = Color.Green;
            }
            else
            {
                lbl_Sale.Text = "$";
                lbl_Sale.ForeColor = Color.Black;

                MessageBox.Show("No se ha ingresado o seleccionado ningun producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_CalcProfit_Click(object sender, EventArgs e)
        {
            if (Productos.Count > 0)
            {
                float Cost = Productos[SelectedRow].Cost * Convert.ToSingle(nud_Quantity.Value);

                float Profit = CalculateSale() - Cost;
                lbl_Profit.Text = "$ " + Profit;
                if (Profit > 0)
                {
                    lbl_Profit.ForeColor = Color.Green;
                }
                else if (Profit < 0)
                {
                    lbl_Profit.ForeColor = Color.Red;
                }
                else
                {
                    lbl_Profit.ForeColor = Color.Black;
                }
            }
            else
            {
                lbl_Profit.Text = "$";
                lbl_Profit.ForeColor = Color.Black;

                MessageBox.Show("No se ha ingresado ningun producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_ShowProd_Click(object sender, EventArgs e)
        {
            if (Productos.Count > 0)
            {
                string Message = "Codigo: " + Productos[SelectedRow].Code;
                Message += "\nModelo: " + Productos[SelectedRow].Model;
                Message += "\nDescripción: " + Productos[SelectedRow].Desc;
                Message += "\nPrecio Venta Minorista: " + Productos[SelectedRow].UnitPrice;
                Message += "\nPrecio Venta Mayorista: " + Productos[SelectedRow].MayorPrice;
                Message += "\nMarca: " + Productos[SelectedRow].Brand;
                Message += "\nOrigen: " + Productos[SelectedRow].Country;
                Message += "\nCantidad Mayorista: " + Productos[SelectedRow].MayorCant;
                Message += "\nGarantia (En Meses): " + Productos[SelectedRow].Warranty;

                MessageBox.Show(Message, "Producto");
            }
            else
            {
                MessageBox.Show("No se ha ingresado ningun producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            UpdateData();
        }
    }
}
