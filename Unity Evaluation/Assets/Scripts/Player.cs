using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Stats")]
    [SerializeField] private float walkSpeed;
    [SerializeField] private float boostSpeed;
    [SerializeField] private bool boost;

    [Space(20)]
    [Header("Components")]
    [SerializeField] private Transform corps;
    [SerializeField] private CharacterController controller;
    [SerializeField] private Animator animator;
    [SerializeField] private Manager manager;

    [Space(20)]
    [Header("Effects")]
    public TrailRenderer boost1, boost2;

    private Vector3 direction;
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        direction = new Vector3(horizontal, 0f, vertical);

        if (direction.magnitude >= 0.1f)
        {
            animator.SetBool("Mooving", true);

            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
            Quaternion rotation = Quaternion.Euler(0f, targetAngle, 0f);
            corps.rotation = rotation;
        }
        else animator.SetBool("Mooving", false);
    }

    private void FixedUpdate()
    {
        if (boost) controller.Move(direction * boostSpeed);
        else controller.Move(direction * walkSpeed);
    }

    public IEnumerator ActiveBoost()
    {
        boost = true;
        boost1.time = 0.4f;
        boost2.time = 0.4f;
        animator.SetBool("Boost", true);
        yield return new WaitForSeconds(3);
        boost = false;
        boost1.time = 0;
        boost2.time = 0;
        animator.SetBool("Boost", false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Boost"))
        {
            Destroy(other.gameObject);
            StartCoroutine(ActiveBoost());
        }

        if (other.CompareTag("Cheese"))
        {
            Destroy(other.gameObject);
            manager.AddPoint();
        }
    }
}
