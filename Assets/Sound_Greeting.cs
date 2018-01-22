using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sound_Greeting : MonoBehaviour {
    public AudioSource nagranie_powitalne;
    public int counter = 0;
    private GameObject spider;
    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.P))
        {
            counter++;
            if (counter == 1) {
                nagranie_powitalne.Play();

            }
            else if (counter == 2)
            {
                SceneManager.LoadScene("safetyRoom");
            }
            else if (counter == 3)
            {
                 
            }
        }
	}
}
