using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
    class Nokta
    {
        public int icerik;
        public int ad;

        public Nokta(int icerik,int ad)
        {
            this.icerik = icerik;
            this.ad = ad;
        }
    }

    class Heap
    {
        Nokta[] dizi;
        int indis;
        int N;

        public Heap(int N)
        {
            dizi = new Nokta[N];
            indis = 0;
            this.N = N;
        }

        public bool HeapBos()
        {
            if (indis == 0)
                return true;
            else return false;
        }

        public bool HeapDolu()
        {
            if (indis == N)
                return true;
            else return false;
        }

        public void HeapEkle(Nokta eleman)
        {
            Nokta temp;
            int ustdal;
            if (HeapBos() == true)
                dizi[0] = eleman;
            if (dizi[indis].icerik > eleman.icerik)
            {
                indis++;
                dizi[indis] = eleman;
            }
            else {

                while (dizi[indis].icerik < eleman.icerik && HeapDolu() == false)
                {
                    indis++;
                    dizi[indis - 1] = eleman;
                    ustdal = (indis - 1) / 2;
                    temp = dizi[ustdal];
                    dizi[ustdal] = dizi[indis - 1];
                    dizi[indis - 1] = temp;
                }
            }
        }

        public Nokta azamiDondur()
        {
            Nokta tmp;
            tmp = dizi[0];
            dizi[0] = dizi[indis - 1];
            asagiIn(0);
            indis--;
            return tmp;
        }

        public void asagiIn(int no)
        {
            int altsol, altsag;
            Nokta temp;
            altsol = 2 * no + 1;
            altsag = 2 * no + 2;
            while ((altsol < indis && dizi[no].icerik < dizi[altsol].icerik) || (altsag < indis && dizi[no].icerik < dizi[altsag].icerik))
            {
                if (altsag >= indis || dizi[altsol].icerik > dizi[altsag].icerik)
                {
                    temp = dizi[no];
                    dizi[no] = dizi[altsol];
                    dizi[altsol] = temp;
                    no = altsol;
                }
                else
                {
                    temp = dizi[no];
                    dizi[no] = dizi[altsag];
                    dizi[altsag] = temp;
                    no = altsol;
                }
                altsol = no * 2 + 1;
                altsag = no * 2 + 2;
            }
        }
    }
    
}
