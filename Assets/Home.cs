using UnityEngine;
using UnityEngine.U2D.IK;

public class Home : MonoBehaviour
{
    [SerializeField] private Animator dr;
    [SerializeField] private GameObject outl;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider coll)
    {
        if (coll.isTrigger && coll.CompareTag("Dial"))
        {
            dr.CrossFade("DrRot", 0.1f);
            outl.SetActive(true);
        }
    }
        private void OnTriggerExit(Collider coll)
    {
        if (coll.isTrigger && coll.CompareTag("Dial"))
        {
            dr.CrossFade("DrUnrot", 0.1f);
            outl.SetActive(false);
        }
    }
}
