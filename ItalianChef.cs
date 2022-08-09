using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningInheritance
{

    //this "super" class has inherited the abilities of another class 
    internal class ItalianChef : Chef
    {

        //but we can also designate special or extra duties to this class
        public void MakePasta()
        {
            Console.WriteLine("The chef makes pasta");
        }


        //or over-ride specified methods
        public override void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes lasagna");
        }
    }
}
