using ACS.Classes;
using Devart.Data.PostgreSql;
using DevExpress.CodeParser;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.MigracionACS.RRHH.Utilerias
{
    //    internal class UpdateEmployeeTMP
    //    {
    //    }

    public class UpdateEmployeeTMP
    {
        public int id { get; set; }
        public int resource_id { get; set; }
        public string name { get; set; }
        public bool active { get; set; }
        public int address_home_id { get; set; }
        public int country_id { get; set; }
        public string gender { get; set; }
        public string marital { get; set; }
        public string spouse_complete_name { get; set; }
        public DateTime? spouse_birthdate { get; set; }
        public int children { get; set; }
        public string place_of_birth { get; set; }
        public int country_of_birth { get; set; }
        public DateTime birthday { get; set; }
        public string identification_id { get; set; }
        public string certificate { get; set; }
        public string study_field { get; set; }
        public string study_school { get; set; }
        public string emergency_contact { get; set; }
        public string emergency_phone { get; set; }
        public string job_title { get; set; }
        public int address_id { get; set; }
        public string work_phone { get; set; }
        public string mobile_phone { get; set; }
        public string work_email { get; set; }
        public string work_location { get; set; }
        public int job_id { get; set; }
        public int department_id { get; set; }
        public int parent_id { get; set; }
        public int coach_id { get; set; }
        public int company_id { get; set; }
        public int resource_calendar_id { get; set; }
        public string barcode { get; set; }
        public string pin { get; set; }
        public int last_attendance_id { get; set; }
        public string manager { get; set; }
        public DateTime medic_exam { get; set; }
        public string vehicle { get; set; }
        public int profession_id { get; set; }
        public string college { get; set; }
        public string rtn { get; set; }
        public string blood_type { get; set; }
        public string employee_account { get; set; }
        public int bank_id { get; set; }
        public int roll_type_id { get; set; }
        public string shirt_size { get; set; }
        public string pant_size { get; set; }
        public string shoe_size { get; set; }
        public decimal height { get; set; }
        public decimal weight { get; set; }
        public string marking { get; set; }
        public string first_marca { get; set; }
        public int id_grupo { get; set; }
        public DateTime? x_hour_in { get; set; }
        public DateTime? x_hour_out { get; set; }
        public string x_conf_aplic { get; set; }
        public int x_id_journal { get; set; }
        public string x_code_card { get; set; }
        public bool x_verified { get; set; }
        public string insurance { get; set; }
        public bool dependents { get; set; }
        public bool x_sinc { get; set; }
        public bool x_update { get; set; }

        public UpdateEmployeeTMP()
        {
            id_grupo = 0;
        }

        public bool RecuperarRegistro(int id)
        {
            DataOperations dp = new DataOperations();
            PgSqlConnection dbConnection = new PgSqlConnection(dp.ConnectionStringODOO4);
            dbConnection.Open();
            string query = @"
            SELECT A.id, resource_id, A.name, A.active, address_home_id, country_id, gender, marital,
                spouse_complete_name, spouse_birthdate, children, place_of_birth, 
                country_of_birth, birthday, identification_id, certificate, study_field, 
                study_school, emergency_contact, emergency_phone, job_title, address_id, 
                work_phone, mobile_phone, work_email, work_location, job_id, department_id, 
                parent_id, coach_id, A.company_id, resource_calendar_id, barcode, pin, 
                last_attendance_id, manager, medic_exam, vehicle, profession_id, 
                college, rtn, blood_type, employee_account, bank_id, roll_type_id, 
                shirt_size, pant_size, shoe_size, height, weight, marking, first_marca, 
                id_grupo, x_hour_in, x_hour_out, x_conf_aplic, x_id_journal, x_code_card, 
                x_verified, insurance, dependents, x_sinc, x_update
            FROM public.hr_employee A
            JOIN public.resource_resource B ON A.resource_id = B.id
            WHERE A.id = @Id AND A.x_update = false AND B.active = true";

            using (PgSqlCommand command = new PgSqlCommand(query, dbConnection))
            {
                command.Parameters.AddWithValue("@Id", id);

                using (PgSqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        
                        id = reader.GetInt32(reader.GetOrdinal("id"));
                        resource_id = reader.GetInt32(reader.GetOrdinal("resource_id"));
                        name = reader.GetString(reader.GetOrdinal("name"));
                        active = reader.GetBoolean(reader.GetOrdinal("active"));
                        
                        if (!reader.IsDBNull(reader.GetOrdinal("address_home_id")))
                            address_home_id = reader.GetInt32(reader.GetOrdinal("address_home_id"));

                        if (!reader.IsDBNull(reader.GetOrdinal("country_id")))
                            country_id = reader.GetInt32(reader.GetOrdinal("country_id"));

                        if (!reader.IsDBNull(reader.GetOrdinal("gender")))
                            gender = reader.GetString(reader.GetOrdinal("gender"));

                        if (!reader.IsDBNull(reader.GetOrdinal("marital")))
                            marital = reader.GetString(reader.GetOrdinal("marital"));

                        if (!reader.IsDBNull(reader.GetOrdinal("spouse_complete_name")))
                            spouse_complete_name = reader.GetString(reader.GetOrdinal("spouse_complete_name"));
                        
                        spouse_birthdate = reader.IsDBNull(reader.GetOrdinal("spouse_birthdate")) ?(DateTime?)null :
                            reader.GetDateTime(reader.GetOrdinal("spouse_birthdate"));

                        //review
                        if (!reader.IsDBNull(reader.GetOrdinal("children")))
                            children = reader.GetInt32(reader.GetOrdinal("children"));

                        if (!reader.IsDBNull(reader.GetOrdinal("place_of_birth")))
                            place_of_birth = reader.GetString(reader.GetOrdinal("place_of_birth"));

                        if (!reader.IsDBNull(reader.GetOrdinal("country_of_birth")))
                            country_of_birth = reader.GetInt32(reader.GetOrdinal("country_of_birth"));

                        if (!reader.IsDBNull(reader.GetOrdinal("birthday")))
                            birthday = reader.GetDateTime(reader.GetOrdinal("birthday"));

                        if (!reader.IsDBNull(reader.GetOrdinal("identification_id")))
                            identification_id = reader.GetString(reader.GetOrdinal("identification_id"));

                        if (!reader.IsDBNull(reader.GetOrdinal("certificate")))
                            certificate = reader.GetString(reader.GetOrdinal("certificate"));

                        if (!reader.IsDBNull(reader.GetOrdinal("study_field")))
                            study_field = reader.GetString(reader.GetOrdinal("study_field"));

                        if (!reader.IsDBNull(reader.GetOrdinal("study_school")))
                            study_school = reader.GetString(reader.GetOrdinal("study_school"));

                        if (!reader.IsDBNull(reader.GetOrdinal("emergency_contact")))
                            emergency_contact = reader.GetString(reader.GetOrdinal("emergency_contact"));

                        if (!reader.IsDBNull(reader.GetOrdinal("emergency_phone")))
                            emergency_phone = reader.GetString(reader.GetOrdinal("emergency_phone"));

                        if (!reader.IsDBNull(reader.GetOrdinal("job_title")))
                            job_title = reader.GetString(reader.GetOrdinal("job_title"));

                        if (!reader.IsDBNull(reader.GetOrdinal("address_id")))
                            address_id = reader.GetInt32(reader.GetOrdinal("address_id"));

                        if (!reader.IsDBNull(reader.GetOrdinal("work_phone")))
                            work_phone = reader.GetString(reader.GetOrdinal("work_phone"));

                        if (!reader.IsDBNull(reader.GetOrdinal("mobile_phone")))
                            mobile_phone = reader.GetString(reader.GetOrdinal("mobile_phone"));

                        if (!reader.IsDBNull(reader.GetOrdinal("mobile_phone")))
                            work_email = reader.GetString(reader.GetOrdinal("work_email"));

                        if (!reader.IsDBNull(reader.GetOrdinal("work_location")))
                            work_location = reader.GetString(reader.GetOrdinal("work_location"));

                        if (!reader.IsDBNull(reader.GetOrdinal("job_id")))
                            job_id = reader.GetInt32(reader.GetOrdinal("job_id"));

                        if (!reader.IsDBNull(reader.GetOrdinal("department_id")))
                            department_id = reader.GetInt32(reader.GetOrdinal("department_id"));

                        if (!reader.IsDBNull(reader.GetOrdinal("department_id")))
                            parent_id = reader.GetInt32(reader.GetOrdinal("parent_id"));

                        if (!reader.IsDBNull(reader.GetOrdinal("coach_id")))
                            coach_id = reader.GetInt32(reader.GetOrdinal("coach_id"));

                        if (!reader.IsDBNull(reader.GetOrdinal("company_id")))
                            company_id = reader.GetInt32(reader.GetOrdinal("company_id"));

                        if (!reader.IsDBNull(reader.GetOrdinal("resource_calendar_id")))
                            resource_calendar_id = reader.GetInt32(reader.GetOrdinal("resource_calendar_id"));

                        if (!reader.IsDBNull(reader.GetOrdinal("barcode")))
                            barcode = reader.GetString(reader.GetOrdinal("barcode"));

                        if (!reader.IsDBNull(reader.GetOrdinal("pin")))
                            pin = reader.GetString(reader.GetOrdinal("pin"));

                        if (!reader.IsDBNull(reader.GetOrdinal("last_attendance_id")))
                            last_attendance_id = reader.GetInt32(reader.GetOrdinal("last_attendance_id"));

                        if (!reader.IsDBNull(reader.GetOrdinal("manager")))
                            manager = reader.GetString(reader.GetOrdinal("manager"));

                        if (!reader.IsDBNull(reader.GetOrdinal("medic_exam")))
                            medic_exam = reader.GetDateTime(reader.GetOrdinal("medic_exam"));

                        if (!reader.IsDBNull(reader.GetOrdinal("vehicle")))
                            vehicle = reader.GetString(reader.GetOrdinal("vehicle"));

                        if (!reader.IsDBNull(reader.GetOrdinal("profession_id")))
                            profession_id = reader.GetInt32(reader.GetOrdinal("profession_id"));

                        if (!reader.IsDBNull(reader.GetOrdinal("profession_id")))
                            college = reader.GetString(reader.GetOrdinal("college"));

                        if (!reader.IsDBNull(reader.GetOrdinal("rtn")))
                            rtn = reader.GetString(reader.GetOrdinal("rtn"));

                        if (!reader.IsDBNull(reader.GetOrdinal("blood_type")))
                            blood_type = reader.GetString(reader.GetOrdinal("blood_type"));

                        if (!reader.IsDBNull(reader.GetOrdinal("employee_account")))
                            employee_account = reader.GetString(reader.GetOrdinal("employee_account"));

                        if (!reader.IsDBNull(reader.GetOrdinal("bank_id")))
                            bank_id = reader.GetInt32(reader.GetOrdinal("bank_id"));

                        if (!reader.IsDBNull(reader.GetOrdinal("roll_type_id")))
                            roll_type_id = reader.GetInt32(reader.GetOrdinal("roll_type_id"));

                        if (!reader.IsDBNull(reader.GetOrdinal("shirt_size")))
                            shirt_size = reader.GetString(reader.GetOrdinal("shirt_size"));

                        if (!reader.IsDBNull(reader.GetOrdinal("shirt_size")))
                            pant_size = reader.GetString(reader.GetOrdinal("pant_size"));

                        if (!reader.IsDBNull(reader.GetOrdinal("shoe_size")))
                            shoe_size = reader.GetString(reader.GetOrdinal("shoe_size"));

                        if (!reader.IsDBNull(reader.GetOrdinal("height")))
                            height = reader.GetDecimal(reader.GetOrdinal("height"));

                        if (!reader.IsDBNull(reader.GetOrdinal("weight")))
                            weight = reader.GetDecimal(reader.GetOrdinal("weight"));

                        if (!reader.IsDBNull(reader.GetOrdinal("marking")))
                            marking = reader.GetString(reader.GetOrdinal("marking"));

                        if (!reader.IsDBNull(reader.GetOrdinal("first_marca")))
                            first_marca = reader.GetString(reader.GetOrdinal("first_marca"));

                        if (!reader.IsDBNull(reader.GetOrdinal("id_grupo")))
                            id_grupo = reader.GetInt32(reader.GetOrdinal("id_grupo"));

                            x_hour_in = reader.IsDBNull(reader.GetOrdinal("x_hour_in")) ? (DateTime?)null :
                            reader.GetDateTime(reader.GetOrdinal("x_hour_in"));
                        
                        x_hour_out = reader.IsDBNull(reader.GetOrdinal("x_hour_out")) ? (DateTime?)null :
                            reader.GetDateTime(reader.GetOrdinal("x_hour_out"));

                        if (!reader.IsDBNull(reader.GetOrdinal("x_conf_aplic")))
                            x_conf_aplic = reader.GetString(reader.GetOrdinal("x_conf_aplic"));

                        if (!reader.IsDBNull(reader.GetOrdinal("x_conf_aplic")))
                            x_id_journal = reader.GetInt32(reader.GetOrdinal("x_id_journal"));

                        if (!reader.IsDBNull(reader.GetOrdinal("x_code_card")))
                            x_code_card = reader.GetString(reader.GetOrdinal("x_code_card"));

                        if (!reader.IsDBNull(reader.GetOrdinal("x_code_card")))
                            x_verified = reader.GetBoolean(reader.GetOrdinal("x_verified"));

                        if (!reader.IsDBNull(reader.GetOrdinal("insurance")))
                            insurance = reader.GetString(reader.GetOrdinal("insurance"));

                        if (!reader.IsDBNull(reader.GetOrdinal("dependents")))
                            dependents = reader.GetBoolean(reader.GetOrdinal("dependents"));

                        if (!reader.IsDBNull(reader.GetOrdinal("x_sinc")))
                            x_sinc = reader.GetBoolean(reader.GetOrdinal("x_sinc"));

                        if (!reader.IsDBNull(reader.GetOrdinal("x_update")))
                            x_update = reader.GetBoolean(reader.GetOrdinal("x_update"));

                        return true;
                    }
                }
            }

            return false; // Retorna null si no se encuentra un empleado con el ID especificado.
        }

        public void UpdateEmployee(int pId)
        {
            id = pId;
            DataOperations dp = new DataOperations();
            string query = @"INSERT INTO public.x_hr_employee(
	                             resource_id, message_main_attachment_id, name, user_id, 
	                            active, address_home_id, country_id, gender, marital,
	                            spouse_complete_name, spouse_birthdate, children, place_of_birth,
	                            country_of_birth, birthday, ssnid, sinid, identification_id, passport_id,
	                            bank_account_id, permit_no, visa_no, visa_expire, additional_note, certificate,
	                            study_field, study_school, emergency_contact, emergency_phone, km_home_work, 
	                            google_drive_link, job_title, address_id, work_phone, mobile_phone, work_email, 
	                            work_location, job_id, department_id, parent_id, coach_id, notes, color, company_id, 
	                            resource_calendar_id, create_uid, create_date, write_uid, write_date, barcode, 
	                            pin, last_attendance_id, manager, medic_exam, vehicle, profession_id, payment_type, 
	                            college, rtn, blood_type, employee_account, bank_id, roll_type_id, shirt_size, 
	                            pant_size, shoe_size, height, weight, marking, first_marca, id_grupo, x_image, 
	                            x_hour_in, x_hour_out, x_conf_aplic, x_id_journal, x_code_card, x_verified, 
	                            insurance, dependents, x_sinc,id_employee,tipo_trans)
	                            SELECT  resource_id, message_main_attachment_id, name, user_id, active, address_home_id, 
	                            country_id, gender, marital, spouse_complete_name, spouse_birthdate, children, place_of_birth, 
	                            country_of_birth, birthday, ssnid, sinid, identification_id, passport_id, bank_account_id, 
	                            permit_no, visa_no, visa_expire, additional_note, certificate, study_field, study_school, 
	                            emergency_contact, emergency_phone, km_home_work, google_drive_link, job_title, address_id, 
	                            work_phone, mobile_phone, work_email, work_location, job_id, department_id, parent_id, 
	                            coach_id, notes, color, company_id, resource_calendar_id, create_uid, create_date, write_uid, 
	                            write_date, barcode, pin, last_attendance_id, manager, medic_exam, vehicle, profession_id, 
	                            payment_type, college, rtn, blood_type, employee_account, bank_id, roll_type_id, shirt_size, 
	                            pant_size, shoe_size, height, weight, marking, first_marca, id_grupo, x_image, x_hour_in, 
	                            x_hour_out, x_conf_aplic, x_id_journal, x_code_card, x_verified, insurance, dependents, 
	                            x_sinc,id,'original'
	                            FROM public.hr_employee
	                            where id = @id;";
            PgSqlConnection conn = new PgSqlConnection(dp.ConnectionStringODOO5);
            conn.Open();
            PgSqlCommand command = conn.CreateCommand();
            command.CommandText = query;
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();

            query = @"
            UPDATE public.hr_employee
            SET 
                name = :name,
                active = :active,
                address_home_id = :address_home_id,
                country_id = :country_id,
                gender = :gender,
                marital = :marital,
                spouse_complete_name = :spouse_complete_name,
                spouse_birthdate = :spouse_birthdate,
                children = :children,
                place_of_birth = :place_of_birth,
                country_of_birth = :country_of_birth,
                birthday = :birthday,
                identification_id = :identification_id,
                certificate = :certificate,
                study_field = :study_field,
                study_school = :study_school,
                emergency_contact = :emergency_contact,
                emergency_phone = :emergency_phone,
                job_title = :job_title,
                address_id = :address_id,
                work_phone = :work_phone,
                mobile_phone = :mobile_phone,
                work_email = :work_email,
                work_location = :work_location,
                job_id = :job_id,
                department_id = :department_id,
                parent_id = :parent_id,
                coach_id = :coach_id,
                company_id = :company_id,
                resource_calendar_id = :resource_calendar_id,
                barcode = :barcode,
                pin = :pin,
                last_attendance_id = :last_attendance_id,
                manager = :manager,
                medic_exam = :medic_exam,
                vehicle = :vehicle,
                profession_id = :profession_id,
                college = :college,
                rtn = :rtn,
                blood_type = :blood_type,
                employee_account = :employee_account,
                bank_id = :bank_id,
                roll_type_id = :roll_type_id,
                shirt_size = :shirt_size,
                pant_size = :pant_size,
                shoe_size = :shoe_size,
                height = :height,
                weight = :weight,
                marking = :marking,
                first_marca = :first_marca,
                id_grupo = :id_grupo,
                x_conf_aplic = :x_conf_aplic,
                x_id_journal = :x_id_journal,
                x_code_card = :x_code_card,
                x_verified = :x_verified,
                insurance = :insurance,
                dependents = :dependents,
                x_sinc = :x_sinc
            WHERE id = :id";

            //PgSqlConnection conn = new PgSqlConnection(dp.ConnectionStringODOO5);
            //conn.Open();
            command = conn.CreateCommand();
            command.CommandText = query;
            command.Parameters.AddWithValue("name", name);
            command.Parameters.AddWithValue("active", active);

            if(address_home_id==0)
                command.Parameters.AddWithValue("address_home_id", DBNull.Value);
            else
                command.Parameters.AddWithValue("address_home_id", address_home_id);

            if (country_id == 0)
                command.Parameters.AddWithValue("country_id", DBNull.Value);
            else
                command.Parameters.AddWithValue("country_id", country_id);

            if(string.IsNullOrEmpty(gender))
                command.Parameters.AddWithValue("gender", DBNull.Value);
            else
                command.Parameters.AddWithValue("gender", gender);

            if (string.IsNullOrEmpty(marital))
                command.Parameters.AddWithValue("marital", DBNull.Value);
            else
                command.Parameters.AddWithValue("marital", marital);

            if (string.IsNullOrEmpty(spouse_complete_name))
                command.Parameters.AddWithValue("spouse_complete_name", DBNull.Value);
            else
                command.Parameters.AddWithValue("spouse_complete_name", spouse_complete_name);

            if (spouse_birthdate == null)
            {
                command.Parameters.AddWithValue("spouse_birthdate", DBNull.Value);
            }
            else
            {
                if (spouse_birthdate.Value.Year > 1910)
                    command.Parameters.AddWithValue("spouse_birthdate", spouse_birthdate);
                else
                    command.Parameters.AddWithValue("spouse_birthdate", DBNull.Value);
            }

            if (children == 0)
                command.Parameters.AddWithValue("children", DBNull.Value);
            else
                command.Parameters.AddWithValue("children", children);

            if (string.IsNullOrEmpty(place_of_birth))
                command.Parameters.AddWithValue("place_of_birth", DBNull.Value);
            else
                command.Parameters.AddWithValue("place_of_birth", place_of_birth);

            if (country_of_birth == 0)
                command.Parameters.AddWithValue("country_of_birth", DBNull.Value);
            else
                command.Parameters.AddWithValue("country_of_birth", country_of_birth);

            if (birthday == null)
            {
                command.Parameters.AddWithValue("birthday", DBNull.Value);
            }
            else
            {
                if (birthday.Year > 1910)
                    command.Parameters.AddWithValue("birthday", birthday);
                else
                    command.Parameters.AddWithValue("birthday", DBNull.Value);
            }

            if (string.IsNullOrEmpty(identification_id))
                command.Parameters.AddWithValue("identification_id", DBNull.Value);
            else
                command.Parameters.AddWithValue("identification_id", identification_id);

            if (string.IsNullOrEmpty(certificate))
                command.Parameters.AddWithValue("certificate", DBNull.Value);
            else
                command.Parameters.AddWithValue("certificate", certificate);

            if (string.IsNullOrEmpty(study_field))
                command.Parameters.AddWithValue("study_field", DBNull.Value);
            else
                command.Parameters.AddWithValue("study_field", study_field);

            if (string.IsNullOrEmpty(study_school))
                command.Parameters.AddWithValue("study_school", DBNull.Value);
            else
                command.Parameters.AddWithValue("study_school", study_school);

            if (string.IsNullOrEmpty(emergency_contact))
                command.Parameters.AddWithValue("emergency_contact", DBNull.Value);
            else
                command.Parameters.AddWithValue("emergency_contact", emergency_contact);

            if (string.IsNullOrEmpty(emergency_contact))
                command.Parameters.AddWithValue("emergency_phone", DBNull.Value);
            else
                command.Parameters.AddWithValue("emergency_phone", emergency_phone);

            if (string.IsNullOrEmpty(job_title))
                command.Parameters.AddWithValue("job_title", DBNull.Value);
            else
                command.Parameters.AddWithValue("job_title", job_title);

            if (address_id == 0)
                command.Parameters.AddWithValue("address_id", DBNull.Value);
            else
                command.Parameters.AddWithValue("address_id", address_id);

            if (string.IsNullOrEmpty(work_phone))
                command.Parameters.AddWithValue("work_phone", DBNull.Value);
            else
                command.Parameters.AddWithValue("work_phone", work_phone);

            if (string.IsNullOrEmpty(mobile_phone))
                command.Parameters.AddWithValue("mobile_phone", DBNull.Value);
            else
                command.Parameters.AddWithValue("mobile_phone", mobile_phone);

            if (string.IsNullOrEmpty(work_email))
                command.Parameters.AddWithValue("work_email", DBNull.Value);
            else
                command.Parameters.AddWithValue("work_email", work_email);

            if (string.IsNullOrEmpty(work_location))
                command.Parameters.AddWithValue("work_location", DBNull.Value);
            else
                command.Parameters.AddWithValue("work_location", work_location);

            if (job_id == 0)
                command.Parameters.AddWithValue("job_id", DBNull.Value);
            else
                command.Parameters.AddWithValue("job_id", job_id);

            if (department_id == 0)
                command.Parameters.AddWithValue("department_id", DBNull.Value);
            else
                command.Parameters.AddWithValue("department_id", department_id);

            if (parent_id == 0)
                command.Parameters.AddWithValue("parent_id", DBNull.Value);
            else
                command.Parameters.AddWithValue("parent_id", parent_id);

            if (coach_id == 0)
                command.Parameters.AddWithValue("coach_id", DBNull.Value);
            else
                command.Parameters.AddWithValue("coach_id", coach_id);

            if (company_id == 0)
                command.Parameters.AddWithValue("company_id", DBNull.Value);
            else
                command.Parameters.AddWithValue("company_id", company_id);

            if (resource_calendar_id == 0)
                command.Parameters.AddWithValue("resource_calendar_id", DBNull.Value);
            else
                command.Parameters.AddWithValue("resource_calendar_id", resource_calendar_id);

            if (string.IsNullOrEmpty(barcode))
                command.Parameters.AddWithValue("barcode", DBNull.Value);
            else
                command.Parameters.AddWithValue("barcode", barcode);

            if (string.IsNullOrEmpty(pin))
                command.Parameters.AddWithValue("pin", pin);
            else
                command.Parameters.AddWithValue("pin", pin);

            if (last_attendance_id == 0)
                command.Parameters.AddWithValue("last_attendance_id", DBNull.Value);
            else
                command.Parameters.AddWithValue("last_attendance_id", last_attendance_id);

            command.Parameters.AddWithValue("manager", manager);

            if (medic_exam == null)
            {
                command.Parameters.AddWithValue("medic_exam", DBNull.Value);
            }
            else
            {
                if (birthday.Year > 1910)
                    command.Parameters.AddWithValue("medic_exam", medic_exam);
                else
                    command.Parameters.AddWithValue("medic_exam", DBNull.Value);
            }

            if (string.IsNullOrEmpty(vehicle))
                command.Parameters.AddWithValue("vehicle", DBNull.Value);
            else
                command.Parameters.AddWithValue("vehicle", vehicle);

            if (last_attendance_id == 0)
                command.Parameters.AddWithValue("profession_id", DBNull.Value);
            else
                command.Parameters.AddWithValue("profession_id", profession_id);

            if (string.IsNullOrEmpty(college))
                command.Parameters.AddWithValue("college", DBNull.Value);
            else
                command.Parameters.AddWithValue("college", college);

            if (string.IsNullOrEmpty(rtn))
                command.Parameters.AddWithValue("rtn", DBNull.Value);
            else
                command.Parameters.AddWithValue("rtn", rtn);

            if (string.IsNullOrEmpty(blood_type))
                command.Parameters.AddWithValue("blood_type", DBNull.Value);
            else
                command.Parameters.AddWithValue("blood_type", blood_type);

            if (string.IsNullOrEmpty(employee_account))
                command.Parameters.AddWithValue("employee_account", DBNull.Value);
            else
                command.Parameters.AddWithValue("employee_account", employee_account);

            if (bank_id == 0)
                command.Parameters.AddWithValue("bank_id", DBNull.Value);
            else
                command.Parameters.AddWithValue("bank_id", bank_id);

            if (roll_type_id == 0)
                command.Parameters.AddWithValue("roll_type_id", DBNull.Value);
            else
                command.Parameters.AddWithValue("roll_type_id", roll_type_id);

            if (string.IsNullOrEmpty(shirt_size))
                command.Parameters.AddWithValue("shirt_size", DBNull.Value);
            else 
                command.Parameters.AddWithValue("shirt_size", shirt_size);

            if (string.IsNullOrEmpty(pant_size))
                command.Parameters.AddWithValue("pant_size", DBNull.Value); 
            else
                command.Parameters.AddWithValue("pant_size", pant_size);

            if (string.IsNullOrEmpty(shoe_size))
                command.Parameters.AddWithValue("shoe_size", DBNull.Value); 
            else
                command.Parameters.AddWithValue("shoe_size", shoe_size);

            if (height == 0)
                command.Parameters.AddWithValue("height", DBNull.Value);
            else
                command.Parameters.AddWithValue("height", height);

            if (weight == 0)
                command.Parameters.AddWithValue("weight", DBNull.Value);
            else
                command.Parameters.AddWithValue("weight", weight);

            command.Parameters.AddWithValue("marking", marking);
            command.Parameters.AddWithValue("first_marca", first_marca);
            
            if (id_grupo == 0)
                command.Parameters.AddWithValue("id_grupo", DBNull.Value);
            else
                command.Parameters.AddWithValue("id_grupo", id_grupo);

            //command.Parameters.AddWithValue("x_hour_in", x_hour_in);
            //command.Parameters.AddWithValue("x_hour_out", x_hour_out);
            command.Parameters.AddWithValue("x_conf_aplic", x_conf_aplic);
            if (x_id_journal == 0)
                command.Parameters.AddWithValue("x_id_journal", DBNull.Value);
            else
                command.Parameters.AddWithValue("x_id_journal", x_id_journal);

            if (string.IsNullOrEmpty(x_code_card))
                command.Parameters.AddWithValue("x_code_card", DBNull.Value);
            else
                command.Parameters.AddWithValue("x_code_card", x_code_card);

            command.Parameters.AddWithValue("x_verified", x_verified);

            if (string.IsNullOrEmpty(insurance))
                command.Parameters.AddWithValue("insurance", DBNull.Value);
            else
                command.Parameters.AddWithValue("insurance", insurance);

            command.Parameters.AddWithValue("dependents", dependents);
            command.Parameters.AddWithValue("x_sinc", true);
            //command.Parameters.AddWithValue("x_update", true);
            command.Parameters.AddWithValue("id", id);

            command.ExecuteNonQuery();



            //Nuevo
            query = @"INSERT INTO public.x_hr_employee(
	                             resource_id, message_main_attachment_id, name, user_id, 
	                            active, address_home_id, country_id, gender, marital,
	                            spouse_complete_name, spouse_birthdate, children, place_of_birth,
	                            country_of_birth, birthday, ssnid, sinid, identification_id, passport_id,
	                            bank_account_id, permit_no, visa_no, visa_expire, additional_note, certificate,
	                            study_field, study_school, emergency_contact, emergency_phone, km_home_work, 
	                            google_drive_link, job_title, address_id, work_phone, mobile_phone, work_email, 
	                            work_location, job_id, department_id, parent_id, coach_id, notes, color, company_id, 
	                            resource_calendar_id, create_uid, create_date, write_uid, write_date, barcode, 
	                            pin, last_attendance_id, manager, medic_exam, vehicle, profession_id, payment_type, 
	                            college, rtn, blood_type, employee_account, bank_id, roll_type_id, shirt_size, 
	                            pant_size, shoe_size, height, weight, marking, first_marca, id_grupo, x_image, 
	                            x_hour_in, x_hour_out, x_conf_aplic, x_id_journal, x_code_card, x_verified, 
	                            insurance, dependents, x_sinc,id_employee,tipo_trans)
	                            SELECT  resource_id, message_main_attachment_id, name, user_id, active, address_home_id, 
	                            country_id, gender, marital, spouse_complete_name, spouse_birthdate, children, place_of_birth, 
	                            country_of_birth, birthday, ssnid, sinid, identification_id, passport_id, bank_account_id, 
	                            permit_no, visa_no, visa_expire, additional_note, certificate, study_field, study_school, 
	                            emergency_contact, emergency_phone, km_home_work, google_drive_link, job_title, address_id, 
	                            work_phone, mobile_phone, work_email, work_location, job_id, department_id, parent_id, 
	                            coach_id, notes, color, company_id, resource_calendar_id, create_uid, create_date, write_uid, 
	                            write_date, barcode, pin, last_attendance_id, manager, medic_exam, vehicle, profession_id, 
	                            payment_type, college, rtn, blood_type, employee_account, bank_id, roll_type_id, shirt_size, 
	                            pant_size, shoe_size, height, weight, marking, first_marca, id_grupo, x_image, x_hour_in, 
	                            x_hour_out, x_conf_aplic, x_id_journal, x_code_card, x_verified, insurance, dependents, 
	                            x_sinc, id,'Nuevo'
	                            FROM public.hr_employee
	                            where id = :id;";

            command = conn.CreateCommand();
            command.CommandText = query;
            command.Parameters.AddWithValue(":id", this.id);
            command.ExecuteNonQuery();

            string sql_ = @"UPDATE public.hr_employee
	                            SET x_update=true
	                            WHERE id=" + pId;
            PgSqlConnection cn = new PgSqlConnection(dp.ConnectionStringODOO5);
            cn.Open();
            PgSqlCommand cmdx = cn.CreateCommand();
            cmdx.CommandText = sql_;
            cmdx.ExecuteNonQuery();
            cn.Close();

            //Actualizamos en la base aqua_base
            sql_ = @"UPDATE public.hr_employee
	                            SET x_update=true
	                            WHERE id=" + pId;
            PgSqlConnection conn1 = new PgSqlConnection(dp.ConnectionStringODOO4);
            conn1.Open();
            PgSqlCommand pgSqlCommand = conn1.CreateCommand();
            pgSqlCommand.CommandText = sql_;
            pgSqlCommand.ExecuteNonQuery();
            conn1.Close(); 
        }
    }
}
