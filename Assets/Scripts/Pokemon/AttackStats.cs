using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackStats
{
    private int power;

    public AttackStats(int power)
    {
        this.power = power;
    }

    public int Power
    {
        get { return power; }
        set { power = value; }
    }

}
