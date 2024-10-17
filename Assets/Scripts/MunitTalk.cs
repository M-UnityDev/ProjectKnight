using UnityEngine;
using System.Collections;
public class MunitTalk : MonoBehaviour
{
    [SerializeField] private string nam;
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
        yield return new WaitForSeconds(1f);
        print("Hi!, I'm"+ nam);
    } 
}
