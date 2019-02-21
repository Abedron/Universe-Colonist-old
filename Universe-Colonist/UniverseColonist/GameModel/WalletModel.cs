using System;
using System.Reflection;
using Game.Configurations;
using Game.DataModel.Runtime;

namespace Game.GameModels
{
    public class WalletModel
    {
        private IWallet WalletData { get; }

        public WalletModel(IWallet walletData)
        {
            WalletData = walletData;
        }

        public int GetCurrentMoney(CurrencyType currencyType)
        {
            PropertyInfo property = WalletData.GetType().GetProperty(currencyType.ToString());
            if (property == null)
            {
                return 0;
            }

            return (int) property.GetValue(WalletData);
        }

        public void AddMoney(CurrencyType currencyType, int value)
        {
            PropertyInfo propertyInfo = WalletData.GetType().GetProperty(currencyType.ToString());
            if (propertyInfo == null)
            {
                return;
            }

            int currentValue = (int) propertyInfo.GetValue(WalletData);
            int newValue = currentValue + value;

            propertyInfo.SetValue(WalletData, Convert.ChangeType(newValue, propertyInfo.PropertyType), null);
        }

        public bool TryDrawMoney(CurrencyType currencyType, int value)
        {
            PropertyInfo propertyInfo = WalletData.GetType().GetProperty(currencyType.ToString());
            if (propertyInfo == null)
            {
                return false;
            }

            int currentValue = (int) propertyInfo.GetValue(WalletData);
            int newValue = currentValue - value;
            if (newValue < 0 || value == 0)
            {
                return false;
            }

            propertyInfo.SetValue(WalletData, Convert.ChangeType(newValue, propertyInfo.PropertyType), null);

            return true;
        }
    }
}