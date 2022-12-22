using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Diagnostics;
using ShoppingApp.Business.Abstract;
using ShoppingApp.Entity.Concrete;
using ShoppingApp.Entity.Concrete.Identity;
using ShoppingApp.Web.Models.Dtos;

namespace ShoppingApp.Web.Controllers
{
    [Authorize]
    public class CardController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly ICardService _cardManager;
        private readonly ICardItemService _cardItemManager;
        private readonly IOrderService _orderManager;

        public CardController(UserManager<User> userManager, ICardService cardManager, ICardItemService cardItemManager, IOrderService orderManager)
        {
            _userManager = userManager;
            _cardManager = cardManager;
            _cardItemManager = cardItemManager;
            _orderManager = orderManager;
        }

        public async Task<IActionResult> Index()
        {
            var userId = _userManager.GetUserId(User);
            var card = await _cardManager.GetCardByUserId(userId);
            CardDto cardDto = new CardDto
            {
                CardId = card.Id,
                CardItems = card.CardItems.Select(ci => new CardItemDto
                {
                    CardItemId = ci.Id,
                    ProductId = ci.ProductId,
                    ProductName = ci.Product.Name,
                    ProductUrl= ci.Product.Url, 
                    ItemPrice = ci.Product.Price,
                    ImageUrl = ci.Product.ImageUrl,
                    Quantity = ci.Quantity
                }).ToList()
            };
            return View(cardDto);
        }

        [HttpPost]
        public IActionResult AddToCard(int productId, int quantity)
        {
            var userId = _userManager.GetUserId(User);
            _cardManager.AddToCard(userId, productId, quantity);
            return RedirectToAction("Index","Card");
        }

        [HttpPost]  

        public async Task<IActionResult> ChangeQuantity(int cardItemId,int quantity) 
        { 
            await _cardItemManager.ChangeQuantity(cardItemId, quantity);
            return RedirectToAction("Index", "Card");
        }

        public async Task<IActionResult> DeleteFromCard(int id)
        {
            var cardItem = await _cardItemManager.GetByIdAsync(id);
            _cardItemManager.Delete(cardItem);
            return RedirectToAction("Index","Card");
        }

        public async Task<IActionResult> Checkout()
        {
            var userId = _userManager.GetUserId(User);
            var user = await _userManager.FindByIdAsync(userId);
            var card = await _cardManager.GetCardByUserId(userId);
            
            OrderDto orderDto = new OrderDto
            {

                FirstName=user.FirstName,
                LastName=user.LastName,
                Address=user.Address,
                City=user.City,
                Phone=user.PhoneNumber,
                Email=user.Email,
                CardDto = new CardDto
                {
                    CardId = card.Id,
                    CardItems = card.CardItems.Select(ci => new CardItemDto
                    {
                        CardItemId = ci.Id,
                        ProductId = ci.ProductId,
                        ProductName = ci.Product.Name,
                        ItemPrice = ci.Product.Price,
                        ImageUrl=ci.Product.ImageUrl,
                        ProductUrl=ci.Product.Url,
                        Quantity=ci.Quantity
                    }).ToList()
                }
            };
                    return View(orderDto);
        }

        [HttpPost]
        public async Task<IActionResult> CheckOut(OrderDto orderDto)
        {
            if (ModelState.IsValid)
            {
                var userId = _userManager.GetUserId(User);
                var card = await _cardManager.GetCardByUserId(userId);
                orderDto.CardDto = new CardDto
                {
                    CardId = card.Id,
                    CardItems = card.CardItems.Select(ci => new CardItemDto
                    {
                        CardItemId = ci.Id,
                        ProductId = ci.ProductId,
                        ProductName = ci.Product.Name,
                        ItemPrice = ci.Product.Price,
                        ImageUrl = ci.Product.ImageUrl,
                        ProductUrl = ci.Product.Url,
                        Quantity = ci.Quantity
                    }).ToList()
                };
                //Ödeme işlemleri ile ilgili kodlar buraya yazılacak.

                //Yapılan satışı kaydetme işlemleri(Save order)
                SaveOrder(orderDto, userId);
            }
            return View("Index","Home");
        }
        private async void SaveOrder(OrderDto orderDto, string userId)
        {
            Order order = new Order();
            order.OrderNumber = "SA-" + new Random().Next(111111111, 999999999).ToString();
            order.OrderState = EnumOrderState.Unpaid;//Bu geçici olarak yapıldı aslında buraya ödeme tamamlanmış halde geleceğiz ve unpadi değil comlepte olamsını sağlayacağız.
            order.OrderType = EnumOrderType.CreditCard;
            order.OrderDate = new DateTime();
            order.FirstName= orderDto.FirstName;
            order.LastName= orderDto.LastName;
            order.Address = orderDto.Address;
            order.Email= orderDto.Email;
            order.Phone = orderDto.Phone;
            order.City = orderDto.City;
            order.UserId= userId;
            order.OrderItems = new List<OrderItem>();
            foreach (var item in orderDto.CardDto.CardItems)
            {
                var orderItem = new OrderItem();
                orderItem.Price = item.ItemPrice;
                orderItem.Quantity = item.Quantity;
                orderItem.ProductId=item.ProductId;
                order.OrderItems.Add(orderItem);
            }
            await _orderManager.CreateAsync(order);
        }

    }
}
