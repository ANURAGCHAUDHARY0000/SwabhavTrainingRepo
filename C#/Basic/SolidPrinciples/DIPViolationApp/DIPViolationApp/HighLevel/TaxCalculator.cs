using System;
using DIPViolationApp.HighLevel;
using DIPViolationApp.LowLevel;

namespace DIPViolationApp.HighLevel
{
    internal class TaxCalculator
    {
        private LogType _log;

        public TaxCalculator(LogType log)
        {
            _log = log;
        }

        public int Calculate(int income,int rate)
        {
            int result = -1;
            try
            {
                result = income / rate;

            }catch(Exception ex)
            {
                if (_log == LogType.DB)
                {
                    DBLogger db = new DBLogger();
                    db.Write(ex.Message);
                }

                if (_log == LogType.FILE)
                {
                    FileLogger file = new FileLogger();
                    file.Write(ex.Message);
                }
            }
            return result;
        }
    }
}
