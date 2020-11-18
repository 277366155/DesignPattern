namespace Repositorys.TCC
{
    public class Animal
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }


    public class AnimalDetail
    { 
        public int Id { get; set; }

        public int AnimalId { get; set; }

        public string Remark { get; set; }
    }
}
