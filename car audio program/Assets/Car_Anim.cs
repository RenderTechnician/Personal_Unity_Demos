using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_Anim : MonoBehaviour {
    public Animator Spin;
    public Animator Spin_B;
    public float Speeder;
    public Car_Audio Car_Link;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Spin_B.speed = Speeder;
        Spin.speed = Speeder;
        Speeder = Car_Link.Spinning;
	}
}
