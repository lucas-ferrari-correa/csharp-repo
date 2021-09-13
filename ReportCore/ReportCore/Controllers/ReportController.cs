using AspNetCore.Reporting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReportCore.Controllers
{
    public class ReportController : Controller
    {
        public IActionResult Index()
        {
            string mimtype = "";
            int extension = 1;
            var path = $"\\Reports\\Report1.rdlc";
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("rp1", "Welcome to Etaure!");
            LocalReport localReport = new LocalReport(path);
            var result = localReport.Execute(RenderType.Pdf, extension, parameters, mimtype);

            return File(result.MainStream, "application/pdf");
        }
    }
}
