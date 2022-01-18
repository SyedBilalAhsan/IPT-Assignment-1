using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Configuration;


namespace K181133_Q2
{
    
    public partial class Frm_Login : Form
    {
        Person person = new Person();
        VoterList votes = new VoterList();
        public Frm_Login()
        {
            InitializeComponent();
        }

        public static string Base64Decode(string encodedString)
        {
            try
            {
                byte[] data = Convert.FromBase64String(encodedString);
                string decodedString = Encoding.UTF8.GetString(data);
                return decodedString;
            }
            catch (Exception exception)
            {
                throw new Exception("Error in base64Decode" + exception.Message);
            }
        }
        private void FormLogin_Load(object sender, EventArgs e)
        {
            try
            {
                string path = ConfigurationManager.AppSettings["Path"];
                if (File.Exists(path))
                {  
                    var lines = File.ReadAllLines(path);
                    foreach (var line in lines)
                    {
                        String[] fields = line.Split(',');
                        person.userName.Add(fields[0]);
                        person.password.Add(Base64Decode(fields[1]));
                        person.stationId.Add(fields[2]);
                    }
                }
                else
                {
                    MessageBox.Show("File Not Found");
                }
            }
            catch (Exception exception)
            {
                throw new Exception("Exception Error: " + exception.Message);
            }
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {     
            try
            {
                bool LoggedIn = false;
                for (int i = 0; i < person.userName.Count; i++)
                {
                    if (uname_input.Text == (string)person.userName[i] && pw_input.Text == (string)person.password[i] && sid_cb.Text == (string)person.stationId[i])
                    {
                        votes.StationID = sid_cb.Text;
                        LoggedIn = true;
                    }
                }
                if (LoggedIn == false)
                {
                    MessageBox.Show("Incorrect Email or password or StationID");
                }
                else
                {
                    var frm_VDetails = new frm_VDetails(votes.StationID);
                    frm_VDetails.Show();
                    this.Hide();
                }
            }      
            catch (Exception exception)
            {
                throw new Exception("Exception Error: " + exception.Message);
            }
        }
    }
 }

