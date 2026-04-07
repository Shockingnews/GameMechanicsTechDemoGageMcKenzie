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
        

        if (atStart == false)
        {
            while(atStart == false)
            {
            transform.position = Vector3.Lerp(TagrgetPos.position, StartPos.position, Time.deltaTime * 5);
                if (StartPos.position == gameObject.transform.position)
                {
                    atStart = true;
                }
            }
        }
        if (TagrgetPos.position != gameObject.transform.position)
        {
            transform.position = Vector3.Lerp(StartPos.position, TagrgetPos.position, Time.deltaTime * 1.5f);
        }

        if (TagrgetPos.position == gameObject.transform.position)
        {
            atStart = false;
            while (atStart == false)
            {
                transform.position = Vector3.Lerp(TagrgetPos.position, StartPos.position, Time.deltaTime * 5);
                if (StartPos.position == gameObject.transform.position)
                {
                    atStart = true;
                }
            }
        }
    }
}
