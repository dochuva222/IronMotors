using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;

namespace IronMotors.Models
{
    public class WordReport
    {
        private static Word.Application WordApp = new Word.Application();
        private Word.Document CurrentDocument { get; set; }

        public WordReport()
        {
            CurrentDocument = WordApp.Documents.Add();
        }

        public void AddParagraph(string text, Word.WdBuiltinStyle style)
        {
            var paragraph = CurrentDocument.Paragraphs.Add();
            paragraph.Range.Text = text;
            paragraph.Range.set_Style(style);
            paragraph.Range.InsertParagraphAfter();
        }

        public void AddTable<T>(List<T> data, Dictionary<string, string> synonyms)
        {
            var props = typeof(T).GetProperties();
            var tableParagraph = CurrentDocument.Paragraphs.Add();
            var table = CurrentDocument.Tables.Add(tableParagraph.Range, data.Count + 1, props.Length);
            table.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
            table.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
            for (int i = 0; i < props.Length; i++)
            {
                table.Cell(1, i + 1).Range.Text = synonyms.FirstOrDefault(d => d.Key == props[i].Name).Value;
            }
            int row = 2;
            foreach (var item in data)
            {
                for (int i = 0; i < props.Length; i++)
                {
                    table.Cell(row, i + 1).Range.Text = props[i].GetValue(item).ToString();
                }
                row++;
            }
            tableParagraph.Range.InsertParagraphAfter();
        }

        public void SaveReport(ReportType reportType)
        {
            var dialog = new SaveFileDialog();
            if (reportType == ReportType.docx)
                dialog.Filter = ".docx | *.docx;";
            else
                dialog.Filter = ".pdf | *.pdf;";
            if (dialog.ShowDialog().GetValueOrDefault())
            {
                if (reportType == ReportType.pdf)
                    CurrentDocument.SaveAs2(dialog.FileName, Word.WdExportFormat.wdExportFormatPDF);
                else
                    CurrentDocument.SaveAs2(dialog.FileName);
                CurrentDocument.Close();
            }
        }
    }
}
