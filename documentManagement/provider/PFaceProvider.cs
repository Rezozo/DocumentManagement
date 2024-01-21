using documentManagement.models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace documentManagement.provider
{
    public class PFaceProvider
    {
        private NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=Document;User Id=postgres;Password=0987");

        public List<PFace> getAll()
        {
            connection.Open();
            List<PFace> pFaces = new List<PFace>();
            var command = new NpgsqlCommand("SELECT * FROM physical_face", connection);
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                PFace pFace = new PFace();
                pFace.Id = (int)reader["id"];
                pFace.lastName = (string)reader["last_name"];
                pFace.firstName = (string)reader["first_name"];
                pFace.middleName = (string)reader["patronymic"];
                pFace.dateOfBirth = (DateTime)reader["date_of_birth"];
                pFace.passportData = (string)reader["passport_data"];
                pFace.address = (string)reader["address"];
                pFace.email = (string)reader["email"];
                pFace.phoneNumber = (string)reader["phone_number"];
                pFace.position = (string)reader["position"];
                pFace.workPlace = (string)reader["work_place"];
                pFaces.Add(pFace);
            }

            reader.Close();
            connection.Close();
            return pFaces;
        }

        public void saveFace(PFace face)
        {
            connection.Open();
            var insertCommand = new NpgsqlCommand("INSERT INTO physical_face (id, last_name, first_name, patronymic, date_of_birth, passport_data, address, email, phone_number, position, work_place) " +
                "VALUES (nextval('physical_id_seq'), @last_name, @first_name, @patronymic, @date_of_birth, @passport_data, @address, @email, @phone_number, @position, @work_place)", connection);
            insertCommand.Parameters.AddWithValue("last_name", face.lastName);
            insertCommand.Parameters.AddWithValue("first_name", face.firstName);
            insertCommand.Parameters.AddWithValue("patronymic", face.middleName);
            insertCommand.Parameters.AddWithValue("date_of_birth", face.dateOfBirth);
            insertCommand.Parameters.AddWithValue("passport_data", face.passportData);
            insertCommand.Parameters.AddWithValue("address", face.address);
            insertCommand.Parameters.AddWithValue("email", face.email);
            insertCommand.Parameters.AddWithValue("phone_number", face.phoneNumber);
            insertCommand.Parameters.AddWithValue("position", face.position);
            insertCommand.Parameters.AddWithValue("work_place", face.workPlace);
            insertCommand.ExecuteNonQuery();
            connection.Close();
        }

        public void updateFace(PFace face)
        {
            connection.Open();

            var updateCommand = new NpgsqlCommand("UPDATE physical_face SET last_name = @last_name, first_name = @first_name, " +
                                                  "patronymic = @patronymic, date_of_birth = @date_of_birth, passport_data = @passport_data, " +
                                                  "address = @address, email = @email, phone_number = @phone_number, position = @position, " +
                                                  "work_place = @work_place WHERE id = @id", connection);
            updateCommand.Parameters.AddWithValue("id", face.Id);
            updateCommand.Parameters.AddWithValue("last_name", face.lastName);
            updateCommand.Parameters.AddWithValue("first_name", face.firstName);
            updateCommand.Parameters.AddWithValue("patronymic", face.middleName);
            updateCommand.Parameters.AddWithValue("date_of_birth", face.dateOfBirth);
            updateCommand.Parameters.AddWithValue("passport_data", face.passportData);
            updateCommand.Parameters.AddWithValue("address", face.address);
            updateCommand.Parameters.AddWithValue("email", face.email);
            updateCommand.Parameters.AddWithValue("phone_number", face.phoneNumber);
            updateCommand.Parameters.AddWithValue("position", face.position);
            updateCommand.Parameters.AddWithValue("work_place", face.workPlace);

            updateCommand.ExecuteNonQuery();
            connection.Close();
        }


        public void deleteById(int id)
        {
            connection.Open();
            var command = new NpgsqlCommand("DELETE FROM physical_face where id=@id", connection);
            command.Parameters.AddWithValue("id", id);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
