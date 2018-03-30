/*
 * Created by Ranorex
 * User: Fahad Shah
 * Date: 3/7/2018
 * Time: 6:58 PM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace PMISupervisor.UserCodeCollection
{
    /// <summary>
    /// Ranorex user code collection. A collection is used to publish user code methods to the user code library.
    /// </summary>
    [UserCodeCollection]
    public class UserCodeCollection1
    {
    	
    	/// <summary>
    	/// This is a placeholder text. Please describe the purpose of the
    	/// user code method here. The method is published to the user code library
    	/// within a user code collection.
    	/// </summary>
    	[UserCodeMethod]
    	public static void readtextfromfile()
	    {
	    	try
	    	{
	    		string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Fahad Shah\Desktop\Sample.txt");
	    		foreach(string line in lines){
	    			System.Diagnostics.Debug.WriteLine(line);
	    		}
	        }
	    	catch{
	    		
	    	}
	    }
    }
}
