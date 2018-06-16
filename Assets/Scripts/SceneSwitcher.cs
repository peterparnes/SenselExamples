using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SceneManager.LoadScene("Contacts");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SceneManager.LoadScene("Rain");
        }
        //else if (Input.GetKeyDown(KeyCode.Alpha3))
        //{
        //    SceneManager.LoadScene("Ripples");
        //}
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SceneManager.LoadScene("Blot");
        } else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            SceneManager.LoadScene("Theremin");
        }
    }
}
