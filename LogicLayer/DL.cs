using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace LogicLayer
{
    public class DL
    {
        public string userName { get; set; }
        public string passWord { get; set; }

    }
    public class accessDA
    {
        public void Add(DL obj) {
           
            DA.userName = obj.userName;
            DA.passWord = obj.passWord;
        }
       
          public string checkun = DA.userName;
          public string checkpw = DA.passWord;

        
    }
}
