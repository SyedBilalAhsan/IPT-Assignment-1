using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;
using K181133_Q4.Models;

namespace K181133_Q4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            try
            {
                List<Details> details = new List<Details>();
                string filePath = WebConfigurationManager.AppSettings["filePath"];
                string cListPath = WebConfigurationManager.AppSettings["cListPath"];

                XmlDocument doc = new XmlDocument();
                doc.Load(filePath);
                ArrayList Cid = new ArrayList();
                ArrayList Pos = new ArrayList();
                foreach (XmlNode node in doc.SelectNodes("/Votes/Vote"))
                {
                    Cid.Add(node["CandidateID"].InnerText);
                    Pos.Add(node["Position"].InnerText);
                }

                var lines = System.IO.File.ReadAllLines(cListPath);
                int count = 0;

                foreach (var line in lines)
                {
                    String[] fields = line.Split(',');
                    count = 0;
                    for (int i = 0; i < Cid.Count; i++)
                    {
                        if (fields[0].Contains(Cid[i].ToString()))
                        {
                            if (fields[2].Contains(Pos[i].ToString()))
                            {
                                count++;
                            }
                        }
                    }

                    details.Add(new Details
                    {
                        CandidateId = (fields[0]),
                        CandidateName = (fields[1]),
                        Position = (fields[2]),
                        votes = count.ToString(),

                    });
                }
                return View(details);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}