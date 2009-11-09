﻿// srp4net 1.0
// SRP for .NET - A Javascript/C# .NET library for implementing the SRP authentication protocol
// by Sorin Ostafiev (http://code.google.com/p/srp4net/)
// License: LGPL v3 (http://www.gnu.org/licenses/lgpl-3.0.txt)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace srp4net.Helpers
{
    internal abstract class SHA512
    {
        public static byte[] Hash(byte[] ar)
        {
            return new System.Security.Cryptography.SHA512Managed().ComputeHash(ar);
        }
    }
}