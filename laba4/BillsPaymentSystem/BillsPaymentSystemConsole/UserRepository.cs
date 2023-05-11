using BillsPaymentSystem.Data;
using BillsPaymentSysytem.Data.Models;
using BillsPaymentSysytem.Data.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public async Task<PaymentMethod> GetPaymentMethodByUserId(Guid userId)
        {
            var paymentMethodResult = await _context
                .Set<PaymentMethod>()
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.UserId == userId);

            if (paymentMethodResult is not null) { return paymentMethodResult; }
            else { throw new NullReferenceException($"The user payment method was not found!"); }
        }

        public async Task<BankAccount> GetBankAccountByUserId(Guid userId)
        {
            var paymentMethodResult = await GetPaymentMethodByUserId(userId);

            Guid bankAccountId = Guid.Empty;
            if (paymentMethodResult is not null) { bankAccountId = paymentMethodResult.BankAccountId; }

            var bankAccountResult = await _context
                .Set<BankAccount>()
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.ID == bankAccountId);

            if (bankAccountResult is not null) {  return bankAccountResult; }
            else { throw new NullReferenceException($"The user bank was not found!"); }
        }

        public async Task<CreditCard> GetCreditCardByUserId(Guid userId)
        {
            var paymentMethodResult = await GetPaymentMethodByUserId(userId);

            Guid creditCardId = Guid.Empty;
            if (paymentMethodResult is not null) { creditCardId = paymentMethodResult.CreditCardId; }

            var creditCardtResult = await _context
                .Set<CreditCard>()
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.ID == creditCardId);

            if (creditCardtResult is not null) { return creditCardtResult; }
            else { throw new NullReferenceException($"The user credit card was not found!"); }
        }
    }
}
