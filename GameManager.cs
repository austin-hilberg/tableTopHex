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

        GameObject hex = GameObject.Find("Base Hex");
        board = gameObject.AddComponent<HexBoard>();
        board.AddBigHex(hex, boardRadius, 0, 0, true);
        hex.SetActive(false);

        GameObject player = GameObject.Find("Base Player");
        players = new Player[numPlayers];
        for (int i = 0; i < numPlayers; i ++) {
            GameObject playerObj = Object.Instantiate(player, board.transform.position, Quaternion.Euler(0, 0, 0), board.transform);
            Player newPLayer = playerObj.AddComponent<Player>();
            AddPlayer(newPLayer, boardRadius - 2 * i * boardRadius, 0);
        }
        player.SetActive(false);

    }

    void AddPlayer(Player player, int q, int r) {
        board.SetOccupant(q, r, player.gameObject);
        player.Initialize(q, r);
        players[players.Length - 1] = player;
    }
}
