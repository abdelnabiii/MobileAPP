using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Required for scene management

public class Signup : MonoBehaviour
{
    // This method will be called when the button is clicked
    public void GoToSignupPage()
    {
        // Load the signup scene
        SceneManager.LoadScene("SignupScene");
    }
}
