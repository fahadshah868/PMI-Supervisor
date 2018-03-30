﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

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
using Ranorex.Core.Repository;

namespace PMISupervisor.TestCases.OverWriteNonTKShop
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The AvailabilityCheck recording.
    /// </summary>
    [TestModule("ae271e60-2534-4140-b245-c95b0638f24d", ModuleType.Recording, 1)]
    public partial class AvailabilityCheck : ITestModule
    {
        /// <summary>
        /// Holds an instance of the PMISupervisor.PMISupervisorRepository repository.
        /// </summary>
        public static PMISupervisor.PMISupervisorRepository repo = PMISupervisor.PMISupervisorRepository.Instance;

        static AvailabilityCheck instance = new AvailabilityCheck();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AvailabilityCheck()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AvailabilityCheck Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.0")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.0")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Non-TK') on item 'PMI_Supervisor.Validate_NonTKShopScreen'.", repo.PMI_Supervisor.Validate_NonTKShopScreenInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.PMI_Supervisor.Validate_NonTKShopScreenInfo, "Text", "Non-TK");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PMI_Supervisor.AvailabilityCheck' at Center", repo.PMI_Supervisor.AvailabilityCheckInfo, new RecordItemIndex(1));
            repo.PMI_Supervisor.AvailabilityCheck.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='AVAILABILITY CHECK') on item 'PMI_Supervisor.Validate_AVAILABILITYCHECKScreen'.", repo.PMI_Supervisor.Validate_AVAILABILITYCHECKScreenInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.PMI_Supervisor.Validate_AVAILABILITYCHECKScreenInfo, "Text", "AVAILABILITY CHECK");
            Delay.Milliseconds(0);
            
            UserCode.UserCode.overwriteNonTKAvailabilityCheck();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key '{BACK}' press on 'PMI_Supervisor'.", repo.PMI_Supervisor.SelfInfo, new RecordItemIndex(4));
            repo.PMI_Supervisor.Self.PressKeys("{BACK}");
            Delay.Milliseconds(1000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Non-TK') on item 'PMI_Supervisor.Validate_NonTKShopScreen'.", repo.PMI_Supervisor.Validate_NonTKShopScreenInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.PMI_Supervisor.Validate_NonTKShopScreenInfo, "Text", "Non-TK");
            Delay.Milliseconds(0);
            
            UserCode.UserCode.countNonTKShopModules();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key '{BACK}' press on 'PMI_Supervisor'.", repo.PMI_Supervisor.SelfInfo, new RecordItemIndex(7));
            repo.PMI_Supervisor.Self.PressKeys("{BACK}");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'PMI_Supervisor.Validate_InfoPopUp'.", repo.PMI_Supervisor.Validate_InfoPopUpInfo, new RecordItemIndex(8));
            Validate.Exists(repo.PMI_Supervisor.Validate_InfoPopUpInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PMI_Supervisor.YesButton' at Center", repo.PMI_Supervisor.YesButtonInfo, new RecordItemIndex(9));
            repo.PMI_Supervisor.YesButton.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Shops List') on item 'PMI_Supervisor.Validate_ShopsListScreen'.", repo.PMI_Supervisor.Validate_ShopsListScreenInfo, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.PMI_Supervisor.Validate_ShopsListScreenInfo, "Text", "Shops List");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key '{BACK}' press on 'PMI_Supervisor'.", repo.PMI_Supervisor.SelfInfo, new RecordItemIndex(11));
            repo.PMI_Supervisor.Self.PressKeys("{BACK}");
            Delay.Milliseconds(1000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='ROUTE LIST') on item 'PMI_Supervisor.Validate_ROUTELISTScreen'.", repo.PMI_Supervisor.Validate_ROUTELISTScreenInfo, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.PMI_Supervisor.Validate_ROUTELISTScreenInfo, "Text", "ROUTE LIST");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key '{BACK}' press on 'PMI_Supervisor'.", repo.PMI_Supervisor.SelfInfo, new RecordItemIndex(13));
            repo.PMI_Supervisor.Self.PressKeys("{BACK}");
            Delay.Milliseconds(1000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='MERCHANDISERS LIST') on item 'PMI_Supervisor.Validate_MERCHANDISERSLISTScreen'.", repo.PMI_Supervisor.Validate_MERCHANDISERSLISTScreenInfo, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.PMI_Supervisor.Validate_MERCHANDISERSLISTScreenInfo, "Text", "MERCHANDISERS LIST");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key '{BACK}' press on 'PMI_Supervisor'.", repo.PMI_Supervisor.SelfInfo, new RecordItemIndex(15));
            repo.PMI_Supervisor.Self.PressKeys("{BACK}");
            Delay.Milliseconds(1000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='WELCOME') on item 'PMI_Supervisor.Validate_AppStartingScreen'.", repo.PMI_Supervisor.Validate_AppStartingScreenInfo, new RecordItemIndex(16));
            Validate.AttributeEqual(repo.PMI_Supervisor.Validate_AppStartingScreenInfo, "Text", "WELCOME");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
