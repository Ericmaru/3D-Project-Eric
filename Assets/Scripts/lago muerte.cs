using UnityEngine;

public class lagomuerte : MonoBehaviour
{

    private LayerController _player;

    void Awake()
    {
        _player = GameObject.FindWithTag("Player").GetComponent<LayerController>();
    }

    void OntTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            _player.Death();   
        }
    }
}
