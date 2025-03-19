using Microsoft.AspNetCore.Mvc;
using OrderFlowApp.Models;

namespace OrderFlowApp.Controllers
{
    public class OrderController : Controller
    {
        // Handles GET requests for the order entry page
        [HttpGet]
        public IActionResult OrderEntry()
        {
            // Returns the view for entering order details (first time loading the form)
            return View();
        }

        // Handles POST requests when the order form is submitted
        [HttpPost]
        public IActionResult OrderEntry(Order order)
        {
            // Check if the model state is valid (ensuring that all required fields are filled in correctly)
            if (ModelState.IsValid)
            {
                // Calculate the discount based on the order amount and customer type
                order.CalculateDiscount();
                
                // If the model is valid, return the OrderSummary view with the order data
                // This will display the calculated discount and total amount to the user
                return View("OrderSummary", order);
            }
            else
            {
                // If the model state is invalid, re-display the order entry form for the user to correct their input
                return View();
            }
        }
    }
}
