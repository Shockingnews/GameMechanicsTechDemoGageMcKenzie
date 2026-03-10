using UnityEngine;

public class TeleporterInteraction : MonoBehaviour, IInteraction
{
    public Transform targetTeleporter;
    [SerializeField] private GameObject Player;
    private CharacterController controller;

    private void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }
    public void Interact()
    {
        Debug.Log("hi it's moving");
        Player.transform.position = targetTeleporter.position;
    }
}
