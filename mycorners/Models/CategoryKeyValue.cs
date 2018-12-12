using System;
using System.Collections;
using System.Collections.Generic;

namespace mycorners.Models
{
    public class CategoryKeyValue
    {
        //public List<KeyValuePair<string, string>> myList = new List<KeyValuePair<string, string>>();
        public Dictionary<string, string> categories = new Dictionary<string, string>();

        public CategoryKeyValue()
        {
            //KeyValuePair<string, string> myKeyValuePair1 = new KeyValuePair<string, string>("F", "Food");
            //KeyValuePair<string, string> myKeyValuePair2 = new KeyValuePair<string, string>("A", "Arts & Crafts");
            //KeyValuePair<string, string> myKeyValuePair3 = new KeyValuePair<string, string>("P", "Produce");

            //myList.Add(myKeyValuePair1);
            //myList.Add(myKeyValuePair2);
            //myList.Add(myKeyValuePair3);
            categories.Add("F", "Food");
            categories.Add("A", "Arts & Crafts");
            categories.Add("P", "Product");
        }

    }
}
