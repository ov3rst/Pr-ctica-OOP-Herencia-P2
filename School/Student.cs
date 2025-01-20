

namespace School
{
    public class Student : Person
    {
        private Guid _id;

        public Student(ICollection<Teacher> teachers, string name, Guid id) : base(teachers, name)
        {
            this._id = id;
        }
    }
}
