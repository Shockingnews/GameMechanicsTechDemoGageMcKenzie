using UnityEngine;
using UnityEngine.InputSystem;

public class CheckPoint : MonoBehaviour
{
    [SerializeField] GameObject player;
    private Transform saveStatePos;
    CharacterController controller;
    [SerializeField] bool currentCheckPoint = false;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        controller = player.GetComponent<CharacterController>();
    }
    public void OnTriggerEnter(Collider other)
    {
        saveStatePos = gameObject.transform;
        //saveStatePos.position = player.transform.position;
        
    }


    public void OnTriggerExit(Collider other)
    {
        
    }
    void Update()
    {
        if (controller.transform.position.y < -5f)
        {
            Vector3 test = saveStatePos.position - controller.transform.position;
            

            controller.Move(test);
            
        }
    }

    public void OnDeath()
    {
        Vector3 test = new Vector3(saveStatePos.position.x - player.transform.position.x, 0f, saveStatePos.position.z - player.transform.position.z);

        controller.Move(test);
    }

}
