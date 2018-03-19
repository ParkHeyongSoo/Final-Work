using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public bool bStart;

    private float _Speed;
    public float _Accel;
    public float JumpPower;

	// Use this for initialization
	void Awake () {
        _Speed = 0f;
        bStart = false;
        MobileInputHandler.Touch += Jump;
        MobileInputHandler.Touch += TouchToStart;

    }
	
	// Update is called once per frame
	void Update () {

        Physics();

    }

    void TouchToStart(float x, float y)
    {
        if (bStart)
            return;

        bStart = true;
    }

    void Physics()
    {
        if (!bStart)
            return;
        _Speed -= _Accel * Time.deltaTime;

        transform.Translate(0f, _Speed * Time.deltaTime, 0f, Space.World);
    }

    void Jump(float x, float y)
    {
        if (!bStart)
            return;

        _Speed += JumpPower;
    }
}
