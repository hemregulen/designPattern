namespace HEG.FlyweightDesignPattern.RealWorld.Flyweight
{
    public class CharacterStyle
    {
        public CharacterStyle(string fontFamily, int fontSize, string color)
        {
            FontFamily = fontFamily;
            FontSize = fontSize;
            Color = color;
        }

        public string FontFamily { get; }
        public int FontSize { get; }
        public string Color { get; }

        public string Describe() => $"{FontFamily}, {FontSize}px, {Color}";
    }

    public class CharacterStyleFactory
    {
        private readonly Dictionary<string, CharacterStyle> _styles = new();

        public int Count => _styles.Count;

        public CharacterStyle GetStyle(string fontFamily, int fontSize, string color)
        {
            string key = $"{fontFamily}-{fontSize}-{color}";
            if (!_styles.ContainsKey(key))
            {
                _styles[key] = new CharacterStyle(fontFamily, fontSize, color);
            }

            return _styles[key];
        }
    }

    public class CharacterGlyph
    {
        public CharacterGlyph(char symbol, int x, int y, CharacterStyle style)
        {
            Symbol = symbol;
            X = x;
            Y = y;
            Style = style;
        }

        public char Symbol { get; }
        public int X { get; }
        public int Y { get; }
        public CharacterStyle Style { get; }

        public void Render()
        {
            Console.WriteLine($"'{Symbol}' at ({X},{Y}) using {Style.Describe()}");
        }
    }

    public class TextDocument
    {
        private readonly List<CharacterGlyph> _characters = new();

        public void AddCharacter(char symbol, int x, int y, CharacterStyle style)
        {
            _characters.Add(new CharacterGlyph(symbol, x, y, style));
        }

        public void Render()
        {
            foreach (CharacterGlyph character in _characters)
            {
                character.Render();
            }
        }
    }
}
