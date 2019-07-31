using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildTool {
    class Program {
        static void Main ( string[] args ) {
            string file = "C:/Users/murray.coueslant/Documents/docs/Testfile.txt";

            TestRuleTrigger ruleTrigger = new TestRuleTrigger() {
                RuleCode = "MD001",
                RuleDescription = "A test warning",
                RuleNotes = "Testing notes",
                LineNumber = 5,
                ColumnNumber = 8
            };

            Console.Out.WriteLine($"{file}({ruleTrigger.LineNumber}, {ruleTrigger.ColumnNumber}): test warning {ruleTrigger.RuleCode}: {ruleTrigger.RuleDescription} {ruleTrigger.RuleNotes}");
        }
    }

    public class TestRuleTrigger {
        public string RuleCode { get; set; }

        public string RuleDescription { get; set; }

        public string RuleNotes { get; set; }

        public int LineNumber { get; set; }

        public int ColumnNumber { get; set; }

        public object OffendingObject { get; set; }
    }
}
