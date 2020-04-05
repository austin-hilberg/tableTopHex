using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    List<Character> characters = new List<Character>();
    string playerName;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Initialize(string name) {
        playerName = name;
    }

    public void AddCharacter(Character character) {
        characters.Add(character);
    }
}
