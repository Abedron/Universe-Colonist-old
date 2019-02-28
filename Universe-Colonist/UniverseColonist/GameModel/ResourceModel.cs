using System;
using System.Reflection;
using Game.Articles;
using Game.DataModel.Runtime;

namespace Game.GameModel
{
    public class ResourceModel
    {
        private IResourceData ResourceData { get; }

        public ResourceModel(IResourceData resourceData)
        {
            ResourceData = resourceData;
        }

        public int GetCurrentMoney(ResourceType currencyType)
        {
            PropertyInfo property = ResourceData.GetType().GetProperty(currencyType.ToString());
            if (property == null)
            {
                return 0;
            }

            return (int) property.GetValue(ResourceData);
        }

        public void AddMoney(ResourceType currencyType, int value)
        {
            PropertyInfo propertyInfo = ResourceData.GetType().GetProperty(currencyType.ToString());
            if (propertyInfo == null)
            {
                return;
            }

            int currentValue = (int) propertyInfo.GetValue(ResourceData);
            int newValue = currentValue + value;

            propertyInfo.SetValue(ResourceData, Convert.ChangeType(newValue, propertyInfo.PropertyType), null);
        }

        public bool TryDrawMoney(ResourceType currencyType, int value)
        {
            PropertyInfo propertyInfo = ResourceData.GetType().GetProperty(currencyType.ToString());
            if (propertyInfo == null)
            {
                return false;
            }

            int currentValue = (int) propertyInfo.GetValue(ResourceData);
            int newValue = currentValue - value;
            if (newValue < 0 || value == 0)
            {
                return false;
            }

            propertyInfo.SetValue(ResourceData, Convert.ChangeType(newValue, propertyInfo.PropertyType), null);

            return true;
        }
    }
}