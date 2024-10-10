using UnityEngine;

public class CactusS : MonoBehaviour
{
    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            animator.SetBool("isAttacking", true);
        }
        if (Input.GetKeyUp(KeyCode.C))
        {
            animator.SetBool("isAttacking", false);
        }

    }
}
