using TMPro;
using UnityEngine;
public class Trigmgr : MonoBehaviour
{
    [SerializeField] private TMP_Text cutxt;
    private void OnTriggerEnter(Collider coll)
    {
        if (coll.isTrigger)
        {

            switch (coll.tag)
            {
                case "Munit":
                    coll.gameObject.GetComponent<MunitTalk>().StartTalk();
                    break;
                case "cub":
                    Destroy(coll.gameObject);
                    PlayerPrefs.SetInt("Cube",PlayerPrefs.GetInt("Cube",0)+1);
                    cutxt.text = PlayerPrefs.GetInt("Cube",0).ToString()+"/7";
                    break;
            }
        }
    }
}
