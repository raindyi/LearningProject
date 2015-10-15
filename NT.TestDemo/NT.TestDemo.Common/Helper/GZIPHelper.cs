using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;

namespace NT.TestDemo.Common.Helper
{
    public class GZIPHelper
    {
        #region GZIP

        /// <summary>
        /// GZIP压缩
        /// </summary>
        /// <param name="rawData"></param>
        /// <returns></returns>
        public static byte[] Compress(byte[] rawData)
        {
            MemoryStream ms = new MemoryStream();
            GZipStream compressedzipStream = new GZipStream(ms, CompressionMode.Compress, true);
            compressedzipStream.Write(rawData, 0, rawData.Length);
            compressedzipStream.Close();
            return ms.ToArray();
        }

        /// <summary>
        /// GZIP解压
        /// </summary>
        /// <param name="result">返回字符串</param>
        /// <returns></returns>
        public static string Decompress(string result)
        {
            byte[] retArr = Convert.FromBase64String(result);
            MemoryStream ms = new MemoryStream(retArr);
            GZipStream compressionStream = new GZipStream(ms, CompressionMode.Decompress);
            StreamReader reader = new StreamReader(compressionStream);
            string data = reader.ReadToEnd();
            reader.Close();
            return data;
        }

        /// <summary>
        /// 流转byte[]
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static byte[] StreamToBytes(Stream stream)
        {
            byte[] bytes = new byte[stream.Length];
            stream.Read(bytes, 0, bytes.Length);
            stream.Seek(0, SeekOrigin.Begin);
            return bytes;
        }

        #endregion
    }
}
