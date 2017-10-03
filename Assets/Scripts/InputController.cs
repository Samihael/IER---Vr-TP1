using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    private CubeAvatar avatar = new CubeAvatar();
	// Use this for initialization
	void Start () {
        avatar = this.gameObject.GetComponent<CubeAvatar>();
	}
	
	// Update is called once per frame
	void Update ()
	{
	    float hinput = Input.GetAxis("Horizontal");
	    float vinput = Input.GetAxis("Vertical");
	    float inputA, inputB, inputX, inputY;

        if(avatar.AlwaysMax)
             this.gameObject.transform.position = new Vector3(hinput * 10f, vinput * 10f, 0f);

        inputA = Input.GetAxisRaw("A");
        inputB = Input.GetAxisRaw("B");
        inputX = Input.GetAxisRaw("X");
        inputY = Input.GetAxisRaw("Y");

	    if (inputA.Equals(0) && inputB.Equals(0) && inputX.Equals(0) && inputY.Equals(0))
	        this.GetComponent<Renderer>().material.color = Color.white;
	    else
            this.GetComponent<Renderer>().material.color = new Color(0.5f * (inputY + inputB), 0.5f * (inputY + inputA), 0.5f * inputX);
    
	    if (Input.GetKeyDown(KeyCode.Escape))
	        Application.Quit();
	  
    }
}
