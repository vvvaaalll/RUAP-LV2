﻿using ruap_lv2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ruap_lv2.Services;

namespace ruap_lv2.Controllers
{
    public class ContactController : ApiController
    {
       
            private ContactRepository contactRepository;

            public ContactController()
            {
                this.contactRepository = new ContactRepository();
            } 


        public Contact[] Get()
        {
            return contactRepository.GetAllContacts();
        }
    }
}