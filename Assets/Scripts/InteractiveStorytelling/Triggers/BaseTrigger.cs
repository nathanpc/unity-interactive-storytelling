using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InteractiveStorytelling
{
    /// <summary>
    /// Base trigger that provides the basic framework for creating triggers.
    /// </summary>
    public class BaseTrigger : MonoBehaviour
    {
        [Header("Triggered Actions")]
        public List<BaseAction> actions = new List<BaseAction>();

        [Header("Debug")]
        public bool debug = false;

        protected bool hasTriggered = false;

        /// <summary>
        /// Method called whenever you want to perform all of the actions
        /// that are associated with this trigger.
        /// </summary>
        public void TriggerAction()
        {
            hasTriggered = true;
            if (debug)
                Debug.Log("Triggered!");

            // Go through the action list and perform each individual action.
            foreach (BaseAction action in actions)
            {
                action.PerfomAction();
            }
        }
    }
}
