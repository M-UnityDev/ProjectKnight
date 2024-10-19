using UnityEngine;

public class Trigmgr : MonoBehaviour
{
    private void OnTriggerEnter(Collider coll)
    {
        if (coll.isTrigger)
        {

            switch (coll.tag)
            {
                case "Munit":
                    coll.gameObject.GetComponent<MunitTalk>().StartTalk();
                    break;

            }
        }
    }
}
