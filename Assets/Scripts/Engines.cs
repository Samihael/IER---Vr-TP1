using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engines : MonoBehaviour {

    private Vector2 speed;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.Translate(speed * this.GetComponent<CubeAvatar>().MaxSpeed * Time.deltaTime);
    }
}
