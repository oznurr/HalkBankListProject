using System;
using System.Collections;

namespace HalkBank.Collections
{
    public class HalkBankList : IBankList , IEnumerable
    {
        protected object[] _dizi;

        public HalkBankList()
        {
            _dizi = new object[0];
        }

        public HalkBankList(int maxElemanSayisi) : this()
        {
            MaxElemanSayisi = maxElemanSayisi;
        }

        public int ElemanSayisi => _dizi.Length;
        public static int MaxElemanSayisi { get; set; } = 5;

        public object this[int index] //C# 7.0
        {
            get => _dizi[index];
            set => _dizi[index] = value;
        }

        public virtual void Ekle(object eleman)
        {
            if (ElemanSayisi >= MaxElemanSayisi)
                throw new System.Exception($"Maksimum eleman sayısına ulaştınız");

            var yedekDizi = _dizi;
            _dizi = new object[yedekDizi.Length + 1];

            yedekDizi.CopyTo(_dizi, 0);

            _dizi[yedekDizi.Length] = eleman;
        }

        public void Sil(int index)
        {
            var yedekDizi = _dizi;
            _dizi = new object[yedekDizi.Length - 1];

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
            _dizi = new object[0];
        }

        public IEnumerator GetEnumerator()
        {
            return _dizi.GetEnumerator();
        }

        public virtual void TersineCevir()
        {
            object tersDizi;
          
            for (int i = 0; i < _dizi.Length / 2; i++)
            {
                tersDizi = _dizi[i];
                _dizi[i] = _dizi[_dizi.Length - i - 1];
                _dizi[_dizi.Length - i - 1] = tersDizi;
            }

        }

        public virtual HalkBankList KosulluSil(HalkBankList datalar, Func<string, bool> kosul)
        {
             foreach (var data in datalar)
            //for (int i= 0;i < datalar.ElemanSayisi;i++)
            {
                bool sartSaglandimi = kosul.Invoke((string)data);
                if (sartSaglandimi)
                    datalar.Sil(datalar.IndexBul(data));
                
               
            }

            return datalar;


        }

        public int  SondanIndexleme(object value)
        {
            int sira = -1;
            for (int i = _dizi.Length - 1; i >=0 ; i--)
            {
                if (_dizi[i].ToString() ==value)
                {
                    sira = i;
                }
               
            }

            return sira;
        }

        public int IndexBul(object value)
        {
            int sira = -1;
            for (int i = 0; i <= _dizi.Length - 1; i++)
            {
                if (_dizi[i].ToString() == value)
                {
                    sira = i;
                }

            }

            return sira;
        }


    }
}
