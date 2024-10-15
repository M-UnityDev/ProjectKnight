using UnityEngine;
public class Parralax : MonoBehaviour
{
    private float startPos;
    [SerializeField] private GameObject cam;
    [SerializeField] private float parallaxEffect;
    private float dist;
    private Vector3 v;
    private void Awake() => startPos = transform.position.x;
    private void Update() 
    {
        dist = cam.transform.position.x * parallaxEffect;
        v.Set(startPos + dist, transform.position.y, transform.position.z);
        transform.position = v;
    }
}
