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

namespace PMISupervisor.TestCases.VisitNonTKShopOpenOnce
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ChooseNonTKShop recording.
    /// </summary>
    [TestModule("a94e8e78-c867-4757-ae0a-3cad4e58ac5a", ModuleType.Recording, 1)]
    public partial class ChooseNonTKShop : ITestModule
    {
        /// <summary>
        /// Holds an instance of the PMISupervisor.PMISupervisorRepository repository.
        /// </summary>
        public static PMISupervisor.PMISupervisorRepository repo = PMISupervisor.PMISupervisorRepository.Instance;

        static ChooseNonTKShop instance = new ChooseNonTKShop();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ChooseNonTKShop()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ChooseNonTKShop Instance
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Shops List') on item 'PMI_Supervisor.Validate_ShopsListScreen'.", repo.PMI_Supervisor.Validate_ShopsListScreenInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.PMI_Supervisor.Validate_ShopsListScreenInfo, "Text", "Shops List");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key '{BACK}' press on 'PMI_Supervisor'.", repo.PMI_Supervisor.SelfInfo, new RecordItemIndex(1));
            repo.PMI_Supervisor.Self.PressKeys("{BACK}");
            Delay.Milliseconds(1000);
            
            UserCode.UserCode.chooseNonTKShopFromList();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
