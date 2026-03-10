using UnityEngine;
using UnityEngine.InputSystem;

public class InteractionController : MonoBehaviour
{
    [SerializeField] IInteraction interactionObject;
    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out IInteraction interaction))
        {
            interactionObject = interaction;
        }
        //interactionObject = other.GetComponent<TeleporterInteraction>();
        
            
        
    }

    public void OnInteract(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            if (interactionObject != null)
            {
                interactionObject.Interact();
            }
            
                
                
                
                
            


        }

    }
}
