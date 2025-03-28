using UnityEngine;

public class AlienCode : AlienBase
{
    public override void TakeDamage(float damage)
    {
        health -= damage;
    }
}