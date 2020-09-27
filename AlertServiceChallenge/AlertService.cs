using System;

namespace AlertServiceChallenge
{
    public class AlertService
    {
        private readonly IAlertDao _alertDao;
        public AlertService(IAlertDao alertDao)
        {
            _alertDao = alertDao;
        }
        public Guid RaiseAlert()
        {
            return _alertDao.AddAlert(DateTime.Now);
        }

        public DateTime GetAlertTime(Guid id)
        {
            return _alertDao.GetAlert(id);
        }
    }
}
