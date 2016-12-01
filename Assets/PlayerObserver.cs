using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerObserver : MonoBehaviour {

    List<AttackEnum> playerAttacks = new List<AttackEnum>();

    public static PlayerObserver instance = null;

    void Awake()
    {
        instance = this;
    }

    public void RegisterAttack(AttackEnum ae)
    {
        if (!playerAttacks.Contains(ae))
            playerAttacks.Add(ae);
    }
}
