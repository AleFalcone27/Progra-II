using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Libro
{
    public class Class1
    {
       private List<string> paginas;

        public string this[int i] 
        {
            get
            {
                if (i >= 0 && i <= paginas.Count)
                {
                    return paginas[i];
                }
                else return "";
            }
        set {
                if (i <= paginas.Count)
                {
                    paginas[i] = value;
                }
                else paginas.Add(value);    
            }
        }
    }
}