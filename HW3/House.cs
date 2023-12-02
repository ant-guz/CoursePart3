using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    public class House
    {
        private List<object> details = new List<object>();
        public void AppDetail(string detail)
        { 
            details.Add(detail);
        }

        public string ListOfDetails() { 
        var result = string.Empty;
            foreach (var item in details)
            {
                result += item + ", ";
            }
            result = result.Remove(result.Length - 2);
            return $"House details: {result}";
        }
    }
}