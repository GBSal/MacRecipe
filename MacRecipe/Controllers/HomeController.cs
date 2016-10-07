using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MacRecipe.Services;
using MacRecipe.Models;

namespace MacRecipe.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            List<RecipeModel> recipes = GetSampleRecipes();

            return View(recipes);

            
        }

        public ActionResult Invites()
        {
            ViewBag.Message = "Send out invites";

            return View();
        }

        public ActionResult SelectRceipe ()
        {
            ViewBag.Message = "Select your recipe";

            return View();
        }

    


        [HttpPost]
        public ActionResult Index(List<RecipeModel> recipesModel)
        {
         
            string selectedRecipes = string.Empty;
            foreach (var recipe in recipesModel)
            {
                if (recipe.Cook)
                {
                    selectedRecipes = selectedRecipes + recipe.Id + ",";
                }
            }
            selectedRecipes.Remove(selectedRecipes.Length - 1);
            return RedirectToAction("InviteFriends", new { selectedRecipes = selectedRecipes });

        }


        public ActionResult EmailTest(string Email)
        { 
            
            

            var email = new SendGridEmailService();

            string msg="";

            List<String> recipients = new List<String>
                {
                    @"Mohammad Salman<msalman@macmillan.org.uk>",
                    @"Mohammad Salman<macrecipe@mailinator.com>"

                };


            try
            {
                email.InviteEmail(recipients, "XDFSERDSD");

                email.NotityEmail(recipients);
            }

            catch (Exception ex)
            {
                msg = ex.Message;

                    
            }
            ViewBag.Msg = msg;

            return View();

        }



        public List<RecipeModel> GetSampleRecipes()
        {
            
            {
                RecipeModel model = new RecipeModel();
                model.Id = 1;
                model.Title = "Broccoli mornay";
                model.Summary = "Serves 4. Preparation: 15 minutes. Cooking: 1 hour. With thanks to Elizabeth Ward for contributing this recipe.";
                model.Donation = "9.99 £";
                model.Thumbnail = "http://www.macmillan.org.uk/_images/Broccoli-mornay-recipe_tcm9-22703.jpg";
                model.Cook = false;
                List<RecipeModel> recipes = new List<RecipeModel>();
                recipes.Add(model);
                RecipeModel model1 = new RecipeModel();
                model1.Id = 2;
                model1.Title = "Chiken curry";
                model1.Summary = "Serves 2. Preparation 15 minutes. Cooking 45 minutes. With thanks to NHS Choices for contributing this recipe.";
                model1.Donation = "8.99£";
                model1.Thumbnail = "http://www.macmillan.org.uk/_images/Chicken-curry-recipe_tcm9-22704.jpg";
                model1.Cook = false;
                recipes.Add(model1);
                RecipeModel model2 = new RecipeModel();
                model2.Id = 3;
                model2.Title = "One-pot fish with black olives &amp; tomatoes";
                model2.Summary = "Serves 2. Preparation 15 minutes. Cooking 45 minutes. With thanks to NHS Choices for contributing this recipe.";
                model2.Donation = "8.99£";
                model2.Thumbnail = "http://www.macmillan.org.uk/_images/One-pot-fish-black-olives-tomato-recipe_tcm9-22711.jpg";
                model2.Cook = false;
                recipes.Add(model2);
                RecipeModel model3 = new RecipeModel();
                model3.Id = 4;
                model3.Title = "Smoked fish chowder";
                model3.Summary = "Serves 2. Preparation 15 minutes. Cooking 45 minutes. With thanks to NHS Choices for contributing this recipe.";
                model3.Donation = "8.99£";
                model3.Thumbnail = "http://www.macmillan.org.uk/_images/fish-chowder490x490_tcm9-22715.jpg";
                model3.Cook = false;
                recipes.Add(model3);
                RecipeModel model4 = new RecipeModel();
                model4.Id = 5;
                model4.Title = "Chicken thighs with crumbed tomatoes";
                model4.Summary = "Serves 2. Preparation 15 minutes. Cooking 45 minutes. With thanks to NHS Choices for contributing this recipe.";
                model4.Donation = "8.99£";
                model4.Thumbnail = "http://www.macmillan.org.uk/_images/Chicken-thighs-crumbed-tomato-recipe_tcm9-22706.jpg";
                model4.Cook = false;
                recipes.Add(model4);
                RecipeModel model5 = new RecipeModel();
                model5.Id = 6;
                model5.Title = "Chilli con carne";
                model5.Summary = "Serves 2. Preparation 15 minutes. Cooking 45 minutes. With thanks to NHS Choices for contributing this recipe.";
                model5.Donation = "8.99£";
                model5.Thumbnail = "http://www.macmillan.org.uk/_images/chilliconcarne490x490_tcm9-163241.jpg";
                model5.Cook = false;
                recipes.Add(model5);
                RecipeModel model6 = new RecipeModel();
                model6.Id = 7;
                model6.Title = "Coconut &amp; cardamom rice pudding";
                model6.Summary = "Serves 2. Preparation 15 minutes. Cooking 45 minutes. With thanks to NHS Choices for contributing this recipe.";
                model6.Donation = "8.99£";
                model6.Thumbnail = "http://www.macmillan.org.uk/_images/Coconut-cardamom-rice-pudding-recipe_tcm9-22707.jpg";
                model6.Cook = false;
                recipes.Add(model5);
                return recipes;
            }

        }
    }



}