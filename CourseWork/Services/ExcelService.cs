using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Services
{
    using ClosedXML.Excel;
    using Dal;

    class ExcelService: BaseService
    {
        public void SaveToExcel(string fileName, List<Cargo> cargoes)
        {
            var wb = new XLWorkbook();
            var ws = wb.Worksheets.Add("Грузы");
            ws.Cell("A1").Value = "Наименование";
            ws.Cell("B1").Value = "Вес единицы (кг)";
            ws.Cell("C1").Value = "Количество";

            var rowId = 2;
            cargoes.ForEach(cargo =>
            {
                ws.Cell($"A{rowId}").Value = cargo.Name;
                ws.Cell($"B{rowId}").Value = cargo.Weight;
                ws.Cell($"C{rowId}").Value = cargo.Quantity;
                rowId++;
            });

            ws.Columns(1, 3).AdjustToContents();

            wb.SaveAs(fileName);
        }
    }
}
