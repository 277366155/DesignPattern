using Dapper;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Repositorys.TCC
{
    public abstract class BaseRepository<T>
    {
        protected abstract string GetDBName();
        public string DbPath
        {
            get
            {
                return "data source=" + Environment.CurrentDirectory + "/AppData/" + GetDBName();
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
                var sql = GetInsertSql(model.GetType());
                var insertResult = db.Execute(sql,model,tran);
                if (insertResult > 0)
                {
                    masterId= db.QueryFirst<int>($"select last_insert_rowid() from  `{typeof(T).Name.ToLower()}`; ");
                }
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        private string GetInsertSql(Type type)
        {
            var sql = $"insert into `{type.Name.ToLower()}` ";
            var columns = new StringBuilder();
            var paramStrBuild= new StringBuilder();

            foreach (var p in type.GetProperties())
            {
                if (p.Name.ToLower() == "id")
                {
                    continue;
                }
                columns.Append($"`{p.Name}`,");
                paramStrBuild.Append($"@{p.Name},");
            }
            sql += $"({columns.ToString().TrimEnd(',')}) values ({paramStrBuild.ToString().TrimEnd(',')});";
            return sql;
        }
    }
}
