namespace DesignPattern.Flyweight.FlyweightPattern
{
    public class Character
    { // Paylaşılan (intrinsic) state
        private readonly char _symbol;
        private readonly string _font;

        public Character(char symbol, string font)
        {
            _symbol = symbol;
            _font = font;
        }

        // Değişken (extrinsic) state dışarıdan gelir
        public void Display(int size)
        {
            Console.WriteLine($"Karakter: {_symbol}, Font: {_font}, Boyut: {size}");
        }
    }
}
