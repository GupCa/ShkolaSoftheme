using System;

namespace ConsoleApplication_CopyUser
{
    public class User: ICloneable
    {
        //values
        public int IdUser { get; set; }
        
        //references
        public string Login { get; set; }
        public int[] Array = new int[3] ;
        public MyClass MyClassVal { get; set; }
        

        public object Clone()
        {
            var array = new int[3];

            for (var i = 0; i < 3; i++)
            {
                array[i] = this.Array[i];
            }

            var myClass = new MyClass{MyType = this.MyClassVal.MyType};
        
            return new User { 
                IdUser = this.IdUser, 
                Login = this.Login,
                Array = array,
                MyClassVal = myClass,
            };
        }
    }

    public class MyClass
    {
        public int MyType { get; set; }
    }
}