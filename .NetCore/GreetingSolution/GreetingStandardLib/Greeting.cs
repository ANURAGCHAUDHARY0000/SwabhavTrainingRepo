using System;

namespace GreetingStandardLib
{
    public class Greeting
    {
        public string Message
        {
            get
            {
                var hrs = DateTime.Now.Hour;
                if (hrs > 18)
                {
                    return "Good Evening";
                }
                if (hrs > 12)
                {
                    return "Good Afternoon";
                }
                return "Good Morning";
            }
        }

    }
}
