using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjSecondApplication
{
    class UGC
    {
        string[] rules = { "Dress code", "Identity Card" };
        public virtual void RulesMethod()
        {
            foreach(var r in rules)
            {
                Console.WriteLine($"Rules: {r}");
            }
        }
    }
    class MIT : UGC
    {
        string mitRules = "No Mobile";
        public override void RulesMethod()
        {
            base.RulesMethod();
            Console.WriteLine($"MIT Rules: {mitRules}");
        }
    }

    class AnnaUniversity : UGC
    {
        string AnnaUniversityRules = "Only Formal Dress";
        public new void RulesMethod()
        {
            base.RulesMethod();
            Console.WriteLine($"AnnaUniversity Rules: {AnnaUniversityRules}");
        }
    }
    class VirtualEg
    {
        static void Main()
        {
            UGC ugc = new UGC();
            Console.WriteLine("UGC RULES");
            ugc.RulesMethod();

            MIT mit = new MIT();
            Console.WriteLine("MIT RULES");
            mit.RulesMethod();

            AnnaUniversity annaUniversity = new AnnaUniversity();
            Console.WriteLine("AnnaUniversity RULES");
            annaUniversity.RulesMethod();
        }
    }
}
