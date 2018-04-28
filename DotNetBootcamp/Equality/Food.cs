namespace Equality
{
    public class Food
    {
        private string _name;

        public string Name { get { return _name; }}

        public Food(string name)
        {
            _name = name;
        }

		public override string ToString()
		{
            return _name;
		}
	}
}
