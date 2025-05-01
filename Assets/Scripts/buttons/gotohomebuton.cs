using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Required for scene management

public class Homescene : MonoBehaviour
{
    // This method will be called when the button is clicked
    public void GoToHomePage()
    {
        // Load the Homecene
        SceneManager.LoadScene("HomeScene");
    }
}
