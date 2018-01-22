using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showSpider : MonoBehaviour {
	public GameObject spider;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Z)){
		spider.SetActive (false);
	}
	else if (Input.GetKeyDown(KeyCode.A)){
			spider.SetActive (true);
}

}
}
