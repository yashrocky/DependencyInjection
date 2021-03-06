// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.Framework.DependencyInjection.Tests.Fakes
{
    public class AnotherClass
    {
        private readonly IFakeService _fakeService;

        public AnotherClass(IFakeService fakeService)
        {
            _fakeService = fakeService;
        }

        public string LessSimpleMethod()
        {
            return "[" + _fakeService.SimpleMethod() + "]";
        }
    }
}
