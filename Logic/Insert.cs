using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using log4net;
using Npgsql;
using System.Web.Services.Description;
using SoapService.Models;
using static SoapService.Models.models;

namespace SoapService.Logic
{
    public class Insert
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(Insert));
        NpgsqlConnection _connection = default;
        //Test
        private const string CONNECTION_STRING = "Host=localhost;Port=5438;Database=mydatabase;Username=myuser;Password=mypassword;";
        //Prod
        //private const string CONNECTION_STRING = "Host=192.168.133.10;Port=5432;Database=enisprod;Username=enispfr;Password=enispfr123;";
        public int AddNotaryRequest(Person person)
        {
            using (var connection = new NpgsqlConnection(CONNECTION_STRING))
            {
                connection.Open();
                int personId = 0;
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        string query = @"
                            INSERT INTO public.person (iin, surname, name, patronymic, engfirstname, engsurname, birthdate, deathdate, gender, nationality, citizenship, lifestatus, birthcertificate, deathcertificate, citizenshipbegindate, citizenshipenddate, removed)
                            VALUES (@Id, @IIN, @Surname, @Name, @Patronymic, @EngFirstName, @EngSurname, @BirthDate, @DeathDate, @Gender, @Nationality, @Citizenship, @LifeStatus, @BirthCertificate, @DeathCertificate, @CitizenshipBeginDate, @CitizenshipEndDate, @Removed)";

                        using (var command = new NpgsqlCommand(query, connection,transaction))
                        {
                            //command.Parameters.AddWithValue("@ID", person.id ?? (object)DBNull.Value);
                            command.Parameters.AddWithValue("@IIN", person.iin ?? (object)DBNull.Value);
                            command.Parameters.AddWithValue("@Surname", person.surname ?? (object)DBNull.Value);
                            command.Parameters.AddWithValue("@Name", person.name ?? (object)DBNull.Value);
                            command.Parameters.AddWithValue("@Patronymic", person.patronymic ?? (object)DBNull.Value);
                            command.Parameters.AddWithValue("@EngFirstName", person.engFirstName ?? (object)DBNull.Value);
                            command.Parameters.AddWithValue("@EngSurname", person.engSurname ?? (object)DBNull.Value);
                            command.Parameters.AddWithValue("@BirthDate", person.birthDate);
                            if (person.deathDate > DateTime.MinValue || person.deathDate != null)
                                command.Parameters.AddWithValue("@DeathDate", person.deathDate);
                            else
                                command.Parameters.AddWithValue("@DeathDate", DBNull.Value);
                            command.Parameters.AddWithValue("@Gender", person.gender ?? (object)DBNull.Value);
                            command.Parameters.AddWithValue("@Nationality", person.nationality ?? (object)DBNull.Value);
                            command.Parameters.AddWithValue("@Citizenship", person.citizenship ?? (object)DBNull.Value);
                            command.Parameters.AddWithValue("@LifeStatus", person.lifeStatus ?? (object)DBNull.Value);
                            command.Parameters.AddWithValue("@CitizenshipBeginDate", person.citizenshipBeginDate);
                            command.Parameters.AddWithValue("@CitizenshipEndDate", person.citizenshipEndDate);
                            command.Parameters.AddWithValue("@Removed", person.removed);
                            personId = (int)command.ExecuteScalar();
                            logger.Debug($"PersonId = {personId}");

                        }

                        if (personId <= 0)
                        {
                            logger.Error($"Ошибка сохранения person_info");
                            return 0;
                        }

                        //Сохранение Documnets если есть
                        if (person.documents != null )
                        {
                            var save_documnets = AddDocuments(person, personId, transaction);
                            if (save_documnets <= 0)
                            {
                                logger.Error($"Ошибка сохранения Participants ");
                                return 0;
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        throw new Exception($"Ошибка сохранения запроса: {e}");

                    }
                }
            }
            return 1;
        }

        public int AddDocuments(Person person, int personId, NpgsqlTransaction transaction)
        {
            try
            {

                foreach (var document in person.documents)
                {
                    using (var connection = new NpgsqlConnection(CONNECTION_STRING))
                    {
                        string documentQuery = @"
                                    INSERT INTO public.document (person_id, document_type, document_number, issue_date, expiry_date)
                                    VALUES (@PersonId, @DocumentType, @DocumentNumber, @IssueDate, @ExpiryDate)";

                        using (var documentCommand = new NpgsqlCommand(documentQuery, connection, transaction))
                        {
                            documentCommand.Parameters.AddWithValue("@PersonId", person.id);
                            documentCommand.Parameters.AddWithValue("@DocumentType", document.type ?? (object)DBNull.Value);
                            documentCommand.Parameters.AddWithValue("@DocumentNumber", document.number ?? (object)DBNull.Value);
                            documentCommand.Parameters.AddWithValue("@IssueDate", document.beginDate);
                            documentCommand.Parameters.AddWithValue("@ExpiryDate", document.endDate);

                            documentCommand.ExecuteNonQuery();
                        }
                        connection.Close();
                    }
                }
                logger.Debug("Participants saved");
                return 1;
                
            }
            catch (Exception ex)
            {
                logger.Error($"Participants is not saved ||| {ex.Message} ||| {ex.InnerException}");
                return 0;
            }
        }
    }
}