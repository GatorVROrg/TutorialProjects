using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BroadSword : MonoBehaviour
{
    public Material lit;
    public Material unlit;

    public void PickUp()
    {
        gameObject.GetComponent<Rigidbody>().isKinematic = false;
    }

    public void LightUp()
    {
        gameObject.GetComponent<MeshRenderer>().material = lit;
    }

    public void UnLight()
    {
        gameObject.GetComponent<MeshRenderer>().material = unlit;
    }
}
