using UnityEngine;

public class DistanceController : MonoBehaviour
{
    public Transform target1;
    public Transform target2;

    public Animator cactus1Animator;
    public Animator cactus2Animator;

    public float attackDistance = 0.25f;

    void Update()
    {
        if (target1 != null && target2 != null && cactus1Animator != null && cactus2Animator != null)
        {
            float currentDistance = Vector3.Distance(target1.position, target2.position);

            if (currentDistance < attackDistance)
            {
                cactus1Animator.SetBool("isAttacking", true);
                cactus2Animator.SetBool("isAttacking", true);
            }
            else
            {
                cactus1Animator.SetBool("isAttacking", false);
                cactus2Animator.SetBool("isAttacking", false);
            }
        }
    }
}