namespace School
{
    public abstract class Class
    {
        private ICollection<Teacher>? _teachers;
        private string? _classId;

        public Class(ICollection<Teacher> teachers)
        {
            this._teachers = teachers;
            this._classId = Guid.NewGuid().ToString();
        }
    }
}
