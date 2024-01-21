using documentManagement.models;
using Npgsql;
using System;
using System.Collections.Generic;

namespace documentManagement.provider
{
    public class DealProvider
    {
        private NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=Document;User Id=postgres;Password=0987");

        public List<Deal> getAll()
        {
            connection.Open();
            var command1 = new NpgsqlCommand("SELECT d.id, d.date, d.total_cost, pf.last_name, pf.first_name, pf.patronymic, pf.date_of_birth, " +
                "pf.passport_data, pf.phone_number, pf.address FROM deal d INNER JOIN physical_face pf ON d.phisical_face_id = pf.id", connection);

            var reader = command1.ExecuteReader();

            List<Deal> deals = new List<Deal>();
            while (reader.Read())
            {
                Deal deal = new Deal();
                deal.id = (int)reader["id"];
                deal.date = (DateTime)reader["date"];
                deal.totalCost = (decimal)reader["total_cost"];

                PFace face = new PFace();
                face.lastName = (string)reader["last_name"];
                face.firstName = (string)reader["first_name"];
                face.middleName = (string)reader["patronymic"];
                face.dateOfBirth = (DateTime)reader["date_of_birth"];
                face.passportData = (string)reader["passport_data"];
                face.phoneNumber = (string)reader["phone_number"];
                face.address = (string)reader["address"];

                deal.physicalFace = face;

                deals.Add(deal);
            }
            reader.Close();

            foreach (Deal deal in deals)
            {
                var command2 = new NpgsqlCommand("select ep.title from deal_education de INNER JOIN education_program ep ON ep.id = de.education_program_id " +
                    "where deal_id=@dealId", connection);
                command2.Parameters.AddWithValue("dealId", deal.id);

                var reader2 = command2.ExecuteReader();
                List<EducationProgram> educationPrograms = new List<EducationProgram>();

                while (reader2.Read())
                {
                    EducationProgram educationProgram = new EducationProgram();
                    educationProgram.title = (string)reader2["title"];
                    educationPrograms.Add(educationProgram);
                }

                reader2.Close();

                deal.educationPrograms = educationPrograms;
            }

            connection.Close();

            return deals;
        }

        public Deal getById(int id)
        {
            connection.Open();
            var command1 = new NpgsqlCommand("SELECT d.id, d.date, d.total_cost, pf.last_name, pf.first_name, pf.patronymic, pf.date_of_birth, " +
                "pf.passport_data, pf.phone_number, pf.address FROM deal d INNER JOIN physical_face pf ON d.phisical_face_id = pf.id where d.id=@id", connection);
            command1.Parameters.AddWithValue("id", id);

            var reader = command1.ExecuteReader();

            Deal deal = new Deal();
            while (reader.Read())
            {
                deal.id = (int)reader["id"];
                deal.date = (DateTime)reader["date"];
                deal.totalCost = (decimal)reader["total_cost"];

                PFace face = new PFace();
                face.lastName = (string)reader["last_name"];
                face.firstName = (string)reader["first_name"];
                face.middleName = (string)reader["patronymic"];
                face.dateOfBirth = (DateTime)reader["date_of_birth"];
                face.passportData = (string)reader["passport_data"];
                face.phoneNumber = (string)reader["phone_number"];
                face.address = (string)reader["address"];

                deal.physicalFace = face;

            }
            reader.Close();


            var command2 = new NpgsqlCommand("select ep.title from deal_education de INNER JOIN education_program ep ON ep.id = de.education_program_id " +
                "where deal_id=@dealId", connection);
            command2.Parameters.AddWithValue("dealId", deal.id);

            var reader2 = command2.ExecuteReader();
            List<EducationProgram> educationPrograms = new List<EducationProgram>();

            while (reader2.Read())
            {
                EducationProgram educationProgram = new EducationProgram();
                educationProgram.title = (string)reader2["title"];
                educationPrograms.Add(educationProgram);
            }

            reader2.Close();

            deal.educationPrograms = educationPrograms;


            connection.Close();

            return deal;
        }

        public Deal createAndReturnDeal(List<EducationProgram> educationPrograms, PFace physFace, decimal totalCost)
        {
            connection.Open();
            var insertDealCommand = new NpgsqlCommand("INSERT INTO deal (id, date, total_cost, phisical_face_id) " +
                "VALUES (nextval('deal_id_seq'), @date, @total_cost, @physical_face_id) RETURNING id", connection);
            insertDealCommand.Parameters.AddWithValue("date", DateTime.Now);
            insertDealCommand.Parameters.AddWithValue("total_cost", totalCost);
            insertDealCommand.Parameters.AddWithValue("physical_face_id", physFace.Id);

            int dealId = (int)insertDealCommand.ExecuteScalar();

            foreach (EducationProgram educationProgram in educationPrograms)
            {
                var insertDealEducationCommand = new NpgsqlCommand("INSERT INTO deal_education (id, deal_id, education_program_id) " +
                    "VALUES (nextval('deal_education_id_seq'), @deal_id, @education_program_id)", connection);
                insertDealEducationCommand.Parameters.AddWithValue("deal_id", dealId);
                insertDealEducationCommand.Parameters.AddWithValue("education_program_id", educationProgram.id);

                insertDealEducationCommand.ExecuteNonQuery();
            }

            connection.Close();
            return getById(dealId);
        }
    }
}
