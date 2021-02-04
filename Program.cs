using Microsoft.Win32;
using System;

namespace AlwaysUp_TrialRenewal
{
    class Program
    {
        //1612621085
        static void Main(string[] args)
        {
            long newTimestamp = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds() + 60 * 60 * 24 * 2;
            Registry.SetValue(
                @"HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Core Technologies Consulting\AlwaysUp", 
                "Run",
                newTimestamp
                );
        }
    }
}
