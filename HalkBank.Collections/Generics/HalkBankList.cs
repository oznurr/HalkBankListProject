using System.Collections;

namespace HalkBank.Collections.Generics
{
    public class HalkBankList<T> : IBankList
    {
        protected T[] _dizi;

        public HalkBankList()
        {
            _dizi = new T[0];
        }

        public HalkBankList(int maxElemanSayisi) : this()
        {
            MaxElemanSayisi = maxElemanSayisi;
        }

        public int ElemanSayisi => _dizi.Length;
        public static int MaxElemanSayisi { get; set; } = 5;

        int IBankList.ElemanSayisi => throw new System.NotImplementedException();

        object IBankList.this[int index] { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public T this[int index] //C# 7.0
        {
            get => _dizi[index];
            set => _dizi[index] = value;
        }

        public virtual void Ekle(T eleman)
        {
            if (ElemanSayisi >= MaxElemanSayisi)
                throw new System.Exception($"Maksimum eleman sayısına ulaştınız");

            var yedekDizi = _dizi;
            _dizi = new T[yedekDizi.Length + 1];

            yedekDizi.CopyTo(_dizi, 0);

            _dizi[yedekDizi.Length] = eleman;
        }

        public void Sil(int index)
        {
            var yedekDizi = _dizi;
            _dizi = new T[yedekDizi.Length - 1];

            int sayac = 0;

            for (int i = 0; i < yedekDizi.Length; i++)
            {
                if (i == index)
                    continue;

                _dizi[sayac] = yedekDizi[i];
                sayac++;
            }
        }

        public void Temizle()
        {
            _dizi = new T[0];
        }

        void IBankList.Ekle(object eleman)
        {
            throw new System.NotImplementedException();
        }

        void IBankList.Sil(int index)
        {
            throw new System.NotImplementedException();
        }

        void IBankList.Temizle()
        {
            throw new System.NotImplementedException();
        }
        public  void Kopyala(T eleman)
        {
             var yedekDizi = _dizi;
             _dizi = new T[yedekDizi.Length + 1];
             for (int i = 0; i < _dizi.Length; i++)
                yedekDizi[i] = _dizi[i];

            _dizi[yedekDizi.Length] = eleman;
        }
    }
}
