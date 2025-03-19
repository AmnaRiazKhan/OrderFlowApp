using Xunit;
using global::OrderFlowApp.Models;
namespace OrderFlowApp.Tests;

public class OrderTest
{
    // Test for discount calculation for Loyal customers with an amount greater than or equal to $100
    [Fact]
    public void CalculateDiscount_LoyalCustomer_Over100_ShouldApplyDiscount()
    {

        // Arrange
        var order = new Order
        {
            OrderAmount = 150,
            IsCustomerLoyal = true
        };

        // Act
        order.CalculateDiscount();

        // Assert
        Assert.Equal(15, order.OrderDiscount); // Expected 10% of 150 = 15

        Assert.Equal(135, order.FinalAmount); // Expected total after discount = 150 - 15 = 135
    }


    // Test for no discount applied for New customers with an amount greater than or equal to $100
    [Fact]
    public void CalculateDiscount_NewCustomer_Over100_ShouldNotApplyDiscount()
    {
        // Arrange
        var order = new Order
        {
            OrderAmount = 150,
            IsCustomerLoyal = false
        };

        // Act
        order.CalculateDiscount();

        // Assert
        Assert.Equal(0, order.OrderDiscount); // No discount for new customers
        Assert.Equal(150, order.FinalAmount); // Original amount
    }

    // Test for loyal customer with order amount less than $100
    [Fact]
    public void CalculateDiscount_LoyalCustomer_Under100_ShouldNotApplyDiscount()
    {
        // Arrange
        var order = new Order
        {
            OrderAmount = 50,
            IsCustomerLoyal = true
        };

        // Act
        order.CalculateDiscount();

        // Assert
        Assert.Equal(0, order.OrderDiscount);     // No discount below $100
        Assert.Equal(50, order.FinalAmount);     // Total should remain the same
    }
}
