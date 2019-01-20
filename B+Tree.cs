using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Tree
{
    class BEleman
    {
        public int[] dizi;
        int indeks;
        public BEleman[] nesil;
        public int m;
        public bool yaprak;

        public BEleman(int d)
        {
            indeks = d;
            dizi = new int[2 * d + 1];
            nesil = new BEleman[2 * d + 1];
            m = 0;
            yaprak = true;
        }

        public int pozisyon(int eleman)
        {
            if (eleman >= dizi[m - 1])
                return m;
            else 
                for(int i = 0; i < m; i++)
                {
                    if (eleman < dizi[i])
                        return i;
                }
            return 0;
        }
    }
    class BTree
    {
        BEleman kok;

        public BTree()
        {
            kok = null;
        }

        public BEleman agacAra(int eleman)
        {
            int cocuk;
            BEleman b = kok;

            while (!b.yaprak)
            {
                cocuk = b.pozisyon(eleman);
                b = b.nesil[cocuk];
            }
            return b;
        }

    }
}