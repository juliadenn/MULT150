using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallScript : MonoBehaviour
{
    // Define TakeDamageFromFireball methods
    int TakeDamageFromFireball()
    {
        // Logic for first method
        return 100; // Assuming initial health is 100
    }

    int TakeDamageFromFireball(int damageAmount)
    {
        // Logic for second method
        return 100 - damageAmount; // Assuming initial health is 100
    }

    int TakeDamageFromFireball(int fireDamage, int otherDamage)
    {
        // Logic for third method
        return 100 - (fireDamage + otherDamage); // Assuming initial health is 100
    }

    void Start()
    {
        // Call first method
        int x = TakeDamageFromFireball();
        print("Player health: " + x);

        // Call second method
        int y = TakeDamageFromFireball(25);
        print("Player health: " + y);

        // Call third method
        int z = TakeDamageFromFireball(30, 50);
        print("Player health: " + z);
    }


// Update is called once per frame
void Update()
    {
        
    }
}
