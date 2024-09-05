using ABCTraders.Models;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ABCTraders.Services
{
    internal class ReportService
    {

        public void GenerateExcelReport(List<OrderOut> orders, string filePath)
        {
            using (var workbook = new ClosedXML.Excel.XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Order Report");

                // Add header
                worksheet.Cell(1, 1).Value = "Order ID";
                worksheet.Cell(1, 2).Value = "User ID";
                worksheet.Cell(1, 3).Value = "Order Date";
                worksheet.Cell(1, 4).Value = "Status";
                worksheet.Cell(1, 5).Value = "Reason";
                worksheet.Cell(1, 6).Value = "Total Amount";

                // Add rows
                for (int i = 0; i < orders.Count; i++)
                {
                    worksheet.Cell(i + 2, 1).Value = orders[i].OrderID;
                    worksheet.Cell(i + 2, 2).Value = orders[i].UserID;
                    worksheet.Cell(i + 2, 3).Value = orders[i].OrderDate;
                    worksheet.Cell(i + 2, 4).Value = orders[i].Status;
                    worksheet.Cell(i + 2, 5).Value = orders[i].Reason ?? "N/A";
                    worksheet.Cell(i + 2, 6).Value = orders[i].TotalAmount;
                }

                // Save the workbook
                workbook.SaveAs(filePath);
            }
        }
    }
}
