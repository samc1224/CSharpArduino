using System.Diagnostics;

namespace CSharpArduino
{
    /// <summary>
    /// Execute command
    /// </summary>
    public class CmdHelper
    {
        private static readonly string CmdPath = @"C:\Windows\System32\cmd.exe";

        /// <summary>
        /// 執行cmd指令
        /// 多命令請使用批次命令連接符號：
        /// <![CDATA[
        /// &:同時執行兩個指令
        /// |:將上一個指令的輸出,作為下一個指令的輸入
        /// &&：當&&前的指令成功時,才執行&&後的指令
        /// ||：當||前的命令失敗時,才執行||後的命令]]>
        /// 其他請百度
        /// </summary>
        /// <param name="cmd"></param>
        /// <param name="output"></param>
        public static void RunCmd(string cmd, out string output)
        {
            cmd = cmd.Trim().TrimEnd('&') + "&exit";//說明：不管指令是否成功均執行exit指令，否則當呼叫ReadToEnd()方法時，會處於假死狀態
            using (Process p = new Process())
            {
                p.StartInfo.FileName = CmdPath;
                p.StartInfo.UseShellExecute = false;        //是否使用作業系統shell啟動
                p.StartInfo.RedirectStandardInput = true;   //接受來自呼叫程式的輸入訊息
                p.StartInfo.RedirectStandardOutput = true;  //由呼叫程式獲取輸出訊息
                p.StartInfo.RedirectStandardError = true;   //重定向標準錯誤輸出
                p.StartInfo.CreateNoWindow = true;          //不顯示程式視窗
                p.Start();//啟動程式

                //向cmd視窗寫入命令
                p.StandardInput.WriteLine(cmd);
                p.StandardInput.AutoFlush = true;

                //取得cmd視窗的輸出訊息
                output = p.StandardOutput.ReadToEnd();
                p.WaitForExit();//等待程式執行完退出進程
                p.Close();
            }
        }

        public static void OpenCmdWindow(string cmd)
        {
            using (Process p = new Process())
            {
                p.StartInfo.FileName = CmdPath;
                p.StartInfo.UseShellExecute = true;
                p.StartInfo.RedirectStandardInput = true;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardError = true;
                p.StartInfo.CreateNoWindow = false;
                p.Start();

                //p.StandardInput.WriteLine(cmd);
                //p.StandardInput.AutoFlush = true;
            }
        }
    }

    class test
    {
        static string test1()
        {
            //使用範例

            //範例1：顯示ipconfig訊息
            string cmd = @"ipconfig/all";

            //範例2：開啟VS2010命令提示
            //string cmd = @"C:&cd C:\Program Files (x86)\Microsoft Visual Studio 10.0\VC&vcvarsall.bat";

            //範例3：使用sn.exe工具產生金鑰對並顯示
            //string cmd = @"C:&cd C:\Program Files (x86)\Microsoft Visual Studio 10.0\VC&vcvarsall.bat&sn -k d:\LicBase.snk&sn -p d:\LicBase.snk d:\LicBasePubKey.snk&sn -tp d:\LicBasePubKey.snk";

            //呼叫
            string output = "";
            CmdHelper.RunCmd(cmd, out output);
            return output;
        }
    }
}
