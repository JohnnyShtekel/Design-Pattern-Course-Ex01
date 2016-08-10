using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace C16_Ex01_Yoni_301812095_Idan_301911103
{
    public partial class FormLogin : Form
    {

        private bool m_IsLoggedIn = false;
        public FormLogin()
        {
            InitializeComponent();
            
        }

        public bool IsLoggedIn
        {
            get
            {
                return m_IsLoggedIn;
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if(LoggedInUser.Instance().IsUserConnected())
                {
                    m_IsLoggedIn = true;
                }
                if(m_IsLoggedIn == true)
                {
                    this.Close();
                }
                
            }
            catch
            {
                MessageBox.Show("Login Failed please try again");       
            }
                   
        }

    }
}
