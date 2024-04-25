using MobileControlGuru.Properties;
using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileControlGuru.Tools
{
    public class ZipHelper
    {
        public static void ExtractZipToDirectory(string outputDirectory)
        {
             
            byte[] zipBytes = Resources.scrcpy; // 获取 ZIP 文件的字节数组  

            // 确保输出目录存在  
            Directory.CreateDirectory(outputDirectory);

            // 创建一个临时 ZIP 文件  
            string tempZipPath = Path.GetTempFileName();
            try
            {
                // 将字节数组写入临时 ZIP 文件  
                File.WriteAllBytes(tempZipPath, zipBytes);

                // 使用 ZipFile 解压临时 ZIP 文件到指定的输出目录  
                ZipFile.ExtractToDirectory(tempZipPath, outputDirectory);
            }
            catch(Exception e)
            {

            }
            finally
            {
                // 删除临时 ZIP 文件  
                File.Delete(tempZipPath);
            }
        }
    }
}
