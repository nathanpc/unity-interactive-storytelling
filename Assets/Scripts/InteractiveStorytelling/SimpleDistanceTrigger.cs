using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SimpleDistanceTrigger : MonoBehaviour
{
    public GameObject player;
    public float interactionRange = 0.5f;

    public GameObject cube;

    private Vector3 triggerPosition;
    private bool hasTriggered = false;

    // Start is called before the first frame update
    void Start()
    {
        // Gets the initial position of the trigger since it won't
        // move and by doing this you are getting a bit more performance.
        triggerPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // If I've triggered, ignore everything below me.
        if (hasTriggered)
            return;

        // Gets the distance between the player and the trigger.
        float distance = Vector3.Distance(triggerPosition,
            player.transform.position);
        Debug.Log(distance);

        // Check if the player has "collided" with the trigger.
        if (distance <= interactionRange)
        {
            hasTriggered = true;
            Debug.Log("Triggered!");
            TriggerAction();
        }
    }

    private void TriggerAction()
    {
        cube.SetActive(true);
    }
}
