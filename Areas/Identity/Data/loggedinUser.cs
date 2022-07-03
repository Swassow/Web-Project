using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace logindemo.Areas.Identity.Data;

// Add profile data for application users by adding properties to the loggedinUser class
public class loggedinUser : IdentityUser
{
    public string FirstName { get; set; }

    public string LastName { get; set; }
}

