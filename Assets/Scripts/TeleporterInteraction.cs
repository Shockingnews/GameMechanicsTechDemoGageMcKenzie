using UnityEngine;

public class TeleporterInteraction : MonoBehaviour, IInteraction
{
    public Transform targetTeleporter;
    [SerializeField] private GameObject Player;
    private CharacterController controller;

    private void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        controller = Player.GetComponent<CharacterController>();
    }
    public void Interact()
    {
        Vector3 test = new Vector3 (targetTeleporter.position.x - Player.transform.position.x, 0f, targetTeleporter.position.z - Player.transform.position.z);
        Debug.Log("hi it's moving");
        controller.Move(test);
        
    }
}
