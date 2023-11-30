using UnityEngine;

public class ExperienceOrbs : MonoBehaviour
{
    public Transform player; // Drag and drop the player's GameObject here
    public float attractionSpeed = 5f;

    void Update()
    {
        if (player != null)
        {
            Vector3 directionToPlayer = player.position - transform.position;
            float distanceToPlayer = directionToPlayer.magnitude;

            if (distanceToPlayer < 1.5f) // Adjust the radius for attraction
            {
                float speed = Mathf.Lerp(0, attractionSpeed, 1 - (distanceToPlayer / 5f));
                transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
            }
        }
    }
}
