using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class TigerMovement : PlayerMovement // INHERITANCE
{
    public override void SetSpeed() // POLYMORPHISM
    {
        speed = 15;
    }
}
