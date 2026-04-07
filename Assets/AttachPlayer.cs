using UnityEngine;

public class AttachPlayer : MonoBehaviour
{
    public GameObject player;
    public float fixedScale = 1;

    private void Update()
    {
        player.transform.localScale = new Vector3(fixedScale, fixedScale , fixedScale );
    }

    private void OnTriggerEnter(Collider other)
    {
        player.transform.SetParent(gameObject.transform);
        
    }
    private void OnTriggerExit(Collider other)
    {
        player.transform.SetParent(null);
    }


}
