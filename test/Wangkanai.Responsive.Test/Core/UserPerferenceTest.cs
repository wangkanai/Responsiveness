﻿using System;
using System.Collections.Generic;
using System.Text;
using Wangkanai.Detection;
using Xunit;

namespace Wangkanai.Responsive.Test.Core
{
    public class UserPerferenceTest
    {
        [Fact]
        public void Preferred_Cookie_over_Resolver()
        {
            var preference = new UserPerference(DeviceType.Mobile, DeviceType.Desktop);

            Assert.Equal("Desktop", preference.Preferred);
        }
    }
}
