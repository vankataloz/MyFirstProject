using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    // Update is called once per frame
    void Update()
    {
        //Всеки фрейм ще изкарва съобщение в конзолата на каква позиция се намира в момента
        //Debug.Log(player.position);
        transform.position = player.position + offset;
    }
}
