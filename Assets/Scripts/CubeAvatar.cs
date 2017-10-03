using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAvatar : MonoBehaviour {

    [SerializeField]
    private float maxSpeed;

    [SerializeField]
    private bool alwaysMax;

    [SerializeField]
    private float inertia;

    [SerializeField]
    private float boost;

    [SerializeField]
    private float dash;

    public float MaxSpeed
    {
        get
        {
            return this.maxSpeed;
        }
        set
        {
            this.maxSpeed = value;
        }
    }
    public bool AlwaysMax
    {
        get
        {
            return this.alwaysMax;
        }
     
    }
    [SerializeField]
    private float sprint;
    
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
