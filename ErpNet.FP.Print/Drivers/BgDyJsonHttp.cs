﻿using System;
using ErpNet.FP.Core;

namespace ErpNet.FP.Drivers
{
    /// <summary>
    /// Implements the Bulgarian Daisy Json over http driver.
    /// </summary>
    /// <seealso cref="_ErpNet.FP.IFiscalPrinter" />
    public class BgDyJsonHttp : IFiscalPrinter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BgDyJsonHttp"/> class.
        /// </summary>
        /// <param name="httpUrl">The HTTP URL.</param>
        public BgDyJsonHttp(string httpUrl, PrintOptions options)
        {
            //...

        }



        public DeviceInfo GetDeviceInfo()
        {
            throw new NotImplementedException();
        }

        public bool IsReady()
        {
            throw new NotImplementedException();
        }

        public PrintInfo PrintReversalReceipt(Receipt reversalReceipt)
        {
            throw new NotImplementedException();
        }

        public void SetupPrinter()
        {
            throw new NotImplementedException();
        }

        PrintInfo IFiscalPrinter.PrintMoneyDeposit(decimal amount)
        {
            throw new NotImplementedException();
        }

        PrintInfo IFiscalPrinter.PrintMoneyWithdraw(decimal amount)
        {
            throw new NotImplementedException();
        }

        PrintInfo IFiscalPrinter.PrintReceipt(Receipt receipt)
        {
            throw new NotImplementedException();
        }

        PrintInfo IFiscalPrinter.PrintZeroingReport()
        {
            throw new NotImplementedException();
        }
    }
}
