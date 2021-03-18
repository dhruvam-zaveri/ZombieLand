using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunDamage : MonoBehaviour
{
    public int Damage = 5;
    public float TargetDistance;
    public float AllowedDistance = 15;

    // Update is called once per frame
    void Update()
    {
        if (Ammo.LoadedAmmo >= 1)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                RaycastHit Shot;
                if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Shot))
                {
                    TargetDistance = Shot.distance;
                    if (TargetDistance < AllowedDistance)
                    {
                        Shot.transform.SendMessage("DeductPoints", Damage);
                    }
                }
            }
        }
    }
}
