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
    public bool physicFeu = false;
    public bool physicGlace = false;
    public bool physicFoudre = false;
    public bool magicFeu = false;
    public bool magicGlace = false;
    public bool magicFoudre = false;

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
