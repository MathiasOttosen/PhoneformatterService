using Microsoft.AspNetCore.Mvc;
using friendlyphonenumber.Models;
using System; 

namespace friendlyphonenumber.Controllers {
    [Route("api/[controller]")]
    public class FormatPhoneNumber: Controller {

        PhoneNumberFormatter formatter =  new PhoneNumberFormatter();

        public IActionResult Post([FromBody] NumericPhoneNumber phoneNumber) {
            Console.WriteLine("posting");

            if (phoneNumber != null) {
                formatter.NumericPhoneNumber = phoneNumber.PhoneNumber;
                formatter.ConvertPhoneNumber();
                FormattedPhoneNumber friendlyNumber = new FormattedPhoneNumber() {
                    PhoneNumber = formatter.FormattedPhoneNumber
                };
                return Ok(friendlyNumber.PhoneNumber + "1");
            }
            else {
                return BadRequest();
            }
        }

        
    }
    public class NumericPhoneNumber
    {
        public long PhoneNumber { get; set; }
    }
}