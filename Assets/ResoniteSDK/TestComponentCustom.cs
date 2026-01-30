using ResoniteLink;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

namespace Test
{
    [AddComponentMenu("MyStuff/Test<Vector4Int>")]
    public class TestComponentCustom : TestComponent<bool4>
    {
    }
}