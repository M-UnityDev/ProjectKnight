using UnityEngine;

public class isgnd : MonoBehaviour
{
    private bool isgnds = false;
    public bool isgn()
    {
        return isgnds;
    }
    private void OnTriggerEnter(Collider coll)
    {
        if(!coll.isTrigger)
        //print(coll);
            isgnds = true;
    }
    private void OnTriggerExit(Collider coll)
    {
        if(!coll.isTrigger)
        //print(coll);
            isgnds = false;
    }
}
