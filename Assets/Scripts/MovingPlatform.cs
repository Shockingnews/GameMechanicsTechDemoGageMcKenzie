using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Transform TagrgetPos;
    private Transform StartPos;
    bool atStart;

    private void Start()
    {
        StartPos = gameObject.transform;
    }

    private void Update()
    {
        if(TagrgetPos.position != gameObject.transform.position)
        {

        }

        else if (atStart == false)
        {

        }

        if(TagrgetPos.position == gameObject.transform.position)
        {
            atStart = false;
        }
    }
}
