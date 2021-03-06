// Copyright (c) 2014 Takashi Yoshizawa

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using OpenQA.Selenium.Support.UI;

namespace SeleniumExcelAddIn.TestCommands
{
    public class AssertSelectOptionsCommand : ITestCommand
    {
        public TestCommandSyntax Syntax
        {
            get
            {
                return TestCommandSyntax.Both;
            }
        }

        public bool IsScreenCapture
        {
            get
            {
                return true;
            }
        }

        
        public string Description
        {
            get
            {
                return TestCommandResource.AssertSelectOptions;
            }
        }

        public string TargetDescription
        {
            get
            {
                return TestCommandResource.AssertSelectOptions_Target;
            }
        }

        public string ValueDescription
        {
            get
            {
                return TestCommandResource.AssertSelectOptions_Value;
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

            var actualList = GetActual(context);

            if (string.IsNullOrWhiteSpace(context.Value) && 0 == actualList.Count())
            {
                return;
            }

            var expectedList = context.Value.Split(',');
            var diff = expectedList.Except(actualList);

            if (0 != diff.Count())
            {
                TestCommandHelper.AssertFail(string.Format(
                    CultureInfo.CurrentCulture,
                    Properties.Resources.AssertExpectedAndActual,
                    string.Join(",", expectedList),
                    string.Join(",", actualList)));
            }
        }

        public static IEnumerable<string> GetActual(ITestContext context)
        {
            var element = context.FindElement(context.Target);
            var selectElement = new SelectElement(element);
            var optionElements = selectElement.AllSelectedOptions;

            return optionElements.Select(i => i.Text).ToArray();
        }
    }
}
