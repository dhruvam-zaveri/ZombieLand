using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ammo : MonoBehaviour
{
    static public int CurrentAmmo;
    public int InternalAmmo;                                          // Magazine capacity of gun 
    public GameObject AmmoDisplay;

    static public int LoadedAmmo;                              
    public int InternalLoaded;                                       // Ammo loaded in the gun
    public GameObject LoadedDisplay;

    void Update()
    {
        InternalAmmo = CurrentAmmo;
        InternalLoaded = LoadedAmmo;

        AmmoDisplay.GetComponent<Text>().text = "" + InternalAmmo;
        LoadedDisplay.GetComponent<Text>().text = "" + InternalLoaded;
    }
}
