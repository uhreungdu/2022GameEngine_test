using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IKHand : MonoBehaviour
{
    public Animator _Animator;

    public Transform HandPos;
    // Start is called before the first frame update
    void Start()
    {
        _Animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnAnimatorIK(int layerIndex)
    {
        _Animator.SetIKPositionWeight(AvatarIKGoal.RightHand,1);
        _Animator.SetIKPosition(AvatarIKGoal.RightHand,HandPos.position);
        _Animator.SetIKRotationWeight(AvatarIKGoal.RightHand, 1);
        _Animator.SetIKRotation(AvatarIKGoal.RightHand,HandPos.rotation);
    }
}
