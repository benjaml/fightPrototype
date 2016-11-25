using UnityEngine;
using System.Collections;

public class TurnManager : MonoBehaviour {

    public static TurnManager instance = null;
    
    void Awake()
    {
        instance = this;
    }

    int turn = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(turn == 1)
        {
            EnemyManager.instance.playTurn();
        }
	}
}
