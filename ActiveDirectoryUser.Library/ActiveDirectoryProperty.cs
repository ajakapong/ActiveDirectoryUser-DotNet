using System;

namespace ActiveDirectoryUser.Library
{
    public class ActiveDirectoryProperty
    {

        #region string
        [Category("Account")]
        [Description("Get or Set System.String From Active Directory Tab Account-User logon name")]
        public string UserName
        {
            get { return GetAttributeValueString("sAMAccountName"); }
            set { SetAttributeValueString("sAMAccountName", value); }
        }

        [Category("Attributes")]
        [Description("Get or Set System.String From Active Directory Tab Attribute")]
        public string cn
        {
            get { return GetAttributeValueString("cn"); }
            set { SetAttributeValueString("cn", value); }
        }
        [Category("General")]
        [Description("Get or Set System.String From Active Directory Tab General-Last name")]
        public string sn
        {
            get { return GetAttributeValueString("sn"); }
            set { SetAttributeValueString("sn", value); }
        }
        [Category("Address")]
        [Description("Get or Set System.String From Active Directory Tab Address-Country/region(Sort name)")]
        public string c
        {
            get { return GetAttributeValueString("c"); }
            set { SetAttributeValueString("c", value); }
        }
        [Category("Address")]
        [Description("Get or Set System.String From Active Directory Tab Address-City")]
        public string l
        {
            get { return GetAttributeValueString("l"); }
            set { SetAttributeValueString("l", value); }
        }
        /// <summary>
        /// Get System.String From Active Directory Tab Address-State/province
        /// </summary>
        [Category("Address")]
        [Description("Get or Set System.String From Active Directory Tab Address-State/province")]
        public string st
        {
            get { return GetAttributeValueString("st"); }
            set { SetAttributeValueString("st", value); }
        }
        /// <summary>
        /// Get System.String From Active Directory Tab Organization-Job Title
        /// </summary>
        [Category("Organization")]
        [Description("Get or Set System.String From Active Directory Tab Organization-Job Title")]
        public string title
        {
            get { return GetAttributeValueString("title"); }
            set { SetAttributeValueString("title", value); }
        }
        /// <summary>
        /// Get System.String From Active Directory Tab General-Description
        /// </summary>
        [Category("General")]
        [Description("Get or Set System.String From Active Directory Tab General-Description")]
        public string description
        {
            get { return GetAttributeValueString("description"); }
            set { SetAttributeValueString("description", value); }
        }
        [Category("Address")]
        [Description("Get or Set System.String From Active Directory Tab Address-Zip/Postal Code")]
        public string postalCode
        {
            get { return GetAttributeValueString("postalCode"); }
            set { SetAttributeValueString("postalCode", value); }
        }
        [Category("Address")]
        [Description("Get or Set System.String From Active Directory Tab Address-P.O. Box")]
        public string postOfficeBox
        {
            get { return GetAttributeValueString("postOfficeBox"); }
            set { SetAttributeValueString("postOfficeBox", value); }
        }
        [Category("General")]
        [Description("Get or Set System.String From Active Directory Tab General-Office")]
        public string physicalDeliveryOfficeName
        {
            get { return GetAttributeValueString("physicalDeliveryOfficeName"); }
            set { SetAttributeValueString("physicalDeliveryOfficeName", value); }
        }
        [Category("General")]
        [Description("Get or Set System.String From Active Directory Tab General-Telephone number")]
        public string telephoneNumber
        {
            get { return GetAttributeValueString("telephoneNumber"); }
            set { SetAttributeValueString("telephoneNumber", value); }
        }
        [Category("Telephone")]
        [Description("Get or Set System.String From Active Directory Tab Telephone-Fax")]
        public string facsimileTelephoneNumber
        {
            get { return GetAttributeValueString("facsimileTelephoneNumber"); }
            set { SetAttributeValueString("facsimileTelephoneNumber", value); }
        }
        [Category("General")]
        [Description("Get or Set System.String From Active Directory Tab General-First name")]
        public string givenName
        {
            get { return GetAttributeValueString("givenName"); }
            set { SetAttributeValueString("givenName", value); }
        }
        [Category("General")]
        [Description("Get or Set System.String From Active Directory Tab General-Initials")]
        public string initials
        {
            get { return GetAttributeValueString("initials"); }
            set { SetAttributeValueString("initials", value); }
        }
        //[Category("Attributes")]
        //[Description("Get System.String From Active Directory Tab attributes")]
        //public string distinguishedName
        //{
        //    get { return GetAttributeValueString("distinguishedName"); }
        //}
        [Category("General")]
        [Description("Get or Set System.String From Active Directory Tab General-Display Name")]
        public string displayName
        {
            get { return GetAttributeValueString("displayName"); }
            set { SetAttributeValueString("displayName", value); }
        }
        [Category("Telephones")]
        [Description("Get or Set System.String From Active Directory Tab Telephones-Note")]
        public string info
        {
            get { return GetAttributeValueString("info"); }
            set { SetAttributeValueString("info", value); }
        }
        [Category("Address")]
        [Description("Get or Set System.String From Active Directory Tab Address-Country/region(Full name)")]
        public string co
        {
            get { return GetAttributeValueString("co"); }
            set { SetAttributeValueString("co", value); }
        }
        [Category("Organization")]
        [Description("Get or Set System.String From Active Directory Tab Organization-Department")]
        public string department
        {
            get { return GetAttributeValueString("department"); }
            set { SetAttributeValueString("department", value); }
        }
        [Category("Organization")]
        [Description("Get or Set System.String From Active Directory Tab Organization-Companey")]
        public string company
        {
            get { return GetAttributeValueString("company"); }
            set { SetAttributeValueString("company", value); }
        }
        [Category("Address")]
        [Description("Get or Set System.String From Active Directory Tab Address-Street")]
        public string streetAddress
        {
            get { return GetAttributeValueString("streetAddress"); }
            set { SetAttributeValueString("streetAddress", value); }
        }
        [Category("General")]
        [Description("Get or Set System.String From Active Directory Tab General-Web page")]
        public string wWWHomePage
        {
            get { return GetAttributeValueString("wWWHomePage"); }
            set { SetAttributeValueString("wWWHomePage", value); }
        }
        [Category("Attributes")]
        [Description("Get or Set System.String From Active Directory First name Last name")]
        public string name
        {
            get { return GetAttributeValueString("name"); }
            set { SetAttributeValueString("name", value); }
        }
        [Category("Account")]
        [Description("Get or Set System.String From Active Directory User logon name")]
        public string userPrincipalName
        {
            get { return GetAttributeValueString("userPrincipalName"); }
            set { SetAttributeValueString("userPrincipalName", value); }
        }
        [Category("Telephones")]
        [Description("Get or Set System.String From Active Directory Tab Telephones-Ip phone")]
        public string ipPhone
        {
            get { return GetAttributeValueString("ipPhone"); }
            set { SetAttributeValueString("ipPhone", value); }
        }
        [Category("Attributes")]
        [Description("Get or Set System.String From Active Directory objectCategory")]
        public string objectCategory
        {
            get { return GetAttributeValueString("objectCategory"); }
            set { SetAttributeValueString("objectCategory", value); }
        }
        [Category("General")]
        [Description("Get or Set System.String From Active Directory Tab General-E-mail")]
        public string mail
        {
            get { return GetAttributeValueString("mail"); }
            set { SetAttributeValueString("mail", value); }
        }
        [Category("Telephones")]
        [Description("Get or Set System.String From Active Directory Tab Telephone-Home")]
        public string homePhone
        {
            get { return GetAttributeValueString("homePhone"); }
            set { SetAttributeValueString("homePhone", value); }
        }
        [Category("Telephones")]
        [Description("Get System.String From Active Directory Tab Telephone-Mobile")]
        public string mobile
        {
            get { return GetAttributeValueString("mobile"); }
            set { SetAttributeValueString("mobile", value); }
        }
        [Category("Telephones")]
        [Description("Get or Set System.String From Active Directory Tab Telephone-Pager")]
        public string pager
        {
            get { return GetAttributeValueString("pager"); }
            set { SetAttributeValueString("pager", value); }
        }
        #endregion

        #region string[]
        [Category("Member Of")]
        [Description("Get or Set System.String[] from Active Directory Tab Member Of")]
        public string[] MemberOf
        {
            get { return GetAttributeValueStringArray("memberOf"); }
            set { SetAttributeValueStringArray("memberOf", value); }
        }
        [Category("General")]
        [Description("Get or Set System.String[] from Active Directory Tab General-Telephone number(Other)")]
        public string[] otherTelephone
        {
            get { return GetAttributeValueStringArray("otherTelephone"); }
            set { SetAttributeValueStringArray("otherTelephone", value); }
        }
        [Category("Telephones")]
        [Description("Get or Set System.String[] from Active Directory Tab Telephones-Pager(Other)")]
        public string[] otherPager
        {
            get { return GetAttributeValueStringArray("otherPager"); }
            set { SetAttributeValueStringArray("otherPager", value); }
        }
        [Category("Telephones")]
        [Description("Get or Set System.String[] from Active Directory Tab Telephones-Home(Other)")]
        public string[] otherHomePhone
        {
            get { return GetAttributeValueStringArray("otherHomePhone"); }
            set { SetAttributeValueStringArray("otherHomePhone", value); }
        }
        [Category("Telephones")]
        [Description("Get or Set System.String[] from Active Directory Tab Telephones-Fax(Other)")]
        public string[] otherFacsimileTelephoneNumber
        {
            get { return GetAttributeValueStringArray("otherFacsimileTelephoneNumber"); }
            set { SetAttributeValueStringArray("otherFacsimileTelephoneNumber", value); }
        }
        [Category("Telephones")]
        [Description("Get or Set System.String[] from Active Directory Tab Telephones-Mobile(Other)")]
        public string[] otherMobile
        {
            get { return GetAttributeValueStringArray("otherMobile"); }
            set { SetAttributeValueStringArray("otherMobile", value); }
        }
        [Category("Telephones")]
        [Description("Get or Set System.String[] from Active Directory Tab Telephones-IpPhone(Other)")]
        public string[] otherIpPhone
        {
            get { return GetAttributeValueStringArray("otherIpPhone"); }
            set { SetAttributeValueStringArray("otherIpPhone", value); }
        }
        [Category("General")]
        [Description("Get or Set System.String[] from Active Directory Tab General-Web page(Other)")]
        public string[] url
        {
            get { return GetAttributeValueStringArray("url"); }
            set { SetAttributeValueStringArray("url", value); }
        }

        #endregion

        #region Int
        [Category("Attributes")]
        [Description("Get or Set System.Int From Active Directory Tab Attribute")]
        public int instanceType
        {
            get { return GetAttributeValueInt("instanceType"); }
            set { SetAttributeValueInt("instanceType", value); }
        }
        [Category("Attributes")]
        [Description("Get or Set System.Int From Active Directory Tab Attribute")]
        public int badPwdCount
        {
            get { return GetAttributeValueInt("badPwdCount"); }
            set { SetAttributeValueInt("badPwdCount", value); }
        }
        [Category("Attributes")]
        [Description("Get or Set System.Int From Active Directory Tab Attribute")]
        public int codePage
        {
            get { return GetAttributeValueInt("codePage"); }
            set { SetAttributeValueInt("codePage", value); }
        }
        [Category("Attributes")]
        [Description("Get or Set System.Int From Active Directory Tab Attribute")]
        public int countryCode
        {
            get { return GetAttributeValueInt("countryCode"); }
            set { SetAttributeValueInt("countryCode", value); }
        }
        [Category("Attributes")]
        [Description("Get or Set System.Int From Active Directory Tab Attribute")]
        public int primaryGroupID
        {
            get { return GetAttributeValueInt("primaryGroupID"); }
            set { SetAttributeValueInt("primaryGroupID", value); }
        }
        [Category("Attributes")]
        [Description("Get or Set System.Int From Active Directory Tab Attribute")]
        public int logonCount
        {
            get { return GetAttributeValueInt("logonCount"); }
            set { SetAttributeValueInt("logonCount", value); }
        }
        [Category("Other")]
        [Description("Get or Set System.Int From Active Directory Tab Attribute")]
        public int sAMAccountType
        {
            get { return GetAttributeValueInt("sAMAccountType"); }
            set { SetAttributeValueInt("sAMAccountType", value); }
        }

        #endregion

        #region DateTime
        [Category("Attributes")]
        [Description("Get or Set System.DateTime From Active Directory Tab Attribute")]
        public DateTime whenCreated
        {
            get { return GetAttributeValueDateTime("whenCreated"); }
            set { SetAttributeValueDateTime("whenCreated", value); }
        }
        [Category("Attributes")]
        [Description("Get or Set System.DateTime From Active Directory Tab Attribute")]
        public DateTime whenChanged
        {
            get { return GetAttributeValueDateTime("whenChanged"); }
            set { SetAttributeValueDateTime("whenChanged", value); }
        }
        [Category("Attributes")]
        [Description("Get or Set System.DateTime From Active Directory Tab Attribute")]
        public DateTime dSCorePropagationData
        {
            get { return GetAttributeValueDateTime("dSCorePropagationData"); }
            set { SetAttributeValueDateTime("dSCorePropagationData", value); }
        }

        #endregion

    }
}
