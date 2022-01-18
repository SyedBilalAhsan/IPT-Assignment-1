using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Configuration;
using System.Collections;
using System.Xml;
using System.Xml.Linq;


namespace K181133_Q2
{
    public partial class frm_VDetails : Form
    {
        VoterList vList = new VoterList();
        CandidateList cList = new CandidateList();
        VoterList votes = new VoterList();

        public frm_VDetails(string sid)
        {
            InitializeComponent();
            sid_tb.Text = sid;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                string candidateListPath = ConfigurationManager.AppSettings["CPath"];
                if (!File.Exists(candidateListPath))
                {
                    MessageBox.Show("Candidate List File Not Exist");
                }
                else
                {
                    var lines = File.ReadAllLines(candidateListPath);

                    foreach (var line in lines)
                    {
                        String[] fields = line.Split(',');
                        cList.CandidateID.Add(fields[0]);
                        cList.CandidateName.Add(fields[1]);
                        cList.Position.Add(fields[2]);
                        if (fields[2] == "President")
                        {
                            Pres_cb.Items.Add(fields[1]);
                        }
                        else if (fields[2] == "Vice President")
                        {
                            VPres_cb.Items.Add(fields[1]);
                        }
                        else if (fields[2] == "General Secretary")
                        {
                            Gsec_cb.Items.Add(fields[1]);
                        }
                    }
                }     
             }
            catch (Exception ex)
            {
                throw new Exception("Exception Error: " + ex.Message);
            }
        }

       
        private bool IsValidCNIC(string cnic)
        {
            Regex check = new Regex(@"^[0-9]{5}-[0-9]{7}-[0-9]{1}$");
            bool valid = false;
            valid = check.IsMatch(cnic);
            return valid;
        }


        private void back_btn_Click(object sender, EventArgs e)
        {
            var Frm_Login = new Frm_Login();
            Frm_Login.Show();
            this.Hide();
        }
    
        public void saveXml(string Nic, string Position, string CandidateID)
        {
            try
            {
                string xmlpath = ConfigurationManager.AppSettings["XmlPath"];
                string fullXmlPath =xmlpath + sid_tb.Text + "_" + DateTime.Now.ToString("ddMMMyy") + "_" + DateTime.Now.ToString("HH") + ".xml";
                if (!File.Exists(fullXmlPath))
                {
                    XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
                    xmlWriterSettings.Indent = true;
                    xmlWriterSettings.NewLineOnAttributes = true;
                    using (XmlWriter xmlWriter = XmlWriter.Create(fullXmlPath, xmlWriterSettings))
                    {
                        xmlWriter.WriteStartDocument();
                        xmlWriter.WriteStartElement("Votes");

                        xmlWriter.WriteStartElement("Vote");
                        xmlWriter.WriteElementString("NIC", Nic);
                        xmlWriter.WriteElementString("Position", Position);
                        xmlWriter.WriteElementString("CandidateID", CandidateID);
                        xmlWriter.WriteEndElement();

                        xmlWriter.WriteEndElement();
                        xmlWriter.WriteEndDocument();
                        xmlWriter.Flush();
                        xmlWriter.Close();
                    }
                }
                else
                {
                    XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
                    xmlWriterSettings.Indent = true;
                    xmlWriterSettings.NewLineOnAttributes = true;
                    XDocument xmlDoc = XDocument.Load(fullXmlPath);
                    XElement root = xmlDoc.Element("Votes");
                    IEnumerable<XElement> rows = root.Descendants("Vote");
                    XElement firstRow = rows.First();
                    firstRow.AddBeforeSelf( new XElement("Vote", new XElement("NIC", Nic), new XElement("Position", Position),  new XElement("CandidateID", CandidateID)));
                    xmlDoc.Save(fullXmlPath);
                    
                }
            }
            catch(Exception ex)
            {
                throw new Exception("Exception Error: " + ex.Message);
            }

        }
  
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            try
            {
                bool voted = false;
                vList.Nic = nic_input.Text;
                string votedPath = ConfigurationManager.AppSettings["VtdPath"];
                string voterListPath = ConfigurationManager.AppSettings["VLPath"];
               
                if (!File.Exists(voterListPath))
                {
                     MessageBox.Show("Voter List File not Found");
                }
                else
                {
                    string voterListFile = File.ReadAllText(voterListPath);
                    if (IsValidCNIC(vList.Nic))
                    {
                        if (voterListFile.Contains(vList.Nic))
                        {
                            if (Pres_cb.SelectedItem == null && VPres_cb.SelectedItem == null && Gsec_cb.SelectedItem == null)
                            {
                                MessageBox.Show("Please Vote Atleast 1");
                            }
                            else
                            {
                                MessageBox.Show("NIC Verified ");
                                if (!File.Exists(votedPath))
                                {
                                    FileStream fs = File.Create(votedPath);
                                    fs.Close();
                                }
                                string votedPathFile = File.ReadAllText(votedPath);
                                if (votedPathFile.Contains(vList.Nic))
                                {
                                    voted = true;
                                }
                                using (StreamWriter sw = new StreamWriter(votedPath, true))
                                {
                                    if (Pres_cb.SelectedItem != null && voted == false)
                                    {
                                        for (int i = 0; i < cList.CandidateName.Count; i++)
                                        {
                                            if ((cList.CandidateName[i]) == Pres_cb.SelectedItem)
                                            {
                                                Pcid_tb.Text = cList.CandidateID[i].ToString();
                                            }
                                        }
                                        saveXml(vList.Nic, President_tb.Text, Pcid_tb.Text);
                                        sw.WriteLine(vList.Nic + ',' + President_tb.Text + ',' + Pcid_tb.Text);
                                    }
                                    if (VPres_cb.SelectedItem != null && voted == false)
                                    {
                                        for (int i = 0; i < cList.CandidateName.Count; i++)
                                        {
                                            if ((cList.CandidateName[i]) == VPres_cb.SelectedItem)
                                            {
                                                VPcid_tb.Text = cList.CandidateID[i].ToString();
                                            }
                                        }
                                        saveXml(vList.Nic, VicePresident_tb.Text, VPcid_tb.Text);
                                        sw.WriteLine(vList.Nic + ',' + VicePresident_tb.Text + ',' + VPcid_tb.Text);
                                    }
                                    if (Gsec_cb.SelectedItem != null && voted == false)
                                    {
                                        for (int i = 0; i < cList.CandidateName.Count; i++)
                                        {
                                            if ((cList.CandidateName[i]) == Gsec_cb.SelectedItem)
                                            {
                                                Gcid_tb.Text = cList.CandidateID[i].ToString();
                                            }
                                        }
                                        saveXml(vList.Nic, GeneralSecretary_tb.Text, Gcid_tb.Text);
                                        sw.WriteLine(vList.Nic + ',' + GeneralSecretary_tb.Text + ',' + Gcid_tb.Text);
                                    }
                                }
                                if (voted == true)
                                {
                                    MessageBox.Show("Already Voted");
                                }
                                else
                                {
                                    MessageBox.Show("Voted Successfully");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("NIC Not Found in Voters List");
                        }
                    }
                    else
                    {
                        MessageBox.Show("NIC Format not valid");
                    }
                }        
            }
            catch (Exception ex)
            {
                throw new Exception("Exception Error: " + ex.Message);
            }  
        }   
    }
}
