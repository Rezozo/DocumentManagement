using documentManagement.models;
using Npgsql;
using System.Collections.Generic;

namespace documentManagement.provider
{
    public class EducationProvider
    {
        private NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=Document;User Id=postgres;Password=0987");

        public List<EducationProgram> getAll()
        {
            List<EducationProgram> educationPrograms = new List<EducationProgram>();
            connection.Open();
            var command = new NpgsqlCommand("SELECT * FROM education_program", connection);
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                EducationProgram program = new EducationProgram();
                program.id = (int)reader["id"];
                program.title = (string)reader["title"];
                program.cost = (decimal)reader["cost"];
                program.qualification = (string)reader["qualification"];
                program.period = (string)reader["period"];
                educationPrograms.Add(program);
            }

            reader.Close();
            connection.Close();
            return educationPrograms;
        }

        public bool isUniqueTitle(string title)
        {
            connection.Open();
            var command = new NpgsqlCommand("Select COUNT(1) from education_program where title=@title", connection);
            command.Parameters.AddWithValue("title", title);

            long countRow = (long)command.ExecuteScalar();
            connection.Close();
            if (countRow == 0) { return true; }
            return false;
        }

        public void insertProgram(EducationProgram program)
        {
            connection.Open();
            var insertCommand = new NpgsqlCommand("INSERT INTO education_program (id, title, cost, qualification, period) " +
                                                  "VALUES (nextval('education_id_seq'), @title, @cost, @qualification, @period)", connection);
            insertCommand.Parameters.AddWithValue("title", program.title);
            insertCommand.Parameters.AddWithValue("cost", program.cost);
            insertCommand.Parameters.AddWithValue("qualification", program.qualification);
            insertCommand.Parameters.AddWithValue("period", program.period);
            insertCommand.ExecuteNonQuery();
            connection.Close();
        }

        public void updateProgram(EducationProgram program)
        {
            connection.Open();
            var updateCommand = new NpgsqlCommand("UPDATE education_program SET title = @title, cost = @cost, " +
                                                  "qualification = @qualification, period = @period WHERE id = @id", connection);
            updateCommand.Parameters.AddWithValue("id", program.id);
            updateCommand.Parameters.AddWithValue("title", program.title);
            updateCommand.Parameters.AddWithValue("cost", program.cost);
            updateCommand.Parameters.AddWithValue("qualification", program.qualification);
            updateCommand.Parameters.AddWithValue("period", program.period);
            updateCommand.ExecuteNonQuery();
            connection.Close();
        }

        public bool deleteById(int id)
        {
            try
            {
                connection.Open();
                var command = new NpgsqlCommand("Delete from education_program where id=@id", connection);
                command.Parameters.AddWithValue("id", id);
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            } catch
            {
                connection.Close();
                return false;
            }
        }
    }
}
