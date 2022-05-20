using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnotationDemo
{
    public class Employee
    {
        //<summary>
        //<Gets or sets the name.
        //<value>
        //The name.
        //</Value>
        [Required(ErrorMessage="Employee {0} is required")]
        [StringLength(100,MinimumLength = 3,ErrorMessage = "Name should be minium 3 characters and of 100 characters")]
        [DataType(DataType.Text)]
        public string Name { get; set; }
        //<summary>
        //<Gets or sets the name.
        //<value>
        //The age.
        //</Value>
        [Range (18,99,ErrorMessage ="Age should be above 18")]
        public int Age { get; set; }
        //<summary>
        //<Gets or sets the name.
        //<value>
        //The phone number.
        //</Value>
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        //<summary>
        //<Gets or sets the name.
        //<value>
        //The email.
        //</Value>
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }    
    }
}
