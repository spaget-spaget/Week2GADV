using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator animator;
    bool isRunning;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Animation event handler method
    public void HandleFall()
    {
        Debug.Log("Oof! I didn't expect that!");
    }

    private void Update()
    {
        // Example 1: Transition to Running animation
        isRunning = true;
        animator.SetBool("Run", isRunning);

        // Example 2: Trigger the Jump animation
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Jump");
        }

        // Example 3: Trigger the Fall animation
        if (Input.GetKeyDown(KeyCode.F))
        {
            animator.SetTrigger("Fall");
        }
    }
}
