using Microsoft.VisualBasic;
using System;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace PhraseALator
{
    internal static class Module1
    {
        public static string gSerialDataBeingSent = "";
        public static bool gLastWasRepeat = false;
        public static string[] gPhonemes = new string[401];

        public const int cvP0 = 0;
        public const int cvP1 = 1;
        public const int cvP2 = 2;
        public const int cvP3 = 3;
        public const int cvP4 = 4;
        public const int cvP5 = 5;
        public const int cvP6 = 6;
        public const int cvFAST = 7;
        public const int cvSLOW = 8;
        public const int cvSTRESS = 14;
        public const int cvRELAX = 15;
        public const int cvWAIT = 16;
        public const int cvSOFT = 18;
        public const int cvVOLUME = 20;
        public const int cvSPEED = 21;
        public const int cvPITCH = 22;
        public const int cvBEND = 23;
        public const int cvPCTRL = 24;
        public const int cvPOUT = 25;
        public const int cvREPEAT = 26;
        public const int cvCALL = 28;
        public const int cvPLAY = 29;
        public const int cvDELAY = 30;
        public const int cvRESET = 31;
        public const int cvIY = 128;
        public const int cvIH = 129;
        public const int cvEY = 130;
        public const int cvEH = 131;
        public const int cvAY = 132;
        public const int cvAX = 133;
        public const int cvAW = 134;
        public const int cvOH = 135;
        public const int cvOW = 136;
        public const int cvUH = 137;
        public const int cvUW = 138;
        public const int cvMM = 139;
        public const int cvNE = 140;
        public const int cvNO = 141;
        public const int cvNGE = 142;
        public const int cvNGO = 143;
        public const int cvLE = 144;
        public const int cvLO = 145;
        public const int cvWW = 146;
        public const int cvRR = 147;
        public const int cvIYRR = 148;
        public const int cvEYRR = 149;
        public const int cvAXRR = 150;
        public const int cvAWRR = 151;
        public const int cvOWRR = 152;
        public const int cvEYIY = 153;
        public const int cvOHIY = 154;
        public const int cvOWIY = 155;
        public const int cvOHIH = 156;
        public const int cvIYEH = 157;
        public const int cvEHLE = 158;
        public const int cvIYUW = 159;
        public const int cvEHUW = 160;
        public const int cvAXUW = 161;
        public const int cvIHWW = 162;
        public const int cvAYWW = 163;
        public const int cvOWWW = 164;
        public const int cvJH = 165;
        public const int cvVV = 166;
        public const int cvZZ = 167;
        public const int cvZH = 168;
        public const int cvDH = 169;
        public const int cvBE = 170;
        public const int cvBO = 171;
        public const int cvEB = 172;
        public const int cvOB = 173;
        public const int cvDE = 174;
        public const int cvDO = 175;
        public const int cvED = 176;
        public const int cvOD = 177;
        public const int cvGE = 178;
        public const int cvGO = 179;
        public const int cvEG = 180;
        public const int cvOG = 181;
        public const int cvCH = 182;
        public const int cvHE = 183;
        public const int cvHO = 184;
        public const int cvWH = 185;
        public const int cvFF = 186;
        public const int cvSE = 187;
        public const int cvSO = 188;
        public const int cvSH = 189;
        public const int cvTH = 190;
        public const int cvTT = 191;
        public const int cvTU = 192;
        public const int cvTS = 193;
        public const int cvKE = 194;
        public const int cvKO = 195;
        public const int cvEK = 196;
        public const int cvOK = 197;
        public const int cvPE = 198;
        public const int cvPO = 199;
        public const int cvR0 = 200;
        public const int cvR1 = 201;
        public const int cvR2 = 202;
        public const int cvR3 = 203;
        public const int cvR4 = 204;
        public const int cvR5 = 205;
        public const int cvR6 = 206;
        public const int cvR7 = 207;
        public const int cvR8 = 208;
        public const int cvR9 = 209;
        public const int cvA0 = 210;
        public const int cvA1 = 211;
        public const int cvA2 = 212;
        public const int cvA3 = 213;
        public const int cvA4 = 214;
        public const int cvA5 = 215;
        public const int cvA6 = 216;
        public const int cvA7 = 217;
        public const int cvA8 = 218;
        public const int cvA9 = 219;
        public const int cvB0 = 220;
        public const int cvB1 = 221;
        public const int cvB2 = 222;
        public const int cvB3 = 223;
        public const int cvB4 = 224;
        public const int cvB5 = 225;
        public const int cvB6 = 226;
        public const int cvB7 = 227;
        public const int cvB8 = 228;
        public const int cvB9 = 229;
        public const int cvC0 = 230;
        public const int cvC1 = 231;
        public const int cvC2 = 232;
        public const int cvC3 = 233;
        public const int cvC4 = 234;
        public const int cvC5 = 235;
        public const int cvC6 = 236;
        public const int cvC7 = 237;
        public const int cvC8 = 238;
        public const int cvC9 = 239;
        public const int cvD0 = 240;
        public const int cvD1 = 241;
        public const int cvD2 = 242;
        public const int cvD3 = 243;
        public const int cvD4 = 244;
        public const int cvD5 = 245;
        public const int cvD6 = 246;
        public const int cvD7 = 247;
        public const int cvD8 = 248;
        public const int cvD9 = 249;
        public const int cvD10 = 250;
        public const int cvD11 = 251;
        public const int cvM0 = 252;
        public const int cvM1 = 253;
        public const int cvM2 = 254;

        internal enum WordTypes
        {
            wtNone,
            wtText,
            wtSpaces,
            wtCommas
        }

        internal static T ReadINI<T>(string SectionToRead, string ItemToRead, T DefaultValue)
        {
            using (IniFile iniFile = new IniFile(Path.Combine(Application.StartupPath, "PhraseALator.ini")))
                return iniFile.Read<T>(SectionToRead, ItemToRead, DefaultValue);
        }

        internal static void WriteINI<T>(string SectionToWrite, string ItemToWrite, T ValueToWrite)
        {
            using (IniFile iniFile = new IniFile(Path.Combine(Application.StartupPath, "PhraseALator.ini")))
                iniFile.Write<T>(SectionToWrite, ItemToWrite, ValueToWrite);
        }

        internal static string ReadDict(string SectionToRead, string ItemToRead, string DefaultValue)
        {
            using (IniFile iniFile = new IniFile(Path.Combine(Application.StartupPath, "PhraseALator.Dic")))
                return iniFile.Read(SectionToRead, ItemToRead, DefaultValue);
        }

        internal static void WriteDict(string SectionToWrite, string ItemToWrite, string ValueToWrite)
        {
            using (IniFile iniFile = new IniFile(Path.Combine(Application.StartupPath, "PhraseALator.Dic")))
                iniFile.Write(SectionToWrite, ItemToWrite, ValueToWrite);
        }

        internal static string ReadSound(string SectionToRead, string ItemToRead, string DefaultValue)
        {
            using (IniFile iniFile = new IniFile(Path.Combine(Application.StartupPath, "SJSounds.txt")))
                return iniFile.Read(SectionToRead, ItemToRead, DefaultValue);
        }

        internal static void WriteSound(string SectionToWrite, string ItemToWrite, int ValueToWrite)
        {
            using (IniFile iniFile = new IniFile(Path.Combine(Application.StartupPath, "SJSounds.txt")))
                iniFile.Write(SectionToWrite, ItemToWrite, ValueToWrite);
        }

        internal static void SendDataToSpeakJet(string SerialData, bool zUseFlowControl)
        {
            string TextRecieved = "";

            frmUtility.DefInstance.Timer1.Enabled = false;
            DialogResult qa = System.Windows.Forms.DialogResult.Yes;
            if (zUseFlowControl)
            {
                if (SerialData.Length >= 64)
                {
                    if (frmUtility.DefInstance.chkFlow.CheckState == CheckState.Unchecked)
                    {
                        qa = MessageBox.Show("Flow Control is currently disabled. -AND-" + Environment.NewLine + "The phrase that you are about to play is longer than 64 codes." + Environment.NewLine + Environment.NewLine + "This will result in some of the codes after the 64th one to not being played." + Environment.NewLine + Environment.NewLine + "Do you still want to send it to the SpeakJet.", "Notice", MessageBoxButtons.YesNo);
                    }
                }
            }
            if (qa == System.Windows.Forms.DialogResult.Yes)
            {
                OpenSerialPort(true, zUseFlowControl);
                if (frmUtility.DefInstance.SerialPort.IsOpen)
                {
                    // The following line is used if you want to detect that a serial device
                    //   is connected to the PC and skip the data output if one is not.
                    //If frmUtility.MSComm1.DSRHolding = True Then
                    gSerialDataBeingSent = SerialData;
                    TextRecieved = frmUtility.DefInstance.SerialPort.ReadExisting();

                    while (String.CompareOrdinal(gSerialDataBeingSent, "") > 0)
                    {
                        frmUtility.DefInstance.SerialPort.Write(gSerialDataBeingSent.Substring(0, Math.Min(1, gSerialDataBeingSent.Length)));
                        gSerialDataBeingSent = gSerialDataBeingSent.Substring(1);
                        Application.DoEvents();
                    };
                }
                // Close the com port in 1 second
                frmUtility.DefInstance.Timer1.Interval = 1000;
                frmUtility.DefInstance.Timer1.Start();
            }

        }

        internal static void CloseSerialPort()
        {
            if (frmUtility.DefInstance.SerialPort.IsOpen)
            {
                frmUtility.DefInstance.SerialPort.Close();
                frmUtility.DefInstance.txtComPort.BackColor = Color.White;
            }
        }

        internal static void OpenSerialPort(bool zReportError, bool zUseFlowControl)
        {

            try
            {
                if (!frmUtility.DefInstance.SerialPort.IsOpen)
                {
                    frmUtility.DefInstance.SerialPort.PortName = String.Format("COM{0}", Convert.ToInt32(frmUtility.DefInstance.txtComPort.Text));
                    frmUtility.DefInstance.SerialPort.BaudRate = ReadINI<int>("Serial", "BaudRate", 9600);
                    frmUtility.DefInstance.SerialPort.Parity = Parity.None;
                    frmUtility.DefInstance.SerialPort.DataBits = 8;
                    frmUtility.DefInstance.SerialPort.StopBits = StopBits.One;
                    frmUtility.DefInstance.SerialPort.Encoding = Encoding.Default;
                    if ((zUseFlowControl) && (frmUtility.DefInstance.chkFlow.CheckState == CheckState.Checked))
                    {
                        frmUtility.DefInstance.SerialPort.Handshake = Handshake.RequestToSend;
                    }
                    else
                    {
                        frmUtility.DefInstance.SerialPort.Handshake = Handshake.None;
                    }
                    frmUtility.DefInstance.SerialPort.Open();
                }
                if (frmUtility.DefInstance.SerialPort.IsOpen)
                {
                    frmUtility.DefInstance.txtComPort.BackColor = Color.Lime;
                }
            }
            catch
            {

                if (zReportError)
                {
                    frmUtility.DefInstance.txtComPort.BackColor = Color.Red;
                }
            }
        }

        internal static string FormatAllophoneList(string zText)
        {
            string result = "";
            string Work2 = "";
            string l = "";
            string r = "";
            string xChar = "";

            // Copvert all chars but the letters, numbers and the # sybol to the \ symbol.
            string Work1 = zText.ToUpper();
            int tempForEndVar = Work1.Length;
            for (int X = 1; X <= tempForEndVar; X++)
            {
                xChar = Work1.Substring(X - 1, Math.Min(1, Work1.Length - (X - 1)));
                if (String.CompareOrdinal(xChar, "A") >= 0 && String.CompareOrdinal(xChar, "Z") <= 0 || String.CompareOrdinal(xChar, "0") >= 0 && String.CompareOrdinal(xChar, "9") <= 0 || xChar == "#")
                {
                    Work2 = Work2 + xChar;
                }
                else
                {
                    Work2 = Work2 + "\\";
                }
            }

            // remove all double slashes
            int lc = (Work2.IndexOf("\\\\") + 1);

            while (lc > 0)
            {
                l = Work2.Substring(0, Math.Min(lc - 1, Work2.Length));
                r = Work2.Substring(lc);
                Work2 = l + r;
                lc = (Work2.IndexOf("\\\\") + 1);
            };

            // remove slashes off the end
            if (Work2.Substring(Math.Max(Work2.Length - 1, 0)) == "\\")
            {
                Work2 = Work2.Substring(0, Math.Min(Work2.Length - 1, Work2.Length));
            }

            // Put single spaces in front of all slashes
            int tempForEndVar2 = Work2.Length;
            for (int X = 1; X <= tempForEndVar2; X++)
            {
                xChar = Work2.Substring(X - 1, Math.Min(1, Work2.Length - (X - 1)));
                if (String.CompareOrdinal(xChar, "A") >= 0 && String.CompareOrdinal(xChar, "Z") <= 0 || String.CompareOrdinal(xChar, "0") >= 0 && String.CompareOrdinal(xChar, "9") <= 0 || xChar == "#" || xChar == "\"")
                {
                    result += xChar;
                }
                else if (xChar == "\\")
                {
                    result += " " + xChar;
                }
            }

            return result;
        }

        internal static string GetPhonemeName(int zIndex)
        {
            return gPhonemes[zIndex & 255];
        }

        internal static int GetSoundCode(string zName)
        {
            int result = 0;
            for (result = 0; result <= 400; result++)
            {
                if (gPhonemes[result] == zName.ToUpper())
                {
                    break;
                }
            }
            return result;
        }

        internal static void InitPhoneneNames()
        {
            gPhonemes[cvP0] = "\\P0";
            gPhonemes[cvP1] = "\\P1";
            gPhonemes[cvP2] = "\\P2";
            gPhonemes[cvP3] = "\\P3";
            gPhonemes[cvP4] = "\\P4";
            gPhonemes[cvP5] = "\\P5";
            gPhonemes[cvP6] = "\\P6";
            gPhonemes[cvFAST] = "\\FAST";
            gPhonemes[cvSLOW] = "\\SLOW";
            gPhonemes[cvSTRESS] = "\\STRESS";
            gPhonemes[cvRELAX] = "\\RELAX";
            gPhonemes[cvWAIT] = "\\WAIT";
            gPhonemes[cvSOFT] = "\\SOFT";
            gPhonemes[cvVOLUME] = "\\VOLUME";
            gPhonemes[cvSPEED] = "\\SPEED";
            gPhonemes[cvPITCH] = "\\PITCH";
            gPhonemes[cvBEND] = "\\BEND";
            gPhonemes[cvPCTRL] = "\\PCTRL";
            gPhonemes[cvPOUT] = "\\POUT";
            gPhonemes[cvREPEAT] = "\\REPEAT";
            gPhonemes[cvCALL] = "\\CALL";
            gPhonemes[cvPLAY] = "\\PLAY";
            gPhonemes[cvDELAY] = "\\DELAY";
            gPhonemes[cvRESET] = "\\RESET";

            gPhonemes[128] = "\\IY";
            gPhonemes[129] = "\\IH";
            gPhonemes[130] = "\\EY";
            gPhonemes[131] = "\\EH";
            gPhonemes[132] = "\\AY";
            gPhonemes[133] = "\\AX";
            gPhonemes[134] = "\\UX";
            gPhonemes[135] = "\\AW";
            gPhonemes[136] = "\\OH";
            gPhonemes[137] = "\\OW";
            gPhonemes[138] = "\\UH";
            gPhonemes[139] = "\\UW";
            gPhonemes[140] = "\\MM";
            gPhonemes[141] = "\\NE";
            gPhonemes[142] = "\\NO";
            gPhonemes[143] = "\\NGE";
            gPhonemes[144] = "\\NGO";
            gPhonemes[145] = "\\LE";
            gPhonemes[146] = "\\LO";
            gPhonemes[147] = "\\WW";
            gPhonemes[148] = "\\RR";

            gPhonemes[149] = "\\IYRR";
            gPhonemes[150] = "\\EYRR";
            gPhonemes[151] = "\\AXRR";
            gPhonemes[152] = "\\AWRR";
            gPhonemes[153] = "\\OWRR";
            gPhonemes[154] = "\\EYIY";
            gPhonemes[155] = "\\OHIY";
            gPhonemes[156] = "\\OWIY";
            gPhonemes[157] = "\\OHIH";
            gPhonemes[158] = "\\IYEH";
            gPhonemes[159] = "\\EHLE";
            gPhonemes[160] = "\\IYUW";
            gPhonemes[161] = "\\AXUW";
            gPhonemes[162] = "\\IHWW";
            gPhonemes[163] = "\\AYWW";
            gPhonemes[164] = "\\OWWW";

            gPhonemes[165] = "\\JH";
            gPhonemes[166] = "\\VV";
            gPhonemes[167] = "\\ZZ";
            gPhonemes[168] = "\\ZH";
            gPhonemes[169] = "\\DH";
            gPhonemes[170] = "\\BE";
            gPhonemes[171] = "\\BO";
            gPhonemes[172] = "\\EB";
            gPhonemes[173] = "\\OB";
            gPhonemes[174] = "\\DE";
            gPhonemes[175] = "\\DO";
            gPhonemes[176] = "\\ED";
            gPhonemes[177] = "\\OD";
            gPhonemes[178] = "\\GE";
            gPhonemes[179] = "\\GO";
            gPhonemes[180] = "\\EG";
            gPhonemes[181] = "\\OG";
            gPhonemes[182] = "\\CH";
            gPhonemes[183] = "\\HE";
            gPhonemes[184] = "\\HO";
            gPhonemes[185] = "\\WH";
            gPhonemes[186] = "\\FF";
            gPhonemes[187] = "\\SE";
            gPhonemes[188] = "\\SO";
            gPhonemes[189] = "\\SH";
            gPhonemes[190] = "\\TH";
            gPhonemes[191] = "\\TT";
            gPhonemes[192] = "\\TU";
            gPhonemes[193] = "\\TS";
            gPhonemes[194] = "\\KE";
            gPhonemes[195] = "\\KO";
            gPhonemes[196] = "\\EK";
            gPhonemes[197] = "\\OK";
            gPhonemes[198] = "\\PE";
            gPhonemes[199] = "\\PO";

            gPhonemes[200] = "\\R0";
            gPhonemes[201] = "\\R1";
            gPhonemes[202] = "\\R2";
            gPhonemes[203] = "\\R3";
            gPhonemes[204] = "\\R4";
            gPhonemes[205] = "\\R5";
            gPhonemes[206] = "\\R6";
            gPhonemes[207] = "\\R7";
            gPhonemes[208] = "\\R8";
            gPhonemes[209] = "\\R9";

            gPhonemes[210] = "\\A0";
            gPhonemes[211] = "\\A1";
            gPhonemes[212] = "\\A2";
            gPhonemes[213] = "\\A3";
            gPhonemes[214] = "\\A4";
            gPhonemes[215] = "\\A5";
            gPhonemes[216] = "\\A6";
            gPhonemes[217] = "\\A7";
            gPhonemes[218] = "\\A8";
            gPhonemes[219] = "\\A9";

            gPhonemes[220] = "\\B0";
            gPhonemes[221] = "\\B1";
            gPhonemes[222] = "\\B2";
            gPhonemes[223] = "\\B3";
            gPhonemes[224] = "\\B4";
            gPhonemes[225] = "\\B5";
            gPhonemes[226] = "\\B6";
            gPhonemes[227] = "\\B7";
            gPhonemes[228] = "\\B8";
            gPhonemes[229] = "\\B9";

            gPhonemes[230] = "\\C0";
            gPhonemes[231] = "\\C1";
            gPhonemes[232] = "\\C2";
            gPhonemes[233] = "\\C3";
            gPhonemes[234] = "\\C4";
            gPhonemes[235] = "\\C5";
            gPhonemes[236] = "\\C6";
            gPhonemes[237] = "\\C7";
            gPhonemes[238] = "\\C8";
            gPhonemes[239] = "\\C9";

            gPhonemes[240] = "\\D0";
            gPhonemes[241] = "\\D1";
            gPhonemes[242] = "\\D2";
            gPhonemes[243] = "\\D3";
            gPhonemes[244] = "\\D4";
            gPhonemes[245] = "\\D5";
            gPhonemes[246] = "\\D6";
            gPhonemes[247] = "\\D7";
            gPhonemes[248] = "\\D8";
            gPhonemes[249] = "\\D9";
            gPhonemes[250] = "\\D10";
            gPhonemes[251] = "\\D11";

            gPhonemes[252] = "\\M0";
            gPhonemes[253] = "\\M1";
            gPhonemes[254] = "\\M2";

            gPhonemes[301] = "\\NTC1";
            gPhonemes[302] = "\\NTC#1";
            gPhonemes[303] = "\\NTD1";
            gPhonemes[304] = "\\NTD#1";
            gPhonemes[305] = "\\NTE1";
            gPhonemes[306] = "\\NTF1";
            gPhonemes[307] = "\\NTF#1";
            gPhonemes[308] = "\\NTG1";
            gPhonemes[309] = "\\NTG#1";
            gPhonemes[310] = "\\NTA1";
            gPhonemes[311] = "\\NTA#1";
            gPhonemes[312] = "\\NTB1";

            gPhonemes[321] = "\\NTC2";
            gPhonemes[322] = "\\NTC#2";
            gPhonemes[323] = "\\NTD2";
            gPhonemes[324] = "\\NTD#2";
            gPhonemes[325] = "\\NTE2";
            gPhonemes[326] = "\\NTF2";
            gPhonemes[327] = "\\NTF#2";
            gPhonemes[328] = "\\NTG2";
            gPhonemes[329] = "\\NTG#2";
            gPhonemes[330] = "\\NTA2";
            gPhonemes[331] = "\\NTA#2";
            gPhonemes[332] = "\\NTB2";

            gPhonemes[341] = "\\NTC3";
            gPhonemes[342] = "\\NTC#3";
            gPhonemes[343] = "\\NTD3";
            gPhonemes[344] = "\\NTD#3";
            gPhonemes[345] = "\\NTE3";
            gPhonemes[346] = "\\NTF3";
            gPhonemes[347] = "\\NTF#3";
            gPhonemes[348] = "\\NTG3";
            gPhonemes[349] = "\\NTG#3";
            gPhonemes[350] = "\\NTA3";
            gPhonemes[351] = "\\NTA#3";
            gPhonemes[352] = "\\NTB3";
        }

        internal static string GetSpeakJetCodes(string zAllophoneList)
        {
            string result = "";
            int LocationOfSlash = 0;
            string SoundToken = "";
            int SoundCode = 0;
            int value = 0;

            string SoundTokenList = FormatAllophoneList(zAllophoneList).Trim();

            while (SoundTokenList != "")
            {
                LocationOfSlash = (SoundTokenList + "\\").IndexOf("\\", 2) + 1;
                if (LocationOfSlash > 0)
                {
                    SoundToken = SoundTokenList.Substring(0, Math.Min(LocationOfSlash - 1, SoundTokenList.Length)).Trim().ToUpper();
                    SoundTokenList = SoundTokenList.Substring(LocationOfSlash - 1).Trim();
                    if (SoundToken == "\\0")
                    {
                        result += Strings.Chr(0);
                    }
                    else if (Int32.TryParse(SoundToken.Substring(1), out value))
                    {
                        result += Strings.Chr(value);
                    }
                    else
                    {
                        SoundCode = GetSoundCode(SoundToken);
                        if (SoundCode < 128)
                        {
                            result += Strings.Chr(SoundCode);
                        }
                        else if (SoundCode < 256)
                        {
                            result += Strings.Chr(SoundCode);
                        }
                        else if (SoundCode > 400)
                        {
                            // not an allophone
                        }
                        else
                        {
                            result += Strings.Chr(cvPITCH) + Strings.Chr(GetNoteFreq(SoundCode));
                        }
                    }
                }
            };

            return result;
        }

        internal static string dhex(byte v)
        {
            return ("00" + v.ToString("X")).Substring(Math.Max(("00" + v.ToString("X")).Length - 2, 0));
        }

        internal static byte GetNoteFreq(int zSoundCode)
        {
            switch (zSoundCode)
            {
                case 301:
                    return 33;
                case 302:
                    return 35;
                case 303:
                    return 37;
                case 304:
                    return 39;
                case 305:
                    return 41;
                case 306:
                    return 44;
                case 307:
                    return 46;
                case 308:
                    return 49;
                case 309:
                    return 52;
                case 310:
                    return 55;
                case 311:
                    return 58;
                case 312:
                    return 62;
                case 321:
                    return 65;
                case 322:
                    return 69;
                case 323:
                    return 73;
                case 324:
                    return 78;
                case 325:
                    return 82;
                case 326:
                    return 87;
                case 327:
                    return 93;
                case 328:
                    return 98;
                case 329:
                    return 104;
                case 330:
                    return 110;
                case 331:
                    return 117;
                case 332:
                    return 123;
                case 341:
                    return 131;
                case 342:
                    return 139;
                case 343:
                    return 147;
                case 344:
                    return 156;
                case 345:
                    return 165;
                case 346:
                    return 175;
                case 347:
                    return 185;
                case 348:
                    return 196;
                case 349:
                    return 208;
                case 350:
                    return 220;
                case 351:
                    return 233;
                case 352:
                    return 247;
            }

            return 0;
        }

        internal static void QuickSortVariants(string[] vArray, int inLow, int inHi)
        {

            string tmpSwap = "";

            int tmpLow = inLow;
            int tmpHi = inHi;

            string pivot = vArray[(inLow + inHi) / 2];

            while ((tmpLow <= tmpHi))
            {

                while ((String.CompareOrdinal(vArray[tmpLow], pivot) < 0 && tmpLow < inHi))
                {
                    tmpLow++;
                }

                while ((String.CompareOrdinal(pivot, vArray[tmpHi]) < 0 && tmpHi > inLow))
                {
                    tmpHi--;
                }

                if (tmpLow <= tmpHi)
                {
                    tmpSwap = vArray[tmpLow];
                    vArray[tmpLow] = vArray[tmpHi];
                    vArray[tmpHi] = tmpSwap;
                    tmpLow++;
                    tmpHi--;
                }

            }

            if ((inLow < tmpHi))
            {
                QuickSortVariants(vArray, inLow, tmpHi);
            }
            if ((tmpLow < inHi))
            {
                QuickSortVariants(vArray, tmpLow, inHi);
            }
        }

        internal static string ExtractAllophoneListFromSayData(string zSayData)
        {
            string WordToLookUp = "";
            int SpacesToDo = 0;
            int CommasToDo = 0;
            char xChar;
            StringBuilder AlloPhoneList = new StringBuilder();
            WordTypes WordType = WordTypes.wtNone;
            WordTypes OldWordType = WordTypes.wtNone;

            string SayDataWork = zSayData + " ";
            for (int X = 0; X < SayDataWork.Length; X++)
            {
                xChar = SayDataWork[X];
                if ((xChar >= 'A' && xChar <= 'Z') || (xChar >= 'a' && xChar <= 'z') || (xChar >= '0' && xChar <= '9') || (xChar == '\\'))
                {
                    WordType = WordTypes.wtText;
                    WordToLookUp = WordToLookUp + xChar;
                }
                else if (xChar == ' ')
                {
                    WordType = WordTypes.wtSpaces;
                    SpacesToDo++;
                }
                else if (xChar == ',')
                {
                    WordType = WordTypes.wtCommas;
                    CommasToDo++;
                }
                if (WordType != OldWordType)
                {
                    switch (OldWordType)
                    {
                        case WordTypes.wtText:
                            if (WordToLookUp.StartsWith("\\"))
                            {
                                AlloPhoneList.Append(WordToLookUp);
                            }
                            else
                            {
                                AlloPhoneList.Append(ExtractAllophoneListFromSayData(ReadDict("Words", WordToLookUp, "")));
                            }
                            WordToLookUp = "";
                            break;
                        case WordTypes.wtCommas:
                            int tempForEndVar2 = CommasToDo;
                            for (int xCounter = 0; xCounter < tempForEndVar2; xCounter++)
                            {
                                AlloPhoneList.Append(" \\P2");
                                if (WordType == WordTypes.wtCommas)
                                {
                                    WordType = WordTypes.wtNone;
                                }
                            }
                            CommasToDo = 0;
                            break;
                        case WordTypes.wtSpaces:
                            switch (SpacesToDo)
                            {
                                case 1:  // Add nothing 
                                    break;
                                case 2:
                                    AlloPhoneList.Append(" \\P6");
                                    break;
                                default:
                                    AlloPhoneList.Append(" \\P4 \\P1");
                                    break;
                            }
                            SpacesToDo = 0;
                            break;
                    }
                    OldWordType = WordType;
                }
            }

            return AlloPhoneList.ToString();

        }

        internal static string FormatSayData(string zSayData)
        {
            return zSayData;
        }
    }
}