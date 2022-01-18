using System;
using System.Linq;
using System.Xml.Linq;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections;
using System.Xml;
using System.Collections.Generic;
using System.Configuration;


namespace K181133_Q3
{
    class Program
    {   
        static void Main(string[] args)
        {
            try
            {
                DataAggregation data = new DataAggregation();
                data.StationWiseMerge();
            }
            catch(Exception ex)
            {
                throw new Exception("Exception Error: " + ex.Message);
            }        
        }
    }
}
