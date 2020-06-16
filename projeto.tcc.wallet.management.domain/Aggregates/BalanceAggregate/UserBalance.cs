using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using projeto.tcc.wallet.management.domain.Events;
using projeto.tcc.wallet.management.domain.SeedWork;

namespace projeto.tcc.wallet.management.domain.Aggregates.BalanceAggregate
{
    public class UserBalance : Entity, IAggregateRoot
    {
        public Guid _userId { get; private set; }
        public Guid GetUserID => _userId;

        private decimal _totalPatrimony;
        public decimal _transientBalance { get; private set; }


        protected UserBalance()
        {
        }


        public void ExecuteOrderAndCalculateTotalBalance(string symbol, decimal startPrice, int ammount)
        {
            _totalPatrimony -= startPrice * ammount;
            AddDomainEvent(new ExecutingOrderDomainEvent(this._userId, symbol, startPrice, ammount));
        }

        public void SetTransientBalance(decimal startPrice, string quote, string type)
        {
            if (startPrice > decimal.Parse(quote))
            {
                if (type == "sell")
                {
                    this._transientBalance -= (startPrice - decimal.Parse(quote));
                }
                else if (type == "buy")
                {
                    this._transientBalance += (startPrice - decimal.Parse(quote));
                }
            }

            else
            {
                if (type == "sell")
                {
                    this._transientBalance += (startPrice - decimal.Parse(quote));
                }
                else if (type == "buy")
                {
                    this._transientBalance -= (startPrice - decimal.Parse(quote));
                }
            }
        }

        public bool VerifyBalance(decimal startPrice)
        {
            return _totalPatrimony >= startPrice;
        }
        public UserBalance(Guid userId)
        {
            _userId = userId;
        }

    }
}