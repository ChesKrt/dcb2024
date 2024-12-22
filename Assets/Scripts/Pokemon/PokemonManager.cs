using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PokemonManager : MonoBehaviour
{

    PokemonStats pikachu;
    PokemonStats charmander;

    // Start is called before the first frame update
    void Start()
    {
        /*pikachu = new PokemonStats();
        pikachu.pkName = "Pikachu";
        pikachu.life = 35;
        pikachu.attack = 55;
        pikachu.defense = 40;
        pikachu.speed = 90;
        Debug.Log($"Name: {pikachu.pkName}, life: {pikachu.life}, attack: {pikachu.attack}, defense: {pikachu.defense}, speed: {pikachu.speed}");*/


        pikachu = new PokemonStats("Pikachu", 35, 55, 40, 90, 50, 50, 40, 40, 30, 65);
        charmander = new PokemonStats("Charmander", 39, 52, 43, 65, 60, 50, 40, 40, 65, 70);



        //Charmander

        Debug.Log($"Name: {charmander.PkName}, life: {charmander.Life}, attack: {charmander.Attack}, defense: {charmander.Defense}, speed: {charmander.Speed}, special attack: {charmander.SpecialAttack}, special defense: {charmander.SpecialDefense}");
        charmander.TotalSpecialAttack(charmander.SpecialAttack, pikachu.SpecialDefense);
        Debug.Log(charmander.SpecialAttack);



        //Pikachu

        Debug.Log($"Name: {pikachu.PkName}, life: {pikachu.Life}, attack: {pikachu.Attack}, defense: {pikachu.Defense}, speed: {pikachu.Speed}, special attack: {pikachu.SpecialAttack}, special defense: {pikachu.SpecialDefense}");
        pikachu.TotalSpecialAttack(pikachu.SpecialAttack, charmander.SpecialDefense);
        Debug.Log(pikachu.SpecialAttack);

    }

    private void Update()
    {
        //Attack debug test

        if (Input.GetKeyDown(KeyCode.R))
        {
            pikachu.Life = 35;
            charmander.Life = 39;
            Debug.Log($"Pikachu: {pikachu.Life}, Charmander: {charmander.Life}");
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            charmander.Life = (pikachu.Attack) - (charmander.Defense);
            Debug.Log(charmander.Life);
        }

        if(Input.GetKeyDown(KeyCode.P))
        {
            pikachu.Life = (charmander.Attack) - (pikachu.Defense);
            Debug.Log(pikachu.Life);
        }
    }
}
