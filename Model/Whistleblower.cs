using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Budweg.Model
{
    public enum ToDepartments   
    {
        HR,
        CEO,
        CFO,
        ConfidenceRep,
        WorkEnvironmentRep
    }
    public class Whistleblower : Blog
    {
        public int WhistleblowerId { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public ToDepartments ToDepartment;


        public Whistleblower() { }
    }
}