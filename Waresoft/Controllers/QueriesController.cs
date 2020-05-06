using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Waresoft.Models;

namespace Waresoft.Controllers
{
    public class QueriesController : Controller
    {
        private const string CONN_STR = "Server=ROOFLER\\SQLEXPRESS;Database=Waresoft;Trusted_Connection=True;MultipleActiveResultSets=true";
        private const string S1_PATH = @"D:\Женя\Студматериалы\2 КУРС\2 СЕМЕСТР\БД та ІС\Лаба 2\Waresoft\Waresoft\Queries\S1.sql";
        private const string S2_PATH = @"D:\Женя\Студматериалы\2 КУРС\2 СЕМЕСТР\БД та ІС\Лаба 2\Waresoft\Waresoft\Queries\S2.sql";
        private const string S3_PATH = @"D:\Женя\Студматериалы\2 КУРС\2 СЕМЕСТР\БД та ІС\Лаба 2\Waresoft\Waresoft\Queries\S3.sql";

        private const string ERR_AVG = "Неможливо обрахувати середню ціну, оскільки продукти відсутні.";
        private const string ERR_CUST = "Покупці, що задовольняють дану умову, відсутні.";
        private const string ERR_PROD = "Програмні продукти, що задовольняють дану умову, відсутні.";

        private readonly WaresoftContext _context;

        public QueriesController(WaresoftContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.DevNames = new SelectList(_context.Developers, "Name", "Name");
            ViewBag.Countries = new SelectList(_context.Countries, "Name", "Name");
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SimpleQuery1(Query queryModel)
        {
            string query = System.IO.File.ReadAllText(S1_PATH);
            query = query.Replace("P", "N\'" + queryModel.DevName + "\'");
            query = query.Replace("\r\n", " ");
            query = query.Replace('\t', ' ');

            queryModel.QueryId = "S1";

            using (var connection = new SqlConnection(CONN_STR))
            {
                connection.Open();
                using (var command = new SqlCommand(query, connection))
                {
                    var result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        queryModel.AvgPrice = Convert.ToDecimal(result);
                    }
                    else
                    {
                        queryModel.ErrorFlag = 1;
                        queryModel.Error = ERR_AVG;
                    }
                }
                connection.Close();
            }
            return RedirectToAction("Result", queryModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SimpleQuery2(Query queryModel)
        {
            string query = System.IO.File.ReadAllText(S2_PATH);
            query = query.Replace("X", "N\'" + queryModel.DevName + "\'");
            query = query.Replace("\r\n", " ");
            query = query.Replace('\t', ' ');

            queryModel.QueryId = "S2";
            queryModel.CustNames = new List<string>();
            queryModel.CustSurnames = new List<string>();

            using (var connection = new SqlConnection(CONN_STR))
            {
                connection.Open();
                using (var command = new SqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                    using (var reader = command.ExecuteReader())
                    {
                        int flag = 0;
                        while (reader.Read())
                        {
                            queryModel.CustNames.Add(reader.GetString(0));
                            queryModel.CustSurnames.Add(reader.GetString(1));
                            flag++;
                        }

                        if (flag == 0)
                        {
                            queryModel.ErrorFlag = 1;
                            queryModel.Error = ERR_CUST;
                        }
                    }
                }
                connection.Close();
            }
            return RedirectToAction("Result", queryModel);
        }

        public IActionResult SimpleQuery3(Query queryModel)
        {
            string query = System.IO.File.ReadAllText(S3_PATH);
            query = query.Replace("K", "N\'" + queryModel.CountryName + "\'");
            query = query.Replace("\r\n", " ");
            query = query.Replace('\t', ' ');

            queryModel.QueryId = "S3";
            queryModel.ProdNames= new List<string>();
            queryModel.ProdPrices= new List<decimal>();

            using (var connection = new SqlConnection(CONN_STR))
            {
                connection.Open();
                using (var command = new SqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                    using (var reader = command.ExecuteReader())
                    {
                        int flag = 0;
                        while (reader.Read())
                        {
                            queryModel.ProdNames.Add(reader.GetString(0));
                            queryModel.ProdPrices.Add(reader.GetDecimal(1));
                            flag++;
                        }

                        if (flag == 0)
                        {
                            queryModel.ErrorFlag = 1;
                            queryModel.Error = ERR_PROD;
                        }
                    }
                }
                connection.Close();
            }
            return RedirectToAction("Result", queryModel);
        }

        public IActionResult Result(Query queryResult)
        {
            return View(queryResult);
        }
    }
}