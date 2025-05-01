using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Required for scene management

public class gotosubmiteoi : MonoBehaviour
{
    // This method will be called when the button is clicked
    public void GoToSubmitEOI()
    {
        // Load the submitEOI scene
        SceneManager.LoadScene("SubmitEOIscene");
    }
}
