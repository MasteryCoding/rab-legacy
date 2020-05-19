using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalLevel2 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Ball")
        {
            Debug.Log("You beat level 2! Loading Level 3...");
            //SceneManager.LoadScene("Level 3");
        }
    }
}
