using System.Collections.ObjectModel;

namespace KeLi.HelloTableLayoutPanel.Models
{
    public class StudentPropertyCollection : KeyedCollection<string, StudentProperty>
    {
        protected override string GetKeyForItem(StudentProperty item)
        {
            return item.PropertyName;
        }
    }
}