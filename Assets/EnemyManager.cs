using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyManager : MonoBehaviour {

    public static EnemyManager instance = null;

    public List<Enemy> renforts = new List<Enemy>();
    public Enemy attacker;

    List<AttackEnum> playerAttack = new List<AttackEnum>();

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
        Enemy currentBest = attacker;
        float bestScore = GetScoreForPlayer(attacker);
        foreach(Enemy e in renforts)
        {
            float tmp = GetScoreForPlayer(e);
            if(tmp > bestScore)
            {
                bestScore = tmp;
                currentBest = e;
            }
        }
       // if(currentBest )
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
                    e.magic_thunder = true;
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

    float GetScoreForPlayer(Enemy en)
    {
        float score = 0;
        foreach(AttackEnum ae in playerAttack)
        {
            switch (ae)
            {
                case AttackEnum.MAGICAL_FIRE:
                    if (en.magic_fire)
                        score++;
                    break;
                case AttackEnum.MAGICAL_ICE:
                    if (en.magic_ice)
                        score++;
                    break;
                case AttackEnum.MAGICAL_THUNDER:
                    if (en.magic_thunder)
                        score++;
                    break;
                case AttackEnum.PHYSICAL_FIRE:
                    if (en.physic_fire)
                        score++;
                    break;
                case AttackEnum.PHYSICAL_ICE:
                    if (en.physic_ice)
                        score++;
                    break;
                case AttackEnum.PHYSICAL_THUNDER:
                    if (en.physic_thunder)
                        score++;
                    break;
            }
        }
        return 0;
    }

}
