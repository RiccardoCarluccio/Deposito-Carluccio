using Es_1_N_Tier_Sistema_Ordini.Domain.Entities;
using Es_1_N_Tier_Sistema_Ordini.Domain.Interfaces;

namespace Es_1_N_Tier_Sistema_Ordini.Application.Services;

public class OrderService
{
    private readonly IOrderRepository _orderRepository;
    private readonly ProductService _productService;

    public OrderService(
        IOrderRepository orderRepository,
        ProductService productService)
    {
        _orderRepository = orderRepository;
        _productService = productService;
    }

    public Order CreateOrder(Customer customer)
    {
        var order = new Order
        {
            Customer = customer,
            Items = new List<OrderItem>()
        };
        _orderRepository.Add(order);
        return order;
    }

    public void AddOrderItem(Guid orderId, string productCode, int quantity)
    {
        var order = _orderRepository.GetById(orderId);
        var product = _productService.GetProductByCode(productCode);

        order.AddOrderItem(product, quantity);
    }

    public double CalculatePrice(Guid orderId)
    {
        double finalPrice = 0;

        var order = _orderRepository.GetById(orderId);

        foreach (var item in order.Items)
        {
            finalPrice += item.Product.Price * item.Quantity;
        }
        return finalPrice;
    }

    public IEnumerable<Order> ListOrders()
    {
        return _orderRepository.List();
    }
}
