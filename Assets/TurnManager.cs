using UnityEngine;
using System.Collections;

public class TurnManager : MonoBehaviour {

    public static TurnManager instance = null;

    Player player;

    void Awake()
    {
        instance = this;
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    int turn = 1;
	// Use this for initialization
	void Start () {
        EndOfTurn();
	}
	
	// Update is called once per frame
	void Update () { }

    public void EndOfTurn()
    {
        turn = (turn + 1) % 2;
        if (turn == 1)
            EnemyManager.instance.playTurn();
        else
            player.PlayTurn();
    }
}
