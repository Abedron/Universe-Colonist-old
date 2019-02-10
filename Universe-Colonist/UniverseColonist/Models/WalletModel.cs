using System.Reflection;
using Game.Configurations;
using Game.PlayDataService;

namespace Game.Models
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
    }
}