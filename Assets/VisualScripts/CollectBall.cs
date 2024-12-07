using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDestroyer : MonoBehaviour
{
    
    public static int BallScore = 0;

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            BallScore += 1;
         
            Destroy(gameObject);

            if (BallScore == 1)
            { 
                DeactivateAllNPCs();
            }
        }
    }

   
    private void DeactivateAllNPCs()
    {

        GameObject[] npcs = GameObject.FindGameObjectsWithTag("npc");
        foreach (GameObject npc in npcs)
        {
            npc.SetActive(false);
        }
    }
}
