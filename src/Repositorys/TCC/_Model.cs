namespace Repositorys.TCC
{
    public class AnimalModel
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }


    public class AnimalDetailModel
    { 
        public int Id { get; set; }

        public int AnimalId { get; set; }

        public string Remark { get; set; }
    }
}
