// Copyright (c) 2014 Takashi Yoshizawa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using Excel = Microsoft.Office.Interop.Excel;

namespace SeleniumExcelAddIn.TestCommands
{
    public class MetaKeyUpAndWaitCommand : ITestCommand
    {
        public TestCommandSyntax Syntax
        {
            get
            {
                return TestCommandSyntax.None;
            }
        }

        public bool IsScreenCapture
        {
            get
            {
                return false;
            }
        }

        
        public string Description
        {
            get
            {
                return TestCommandResource.x_MetaKeyUpAndWait;
            }
        }

        public string TargetDescription
        {
            get
            {
                return TestCommandResource.x_MetaKeyUpAndWait_Target;
            }
        }

        public string ValueDescription
        {
            get
            {
                return TestCommandResource.x_MetaKeyUpAndWait_Value;
            }
        }

        public void Execute(ITestContext context)

        {
            if (null == context)
            {
                throw new ArgumentNullException("context");
            }

            ExecuteInternal(context);
        }

        public static void ExecuteInternal(ITestContext context)
        {
            if (null == context)
            {
                throw new ArgumentNullException("context");
            }

            MetaKeyUpCommand.ExecuteInternal(context);
            TestCommandHelper.AndWait();
        }
    }
}
