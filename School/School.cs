namespace School
{
    public class School
    {
        private ICollection<Teacher>? _teachers;

        public School(ICollection<Teacher> teachers)
        {
            this._teachers = teachers;
        }


    }
}
