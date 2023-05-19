using CompaniesList.Models;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Globalization;

namespace CompaniesList
{
    public partial class Form1 : Form
    {
        private string _connection = "Server=localhost\\SQLEXPRESS;Database=ITCompanies;Trusted_Connection=True;TrustServerCertificate=True;";
        public Form1()
        {
            InitializeComponent();
            Load += (s, e) =>
            {
                using (SqlConnection conn = new SqlConnection(_connection))
                {
                    List<City> cities = new List<City>();

                    conn.Open();
                    string commandText = @"SELECT * FROM [Cities];";
                    SqlCommand command = new SqlCommand(commandText, conn);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        City temp = new City((int)reader[0], reader[1].ToString());
                        cities.Add(temp);
                    }

                    List<CompanyCity> companyCities = new List<CompanyCity>();

                    reader.Close();
                    commandText = @"SELECT * FROM [CompanyCities];";
                    command = new SqlCommand(commandText, conn);
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        CompanyCity temp = new CompanyCity((int)reader[1], (int)reader[2]);
                        companyCities.Add(temp);
                    }

                    reader.Close();

                    commandText = @"SELECT * FROM [Companies];";
                    command = new SqlCommand(commandText, conn);
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Company temp = new Company((int)reader[0], (int)reader[3], reader[1].ToString(), reader[2].ToString());
                        CompanyItem tempCompanyItem = new CompanyItem(temp);
                        if (this.Controls.Count > 0) tempCompanyItem.Location = new Point(0, this.Controls[this.Controls.Count - 1].Location.Y + this.Controls[this.Controls.Count - 1].Height + 2);
                        else tempCompanyItem.Location = new Point(0, 0);

                        List<CompanyCity> tempCompanyCities = new List<CompanyCity>(companyCities.Where(x => x.CompanyId.Equals(temp.Id)));
                        List<City> tempCities = new List<City>(cities.Where(x => tempCompanyCities.Any(y => y.CityId.Equals(x.Id))));

                        tempCompanyItem.SetCities(tempCities);

                        this.Controls.Add(tempCompanyItem);
                    }

                }
            };
        }
        private void ChangeLang(string lang)
        {
            ComponentResourceManager manager = new ComponentResourceManager(typeof(CompanyItem));
            CultureInfo.CurrentCulture = new CultureInfo(lang);
            foreach (Control item in this.Controls)
            {
                if (this.Controls.IndexOf(item) == 0) continue;
                manager.ApplyResources(item.Controls[1], item.Controls[1].Name, CultureInfo.CurrentCulture);
                manager.ApplyResources(item.Controls[3], item.Controls[3].Name, CultureInfo.CurrentCulture);
                manager.ApplyResources(item.Controls[5], item.Controls[5].Name, CultureInfo.CurrentCulture);
                manager.ApplyResources(item.Controls[7], item.Controls[7].Name, CultureInfo.CurrentCulture);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangeLang("en");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChangeLang("ru");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChangeLang("de");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ChangeLang("es");
        }
    }
}