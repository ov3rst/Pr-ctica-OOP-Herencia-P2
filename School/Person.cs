

namespace School
{
    public abstract class Person : School
    {
        protected Person(ICollection<Teacher> teachers) : base(teachers)
        {
        }

        public Guid Id { get; set; }
        public string? Name { get; set; }



        protected virtual void Study()
        {
            Console.WriteLine("Estudiando...");
        }

        protected virtual void Expose()
        {
            Console.WriteLine("Exponiendo en clases...");
        }
    }
}
