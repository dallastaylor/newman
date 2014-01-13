using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using Nustache.Core;
using umbraco.cms.presentation;
using Umbraco.Core;
using umbraco.BusinessLogic;
using umbraco.cms.businesslogic;
using umbraco.cms.businesslogic.web;
using Umbraco.Core.Persistence;
using Umbraco.Web.Mvc;


namespace Newman.Api
{
    public class Mail
    {
        
        private Dictionary<string, string> data;
        public Dictionary<string, string> Data
        {
            get {

                if (data == null)
                    data = new Dictionary<string, string>();

                return data;
            }
        }
        
        private string mailName;
        public string MailName
        {
            get { return mailName; }
            set { mailName = value; }
        }

        private string toAddress;
        public string ToAddress
        {
            get { return toAddress; }
            set { toAddress = value; }
        }

        public Mail(string mailName, string toAddress)
        {
            MailName = mailName;
            ToAddress = toAddress;
        }

        public void Deliver()
        {

            var template = GetTemplate(MailName);
         
            // merge template and data

            var emailbody = Render.StringToString(template, Data);

            // Send the email using configured delivery method

           // SmtpClient smtp = new SmtpClient();



            
        }

        private string GetTemplate(string mailName)
        {
            /*
            //Connect to the Umbraco DB
            var db = ApplicationContext.DatabaseContext.Database;

            //Get the current Umbraco Node ID
            var currentNodeId = UmbracoContext.PageId.Value;

            //Get an IENumberable of BlogComment objects to iterate over
            var email = db.Query("SELECT Top 1 FROM Newman_Email WHERE mailName=@0", mailName);
             */

            return "{{test}}";
        }
    }
}