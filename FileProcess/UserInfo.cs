using System;
using System.Collections.Generic;
using System.Text;

namespace FileProcess
{
    public class UserInfo
    {
        public string UserName { get; set; }
        public string UserPassword { get; set; }

        private bool _sessionInfo;

        public void SessionControl(UserInfo userInfo)
        {
            if(userInfo.UserName != "" && userInfo.UserPassword != "")
            {
                setSessionInfo(true);
            } 
            else
            {
                setSessionInfo(false);
            }
        }
        
        public void setSessionInfo(bool session)
        {
            _sessionInfo = session;
        }

        public bool getSessionInfo()
        {
            return _sessionInfo;
        }
    }
}
