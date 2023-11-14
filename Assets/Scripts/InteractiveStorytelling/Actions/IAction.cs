namespace InteractiveStorytelling
{
    /// <summary>
    /// Base interface of an action in the interactive storytelling framework.
    /// </summary>
    public interface IAction
    {
        /// <summary>
        /// Method that gets called whenever a trigger need an action to be
        /// performed.
        /// </summary>
        /// <param name="triggerName">Name of the trigger that triggered
        /// this action.</param>
        public void PerfomAction(string triggerName);
    }
}
