using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpColtM4 : MonoBehaviour
{
    public float TheDistance = PlayerCasting.DistanceFromTarget;
    public GameObject FakeGun;
    public GameObject RealGun;
    public GameObject TextDisplay;

    void Update()
    {
        if (Input.GetButtonDown("PickUp"))
        {
            if (TheDistance <= 1)
            {
                PickUp();
            }
        }
    }

    private void OnMouseOver()
    {
        if (TheDistance <= 1)
        {
            TextDisplay.GetComponent<Text>().text = "Press g to pick up the gun.";
        }
    }

    private void OnMouseExit()
    {
        TextDisplay.GetComponent<Text>().text = "";
    }

    void PickUp()
    {
        //transform.position=Vector4(0, -1000, 0);
        FakeGun.SetActive(false);
        RealGun.SetActive(true);
    }
}
