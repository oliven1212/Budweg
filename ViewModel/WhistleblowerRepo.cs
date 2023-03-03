using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;
using System.Reflection;
using Budweg.Model;

namespace Budweg.ViewModel
{
    public class WhistleblowerRepo
    {
        private string connectionString = "Server=10.56.8.36; Database=P1_DB_2023_10; User Id=PROJECT_USER_10; Password=OPENDB_10; TrustServerCertificate=true";
        //P1_DB_2023_10, PROJECT_USER_10, OPENDB_10
        private List <Whistleblower> whistleblowers = new List<Whistleblower>();
    
        public WhistleblowerRepo()
        {

        }

        public int Add(Whistleblower whistleblower)
        {
            int result = -1;
            return result;
        }
        public List<Whistleblower> GetAll()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * from WhistleBlower", con);
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Whistleblower whistleblower = new Whistleblower
                        {
                            WhistleblowerId = int.Parse(dr["WBId"].ToString()),
                            Title = dr["WBTitle"].ToString(),
                            Text = dr["WBText"].ToString(),
                            PictureName = dr["WBPictureName"].ToString(),
                            Password = dr["WBPassword"].ToString(),
                            ToDepartment = (ToDepartments)Enum.Parse(typeof(ToDepartments), dr["WBToDepartment"].ToString()),
                            IsActive = bool.Parse(dr["WBIsActive"].ToString())
                            
                        };
                        whistleblowers.Add(whistleblower);
                    }
                }
            }
            return whistleblowers;
        }
    }
}
