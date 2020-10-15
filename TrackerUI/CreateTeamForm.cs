using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace CreateTeamForm
{
    public partial class CreateTeamForm : Form
    {
        private List<PersonModel> avaliableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();

        public CreateTeamForm()
        {
            InitializeComponent();

            //CreateSampleData();                                           //Makes a sample template for the Lists (WireUpLists)

            WireUpLists();
        }

        private void CreateSampleData()                                     //temporary fake list
        {
            avaliableTeamMembers.Add(new PersonModel { FirstName = "Tim", LastName = "Corey" });
            avaliableTeamMembers.Add(new PersonModel { FirstName = "Sue", LastName = "Storm" });


            selectedTeamMembers.Add(new PersonModel { FirstName = "Jane", LastName = "Jones" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Max", LastName = "Smith" });
        }

        private void WireUpLists()
        {
            //TODO- Better way to do a data binding
            //TODO- See if the Box clears out everything in the Team list if nothing is present in the dropdown and Add Member button is pressed
           
            selectTeamMemberDropdown.DataSource = null;                     //sets the data source for select team member dropdown to Null before starting

            selectTeamMemberDropdown.DataSource = avaliableTeamMembers;
            selectTeamMemberDropdown.DisplayMember = "FullName";            //found in PersonModel: return $"{ FirstName } { LastName }";

            teamMembersListBox.DataSource = null;                           //sets the data source for Members list to Null before starting

            teamMembersListBox.DataSource = selectedTeamMembers;
            teamMembersListBox.DisplayMember = "FullName";                  //found in PersonModel: return $"{ FirstName } { LastName }";


        }

        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel();

                    p.FirstName = firstNameValue.Text;
                    p.LastName = lastNameValue.Text;
                    p.EmailAddress = emailValue.Text;
                    p.PhoneNumber = cellphoneValue.Text;

                    p = GlobalConfig.Connection.CreatePerson(p);

                    selectedTeamMembers.Add(p);                           //adds newly created member to Team members list

                    WireUpLists();

                firstNameValue.Text = "";
                    lastNameValue.Text = "";
                    emailValue.Text = "";
                    cellphoneValue.Text = "";
            }
        }


        private bool ValidateForm()
        {
            if(firstNameValue.Text.Length == 0)
            {
                MessageBox.Show("Missing First Name.");
                return false;
            }

            if (lastNameValue.Text.Length == 0)
            {
                MessageBox.Show("Missing Last Name.");
                return false;
            }

            if (emailValue.Text.Length == 0)
            {
                MessageBox.Show("Missing Email.");
                return false;
            }

            if (cellphoneValue.Text.Length == 0)
            {
                return false;
            }

            return true;
        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)selectTeamMemberDropdown.SelectedItem;  //casts the person model list into the dropdown
           
            if (p != null)
            {
                avaliableTeamMembers.Remove(p);                                     //removes team members from the avaliable list.
                selectedTeamMembers.Add(p);                                         //adds team member to Team members list

                WireUpLists();
            }
        }

        private void removeMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)teamMembersListBox.SelectedItem;       //casts the person model list into the team member list box

            if (p != null)
            {
                avaliableTeamMembers.Add(p);                                        //adds team members from the avaliable list.
                selectedTeamMembers.Remove(p);                                      //removes team member to Team members list

                WireUpLists();
            }
        }
    }
}
