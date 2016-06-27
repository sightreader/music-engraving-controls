namespace Manufaktura.Controls.Model.Collections
{
    public class PartStavesCollection : ItemManagingCollection<Staff>
    {
        public PartStavesCollection(Part part)
        {
            this.part = part;
        }

        protected override void BindEvents(Staff item)
        {
        }

        protected override void ManageItemOnAdd(Staff item)
        {
            item.Part = part;
        }

        protected override void ManageItemOnRemove(Staff item)
        {
            item.Part = null;
        }

        protected override void UnbindEvents(Staff item)
        {
        }

        private readonly Part part;
    }
}