using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpM9 : MonoBehaviour
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
                PickUp9mm();
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

    void PickUp9mm()
    {
        transform.position = new Vector3(0, -1000, 0);
        FakeGun.SetActive(false);
        RealGun.SetActive(true);
    }
}
