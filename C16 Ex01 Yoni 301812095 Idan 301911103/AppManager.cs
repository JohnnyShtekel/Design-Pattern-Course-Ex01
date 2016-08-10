using FacebookWrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace C16_Ex01_Yoni_301812095_Idan_301911103
{
    public class AppManager
    {
        private FormLogin m_LoginForm;
        private FormFacebook m_FacebookForm;
        public AppManager()
        {
            m_LoginForm = new FormLogin();
            
        }
        public void Start()
        {
            m_LoginForm.ShowDialog();
            if (m_LoginForm.IsLoggedIn)
            {
                m_LoginForm.Close();
                m_FacebookForm = new FormFacebook();
                m_FacebookForm.ShowDialog();
            }

            FacebookService.Logout(new Action(run));

        }


        void run()
        {
            Start();
        }
    }
}
