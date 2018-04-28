namespace Equality
{
    public struct Structure
    {
        private string _name;

        public string Name { get { return _name; } }

        public Structure(string name)
        {
            _name = name;
        }

        public override string ToString()
        {
            return _name;
        }
    }
}
