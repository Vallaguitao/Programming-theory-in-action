using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatMovement : PlayerMovement // INHERITANCE
{
    public override void SetSpeed() // POLYMORPHISM
    {
        speed = 10;
    }
}
