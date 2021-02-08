using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankHealth : MonoBehaviour
{

    public int tankHP;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="EnemyShell")
        {
            tankHP -= 1;

            Destroy(other.gameObject);

            if(tankHP<=0)
            {
                Destroy(gameObject);
            }
        }
    }

}
