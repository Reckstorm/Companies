using CompaniesList.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompaniesList
{
    public partial class CompanyItem : UserControl
    {
        public CompanyItem()
        {
            InitializeComponent();
        }

        public CompanyItem(Company company) : this()
        {
            this.Name_TB.Text = company.Name;
            this.CEO_TB.Text = company.CEO;
            this.Employees_TB.Text = company.EmployeeCount.ToString();
        }

        public void SetCities(List<City> cities)
        {
            string temp = "";
            foreach (City city in cities)
            {
                if (!temp.Equals(string.Empty)) temp += $", {city.CityName}";
                else temp += city.CityName;
            }
            this.Cities.Text = temp;
        }
    }
}
