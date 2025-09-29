namespace DesignPattern.Flyweight.FlyweightPattern
{
    public class CharacterFactory
    {
        private Dictionary<string, Character> _characters = new Dictionary<string, Character>();

        public Character GetCharacter(char symbol, string font)
        {
            string key = symbol.ToString() + font;

            if (!_characters.ContainsKey(key))
            {
                _characters[key] = new Character(symbol, font);
            }

            return _characters[key];
        }
    }
}
