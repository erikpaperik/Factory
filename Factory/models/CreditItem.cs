using System;

namespace Factory.models
{
    class CreditItem : Document
    {
        private decimal amount = 5;

        public decimal getAmount() { return amount; }

        public void setAmount(int amount)
        {
            if (amount > 0)
                this.amount = amount;
        }

        public override bool isValid()
        {
            return base.isValid() && (amount > 0);
        }

    }
}
