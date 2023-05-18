﻿using System.Security.Cryptography;
using System.Text;
using System;

namespace MultivendorEcommerce.Encript_Decrypt
{
    public class Password
    {
        public static string HashEncrypt(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                return "";
            }
            SHA512 hashSvc = SHA512.Create();
            byte[] hash = hashSvc.ComputeHash(Encoding.UTF8.GetBytes(password));
            var EncodedPassword = BitConverter.ToString(hash).Replace("-", "");
            return EncodedPassword;
        }
    }
}
