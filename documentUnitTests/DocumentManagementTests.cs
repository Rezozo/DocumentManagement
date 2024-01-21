using documentManagement;
using documentManagement.files;
using documentManagement.models;
using documentManagement.provider;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Npgsql;
using System;
using System.Collections.Generic;
using System.IO;

namespace documentUnitTests
{
    [TestClass]
    public class DocumentManagementTests
    {
        private UserProvider usersProvider;
        private PFaceProvider pFaceProvider;
        private DealProvider dealProvider;
        private EducationProvider educationProvider;

        [TestInitialize]
        public void Init()
        {
            usersProvider = new UserProvider();
            pFaceProvider = new PFaceProvider();
            dealProvider = new DealProvider();
            educationProvider = new EducationProvider();    
        }


        [TestMethod]
        public void TC_GenerateTxt_1()
        {
            var educationProgram1 = new EducationProgram(1, "Программа 1", "Квалификация 1", 1000, "6 месяцев");
            var educationProgram2 = new EducationProgram(2, "Программа 2", "Квалификация 2", 1500, "12 месяцев");

            var physicalFace = new PFace(1, "Иванов", "Иван", "Иванович", new DateTime(1990, 1, 1),
                "123412 1234", "г. Воронеж ул. Пушкина д. 21 кв. 21", "ivan@example.com", "79003078213", "Уборщик", "ООО \"Уборщики\"");

            var deal = new Deal(1, DateTime.Now, 2500, physicalFace, new List<EducationProgram> { educationProgram1, educationProgram2 });

            var fileName = "TestFile.txt";
            FileCreater fileCreater = new FileCreater();
            fileCreater.GenerateTXT(fileName, deal);

            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), fileName);
            var fileContents = File.ReadAllText(filePath);
            Assert.IsTrue(fileContents.Contains($"паспорт: серия {deal.physicalFace.passportData.Split(' ')[0]}, номер {deal.physicalFace.passportData.Split(' ')[1]},"));
            Assert.IsTrue(fileContents.Contains($"{educationProgram1.title}"));
            Assert.IsTrue(fileContents.Contains($"{educationProgram2.title}"));
        }

        [TestMethod]
        public void TC_isValidReg_1()
        {
            Assert.IsTrue(usersProvider.isValidReg("test111"));
        }

        [TestMethod]
        public void TC_ResetPassword_1()
        {
            string login = "login";
            string newPassword = "aaaaa123@";
            usersProvider.resetPassword(newPassword, login);
            Assert.IsTrue(usersProvider.isValidUser(login, newPassword));
        }

        [TestMethod]
        public void TC_CreateDeal_1()
        {
            PFace pFace = pFaceProvider.getAll()[0];
            List<EducationProgram> educationPrograms = educationProvider.getAll();
            decimal totalCost = 0;
            foreach (EducationProgram education in  educationPrograms)
            {
                totalCost += decimal.Parse(education.cost.ToString());
            }

            Deal newDeal = dealProvider.createAndReturnDeal(educationPrograms, pFace, totalCost);

            Assert.IsNotNull(newDeal);
            Assert.AreEqual(totalCost, newDeal.totalCost);
            Assert.AreEqual(pFace.firstName, newDeal.physicalFace.firstName);
            Assert.AreEqual(educationPrograms.Count, newDeal.educationPrograms.Count);
        }

        [TestMethod]
        public void TC_CreateEducationProgram_1()
        {
            var educationProgram = new EducationProgram(0, "Программа 1", "Квалификация 1", 1000, "6 месяцев");
            educationProvider.insertProgram(educationProgram);
            Assert.IsFalse(educationProvider.isUniqueTitle(educationProgram.title));
        }
    }
}
