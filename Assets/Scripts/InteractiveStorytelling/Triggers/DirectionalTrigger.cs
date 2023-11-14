using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InteractiveStorytelling
{
    public class DirectionalTrigger : BaseTrigger, IAction
    {
        [Header("Triggers")]
        public RadiusTrigger trigger1;
        public RadiusTrigger trigger2;

        [Header("Directional Actions")]
        public List<BaseAction> forwardActions = new List<BaseAction>();
        public List<BaseAction> backwardActions = new List<BaseAction>();

        private RadiusTrigger previousTrigger = null;

        // Start is called before the first frame update
        void Start()
        {
            // Ensures that BaseTrigger.Start() gets called.
            base.Start();

            trigger1.AddAction(this);
            trigger2.AddAction(this);
        }

        public void PerfomAction(string triggerName)
        {
            // Get the trigger associated with the name.
            RadiusTrigger currentTrigger = GetTriggerByName(triggerName);

            if (debug)
                Debug.Log("Apparetly we were triggered by " + triggerName);

            // Check if we have already triggered previously and detect direction.
            if ((previousTrigger != null) && (currentTrigger != previousTrigger))
            {
                if ((previousTrigger == trigger1) && (currentTrigger == trigger2))
                {
                    if (debug)
                        Debug.Log("We are going forwards!");

                    // Trigger the forward actions.
                    foreach (BaseAction action in forwardActions)
                    {
                        action.PerfomAction("Forward");
                    }
                }
                else
                {
                    if (debug)
                        Debug.Log("We are going backwards!");

                    // Trigger the backward actions.
                    foreach (BaseAction action in backwardActions)
                    {
                        action.PerfomAction("Backward");
                    }
                }
            }

            // Update which trigger was the previous one.
            previousTrigger = currentTrigger;
        }

        /// <summary>
        /// Gets a trigger object by its GameObject name.
        /// </summary>
        /// <param name="name">GameObject name associated with the trigger.</param>
        /// <returns>Trigger associated with the name.</returns>
        private RadiusTrigger GetTriggerByName(string name)
        {
            if (trigger1.gameObject.name == name)
            {
                return trigger1;
            }
            else
            {
                return trigger2;
            }
        }
    }
}
