using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using StoredProcedure123.Data;
using StoredProcedure123.Models;

namespace StoredProcedure123.Controllers
{
    public class CarsController : Controller
    {
        public StoredProcDbContext _context;
        public IConfiguration _confiq;
        public CarsController
            (
                StoredProcDbContext context,
                IConfiguration config
            )
        {
            _context = context;
            _confiq = config;
        }
        [HttpGet]
        public IActionResult Index()
        {
            string connectionStr = _confiq.GetConnectionString("DefaultConnection");

            using (SqlConnection con = new SqlConnection(connectionStr))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "dbo.spFindCars";
                cmd.CommandType = System.Data.CommandType.Text;
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                List<Cars> model = new List<Cars>();
                while (sdr.Read())
                {
                    var details = new Cars();
                    details.FirstName = sdr["FirstName"].ToString();
                    details.TopSpeed = sdr["TopSpeed"].ToString();
                    details.HamburgersEaten = Convert.ToInt32(sdr["HamburgersEaten"]);
                    details.TimesRanOutOfGas = Convert.ToInt32(sdr["TimesRanOutOfGas"]);
                    details.RacesWon = Convert.ToInt32(sdr["RacesWon"]);
                    model.Add(details);
                }

                return View(model);
            }
        }
    }
}
    

