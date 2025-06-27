using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Security.Cryptography;
using System.Text;

namespace TorrentCast
{
    public class cryptoKit
    {
        public static string EncryptString(string plainText)
        {
            using (var aesAlg = Aes.Create())
            {
                aesAlg.Key = GenerateKey();
                aesAlg.IV = GenerateIV();
                aesAlg.Mode = CipherMode.CBC;
                aesAlg.Padding = PaddingMode.PKCS7;

                var encryptor = aesAlg.CreateEncryptor();

                var ms = new MemoryStream();
                var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write);
                using (var sw = new StreamWriter(cs))
                {
                    sw.Write(plainText);
                }

                return Convert.ToBase64String(ms.ToArray());
            }
        }

        public static string DecryptString(string cipherText)
        {
            //Debug.WriteLine("decrypting :" + cipherText);
            using (var aesAlg = Aes.Create())
            {
                aesAlg.Key = GenerateKey();
                aesAlg.IV = GenerateIV();
                aesAlg.Mode = CipherMode.CBC;
                aesAlg.Padding = PaddingMode.PKCS7;

                var decryptor = aesAlg.CreateDecryptor();

                var buffer = Convert.FromBase64String(cipherText);
                var ms = new MemoryStream(buffer);
                var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read);
                var sr = new StreamReader(cs);
                return sr.ReadToEnd();
            }
        }


        public static byte[] GenerateKey()
        {
            var sha256 = SHA256.Create();
            var hashed = GetMotherboardSerial().GetHashCode();
            // Generate a key based on the motherboard serial number
            var key = sha256.ComputeHash(BitConverter.GetBytes(hashed));
            return key;
        }

        public static byte[] GenerateIV()
        {
            var md5 = MD5.Create();
            var hashed = GetMotherboardSerial().GetHashCode();
            // Generate an IV based on the motherboard serial number
            var iv = md5.ComputeHash(BitConverter.GetBytes(hashed));
            return iv;
        }

        public static string GetMotherboardSerial()
        {
            using (var searcher = new ManagementObjectSearcher("SELECT SerialNumber FROM Win32_BaseBoard"))
            {
                foreach (ManagementObject obj in searcher.Get()) return obj["SerialNumber"]?.ToString().Trim();
            }

            return null;
        }
    }
}