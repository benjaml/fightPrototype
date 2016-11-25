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
       // attackers.PlayAttack();
    }

    public void ApplyRes(AttackEnum ae)
    {
        switch (ae)
        {
            case AttackEnum.MAGICAL_FIRE:
                foreach(Enemy e in renforts)
                {
                    e.magic_fire = true;
                }
                break;
            case AttackEnum.MAGICAL_ICE:
                foreach (Enemy e in renforts)
                {
                    e.magic_ice = true;
                }
                break;
            case AttackEnum.MAGICAL_THUNDER:
                foreach (Enemy e in renforts)
                {
                    e.magic_foudre = true;
                }
                break;
            case AttackEnum.PHYSICAL_FIRE:
                foreach (Enemy e in renforts)
                {
                    e.physic_fire = true;
                }
                break;
            case AttackEnum.PHYSICAL_ICE:
                foreach (Enemy e in renforts)
                {
                    e.physic_ice = true;
                }
                break;
            case AttackEnum.PHYSICAL_THUNDER:
                foreach (Enemy e in renforts)
                {
                    e.physic_thunder = true;
                }
                break;
        }
    }


}
