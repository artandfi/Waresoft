﻿using System;
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
        private const string S4_PATH = @"D:\Женя\Студматериалы\2 КУРС\2 СЕМЕСТР\БД та ІС\Лаба 2\Waresoft\Waresoft\Queries\S4.sql";
        private const string S5_PATH = @"D:\Женя\Студматериалы\2 КУРС\2 СЕМЕСТР\БД та ІС\Лаба 2\Waresoft\Waresoft\Queries\S5.sql";
        private const string S6_PATH = @"D:\Женя\Студматериалы\2 КУРС\2 СЕМЕСТР\БД та ІС\Лаба 2\Waresoft\Waresoft\Queries\S6.sql";

        private const string A1_PATH = @"D:\Женя\Студматериалы\2 КУРС\2 СЕМЕСТР\БД та ІС\Лаба 2\Waresoft\Waresoft\Queries\A1.sql";
        private const string A2_PATH = @"D:\Женя\Студматериалы\2 КУРС\2 СЕМЕСТР\БД та ІС\Лаба 2\Waresoft\Waresoft\Queries\A2.sql";
        private const string A3_PATH = @"D:\Женя\Студматериалы\2 КУРС\2 СЕМЕСТР\БД та ІС\Лаба 2\Waresoft\Waresoft\Queries\A3.sql";


        private const string ERR_AVG = "Неможливо обрахувати середню ціну, оскільки продукти відсутні.";
        private const string ERR_CUST = "Покупці, що задовольняють дану умову, відсутні.";
        private const string ERR_PROD = "Програмні продукти, що задовольняють дану умову, відсутні.";
        private const string ERR_DEV = "Розробнкии, що задовольняють дану умову, відсутні.";
        private const string ERR_COUNTRY = "Країни, що задовольняють дану умову, відсутні.";
        
        private readonly WaresoftContext _context;

        public QueriesController(WaresoftContext context)
        {
            _context = context;
        }

        public IActionResult Index(int errorCode)
        {
            var customers = _context.Customers.Select(c => c.Name).Distinct().ToList();
            if (errorCode == 1)
            {
                ViewBag.ErrorFlag = 1;
                ViewBag.PriceError = "Введіть коректну вартість";
            }
            if (errorCode == 2)
            {
                ViewBag.ErrorFlag = 2;
                ViewBag.ProdNameError = "Поле необхідно заповнити";
            }

            var empty = new SelectList(new List<string> { "--Пусто--" });
            var anyCusts = _context.Customers.Any();
            var anyDevs = _context.Developers.Any();

            ViewBag.DevIds = anyDevs ? new SelectList(_context.Developers, "Id", "Id") : empty;
            ViewBag.DevNames = anyDevs ? new SelectList(_context.Developers, "Name", "Name") : empty;
            ViewBag.CustNames = anyCusts ? new SelectList(customers) : empty;
            ViewBag.CustEmails = anyCusts ? new SelectList(_context.Customers, "Email", "Email") : empty;
            ViewBag.CustSurnames = anyCusts ? new SelectList(_context.Customers, "Surname", "Surname") : empty;
            ViewBag.Countries = _context.Countries.Any() ? new SelectList(_context.Countries, "Name", "Name") : empty;
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

        [HttpPost]
        [ValidateAntiForgeryToken]
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SimpleQuery4(Query queryModel)
        {
            string query = System.IO.File.ReadAllText(S4_PATH);
            query = query.Replace("X", "N\'" + queryModel.CustName + "\'");
            query = query.Replace("Y", "N\'" + queryModel.CustSurname + "\'");
            query = query.Replace("Z", "N\'" + queryModel.CustEmail + "\'");
            query = query.Replace("\r\n", " ");
            query = query.Replace('\t', ' ');

            queryModel.QueryId = "S4";
            queryModel.DevNames = new List<string>();

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
                            queryModel.DevNames.Add(reader.GetString(0));
                            flag++;
                        }

                        if (flag == 0)
                        {
                            queryModel.ErrorFlag = 1;
                            queryModel.Error = ERR_DEV;
                        }
                    }
                }
                connection.Close();
            }
            return RedirectToAction("Result", queryModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SimpleQuery5(Query queryModel)
        {
            if (ModelState.IsValid)
            {
                string query = System.IO.File.ReadAllText(S5_PATH);
                query = query.Replace("P", queryModel.Price.ToString());
                query = query.Replace("\r\n", " ");
                query = query.Replace('\t', ' ');

                queryModel.QueryId = "S5";
                queryModel.DevNames = new List<string>();

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
                                queryModel.DevNames.Add(reader.GetString(0));
                                flag++;
                            }

                            if (flag == 0)
                            {
                                queryModel.ErrorFlag = 1;
                                queryModel.Error = ERR_DEV;
                            }
                        }
                    }
                    connection.Close();
                }
                return RedirectToAction("Result", queryModel);
            }
            return RedirectToAction("Index", new { errorCode = 1 });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SimpleQuery6(Query queryModel)
        {
            if (ModelState.IsValid)
            {
                string query = System.IO.File.ReadAllText(S6_PATH);
                query = query.Replace("X", "N\'" + queryModel.ProdName + "\'");
                query = query.Replace("\r\n", " ");
                query = query.Replace('\t', ' ');
                queryModel.QueryId = "S6";
                queryModel.DevNames = new List<string>();

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
                                queryModel.DevNames.Add(reader.GetString(0));
                                flag++;
                            }

                            if (flag == 0)
                            {
                                queryModel.ErrorFlag = 1;
                                queryModel.Error = ERR_DEV;
                            }
                        }
                    }
                    connection.Close();
                }
                return RedirectToAction("Result", queryModel);
            }

            return RedirectToAction("Index", new { errorCode = 2 });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AdvancedQuery1(Query queryModel)
        {
            string query = System.IO.File.ReadAllText(A1_PATH);
            query = query.Replace("K", queryModel.DevId.ToString());
            query = query.Replace("\r\n", " ");
            query = query.Replace('\t', ' ');
            queryModel.QueryId = "A1";
            queryModel.CountryNames = new List<string>();

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
                            queryModel.CountryNames.Add(reader.GetString(0));
                            flag++;
                        }

                        if (flag == 0)
                        {
                            queryModel.ErrorFlag = 1;
                            queryModel.Error = ERR_COUNTRY;
                        }
                    }
                }
                connection.Close();
            }
            return RedirectToAction("Result", queryModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AdvancedQuery2(Query queryModel)
        {
            string query = System.IO.File.ReadAllText(A2_PATH);
            query = query.Replace("Y", "N\'" + queryModel.CustEmail.ToString() + "\'");
            query = query.Replace("\r\n", " ");
            query = query.Replace('\t', ' ');
            queryModel.QueryId = "A2";
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
                            queryModel.CustSurnames.Add(reader.GetString(0));
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

        public IActionResult AdvancedQuery3(Query queryModel)
        {
            string query = System.IO.File.ReadAllText(A3_PATH);
            query = query.Replace("Y", "N\'" + queryModel.CustName.ToString() + "\'");
            query = query.Replace("\r\n", " ");
            query = query.Replace('\t', ' ');
            queryModel.QueryId = "A3";
            queryModel.CustSurnames = new List<string>();
            queryModel.CustEmails = new List<string>();

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
                            queryModel.CustSurnames.Add(reader.GetString(0));
                            queryModel.CustEmails.Add(reader.GetString(1));
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

        public IActionResult Result(Query queryResult)
        {
            return View(queryResult);
        }
    }
}