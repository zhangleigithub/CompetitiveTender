using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Summer.Common.Utility.Commnd
{
    /// <summary>
    /// author:刘小兵
    /// memo:公共类
    /// </summary>
    public class Utility
    {
        /// <summary>
        /// 将目录和文件压缩为rar格式并保存到指定的目录
        /// </summary>
        /// <param name="soruceDir">要压缩的文件夹目录</param>
        /// <param name="rarFileName">压缩后的rar保存路径</param>
        public void CompressRar(string soruceDir, string rarFileName)
        {
            //这个路径以后会做成配置文件
            string regKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\WinRAR.exe";
            RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(regKey);
            string winrarPath = registryKey.GetValue("").ToString();
            registryKey.Close();
            string winrarDir = System.IO.Path.GetDirectoryName(winrarPath);
            String commandOptions = string.Format("a {0} {1} -r", rarFileName, soruceDir);

            ProcessStartInfo processStartInfo = new ProcessStartInfo();
            processStartInfo.FileName = System.IO.Path.Combine(winrarDir, "rar.exe");
            processStartInfo.Arguments = commandOptions;
            processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            Process process = new Process();
            process.StartInfo = processStartInfo;
            process.Start();
            process.WaitForExit();
            process.Close();
        }

        /// <summary>
        /// 将格式为rar的压缩文件解压到指定的目录
        /// </summary>
        /// <param name="rarFileName">要解压rar文件的路径</param>
        /// <param name="saveDir">解压后要保存到的目录</param>
        public void DeCompressRar(string rarFileName, string saveDir)
        {
            string regKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\WinRAR.exe";
            RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(regKey);
            string winrarPath = registryKey.GetValue("").ToString();
            registryKey.Close();
            string winrarDir = System.IO.Path.GetDirectoryName(winrarPath);
            String commandOptions = string.Format("x {0} {1} -y", rarFileName, saveDir);

            ProcessStartInfo processStartInfo = new ProcessStartInfo();
            processStartInfo.FileName = System.IO.Path.Combine(winrarDir, "rar.exe");
            processStartInfo.Arguments = commandOptions;
            processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;

            Process process = new Process();
            process.StartInfo = processStartInfo;
            process.Start();
            process.WaitForExit();
            process.Close();
        }

        /// <summary>
        /// CA加密
        /// </summary>
        /// <param name="path">加密文件路径</param>
        /// <returns></returns>
        public string CAToEncryption(string path)
        {
            string outKty = string.Empty;
            // 使用pwdKey的base64编码作为加密key
            //String key = base64Encode(pwdKey);
            // 获取证书的公钥
            //String pubKey = getInstance().getCertInfo(exchCert, 30);
            // 使用加密key对证书公钥将证书进行对称加密，获得文件加密密文
            //String encryptKey = getInstance().symmEncryptData(key, pubKey);
            // 获取加密密文的base64编码
            //String encryptKeyBase64 = getInstance().base64Encode(encryptKey.getBytes());
            // 使用文件加密密文对文件进行加密  encryptKeyBase64（密码）inFile（输入文件）outFile（加密输出文件）
            //fileDesHelper.encrypt(encryptKeyBase64, inFile, outFile);
            return outKty;
        }

        /// <summary>
        /// 非CA加密
        /// </summary>
        /// <param name="path">加密文件路径</param>
        /// <returns></returns>
        public string NoCAToEncryption(string path)
        {
            string outKty = string.Empty;
            string pwdKey = "c2lubzMyMTBAMjAxODA0MjY=";
            // 使用pwdKey的base64编码作为加密key
            //String key = base64Encode(pwdKey);
            // 使用加密key对pwd进行对称加密
            //String encryptKey = getInstance().symmEncryptData(key, pwd);
            // 获取加密密文的base64编码
            //String encryptKeyBase64 = getInstance().base64Encode(encryptKey.getBytes());
            // 使用文件加密密文的base64对文件进行加密
            //fileDesHelper.encrypt(encryptKeyBase64, inFile, outFile);

            return outKty;
        }
    }
}
