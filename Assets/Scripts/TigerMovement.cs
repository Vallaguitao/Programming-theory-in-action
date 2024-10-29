using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class TigerMovement : PlayerMovement
{
    public override void SetSpeed()
    {
        speed = 15;
    }
}
