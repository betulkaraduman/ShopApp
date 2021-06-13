using System;
using System.Collections.Generic;
using System.Linq;
using Iyzipay;
using Iyzipay.Model;
using Iyzipay.Request;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using shopApp.business.Abstract;
using shopApp.entity;
using ShopApp.webui.Identity;
using ShopApp.webui.Models;

namespace ShopApp.webui.Controllers
{
    [Authorize]
    public class CartController : Controller
    {
        private ICartService _cart;
        private UserManager<User> _userManager;
        private IOrderService _order;
        public CartController(ICartService cart, UserManager<User> user, IOrderService order)
        {
            _cart = cart;
            _order = order;
            _userManager = user;
        }

        public IActionResult Index()
        {
            var cart = _cart.GetCartByUserId(_userManager.GetUserId(User));
            var model = (new CartModel()
            {
                CartId = cart.Id,
                CartItems = cart.CartItems.Select(i => new CartItemModel()
                {
                    CartItemId = i.Id,
                    ProductId = i.ProductId,
                    Name = i.Product.Name,
                    Price = (double)i.Product.Price,
                    ImageUrl = i.Product.ImageUrl,
                    Quantity = i.Quantity
                }).ToList()
            });
            return View(model);

        }
        [HttpPost]
        public IActionResult AddToCart(int ProductId, int quantity)
        {
            var userId = _userManager.GetUserId(User);
            _cart.AddToCard(userId, ProductId, quantity);

            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Delete(int ProductId)
        {
            _cart.DeleteFromCart(_userManager.GetUserId(User), ProductId);
            return Redirect("Index");
        }

        public IActionResult Checkout()
        {
            var cart = _cart.GetCartByUserId(_userManager.GetUserId(User));

            var orderModel = new OrderModel();

            orderModel.CartModel = new CartModel()
            {
                CartId = cart.Id,
                CartItems = cart.CartItems.Select(i => new CartItemModel()
                {
                    CartItemId = i.Id,
                    ProductId = i.ProductId,
                    Name = i.Product.Name,
                    Price = (double)i.Product.Price,
                    ImageUrl = i.Product.ImageUrl,
                    Quantity = i.Quantity

                }).ToList()
            };

            return View(orderModel);
        }

        [HttpPost]
        public IActionResult Checkout(OrderModel model)
        {
            if (ModelState.IsValid)
            {
                var userId = _userManager.GetUserId(User);
                var cart = _cart.GetCartByUserId(userId);

                model.CartModel = new CartModel()
                {
                    CartId = cart.Id,
                    CartItems = cart.CartItems.Select(i => new CartItemModel()
                    {
                        CartItemId = i.Id,
                        ProductId = i.ProductId,
                        Name = i.Product.Name,
                        Price = (double)i.Product.Price,
                        ImageUrl = i.Product.ImageUrl,
                        Quantity = i.Quantity
                    }).ToList()
                };

                var payment = PaymentProcess(model);

                if (payment.Status == "success")
                {
                    SaveOrder(model, payment, userId);
                    ClearCart(model.CartModel.CartId);
                    return View("Success");
                }
                else
                {
                    var msg = new AlertMessage()
                    {
                        Message = $"{payment.ErrorMessage}",
                        AlertType = "danger"
                    };

                    TempData["message"] = JsonConvert.SerializeObject(msg);
                }
            }
            return View(model);
        }

        private void ClearCart(int CartId)
        {
            _cart.ClearCart(CartId);
        }

        private void SaveOrder(OrderModel model, Payment payment, string userId)
        {
            var order = new Order();

            order.OrderNumber = new Random().Next(111111, 999999).ToString();
            order.OrderState = shopApp.entity.EnumOrderState.completed;
            order.PaymentType = shopApp.entity.PaymentType.CrediCart;
            order.PaymentId = payment.PaymentId;
            order.Conversation = payment.ConversationId;
            order.OrderDate = new DateTime();
            order.FirstName = model.FirstName;
            order.LastName = model.LastName;
            order.UserId = userId;
            order.Address = model.Address;
            order.Phone = model.Phone;
            order.Email = model.Email;
            order.City = model.City;
            order.Note = "None";

            order.OrderItems = new List<shopApp.entity.OrderItem>();

            foreach (var item in model.CartModel.CartItems)
            {
                var orderItem = new shopApp.entity.OrderItem()
                {
                    Price = item.Price,
                    Quantity = item.Quantity,
                    ProductId = item.ProductId
                };
                order.OrderItems.Add(orderItem);
            }
            _order.Create(order);
        }

        private Payment PaymentProcess(OrderModel model)
        {
            Options options = new Options();
            options.ApiKey = "sandbox-RStpAR6sBz86RpFTuWPyF7hjh8c8g9E4";
            options.SecretKey = "sandbox-0zu0oxpXipwFsSGu1FrSofDVhTrWig2p";
            options.BaseUrl = "https://sandbox-api.iyzipay.com";

            CreatePaymentRequest request = new CreatePaymentRequest();
            request.Locale = Locale.TR.ToString();
            request.ConversationId = new Random().Next(111111111, 999999999).ToString();
            request.Price = model.CartModel.TotalPrice().ToString();
            request.PaidPrice = model.CartModel.TotalPrice().ToString();
            request.Currency = Currency.TRY.ToString();
            request.Installment = 1;
            request.BasketId = "B67832";
            request.PaymentChannel = PaymentChannel.WEB.ToString();
            request.PaymentGroup = PaymentGroup.PRODUCT.ToString();

            PaymentCard paymentCard = new PaymentCard();
            paymentCard.CardHolderName = model.CartName;
            paymentCard.CardNumber = model.CartNumber;
            paymentCard.ExpireMonth = model.ExpirationMonth;
            paymentCard.ExpireYear = model.ExpirationYear;
            paymentCard.Cvc = model.Cvc;
            paymentCard.RegisterCard = 0;
            request.PaymentCard = paymentCard;

            //  paymentCard.CardNumber = "5528790000000008";
            // paymentCard.ExpireMonth = "12";
            // paymentCard.ExpireYear = "2030";
            // paymentCard.Cvc = "123";

            Buyer buyer = new Buyer();
            buyer.Id = "BY789";
            buyer.Name = model.FirstName;
            buyer.Surname = model.LastName;
            buyer.GsmNumber = "+905350000000";
            buyer.Email = "email@email.com";
            buyer.IdentityNumber = "74300864791";
            buyer.LastLoginDate = "2015-10-05 12:43:35";
            buyer.RegistrationDate = "2013-04-21 15:12:09";
            buyer.RegistrationAddress = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
            buyer.Ip = "85.34.78.112";
            buyer.City = "Istanbul";
            buyer.Country = "Turkey";
            buyer.ZipCode = "34732";
            request.Buyer = buyer;

            Address shippingAddress = new Address();
            shippingAddress.ContactName = "Jane Doe";
            shippingAddress.City = "Istanbul";
            shippingAddress.Country = "Turkey";
            shippingAddress.Description = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
            shippingAddress.ZipCode = "34742";
            request.ShippingAddress = shippingAddress;

            Address billingAddress = new Address();
            billingAddress.ContactName = "Jane Doe";
            billingAddress.City = "Istanbul";
            billingAddress.Country = "Turkey";
            billingAddress.Description = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
            billingAddress.ZipCode = "34742";
            request.BillingAddress = billingAddress;

            List<BasketItem> basketItems = new List<BasketItem>();
            BasketItem basketItem;

            foreach (var item in model.CartModel.CartItems)
            {
                basketItem = new BasketItem();
                basketItem.Id = item.ProductId.ToString();
                basketItem.Name = item.Name;
                basketItem.Category1 = "Telefon";
                basketItem.Price = item.Price.ToString();
                basketItem.ItemType = BasketItemType.PHYSICAL.ToString();
                basketItems.Add(basketItem);
            }
            request.BasketItems = basketItems;
            return Payment.Create(request, options);
        }

        public IActionResult Orders()
        {
            var userId = _userManager.GetUserId(User);
            var orders = _order.GetORders(userId);
            Console.WriteLine(userId);
            var orderListModel=new List<OrderListModel>();
            OrderListModel orderModel;
            foreach (var order in orders)
            {
                orderModel=new OrderListModel();
                orderModel.OrderId=order.Id;
                orderModel.OrderNumber=order.OrderNumber;
                orderModel.OrderDate=order.OrderDate;
                orderModel.Phone=order.Phone;
                orderModel.FirstName=order.FirstName;
                orderModel.LastName=order.LastName;
                orderModel.Email=order.Email;
                orderModel.Address=order.Address;
                orderModel.City=order.City;
                orderModel.OrderItems=order.OrderItems.Select(i=>new OrderItemModel(){
                    OrderItemId=i.Id,
                    Name=i.Product.Name,
                    Price=(double)i.Product.Price,
                    Quantity=i.Quantity,
                    ImageUrl=i.Product.ImageUrl
                }).ToList();
                Console.WriteLine(orderModel.FirstName);
                orderListModel.Add(orderModel);

            }

            return View("Orders", orderListModel);
        }



    }
}