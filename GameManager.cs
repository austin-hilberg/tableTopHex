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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
