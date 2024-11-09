using UnityEngine;
using System.Collections;
using TMPro;
public class MunitTalk : MonoBehaviour
{
    [SerializeField] private string nam;
    [SerializeField] private GameObject vc;
    [SerializeField] private GameObject dil;
    [SerializeField] private string[] wrds;
    [SerializeField] private TMP_Text diltxt;
    [SerializeField] private TMP_Text namtxt;
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
        dil.SetActive(true);
        GameObject.Find("Knight").GetComponent<Movement>().iscut = true;
        namtxt.text = nam;
        GameObject.Find("Knight").GetComponent<Movement>().spd = 0;
        GameObject.Find("Knight").GetComponent<Movement>().jmspd = 0;
        yield return new WaitForSeconds(1f);
        foreach(string a in wrds)
        {
            diltxt.text = null;
            foreach(char c in a)
            {
                diltxt.text += c;
                yield return new WaitForSeconds(0.1f);
            }
            yield return new WaitUntil(() => Input.GetButtonDown("Submit"));
        }
        GameObject.Find("Knight").GetComponent<Movement>().spd = 5;
        GameObject.Find("Knight").GetComponent<Movement>().jmspd = 8;
        GetComponent<Collider>().enabled = false;
        GameObject.Find("Knight").GetComponent<Movement>().iscut = false;
        vc.SetActive(false);
        dil.SetActive(false);
    } 
}
