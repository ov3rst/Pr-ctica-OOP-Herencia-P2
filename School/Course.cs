
namespace School
{
    public abstract class Course : School
    {
        protected Course(ICollection<Teacher> teachers) : base(teachers)
        {
        }

        public int ClassCount { get; set; }
        public int ExerciseCount { get; set; }
    }
}
