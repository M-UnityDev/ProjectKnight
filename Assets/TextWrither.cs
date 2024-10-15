using UnityEngine;
using System.Collections;
using TMPro;

public class TextWrither : MonoBehaviour
{
    [SerializeField] private string s;
    [SerializeField] private TMP_Text tx;
    [SerializeField] private AudioClip aud;
    [SerializeField] private AudioClip ad;
    [SerializeField] private AudioSource au;

    void Start()
    {
        StartCoroutine(nameof(WriteText));
    }

    // Update is called once per frame
    void Update()
    {
        au.PlayOneShot(ad);
        au.PlayOneShot(aud);
    }
    private IEnumerator WriteText()
    {
        foreach(char c in s)
        {
            yield return new WaitForSeconds(0.1f);
            tx.text += "<size=50>"+c;
        }
    }
}
