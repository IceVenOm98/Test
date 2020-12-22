namespace Terrasoft.Configuration
{
    using System;
    using Terrasoft.Core.Entities;
    using Terrasoft.Core.Entities.Events;

    [EntityEventListener(SchemaName = "Activity")]
    public class CgrActivityEventListener : BaseEntityEventListener
    {
        public override void OnSaving(object sender, EntityBeforeEventArgs e)
        {
            base.OnSaving(sender, e);
            throw new Exception("Test");
        }
    }
}
