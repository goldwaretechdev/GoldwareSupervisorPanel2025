using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldwareSupervisorPanel2025.Models
{
    public static class Constants
    {
        public static readonly string BASE_URL = "https://localhost:7108/api";
    }

    public static class ErrorCode
    {
        public static readonly string INTERNAL_ERROR = "INTERNAL_ERROR";
        public static readonly string NOT_FOUND = "NOT_FOUND";
        public static readonly string INVALID_ID = "INVALID_ID";
    }
}
