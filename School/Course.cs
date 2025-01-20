
namespace School
{
    public class Course : Teacher
    {
        private string? _courseName;
        private ICollection<Class> _classes;
        private ICollection<string> _exercises;

        protected Course(ICollection<Teacher> teachers, string name, string courseName, ICollection<Class> classes, ICollection<string> exercises) : base(teachers, name)
        {
            _courseName = courseName;
            _classes = classes;
            _exercises = exercises;
        }

    }
}
