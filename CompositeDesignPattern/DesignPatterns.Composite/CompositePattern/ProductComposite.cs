using System.Text;

namespace DesignPatterns.Composite.CompositePattern
{
    public class ProductComposite : IComponent
    {
        public ProductComposite(int id, string name)
        {
            Id = id;
            Name = name;
            _components = new List<IComponent>();
        }
        //Composite:hem tekil nesneleri hem de bu tekil nesneleri içeren grupları tek bir nesneymiş gibi ele almamızı sağlayan bir yapıdır.

        public int Id { get; set; }
        public string Name { get; set; }
        public List<IComponent> _components { get; set; }
        public ICollection<IComponent> Components => _components;

        public void Add(IComponent component)
        {
            _components.Add(component);
        }
        public string Display()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append($"<div class='text-success'>{Name}({TotalCount()})</div>");
            stringBuilder.Append("<ul class='list-group list-group-flush ms-2'>");
            foreach (var item in _components)
            {
                stringBuilder.Append(item.Display());
            }
             stringBuilder.Append("</ul>");
            return stringBuilder.ToString();
        }

        public int TotalCount()
        {
            return _components.Sum(x => x.TotalCount());
        }
    }
}

//_components → gerçek veriyi tutan liste (List<IComponent>).

//Components → dışarıya verilen sadece okunabilir özellik (property).
//Ama tipini ICollection<IComponent> olarak veriyoruz. Böylece:

//Dışarıya sadece koleksiyon davranışını gösteriyoruz (Add, Remove, Count).

//İçerde kullandığımız gerçek tipin (List) ne olduğu saklanıyor.

//Yapılma sebebi

//Gevşek bağlılık (loose coupling): Kod dışarıya List yerine ICollection verir, böylece ister List, ister HashSet, ister başka koleksiyon kullanılabilir.