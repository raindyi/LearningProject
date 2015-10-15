/********************************************/
//DecryptAndEncryptionHelper//
//加密解密Helper
//Created by Lynn 2015.09.13 11:29
/********************************************/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace NT.TestDemo.Common.Helper
{
    /// <summary>
    /// DecryptAndEncryptionHelper
    /// </summary>
    public class DecryptAndEncryptionHelper
    {
        private SymmetricAlgorithm symmetricAlgorithm;
        private String _key = "qazwsxedcrfvtgb!@#$%^&*(tgbrfvedcwsxqaz)(*&^%$#@!";
        public String Key
        {
            get { return _key; }
            set { _key = value; }
        }
        private String _iv = "tgbrfvedcwsxqaz)(*&^%$#@!qazwsxedcrfvtgb!@#$%^&*(";
        public String IV
        {
            get { return _iv; }
            set { _iv = value; }
        }
        public DecryptAndEncryptionHelper()
        {
            symmetricAlgorithm = new RijndaelManaged();
        }

        public DecryptAndEncryptionHelper(String Key, String IV)
        {
            symmetricAlgorithm = new RijndaelManaged();
            _key = String.IsNullOrEmpty(Key) ? _key : Key;
            _iv = String.IsNullOrEmpty(Key) ? _iv : IV;
        }
        /// <summary>
        /// Get Key
        /// </summary>
        /// <returns>密钥</returns>
        private byte[] GetLegalKey()
        {
            symmetricAlgorithm.GenerateKey();
            byte[] bytTemp = symmetricAlgorithm.Key;
            int KeyLength = bytTemp.Length;
            if (_key.Length > KeyLength)
                _key = _key.Substring(0, KeyLength);
            else if (_key.Length < KeyLength)
                _key = _key.PadRight(KeyLength, '#');
            return ASCIIEncoding.ASCII.GetBytes(_key);
        }

        /// <summary>
        /// Get IV
        /// </summary>
        private byte[] GetLegalIV()
        {
            symmetricAlgorithm.GenerateIV();
            byte[] bytTemp = symmetricAlgorithm.IV;
            int IVLength = bytTemp.Length;
            if (_iv.Length > IVLength)
                _iv = _iv.Substring(0, IVLength);
            else if (_iv.Length < IVLength)
                _iv = _iv.PadRight(IVLength, '#');
            return ASCIIEncoding.ASCII.GetBytes(_iv);
        }

        /// <summary>
        /// Encrypto
        /// </summary>
        public string Encrypto(string Source)
        {
            byte[] bytIn = UTF8Encoding.UTF8.GetBytes(Source);
            MemoryStream ms = new MemoryStream();
            symmetricAlgorithm.Key = GetLegalKey();
            symmetricAlgorithm.IV = GetLegalIV();
            ICryptoTransform encrypto = symmetricAlgorithm.CreateEncryptor();
            CryptoStream cs = new CryptoStream(ms, encrypto, CryptoStreamMode.Write);
            cs.Write(bytIn, 0, bytIn.Length);
            cs.FlushFinalBlock();
            ms.Close();
            byte[] bytOut = ms.ToArray();
            return Convert.ToBase64String(bytOut);
        }

        /// <summary>
        /// Decrypto
        /// </summary>
        public string Decrypto(string Source)
        {
            byte[] bytIn = Convert.FromBase64String(Source);
            MemoryStream ms = new MemoryStream(bytIn, 0, bytIn.Length);
            symmetricAlgorithm.Key = GetLegalKey();
            symmetricAlgorithm.IV = GetLegalIV();
            ICryptoTransform encrypto = symmetricAlgorithm.CreateDecryptor();
            CryptoStream cs = new CryptoStream(ms, encrypto, CryptoStreamMode.Read);
            StreamReader sr = new StreamReader(cs);
            return sr.ReadToEnd();
        }
    }
}
