using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileInputHandler : MonoBehaviour {


    public delegate void MyInput(float x, float y);
    public static event MyInput Touch;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0))
        {
            Debug.Log(Input.mousePosition.ToString());
            Touch(Input.mousePosition.x, Input.mousePosition.y);
           
        }
	}
}
