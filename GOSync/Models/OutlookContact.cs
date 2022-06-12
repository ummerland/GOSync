using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOSync.Models
{
    public class OutlookContact
    {
        [Name("First Name")]
        public string? FirstName { get; set; }
        
        [Name("Middle Name")]
        public string? MiddleName { get; set; }

        [Name("Last Name")]
        public string? LastName { get; set; }
        
        [Name("Title")]
        public string? Title { get; set; }
        
        [Name("Suffix")]
        public string? Suffix { get; set; }
        
        [Name("Initials")]
        public string? Initials { get; set; }
        
        [Name("Web Page")]
        public string? WebPage { get; set; }
        
        [Name("Gender")]
        public string? Gender { get; set; }
        
        [Name("Birthday")]
        public string? Birthday { get; set; }
        
        [Name("Anniversary")]
        public string? Anniversary { get; set; }
        
        [Name("Location")]
        public string? Location { get; set; }
        
        [Name("Language")]
        public string? Language { get; set; }
        
        [Name("Internet Free Busy")]
        public string? InternetFreeBusy { get; set; }
        
        [Name("Notes")]
        public string? Notes { get; set; }
        
        [Name("E-mail Address")]
        public string? EmailAddress { get; set; }
        
        [Name("E-mail 2 Address")]
        public string? Email2Address { get; set; }
        
        [Name("E-mail 3 Address")]
        public string? Email3Address { get; set; }
        
        [Name("Primary Phone")]
        public string? PrimaryPhone { get; set; }
        
        [Name("Home Phone")]
        public string? HomePhone { get; set; }
        
        [Name("Home Phone 2")]
        public string? HomePhone2 { get; set; }
        
        [Name("Mobile Phone")]
        public string? MobilePhone { get; set; }
        
        [Name("Pager")]
        public string? Pager { get; set; }
        
        [Name("Home Fax")]
        public string? HomeFax { get; set; }
        
        [Name("Home Address")]
        public string? HomeAddress { get; set; }
        
        [Name("Home Street")]
        public string? HomeStreet { get; set; }
        
        [Name("Home Street 2")]
        public string? HomeStreet2 { get; set; }
        
        [Name("Home Street 3")]
        public string? HomeStreet3 { get; set; }
        
        [Name("Home Address PO Box")]
        public string? HomeAddressPOBox { get; set; }
        
        [Name("Home City")]
        public string? HomeCity { get; set; }
        
        [Name("Home State")]
        public string? HomeState { get; set; }
        
        [Name("Home Postal Code")]
        public string? HomePostalCode { get; set; }
        
        [Name("Home Country")]
        public string? HomeCountry { get; set; }
        
        [Name("Spouse")]
        public string? Spouse { get; set; }
        
        [Name("Children")]
        public string? Children { get; set; }
        
        [Name("Manager's Name")]
        public string? ManagersName { get; set; }
        
        [Name("Assistant's Name")]
        public string? AssistantsName { get; set; }
        
        [Name("Referred By")]
        public string? ReferredBy { get; set; }
        
        [Name("Company Main Phone")]
        public string? CompanyMainPhone { get; set; }
        
        [Name("Business Phone")]
        public string? BusinessPhone { get; set; }
        
        [Name("Business Phone 2")]
        public string? BusinessPhone2 { get; set; }
        
        [Name("Business Fax")]
        public string? BusinessFax { get; set; }
        
        [Name("Assistant's Phone")]
        public string? AssistantsPhone { get; set; }
        
        [Name("Company")]
        public string? Company { get; set; }
        
        [Name("Job Title")]
        public string? JobTitle { get; set; }
        
        [Name("Department")]
        public string? Department { get; set; }
        
        [Name("Office Location")]
        public string? OfficeLocation { get; set; }
        
        [Name("Organizational ID Number")]
        public string? OrganizationalIDNumber { get; set; }
        
        [Name("Profession")]
        public string? Profession { get; set; }
        
        [Name("Account")]
        public string? Account { get; set; }
        
        [Name("Business Address")]
        public string? BusinessAddress { get; set; }
        
        [Name("Business Street")]
        public string? BusinessStreet { get; set; }
        
        [Name("Business Street 2")]
        public string? BusinessStreet2 { get; set; }
        
        [Name("Business Street 3")]
        public string? BusinessStreet3 { get; set; }
        
        [Name("Business Address PO Box")]
        public string? BusinessAddressPOBox { get; set; }
        
        [Name("Business City")]
        public string? BusinessCity { get; set; }
        
        [Name("Business State")]
        public string? BusinessState { get; set; }
        
        [Name("Business Postal Code")]
        public string? BusinessPostalCode { get; set; }
        
        [Name("Business Country")]
        public string? BusinessCountry { get; set; }
        
        [Name("Other Phone")]
        public string? OtherPhone { get; set; }
        
        [Name("Other Fax")]
        public string? OtherFax { get; set; }
        
        [Name("Other Address")]
        public string? OtherAddress { get; set; }
        
        [Name("Other Street")]
        public string? OtherStreet { get; set; }
        
        [Name("Other Street 2")]
        public string? OtherStreet2 { get; set; }
        
        [Name("Other Street 3")]
        public string? OtherStreet3 { get; set; }
        
        [Name("Other Address PO Box")]
        public string? OtherAddressPOBox { get; set; }
        
        [Name("Other City")]
        public string? OtherCity { get; set; }
        
        [Name("Other State")]
        public string? OtherState { get; set; }
        
        [Name("Other Postal Code")]
        public string? OtherPostalCode { get; set; }
        
        [Name("Other Country")]
        public string? OtherCountry { get; set; }
        
        [Name("Callback")]
        public string? Callback { get; set; }
        
        [Name("Car Phone")]
        public string? CarPhone { get; set; }
        
        [Name("ISDN")]
        public string? ISDN { get; set; }
        
        [Name("Radio Phone")]
        public string? RadioPhone { get; set; }
        
        [Name("TTY/TDD Phone")]
        public string? TTYTDDPhone { get; set; }
        
        [Name("Telex")]
        public string? Telex { get; set; }
        
        [Name("User 1")]
        public string? User1 { get; set; }
        
        [Name("User 2")]
        public string? User2 { get; set; }
        
        [Name("User 3")]
        public string? User3 { get; set; }
        
        [Name("User 4")]
        public string? User4 { get; set; }
        
        [Name("Keywords")]
        public string? Keywords { get; set; }
        
        [Name("Mileage")]
        public string? Mileage { get; set; }
        
        [Name("Hobby")]
        public string? Hobby { get; set; }
        
        [Name("Billing Information")]
        public string? BillingInformation { get; set; }
        
        [Name("Directory Server")]
        public string? DirectoryServer { get; set; }
        
        [Name("Sensitivity")]
        public string? Sensitivity { get; set; }
        
        [Name("Priority")]
        public string? Priority { get; set; }
        
        [Name("Private")]
        public string? Private { get; set; }
        
        [Name("Categories")]
        public string? Categories { get; set; }
    }


}
