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

        private readonly WaresoftContext _context;

        public QueriesController(WaresoftContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.DevNames = new SelectList(_context.Developers, "Name", "Name");

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SimpleQuery1(Query queryModel)
        {
            string query = System.IO.File.ReadAllText(S1_PATH);
            query = query.Replace("N\'param\'", "N\'" + queryModel.DevName + "\'");
            query = query.Replace("\r\n", " ");
            query = query.Replace('\t', ' ');

            queryModel.QueryId = "S1";

            using (var connection = new SqlConnection(CONN_STR))
            {
                connection.Open();
                try
                {
                    using (var command = new SqlCommand(query, connection))
                    {
                        queryModel.AvgPrice = Convert.ToDecimal(command.ExecuteScalar());
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
                finally
                {
                    connection.Close();
                }
            }
            return RedirectToAction("Result", queryModel);
        }

        public IActionResult Result(Query queryResult)
        {
            return View(queryResult);
        }
    }
}