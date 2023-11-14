using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

namespace InteractiveStorytelling
{
    /// <summary>
    /// Base trigger that provides the basic framework for creating triggers.
    /// </summary>
    public class BaseTrigger : MonoBehaviour
    {
        [Header("Triggered Actions")]
        public List<BaseAction> actions = new List<BaseAction>();
        private List<IAction> internalActions = new List<IAction>();

        [Header("Debug")]
        public bool debug = false;

        protected bool hasTriggered = false;

        public void Start()
        {
            // Convert BaseActions into IActions that are generic.
            foreach (BaseAction action in actions)
            {
                internalActions.Add(action);
            }
        }

        /// <summary>
        /// Adds an action to the internal actions list.
        /// </summary>
        /// <param name="action">Action to be added to the list.</param>
        public void AddAction(IAction action)
        {
            internalActions.Add(action);
        }

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
            foreach (IAction action in internalActions)
            {
                action.PerfomAction(gameObject.name);
            }
        }
    }
}
