using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InteractiveStorytelling
{
    public class RadiusTrigger : BaseTrigger
    {
        [Header("Trigger Parameters")]
        public GameObject trackedObject;
        public float interactionRange = 1.5f;

        private Vector3 triggerPosition;

        // Start is called before the first frame update
        void Start()
        {
            // Ensures that BaseTrigger.Start() gets called.
            base.Start();

            // Gets the initial position of the trigger since it won't
            // move and by doing this you are getting a bit more performance.
            //
            // WARNING: If you want your trigger position to move you must
            // rewrite this.
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
                trackedObject.transform.position);
            if (debug)
                Debug.Log(distance);

            // Check if the player has "collided" with the trigger.
            if (distance <= interactionRange)
            {
                TriggerAction();
            }
        }
    }
}
