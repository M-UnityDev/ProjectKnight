using UnityEngine;

public class isgnd : MonoBehaviour
{
    private bool isgnds = true;
    public bool isgn()
    {
        return isgnds;
    }
    private void OnTriggerEnter(Collider coll)
    {
        print(coll);
        isgnds = true;
    }
    private void OnTriggerExit(Collider coll)
    {

        print(coll);
        isgnds = false;
    }
}
