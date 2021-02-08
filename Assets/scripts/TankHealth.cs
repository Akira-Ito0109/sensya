using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
               // Destroy(gameObject);

                this.gameObject.SetActive(false);

                Invoke("GoToGameOver", 1.5f);
            }
        }
    }
    void GoToGameOver()
    {
        SceneManager.LoadScene("GameOver");
    }

}
