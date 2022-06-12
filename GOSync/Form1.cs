using CsvHelper;
using CsvHelper.Configuration.Attributes;
using GOSync.Models;
using Microsoft.Office.Interop.Outlook;
using System.Globalization;

namespace GOSync
{
    public partial class Form1 : Form
    {

        private List<OutlookContact> Contacts = new List<OutlookContact>();

        public Form1()
        {
            InitializeComponent();
        }


        private List<OutlookContact> OpenCsvFromFile()
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "CSV-Files|*.csv";
            ofd.Multiselect = false;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using (var reader = new StreamReader(ofd.FileName))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var records = csv.GetRecords<OutlookContact>();
                    return records.ToList();
                }
            }
            return new List<OutlookContact>();
        }

        private void FillLv(List<OutlookContact> contacts)
        {
            LV.BeginUpdate();
            LV.Items.Clear();

            if (contacts.Count > 0)
            {
                var props = contacts[0].GetType().GetProperties().ToList();

                int i = 0;
                foreach (var contact in contacts)
                {
                    var lvi = new ListViewItem();

                    var overallSucc = true;
                    foreach (ColumnHeader column in LV.Columns)
                    {
                        if (column.Index != 0)
                        {
                            var succ = SearchColumnAndEnterData(column, LV, props, contact, lvi);
                            overallSucc = overallSucc && succ;
                        }
                    }

                    if (overallSucc)
                    {
                        i++;
                        lvi.Text = i.ToString();
                        lvi.Tag = contact;
                        LV.Items.Add(lvi);
                    }
                    else
                    {
                        MessageBox.Show($"No entry was added for '{contact.FirstName} {contact.LastName}'");
                    }
                }
            }

            LV.EndUpdate();
        }




        private bool SearchColumnAndEnterData(ColumnHeader column, ListView LV, List<System.Reflection.PropertyInfo> props, OutlookContact contact, ListViewItem lvi)
        {
            foreach (var prop in props)
            {
                var cAttrs = prop.GetCustomAttributes(true);
                foreach (var attr in cAttrs)
                {
                    NameAttribute? nAttr = attr as NameAttribute;
                    if (nAttr != null)
                    {
                        if (nAttr.Names.Contains(column.Text))
                        {
                            var pVal = prop.GetValue(contact);
                            if (pVal != null)
                            {
                                lvi.SubItems.Add(pVal.ToString());
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }


        private bool AddContact(OutlookContact contact)
        {
            try
            {
                Microsoft.Office.Interop.Outlook.Application outlookObj = new Microsoft.Office.Interop.Outlook.Application();
                MAPIFolder Folder_Contacts = outlookObj.Session.GetDefaultFolder(OlDefaultFolders.olFolderContacts);
                Items ExistingOutlookItems = Folder_Contacts.Items;

                ContactItem newContact = (ContactItem)Folder_Contacts.Items.Add(OlItemType.olContactItem);

                newContact.Account = contact.Account;

                DateTime Anniversary;
                if (DateTime.TryParse(contact.Anniversary, out Anniversary)) newContact.Anniversary = Anniversary;

                newContact.AssistantName = contact.AssistantsName;
                newContact.AssistantTelephoneNumber = contact.AssistantsPhone;

                DateTime Birthday;
                if (DateTime.TryParse(contact.Birthday, out Birthday)) newContact.Birthday = Birthday;

                newContact.Business2TelephoneNumber = contact.BusinessPhone2;
                newContact.BusinessAddress = contact.BusinessAddress;
                newContact.BusinessAddressCity = contact.BusinessCity;
                newContact.BusinessAddressCountry = contact.BusinessCountry;
                newContact.BusinessAddressPostalCode = contact.BusinessPostalCode;
                newContact.BusinessAddressPostOfficeBox = contact.BusinessAddressPOBox;
                newContact.BusinessAddressState = contact.BusinessState;
                newContact.BusinessAddressStreet = contact.BusinessStreet;
                newContact.BusinessFaxNumber = contact.BusinessFax;
                newContact.BusinessTelephoneNumber = contact.BusinessPhone;
                newContact.CallbackTelephoneNumber = contact.Callback;
                newContact.CarTelephoneNumber = contact.CarPhone;
                newContact.Categories = contact.Categories;
                newContact.Children = contact.Children;
                newContact.Companies = contact.Company;
                newContact.CompanyMainTelephoneNumber = contact.CompanyMainPhone;
                newContact.CompanyName = contact.Company;
                newContact.Department = contact.Department;
                newContact.Email1Address = contact.EmailAddress;
                newContact.Email2Address = contact.Email2Address;
                newContact.Email3Address = contact.Email3Address;
                newContact.FirstName = contact.FirstName;
                newContact.FullName = $"{contact.FirstName} {contact.MiddleName} {contact.LastName}";
                newContact.Hobby = contact.Hobby;
                newContact.Home2TelephoneNumber = contact.HomePhone2;
                newContact.HomeAddress = contact.HomeAddress;
                newContact.HomeAddressCity = contact.HomeCity;
                newContact.HomeAddressCountry = contact.HomeCountry;
                newContact.HomeAddressPostalCode = contact.HomePostalCode;
                newContact.HomeAddressPostOfficeBox = contact.HomeAddressPOBox;
                newContact.HomeAddressState = contact.HomeState;
                newContact.HomeAddressStreet = contact.HomeStreet;
                newContact.HomeFaxNumber = contact.HomeFax;
                newContact.HomeTelephoneNumber = contact.HomePhone;
                newContact.Initials = contact.Initials;
                newContact.InternetFreeBusyAddress = contact.InternetFreeBusy;
                newContact.ISDNNumber = contact.ISDN;
                newContact.JobTitle = contact.JobTitle;
                newContact.Language = contact.Language;
                newContact.LastName = contact.LastName;
                newContact.ManagerName = contact.ManagersName;
                newContact.MiddleName = contact.MiddleName;
                newContact.Mileage = contact.Mileage;
                newContact.MobileTelephoneNumber = contact.MobilePhone;
                newContact.OfficeLocation = contact.OfficeLocation;
                newContact.OtherAddress = contact.OtherAddress;
                newContact.OtherAddressCity = contact.OtherCity;
                newContact.OtherAddressCountry = contact.OtherCountry;
                newContact.OtherAddressPostalCode = contact.OtherPostalCode;
                newContact.OtherAddressPostOfficeBox = contact.OtherAddressPOBox;
                newContact.OtherAddressState = contact.OtherState;
                newContact.OtherAddressStreet = contact.OtherStreet;
                newContact.OtherFaxNumber = contact.OtherFax;
                newContact.OtherTelephoneNumber = contact.OtherPhone;
                newContact.PagerNumber = contact.Pager;
                newContact.PrimaryTelephoneNumber = contact.PrimaryPhone;
                newContact.Profession = contact.Profession;
                newContact.RadioTelephoneNumber = contact.RadioPhone;
                newContact.ReferredBy = contact.ReferredBy;
                newContact.Spouse = contact.Spouse;
                newContact.Suffix = contact.Suffix;
                newContact.TelexNumber = contact.Telex;
                newContact.Title = contact.Title;
                newContact.TTYTDDTelephoneNumber = contact.TTYTDDPhone;
                newContact.User1 = contact.User1;
                newContact.User2 = contact.User2;
                newContact.User3 = contact.User3;
                newContact.User4 = contact.User4;
                newContact.WebPage = contact.WebPage;

                newContact.Save();
                return true;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }



        private void btnOpenCsv_Click(object sender, EventArgs e)
        {
            Contacts = OpenCsvFromFile();
            FillLv(Contacts);
            MessageBox.Show($"{Contacts.Count().ToString()} Entires loaded successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnWriteContacts_Click(object sender, EventArgs e)
        {
            if (LV.SelectedItems.Count > 0)
            {
                if (LV.SelectedItems[0] != null)
                {
                    OutlookContact contact = (OutlookContact)LV.SelectedItems[0].Tag;
                    var res = AddContact(contact);
                    if (res) MessageBox.Show("Entry imported successfully");
                }
            }
            else
            {
                MessageBox.Show("Select an Item first");
            }
        }

        private void btnWriteAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Do you really want to import {Contacts.Count} contact entries to Outlook?", "Outlook Contacts Import", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int cOk = 0;
                btnOpenCsv.Enabled = false;
                btnWriteAll.Enabled = false;
                btnWriteContacts.Enabled = false;

                System.Windows.Forms.Application.DoEvents();

                foreach (OutlookContact contact in Contacts)
                {
                    var res = AddContact(contact);
                    if (res) cOk++;
                }

                btnOpenCsv.Enabled = true;
                btnWriteAll.Enabled = true;
                btnWriteContacts.Enabled = true;

                MessageBox.Show($"{cOk} of {Contacts.Count} Contact entries imported successfully");
            }
        }

        private void btnOpenGoogleContacts_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("rundll32", "url.dll,FileProtocolHandler https://contacts.google.com/");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var gchelp = new GcHelpform();
            gchelp.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Microsoft.Win32.RegistryKey? key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("Software\\microsoft\\windows\\currentversion\\app paths\\OUTLOOK.EXE");
            if (key != null)
            {
                string? path = key.GetValue("Path")?.ToString();
                if (path != null)
                    System.Diagnostics.Process.Start($"{path}OUTLOOK.EXE");
                else
                    MessageBox.Show("Outlook was not found on this computer. Please check installation.", "Outlook not found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void llGitHubIssues_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("rundll32", "url.dll,FileProtocolHandler https://github.com/ummerland/GOSync/issues");
        }
    }
}