using UnityEngine;
using UnityEngine.InputSystem;

public class CheckPoint : MonoBehaviour
{
    [SerializeField] GameObject player;
    private Transform saveStatePos;

    public void OnTriggerEnter()
    {
        saveStatePos.position = player.transform.position;

    }




}
