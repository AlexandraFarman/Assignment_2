using BLL.Controllers;
using HomesForSales.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomesForSales
{
    public partial class Form1 : Form
    {
        private IHouseController houseController;
        private IVillaController villaController;
        private IApartmentController apartmentController;
        private ITownhouseController townhouseController;
        public IShopController shopController;
        public IWarehouseController warehouseController;
        private IAddressController addressController;


        public Form1()
        {
            houseController = new HouseController();
            villaController = new VillaController();
            apartmentController = new ApartmentController();
            townhouseController = new TownhouseController();
            shopController = new ShopController();
            warehouseController = new WarehouseController();
            addressController = new AddressController();
            InitializeComponent();
        }

        private void lblAddress_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddEstate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxEstateId.Text) || String.IsNullOrEmpty(comboBoxAddLegalForm.Text)
                || String.IsNullOrEmpty(comboBoxAddCategory.Text) || String.IsNullOrEmpty(comboBoxAddType.Text)
                || String.IsNullOrEmpty(comboBoxAddAddressToEstate.Text) || String.IsNullOrEmpty(comboBoxAddAddressToEstate.Text))
            {
                string errorMessage = "";
                if (String.IsNullOrEmpty(textBoxEstateId.Text))
                {
                    errorMessage = "Estate Id";
                }
                if (String.IsNullOrEmpty(comboBoxAddLegalForm.Text))
                {
                    errorMessage += " Legal form";
                }
                if (String.IsNullOrEmpty(comboBoxAddCategory.Text))
                {
                    errorMessage += " Category";
                }
                if (String.IsNullOrEmpty(comboBoxAddType.Text))
                {
                    errorMessage += " Type";
                }
                if (String.IsNullOrEmpty(comboBoxAddAddressToEstate.Text))
                {
                    errorMessage += " Address";
                }
                errorMessage += " must be specified.";
                System.Windows.Forms.MessageBox.Show(errorMessage);

            } else
            {
                if (comboBoxType.Text.Equals("House"))
                {
                    bool houseIsAdded = houseController.AddHouse(textBoxEstateId.Text, comboBoxAddLegalForm.Text, comboBoxAddAddressToEstate.Text);
                    if (houseIsAdded)
                    {
                        System.Windows.Forms.MessageBox.Show("House is added.");
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("An error occured when trying to add the house.");
                    }
                }
                else if (comboBoxType.Text.Equals("Villa"))
                {
                    bool villaIsAdded = villaController.AddVilla(textBoxEstateId.Text, comboBoxAddLegalForm.Text, comboBoxAddAddressToEstate.Text);
                    if (villaIsAdded)
                    {
                        System.Windows.Forms.MessageBox.Show(" Villa is added.");
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("An error occured when trying to add the villa.");
                    }
                }
                else if (comboBoxType.Text.Equals("Apartment"))
                {
                    bool apartmentIsAdded = apartmentController.AddApartment(textBoxEstateId.Text, comboBoxAddLegalForm.Text, comboBoxAddAddressToEstate.Text);
                    if (apartmentIsAdded)
                    {
                        System.Windows.Forms.MessageBox.Show("Apartment is added.");
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("An error occured when trying to add the apartment.");
                    }
                }
                else if (comboBoxType.Text.Equals("Townhouse"))
                {
                    bool townhouseIsAdded = townhouseController.AddTownhouse(textBoxEstateId.Text, comboBoxAddLegalForm.Text, comboBoxAddAddressToEstate.Text);
                    if (townhouseIsAdded)
                    {
                        System.Windows.Forms.MessageBox.Show("Townhouse is added.");
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("An error occured when trying to add the Townhouse.");
                    }
                }
                else if (comboBoxType.Text.Equals("Shop"))
                {
                    bool shopIsAdded = shopController.AddShop(textBoxEstateId.Text, comboBoxAddLegalForm.Text, comboBoxAddAddressToEstate.Text);
                    if (shopIsAdded)
                    {
                        System.Windows.Forms.MessageBox.Show("Shop is added.");
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("An error occured when trying to add the shop.");
                    }
                }
                else if (comboBoxType.Text.Equals("Warehouse"))
                {
                    bool warehouseIsAdded = warehouseController.AddWarehouse(textBoxEstateId.Text, comboBoxAddLegalForm.Text, comboBoxAddAddressToEstate.Text);
                    if (warehouseIsAdded)
                    {
                        System.Windows.Forms.MessageBox.Show("Warehouse is added.");
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("An error occured when trying to add the Warehouse.");
                    }
                }
            }

        }

        private void textBoxCategory_TextChanged(object sender, EventArgs e)
        {
        }

        private void tabAdd_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEstateId_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddNewAddress_Click(object sender, EventArgs e)
        {
            // If one of the fields are not filled in
            if (String.IsNullOrEmpty(textBoxStreet.Text) || String.IsNullOrEmpty(textBoxCity.Text) || 
                String.IsNullOrEmpty(textBoxZipCode.Text) || String.IsNullOrEmpty(textBoxZipCode.Text) || 
                String.IsNullOrEmpty(comboBoxCountry.Text))
            {
                string errorMessage = "";
                if (String.IsNullOrEmpty(textBoxStreet.Text))
                {
                    errorMessage = "Street";
                }
                if (String.IsNullOrEmpty(textBoxCity.Text))
                {
                    errorMessage += " City";
                }
                if (String.IsNullOrEmpty(textBoxZipCode.Text))
                {
                    errorMessage += " Zip Code";
                }
                if (String.IsNullOrEmpty(comboBoxCountry.Text))
                {
                    errorMessage += " Country";
                }
                errorMessage += " must be specified.";
                System.Windows.Forms.MessageBox.Show(errorMessage);
            } else
            {
                bool addressIsAdded = addressController.AddAddress(textBoxStreet.Text, textBoxCity.Text,
                textBoxZipCode.Text, comboBoxCountries.Text);
                if (addressIsAdded)
                {
                    System.Windows.Forms.MessageBox.Show("Address is added.");
                } else
                {
                    System.Windows.Forms.MessageBox.Show("An error occured when trying to add the address.");
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(comboBoxChangeEstateId.Text))
            {
                System.Windows.Forms.MessageBox.Show("Please choose an Estate Id for the Estate to be deleted!");
            } else
            {
                
            }
        }

        private void buttonChangeEstate_Click(object sender, EventArgs e)
        {
            // If one of the fields are not filled in
            if (String.IsNullOrEmpty(comboBoxChangeEstateId.Text) || String.IsNullOrEmpty(comboBoxChangeLegalForm.Text) ||
                String.IsNullOrEmpty(comboBoxChangeCategory.Text) || String.IsNullOrEmpty(comboBoxChangeType.Text) ||
                String.IsNullOrEmpty(comboBoxChangeAddressForEstate.Text))
            {
                string errorMessage = "";
                if (String.IsNullOrEmpty(comboBoxChangeEstateId.Text))
                {
                    errorMessage = "EstateId";
                }
                if (String.IsNullOrEmpty(comboBoxChangeLegalForm.Text))
                {
                    errorMessage += " Legal Form";
                }
                if (String.IsNullOrEmpty(comboBoxChangeCategory.Text))
                {
                    errorMessage += " Category";
                }
                if (String.IsNullOrEmpty(comboBoxChangeType.Text))
                {
                    errorMessage += " Type";
                }
                if (String.IsNullOrEmpty(comboBoxChangeAddressForEstate.Text))
                {
                    errorMessage += " Address";
                }
                errorMessage += " must be specified.";
                System.Windows.Forms.MessageBox.Show(errorMessage);
            } else {

                bool estateIsChanged = addressController.AddAddress(textBoxStreet.Text, textBoxCity.Text,
                textBoxZipCode.Text, comboBoxCountries.Text);
                if (addressIsAdded)
                {
                    System.Windows.Forms.MessageBox.Show("Address is added.");
                } else
                {
                    System.Windows.Forms.MessageBox.Show("An error occured when trying to add the address.");
                }
            }
        }
        }
    }
}
