﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

//namespace Doorstop
//{
//    public static class Loader
//    {
//        public static void Main(string[] args)
//        {
//            using (TextWriter textWriter = File.CreateText("UKMM_IS_ALIVE.txt"))
//            {
//                textWriter.WriteLine(string.Format("Beginning assembly injection...", DateTime.Now));
//                textWriter.Flush();
//                //Assembly assembly = Assembly.Load(File.ReadAllBytes(Directory.GetCurrentDirectory() + "\\ULTRAKILL_Data\\Managed\\Assembly-CSharp.dll"));
//                //Assembly modded = Assembly.Load(File.ReadAllBytes(Directory.GetCurrentDirectory() + "\\ULTRAKILL_Data\\UKMM\\UKMM.dll"));
//                //modded.GetType("UKModManager").GetMethod("UKModManager").Invoke(null, null);
//                textWriter.WriteLine(string.Format("End assembly injection", DateTime.Now));
//                textWriter.Flush();
//            }
//        }
//    }
//}

public static class Loader
{
	public static void Main(string[] args)
	{
		using (TextWriter textWriter = File.CreateText("doorstop_is_alive.txt"))
		{
			textWriter.WriteLine(string.Format("Hello! This text file was generated by Doorstop on {0:R}!", DateTime.Now));
			textWriter.WriteLine("Command line: " + Environment.CommandLine);
			textWriter.WriteLine();
			textWriter.WriteLine("Doorstop also set the following environment variables:");
			textWriter.WriteLine("DOORSTOP_INVOKE_PATH = " + Environment.GetEnvironmentVariable("DOORSTOP_INVOKE_DLL_PATH"));
			textWriter.WriteLine("DOORSTOP_MANAGED_FOLDER_DIR = " + Environment.GetEnvironmentVariable("DOORSTOP_MANAGED_FOLDER_DIR"));
			textWriter.WriteLine("DOORSTOP_PROCESS_PATH = " + Environment.GetEnvironmentVariable("DOORSTOP_PROCESS_PATH"));
			textWriter.WriteLine("Replace this DLL with a custom-made one to do whatever you want!");
			textWriter.Flush();
		}
	}
}