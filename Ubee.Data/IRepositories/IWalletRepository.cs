using Ubee.Domain.Entities;

namespace Ubee.Data.IRepositories;

public interface IWalletRepsistory
{
    ValueTask<Wallet> InsertWalletAsync(Wallet wallet);
    ValueTask<Wallet> UpdateWalletAsync(Wallet wallet);
    ValueTask<bool> DeleteWalletAysnyc(long id);
    ValueTask<Wallet> SelectWalletById(long id);
    IQueryable<Wallet> SelectAllWallets();
}
