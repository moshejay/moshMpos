//seeing how this gets added
using Microsoft.WindowsAzure.Mobile.Service;

namespace mosheMposService.DataObjects
{
    public class TodoItem : EntityData
    {
        public string Text { get; set; }

        public bool Complete { get; set; }
    }
}