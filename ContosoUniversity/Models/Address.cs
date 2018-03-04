using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace ContosoUniversity.Models
{
    public class Address
    {
        [EmailAddress]
        [RegularExpression(@"^[a-zA-Z0-9._]+@contoso\.edu$", ErrorMessage = "Invalid Emaddresses. Please entere into the system conform with the pattern [username]@contoso.edu")]
        public string Email { get; set; }
    }
}