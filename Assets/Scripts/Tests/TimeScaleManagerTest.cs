using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Zenject;
using Foundation;

public class TimeScaleManagerTest
{
    // A Test behaves as an ordinary method
    [Test]
    public void TimeScaleManagerTestSimplePasses()
    {
        // Use the Assert class to test conditions
        Assert.IsTrue(false);
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator TimeScaleManagerTestWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}
