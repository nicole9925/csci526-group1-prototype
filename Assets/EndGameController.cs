using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameController : MonoBehaviour
{
    int[] targetsHit;
    bool gameOver;
    // Start is called before the first frame update
    void Start()
    {
        targetsHit = new int[] { 0, 0, 0 };
        gameOver = false;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            if (!gameOver)
            {
                print("Game Over");
                gameOver = true;
            }
        }
        if (collision.gameObject.name == "Target1")
        {
            targetsHit[0] = 1;
        }
        if (collision.gameObject.name == "Target2")
        {
            targetsHit[1] = 1;
        }
        if (collision.gameObject.name == "Target3")
        {
            targetsHit[2] = 1;
        }

        int sum = 0;

        foreach (int i in targetsHit)
        {
            if(i == 1)
            {
                sum++;
            }
            if (sum == 3)
            {
                if (!gameOver)
                {
                    print("You won!"); 
                }
            }
        }
    }
}
