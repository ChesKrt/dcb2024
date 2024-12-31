using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class PokemonManager : MonoBehaviour
{
    //Constructor programacion
    PokemonStats pikachu;
    PokemonStats charmander;
    int pikachuL;
    int charmanderL;

    //Scriptable object
    public PokemonTemplate[] playerPokemon;


    //Cambio Pokemon
    public TextMeshProUGUI namesUi;
    int changePk;

    //Cambiar menu
    public GameObject menuPokemon;

    void Start()
    {



        /*pikachu = new PokemonStats();
        pikachu.pkName = "Pikachu";
        pikachu.life = 35;
        pikachu.attack = 55;
        pikachu.defense = 40;
        pikachu.speed = 90;
        Debug.Log($"Name: {pikachu.pkName}, life: {pikachu.life}, attack: {pikachu.attack}, defense: {pikachu.defense}, speed: {pikachu.speed}");*/


        //pikachu = new PokemonStats("Pikachu",   35, 55, 40, 90, 50, 50, 40, 40, 30, 65, 25);
        charmander = new PokemonStats("Charmander", 39, 52, 43, 65, 60, 50, 40, 40, 65, 70, 04);

        //charmanderL = charmander.Life;
        //pikachuL = pikachu.Life;


        //Charmander

        //Debug.Log($"Name: {charmander.PkName}, life: {charmander.Life}, attack: {charmander.Attack}, defense: {charmander.Defense}, speed: {charmander.Speed}, special attack: {charmander.SpecialAttack}, special defense: {charmander.SpecialDefense}");
        //charmander.TotalSpecialAttack(charmander.SpecialAttack, pikachu.SpecialDefense);
        //Debug.Log(charmander.SpecialAttack);



        //Pikachu

        //Debug.Log($"Name: {pikachu.PkName}, life: {pikachu.Life}, attack: {pikachu.Attack}, defense: {pikachu.Defense}, speed: {pikachu.Speed}, special attack: {pikachu.SpecialAttack}, special defense: {pikachu.SpecialDefense}");
        //pikachu.TotalSpecialAttack(pikachu.SpecialAttack, charmander.SpecialDefense);
        //Debug.Log(pikachu.SpecialAttack);


        //Sprites

        SpriteManager.instance.SetSprites(playerPokemon[0].PokdedexNumber, charmander.PokdedexNumber);
        namesUi.text = playerPokemon[0].PkName;

        for (int i = 0; i < menuPokemon.transform.childCount; i++)
        {
            menuPokemon.transform.GetChild(i).gameObject.SetActive(false);
        }

        for (int i = 0; i < playerPokemon.Length; i++)
        {
            menuPokemon.transform.GetChild(i).gameObject.SetActive(true);
            menuPokemon.transform.GetChild(i).GetComponent<ElementPokemon>().pkName.text = playerPokemon[i].PkName;
            menuPokemon.transform.GetChild(i).GetComponent<ElementPokemon>().spriteMini.sprite = SpriteManager.instance.MiniSprite(playerPokemon[i].PokdedexNumber);
        }

    }

    private void Update()
    {
        //Attack debug test

        /*if (Input.GetKeyDown(KeyCode.C))
        {
            int attackP = pikachu.Attack + pikachu.Attack2;
            int defenseCh = charmander.Defense + charmander.Life;

            charmanderL -= (attackP) - (defenseCh);
            Debug.Log($"Pikachu utilizo: {pikachu.Name2}.  Charmander life: {charmanderL}");
        }

        if(Input.GetKeyDown(KeyCode.P))
        {
            int attackCh = charmander.Attack + charmander.Attack1;
            int defenseP = pikachu.Life + pikachu.Defense;

            pikachuL -= attackCh - defenseP; 
            Debug.Log($"Charmander utilizo: {charmander.Name1}.  Pikachu life: {pikachuL}");
        }*/

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            changePk++;

            if(changePk > playerPokemon.Length - 1)
            {
                changePk = 0;
            }

            namesUi.text = playerPokemon[changePk].PkName;
            SpriteManager.instance.SetSprites(playerPokemon[changePk].PokdedexNumber, charmander.PokdedexNumber);

        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            changePk--;

            if (changePk < 0)
            {
                changePk = playerPokemon.Length - 1;
            }

            namesUi.text = playerPokemon[changePk].PkName;
            SpriteManager.instance.SetSprites(playerPokemon[changePk].PokdedexNumber, charmander.PokdedexNumber);
        }

    }
}
