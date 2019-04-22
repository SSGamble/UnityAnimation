using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private Animator animator;

    // 将字符串转换成 ID，每次写字符串容易出错
    private int speedAnimID = Animator.StringToHash("Speed");
    private int isSpeedUPID = Animator.StringToHash("IsSpeedUP");
    private int horizontalID = Animator.StringToHash("Horizontal");

    private bool isSpeedUP = false; // 是否加速

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        animator.SetFloat(speedAnimID, Input.GetAxisRaw("Vertical"));
        animator.SetFloat(horizontalID, Input.GetAxisRaw("Horizontal"));
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            animator.SetBool(isSpeedUPID, true);
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            animator.SetBool(isSpeedUPID, false);
        }
    }
}
