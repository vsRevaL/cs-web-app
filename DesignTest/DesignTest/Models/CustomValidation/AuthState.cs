using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignTest.Models.CustomValidation
{
    public static class AuthState
    {
        public static States State { get; set; }
    }

    public enum States
    {
        LOG,
        REG
    }
}
