using Dapper;
using InsuranceERPDapper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InsuranceERPDapper.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Insurance> insurances = new List<Insurance>();

            ViewBag.Error = "";
            ViewBag.Message = "";
            try
            {
                insurances = DapperORM.ReturnList<Insurance>("GetAllPolicies").ToList();
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
            }
            return View(insurances);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Create(Insurance insurance)
        {
            ViewBag.Error = "";
            ViewBag.Message = "";
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@PolicyNumber", insurance.PolicyNumber);
                parameters.Add("@Status", insurance.Status);
                parameters.Add("@Premium", insurance.Premium);
                parameters.Add("@HolderName", insurance.HolderName);
                parameters.Add("@Address", insurance.Address);
                parameters.Add("@Comment", insurance.Comment);

                DapperORM.ExecuteWithoutReturn("CreatePolicy", parameters);
                ViewBag.Message = "Data Inserted Successfully!";
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
            }
            return View();
        }
    }
}