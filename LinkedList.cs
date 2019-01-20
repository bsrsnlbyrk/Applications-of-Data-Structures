using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;

namespace LinkedList
{
    public class Eleman
    {
        public int icerik;
        public Eleman ileri;

        public Eleman(int icerik)
        {
            this.icerik = icerik;
            ileri = null;
        }
    }

    public class Liste
    {
        public Eleman liste = new Eleman(0);
        public Eleman bas;
        public Eleman son;

        public Liste()
        {
            bas = null;
            son = null;
        }

        public void listeBasinaEkle(Eleman yeni)
        {
            if (son == null) son = yeni;
            else yeni.ileri = bas;
            bas = yeni;

        }

        public void listeSonunaEkle(Eleman yeni)
        {
            if (bas == null) bas = yeni;
            else son.ileri = yeni;
            son = yeni;
        }

        public void listeOrtaEkle(Eleman yeni, Eleman once)
        {
            yeni.ileri = once.ileri;
            once.ileri = yeni;
        }

        public Eleman ListeAra(int deger)
        {
            Eleman tmp;
            tmp = bas;
            while (tmp != null)
            {
                if (tmp.icerik == deger) return tmp;
                else tmp = tmp.ileri;
            }
            return null;
        }

        public Eleman ListeAra2(int i)
        {
            Eleman tmp = bas;
            int j;
            for(j=0 ; tmp!= null && j<i ; j++)
            {
                tmp = tmp.ileri;
            }
            return tmp;
        }

        public void ListeBasiSil()
        {
            bas = bas.ileri;
            if (bas == null) son = null;
        }

        public void ListeSonuSil()
        {
            Eleman tmp, once;
            tmp = bas;
            once = null;
            while (tmp != son)
            {
                once = tmp;
                tmp = tmp.ileri;
            }

            if (once == null) bas = null;
            else once.ileri = null;
            son = once;
        }

        public void ListeOrtaSil(Eleman s)
        {
            Eleman tmp, once;
            tmp = bas;
            once = null;
            while (tmp != s)
            {
                once = tmp;
                tmp = tmp.ileri;
            }
            once.ileri = s.ileri;
        }

        public int ElemanSayisiBul()
        {
            Eleman tmp = bas;
            int i=0;
            while (tmp != null)
            {
                tmp = tmp.ileri;
                i++;
            }
            return i;
        }
	}
}