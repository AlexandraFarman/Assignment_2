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
        private IEstateController estateController;
        private IAddressController addressController;


        public Form1()
        {
            estateController = new EstateController();
            addressController = new AddressController();
            InitializeComponent();
            comboBoxCountries.DataSource = Enum.GetValues(typeof(Countries));
            comboBoxCountry.DataSource = Enum.GetValues(typeof(Countries));
            comboBoxCountryChange.DataSource= Enum.GetValues(typeof(Countries));
            comboBoxLegalForm.DataSource = Enum.GetValues(typeof(LegalForm));
            comboBoxChangeLegalForm.DataSource = Enum.GetValues(typeof(LegalForm));
            comboBoxAddLegalForm.DataSource = Enum.GetValues(typeof(LegalForm));
            comboBoxType.DataSource = estateController.GetEstateTypes();
            comboBoxAddType.DataSource = estateController.GetEstateTypes();
            comboBoxChangeType.DataSource = estateController.GetEstateTypes();

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

            }
            else
            {
                Estate estate = (Estate)comboBoxType.SelectedItem;
                estate.EstateId = textBoxEstateId.Text;
                estate.LegalForm = (LegalForm)comboBoxAddLegalForm.SelectedItem;
                estate.Address = (Address)comboBoxAddAddressToEstate.SelectedItem;
                bool estateIsAdded = estateController.AddEstate(estate);
                if (estateIsAdded)
                {
                    System.Windows.Forms.MessageBox.Show("House is added.");
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("An error occured when trying to add the house.");
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
                String.IsNullOrEmpty(comboBoxCountries.Text))
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
                if (String.IsNullOrEmpty(comboBoxCountries.Text))
                {
                    errorMessage += " Country";
                }
                errorMessage += " must be specified.";
                System.Windows.Forms.MessageBox.Show(errorMessage);
            }
            else
            {
                bool addressIsAdded = addressController.AddAddress(new Address(textBoxStreet.Text, textBoxCity.Text,
                textBoxZipCode.Text, (Countries)comboBoxCountries.SelectedItem));
                if (addressIsAdded)
                {
                    System.Windows.Forms.MessageBox.Show("Address is added.");
                }
                else
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
            }
            else
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
            }
            else
            {
                if (comboBoxType.Text.Equals("House"))
                {
                    House house = new House((LegalForm)comboBoxAddLegalForm.SelectedItem, (Address)comboBoxAddAddressToEstate.SelectedItem, textBoxEstateId.Text);
                    bool houseIsUpdated = estateController.UpdateEstate(house);
                    if (houseIsUpdated)
                    {
                        System.Windows.Forms.MessageBox.Show("House is updated.");
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("An error occured when trying to update the house.");
                    }
                }
                else if (comboBoxType.Text.Equals("Villa"))
                {
                    Villa villa = new Villa((LegalForm)comboBoxAddLegalForm.SelectedItem, (Address)comboBoxAddAddressToEstate.SelectedItem, textBoxEstateId.Text);
                    bool villaIsUpdated = estateController.UpdateEstate(villa);
                    if (villaIsUpdated)
                    {
                        System.Windows.Forms.MessageBox.Show(" Villa is added.");
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("An error occured when trying to update the villa.");
                    }
                }
                else if (comboBoxType.Text.Equals("Apartment"))
                {
                    Apartment apartment = new Apartment((LegalForm)comboBoxAddLegalForm.SelectedItem, (Address)comboBoxAddAddressToEstate.SelectedItem, textBoxEstateId.Text);
                    bool apartmentIsUpdated = estateController.UpdateEstate(apartment);
                    if (apartmentIsUpdated)
                    {
                        System.Windows.Forms.MessageBox.Show("Apartment is updated.");
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("An error occured when trying to update the apartment.");
                    }
                }
                else if (comboBoxType.Text.Equals("Townhouse"))
                {
                    Townhouse townhouse = new Townhouse((LegalForm)comboBoxAddLegalForm.SelectedItem, (Address)comboBoxAddAddressToEstate.SelectedItem, textBoxEstateId.Text);
                    bool townhouseIsUpdated = estateController.UpdateEstate(townhouse);
                    if (townhouseIsUpdated)
                    {
                        System.Windows.Forms.MessageBox.Show("Townhouse is updated.");
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("An error occured when trying to update the Townhouse.");
                    }
                }
                else if (comboBoxType.Text.Equals("Shop"))
                {
                    Shop shop = new Shop((LegalForm)comboBoxAddLegalForm.SelectedItem, (Address)comboBoxAddAddressToEstate.SelectedItem, textBoxEstateId.Text);
                    bool shopIsUpdated = estateController.UpdateEstate(shop);
                    if (shopIsUpdated)
                    {
                        System.Windows.Forms.MessageBox.Show("Shop is updated.");
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("An error occured when trying to update the shop.");
                    }
                }
                else if (comboBoxType.Text.Equals("Warehouse"))
                {
                    Warehouse warehouse = new Warehouse((LegalForm)comboBoxAddLegalForm.SelectedItem, (Address)comboBoxAddAddressToEstate.SelectedItem, textBoxEstateId.Text);
                    bool warehouseIsUpdated = estateController.UpdateEstate(warehouse);
                    if (warehouseIsUpdated)
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

        private void buttonChangeAddress_Click(object sender, EventArgs e)
        {
            // If one of the fields are not filled in
            if (String.IsNullOrEmpty(textBoxStreetChange.Text) || String.IsNullOrEmpty(textBoxCityChange.Text) ||
                String.IsNullOrEmpty(textBoxZipCodeChange.Text) || String.IsNullOrEmpty(textBoxZipCodeChange.Text) ||
                String.IsNullOrEmpty(comboBoxCountryChange.Text))
            {
                string errorMessage = "";
                if (String.IsNullOrEmpty(textBoxStreetChange.Text))
                {
                    errorMessage = "Street";
                }
                if (String.IsNullOrEmpty(textBoxCityChange.Text))
                {
                    errorMessage += " City";
                }
                if (String.IsNullOrEmpty(textBoxZipCodeChange.Text))
                {
                    errorMessage += " Zip Code";
                }
                if (String.IsNullOrEmpty(comboBoxCountryChange.Text))
                {
                    errorMessage += " Country";
                }
                errorMessage += " must be specified.";
                System.Windows.Forms.MessageBox.Show(errorMessage);
            }
            else
            {
                bool addressIsUpdated = addressController.UpdateAddress(new Address(textBoxStreet.Text, textBoxCity.Text,
                textBoxZipCode.Text, (Countries)comboBoxCountries.SelectedItem));
                if (addressIsUpdated)
                {
                    System.Windows.Forms.MessageBox.Show("Address is updated.");
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("An error occured when trying to update the address.");
                }
            }
        }
    }
}

