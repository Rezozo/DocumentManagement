using documentManagement.models;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text.pdf.draw;

namespace documentManagement.files
{
    public class FileCreater
    {

        public void GenerateTXT(string fileName, Deal deal)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = fileName;
            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt";

            string filePath;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = saveFileDialog.FileName;
            }
            else
            {
                return;
            }

            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.WriteLine("                                                      Договор оказания образовательных услуг");
                sw.WriteLine($"Г. Москва {deal.date.ToShortDateString()} года");
                sw.WriteLine($"ООО «Центр образования», в лице генерального директора Кривоконева Кирилла Алексеевича," +
                    $" действующего на основании Устава общества, именуемого в дальнейшем Исполнитель, с одной стороны");
                sw.WriteLine("И");
                string phoneNumber = deal.physicalFace.phoneNumber;
                sw.WriteLine($"{deal.physicalFace.lastName + " " + deal.physicalFace.firstName + " " + deal.physicalFace.middleName}, " +
                    $"{deal.physicalFace.dateOfBirth.ToShortDateString()} года рождения, " +
                    $"проживающий по адресу: {deal.physicalFace.address}, " +
                    $"паспорт: серия {deal.physicalFace.passportData.Split(' ')[0]}, номер {deal.physicalFace.passportData.Split(' ')[1]}, " +
                    $"выданный отделом УФМС России по Тюменской области в городе Тюмень " +
                    $"{deal.physicalFace.dateOfBirth.ToShortDateString()}, " +
                    $"номер телефона: {$"+7 ({phoneNumber.Substring(1, 3)}) {phoneNumber.Substring(4, 3)}-{phoneNumber.Substring(7, 2)}-{phoneNumber.Substring(9, 2)}"}, именуемый в дальнейшем Заказчик, с другой стороны");
                sw.WriteLine("заключили настоящий договор о нижеследующем");
                sw.WriteLine("Предмет");
                sw.WriteLine("В соответствии с настоящим соглашением Исполнитель в лице ООО «Центр образования» " +
                    $"обязуется оказать Заказчику в лице {deal.physicalFace.lastName + " " + deal.physicalFace.firstName + " " + deal.physicalFace.middleName}, " +
                    "за оговоренную договором плату, следующие образовательные услуги:");
                foreach (EducationProgram education in deal.educationPrograms)
                {
                    sw.WriteLine("  ● " + education.title);
                }
                sw.WriteLine("Заключительные положения");
                sw.WriteLine("  ● Настоящий договор составлен в двух экземплярах. Один экземпляр передается Заказчику, другой передается Исполнителю.");
                sw.WriteLine("  ● По всем моментам, которые не оговорены в настоящем соглашении, стороны руководствуются действующим законодательством Российской Федерации.");
                sw.WriteLine();
                sw.WriteLine("Подпись директора");
                sw.WriteLine("Подпись плательщика");
            }
        }

        public void GeneratePDF(string fileName, Deal deal)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = fileName;
            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt";

            string filePath;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = saveFileDialog.FileName;
            }
            else
            {
                return;
            }

            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                Document document = new Document();
                BaseFont baseFont = BaseFont.CreateFont("C:\\Windows\\Fonts\\arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, 12);
                iTextSharp.text.Font boldFont = new iTextSharp.text.Font(baseFont, 12, iTextSharp.text.Font.BOLD);
                using (PdfWriter writer = PdfWriter.GetInstance(document, fs))
                {
                    document.Open();
                    document.Add(new Paragraph("                                            Договор оказания образовательных услуг", boldFont));
                    document.Add(new Paragraph($"Г. Москва {deal.date.ToShortDateString()} года", font));
                    document.Add(new Paragraph($"ООО «Центр образования», в лице генерального директора Кривоконева Кирилла Алексеевича," +
                        $" действующего на основании Устава общества, именуемого в дальнейшем Исполнитель, с одной стороны", font));
                    document.Add(new Paragraph("И", font));
                    string phoneNumber = deal.physicalFace.phoneNumber;
                    document.Add(new Paragraph($"{deal.physicalFace.lastName + " " + deal.physicalFace.firstName + " " + deal.physicalFace.middleName}, " +
                        $"{deal.physicalFace.dateOfBirth.ToShortDateString()} года рождения, " +
                        $"проживающий по адресу: {deal.physicalFace.address}, " +
                        $"паспорт: серия {deal.physicalFace.passportData.Split(' ')[0]}, номер {deal.physicalFace.passportData.Split(' ')[1]}, " +
                        $"выданный отделом УФМС России по Тюменской области в городе Тюмень " +
                        $"{deal.physicalFace.dateOfBirth.ToShortDateString()}, " +
                        $"номер телефона: {$"+7 ({phoneNumber.Substring(1, 3)}) {phoneNumber.Substring(4, 3)}-{phoneNumber.Substring(7, 2)}-{phoneNumber.Substring(9, 2)}"}, именуемый в дальнейшем Заказчик, с другой стороны", font));
                    document.Add(new Paragraph("заключили настоящий договор о нижеследующем", font));
                    document.Add(new Paragraph("Предмет", boldFont));
                    document.Add(new Paragraph("В соответствии с настоящим соглашением Исполнитель в лице ООО «Центр образования» " +
                        $"обязуется оказать Заказчику в лице {deal.physicalFace.lastName + " " + deal.physicalFace.firstName + " " + deal.physicalFace.middleName}, " +
                        "за оговоренную договором плату, следующие образовательные услуги:", font));
                    foreach (EducationProgram education in deal.educationPrograms)
                    {
                        document.Add(new Paragraph("    ● " + education.title, font));
                    }
                    document.Add(new Paragraph("Заключительные положения", boldFont));
                    document.Add(new Paragraph("    ● Настоящий договор составлен в двух экземплярах. Один экземпляр передается Заказчику, другой передается Исполнителю.", font));
                    document.Add(new Paragraph("    ● По всем моментам, которые не оговорены в настоящем соглашении, стороны руководствуются действующим законодательством Российской Федерации.", font));
                    document.Add(new Paragraph(""));
                    document.Add(new Paragraph("Подпись директора", boldFont));
                    document.Add(new Paragraph("Подпись плательщика", boldFont));

                    document.Close();
                }
            }
        }

        public void GeneratePdfPaymentList(string fileName, Deal deal)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = fileName;
            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt";

            string filePath;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = saveFileDialog.FileName;
            }
            else
            {
                return;
            }

            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                Document document = new Document();
                BaseFont baseFont = BaseFont.CreateFont("C:\\Windows\\Fonts\\arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                iTextSharp.text.Font bigfont = new iTextSharp.text.Font(baseFont, 12);
                iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, 8);
                iTextSharp.text.Font smallFont = new iTextSharp.text.Font(baseFont, 5);
                iTextSharp.text.Font boldFont = new iTextSharp.text.Font(baseFont, 12, iTextSharp.text.Font.BOLD);
                using (PdfWriter writer = PdfWriter.GetInstance(document, fs))
                {
                    document.Open();
                    PdfPTable table = new PdfPTable(2);
                    table.SetWidths(new float[] { 50, 120 });

                    PdfPCell leftCell = new PdfPCell();
                    Paragraph title = new Paragraph("Квитанция", bigfont);
                    title.Alignment = Element.ALIGN_CENTER;
                    title.SpacingBefore = 5f;
                    leftCell.AddElement(title);
                    System.Drawing.Image img = Properties.Resources.qr;
                    iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(img, System.Drawing.Imaging.ImageFormat.Jpeg);
                    leftCell.AddElement(image);
                    table.AddCell(leftCell);

                    PdfPCell rightCell = new PdfPCell();
                    LineSeparator lineSeparator = new LineSeparator(0.0F, 101.0F, BaseColor.BLACK, Element.ALIGN_LEFT, 1);
                    Paragraph line = new Paragraph(new Chunk(lineSeparator));
                    line.SetLeading(0.5F, 0.5F);

                    Paragraph formTitle = new Paragraph("Форма №ПД-4", smallFont);
                    formTitle.Alignment = Element.ALIGN_CENTER;
                    rightCell.AddElement(formTitle);
                    Paragraph consumer = new Paragraph("ООО «Центр образования»", font);
                    consumer.Alignment = Element.ALIGN_CENTER;
                    rightCell.AddElement(consumer);
                    rightCell.AddElement(line);
                    Paragraph counsumerTitleDesc = new Paragraph("(наименование получателя платежа)", smallFont);
                    counsumerTitleDesc.Alignment = Element.ALIGN_CENTER;
                    rightCell.AddElement(counsumerTitleDesc);
                    rightCell.AddElement(new Paragraph("    ИНН 060834123664 КПП 255505341          30101810400000000886", font));
                    rightCell.AddElement(line);
                    rightCell.AddElement(new Paragraph("        (инн получателя платежа)                                        (номер счёта получателя платежа)", smallFont));
                    Paragraph bank = new Paragraph("БИК 964004621 (ОТДЕЛЕНИЕ БАНКА РОССИИ//УФК по Воронежской области г. Воронеж", font);
                    bank.Alignment = Element.ALIGN_CENTER;
                    rightCell.AddElement(bank);
                    rightCell.AddElement(line);
                    Paragraph bankTitleDesc = new Paragraph("(наименование банка получателя платежа)", smallFont);
                    bankTitleDesc.Alignment = Element.ALIGN_CENTER;
                    rightCell.AddElement(bankTitleDesc);
                    rightCell.AddElement(new Paragraph($"Договор: {deal.id}", font));
                    rightCell.AddElement(line);
                    rightCell.AddElement(new Paragraph($"ФИО обучающегося: " +
                        $"{deal.physicalFace.lastName + " " + deal.physicalFace.firstName + " " + deal.physicalFace.middleName}", font));
                    rightCell.AddElement(line);
                    rightCell.AddElement(new Paragraph("Назначение: Оплата за курсы", font));
                    rightCell.AddElement(line);
                    rightCell.AddElement(new Paragraph($"ФИО плательщика: " +
                        $"{deal.physicalFace.lastName + " " + deal.physicalFace.firstName + " " + deal.physicalFace.middleName}", font));
                    rightCell.AddElement(line);
                    rightCell.AddElement(new Paragraph($"Адрес плательщика: {deal.physicalFace.address}", font));
                    rightCell.AddElement(line);
                    rightCell.AddElement(new Paragraph($"КБК: 18210441010983012110", font));
                    rightCell.AddElement(line);
                    rightCell.AddElement(new Paragraph($"ОКТМО: 12345678", font));
                    rightCell.AddElement(line);
                    rightCell.AddElement(new Paragraph($"Сумма: {deal.totalCost} рублей", font));
                    rightCell.AddElement(line);
                    rightCell.AddElement(new Paragraph("С условиями приёма указанной в платёжном документе суммы, в т.ч. " +
                       "с суммой взимаемой платы за услуги банка ознакомлен и согласен.        Подпись плательщика ________________\\", smallFont));

                    table.AddCell(rightCell);

                    document.Add(table);

                    document.Close();
                }
            }
        }
    }
}
