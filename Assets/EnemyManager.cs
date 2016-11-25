using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyManager : MonoBehaviour {

    public static EnemyManager instance = null;

    public List<Enemy> renforts = new List<Enemy>();
    public Enemy attackers;

    void Awake()
    {
        instance = this;
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void playTurn()
    {
        CheckSwitch();
        playAttack();
    }

    void CheckSwitch()
    {
              
    }

    void playAttack()
    {
        
    }


}
