using UnityEngine;

public class AttachPlayer : MonoBehaviour
{
    public GameObject player;
    //public GameObject platform;
    public float fixedScale = 1;
    bool onPlatform;
    [SerializeField] CharacterController controller;
    public GameObject[] walls;

    private void Awake()
    {
        controller = player.GetComponent<CharacterController>();
    }

    private void Update()
    {
        //player.transform.localScale = new Vector3(fixedScale, fixedScale , fixedScale );
        //if (onPlatform)
        //{
        //    player.transform.position -= platform.transform.position;
        //}
        
        

    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            controller.transform.SetParent(gameObject.transform);
            for (int i = 0; i < walls.Length; i++)
            {
                walls[i].SetActive(true);
            }
            onPlatform = true;
        }

        


    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            player.transform.SetParent(null);
            for (int i = 0; i < walls.Length; i++)
            {
                walls[i].SetActive(false);
            }
            onPlatform = false;
        }
            
    }


}
