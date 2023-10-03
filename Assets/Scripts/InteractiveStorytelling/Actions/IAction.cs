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
        public void PerfomAction();
    }
}
