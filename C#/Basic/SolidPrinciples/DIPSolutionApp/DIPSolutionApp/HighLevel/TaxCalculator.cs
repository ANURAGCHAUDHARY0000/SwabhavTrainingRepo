using System;


namespace DIPSolutionApp.HighLevel
{
    internal class TaxCalculator
    {
        private ILogger _logger;
        public TaxCalculator(ILogger logger)
        {
            _logger = logger;
        }

		public int CalculateTax(int income, int rate)
		{

			int result = -1;
			try
			{

				result = income / rate;

			}
			catch (Exception ex)
			{

				_logger.Write(ex.Message);

			}

			return result;
		}
	}
}
