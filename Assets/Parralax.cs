using UnityEngine;

public class Parralax : MonoBehaviour
{
    private float startPos, length;
    [SerializeField] private GameObject cam;
    [SerializeField] private float parallaxEffect;
    private float temp;
    private float dist;
    private void Awake() 
    {
        length   = (GetComponent<SpriteRenderer>().bounds.size.x-10)*3;
        startPos = transform.position.x;
    }
    private void Update() 
    {
        temp = cam.transform.position.x * (1 - parallaxEffect);
        dist = cam.transform.position.x * parallaxEffect;
        transform.position = new Vector3(startPos + dist, transform.position.y, transform.position.z);
/*         if (temp > startPos + length)
            startPos += length;
        else if (temp < startPos - length)
            startPos -= length; */
    }
}
