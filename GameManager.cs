using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    HexBoard board;
    Player[] players;
    enum GameState
    {
        Decision,
        Resolution,
        Completion
    }
    GameState state;

    // Start is called before the first frame update
    void Start()
    {
        DefaultInitialization();
        state = GameState.Decision;
    }

    // Update is called once per frame
    void Update()
    {
        switch (state)
        {
            case GameState.Decision:
                break;
            case GameState.Resolution:
                break;
            case GameState.Completion:
                break;
        }
        
    }

    void DefaultInitialization() {
        int numPlayers = 2;
        int boardRadius = 2;

        int hp = 10;
        List<Ability> abilities = new List<Ability>();
        abilities.Add(new Ability(Ability.Target.Location, Ability.Effect.Path, 0, 3, 3, 2, true, "Move"));
        abilities.Add(new Ability(Ability.Target.Unit, Ability.Effect.Harm, 4, 3, 6, 2, false, "Attack"));
        
        GameObject hex = GameObject.Find("Base Hex");
        board = new GameObject().AddComponent<HexBoard>();
        board.AddBigHex(hex, boardRadius, 0, 0, true);
        hex.SetActive(false);

        GameObject charObj = GameObject.Find("Base Character");
        players = new Player[numPlayers];       
        for (int i = 0; i < numPlayers; i ++) {
            GameObject playerObj = new GameObject();
            Player newPLayer = playerObj.AddComponent<Player>();
            newPLayer.Initialize("Player " + i);
            Character newCharacter = Object.Instantiate(charObj).AddComponent<Character>();
            int charq = boardRadius - 2 * i * boardRadius;
            int charr = 0;
            newCharacter.Initialize(charq, charr, hp, abilities, "Char " + i);
            newPLayer.AddCharacter(newCharacter);
            AddCharacter(newCharacter, charq, charr);
        }
        charObj.SetActive(false);

    }

    void AddCharacter(Character character, int q, int r) {
        board.SetOccupant(q, r, character.gameObject);
        
    }
}
