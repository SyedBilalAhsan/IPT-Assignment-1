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
    public class DataAggregation
    {
        public string data;

        public static void MergeIntoOne(string file1, string file2)
        {
            try
            {
                string MergedPath = ConfigurationManager.AppSettings["MergedPath"];
                var mfile = new XDocument();
                XElement newDocument = new XElement("Votes");
                mfile.Add(newDocument);
                XDocument xml1 = XDocument.Load(file1);
                XDocument xml2 = XDocument.Load(file2);
                mfile.Root.Add(xml1.Descendants("Vote").Concat(xml2.Descendants("Votes")));
                mfile.Save(MergedPath);
            }
            catch (Exception ex)
            {
                throw new Exception("Exception Error: " + ex.Message);
            }
        }
        public void StationWiseMerge()
        {
            try
            {
                string StationId1 = "210001";
                string StationId2 = "210002";
                string AllFiles = ConfigurationManager.AppSettings["AllFiles"];
                var AllfilesPath = AllFiles;
                var files = Directory.GetFiles(AllfilesPath, "*.xml", SearchOption.AllDirectories);
                var File_sid1 = ConfigurationManager.AppSettings["File_sid1"];
                var File_sid2 = ConfigurationManager.AppSettings["File_sid2"];

                var mergedFile1 = new XDocument();
                XElement newDocument = new XElement("Votes");
                mergedFile1.Add(newDocument);
                var mergedFile2 = new XDocument();
                XElement newDocument2 = new XElement("Votes");
                mergedFile2.Add(newDocument2);

                string FilePath = ConfigurationManager.AppSettings["FilePath"];
                if (!File.Exists(FilePath))
                {
                    foreach (var file in files)
                    {
                        using (StreamWriter writer = new StreamWriter(FilePath, true))
                        {
                            writer.WriteLine(file);
                        }
                    }
                }
                string[] lines = File.ReadAllLines(FilePath);

                foreach (string line in lines)
                {
                    if (line.Contains(StationId1))
                    {
                        XDocument xdoc = XDocument.Load(line);
                        mergedFile1.Root.Add(xdoc.Descendants("Vote"));
                    }
                    if (line.Contains(StationId2))
                    {
                        XDocument xdoc = XDocument.Load(line);
                        mergedFile2.Root.Add(xdoc.Descendants("Vote"));
                    }
                }
                mergedFile1.Save(File_sid1);
                mergedFile2.Save(File_sid2);

                MergeIntoOne(File_sid1, File_sid2);
                Console.WriteLine("Successfully Executed");
                File.Delete(FilePath);


            }
            catch (Exception ex)
            {
                throw new Exception("Exception Error: " + ex.Message);
            }
        }
    }
}
