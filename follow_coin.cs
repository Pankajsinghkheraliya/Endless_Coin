using UnityEngine;

public class follow_coin : MonoBehaviour
{
    public Transform coin;
    public Vector3 offset;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = coin.position + offset;
    }
}
