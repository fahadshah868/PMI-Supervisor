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
    ///The TPOSM recording.
    /// </summary>
    [TestModule("0dfa3d5d-811a-4c21-8716-5d4264db4c50", ModuleType.Recording, 1)]
    public partial class TPOSM : ITestModule
    {
        /// <summary>
        /// Holds an instance of the PMISupervisor.PMISupervisorRepository repository.
        /// </summary>
        public static PMISupervisor.PMISupervisorRepository repo = PMISupervisor.PMISupervisorRepository.Instance;

        static TPOSM instance = new TPOSM();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public TPOSM()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static TPOSM Instance
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='TPOSM') on item 'PMI_Supervisor.Validate_TPOSMScreen'.", repo.PMI_Supervisor.Validate_TPOSMScreenInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.PMI_Supervisor.Validate_TPOSMScreenInfo, "Text", "TPOSM");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PMI_Supervisor.TPOSM_No' at Center", repo.PMI_Supervisor.TPOSM_NoInfo, new RecordItemIndex(1));
            repo.PMI_Supervisor.TPOSM_No.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key '{BACK}' press on 'PMI_Supervisor'.", repo.PMI_Supervisor.SelfInfo, new RecordItemIndex(2));
            repo.PMI_Supervisor.Self.PressKeys("{BACK}");
            Delay.Milliseconds(1000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='TPOSM') on item 'PMI_Supervisor.Validate_TPOSMDeploymentScreen'.", repo.PMI_Supervisor.Validate_TPOSMDeploymentScreenInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.PMI_Supervisor.Validate_TPOSMDeploymentScreenInfo, "Text", "TPOSM");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
