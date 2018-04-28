namespace EqualityOperator
{
    public class Button
    {
        private string _text;

        public string Text { get { return _text; } }

        public Button(string text)
        {
            _text = text;
        }

        public override string ToString()
        {
            return _text;
        }
    }
}