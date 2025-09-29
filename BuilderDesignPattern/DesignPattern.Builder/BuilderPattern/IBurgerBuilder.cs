using System;

namespace DesignPattern.Builder.BuilderPattern
{
    public interface IBurgerBuilder
    {
        void SetBread();
        void SetMeat();
        void SetCheese();
        void SetSauce();
        Burger GetBurger();
    }
        // 👉 Tam olarak burada Builder kullanılıyor.

        //Bu sınıf interface’teki adımları uyguluyor.
        //    Yani “hangi ekmek, hangi köfte, hangi peynir” bilgisini burada belirliyoruz.

        //Burger’in nasıl yapılacağı buradaki builder sınıfında saklı.
}
