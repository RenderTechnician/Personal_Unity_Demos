using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_Audio : MonoBehaviour
{
    public AudioSource Stop;
    public AudioSource running;
    public AudioSource Clutch;
    public float Pitcher;
    public float count;
    public int Gear;
    public float volume;
    public float volums;
    public float Spinning;
    // Use this for initialization
    void Start()
    {
        volume = 100;
    }

    // Update is called once per frame
    void Update()
    {
        volums = volume / 100;
        PressW();
        PressS();
        PitcherCalc();
        Still();
        Pitch();
        Zero();
        Gearing();
        Vol();
        Spinner();

    }
    void PressW()
    {
        if (Input.GetKey(KeyCode.W))
        {
            count++;
            count++;
            Spinning++;
            Spinning++;
            volume--;
            if (!running.isPlaying)
            {
                running.Play();
            }
        }
        else
        {
            count--;
            Spinning--;
        }
    }
    void PitcherCalc()
    {
        Pitcher = count / 500;
    }
    void Still()
    {
if(Pitcher == 0)
        {
            running.Stop();
            if (!Stop.isPlaying)
            {
                Stop.Play();
            }
           
        }
    }
    void Pitch()
    {
        running.pitch = Pitcher;
    }
    void Zero()
    {
if (0 > volume)
        {
            volume = 0;
        }
if (0 > Pitcher)
        {
            Pitcher = 0;
        }
if (0 > count)
        {
            count = 0;
        }
if (0 > Spinning)
        {
            Spinning = 0;
        }
    }
    void Gearing()
    {
if (count >= 600 + (Gear*20))
        {
            if (Gear < 7)
            {
                Gear++;
                //Pitcher = 0.3f;
                count = 450 + (Gear * 15);
                Clutch.Play();
            }
        }
if (count > 700)
        {
            count = 700;
        }
if (300 > count)
        {
            if (Gear > 0)   
            {
                count = 500;
                Gear--;
                Clutch.Play();
            }
            
           
        }
    }
    void MaxSpeed()
    {
        if (count > 900)
        {
            count = 900;
        }
    }
    void Vol()
    {
        if (150 > count)
        {
            volume++;
        }
        Stop.volume = volums;
        if (volume > 100)
        {
            volume = 100;
        }
    }
    void PressS()
    {
        if (Input.GetKey(KeyCode.S))
        {
            count--;
            count--;
            Spinning--;
            Spinning--;
        }
    }
    void Spinner()
    {
if (Spinning > 1500)
        {
            Spinning = 1500;
        }
    }
}
