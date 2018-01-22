using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class safetyRoom : MonoBehaviour
{

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SceneManager.LoadScene("safetyRoom");
            
          // Application.LoadLevel("safetyRoom");

        }

    }
}
