using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthArmorDamage : MonoBehaviour
{
    public float health;
    public float armor;
    public float damage;
    void Start()
    {

            if (damage > armor)
            {
                health = health - damage + armor;
                if (health > 0)
                {
                    Debug.Log(health);
                    Debug.Log("YouGotShot");
                }
                else
                {
                    Debug.Log("YouDied");
                }
            }
            else
            {
                armor = armor - damage;
                Debug.Log(armor);
                Debug.Log("NothingHappend");
            }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
