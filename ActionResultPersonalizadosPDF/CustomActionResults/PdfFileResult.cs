using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionResultPersonalizadosPDF.Models
{
    public class PdfFileResult : ActionResult
    {
        private  string _titulo;
        private  string _stream;

        public PdfFileResult(string stream, string text)
        {
            _titulo = text;
            _stream = stream;
        }


        public override void ExecuteResult(ControllerContext context)
        {


            context.HttpContext.Response.ContentType = "application/pdf";
            context.HttpContext.Response.AddHeader("content-disposition", "attachment;filename="+_titulo+".pdf");
            generatePdf(context.HttpContext.Response.OutputStream,_stream);
        }

        
        public void generatePdf(Stream stream, string text)
        {
            //_titulo = text;
            var document = new Document();

            PdfWriter writer = PdfWriter.GetInstance(document, stream);
            document.Open();

            document.Add(new Paragraph(text, FontFactory.GetFont("Arial", 28, BaseColor.GRAY)));
            document.Add(new Paragraph(DateTime.Now.ToLongDateString()));

            document.Close();
            writer.Flush();
            writer.Close();

            
        }
    }
}