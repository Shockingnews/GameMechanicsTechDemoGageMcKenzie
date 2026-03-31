using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject cube;
    public Transform placement;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Instantiate(cube, placement.position,placement.rotation);
    }
}
