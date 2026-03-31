using UnityEngine;

public class DoorScript : MonoBehaviour
{
    [SerializeField]
    Transform _doorGfx;

    [SerializeField]
    Vector3 _closedPos;
    [SerializeField]
    Vector3 _openPos;
    Vector3 _targetPos;

    bool _isOpening;
    bool _isClosing;

    float _speed = 10;

    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!_isOpening && !_isClosing) return;
        if (_isOpening)
        {
            _targetPos = _openPos;
           
        }
        else if (_isClosing)
        {
            _targetPos = _closedPos;
            
        }
        _doorGfx.transform.localPosition = Vector3.MoveTowards(current: _doorGfx.transform.localPosition, target: _targetPos, _speed * Time.deltaTime);

        if (Vector3.Distance(a: _doorGfx.transform.localPosition, b: _targetPos) <= 0.001f)
        {
            _isOpening = false;
            _isClosing = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _isOpening = true;
            _isClosing = false;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _isOpening = false;
            _isClosing = true;
        }
    }
}
