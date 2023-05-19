using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompaniesList.Models
{
    public class City
    {
        public int Id { get; set; }
        public string CityName { get; set; }

        public City(int id, string cityName)
        {
            this.Id = id;
            this.CityName = cityName;
        }
    }
}
