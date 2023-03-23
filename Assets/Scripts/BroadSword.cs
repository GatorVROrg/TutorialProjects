using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BroadSword : MonoBehaviour
{
    public Material lit;
    public Material unlit;

    public GameObject blade;
    public float points;

    public void PickUp()
    {
        gameObject.GetComponent<Rigidbody>().isKinematic = false;
    }

    public void LightUp()
    {
        blade.GetComponent<MeshRenderer>().material = lit;
    }

    public void UnLight()
    {
        blade.GetComponent<MeshRenderer>().material = unlit;
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.transform.tag == "Enemy")
        {
            Destroy(other.gameObject);
            points = points + 10;
        }
    }
}
