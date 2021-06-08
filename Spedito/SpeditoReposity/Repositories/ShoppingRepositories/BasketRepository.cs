using Microsoft.EntityFrameworkCore;
using SpeditoReposity.Data;
using SpeditoReposity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpeditoReposity.Repositories.ShoppingReposities
{
    public interface IBasketRepository
    {
        IEnumerable<Basket> GetBasketByToken(string token);
        Basket CreateBasket(Basket basket);
        Basket GetBasketByProductAndToken(int productId, string token);
        void ChangeCount(Basket basketItem, int count);
        void UpdateBasketsToken(string guestToken, string userToken);
    }

    public class BasketRepository : IBasketRepository
    {
        private readonly SpeditoDbContext _context;
        public BasketRepository(SpeditoDbContext context)
        {
            _context = context;
        }

        public void ChangeCount(Basket basketItem, int count)
        {
            _context.Entry(basketItem).State = EntityState.Modified;

            basketItem.Count = count;

            _context.SaveChanges();
        }

        public Basket CreateBasket(Basket basket)
        {
            basket.AddedDate = DateTime.Now;
            basket.ModifiedDate = DateTime.Now;

            _context.Baskets.Add(basket);

            _context.SaveChanges();

            return basket;
        }

        public Basket GetBasketByProductAndToken(int productId, string token)
        {
            return _context.Baskets.SingleOrDefault(b => b.ProductId == productId && b.Token == token);
        }

        public IEnumerable<Basket> GetBasketByToken(string token)
        {
            return _context.Baskets.Include("Product")
                                   .Include("Product.Photos")
                                   .Where(b => b.Token == token)
                                   .ToList();
        }

        public void UpdateBasketsToken(string guestToken, string userToken)
        {
            foreach (var item in _context.Baskets.Where(b=>b.Token == guestToken).ToList())
            {
                item.Token = userToken;
            }

            _context.SaveChanges();
        }
    }
}
