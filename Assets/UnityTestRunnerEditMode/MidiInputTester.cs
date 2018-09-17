using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using TwisterForUnity;

namespace TwisterForUnity.Test {
    public class MidiInputTester {

        private TwisterParams twisterParams;

        const string TwisterPortName = "Midi Fighter Twister";

        [SetUp]
        public void SetUp() {
            twisterParams = new TwisterParams(TwisterPortName);
            Debug.Log("SetUp");
        }
    }
}

