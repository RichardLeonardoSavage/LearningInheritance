using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningInheritance
{



    //here is a class we have made with some methods
    internal class Chef
    {



        //methods that can be called upon once an instance of this class has been called upon
        public void MakeChicken()
        {
            Console.WriteLine("The chef makes chicken");
        }
        public void MakeSalad()
        {
            Console.WriteLine("The Chef makes salad");
        }


        //here we have made a virtual void method which means that we can now override this method in another class
        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes BBQ Ribs");
        }


    }
}
