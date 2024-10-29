using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenMovement : PlayerMovement // INHERITANCE
{
    public override void SetSpeed() // POLYMORPHISM
    {
        speed = 5;
    }
}
