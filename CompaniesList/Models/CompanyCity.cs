using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompaniesList.Models
{
    public class CompanyCity
    {
        public int CompanyId { get; set; }
        public int CityId { get; set; }

        public CompanyCity(int CityId, int CompanyId)
        {
            this.CompanyId = CompanyId;
            this.CityId = CityId;
        }
    }
}
