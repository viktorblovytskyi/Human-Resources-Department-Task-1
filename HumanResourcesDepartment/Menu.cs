using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesDepartment
{
    class Menu
    {
        /// <summary>
        /// This method display data. TODO delete. 
        /// </summary>
        public void DisplayData(Employee empObj)
        {
            if (empObj.Employer != null && empObj.Subdivision != null)
            {
                Console.WriteLine(empObj.FirstName + "\t" + empObj.LastName + "\t" + empObj.Position + "\t" + empObj.Subdivision.Name + "\t" + empObj.Employer.FirstName);
            }
            else if (empObj.Employer == null && empObj.Subdivision != null)
            {
                Console.WriteLine(empObj.FirstName + "\t " + empObj.LastName + "\t" + empObj.Position + "\t" + empObj.Subdivision.Name + "\t");
            }
            else if (empObj.Subdivision == null && empObj.Employer != null)
            {
                Console.WriteLine(empObj.FirstName + "\t" + empObj.LastName + "\t" + empObj.Position + "\t" + " " + "\t" + empObj.Employer.FirstName);
            }
            else
            {
                Console.WriteLine(empObj.FirstName + "\t" + empObj.LastName + "\t" + empObj.Position + "\t" + " " + "\t" + " ");
            }
        }
    }
}
