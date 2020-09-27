using System;
using System.Collections.Generic;
using System.Text;

namespace AlertServiceChallenge
{
    public interface IAlertDao
   {
       Guid AddAlert(DateTime time);
       DateTime GetAlert(Guid id);
   }
}
