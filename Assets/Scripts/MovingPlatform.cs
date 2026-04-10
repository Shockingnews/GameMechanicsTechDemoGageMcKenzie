using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Transform TagrgetPos;
    public Transform StartPos;
    

    private Vector3 nextPos;

    private void Awake()
    {
        
        
        nextPos = TagrgetPos.position;
    }

    private void Update()
    {
        

        

            transform.position = Vector3.MoveTowards(transform.position, nextPos, Time.deltaTime * 5f);

            if(transform.position == nextPos)
            {

                
                if(nextPos != TagrgetPos.position)
                {
                    nextPos = TagrgetPos.position;
                }
                else if (nextPos != StartPos.position)
                {
                    nextPos = StartPos.position;
                }
            }


        
    }
}
