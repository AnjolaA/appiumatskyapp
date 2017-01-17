using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atskyapptest.GeneralHook
{
    using System;
    using BaseClass;
    using TechTalk.SpecFlow;

    [Binding]
    public class GeneralHook
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            Console.WriteLine("BeforeTestRun Hook");
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            BaseClass.TearDown();
            Console.WriteLine("AfterTestRun Hook");
           
        }

        [BeforeFeature]
        public static void BeforeFeature()
        {
            Console.WriteLine("BeforeFeature Hook");
            BaseClass.InitWebdriver();
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            
            Console.WriteLine("AfterFeature Hook");
            
        }

        [BeforeScenario]
        public static void BeforeScenario()
        {
            Console.WriteLine("BeforeScenario Hook");
        }

        [AfterScenario]
        public static void AfterScenario()
        {
            //BaseClass.TearDown();
            Console.WriteLine("AfterScenario Hook");
           
        }
    }
}
