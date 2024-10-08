using UnityEngine;
using System.Collections;
public class Movement : MonoBehaviour
{
    private Rigidbody rb;
    private Animator an;
    [SerializeField] private int spd;
    private Vector3 v;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        an = GetComponent<Animator>();
        an.CrossFade("Idle",1);
    }
    private void Update()
    {
        v.Set(Input.GetAxisRaw("Horizontal")*spd,rb.position.y,rb.position.z);
        rb.linearVelocity = v;
        an.SetBool("iswak",Input.GetAxisRaw("Horizontal") != 0);
    }
}
