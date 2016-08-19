using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sports_Management_System__SMS_
{
    public partial class Cricket_Entry : Form
    {
        public Cricket_Entry()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                string constring = "datasource = localhost;port =3306;username=root;password=connect";
                string Query = "insert into sports.cricket (Name,Country,Age,Total_Match,Test_Match,ODI_Match,T20_Match,Test_Run,ODI_Run,T20_Run) values ('" + this.name.Text + "', '" + this.country.Text + "', '" + this.age.Text + "', '" + this.totalmatch.Text + "','"+this.testmatch.Text+"','"+this.odimatch.Text+"','"+this.t20match.Text+"','"+this.testrun.Text+"','"+this.odirun.Text+"','"+this.t20run.Text+"');";
                MySqlConnection conDatabase = new MySqlConnection(constring);
                MySqlCommand cmdDatabase = new MySqlCommand(Query, conDatabase);
                MySqlDataReader myReader;
                try
                {
                    conDatabase.Open();
                    myReader = cmdDatabase.ExecuteReader();
                    MessageBox.Show("Saved");
                    name.Clear();
                    country.Clear();
                    age.Clear();
                    totalmatch.Clear();
                    testmatch.Clear();
                    odimatch.Clear();
                    t20match.Clear();
                    t20run.Clear();
                    odirun.Clear();
                    testrun.Clear();

                    while (myReader.Read())
                    {

                    }
                    conDatabase.Close();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        private void infodelete_Click(object sender, EventArgs e)
        {
            
                string constring = "datasource = localhost;port =3306;username=root;password=connect";
                string Query = "delete from sports.cricket where Name='" + this.name.Text + "';";
                MySqlConnection conDatabase = new MySqlConnection(constring);
                MySqlCommand cmdDatabase = new MySqlCommand(Query, conDatabase);
                MySqlDataReader myReader;
                try
                {
                    if (name.Text != null)
                    {
                        conDatabase.Open();
                        myReader = cmdDatabase.ExecuteReader();
                        MessageBox.Show("Deleted");
                        name.Clear();

                        while (myReader.Read())
                        {

                        }
                        conDatabase.Close();                
                    }
                    else MessageBox.Show("See Help Tab");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        
        }
    }

