using UnityEngine;

public class Trigmgr : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
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
