using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiltPlacement : MonoBehaviour
{
    public Transform head;

    private Vector3 hiltLocation;
    // Start is called before the first frame update
    void Start()
    {
        hiltLocation = new Vector3(head.position.x, head.position.y - 2, head.position.z);
        gameObject.transform.position = hiltLocation;
    }

    // Update is called once per frame
    void Update()
    {
        hiltLocation = new Vector3(head.position.x, head.position.y - 2, head.position.z);
        gameObject.transform.position = hiltLocation;
    }
}
