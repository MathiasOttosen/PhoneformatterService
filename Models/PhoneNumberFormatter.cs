using System;
using System.Text.RegularExpressions;

namespace friendlyphonenumber.Models{
    public class PhoneNumberFormatter{
        public long NumericPhoneNumber{
            get;
            set;
        }
        public string FormattedPhoneNumber{
            get;
            set;
        }

        public void ConvertPhoneNumber()
        {
            FormattedPhoneNumber = string.Format("{0:+45 ## ## ## ##}", NumericPhoneNumber);
        }
    }
}