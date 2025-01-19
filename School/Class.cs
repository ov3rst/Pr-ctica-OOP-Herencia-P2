namespace School
{
    public class Class
    {
        private ICollection<Class>? _classes;
        private string? _id;

        public Class(ICollection<Class> classes) : base(classes)
        {
            this._classes = classes;
            this._id = Guid.NewGuid().ToString();
        }
    }
}
