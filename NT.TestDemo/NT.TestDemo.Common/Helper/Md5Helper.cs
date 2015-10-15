using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace NT.TestDemo.Common.Helper
{
   public static  class Md5Helper
    {
        //对输入的字符串进行Md5散列算法
        public static string GetMD5String(string input)
        {
            MD5 md5Obj = MD5.Create();
            byte[] buffer = System.Text.Encoding.Default.GetBytes(input);
            byte[] md5buffer = md5Obj.ComputeHash(buffer);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < md5buffer.Length; i++)
            {
                sb.Append(md5buffer[i].ToString("X2"));
            }
            md5Obj.Clear();
            return sb.ToString();
        }
       //对文件进行Md5进行散列算法
        public static string EncyrptMd5(string path)
        {
            MD5 md5 = MD5.Create();
            using (FileStream fsRead = File.OpenRead(path))
            {
                byte[] md5Buffer = md5.ComputeHash(fsRead);
                md5.Clear();
                return BitConverter.ToString(md5Buffer).Replace("-", "").ToString();
            }
        }
    }
}
