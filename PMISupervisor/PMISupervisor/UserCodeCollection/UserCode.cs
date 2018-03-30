/*
 * Created by Ranorex
 * User: Fahad Shah
 * Date: 3/6/2018
 * Time: 3:41 PM
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
using System.Linq;

namespace PMISupervisor.UserCode
{
    /// <summary>
    /// Ranorex user code collection. A collection is used to publish user code methods to the user code library.
    /// </summary>
    [UserCodeCollection]
    public class UserCode
    {
    	public static PMISupervisorRepository repo = PMISupervisorRepository.Instance;
    	
    	/// <summary>
    	/// This is a placeholder text. Please describe the purpose of the
    	/// user code method here. The method is published to the user code library
    	/// within a user code collection.
    	/// </summary>
    	[UserCodeMethod]
    	public static void markMerchandiserAttendance()
    	{
    		var merchandiserlist = repo.PMI_Supervisor.Merchandisers_AttendanceList.Children.ToList();
    		for(int i=0; i<merchandiserlist.Count; i++){
    			merchandiserlist[i].Touch();
    			Delay.Seconds(1);
    			merchandiserlist = repo.PMI_Supervisor.Merchandisers_AttendanceList.Children.ToList();
    			for(int j=i+1; j<i+6; j++){
    				var attendancelist = merchandiserlist[j].Children.ToList();
    				attendancelist[1].Touch();
    				Delay.Seconds(1);
    			}
    			merchandiserlist[i].Touch();
    			Delay.Seconds(1);
    			merchandiserlist = repo.PMI_Supervisor.Merchandisers_AttendanceList.Children.ToList();
    		}
    	}
    	/// <summary>
    	/// This is a placeholder text. Please describe the purpose of the
    	/// user code method here. The method is published to the user code library
    	/// within a user code collection.
    	/// </summary>
    	[UserCodeMethod]
    	public static void selectMerchandiser()
    	{
    		var merchandiserlist = repo.PMI_Supervisor.Merchandisers_List.Children.ToList();
    		merchandiserlist[0].Touch();
    		Delay.Seconds(1);
    	}
    	/// <summary>
    	/// This is a placeholder text. Please describe the purpose of the
    	/// user code method here. The method is published to the user code library
    	/// within a user code collection.
    	/// </summary>
    	[UserCodeMethod]
    	public static void selectRouteDay()
    	{
    		var day = repo.PMI_Supervisor.Route_List.Children.ToList();
    		day[0].Touch();
    		Delay.Seconds(1);
    	}
    	/// <summary>
    	/// This is a placeholder text. Please describe the purpose of the
    	/// user code method here. The method is published to the user code library
    	/// within a user code collection.
    	/// </summary>
    	[UserCodeMethod]
    	public static void chooseNonTKShopFromList()
    	{
    		string lastitembeforeswipe = "";
    		string lastitemafterswipe = "";
    		bool flag = false;
    		var shopslist = repo.PMI_Supervisor.Shops_List.Children.ToList();
	    	foreach(var shop in shopslist){
        		var shopname = shop.Children.ToList();
        		string shoptype = Convert.ToString(shopname[1]);
        		if(shoptype.Contains("Non-TK")){
        			shop.Touch();
        			PMISupervisor.TestCases.VisitNonTKShopOpenOnce.ShopOpen.Start();
        			flag = true;
        			break;
        		}
        	}
    		if(flag != true){
    			try{
    				while(true){
			    		var lastitemcontainerbeforeswipe = repo.PMI_Supervisor.Shops_List.Children.Last();
				    	var containeritemsbeforeswipe = lastitemcontainerbeforeswipe.Children.ToList();
				    	lastitembeforeswipe = Convert.ToString(containeritemsbeforeswipe[1]);
				    	repo.PMI_Supervisor.Shops_List.Swipe(Location.Center, ValueConverter.ArgumentFromString<Ranorex.Core.Recorder.Touch.GestureDirection>("SwipeDirection", "Up (270°)"), ValueConverter.ArgumentFromString<Ranorex.Core.Distance>("Distance", ".147"), ValueConverter.ArgumentFromString<Ranorex.Duration>("SwipeDuration", "500ms"), 0);
		    			Delay.Milliseconds(2000);
			            var lastitemcontainerafterswipe = repo.PMI_Supervisor.Shops_List.Children.Last();
			            var containeritemsafterswipe = lastitemcontainerafterswipe.Children.ToList();
			            lastitemafterswipe = Convert.ToString(containeritemsafterswipe[1]);
			            if(lastitembeforeswipe == lastitemafterswipe){
			            	break;
			            }
			            else{
			            	if(lastitemafterswipe.Contains("Non-TK")){
				           		lastitemcontainerafterswipe.Touch();
				           		PMISupervisor.TestCases.VisitNonTKShopOpenOnce.ShopOpen.Start();
				            	break;
				           	}
			    		}
	            	}
    			}
    			catch{
    			}
    		}
    	}
    	/// <summary>
    	/// This is a placeholder text. Please describe the purpose of the
    	/// user code method here. The method is published to the user code library
    	/// within a user code collection.
    	/// </summary>
    	[UserCodeMethod]
    	public static void overwriteNonTKShopFromList()
    	{
    		string lastitembeforeswipe = "";
    		string lastitemafterswipe = "";
    		bool flag = false;
    		var shopslist = repo.PMI_Supervisor.Shops_List.Children.ToList();
	    	foreach(var shop in shopslist){
        		var shopname = shop.Children.ToList();
        		string shoptype = Convert.ToString(shopname[1]);
        		if(shoptype.Contains("Non-TK")){
        			shop.Touch();
        			PMISupervisor.TestCases.OverWriteNonTKShop.ShopOpen.Start();
        			flag = true;
        			break;
        		}
        	}
    		if(flag != true){
    			try{
    				while(true){
			    		var lastitemcontainerbeforeswipe = repo.PMI_Supervisor.Shops_List.Children.Last();
				    	var containeritemsbeforeswipe = lastitemcontainerbeforeswipe.Children.ToList();
				    	lastitembeforeswipe = Convert.ToString(containeritemsbeforeswipe[1]);
				    	repo.PMI_Supervisor.Shops_List.Swipe(Location.Center, ValueConverter.ArgumentFromString<Ranorex.Core.Recorder.Touch.GestureDirection>("SwipeDirection", "Up (270°)"), ValueConverter.ArgumentFromString<Ranorex.Core.Distance>("Distance", ".147"), ValueConverter.ArgumentFromString<Ranorex.Duration>("SwipeDuration", "500ms"), 0);
		    			Delay.Milliseconds(2000);
			            var lastitemcontainerafterswipe = repo.PMI_Supervisor.Shops_List.Children.Last();
			            var containeritemsafterswipe = lastitemcontainerafterswipe.Children.ToList();
			            lastitemafterswipe = Convert.ToString(containeritemsafterswipe[1]);
			            if(lastitembeforeswipe == lastitemafterswipe){
			            	break;
			            }
			            else{
			            	if(lastitemafterswipe.Contains("Non-TK")){
				           		lastitemcontainerafterswipe.Touch();
				           		PMISupervisor.TestCases.OverWriteNonTKShop.ShopOpen.Start();
				            	break;
				           	}
			    		}
	            	}
    			}
    			catch{
    			}
    		}
    	}
    	/// <summary>
    	/// This is a placeholder text. Please describe the purpose of the
    	/// user code method here. The method is published to the user code library
    	/// within a user code collection.
    	/// </summary>
    	[UserCodeMethod]
    	public static void takePhoto()
    	{
    		repo.PMI_Supervisor.TakePhoto.Touch();
    		Delay.Seconds(5);
    	}
    	/// <summary>
    	/// This is a placeholder text. Please describe the purpose of the
    	/// user code method here. The method is published to the user code library
    	/// within a user code collection.
    	/// </summary>
    	[UserCodeMethod]
    	public static void visitNonTKAllTPOSM()
    	{
    		string tposmtext = "";
    		string lastitemtextbeforeswipe = "";
    		string lastitemtextafterswipe = "";
    		var tposmlist = repo.PMI_Supervisor.TPOSM_List.Children.ToList();
    		for(int i=0; i<tposmlist.Count; i++){
    			var tposm = tposmlist[i].Children.ToList();
    			tposmtext = Convert.ToString(tposm[1]);
    			tposm[1].Touch();
    			Delay.Milliseconds(1000);
    			if(tposmtext.Contains("Key Message Communication") || tposmtext.Contains("Trade Letter") || tposmtext.Contains("Dummy Pack")){
    				PMISupervisor.TestCases.VisitNonTKShopOpenOnce.TPOSM1.Start();
    			}
    			else{
    				PMISupervisor.TestCases.VisitNonTKShopOpenOnce.TPOSM2.Start();
    			}
    		}
    		try{
    			while(true){
    				var lastitemcontainerbeforeswipe = repo.PMI_Supervisor.TPOSM_List.Children.Last();
    				var lastitembeforeswipe = lastitemcontainerbeforeswipe.Children.ToList();
    				lastitemtextbeforeswipe = Convert.ToString(lastitembeforeswipe[1]);
    				repo.PMI_Supervisor.TPOSM_List.Swipe(Location.Center, ValueConverter.ArgumentFromString<Ranorex.Core.Recorder.Touch.GestureDirection>("SwipeDirection", "Up (270°)"), ValueConverter.ArgumentFromString<Ranorex.Core.Distance>("Distance", ".147"), ValueConverter.ArgumentFromString<Ranorex.Duration>("SwipeDuration", "500ms"), 0);
	    			Delay.Milliseconds(2000);
		            var lastitemcontainerafterswipe = repo.PMI_Supervisor.TPOSM_List.Children.Last();
		            var lastitemafterswipe = lastitemcontainerafterswipe.Children.ToList();
    				lastitemtextafterswipe = Convert.ToString(lastitemafterswipe[1]);
    				if(lastitemtextafterswipe.Equals(lastitemtextbeforeswipe)){
		            	break;
		            }
		            else{
    					lastitemafterswipe[1].Touch();
    					Delay.Milliseconds(1000);
    		 			if(lastitemtextafterswipe.Contains("Key Message Communication") || lastitemtextafterswipe.Contains("Trade Letter") || lastitemtextafterswipe.Contains("Dummy Pack"))
    		 			{
    						PMISupervisor.TestCases.VisitNonTKShopOpenOnce.TPOSM1.Start();
		    			}
		    			else
		    			{
    						PMISupervisor.TestCases.VisitNonTKShopOpenOnce.TPOSM2.Start();
		    			}
		    		}
	    		}
    		}
    		catch{
    		}
    	}
    	/// <summary>
    	/// This is a placeholder text. Please describe the purpose of the
    	/// user code method here. The method is published to the user code library
    	/// within a user code collection.
    	/// </summary>
    	[UserCodeMethod]
    	public static void overwriteNonTKAllTPOSM()
    	{
    		string lastitemtextbeforeswipe = "";
    		string lastitemtextafterswipe = "";
    		var tposmlist = repo.PMI_Supervisor.TPOSM_List.Children.ToList();
    		for(int i=0; i<tposmlist.Count; i++){
    			var tposm = tposmlist[i].Children.ToList();
    			tposm[1].Touch();
    			Delay.Milliseconds(1000);
    			PMISupervisor.TestCases.OverWriteNonTKShop.TPOSM.Start();
    		}
    		try{
    			while(true){
    				var lastitemcontainerbeforeswipe = repo.PMI_Supervisor.TPOSM_List.Children.Last();
    				var lastitembeforeswipe = lastitemcontainerbeforeswipe.Children.ToList();
    				lastitemtextbeforeswipe = Convert.ToString(lastitembeforeswipe[1]);
    				repo.PMI_Supervisor.TPOSM_List.Swipe(Location.Center, ValueConverter.ArgumentFromString<Ranorex.Core.Recorder.Touch.GestureDirection>("SwipeDirection", "Up (270°)"), ValueConverter.ArgumentFromString<Ranorex.Core.Distance>("Distance", ".147"), ValueConverter.ArgumentFromString<Ranorex.Duration>("SwipeDuration", "500ms"), 0);
	    			Delay.Milliseconds(2000);
		            var lastitemcontainerafterswipe = repo.PMI_Supervisor.TPOSM_List.Children.Last();
		            var lastitemafterswipe = lastitemcontainerafterswipe.Children.ToList();
    				lastitemtextafterswipe = Convert.ToString(lastitemafterswipe[1]);
    				if(lastitemtextafterswipe.Equals(lastitemtextbeforeswipe)){
		            	break;
		            }
		            else{
    					lastitemafterswipe[1].Touch();
    					Delay.Milliseconds(1000);
    					PMISupervisor.TestCases.OverWriteNonTKShop.TPOSM.Start();
		    		}
	    		}
    		}
    		catch{
    		}
    	}
   		/// <summary>
   		/// This is a placeholder text. Please describe the purpose of the
   		/// user code method here. The method is published to the user code library
   		/// within a user code collection.
   		/// </summary>
    	[UserCodeMethod]
    	public static void visitNonTKAvailabilityCheck()
   		{
    		var listcontainer = repo.PMI_Supervisor.AvailabilityCheck_List.Children.ToList();
    		for(int i=1; i<listcontainer.Count; i=i+3){
    			listcontainer = repo.PMI_Supervisor.AvailabilityCheck_List.Children.ToList();
    			var availabilitychecklist = listcontainer[i];
	    		var availabilitychecklistcontainer = availabilitychecklist.Children.ToList();
	    		var availabilitycheckitems = availabilitychecklistcontainer[0];
	    		var availabilitycheckitem = availabilitycheckitems.Children.ToList();
	    		repo.PMI_Supervisor.Self.PressKeys("{BACK}");
	    		Delay.Seconds(1);
	    		repo.PMI_Supervisor.Validation_OKButton.Touch();
	    		Delay.Seconds(1);
	    		availabilitycheckitem[0].Touch();
	    		Delay.Seconds(1);
    		}
    	}
    	/// <summary>
   		/// This is a placeholder text. Please describe the purpose of the
   		/// user code method here. The method is published to the user code library
   		/// within a user code collection.
   		/// </summary>
    	[UserCodeMethod]
    	public static void overwriteNonTKAvailabilityCheck()
   		{
    		var listcontainer = repo.PMI_Supervisor.AvailabilityCheck_List.Children.ToList();
    		for(int i=1; i<listcontainer.Count; i=i+3){
    			listcontainer = repo.PMI_Supervisor.AvailabilityCheck_List.Children.ToList();
    			var availabilitychecklist = listcontainer[i];
	    		var availabilitychecklistcontainer = availabilitychecklist.Children.ToList();
	    		var availabilitycheckitems = availabilitychecklistcontainer[0];
	    		var availabilitycheckitem = availabilitycheckitems.Children.ToList();
	    		repo.PMI_Supervisor.Self.PressKeys("{BACK}");
	    		Delay.Seconds(1);
	    		repo.PMI_Supervisor.Validation_OKButton.Touch();
	    		Delay.Seconds(1);
	    		availabilitycheckitem[1].Touch();
	    		Delay.Seconds(1);
    		}
    	}
    	/// <summary>
    	/// This is a placeholder text. Please describe the purpose of the
    	/// user code method here. The method is published to the user code library
    	/// within a user code collection.
    	/// </summary>
    	[UserCodeMethod]
    	public static void loadNonTKAvailabilityCheck()
    	{
    		PMISupervisor.TestCases.VisitNonTKShopOpenOnce.AvailabilityCheck.Start();
    	}	
    	/// <summary>
    	/// This is a placeholder text. Please describe the purpose of the
    	/// user code method here. The method is published to the user code library
    	/// within a user code collection.
    	/// </summary>
    	[UserCodeMethod]
    	public static void loadNonTKAvailabilityCheckForOverWriting()
    	{
    		PMISupervisor.TestCases.OverWriteNonTKShop.AvailabilityCheck.Start();
    	}
    	/// <summary>
    	/// This is a placeholder text. Please describe the purpose of the
    	/// user code method here. The method is published to the user code library
    	/// within a user code collection.
    	/// </summary>
    	[UserCodeMethod]
    	public static void loadNonTKTPOSM()
    	{
    		PMISupervisor.TestCases.VisitNonTKShopOpenOnce.TPOSMApplication.Start();
    	}
    	/// <summary>
    	/// This is a placeholder text. Please describe the purpose of the
    	/// user code method here. The method is published to the user code library
    	/// within a user code collection.
    	/// </summary>
    	[UserCodeMethod]
    	public static void loadNonTKTPOSMForOverWriting()
    	{
    		PMISupervisor.TestCases.OverWriteNonTKShop.TPOSMApplication.Start();
    	}
    	/// <summary>
    	/// This is a placeholder text. Please describe the purpose of the
    	/// user code method here. The method is published to the user code library
    	/// within a user code collection.
    	/// </summary>
    	[UserCodeMethod]
    	public static void countNonTKShopModules()
    	{
    		int nontkshopmodulescount = repo.PMI_Supervisor.NonTKModules_List.Children.Count;
    		if((nontkshopmodulescount-1) == 3){
    			PMISupervisor.TestCases.VisitNonTKShopOpenOnce.BWUMaintenance.Start();
    		}
    	}
    	/// <summary>
    	/// This is a placeholder text. Please describe the purpose of the
    	/// user code method here. The method is published to the user code library
    	/// within a user code collection.
    	/// </summary>
    	[UserCodeMethod]
    	public static void validateTradeTracker()
    	{
    		Validate.AttributeEqual(repo.PMI_Supervisor.Validate_TradeTrackerScreenInfo, "Text", "Trade Tracker");
    		Delay.Seconds(12);
    	}
    }
}
