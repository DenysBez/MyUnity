using UnityEngine;

public class CharacterAnimationCaller : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        float speed = Input.GetKey(KeyCode.A) ? 1f : 0f;
        animator.SetFloat("Speed", speed);
    }
}