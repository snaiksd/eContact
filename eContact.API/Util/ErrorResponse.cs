using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eContact.API.Util
{
    public class ErrorResponse
    {
        [JsonProperty("errorDetail")]
        public string ErrorDetails { get; set; }

        [JsonProperty("apiErrorMessage")]
        public string ErrorMessage { get; set; }

        public static ErrorResponse FormatResponse(string errorMessage, string errorDetails = "")
        {
            return new ErrorResponse() { ErrorDetails = errorDetails, ErrorMessage = errorMessage };
        }
    }
}
