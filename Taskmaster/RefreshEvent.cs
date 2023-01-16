namespace Taskmaster
{
    public static class RefreshEvent
    {
        public static event EventHandler RefreshNeeded;
        public static void RaiseRefreshEvent(object sender, EventArgs args)
        {
            var handler = RefreshNeeded;
            if (handler != null)
            {
                handler(sender, args);
            }
        }
    }
}
