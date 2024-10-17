using UnityEngine;
using System.Collections;
using TMPro;

public class TextWrither : MonoBehaviour
{
    [SerializeField] private string s;
    [SerializeField] private TMP_Text tx;

    [SerializeField] private AudioClip ad;
    [SerializeField] private AudioSource au;

    void Start()
    {
        StartCoroutine(nameof(WriteText));
    }
    public void WritText(string text)
    {
        s = text;
        StartCoroutine(nameof(WriteText));
    }
    // Update is called once per frame
    void Update()
    {
    }
    private IEnumerator WriteText()
    {
        tx.text = null;
        tx.text += "<size=100><color=#ff0000>";
        foreach(char c in s)
        {
            yield return new WaitForSeconds(0.05f);
            //tx.text = tx.text.Replace("<size=25>","<size=50>");
            tx.text = tx.text.Replace("<color=#00000032>","<color=#0000007D>");
            yield return new WaitForSeconds(0.05f);
            //tx.text = tx.text.Replace("<size=50>","<size=75>");
            tx.text = tx.text.Replace("<color=#0000007D>","<color=#000000AF>");
            yield return new WaitForSeconds(0.05f);
            //tx.text = tx.text.Replace("<size=75>","<size=100>");
            tx.text = tx.text.Replace("<color=#000000AF>","<color=#000000FF>");
            if(tx.text != "<size=100><color=#ff0000>")
                tx.text += "<color=#0000007D>"+c;
            else
                tx.text += c+"<color=#000000>";
        }
        yield return new WaitForSeconds(0.1f);
        //tx.text = tx.text.Replace("<size=25>","<size=50>");
        tx.text = tx.text.Replace("<color=#00000032>","<color=#0000007D>");
        yield return new WaitForSeconds(0.1f);
        //tx.text = tx.text.Replace("<size=50>","<size=75>");
        tx.text = tx.text.Replace("<color=#0000007D>","<color=#000000AF>");
        yield return new WaitForSeconds(0.1f);
        //tx.text = tx.text.Replace("<size=75>","<size=100>");
        tx.text = tx.text.Replace("<color=#000000AF>","<color=#000000FF>");
    }
}
