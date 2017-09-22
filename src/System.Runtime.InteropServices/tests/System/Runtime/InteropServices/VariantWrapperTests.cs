// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Xunit;

namespace System.Runtime.InteropServices.Tests
{
#pragma warning disable 0618 // VariantWrapper is marked as Obsolete.
    public class VariantWrappedTests
    {
        [Theory]
        [InlineData(null)]
        [InlineData(1)]
        [InlineData("Value")]
        public void Ctor_Value(object value)
        {
            var wrapper = new VariantWrapper(value);
            Assert.Equal(value, wrapper.WrappedObject);
        }
    }
#pragma warning restore 0618
}
