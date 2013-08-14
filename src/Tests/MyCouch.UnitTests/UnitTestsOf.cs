﻿using MyCouch.Testing;
#if !WinRT
using Microsoft.VisualStudio.TestTools.UnitTesting;
#else
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
#endif

namespace MyCouch.UnitTests
{
    [TestClass]
    public abstract class UnitTestsOf<T> : TestsOf<T> where T : class { }

    [TestClass]
    public abstract class UnitTestsOf : TestsOf { }
}