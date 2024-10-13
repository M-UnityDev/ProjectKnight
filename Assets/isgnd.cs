using UnityEngine;

public class isgnd : MonoBehaviour
{
    [SerializeField] private LayerMask lr;
    public bool isgn()
    {
        return Physics.OverlapBox(transform.position, transform.localScale/2, Quaternion.identity, lr).Length != 0;
    }
}
