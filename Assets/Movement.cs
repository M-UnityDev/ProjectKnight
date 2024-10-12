using UnityEngine;
using System.Collections;
public class Movement : MonoBehaviour
{
    private Rigidbody rb;
    private Animator an;
    [SerializeField] private int spd;
    [SerializeField] private GameObject rotob;
    private Vector3 newpos;
    private float h;
    private Vector3 v;
    private float angl = 0;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        an = GetComponent<Animator>();
        an.CrossFade("Idle",1);
    }
    private void Update()
    {
        h = Input.GetAxisRaw("Horizontal");
        v.Set(h*spd,rb.position.y,rb.position.z);
        rb.linearVelocity = v;
        an.SetBool("iswak",Input.GetAxisRaw("Horizontal") != 0);
        if (h > 0)
            angl = 0;
        else if (h < 0)
            angl = 180;
    }
    private void FixedUpdate()
    {
        newpos.Set(rotob.transform.localEulerAngles.x, angl, rotob.transform.localEulerAngles.z);
        rotob.transform.localEulerAngles = Vector3.Lerp(rotob.transform.localEulerAngles, newpos,Time.deltaTime * 5);
    }
}
