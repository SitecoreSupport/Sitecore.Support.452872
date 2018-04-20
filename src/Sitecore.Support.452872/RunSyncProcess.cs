namespace Sitecore.Support.Buckets.Pipelines.BucketOperations.SyncBucket
{
  using Sitecore.Buckets.Pipelines.BucketOperations.SyncBucket;
  using Sitecore.Common;
  using Sitecore.Data.Events;
  using Sitecore.Data.Items;

  public class RunSyncProcess : Sitecore.Buckets.Pipelines.BucketOperations.SyncBucket.RunSyncProcess
  {
    protected override Item CreateAndReturnDateFolderDestination(Item topParent, Item itemToMove)
    {
      Switcher<EventDisablerState, EventDisabler>.Enter(EventDisablerState.Disabled);
      Item item = base.CreateAndReturnDateFolderDestination(topParent, itemToMove);
      Switcher<EventDisablerState, EventDisabler>.Enter(EventDisablerState.Enabled);
      return item;
    }
  }
}
