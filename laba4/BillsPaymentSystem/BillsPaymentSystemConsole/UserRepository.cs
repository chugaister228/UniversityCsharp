using BillsPaymentSystem.Data;
using BillsPaymentSysytem.Data.Models;
using BillsPaymentSysytem.Data.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace BillsPaymentSystemConsole
{
    public class UserRepository
    {
        private readonly BillsPaymentSystemContext _context;
        public UserRepository(BillsPaymentSystemContext context)
        {
            _context = context;
        }
        public async Task<User> GetUserById(Guid userId)
        {
            var userResult = await _context
                .Set<User>()
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.ID == userId);

            if (userResult is not null) { return userResult; }
            else { throw new NullReferenceException($"The user with {userId} ID was not found!"); }
        }

        public async Task<List<PaymentMethod>> GetPaymentMethodsByUserId(Guid userId)
        {
            var paymentMethodResult = await _context
                .Set<PaymentMethod>()
                .AsNoTracking()
                .Where(x => x.UserId == userId)
                .ToListAsync();

            if (paymentMethodResult is not null) { return paymentMethodResult; }
            else { throw new NullReferenceException($"The user payment method was not found!"); }
        }

        public async Task<BankAccount> GetBankAccountByPaymentMethod(PaymentMethod paymentMethod)
        {
            var bankAccountResult = await _context
                .Set<BankAccount>()
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.ID == paymentMethod.BankAccountId);

            if (bankAccountResult is not null) {  return bankAccountResult; }
            else { throw new NullReferenceException($"The user bank was not found!"); }
        }

        public async Task<CreditCard> GetCreditCardByPaymentMethod(PaymentMethod paymentMethod)
        {
            var creditCardtResult = await _context
                .Set<CreditCard>()
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.ID == paymentMethod.CreditCardId);

            if (creditCardtResult is not null) { return creditCardtResult; }
            else { throw new NullReferenceException($"The user credit card was not found!"); }
        }

        public async Task WithdrawCreditCardById(Guid creditCardId)
        {
            List<CreditCard> creditCards = await _context
                .CreditCards
                .Where(x => x.ID == creditCardId)
                .ToListAsync();

            if(creditCards is not null)
            {
                creditCards.ForEach(x => { 
                    x.MoneyOwed = 0;
                    x.Limit = 0;
                });
            }

            await _context.SaveChangesAsync();
        }

        public async Task DepositBankAccountById(Guid bankAccountId, decimal amount)
        {
            List<BankAccount> bankAccounts = await _context
                .BankAccounts
                .Where(x => x.ID == bankAccountId)
                .ToListAsync();

            if(bankAccounts is not null)
            {
                bankAccounts.ForEach(x => { 
                    x.Balance -= amount; 
                });
            }

            await _context.SaveChangesAsync();
        }

        public async Task PayBills(List<BankAccount> bankAccounts, List<CreditCard> creditCards, decimal amount)
        {
            bool enoughMoney = true;

            if(bankAccounts is not null)
            {
                bankAccounts.ForEach(x => {
                    if (x.Balance >= amount)
                    {
                        x.Balance -= amount;
                    }
                    else
                    {
                        enoughMoney = false;
                    }
                });
            }

            if(creditCards is not null)
            {
                creditCards.ForEach(x => {
                    if(x.Limit >= amount)
                    {
                        x.Limit -= amount;
                    }
                    else
                    {
                        enoughMoney = false;
                    }
                });
            }

            if (enoughMoney)
            {
                await _context.SaveChangesAsync();
            }
        }
    }
}
