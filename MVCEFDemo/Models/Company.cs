using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCEFDemo.Models
{
    public class Company
    {
        [Key]
        public string SelectDepartment { get; set; }
        
        public List<Department> departments
        {
            
            get
            {
                DepartmentDBContext db = new DepartmentDBContext();
                return db.Departments.ToList();
            }
        }
    }
}