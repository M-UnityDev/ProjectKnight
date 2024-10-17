using UnityEngine;
public class AlwaysZero : MonoBehaviour
{
    private Transform tr;
    private void Awake()
    {
        tr = GetComponent<Transform>();
    }

    private void Update()
    {
        tr.eulerAngles = new Vector3 (0,-90,0);
    }
}
