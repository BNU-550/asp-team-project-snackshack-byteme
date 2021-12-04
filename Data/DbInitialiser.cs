using Snack_Shack.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Snack_Shack.Data
{
    /// <summary>
    /// Data to be seeded, initialising the database. 10 Customers.
    /// 
    /// By Isabelle Thorpe (30/11/2021)
    /// </summary>
    public static class DbInitialiser
    {
        /// <summary>
        /// Initialises the database with seeded data, calling each method to
        /// create test data for each model. 
        /// </summary>
        public static void Initialise(ApplicationDbContext context)
        {
            // ToDo:  Is this here or program? 
            //context.Database.EnsureCreated();

            AddPayment(context);
            // Add Payment first
            // AddPeople(context);
            // Add staff
            // Add product
            // Drink sub cat
            // Drinks
            // Food
            // Order and order items
            // Feedback

        }

        private static void AddPayment(ApplicationDbContext context)
        {
            // Added Payment to Application DbContext but hasn't shown
            // Is this because it is not yet in the database?
            // Look for any payment cards.
            if (context.Payments.Any())
            {
                return;
            }

            // Adding a payment
            var payment = new Payment[]
            {
                //Need to remove spaces as limited to 16? How 
                // Can I remove space automatically
                new Payment
                {
                    PaymentID = "0158 2345 2849 4825",
                    CardHolderName ="MS K S",
                    ExpiryDate = 0329,
                    CardCVV = 342
                },

                new Payment
                {
                    PaymentID = "0258 2345 2849 4825",
                    CardHolderName ="MS K S",
                    ExpiryDate = 0329,
                    CardCVV = 342
                },

                new Payment
                {
                    PaymentID = "0358 2345 2849 4825",
                    CardHolderName ="MS K S",
                    ExpiryDate = 0329,
                    CardCVV = 342
                },

                new Payment
                {
                    PaymentID = "0458 2345 2849 4825",
                    CardHolderName ="MS K S",
                    ExpiryDate = 0329,
                    CardCVV = 342
                },

                new Payment
                {
                    PaymentID = "0558 2345 2849 4825",
                    CardHolderName ="MS K S",
                    ExpiryDate = 0329,
                    CardCVV = 342
                },

                new Payment
                {
                    PaymentID = "0658 2345 2849 4825",
                    CardHolderName ="MS K S",
                    ExpiryDate = 0329,
                    CardCVV = 342
                },

                new Payment
                {
                    PaymentID = "0758 2345 2849 4825",
                    CardHolderName ="MS K S",
                    ExpiryDate = 0329,
                    CardCVV = 342
                },

                new Payment
                {
                    PaymentID = "0858 2345 2849 4825",
                    CardHolderName ="MS K S",
                    ExpiryDate = 0329,
                    CardCVV = 342
                },

                new Payment
                {
                    PaymentID = "0958 2345 2849 4825",
                    CardHolderName ="MS K S",
                    ExpiryDate = 0329,
                    CardCVV = 342
                },

                new Payment
                {
                    PaymentID = "1058 2345 2849 4825",
                    CardHolderName ="MS K S",
                    ExpiryDate = 0329,
                    CardCVV = 342
                },
            };

            foreach (Payment p in payment)
            {
                context.Payments.Add(p);
            }
            context.SaveChanges();

        }




        public static void AddPeople(ApplicationDbContext context)
        {

            // Look for any People.
            if (context.People.Any())
            {
                return;
            }

            // Adding a Person, staff or customer
            var people = new Person[]
            {
                //Add full name here? - This Person is a customer (True)
                // and is under 18
                new Person { FirstName = "Izzy", LastName = "Thorpe", IsCustomer = true,
                    EmailAddress = "isabelle_thorpe@outlook.com", MobileNumber =
                    "07587323741", IsMinor = true,},
            };

            foreach (Person p in people)
            {
                context.People.Add(p);
            }
            context.SaveChanges();
        }
    }
}

            




