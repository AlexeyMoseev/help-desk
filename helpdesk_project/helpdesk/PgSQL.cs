using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Npgsql;

namespace helpdesk
{
    class PgSQL
    {
        NpgsqlConnection dbConnection = null;
        NpgsqlCommand command = null;
        string connParam = null;

        public PgSQL(string connectionString)
        {
            connParam = connectionString;
        }

        public DataTable OutTable(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                dbConnection = new NpgsqlConnection(connParam);
                dbConnection.Open();
                command = new NpgsqlCommand();
                command.Connection = dbConnection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = query;
                NpgsqlDataAdapter dbDataAdapter = new NpgsqlDataAdapter(command);
                DataSet ds = new DataSet();
                dbDataAdapter.Fill(ds);
                dt = ds.Tables[0];
            }
            catch (Exception p)
            {
                throw new Exception(p.Message);
            }
            finally
            {
                dbConnection.Close();
            }
            return dt;
        }
 
        public void Query(string procName)
        {
            try
            {
                dbConnection = new NpgsqlConnection(connParam);
                command = new NpgsqlCommand();
                command.Connection = dbConnection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = procName;
                dbConnection.Open();
                command.Prepare();
                command.ExecuteNonQuery();
            }
            catch (Exception p)
            {
                throw new Exception(p.Message);
            }
            finally
            {
                dbConnection.Close();
            }
        }

        public void Del(string procName, int id)
        {
            try
            {
                dbConnection = new NpgsqlConnection(connParam);
                command = new NpgsqlCommand();
                command.Connection = dbConnection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = procName;

                command.Parameters.AddWithValue("i", NpgsqlTypes.NpgsqlDbType.Bigint, id);

                dbConnection.Open();
                command.Prepare();
                command.ExecuteNonQuery();
            }
            catch (Exception p)
            {
                throw new Exception(p.Message);
            }
            finally
            {
                dbConnection.Close();
            }
        }

        public void AddEditRequest(string procName, string tit, string des, string rec, string dead, int oper, int cat, int cli, int prio, int imp, int stat, int id = -1)
        {
            try
            {
                dbConnection = new NpgsqlConnection(connParam);
                command = new NpgsqlCommand();
                command.Connection = dbConnection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = procName;

                command.Parameters.AddWithValue("tit", NpgsqlTypes.NpgsqlDbType.Varchar, tit);
                command.Parameters.AddWithValue("des", NpgsqlTypes.NpgsqlDbType.Text, des);
                command.Parameters.AddWithValue("rec", NpgsqlTypes.NpgsqlDbType.Date, Convert.ToDateTime(rec));
                command.Parameters.AddWithValue("dead", NpgsqlTypes.NpgsqlDbType.Date, Convert.ToDateTime(dead));
                command.Parameters.AddWithValue("cat",  NpgsqlTypes.NpgsqlDbType.Integer, cat);
                command.Parameters.AddWithValue("oper", NpgsqlTypes.NpgsqlDbType.Integer, oper);
                command.Parameters.AddWithValue("cli", NpgsqlTypes.NpgsqlDbType.Integer, cli);
                command.Parameters.AddWithValue("prio", NpgsqlTypes.NpgsqlDbType.Integer, prio);
                command.Parameters.AddWithValue("imp", NpgsqlTypes.NpgsqlDbType.Integer, imp);
                command.Parameters.AddWithValue("stat", NpgsqlTypes.NpgsqlDbType.Integer, stat);
                if (id != -1)
                    command.Parameters.AddWithValue("i", id);

                dbConnection.Open();
                command.Prepare();
                command.ExecuteNonQuery();
            }
            catch (Exception p)
            {
                throw new Exception(p.Message);
            }
            finally
            {
                dbConnection.Close();
            }
        }

        public void AddEditWorker(string procName, string name, string addr, string phone, int dep, int post, int id = -1)
        {
            try
            {
                dbConnection = new NpgsqlConnection(connParam);
                command = new NpgsqlCommand();
                command.Connection = dbConnection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = procName;

                command.Parameters.AddWithValue("nam", name);
                command.Parameters.AddWithValue("addr", addr);
                command.Parameters.AddWithValue("phon", phone);
                command.Parameters.AddWithValue("dep", dep);
                command.Parameters.AddWithValue("post", post);
                if (id != -1)
                    command.Parameters.AddWithValue("i", id);

                dbConnection.Open();
                command.Prepare();
                command.ExecuteNonQuery();
            }
            catch (Exception p)
            {
                throw new Exception(p.Message);
            }
            finally
            {
                dbConnection.Close();
            }
        }

        public void AddEditClient(string procName, string name, string addr, string phone, string email, int id = -1)
        {
            try
            {
                dbConnection = new NpgsqlConnection(connParam);
                command = new NpgsqlCommand();
                command.Connection = dbConnection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = procName;

                command.Parameters.AddWithValue("nam", name);
                command.Parameters.AddWithValue("addr", addr);
                command.Parameters.AddWithValue("phon", phone);
                command.Parameters.AddWithValue("emai", email);
                if (id != -1)
                    command.Parameters.AddWithValue("i", id);

                dbConnection.Open();
                command.Prepare();
                command.ExecuteNonQuery();
            }
            catch (Exception p)
            {
                throw new Exception(p.Message);
            }
            finally
            {
                dbConnection.Close();
            }
        }

        public void AddEditDepartment(string procName, string tit, string phone, string email, int id = -1)
        {
            try
            {
                dbConnection = new NpgsqlConnection(connParam);
                command = new NpgsqlCommand();
                command.Connection = dbConnection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = procName;

                command.Parameters.AddWithValue("tit", tit);
                command.Parameters.AddWithValue("phon", phone);
                command.Parameters.AddWithValue("emai", email);
                if (id != -1)
                    command.Parameters.AddWithValue("i", id);

                dbConnection.Open();
                command.Prepare();
                command.ExecuteNonQuery();
            }
            catch (Exception p)
            {
                throw new Exception(p.Message);
            }
            finally
            {
                dbConnection.Close();
            }
        }

        public void AddEditCategory(string procName, string tit, string des, int id = -1)
        {
            try
            {
                dbConnection = new NpgsqlConnection(connParam);
                command = new NpgsqlCommand();
                command.Connection = dbConnection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = procName;

                command.Parameters.AddWithValue("tit", NpgsqlTypes.NpgsqlDbType.Varchar, tit);
                command.Parameters.AddWithValue("descrip", NpgsqlTypes.NpgsqlDbType.Text, des);
                if (id != -1)
                    command.Parameters.AddWithValue("i", NpgsqlTypes.NpgsqlDbType.Bigint, id);

                dbConnection.Open();
                command.Prepare();
                command.ExecuteNonQuery();
            }
            catch (Exception p)
            {
                throw new Exception(p.Message);
            }
            finally
            {
                dbConnection.Close();
            }
        }

        public void AddEditPost(string procName, string tit, string des, int id = -1)
        {
            try
            {
                dbConnection = new NpgsqlConnection(connParam);
                command = new NpgsqlCommand();
                command.Connection = dbConnection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = procName;

                command.Parameters.AddWithValue("tit", tit);
                command.Parameters.AddWithValue("des", des);
                if (id != -1)
                    command.Parameters.AddWithValue("i", id);

                dbConnection.Open();
                command.Prepare();
                command.ExecuteNonQuery();
            }
            catch (Exception p)
            {
                throw new Exception(p.Message);
            }
            finally
            {
                dbConnection.Close();
            }
        }

        public void AddEditStatus(string procName, string tit, int id = -1)
        {
            try
            {
                dbConnection = new NpgsqlConnection(connParam);
                command = new NpgsqlCommand();
                command.Connection = dbConnection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = procName;

                command.Parameters.AddWithValue("tit", tit);
                if (id != -1)
                    command.Parameters.AddWithValue("i", id);

                dbConnection.Open();
                command.Prepare();
                command.ExecuteNonQuery();
            }
            catch (Exception p)
            {
                throw new Exception(p.Message);
            }
            finally
            {
                dbConnection.Close();
            }
        }

        public void AddEditPriority(string procName, string tit, int id = -1)
        {
            try
            {
                dbConnection = new NpgsqlConnection(connParam);
                command = new NpgsqlCommand();
                command.Connection = dbConnection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = procName;

                command.Parameters.AddWithValue("tit", tit);
                if (id != -1)
                    command.Parameters.AddWithValue("i", id);

                dbConnection.Open();
                command.Prepare();
                command.ExecuteNonQuery();
            }
            catch (Exception p)
            {
                throw new Exception(p.Message);
            }
            finally
            {
                dbConnection.Close();
            }
        }
    }
}
