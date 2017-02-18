using System;

namespace Factory.models
{
    abstract class Document
    {
        private int receiptNo = 1;

        public int getReceiptNo() { return receiptNo; }

        public void setReceiptNo(int receiptNo)
        {
            if (receiptNo > 0)
                this.receiptNo = receiptNo;
        }
        public virtual bool isValid()
        {
            return receiptNo > 0;
        }
    }
}
