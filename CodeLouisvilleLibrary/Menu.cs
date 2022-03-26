using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeLouisvilleLibrary;


namespace CodeLouisvilleLibrary
{
    public class Menu<T>
    {
        public List<KeyValuePair<object, string>> MenuItems { get; internal set; }
    }
}