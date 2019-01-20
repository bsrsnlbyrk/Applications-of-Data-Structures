using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVLTree
{
    class AVLDugum
    {
        int icerik;
        int boy;
        AVLDugum sol;
        AVLDugum sag;

        public AVLDugum(int icerik)
        {
            this.icerik = icerik;
            sol = null;
            sag = null;
            boy = 1;
        }

        class AVLAgac
        {
            AVLDugum kok;
            public AVLAgac()
            {
                kok = null;
            }

            public int boy(AVLDugum d)
            {
                if (d == null)
                    return 0;
                else
                    return d.boy;
            }

            public AVLDugum solTekRotasyon(AVLDugum k2)
            {
                AVLDugum k1 = k2.sol;
                k2.sol = k1.sag;
                k1.sag = k2;
                k2.boy = boy(k2.sol) - boy(k2.sag) + 1;
                k1.boy = boy(k1.sol) - k1.sag.boy + 1;
                return k1;
            }

            public AVLDugum sagTekRotasyon(AVLDugum k1)
            {
                AVLDugum k2 = k1.sag;
                k1.sag = k2.sol;
                k2.sol = k1;
                k2.boy = k2.sol.boy - boy(k2.sag) + 1;
                k1.boy = boy(k1.sol) - boy(k1.sag) + 1;
                return k2;
            }


        }
    }
}
