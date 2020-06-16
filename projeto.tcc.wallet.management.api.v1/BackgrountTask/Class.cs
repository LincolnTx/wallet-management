//using Microsoft.Extensions.Caching.Distributed;
//using Microsoft.Extensions.Hosting;
//using projeto.tcc.wallet.management.domain.Aggregates.BalanceAggregate;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading;
//using System.Threading.Tasks;

//namespace projeto.tcc.wallet.management.api.v1.BackgrountTask
//{
//    public class Class : BackgroundService
//    {
//        private readonly IDistributedCache _cache;
//        private readonly IBalanceRepository _userBalance;

//        public Class(IDistributedCache cache, IBalanceRepository userBalance)
//        {
//            _cache = cache;
//            _userBalance = userBalance;
//        }

//        protected override Task ExecuteAsync(CancellationToken stoppingToken)
//        {
//            _userBalance.GetBalanceByUserId()
//        }
//    }
