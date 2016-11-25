using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public float healingPower = 10;
    public float hp = 0;
    public float hpMax = 200;
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

    }

    public void PhysicAttack_Ice()
    {

    }

    public void PhysicAttack_Thunder()
    {

    }

    public void MagicalAttack_Fire()
    {

    }

    public void MagicalAttack_Ice()
    {

    }

    public void MagicalAttack_Thunder()
    {

    }

    public void Heal()
    {
        healingPower = Mathf.Min(hp + healingPower, hpMax);
    }
}
