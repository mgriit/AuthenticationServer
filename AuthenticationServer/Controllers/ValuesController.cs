using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jsreport.AspNetCore;
using jsreport.Types;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationServer.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [MiddlewareFilter(typeof(JsReportPipeline))]
        public IActionResult Invoice()
        {
            HttpContext.JsReportFeature().Recipe(Recipe.PhantomPdf);

            return View(new { name="Golam"});
        }

        //[MiddlewareFilter(typeof(JsReportPipeline))]
        //public IActionResult InvoiceDownload()
        //{
        //    HttpContext.JsReportFeature().Recipe(Recipe.PhantomPdf)
        //        .OnAfterRender((r) => HttpContext.Response.Headers["Content-Disposition"] = "attachment; filename=\"myReport.pdf\"");

        //    return View("Invoice", InvoiceModel.Example());
        //}

        //[MiddlewareFilter(typeof(JsReportPipeline))]
        //public async Task<IActionResult> InvoiceWithHeader()
        //{
        //    var header = await JsReportMVCService.RenderViewToStringAsync(HttpContext, "kkk", "Header", new {h="k"});

        //    HttpContext.JsReportFeature()
        //        .Recipe(Recipe.PhantomPdf)
        //        .Configure((r) => r.Template.Phantom = new Phantom { Header = header });

        //    return View("Invoice", InvoiceModel.Example());
        //}

        //[MiddlewareFilter(typeof(JsReportPipeline))]
        //public IActionResult Items()
        //{
        //    HttpContext.JsReportFeature()
        //        .Recipe(Recipe.HtmlToXlsx);

        //    return View(InvoiceModel.Example());
        //}

        //[MiddlewareFilter(typeof(JsReportPipeline))]
        //public IActionResult ItemsExcelOnline()
        //{
        //    HttpContext.JsReportFeature()
        //        .Configure(req => req.Options.Preview = true)
        //        .Recipe(Recipe.HtmlToXlsx);

        //    return View("Items", InvoiceModel.Example());
        //}

        //[MiddlewareFilter(typeof(JsReportPipeline))]
        //public IActionResult InvoiceDebugLogs()
        //{
        //    HttpContext.JsReportFeature()
        //        .DebugLogsToResponse()
        //        .Recipe(Recipe.PhantomPdf);

        //    return View("Invoice", InvoiceModel.Example());
        //}
    }
}
