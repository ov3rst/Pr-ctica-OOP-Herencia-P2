

namespace School
{
    public abstract class Person : Class
    {
        private string? _name;
        protected Person(ICollection<Teacher> teachers, string name) : base(teachers)
        {
            this._name = name;
        }


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
