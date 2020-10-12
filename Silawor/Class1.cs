using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silawor
{
    enum enum1
    {
        value = 1,
        value_ = 2
    }
    struct struct_ {
        public string name;
        public int age;
        public void GetInfo( )
        {
            Console.WriteLine($"Value name is : {name} ,value age is {age}");
        }
    }
    class Class1
    {
        static void Main(string[] args)
        {
            enum1 en;
            en = enum1.value;
            Console.WriteLine($"Value enum is : {(int)en}");
            struct_ st;
            st.age = 20;
            st.name = "Daniil";
            Console.WriteLine($"Value struct is : {st.GetInfo()}");
            Console.ReadKey();
        }
    }
}
