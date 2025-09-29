namespace DesignPattern.Proxy.ProxyPattern
{
    public class RealImage : IImage
    {
        private string _fileName;

        public RealImage(string fileName)
        {
            _fileName = fileName;
            LoadFromDisk();
        }

        public void Display()
        {
            Console.WriteLine($"Resim görüntülendi: {_fileName}");
        }
        private void LoadFromDisk()
        {
            Console.WriteLine($"Resim diskten yüklendi: {_fileName}");
        }
    }
}
