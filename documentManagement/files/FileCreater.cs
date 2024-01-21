using documentManagement.models;
using System;
using System.IO;
using System.Windows.Forms;

namespace documentManagement.files
{
    public class FileCreater
    {

        public void GenerateTXT(string fileName, Deal deal)
        {
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), fileName);

            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.WriteLine("                                      Договор оказания образовательных услуг");
                sw.WriteLine($"Г. Москва {deal.date.ToShortDateString()} года");
                sw.WriteLine($"ООО «Центр образования», в лице генерального директора Кривоконева Кирилла Алексеевича," +
                    $" действующего на основании Устава общества, именуемого в дальнейшем Исполнитель, с одной стороны");
                sw.WriteLine("И");
                sw.WriteLine($"{deal.physicalFace.lastName + " " + deal.physicalFace.firstName + " " + deal.physicalFace.middleName}, " +
                    $"{deal.physicalFace.dateOfBirth.ToShortDateString()} года рождения, " +
                    $"проживающий по адресу: {deal.physicalFace.address}, " +
                    $"паспорт: серия {deal.physicalFace.passportData.Split(' ')[0]}, номер {deal.physicalFace.passportData.Split(' ')[1]}, " +
                    $"выданный отделом УФМС России по Тюменской области в городе Тюмень " +
                    $"{deal.physicalFace.dateOfBirth.ToShortDateString()}, " +
                    $"номер телефона: {deal.physicalFace.phoneNumber}, именуемый в дальнейшем Заказчик, с другой стороны");
                sw.WriteLine("заключили настоящий договор о нижеследующем");
                sw.WriteLine("Предмет");
                sw.WriteLine("В соответствии с настоящим соглашением Исполнитель в лице ООО «Центр образования» " +
                    $"обязуется оказать Заказчику в лице {deal.physicalFace.lastName + " " + deal.physicalFace.firstName + " " + deal.physicalFace.middleName}, " +
                    "за оговоренную договором плату, следующие образовательные услуги:");
                foreach (EducationProgram education in deal.educationPrograms)
                {
                    sw.WriteLine("● " + education.title);
                }
                sw.WriteLine("Заключительные положения");
                sw.WriteLine("● Настоящий договор составлен в двух экземплярах. Один экземпляр передается Заказчику, другой передается Исполнителю.");
                sw.WriteLine("● По всем моментам, которые не оговорены в настоящем соглашении, стороны руководствуются действующим законодательством Российской Федерации.");
                sw.WriteLine();
                sw.WriteLine("Подпись директора");
                sw.WriteLine("Подпись плательщика");
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = fileName;
            //saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.Move(filePath, saveFileDialog.FileName);
            }
        }
    }
}
