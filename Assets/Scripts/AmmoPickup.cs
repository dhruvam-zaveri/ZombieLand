using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour
{
    public AudioSource AmmoPickUpSound;

    public void OnTriggerEnter(Collider Col)
    {
        AmmoPickUpSound.Play();
        if(Ammo.LoadedAmmo == 0)
        {
            Ammo.LoadedAmmo += 12;                      // Ammo in the gun
        }
        else
        {
            Ammo.CurrentAmmo += 12;                    // Magazine of gun
        }
        this.gameObject.SetActive(false);
    }
}
