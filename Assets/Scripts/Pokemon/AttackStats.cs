using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackStats
{
    private int power;
    private string name;

    public AttackStats(int power, string name)
    {
        this.power = power;
        this.name = name;
    }

    public int Power
    {
        get { return power; }
        set { power = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
}
