using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalLevel1 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Ball")
        {
            Debug.Log("You beat level 1! Loading Level 2...");
            SceneManager.LoadScene("Level 2");
        }
    }
}
