using Microsoft.Data.Sqlite;

namespace Repositorys.TCC
{
    public class AnimalRepository : BaseRepository<Animal>
    {
        protected override string GetDBName()
        {
            return "animal.db";
        }
    }

    public class AnimalDetailRepository : BaseRepository<AnimalDetail>
    {
        private string _dbName;
        protected override string GetDBName()
        {
            return "animaldetail.db";
        }
    }

    public class AnimalService
    {
        private AnimalRepository animalRep = new AnimalRepository();
        private AnimalDetailRepository animalDetailRep = new AnimalDetailRepository();

        public bool InsertAllDbTCC()
        {
            var animal = new Animal { Name = "cat1", Age = 1, TypeName = "cat" };
            var animalConn = new SqliteConnection(animalRep.DbPath);
            animalConn.Open();
            var animalTran = animalConn.BeginTransaction();

            var animalDetail = new AnimalDetail { Remark = "this is cat1's remark" };
            var animalDetailConn = new SqliteConnection(animalDetailRep.DbPath);
            animalDetailConn.Open();
            var animalDetailTran = animalDetailConn.BeginTransaction();

            var masterId = 0;
            try
            {
                var animalTryResult = animalRep.Insert(animal, out masterId, animalConn, animalTran);
                if (animalTryResult && masterId > 0)
                {
                    animalDetail.AnimalId = masterId;
                }
                var animalDetailTryResult = animalDetailRep.Insert(animalDetail, out _, animalDetailConn, animalDetailTran);

                if (animalTryResult && animalDetailTryResult)
                {
                    animalTran.Commit();
                    animalDetailTran.Commit();
                    return true;
                }
                else
                {
                    animalTran.Rollback();
                    animalDetailTran.Rollback();
                    return false;
                }
            }
            catch
            {
                animalTran.Rollback();
                animalDetailTran.Rollback();
                return false;
            }
            finally
            {
                animalConn.Close();
                animalDetailConn.Close();
                animalTran.Dispose();
                animalDetailTran.Dispose();
                animalConn.Dispose();
                animalDetailConn.Dispose();
            }
        }
    }
}
