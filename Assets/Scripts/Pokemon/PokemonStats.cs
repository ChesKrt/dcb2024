using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokemonStats
{
    private string pkName = "";
    private int life;
    private int attack;
    private int defense;
    private int speed;
    private int specialAttack;
    private int specialDefense;

    AttackStats attack1;
    AttackStats attack2;
    AttackStats attack3;
    AttackStats attack4;

    public PokemonStats(string pkName, int life, int attack, int defense, int speed, int specialAttack, int specialDefense, int power1, int power2, int power3, int power4)
    {
        this.pkName = pkName;
        this.life = life;
        this.attack = attack;
        this.defense = defense;
        this.speed = speed;
        this.specialAttack = specialAttack;
        this.specialDefense = specialDefense;

        attack1 = new AttackStats(power1);
        attack2 = new AttackStats(power2);
        attack3 = new AttackStats(power3);
        attack4 = new AttackStats(power4);
    }

    public void TotalSpecialAttack(int attackPlayer, int defenseRival)
    {
        specialAttack = attackPlayer + defenseRival;
    }

    /*public string GetName()
    {
        return pkName;
    }

    public void SetName(string pkName)
    {
        this.pkName = pkName;
    }*/

    public string PkName
    {
        get { return pkName; }
        set {  pkName = value; }
    }

    /*public int GetLife()
    {
        return life;
    }*/

    public int Life
    {
        get { return life; }
        set { life = value; }
    }

    /*public int GetAttack()
    {
        return attack;
    }*/

    public int Attack
    {
        get { return attack; }
        set { attack = value; }
    }

    /*public int GetDefense()
    {
        return defense;
    }*/

    public int Defense
    {
        get { return defense; }
        set { defense = value; }
    }

    /*public int GetSpeed()
    {
        return speed;
    }*/

    public int Speed
    {
        get { return speed; }
        set { speed = value; }
    }

    public int SpecialAttack
    {
        get { return specialAttack; }
        set { specialAttack = value; }
    }

    public int SpecialDefense
    {
        get { return specialDefense; }
        set { specialDefense = value; }
    }

}
