using UnityEngine;
using System.Collections;
public class Movement : MonoBehaviour
{
    private Rigidbody rb;
    private Animator an;
    [SerializeField] private int spd;
    [SerializeField] private int jmspd;
    [SerializeField] private GameObject rotob;
    private BoxCollider coll;
    [SerializeField] private SkinnedMeshRenderer skcoll;
    private Vector3 newpos;
    private float h;
    private float hv;
    private Vector3 v;
    private Vector3 vb;
    private Vector3 vbh;
    private Vector3 vbha;
    [SerializeField] private float of;
    [SerializeField] private Mesh mh;
    private float angl = 0;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        an = GetComponent<Animator>();
        coll = GetComponent<BoxCollider>();
        an.CrossFade("Idle",0);
        //Time.timeScale = 0.1f;
    }
    private void Update()
    {
        skcoll.BakeMesh(mh);
        vb.Set(mh.bounds.center.x, mh.bounds.center.y+of, mh.bounds.center.z);
        vbh.Set(mh.bounds.center.x, (-mh.bounds.size.y/2)+mh.bounds.center.y + of+0.001f, mh.bounds.center.z);
        vbha.Set(mh.bounds.size.x, mh.bounds.size.y, mh.bounds.size.z-1);
        coll.size = vbha;
        coll.center = vb;
        //rotob.GetComponent<BoxCollider>().center = vbh;
        //h = rotob.GetComponent<isgnd>().isgn() ? Input.GetAxisRaw("Horizontal") : rb.linearVelocity.x/spd;
        h = Input.GetAxisRaw("Horizontal");
        hv = rotob.GetComponent<isgnd>().isgn() ? Input.GetAxisRaw("Horizontal") : 0;
        if(rotob.GetComponent<isgnd>().isgn() && Input.GetButtonDown("Jump"))
        {
            rb.linearVelocity = Vector3.up * jmspd;
            an.CrossFade("Jmp",1);
        }
        an.SetBool("iswak",h != 0);
        v.Set(h*spd,rb.linearVelocity.y,0);
        rb.linearVelocity = v;
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
