using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeCrm.Domain.Entities.Common;

namespace EmployeeCrm.Domain.Entities;

public class User : BaseEntity
{
    public string UserName { get; set; }
}
