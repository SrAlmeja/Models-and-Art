using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AnimationActive : MonoBehaviour
{
    public Animator animator;

    public List<Collider> colliders;

    void Start()
    {
        foreach (var item in GetComponentsInChildren<Collider>())
        {
            colliders.Add(item);
            item.AddComponent<ChildCollider>();
        }
    }

    public void ActiveAnimation()
    {
        animator.ResetTrigger("Taunt");
        animator.SetTrigger("BodyBlock");
    }

    public void IdleAgain()
    {
        animator.ResetTrigger("BodyBlock");
        animator.SetTrigger("Taunt");
    }
}
