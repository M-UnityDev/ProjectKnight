using UnityEngine;
using System.Collections;
public class Movement : MonoBehaviour
{
    private Rigidbody rb;
    private Animator an;
    [SerializeField] private int spd;
    [SerializeField] private GameObject rotob;
    private Vector3 newpos;
    private bool islft;
    private Vector3 v;
    float zov = 0;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        an = GetComponent<Animator>();
        an.CrossFade("Idle",1);
    }
    private void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        v.Set(h*spd,rb.position.y,rb.position.z);
        rb.linearVelocity = v;
        an.SetBool("iswak",Input.GetAxisRaw("Horizontal") != 0);
        
        if (h > 0)
            zov = 0;
        else if (h < 0)
            zov = 180;
        newpos.Set(rotob.transform.localEulerAngles.x, zov, rotob.transform.localEulerAngles.z);

    }
    private void FixedUpdate()
    {
        rotob.transform.localEulerAngles = Vector3.Lerp(rotob.transform.localEulerAngles, newpos,Time.deltaTime * 5);
    }
}
