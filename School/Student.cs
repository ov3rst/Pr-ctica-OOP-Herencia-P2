

namespace School
{
    public class Student : Person
    {
        public Student(ICollection<Teacher> teachers) : base(teachers)
        {
        }
    }
}
