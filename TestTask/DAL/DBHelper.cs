using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.DAL
{
    internal class DBHelper
    {
        private static DBStuffConnection conn = new DBStuffConnection();

        internal static DataTable GetEmployees(string ordering = "")
        {
            try
            {
                conn.OpenConnection();
                using (var cmd = new SqlCommand(@"select first_name, last_name, p.pos_name, year_of_birth, salary from employees e
                                                  inner join positions p on e.position_id = p.id " + ordering, conn.GetConnection()))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        return dt;
                    }
                }
                conn.CloseConnection();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            return null;
        }

        internal static DataTable GetEmployeesWithSorting()
        {
            return GetEmployees("order by p.pos_name");
        }

        internal static DataTable GetEmployeesWithSortingDesc()
        {
            return GetEmployees("order by p.pos_name desc");
        }

        internal static string AddEmployee(string firstName, string lastName, int positionId, int yearOfBirth, decimal salary)
        {
            try
            {
                conn.OpenConnection();
                using (var cmd = new SqlCommand(@"insert into employees (first_name, last_name, position_id, year_of_birth, salary)
                                                values(@first_name, @last_name, @position_id, @year_of_birth, @salary)", conn.GetConnection()))
                {
                    cmd.Parameters.Add("@first_name", SqlDbType.NVarChar).Value = firstName;
                    cmd.Parameters.Add("@last_name", SqlDbType.NVarChar).Value = lastName;
                    cmd.Parameters.Add("@position_id", SqlDbType.Int).Value = positionId.ToString();
                    cmd.Parameters.Add("@year_of_birth", SqlDbType.SmallInt).Value = yearOfBirth.ToString();
                    cmd.Parameters.Add("@salary", SqlDbType.Money).Value = salary.ToString();

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        return "Object added";
                    }
                    return "Something went wrong... Try again.";
                }
                conn.CloseConnection();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);

                return exception.Message;
            }
        }

        internal static string DeleteEmployee(int id)
        {
            try
            {
                conn.OpenConnection();
                using (var cmd = new SqlCommand(@"delete employees where id = " + id, conn.GetConnection()))
                {
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        return "The object was deleted successfully!";
                    }
                    return "Something went wrong... Try again.";
                }
                conn.CloseConnection();   
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);

                return exception.Message;
            }
        }

        internal static int GetEmpById(string firstName, string lastName, int positionId, string yearOfBirth, string salary)
        {
            try
            {
                conn.OpenConnection();
                using (var cmd = new SqlCommand(@"select id from employees 
                                                where first_name = @first_name and last_name = @last_name 
                                                and position_id = @position_id and year_of_birth = @year_of_birth 
                                                and salary = @salary", conn.GetConnection()))
                {
                    cmd.Parameters.Add("@first_name", SqlDbType.NVarChar).Value = firstName;
                    cmd.Parameters.Add("@last_name", SqlDbType.NVarChar).Value = lastName;
                    cmd.Parameters.Add("@position_id", SqlDbType.Int).Value = positionId.ToString();
                    cmd.Parameters.Add("@year_of_birth", SqlDbType.SmallInt).Value = yearOfBirth;
                    cmd.Parameters.Add("@salary", SqlDbType.Money).Value = salary;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        int id = 0;
                        while (reader.Read())
                        {
                            object oId = reader["id"];
                            id = int.Parse(oId.ToString());
                        }

                        return id;
                    }
                }
                conn.CloseConnection();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);

                return 0;
            }
        }

        internal static int GetPosByName(string posName)
        {
            try
            {
                conn.OpenConnection();
                using (var cmd = new SqlCommand(@"select id from positions 
                                                where pos_name = @pos_name", conn.GetConnection()))
                {
                    cmd.Parameters.Add("@pos_name", SqlDbType.NVarChar).Value = posName;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        int id = 0;
                        while (reader.Read())
                        {
                            object oId = reader["id"];
                            id = int.Parse(oId.ToString());
                        }

                        return id;
                    }    
                }
                conn.CloseConnection();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);

                return -1;
            }
        }

        internal static DataTable GetPositions()
        {
            try
            {
                DBStuffConnection conn = new DBStuffConnection();
                conn.OpenConnection();
                using (var cmd = new SqlCommand(@"select pos_name, AVG(e.salary) as Averrage_amount from positions p
                                                left join employees e on e.position_id = p.id
                                                group by pos_name", conn.GetConnection()))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        return dt;
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            return null;
        }
    }
}
