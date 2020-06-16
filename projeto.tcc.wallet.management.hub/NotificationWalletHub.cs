using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Caching.Distributed;
using projeto.tcc.wallet.management.domain.Aggregates.AssetAggregate;
using projeto.tcc.wallet.management.domain.Aggregates.BalanceAggregate;
using projeto.tcc.wallet.management.domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace projeto.tcc.wallet.management.hub
{
    public class NotificationWalletHub : Hub
    {
        private readonly IDistributedCache _cache;
        private readonly IBalanceRepository _userBalance;
        private readonly IAssetRepository _assetRepository;
        private readonly IUnitOfWork _unitOfWork;
        public NotificationWalletHub(IDistributedCache cache, IBalanceRepository userBalance, IAssetRepository assetRepository, IUnitOfWork unitOfWork)
        {
            _cache = cache;
            _userBalance = userBalance;
            _assetRepository = assetRepository;
            _unitOfWork = unitOfWork;
        }


        public override Task OnConnectedAsync()
        {
            //Ao usar o método All eu estou enviando a mensagem para todos os usuários conectados no meu Hub
            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(System.Exception exception)
        {
            return base.OnDisconnectedAsync(exception);
        }


        public async Task GetPatrimonyTransient(string userId, List<DtoOrder> orders)
        {
            var userBalance = await _userBalance.GetBalanceByUserId(Guid.Parse(userId));
           

            foreach (var order in orders)
            {
                var quote = await _cache.GetStringAsync(order.Symbol);
                var asset = await _assetRepository.GetAssetBySymbol(order.Symbol);

                userBalance.SetTransientBalance(asset._startPrice, quote, order.Symbol);
            }

            //_userBalance.Update(_userBalance);

            await _unitOfWork.Commit();
             
            await Clients.All.SendAsync("Balance", userBalance._transientBalance);

            

        }
    }
}