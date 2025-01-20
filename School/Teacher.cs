namespace School
{
    public class Teacher : Person
    {
        private ICollection<Course>? _courses;

        public Teacher(ICollection<Teacher> teachers, string name) : base(teachers, name)
        {
        }
    }
}
