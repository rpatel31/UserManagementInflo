using MyApp.Models;
using MyApp.Services.Factories.Implementations;
using MyApp.Services.Factories.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApp.WinForm
{
    public partial class AddEditUser : Form
    {
        protected readonly int UserId;
        protected readonly Main Main;
        protected readonly IServiceFactory ServiceFactory;

        private static readonly Regex _nameRegex = new Regex("^[\\w'\\-,.][^0-9_!¡?÷?¿/\\\\+=@#$%ˆ&*(){}|~<>;:[\\]]{2,}$");

        private bool IsEditMode;
        public AddEditUser(Main main, IServiceFactory serviceFactory)
        {

            IsEditMode = false;
            Main = main;
            ServiceFactory = serviceFactory;
            InitializeComponent();

            this.Text = "Create User";
            lblCreateEditTitle.Text = "Create New User";

        }


        public AddEditUser(Main main, IServiceFactory serviceFactory, int userId)
        {
            UserId = userId;
            Main = main;
            ServiceFactory = serviceFactory;
            InitializeComponent();
            PopulateUserFields();
            IsEditMode = true;

            this.Text = "Edit User";

            lblCreateEditTitle.Text = "Edit User";

        }

        private void PopulateUserFields()
        {
            // Get the user by the ID
            var user = ServiceFactory.UserService.GetById(UserId);

            if (user != null) // If we have a user then show their details
            {
                txtBoxForename.Text = user.Forename;
                txtBoxSurname.Text = user.Surname;

                dtpDOB.Value = user.DateOfBirth;
                cbActive.SelectedIndex = user.IsActive ? 0 : 1;


            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Main.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (ValidateChildren(ValidationConstraints.Enabled))
            {

                if (IsEditMode)
                {
                    //get userbyId
                    var user = ServiceFactory.UserService.GetById(UserId);
                    //get updated values 
                    user.Forename = txtBoxForename.Text.Trim();
                    user.Surname = txtBoxSurname.Text.Trim();
                    user.DateOfBirth = dtpDOB.Value.Date;
                    user.IsActive = cbActive.SelectedIndex == 0 ? true : false;

                    //update record
                    ServiceFactory.UserService.Update(user);

                }
                else
                {
                    //adding new record
                    var newUser = new User
                    {
                        Forename = txtBoxForename.Text.Trim(),
                        Surname = txtBoxSurname.Text.Trim(),
                        DateOfBirth = dtpDOB.Value.Date,
                        IsActive = true,


                    };



                    ServiceFactory.UserService.Create(newUser);
                }

                //close the form 
                this.Close();
            }

        }

        private void txtBoxForename_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxForename.Text))
            {
                e.Cancel = true;
                txtBoxForename.Focus();
                errorProviderForename.SetError(txtBoxForename, "Required. Please enter a Name");
            }
            else if (!ValidateCharactersInName(txtBoxForename.Text))
            {
                e.Cancel = true;
                txtBoxForename.Focus();
                errorProviderForename.SetError(txtBoxForename, "Please Enter letters only");
            }
            else
            {

                e.Cancel = false;
                errorProviderForename.SetError(txtBoxForename, "");
            }
        }

        private void txtBoxSurname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxSurname.Text))
            {
                e.Cancel = true;
                txtBoxSurname.Focus();
                errorProviderSurname.SetError(txtBoxSurname, "Required. Please enter a Name");
            }
            else if (!ValidateCharactersInName(txtBoxSurname.Text))
            {
                e.Cancel = true;
                txtBoxSurname.Focus();
                errorProviderSurname.SetError(txtBoxSurname, "Please Enter letters only");
            }
            else
            {
                e.Cancel = false;
                errorProviderSurname.SetError(txtBoxSurname, "");
            }

        }



        /// <summary>
        ///Checks if name has valid characters and doesnt contain any invlaid special characters
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private bool ValidateCharactersInName(string name)
        {
            return _nameRegex.IsMatch(name);
        }

        /// <summary>
        /// Checks if a Account Active status is set, if not display error 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbActive_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbActive.Text))
            {
                e.Cancel = true;
                cbActive.Focus();
                errorProviderActiveDropdown.SetError(cbActive, "Please Select a Status");
            }
        }

        private void dtpDOB_Validating(object sender, CancelEventArgs e)
        {
            //if the date of birth is in future show error
            if(dtpDOB.Value.Date > DateTime.Today)
            {
                e.Cancel = true;
                dtpDOB.Focus();
                errorProviderDOB.SetError(dtpDOB, "Date cannot be in the future");
            }
        }
    }
}
