using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    [Header("Health")]
    public float hp = 0;
    public float hpMax = 200;

    [Header("Fight")]
    public float damage = 15;
    public float healingPower = 10;

    [SerializeField]
    GameObject main;

    // Use this for initialization
    void Start () {
        hp = hpMax;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void PlayTurn()
    {
        main.SetActive(true);
    }

    public void PhysicAttack_Fire()
    {
        EnemyManager.instance.attacker.TakeDamages(AttackEnum.PHYSICAL_FIRE, damage);
    }

    public void PhysicAttack_Ice()
    {
        EnemyManager.instance.attacker.TakeDamages(AttackEnum.PHYSICAL_ICE, damage);
    }

    public void PhysicAttack_Thunder()
    {
        EnemyManager.instance.attacker.TakeDamages(AttackEnum.PHYSICAL_THUNDER, damage);
    }

    public void MagicalAttack_Fire()
    {
        EnemyManager.instance.attacker.TakeDamages(AttackEnum.MAGICAL_FIRE, damage);
    }

    public void MagicalAttack_Ice()
    {
        EnemyManager.instance.attacker.TakeDamages(AttackEnum.MAGICAL_ICE, damage);
    }

    public void MagicalAttack_Thunder()
    {
        EnemyManager.instance.attacker.TakeDamages(AttackEnum.MAGICAL_THUNDER, damage);
    }

    public void Heal()
    {
        healingPower = Mathf.Min(hp + healingPower, hpMax);
    }

    public void TakeDamage(float damage)
    {
        hp -= damage;
        if(hp <= 0)
        {
            death();
        }
    }

    public void death()
    {
        Time.timeScale = 0;
        Debug.Log("YOU'RE DEAD !");
    }
}
