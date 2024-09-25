using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using BorAutoWorkers.AppData;
using Microsoft.Office.Interop.Excel;

namespace BorAutoWorkers.Reports
{
    public class Reports
    {
        public void Employees()
        {
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application()
            {
                Visible = true,
                SheetsInNewWorkbook = 1
            };
            Microsoft.Office.Interop.Excel.Workbook work = app.Workbooks.Add(Type.Missing);
            app.DisplayAlerts = false;
            Microsoft.Office.Interop.Excel.Worksheet sheet = (Microsoft.Office.Interop.Excel.Worksheet)app.Worksheets.get_Item(1);
            sheet.Name = "pomogite";

            // Заголовки столбцов
            sheet.Cells[1, 1] = "Номер записи";
            sheet.Cells[1, 2] = "Фио";
            sheet.Cells[1, 3] = "Должнотсь";
            sheet.Cells[1, 4] = "Зар. плата";
            sheet.Cells[1, 5] = "Этаж";

            // Заполнение данных
            var currentRow = 2;
            foreach (var employee in Connection.context.Employee)
            {
                var position = Connection.context.Positions.FirstOrDefault(y => y.id == employee.position_id);
                var stage = Connection.context.Stages.FirstOrDefault(x => x.id == position.stage_id);

                sheet.Cells[currentRow, 1] = employee.id;
                sheet.Cells[currentRow, 2] = employee.name;
                sheet.Cells[currentRow, 3] = position.name;
                sheet.Cells[currentRow, 4] = employee.salary;
                sheet.Cells[currentRow, 5] = stage.name;

                currentRow++;
            }

            // Форматирование
            Microsoft.Office.Interop.Excel.Range rang = sheet.get_Range("A1", "E" + (currentRow - 1).ToString()); // Изменили "F12" на динамическое значение
            rang.Cells.Font.Name = "Times New Roman";
            rang.Font.Size = 14;
            rang.Font.Bold = true;
        }

        public void Positions()
        {
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application()
            {
                Visible = true,
                SheetsInNewWorkbook = 1
            };
            Microsoft.Office.Interop.Excel.Workbook work = app.Workbooks.Add(Type.Missing);
            app.DisplayAlerts = false;
            Microsoft.Office.Interop.Excel.Worksheet sheet = (Microsoft.Office.Interop.Excel.Worksheet)app.Worksheets.get_Item(1);
            sheet.Name = "pomogite";

            // Заголовки столбцов
            sheet.Cells[1, 1] = "Номер записи";
            sheet.Cells[1, 2] = "Должность";
            sheet.Cells[1, 3] = "Этаж";

            // Заполнение данных
            var currentRow = 2;
            foreach (var positions in Connection.context.Positions)
            {
                var stage = Connection.context.Stages.FirstOrDefault(x => x.id == positions.stage_id);

                sheet.Cells[currentRow, 1] = positions.id;
                sheet.Cells[currentRow, 2] = positions.name;
                sheet.Cells[currentRow, 3] = stage.name;

                currentRow++;
            }

            Microsoft.Office.Interop.Excel.Range rang = sheet.get_Range("A1", "E" + (currentRow - 1).ToString());
            rang.Cells.Font.Name = "Times New Roman";
            rang.Font.Size = 14;
            rang.Font.Bold = true;
        }

        public void Stages()
        {
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application()
            {
                Visible = true,
                SheetsInNewWorkbook = 1
            };
            Microsoft.Office.Interop.Excel.Workbook work = app.Workbooks.Add(Type.Missing);
            app.DisplayAlerts = false;
            Microsoft.Office.Interop.Excel.Worksheet sheet = (Microsoft.Office.Interop.Excel.Worksheet)app.Worksheets.get_Item(1);
            sheet.Name = "pomogite";

            // Заголовки столбцов
            sheet.Cells[1, 1] = "Номер записи";
            sheet.Cells[1, 2] = "Название";
            sheet.Cells[1, 3] = "Этаж";
            sheet.Cells[1, 4] = "Кол-во работников";

            // Заполнение данных
            var currentRow = 2;
            var a = 0;
            foreach (var stage in Connection.context.Stages)
            {
                var positions = Connection.context.Positions.FirstOrDefault(x => x.stage_id == stage.id);
                var EmployeeCount = Connection.context.Employee.Where(x => x.position_id == positions.id).Count();

                sheet.Cells[currentRow, 1] = stage.id;
                sheet.Cells[currentRow, 2] = stage.name;
                sheet.Cells[currentRow, 3] = stage.stage;
                sheet.Cells[currentRow, 4] = EmployeeCount;
                a += (int)EmployeeCount;

                currentRow++;
            }

            Microsoft.Office.Interop.Excel.Range rang = sheet.get_Range("A1", "E" + (currentRow).ToString());
            rang.Cells.Font.Name = "Times New Roman";
            rang.Font.Size = 14;
            rang.Font.Bold = true;
            sheet.Cells[currentRow, 1] = "итого                  ";
            sheet.Cells[currentRow, 4] = a;
        }

        public void Users()
        {
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application()
            {
                Visible = true,
                SheetsInNewWorkbook = 1
            };
            Microsoft.Office.Interop.Excel.Workbook work = app.Workbooks.Add(Type.Missing);
            app.DisplayAlerts = false;
            Microsoft.Office.Interop.Excel.Worksheet sheet = (Microsoft.Office.Interop.Excel.Worksheet)app.Worksheets.get_Item(1);
            sheet.Name = "pomogite";

            // Заголовки столбцов
            sheet.Cells[1, 1] = "Номер записи";
            sheet.Cells[1, 2] = "Логин";
            sheet.Cells[1, 3] = "Почта";
            sheet.Cells[1, 4] = "Права";

            // Заполнение данных
            var currentRow = 2;
            foreach (var user in Connection.context.Users)
            {
                var roles = Connection.context.Roles.FirstOrDefault(x => x.id == user.role_id);

                sheet.Cells[currentRow, 1] = user.id;
                sheet.Cells[currentRow, 2] = user.name;
                sheet.Cells[currentRow, 3] = user.email;
                sheet.Cells[currentRow, 4] = roles.priority;

                currentRow++;
            }

            Microsoft.Office.Interop.Excel.Range rang = sheet.get_Range("A1", "E" + (currentRow - 1).ToString());
            rang.Cells.Font.Name = "Times New Roman";
            rang.Font.Size = 14;
            rang.Font.Bold = true;
        }

        public void Close()
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}


