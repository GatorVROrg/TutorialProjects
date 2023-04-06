using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.XR.CoreUtils;
using Photon.Pun;
using UnityEngine.InputSystem;


public class NetworkPlayer : MonoBehaviour
{
    public Transform head;
    public Transform leftHand;
    public Transform rightHand;

    private Transform headRig;
    private Transform leftHandRig;
    private Transform rightHandRig;

    private PhotonView photonView;

    public InputActionProperty RightpinchAnimationAction;
    public InputActionProperty LeftgripAnimationAction;
    public InputActionProperty LeftpinchAnimationAction;
    public InputActionProperty RightgripAnimationAction;

    public Animator RighthandAnimator;
    public Animator LefthandAnimator;

    void Start()
    {
        photonView = GetComponent<PhotonView>();
        XROrigin rig = FindObjectOfType<XROrigin>();
        headRig = rig.transform.Find("Camera Offset/Main Camera");
        leftHandRig = rig.transform.Find("Camera Offset/LeftHand");
        rightHandRig = rig.transform.Find("Camera Offset/RightHand");
        if(photonView.IsMine)
        {
            foreach(var item in GetComponentsInChildren<Renderer>())
            {
                item.enabled = false;
            }
        }
    }

    void Update()
    {
        if(photonView.IsMine)
        {
            MapPosition(head, headRig);
            MapPosition(leftHand, leftHandRig);
            MapPosition(rightHand, rightHandRig);

            float RtriggerValue = RightpinchAnimationAction.action.ReadValue<float>();
            RighthandAnimator.SetFloat("Trigger", RtriggerValue);

            float RgripValue = RightgripAnimationAction.action.ReadValue<float>();
            RighthandAnimator.SetFloat("Grip", RgripValue);

            float LtriggerValue = LeftpinchAnimationAction.action.ReadValue<float>();
            LefthandAnimator.SetFloat("Trigger", LtriggerValue);

            float LgripValue = LeftgripAnimationAction.action.ReadValue<float>();
            LefthandAnimator.SetFloat("Grip", LgripValue);
        }
    }

    void MapPosition(Transform target, Transform rigPos)
    {
        target.position = rigPos.position;
        target.rotation = rigPos.rotation;
    }
}
