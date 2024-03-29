﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameConstants
{
    public static KeyCode botButton1 = KeyCode.J;
    public static KeyCode botButton2 = KeyCode.K;

    public static KeyCode topButton1 = KeyCode.D;
    public static KeyCode topButton2 = KeyCode.F;
    // Point gain on perfect hit
    public static int maxPointGain = 100;
    // Multipliers for point gain on early/late and perfect hit
    public static float earlyLateMult = 0.5f;
    public static float perfectMult = 1f;
}
