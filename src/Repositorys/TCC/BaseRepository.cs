using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Repositorys.TCC
{
    public abstract class BaseRepository<T>
    {
        protected abstract string dbName { get; set; }
        public string DbPath
        {
            get
            {
                return Environment.CurrentDirectory + "/AppData/" + dbName;
            }
        }

        public virtual bool Insert(T model, out int masterId, IDbConnection db, IDbTransaction tran)
        {
            masterId = 0;
            if (db.State != ConnectionState.Open)
            {
                db.Open();
            }
            try
            {
                var cmd = db.CreateCommand();
                cmd.CommandText = GetInsertSql(model);
                cmd.Transaction = tran;
                var insertResult = cmd.ExecuteNonQuery();
                if (insertResult > 0)
                {
                    cmd.CommandText = $"select last_insert_rowid() from  `{typeof(T).Name.ToLower()}` ";
                    var dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        masterId = dr.GetInt32(0);
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        private string GetInsertSql<T>(T model)
        {
            var sql = $"insert into `{typeof(T).Name.ToLower()}` ";
            var columns = new StringBuilder();
            var values = new StringBuilder();

            foreach (var p in typeof(T).GetProperties())
            {
                if (p.Name.ToLower() == "id")
                {
                    continue;
                }
                columns.Append($"`{p.Name}`,");
                var pValue = p.GetValue(model);
                if (pValue == null)
                {
                    values.Append($"  null ,");
                }
                else
                {
                    switch (pValue.GetType().Name.ToLower())
                    {
                        case "string":
                        case "datetime":
                            values.Append($"'{pValue}',");
                            break;
                        default:
                            values.Append($" {pValue} ,");
                            break;
                    }
                }
            }
            sql += $"({columns.ToString().TrimEnd(',')}) value ({values.ToString().TrimEnd(',')});";
            return sql;
        }
    }
}
