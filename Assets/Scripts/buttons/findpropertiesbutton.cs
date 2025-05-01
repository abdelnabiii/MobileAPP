using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Required for scene management

public class PropertySearch : MonoBehaviour
{
    // This method will be called when the button is clicked
    public void GoToPropertySearchPage()
    {
        // Load the PropertySearch scene
        SceneManager.LoadScene("PropertySearchScene");
    }
}
