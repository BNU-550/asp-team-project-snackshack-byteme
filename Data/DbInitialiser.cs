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
    /// Modified (04/12/2021 Isabelle Thorpe)
    /// </summary>
    public static class DbInitialiser
    {
        /// <summary>
        /// Initialises the database with seeded data, calling each method to
        /// create test data for each model. 
        /// </summary>
        public static void Initialise(ApplicationDbContext context)
        {

            AddPayment(context);
            AddPeople(context);
            AddStaff(context);

            AddProduct(context);
            AddDrink(context);
            AddFood(context);

            AddOrder(context);
            AddOrderItem(context);

            AddFeedback(context);


        }

        private static void AddPayment(ApplicationDbContext context)
        {

            if (context.Payments.Any())
            {
                return;
            }

            var payment = new Payment[]
            {

                new Payment
                {
                    PaymentID = "0111 4387 3298 2848",
                    CardHolderName ="MISS KAYLEY SYRETT",
                    ExpiryDate = 0428,
                    CardCVV = 342
                },

                new Payment
                {
                    PaymentID = "0222 5487 4398 2094",
                    CardHolderName ="MS I M THORPE",
                    ExpiryDate = 0323,
                    CardCVV = 745
                },

                new Payment
                {
                    PaymentID = "0333 2345 2849 4825",
                    CardHolderName ="MR A ADDAPU",
                    ExpiryDate = 1123,
                    CardCVV = 549
                },

                new Payment
                {
                    PaymentID = "0444 2345 2849 4825",
                    CardHolderName ="MR DEREK P",
                    ExpiryDate = 1025,
                    CardCVV = 489
                },

                new Payment
                {
                    PaymentID = "0555 2345 2849 4825",
                    CardHolderName ="MR J LUKER",
                    ExpiryDate = 0824,
                    CardCVV = 988
                },

                new Payment
                {
                    PaymentID = "0666 2345 2849 4825",
                    CardHolderName ="KOMPEL CAMPION",
                    ExpiryDate = 0226,
                    CardCVV = 498
                },

                new Payment
                {
                    PaymentID = "0777 2345 2849 4825",
                    CardHolderName ="MR R JONES",
                    ExpiryDate = 0428,
                    CardCVV = 3655
                },

                new Payment
                {
                    PaymentID = "0888 2345 2849 4825",
                    CardHolderName ="MRS PRATHNA S",
                    ExpiryDate = 0727,
                    CardCVV = 650
                },

                new Payment
                {
                    PaymentID = "0999 2345 2849 4825",
                    CardHolderName ="NICHOLAS DAY",
                    ExpiryDate = 0824,
                    CardCVV = 0987
                },

                new Payment
                {
                    PaymentID = "1111 2345 2849 4825",
                    CardHolderName ="MR CARLO L",
                    ExpiryDate = 0525,
                    CardCVV = 378
                },
            };

            context.Payments.AddRange(payment);
            context.SaveChanges();
        }



        public static void AddPeople(ApplicationDbContext context)
        {

            if (context.People.Any())
            {
                return;
            }

            var people = new Person[]
            {

                new Person
                {
                    //PersonID = 21,
                    FirstName = "Izzy",
                    LastName = "Thorpe",
                    IsCustomer = true,
                    EmailAddress = "isabelle_thorpe@outlook.com",
                    MobileNumber ="07587323741",
                    IsMinor = false
                },

                new Person
                {
                    //PersonID = 23,
                    FirstName = "Kayley",
                    LastName = "Syrett",
                    IsCustomer = true,
                    EmailAddress = "kayleysyrett@yahoo.co.uk",
                    MobileNumber ="07548754848",
                    IsMinor = false
                },

                new Person
                {
                    //PersonID = 25,
                    FirstName = "Atish",
                    LastName = "Addapu",
                    IsCustomer = true,
                    EmailAddress = "atishaddapu@gmail.com",
                    MobileNumber ="07298467236",
                    IsMinor = false
                },

                new Person
                {
                    //PersonID = 27,
                    FirstName = "Justin",
                    LastName = "Luker",
                    IsCustomer = true,
                    EmailAddress = "jluker@gmail.com",
                    MobileNumber ="07486709356",
                    IsMinor = true
                },

                new Person
                {
                    //PersonID = 29,
                    FirstName = "Kompel",
                    LastName = "Campion",
                    IsCustomer = true,
                    EmailAddress = "kompel.campion@hotmail.co.uk",
                    MobileNumber ="07967345623",
                    IsMinor = false
                },

                new Person
                {
                    //PersonID = 31,
                    FirstName = "Richard",
                    LastName = "Jones",
                    IsCustomer = true,
                    EmailAddress = "richardjones21@outlook.com",
                    MobileNumber ="07677345520",
                    IsMinor = false,
                },

                new Person
                {
                    //PersonID = 33,
                    FirstName = "Prathna",
                    LastName = "Singh",
                    IsCustomer = true,
                    EmailAddress = "pratha.s@yahoo.com",
                    MobileNumber ="07362775902",
                    IsMinor = false
                },

                new Person
                {
                    //PersonID = 35,
                    FirstName = "Nick",
                    LastName = "Day",
                    IsCustomer = true,
                    EmailAddress = "nicholasday@gmail.com",
                    MobileNumber ="07344567249",
                    IsMinor = true
                },

                new Person
                {
                    //PersonID = 37,
                    FirstName = "Carlo",
                    LastName = "Spaghetti",
                    IsCustomer = true,
                    EmailAddress = "carlo234@hotmail.co.uk",
                    MobileNumber ="07741673838",
                    IsMinor = false
                },

                new Person
                {
                    //PersonID = 39,
                    FirstName = "Derek",
                    LastName = "Peacock",
                    IsCustomer = true,
                    EmailAddress = "derek_peacock@outlook.com",
                    MobileNumber ="07454278853",
                    IsMinor = false
                },
            };

            context.People.AddRange(people);
            context.SaveChanges();
        }



        private static void AddStaff(ApplicationDbContext context)
        {

            if (context.Staff.Any())
            {
                return;
            }

            var staff = new Staff[]
            {

                new Staff
                {
                    //PersonID = 41,
                    FirstName = "Elon",
                    LastName = "Musk",
                    IsCustomer = false,
                    EmailAddress = "space_x@outlook.com",
                    MobileNumber = "07885667372",
                    IsMinor = false,
                    JobTitle = "Manager",
                    Salary = 29000
                },

                new Staff
                {
                    //PersonID = 43,
                    FirstName = "Jeff",
                    LastName = "Bezos",
                    IsCustomer = false,
                    EmailAddress = "notrees4u@gmail.com",
                    MobileNumber = "07666345234",
                    IsMinor = false,
                    JobTitle = "Assistant Mangager",
                    Salary = 24000
                },

                new Staff
                {
                    //PersonID = 45,
                    FirstName = "Bill",
                    LastName = "Gates",
                    IsCustomer = false,
                    EmailAddress = "theonlyniceguyleft@outlook.com",
                    MobileNumber = "07565446729",
                    IsMinor = false,
                    JobTitle = "Barman",
                    Salary = 22000
                },

                new Staff
                {
                    //PersonID = 47,
                    FirstName = "Mark",
                    LastName = "Zuckerberg",
                    IsCustomer = false,
                    EmailAddress = "suckerberg.mark@meta.com",
                    MobileNumber = "07776855432",
                    IsMinor = false,
                    JobTitle = "Floor",
                    Salary = 23000
                },
            };

            context.Staff.AddRange(staff);
            context.SaveChanges();

        }



        private static void AddProduct(ApplicationDbContext context)
        {

            if (context.Products.Any())
            {
                return;
            }

            var product = new Product[]
            {

                new Product
                {
                    //ProductID = 22,
                    Name = "Chicken Wings",
                    Description = "Succulent chicken wings " +
                    "smothered in a medium spicy homemade BBQ sauce",
                    ProductPrice = 4.20m,
                    IsActive = true,
                    ImageURL = "ChickenWings.jpg"
                },

                new Product
                {
                    //ProductID = 24,
                    Name = "Sharer Nachos",
                    Description = "Crispy tortillas loaded with sour " +
                    "cream, guac, salsa, cheese and jalapeños",
                    ProductPrice = 8.40m,
                    IsActive = true,
                    ImageURL = "NachosToShare.jpg"
                },

                new Product
                {
                    //ProductID = 26,
                    Name = "Char-Grilled Shrimp",
                    Description = "Our locally-caught shrimp " +
                    "served with garlic oil dipping sauce",
                    ProductPrice = 7.10m,
                    IsActive = true,
                    ImageURL = "ChargrilledShrimp.jpg"
                },

                new Product
                {
                    //ProductID = 28,
                    Name = "Hummus & Flat Bread",
                    Description = "Served with mixed olives",
                    ProductPrice = 5.90m,
                    IsActive = true,
                    ImageURL = "HummusAndFlatbread.jpg"
                },

                new Product
                {
                    //ProductID = 30,
                    Name = "Chicken Pops",
                    Description = "8 deep friend chicken pieces " +
                    "served with homemade BBQ dipping sauce",
                    ProductPrice = 5.60m,
                    IsActive = true,
                    ImageURL = "ChickenPops.jpg"
                },

                new Product
                {
                    //ProductID = 32,
                    Name = "Zuckerburger",
                    Description = "Tasty 8oz beef burger " +
                    "with mayo, cheese, tomato, lettuce, and pickles. " +
                    "Served with fries",
                    ProductPrice = 11.90m,
                    IsActive = true,
                    ImageURL = "Zuckerburger.jpg"
                },

                new Product
                {
                    //ProductID = 34,
                    Name = "The Big Bad Burger",
                    Description = "A double beef burger served " +
                    "with burger sauce, cheese, bacon, egg, pickles",
                    ProductPrice = 12.20m,
                    IsActive = true,
                    ImageURL = "BigBadBurger.jpg"
                },

                new Product
                {
                    //ProductID = 36,
                    Name = "Snack Shack Burger",
                    Description = "Tender chicken " +
                    "breast with BBQ sauce, cheddar cheese, and bacon",
                    ProductPrice = 10.90m,
                    IsActive = true,
                    ImageURL = "SnackShackBurger.jpg"
                },

                new Product
                {
                    //ProductID = 38,
                    Name = "The Veggie One",
                    Description = "Chickpea, falafel patty " +
                    "with avocado, lettuce, and sweet chilli sauce",
                    ProductPrice = 10.50m,
                    IsActive = true,
                    ImageURL = "ChickpeaBurger.jpg"
                },

                new Product
                {
                    //ProductID = 40,
                    Name = "Plant Burger",
                    Description = "Vegan Mayonnaise, Tofu patty " +
                    "with pickled red cabbage, and sweet chilli sauce ",
                    ProductPrice = 10.80m,
                    IsActive = true,
                    ImageURL = "PlantBurger.jpg"
                },

                new Product
                {
                    //ProductID = 42,
                    Name = "Grilled Chicken Wrap",
                    Description = "Lettuce, tomato, cucumber, mayo " +
                    "& tortilla bread",
                    ProductPrice = 6.90m,
                    IsActive = true,
                    ImageURL = "ChickenWrap.jpg"
                },

                new Product
                {
                    //ProductID = 44,
                    Name = "Falafel Wrap",
                    Description = "Falafel, hummus, tomato, gherkin, vegan mayo",
                    ProductPrice = 5.90m,
                    IsActive = true,
                    ImageURL = "FalafelWrap.jpg"
                },

                new Product
                {
                    //ProductID = 46,
                    Name = "Halloumi Wrap",
                    Description = "Rocket, grilled peppers, sweet chilli " +
                    "jam & tortilla bread",
                    ProductPrice = 5.90m,
                    IsActive = true,
                    ImageURL = "HalloumiWrap.jpg"
                },

                new Product
                {
                    //ProductID = 48,
                    Name = "Caeser Salad",
                    Description = "Romaine lettuce, crunchy croutons, " +
                    "chicken, anchovies, and ceaser dressing ",
                    ProductPrice = 7.90m,
                    IsActive = true,
                    ImageURL = "CeaserSalad.jpg"
                },

                new Product
                {
                    //ProductID = 50,
                    Name = "Rosemary salted fries",
                    Description = "Served with garlic mayo",
                    ProductPrice = 2.90m,
                    IsActive = true,
                    ImageURL = "RosemaryFries.jpg"
                },

                new Product
                {
                    //ProductID = 52,
                    Name = "Chunky chips",
                    Description = "Served with homemade " +
                    "BBQ sauce",
                    ProductPrice = 2.70m,
                    IsActive = true,
                    ImageURL = "ChunkyChips.jpg"
                },

                new Product
                {
                    //ProductID = 54,
                    Name = "Onion rings",
                    Description = "Served with homemade BBQ sauce ",
                    ProductPrice = 3.30m,
                    IsActive = true,
                    ImageURL = "OnionRings.jpg"
                },

                new Product
                {
                    //ProductID = 56,
                    Name = "Homemade Slaw",
                    Description = "Freshly made slaw with a " +
                    "creamy paprika twist",
                    ProductPrice = 3.20m,
                    IsActive = true,
                    ImageURL = "HomemadeSlaw.jpg"
                },

                new Product

                {
                    //ProductID = 60,
                    Name = "Churros",
                    Description = "Fresh Churros with " +
                    "melted chocolate dip",
                    ProductPrice = 5.20m,
                    IsActive = true,
                    ImageURL = "Churros.jpg"
                },

                new Product
                {
                    //ProductID = 62,
                    Name = "Chocolate Brownie",
                    Description = "Served warm with Cornish " +
                    "vanilla ice cream",
                    ProductPrice = 5.50m,
                    IsActive = true,
                    ImageURL = "ChocolateBrownie.jpg"
                },

                new Product
                {
                    //ProductID = 64,
                    Name = "Apple pie",
                    Description = "Served with a big dollop " +
                    "of Cornish vanilla ice cream",
                    ProductPrice = 5.90m,
                    IsActive = true,
                    ImageURL = "ApplePie.jpg"
                },

                new Product
                {
                    //ProductID = 66,
                    Name = "Waffles",
                    Description = "Served with chocolate " +
                    "ice cream, rasperries, fresh cream " +
                    "and chocolate sauce",
                    ProductPrice = 6.10m,
                    IsActive = true,
                    ImageURL = "Waffles.jpg"
                },


                new Product
                {
                    //ProductID = 68,
                    Name = "Pinot Grigio",
                    Description = "Crisp and fruity with " +
                    "flavours of melon and hints of citrus",
                    ProductPrice = 4.40m,
                    IsActive = true,
                    ImageURL = "GalloPinotGrigio.jpg"
                },

                new Product
                {
                    //ProductID = 70,
                    Name = "Chardonnay",
                    Description = "Notes of apple and ripe " +
                    "stone fruit, layered with toasted oak",
                    ProductPrice = 5.10m,
                    IsActive = true,
                    ImageURL = "DarkHorseChardonnay.jpg"
                },

                new Product
                {
                    //ProductID = 72,
                    Name = "Sauvignon Blanc",
                    Description = "Stunningly aromatic tropical " +
                    "fruits and bright citrus notes, with a " +
                    "refreshingly zesty finish",
                    ProductPrice = 5.90m,
                    IsActive = true,
                    ImageURL = "OysterBaySauvignon.jpg"
                },

                new Product
                {
                    //ProductID = 74,
                    Name = "Merlot",
                    Description = "packed with tempting flavours " +
                    "of blackberry, raspberry and chocolate, with " +
                    "a silky smooth finish",
                    ProductPrice = 5.20m,
                    IsActive = true,
                    ImageURL = "BarefootMerlot.jpg"
                },

                new Product
                {
                    //ProductID = 76,
                    Name = "Shiraz",
                    Description = "Rich and smooth, with juicy red " +
                    "berries and hints of liquorice and spice",
                    ProductPrice = 5.40m,
                    IsActive = true,
                    ImageURL = "YellowTailShiraz.jpg"
                },

                new Product
                {
                    //ProductID = 78,
                    Name = "Rioja",
                    Description = "The most vibrant expression of " +
                    "Tempranillo, showing ripe red fruit characteristics " +
                    "and a slight vanilla and spice character",
                    ProductPrice = 6.10m,
                    IsActive = true,
                    ImageURL = "CampoViejoRioja.jpg"
                },

                new Product
                {
                    //ProductID = 80,
                    Name = "Pinot Blush",
                    Description = "Aromas of wild strawberries, zesty " +
                    "minerality and flavours of forest fruits",
                    ProductPrice = 5.60m,
                    IsActive = true,
                    ImageURL = "MondelliPinotBlush.jpg"
                },

                new Product
                {
                    //ProductID = 82,
                    Name = "White Zinfandel",
                    Description = "Delightful aroma of strawberries, " +
                    "the flavours of red, ripe watermelon",
                    ProductPrice = 4.10m,
                    IsActive = true,
                    ImageURL = "BlossomHillWhiteZinfandel.jpg"
                },

                new Product
                {
                    //ProductID = 84,
                    Name = "Brut Cava",
                    Description = "Crisp, clean and well balanced, with " +
                    "distinctive apple, pear and bright citrus flavours " +
                    "and even a touch of ginger",
                    ProductPrice = 5.60m,
                    IsActive = true,
                    ImageURL = "FreixenetCava.jpg"
                },

                new Product
                {
                    //ProductID = 86,
                    Name = "The Joshua Brut",
                    Description = "Light yeasty aromas, limey fresh fruit " +
                    "on the nose and rich creamy complexity on the palate",
                    ProductPrice = 29.90m,
                    IsActive = true,
                    ImageURL = "GrahamBeckBrut.jpg"
                },

                new Product
                {
                    //ProductID = 88,
                    Name = "Brut Non Vintage",
                    Description = "Initial flavours of white fruits " +
                    "and raisins develop into notes of brioche and vanilla",
                    ProductPrice = 79.90m,
                    IsActive = true,
                    ImageURL = "VeuveClicquotBrut.jpg"
                },

                new Product
                {
                    //ProductID = 90,
                    Name = "Nastro Azzurro",
                    Description = "",
                    ProductPrice = 5.40m,
                    IsActive = true,
                    ImageURL = "PeroniNastro.jpg"
                },

                new Product
                {
                    //ProductID = 92,
                    Name = "Tequila Lager",
                    Description = "",
                    ProductPrice = 4.10m,
                    IsActive = true,
                    ImageURL = "DesperadosLager.jpg"
                },

                new Product
                {
                    //ProductID = 94,
                    Name = "Doom Bar Amber Ale",
                    Description = "",
                    ProductPrice = 5.10m,
                    IsActive = true,
                    ImageURL = "SharpsDoomBar.jpg"
                },

                new Product
                {
                    //ProductID = 96,
                    Name = "Ruby Ale",
                    Description = "",
                    ProductPrice = 5.20m,
                    IsActive = true,
                    ImageURL = "HobgoblinRubyAle.jpg"
                },

                new Product
                {
                    //ProductID = 98,
                    Name = "London Dry",
                    Description = "Wild juniper berries, " +
                    "coriander, angelica and liquorice",
                    ProductPrice = 3.40m,
                    IsActive = true,
                    ImageURL = "GordonsGin.jpg"
                },

                new Product
                {
                    //ProductID = 100,
                    Name = "Flor de Sevilla",
                    Description = "Bittersweet Seville oranges " +
                    "to deliver a fruitful and zesty taste",
                    ProductPrice = 3.90m,
                    IsActive = true,
                    ImageURL = "TanquerySevilla.jpg"
                },

                new Product
                {
                    //ProductID = 101,
                    Name = "Red Label",
                    Description = "Triple distilled from different " +
                    "blended grains, filtered ten times through " +
                    "seven columns of charcoal",
                    ProductPrice = 3.30m,
                    IsActive = true,
                    ImageURL = "SmirnoffRedLabel.jpg"
                },

                new Product
                {
                    //ProductID = 102,
                    Name = "Black Lavel Blended Scotch",
                    Description = "Deep layers of sweet fruit, " +
                    "spice and vanilla",
                    ProductPrice = 3.60m,
                    IsActive = true,
                    ImageURL = "JohnnieWalkerBlackLabel.jpg"
                },

                new Product
                {
                    //ProductID = 104,
                    Name = "Orange juice",
                    Description = "",
                    ProductPrice = 2.40m,
                    IsActive = true,
                    ImageURL = "BritvicOrange.jpg"
                },

                new Product
                {
                    //ProductID = 106,
                    Name = "Apple juice",
                    Description = "",
                    ProductPrice = 2.40m,
                    IsActive = true,
                    ImageURL = "BritvicApple.jpg"
                },

                new Product
                {
                    //ProductID = 108,
                    Name = "Still water",
                    Description = "",
                    ProductPrice = 1.90m,
                    IsActive = true,
                    ImageURL = "HarrogateStill.jpg"
                },

                new Product
                {
                    //ProductID = 110,
                    Name = "Sparkling water",
                    Description = "",
                    ProductPrice = 2.40m,
                    IsActive = true,
                    ImageURL = "HarrogateSparkling.jpg"
                },

                new Product
                {
                    //ProductID = 112,
                    Name = "Diet Coke",
                    Description = "",
                    ProductPrice = 2.60m,
                    IsActive = true,
                    ImageURL = "DietCoke.jpg"
                },

                new Product
                {
                    //ProductID = 114,
                    Name = "Coca Cola",
                    Description = "",
                    ProductPrice = 2.60m,
                    IsActive = true,
                    ImageURL = "CocaCola.jpg"
                },

                new Product
                {
                    //ProductID = 116,
                    Name = "Indian Tonic water",
                    Description = "",
                    ProductPrice = 2.60m,
                    IsActive = true,
                    ImageURL = "FeverTreeIndian.jpg"
                },

                new Product
                {
                    //ProductID = 118,
                    Name = "Americano",
                    Description = "",
                    ProductPrice = 2.70m,
                    IsActive = true,
                    ImageURL = "Americano.jpg"
                },

                new Product
                {
                    //ProductID = 120,
                    Name = "Latte",
                    Description = "",
                    ProductPrice = 3.20m,
                    IsActive = true,
                    ImageURL = "Latte.jpg"
                },

                new Product
                {
                    //ProductID = 122,
                    Name = "Cappacino",
                    Description = "",
                    ProductPrice = 3.20m,
                    IsActive = true,
                    ImageURL = "Cappacino.jpg"
                },

                new Product
                {
                    //ProductID = 124,
                    Name = "Mocha",
                    Description = "",
                    ProductPrice = 3.40m,
                    IsActive = true,
                    ImageURL = "Mocha.jpg"
                },

                new Product
                {
                    //ProductID = 126,
                    Name = "English Breakfast Tea",
                    Description = "",
                    ProductPrice = 2.40m,
                    IsActive = true,
                    ImageURL = "EnglishBreakfastTea.jpg"
                },

                new Product
                {
                    //ProductID = 128,
                    Name = "Earl Grey Tea",
                    Description = "",
                    ProductPrice = 2.40m,
                    IsActive = true,
                    ImageURL = "PukkaEarlyGrey.jpg"
                },

            };

            context.Products.AddRange(product);
            context.SaveChanges();
        }










        private static void AddDrink(ApplicationDbContext context)
        {
            if (context.Drinks.Any())
            {
                return;
            }

            var drinks = new Drink[]
            {
                new Drink
                {
                    ProductID = 2,
                    DrinkCategory = DrinkCategory.Wines,
                    SubCategory = DrinkSubCategory.Rosé,
                    ContainsAlcohol = true,
                    AlcoholPercentage = 8.5,
                    DrinkBrand = "Blossom Hill"
                },

                new Drink
                {
                    ProductID = 3,
                    DrinkCategory = DrinkCategory.Wines,
                    SubCategory = DrinkSubCategory.Sparkling,
                    ContainsAlcohol = true,
                    AlcoholPercentage = 11.5,
                    DrinkBrand = "Freixenet"
                },

                new Drink
                {
                    ProductID = 4,
                    DrinkCategory = DrinkCategory.Wines,
                    SubCategory = DrinkSubCategory.Sparkling,
                    ContainsAlcohol = true,
                    AlcoholPercentage = 12,
                    DrinkBrand = "Graham Beck"
                },

                new Drink
                {
                    ProductID = 5,
                    DrinkCategory = DrinkCategory.Wines,
                    SubCategory = DrinkSubCategory.Champagne,
                    ContainsAlcohol = true,
                    AlcoholPercentage = 12,
                    DrinkBrand = "Veuve Clicquot"
                },

                new Drink
                {
                    ProductID = 6,
                    DrinkCategory = DrinkCategory.Beers,
                    SubCategory = DrinkSubCategory.Lager,
                    ContainsAlcohol = true,
                    AlcoholPercentage = 5.1,
                    DrinkBrand = "Peroni"
                },

                new Drink
                {
                    ProductID = 7,
                    DrinkCategory = DrinkCategory.Beers,
                    SubCategory = DrinkSubCategory.Lager,
                    ContainsAlcohol = true,
                    AlcoholPercentage = 5.9,
                    DrinkBrand = "Desperados"
                },

                new Drink
                {
                    ProductID = 8,
                    DrinkCategory = DrinkCategory.Beers,
                    SubCategory = DrinkSubCategory.Lager,
                    ContainsAlcohol = true,
                    AlcoholPercentage = 4.3,
                    DrinkBrand = "Sharps"
                },

                new Drink
                {
                    ProductID = 9,
                    DrinkCategory = DrinkCategory.Beers,
                    SubCategory = DrinkSubCategory.Lager,
                    ContainsAlcohol = true,
                    AlcoholPercentage = 5.2,
                    DrinkBrand = "Hobgoblin"
                },

                new Drink
                {
                    ProductID = 11,
                    DrinkCategory = DrinkCategory.Spirits,
                    SubCategory = DrinkSubCategory.Gin,
                    ContainsAlcohol = true,
                    AlcoholPercentage = 41.3,
                    DrinkBrand = "Tanquery"
                },

                new Drink
                {
                    ProductID = 12,
                    DrinkCategory = DrinkCategory.Spirits,
                    SubCategory = DrinkSubCategory.Vodka,
                    ContainsAlcohol = true,
                    AlcoholPercentage = 37.5,
                    DrinkBrand = "Smirnoff"
                },

                new Drink
                {
                    ProductID = 12,
                    DrinkCategory = DrinkCategory.Spirits,
                    SubCategory = DrinkSubCategory.Whisky,
                    ContainsAlcohol = true,
                    AlcoholPercentage = 40,
                    DrinkBrand = "Johnnie Walker"
                },

                new Drink
                {
                    ProductID = 14,
                    DrinkCategory = DrinkCategory.SoftDrinks,
                    SubCategory = DrinkSubCategory.Juice,
                    ContainsAlcohol = false,
                    AlcoholPercentage = 0,
                    DrinkBrand = "Britvic"
                },

                new Drink
                {
                    ProductID = 15,
                    DrinkCategory = DrinkCategory.SoftDrinks,
                    SubCategory = DrinkSubCategory.Juice,
                    ContainsAlcohol = false,
                    AlcoholPercentage = 0,
                    DrinkBrand = "Britvic"
                },

                new Drink
                {
                    ProductID = 16,
                    DrinkCategory = DrinkCategory.SoftDrinks,
                    SubCategory = DrinkSubCategory.Water,
                    ContainsAlcohol = false,
                    AlcoholPercentage = 0,
                    DrinkBrand = "Harrogate"
                },

                new Drink
                {
                    ProductID = 17,
                    DrinkCategory = DrinkCategory.SoftDrinks,
                    SubCategory = DrinkSubCategory.Water,
                    ContainsAlcohol = false,
                    AlcoholPercentage = 0,
                    DrinkBrand = "Harrogate"
                },

                new Drink
                {
                    ProductID = 18,
                    DrinkCategory = DrinkCategory.SoftDrinks,
                    SubCategory = DrinkSubCategory.Pop,
                    ContainsAlcohol = false,
                    AlcoholPercentage = 0,
                    DrinkBrand = "CocaCola"
                },

                new Drink
                {
                    ProductID = 19,
                    DrinkCategory = DrinkCategory.SoftDrinks,
                    SubCategory = DrinkSubCategory.Pop,
                    ContainsAlcohol = false,
                    AlcoholPercentage = 0,
                    DrinkBrand = "CocaCola"
                },

                new Drink
                {
                    ProductID = 20,
                    DrinkCategory = DrinkCategory.SoftDrinks,
                    SubCategory = DrinkSubCategory.Tonic,
                    ContainsAlcohol = false,
                    AlcoholPercentage = 0,
                    DrinkBrand = "Fever Tree"
                },

                new Drink
                {
                    ProductID = 21,
                    DrinkCategory = DrinkCategory.HotDrinks,
                    SubCategory = DrinkSubCategory.Coffee,
                    ContainsAlcohol = false,
                    AlcoholPercentage = 0,
                    DrinkBrand = "Illy"
                },

                new Drink
                {
                    ProductID = 22,
                    DrinkCategory = DrinkCategory.HotDrinks,
                    SubCategory = DrinkSubCategory.Coffee,
                    ContainsAlcohol = false,
                    AlcoholPercentage = 0,
                    DrinkBrand = "Illy"
                },

                new Drink
                {
                    ProductID = 23,
                    DrinkCategory = DrinkCategory.HotDrinks,
                    SubCategory = DrinkSubCategory.Coffee,
                    ContainsAlcohol = false,
                    AlcoholPercentage = 0,
                    DrinkBrand = "Illy"
                },

                new Drink
                {
                    ProductID = 24,
                    DrinkCategory = DrinkCategory.HotDrinks,
                    SubCategory = DrinkSubCategory.Coffee,
                    ContainsAlcohol = false,
                    AlcoholPercentage = 0,
                    DrinkBrand = "Illy"
                },

                new Drink
                {
                    ProductID = 25,
                    DrinkCategory = DrinkCategory.Wines,
                    SubCategory = DrinkSubCategory.White,
                    ContainsAlcohol = true,
                    AlcoholPercentage = 12,
                    DrinkBrand = "Mondelli"
                },

                new Drink
                {
                    ProductID = 26,
                    DrinkCategory = DrinkCategory.Wines,
                    SubCategory = DrinkSubCategory.Red,
                    ContainsAlcohol = true,
                    AlcoholPercentage = 14,
                    DrinkBrand = "Campo Viejo"
                },

                new Drink
                {
                    ProductID = 27,
                    DrinkCategory = DrinkCategory.Wines,
                    SubCategory = DrinkSubCategory.Red,
                    ContainsAlcohol = true,
                    AlcoholPercentage = 13.5,
                    DrinkBrand = "Yellow Tail"
                },

                new Drink
                {
                    ProductID = 28,
                    DrinkCategory = DrinkCategory.Wines,
                    SubCategory = DrinkSubCategory.Red,
                    ContainsAlcohol = true,
                    AlcoholPercentage = 13.5,
                    DrinkBrand = "Barefoot"
                },

                new Drink
                {
                    ProductID = 40,
                    DrinkCategory = DrinkCategory.HotDrinks,
                    SubCategory = DrinkSubCategory.Tea,
                    ContainsAlcohol = false,
                    AlcoholPercentage = 0,
                    DrinkBrand = "Pukka"
                },

                new Drink
                {
                    ProductID = 50,
                    DrinkCategory = DrinkCategory.Wines,
                    SubCategory = DrinkSubCategory.White,
                    ContainsAlcohol = true,
                    AlcoholPercentage = 11.5,
                    DrinkBrand = "Gallo"
                },

                new Drink
                {
                    ProductID = 51,
                    DrinkCategory = DrinkCategory.Wines,
                    SubCategory = DrinkSubCategory.White,
                    ContainsAlcohol = true,
                    AlcoholPercentage = 14.5,
                    DrinkBrand = "Dark Horse"
                },

                new Drink
                {
                    ProductID = 52,
                    DrinkCategory = DrinkCategory.Wines,
                    SubCategory = DrinkSubCategory.White,
                    ContainsAlcohol = true,
                    AlcoholPercentage = 13,
                    DrinkBrand = "Oyster Bay"
                },

                new Drink
                {
                    ProductID = 54,
                    DrinkCategory = DrinkCategory.HotDrinks,
                    SubCategory = DrinkSubCategory.Tea,
                    ContainsAlcohol = false,
                    AlcoholPercentage = 0,
                    DrinkBrand = "Pukka"
                },
            };

            context.Drinks.AddRange(drinks);
            context.SaveChanges();
        }


        private static void AddFood(ApplicationDbContext context)
        {
            if (context.Food.Any())
            {
                return;
            }

            var food = new Food[]
{
                new Food
                {
                    ProductID = 1,
                    FoodCategory = FoodCategory.Mains,
                    Calories = 600,
                    ContainsNuts = true,
                    ContainsGluten = true,
                    IsVegetarian = true,
                    IsVegan = true,
                },

                new Food
                {
                    ProductID = 29,
                    FoodCategory = FoodCategory.Mains,
                    Calories = 550,
                    ContainsNuts = false,
                    ContainsGluten = true,
                    IsVegetarian = true,
                    IsVegan = false,
                },

                new Food
                {
                    ProductID = 30,
                    FoodCategory = FoodCategory.Mains,
                    Calories = 700,
                    ContainsNuts = false,
                    ContainsGluten = true,
                    IsVegetarian = false,
                    IsVegan = false,
                },

                new Food
                {
                    ProductID = 31,
                    FoodCategory = FoodCategory.Mains,
                    Calories = 850,
                    ContainsNuts = false,
                    ContainsGluten = true,
                    IsVegetarian = false,
                    IsVegan = false,
                },

                new Food
                {
                    ProductID = 32,
                    FoodCategory = FoodCategory.Mains,
                    Calories = 1300,
                    ContainsNuts = false,
                    ContainsGluten = true,
                    IsVegetarian = false,
                    IsVegan = false,
                },

                new Food
                {
                    ProductID = 33,
                    FoodCategory = FoodCategory.Starters,
                    Calories = 300,
                    ContainsNuts = false,
                    ContainsGluten = true,
                    IsVegetarian = false,
                    IsVegan = false,
                },

                new Food
                {
                    ProductID = 34,
                    FoodCategory = FoodCategory.Starters,
                    Calories = 330,
                    ContainsNuts = false,
                    ContainsGluten = true,
                    IsVegetarian = true,
                    IsVegan = true,
                },

                new Food
                {
                    ProductID = 35,
                    FoodCategory = FoodCategory.Starters,
                    Calories = 250,
                    ContainsNuts = false,
                    ContainsGluten = true,
                    IsVegetarian = false,
                    IsVegan = false,
                },

                new Food
                {
                    ProductID = 36,
                    FoodCategory = FoodCategory.Starters,
                    Calories = 600,
                    ContainsNuts = false,
                    ContainsGluten = false,
                    IsVegetarian = true,
                    IsVegan = false,
                },

                new Food
                {
                    ProductID = 37,
                    FoodCategory = FoodCategory.Starters,
                    Calories = 450,
                    ContainsNuts = false,
                    ContainsGluten = false,
                    IsVegetarian = false,
                    IsVegan = false,
                },

                new Food
                {
                    ProductID = 38,
                    FoodCategory = FoodCategory.Mains,
                    Calories = 525,
                    ContainsNuts = false,
                    ContainsGluten = false,
                    IsVegetarian = false,
                    IsVegan = false,
                },

                new Food
                {
                    ProductID = 39,
                    FoodCategory = FoodCategory.Mains,
                    Calories = 500,
                    ContainsNuts = false,
                    ContainsGluten = false,
                    IsVegetarian = true,
                    IsVegan = true,
                },

                new Food
                {
                    ProductID = 41,
                    FoodCategory = FoodCategory.Mains,
                    Calories = 575,
                    ContainsNuts = false,
                    ContainsGluten = false,
                    IsVegetarian = true,
                    IsVegan = false,
                },

                new Food
                {
                    ProductID = 42,
                    FoodCategory = FoodCategory.Sides,
                    Calories = 350,
                    ContainsNuts = false,
                    ContainsGluten = false,
                    IsVegetarian = true,
                    IsVegan = true,
                },

                new Food
                {
                    ProductID = 43,
                    FoodCategory = FoodCategory.Sides,
                    Calories = 300,
                    ContainsNuts = false,
                    ContainsGluten = false,
                    IsVegetarian = true,
                    IsVegan = true,
                },

                new Food
                {
                    ProductID = 44,
                    FoodCategory = FoodCategory.Sides,
                    Calories = 375,
                    ContainsNuts = false,
                    ContainsGluten = true,
                    IsVegetarian = true,
                    IsVegan = true,
                },

                new Food
                {
                    ProductID = 45,
                    FoodCategory = FoodCategory.Sides,
                    Calories = 400,
                    ContainsNuts = false,
                    ContainsGluten = false,
                    IsVegetarian = true,
                    IsVegan = false,
                },

                new Food
                {
                    ProductID = 46,
                    FoodCategory = FoodCategory.Desserts,
                    Calories = 450,
                    ContainsNuts = false,
                    ContainsGluten = true,
                    IsVegetarian = true,
                    IsVegan = false,
                },

                new Food
                {
                    ProductID = 47,
                    FoodCategory = FoodCategory.Desserts,
                    Calories = 500,
                    ContainsNuts = false,
                    ContainsGluten = false,
                    IsVegetarian = true,
                    IsVegan = true,
                },

                new Food
                {
                    ProductID = 48,
                    FoodCategory = FoodCategory.Desserts,
                    Calories = 470,
                    ContainsNuts = false,
                    ContainsGluten = true,
                    IsVegetarian = true,
                    IsVegan = false,
                },

                new Food
                {
                    ProductID = 49,
                    FoodCategory = FoodCategory.Desserts,
                    Calories = 500,
                    ContainsNuts = false,
                    ContainsGluten = true,
                    IsVegetarian = true,
                    IsVegan = false,
                },

                new Food
                {
                    ProductID = 53,
                    FoodCategory = FoodCategory.Mains,
                    Calories = 600,
                    ContainsNuts = false,
                    ContainsGluten = false,
                    IsVegetarian = false,
                    IsVegan = false,
                },
            };

            context.Food.AddRange(food);
            context.SaveChanges();
        }









        private static void AddOrder(ApplicationDbContext context)
        {
            if (context.Orders.Any())
            {
                return;
            }

            var orders = new Order[]
            {
                new Order
                {
                    PersonID = 1,
                    PaymentID = "0444 2345 2849 4825",
                    StaffName = "Mark",
                    TableNo = 10,
                    OrderDate = DateTime.Parse("2021-12-01"),
                },

                new Order
                {
                    PersonID = 2,
                    PaymentID = "1111 2345 2849 4825",
                    StaffName = "Elon",
                    TableNo = 21,
                    OrderDate = DateTime.Parse("2021-12-01"),
                },

                new Order
                {
                    PersonID = 3,
                    PaymentID = "0999 2345 2849 4825",
                    StaffName = "Mark",
                    TableNo = 8,
                    OrderDate = DateTime.Parse("2021-12-01"),
                },

                new Order
                {
                    PersonID = 4,
                    PaymentID = "0888 2345 2849 4825",
                    StaffName = "Bill",
                    TableNo = 34,
                    OrderDate = DateTime.Parse("2021-12-01"),
                },

                new Order
                {
                    PersonID = 5,
                    PaymentID = "0777 2345 2849 4825",
                    StaffName = "Bill",
                    TableNo = 11,
                    OrderDate = DateTime.Parse("2021-12-01"),
                },

                new Order
                {
                    PersonID = 6,
                    PaymentID = "0666 2345 2849 4825",
                    StaffName = "Jeff",
                    TableNo = 32,
                    OrderDate = DateTime.Parse("2021-12-01"),
                },

                new Order
                {
                    PersonID = 7,
                    PaymentID = "0555 2345 2849 4825",
                    StaffName = "Elon",
                    TableNo = 43,
                    OrderDate = DateTime.Parse("2021-12-01"),
                },

                new Order
                {
                    PersonID = 8,
                    PaymentID = "0333 2345 2849 4825",
                    StaffName = "Jeff",
                    TableNo = 3,
                    OrderDate = DateTime.Parse("2021-12-01"),
                },

                new Order

                {
                    PersonID = 9,
                    PaymentID = "0111 4387 3298 2848",
                    StaffName = "Bill",
                    TableNo = 49,
                    OrderDate = DateTime.Parse("2021-12-01"),
                },

                new Order
                {
                    PersonID = 10,
                    PaymentID = "0222 5487 4398 2094",
                    StaffName = "Mark",
                    TableNo = 9,
                    OrderDate = DateTime.Parse("2021-12-01"),
                },

            };

            context.Orders.AddRange(orders);
            context.SaveChanges();
        }


        private static void AddOrderItem(ApplicationDbContext context)
        {
            if (context.OrderItems.Any())
            {
                return;
            }

            var order_items = new OrderItem[]
            {
                // A single order(1)
                // 2 x Prosecco
                // 2 x The Veggie One
                new OrderItem
                {
                    OrderID = 1,
                    ProductID = 3,
                    UnitPrice = 5.60m,
                    Quantity = 2,
                    
                },

                new OrderItem
                {
                    OrderID = 1,
                    ProductID = 29,
                    UnitPrice = 10.50m,
                    Quantity = 2,
                },
                new OrderItem
                {
                    OrderID = 1,
                    ProductID = 47,
                    UnitPrice = 5.50m,
                    Quantity = 2,
                },

                // A single Order(2)
                // 2 x Sauvignon Blanc
                // 1 x Coca Cola
                // 2 x Chicken Wrap
                // 1 x Big Bad Burger
                new OrderItem
                {
                    OrderID = 2,
                    ProductID = 52,
                    UnitPrice = 5.90m,
                    Quantity = 2,
                },

                new OrderItem
                {
                    OrderID = 2,
                    ProductID = 19,
                    UnitPrice = 2.60m,
                    Quantity = 1,
                },

                new OrderItem
                {
                    OrderID = 2,
                    ProductID = 38,
                    UnitPrice = 6.90m,
                    Quantity = 2,
                },

                new OrderItem
                {
                    OrderID = 2,
                    ProductID = 31,
                    UnitPrice = 12.20m,
                    Quantity = 1,
                },

                // A single Order(3)
                // 1 x Champagne
                // 2 x Waffles
                new OrderItem
                {
                    OrderID = 3,
                    ProductID = 5,
                    UnitPrice = 79.90m,
                    Quantity = 1,
                },

                new OrderItem
                {
                    OrderID = 3,
                    ProductID = 49,
                    UnitPrice = 6.10m,
                    Quantity = 2,
                },

                // A single Order(4)
                // 3 x Latte
                // 2 x Chicken Pops
                // 1 x Zuckerburger
                // 1 x Snack Shack Burger
                // 1 x Apple Pie
                // 1 x Churros
                new OrderItem
                {
                    OrderID = 4,
                    ProductID = 22,
                    UnitPrice = 3.20m,
                    Quantity = 3,
                },

                new OrderItem
                {
                    OrderID = 4,
                    ProductID = 32,
                    UnitPrice = 5.60m,
                    Quantity = 2,
                },

                new OrderItem
                {
                    OrderID = 4,
                    ProductID = 32,
                    UnitPrice = 11.90m,
                    Quantity = 1,
                },

                new OrderItem
                {
                    OrderID = 4,
                    ProductID = 30,
                    UnitPrice = 10.90m,
                    Quantity = 1,
                },

                new OrderItem
                {
                    OrderID = 4,
                    ProductID = 48,
                    UnitPrice = 5.90m,
                    Quantity = 1,
                },

                new OrderItem
                {
                    OrderID = 4,
                    ProductID = 46,
                    UnitPrice = 5.20m,
                    Quantity = 1,
                },

                // A single Order(5)
                // 1 x Sparkling water
                // 1 x Falafel Wrap
                new OrderItem
                {
                    OrderID = 5,
                    ProductID = 17,
                    UnitPrice = 2.40m,
                    Quantity = 1,
                },

                new OrderItem
                {
                    OrderID = 5,
                    ProductID = 39,
                    UnitPrice = 5.90m,
                    Quantity = 1,
                },

                // A single Order(6)
                // 2 x Earl Grey Tea
                // 2 x Hummus and Flatbread
                new OrderItem
                {
                    OrderID = 6,
                    ProductID = 54,
                    UnitPrice = 2.40m,
                    Quantity = 2,
                },

                new OrderItem
                {
                    OrderID = 6,
                    ProductID = 34,
                    UnitPrice = 5.90m,
                    Quantity = 2,
                },

                // A single Order(7)
                // 1 x Bottle Cava
                // 3 x Big Bad Burger
                // 2 x Homemade Slaw
                new OrderItem
                {
                    OrderID = 7,
                    ProductID = 4,
                    UnitPrice = 29.90m,
                    Quantity = 1,
                },

                new OrderItem
                {
                    OrderID = 7,
                    ProductID = 31,
                    UnitPrice = 12.20m,
                    Quantity = 3,
                },

                new OrderItem
                {
                    OrderID = 7,
                    ProductID = 45,
                    UnitPrice = 3.20m,
                    Quantity = 2,
                },

                // A single Order(8)
                // 1 x English Breakfast Tea
                new OrderItem
                {
                    OrderID = 8,
                    ProductID = 40,
                    UnitPrice = 2.40m,
                    Quantity = 1,
                },

                // A single Order(9)
                // 2 x Tonic Water
                // 2 x Flor de Sevilla
                // 2 x Halloumi Wrap
                // 1 x Onion Rings
                // 1 x Waffles
                // 1 x Mocha
                new OrderItem
                {
                    OrderID = 9,
                    ProductID = 20,
                    UnitPrice = 2.60m,
                    Quantity = 2,
                },

                new OrderItem
                {
                    OrderID = 9,
                    ProductID = 11,
                    UnitPrice = 3.90m,
                    Quantity = 2,
                },

                new OrderItem
                {
                    OrderID = 9,
                    ProductID = 41,
                    UnitPrice = 5.90m,
                    Quantity = 2,
                },

                new OrderItem
                {
                    OrderID = 9,
                    ProductID = 44,
                    UnitPrice = 3.30m,
                    Quantity = 1,
                },

                

                new OrderItem
                {
                    OrderID = 9,
                    ProductID = 24,
                    UnitPrice = 3.40m,
                    Quantity = 1,
                },

                // A single Order(10)
                // 1 x Pinot Blush
                // 1 x Sharer Nachos
                new OrderItem
                {
                    OrderID = 10,
                    ProductID = 25,
                    UnitPrice = 5.60m,
                    Quantity = 2,
                },

                new OrderItem
                {
                    OrderID = 10,
                    ProductID = 36,
                    UnitPrice = 8.40m,
                    Quantity = 1,
                },
            };

            context.OrderItems.AddRange(order_items);
            context.SaveChanges();
        }


        private static void AddFeedback(ApplicationDbContext context)
        {
            if (context.Feedback.Any())
            {
                return;
            }

            var feedback = new Feedback[]
            {
                new Feedback
                {
                    OrderID = 1,
                    FeedbackMessage = "Best Veggie burger I've ever had!!",
                    CustomerReviewDate = DateTime.Parse("2021-12-01"),
                },

                new Feedback
                {
                    OrderID = 2,
                    FeedbackMessage = "Good place, friendly staff. Chuffed " +
                    "they had my favourite Oyster Bay Sauvignon Blanc. Would " +
                    "recommend!",
                    CustomerReviewDate = DateTime.Parse("2021-12-01")
                },

                new Feedback
                {
                    OrderID = 3,
                    FeedbackMessage = "Popped in for mine and my partners " +
                    "one year anniversary for some fizz and desserts. " +
                    "Have to say, Mark really went out his way to make it " +
                    "special with getting the chefs to make the waffles into " +
                    "love hearts! Can't wait to come back and try one of the " +
                    "burgers.",
                    CustomerReviewDate = DateTime.Parse("2021-12-01")
                },

                new Feedback
                {
                    OrderID = 4,
                    FeedbackMessage = "Good food, reasonable price. " +
                    "The application makes ordering really easy.",
                    CustomerReviewDate = DateTime.Parse("2021-12-01")
                },

                new Feedback
                {
                    OrderID = 5,
                    FeedbackMessage = "So happy to find such a tasty vegan " +
                    "option. Will be recommending!",
                    CustomerReviewDate = DateTime.Parse("2021-12-01")
                },

                new Feedback
                {
                    OrderID = 6,
                    FeedbackMessage = "Myself and a girlfriend popped in here. Nice " +
                    "surroundings, food was okay - would have liked a bit more flat" +
                    "bread with the hummus!",
                    CustomerReviewDate = DateTime.Parse("2021-12-01")
                },

                new Feedback
                {
                    OrderID = 7,
                    FeedbackMessage = "Came here for the 3rd time in a month, we " +
                    "love the Big Bad Burger. Sadly this time my sons came out a little " +
                    "cold but the Manager, Elon, came out apologised and gave us a gift " +
                    "card for next time. I still recommend - lovely staff!)",
                    CustomerReviewDate = DateTime.Parse("2021-12-01")
                },

                new Feedback
                {
                    OrderID = 8,
                    FeedbackMessage = "Just popped in for a tea. Cosy decor.",
                    CustomerReviewDate = DateTime.Parse("2021-12-01")
                },

                new Feedback
                {
                    OrderID = 9,
                    FeedbackMessage = "Good Veggie selection. Nice gin!",
                    CustomerReviewDate = DateTime.Parse("2021-12-01")
                },

                new Feedback
                {
                    OrderID = 10,
                    FeedbackMessage = "Only came in for a quick wine and some " +
                    "nachos but the staff were super friendly and chatted to me for " +
                    "a while. I live on my own so it was great to talk! Will definitely" +
                    "be coming back. Thanks guys!",
                    CustomerReviewDate = DateTime.Parse("2021-12-01")
                },
            };

            context.Feedback.AddRange(feedback);
            context.SaveChanges();
        }
    }
}

            




