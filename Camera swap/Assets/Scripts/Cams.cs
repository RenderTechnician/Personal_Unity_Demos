using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cams : MonoBehaviour {
    public int Cam_Acc;
    public int Cam_Num;
    public Camera Cam0;
    public Camera Cam1;
    public Camera Cam2;
    public Camera Cam3;
    public Camera[] Strings;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetKeyDown(KeyCode.Space))
        {
            Cam_Acc++;
        }	
    if (Cam_Acc > 1)
        {
            Cam_Acc = 0;
        }
    //Camera access
    if (Cam_Acc == 1 && Cam_Num == 0)
        {
            Cam0.enabled = false;
            Cam1.enabled = true;
            Cam2.enabled = false;
            Cam3.enabled = false;
        }
        if (Cam_Acc == 1 && Cam_Num == 1)
        {
            Cam0.enabled = false;
            Cam1.enabled = false;
            Cam2.enabled = true;
            Cam3.enabled = false;
        }
        if (Cam_Acc == 1 && Cam_Num == 2)
        {
            Cam0.enabled = false;
            Cam1.enabled = false;
            Cam2.enabled = false;
            Cam3.enabled = true;
        }
        if (Cam_Acc == 0)
        {
            Cam0.enabled = true;
            Cam1.enabled = false;
            Cam2.enabled = false;
            Cam3.enabled = false;
        }
    }
    public void CAM1()
    {
        Cam_Num = 0;
    }
    public void CAM2()
    {
        Cam_Num = 1;
    }
    public void CAM3()
    {
        Cam_Num = 2;
    }
}
