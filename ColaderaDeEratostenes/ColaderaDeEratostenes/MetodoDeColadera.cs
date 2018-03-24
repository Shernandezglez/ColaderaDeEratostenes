using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColaderaDeEratostenes
{
    class MetodoDeColadera
    {
        private bool[] _num;
        private int[] _index;

        public MetodoDeColadera(int lim)
        {
            _num = new bool[lim];
            _index = new int[lim];
        }

        public void inicializarArreglo()
        {
            for (int i = 0; i < _num.Length -1; i++)
            {
                _num[i] = true;
                _index[i] = i + 1;
            }
        }

        public void buscarMultiplos()
        {
            for(int i = 2; i< _index.Length; i++)
            {
                if(_num[i] == true)
                {
                   
                    if (_index[i + 1] % 2 == 1 || _index[i] % 3 == 0 || _index[i] % 5 == 0 || _index[i] % 7 == 0)
                    {
                        _num[i] = false;
                    }
                    else
                    {
                        _num[i] = true;
                    }
                }
            }
        }

     

        public string mostrar()
        {
           
            string cosa = "";
            for (int i = 0; i < _num.Length; i++)
            {
                if(_num[i] == true)
                {
                    cosa += _index[i].ToString() + ", ";
                }
                else
                {
                    cosa += "";
                }
                
            }

            return cosa;
        }








    }
}
