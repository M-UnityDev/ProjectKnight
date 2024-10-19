using UnityEngine;
using System.Collections;
public class MunitTalk : MonoBehaviour
{
    [SerializeField] private string nam;
    [SerializeField] private GameObject vc;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void StartTalk()
    {
        StartCoroutine(nameof(Talk));
    }
    private IEnumerator Talk()
    {
        vc.SetActive(true);
        GameObject.Find("Knight").GetComponent<Movement>().spd = 0;
        GameObject.Find("Knight").GetComponent<Movement>().jmspd = 0;
        yield return new WaitForSeconds(1f);
        print("Hi!, I'm"+ nam);
    } 
}
