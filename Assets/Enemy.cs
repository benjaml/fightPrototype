using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {


    // Health
    [Header("Health")]
    public float hp = 30;

    // Damage
    [Header("Damage")]
    public float damagePhysicFeu = 10;
    public float damagePhysicGlace = 10;
    public float damagePhysicFoudre = 10;
    public float damageMagicFeu = 10;
    public float damageMagicGlace = 10;
    public float damageMagicFoudre = 10;

    // resistance
    [Header("Resistance")]
    public bool physic_fire = false;
    public bool physic_ice = false;
    public bool physic_thunder = false;
    public bool magic_fire = false;
    public bool magic_ice = false;
    public bool magic_thunder = false;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public float getScore()
    {
        return 0;
    }
}
