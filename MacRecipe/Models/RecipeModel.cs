using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MacRecipe.Models
{
    public class RecipeModel
    {


        public int Id { get; set; }
        public string Title { get; set; }
        public string Donation { get; set; }
        public string Summary { get; set; }
        public string Thumbnail { get; set; }


        public bool Cook { get; set; }
        public RecipeModel()
        {

        }

        //public static List<RecipeModel> GetSampleRecipes()
        //{
        //    return new List<RecipeModel>
        //               {
        //                   new RecipeModel(id:1, title: "Broccoli mornay", donation:"9.99 £", summary:"Serves 4. Preparation: 15 minutes. Cooking: 1 hour. With thanks to Elizabeth Ward for contributing this recipe.",thumbnail:"http://www.macmillan.org.uk/_images/Broccoli-mornay-recipe_tcm9-22703.jpg",cook:false),
        //                   new RecipeModel(id:2, title : "Chilen curry", donation :"8.99£", summary:"Serves 2. Preparation 15 minutes. Cooking 45 minutes. With thanks to NHS Choices for contributing this recipe.",thumbnail:"http://www.macmillan.org.uk/_images/Chicken-curry-recipe_tcm9-22704.jpg",cook:false),
        //                   new RecipeModel(id:3, title : "One-pot fish with black olives &amp; tomatoes", donation :"6.99£", summary :"Serves 4. Preparation 15 minutes. Cooking 15-20 minutes. With thanks to Good Food magazine for contributing this recipe. ",thumbnail:"http://www.macmillan.org.uk/_images/One-pot-fish-black-olives-tomato-recipe_tcm9-22711.jpg",cook:false),
        //                   new RecipeModel(id:4, title : "Smoked fish chowder", donation :"6.99£", summary :"Preparation: 15 minutes. Cooking: 30 minutes.With thanks to the Oesophageal Patients Association for contributing this recipe.",thumbnail:"http://www.macmillan.org.uk/_images/fish-chowder490x490_tcm9-22715.jpg",cook:false),
        //                   new RecipeModel(id:5, title : "Chicken thighs with crumbed tomatoes", donation :"6.99£", summary :"Serves 4. Preparation 10 minutes. Cooking 50 minutes.  With thanks to Waitrose for contributing this recipe. ",thumbnail:"http://www.macmillan.org.uk/_images/Chicken-thighs-crumbed-tomato-recipe_tcm9-22706.jpg",cook:false),
        //                   new RecipeModel(id:6, title : "Chilli con carne", donation :"4.99£", summary :"Serves 2. Preparation 10 minutes. Cooking 40 minutes. With thanks to NHS Choices for contributing this recipe.",thumbnail:"http://www.macmillan.org.uk/_images/chilliconcarne490x490_tcm9-163241.jpg",cook:false),
        //                   new RecipeModel(id:7, title : "Coconut &amp; cardamom rice pudding", donation :"7.99£", summary :"Serves 6. Preparation: 5 minutes. Cooking time: 1 hour 30 minutes. With thanks to Waitrose for contributing this recipe.",thumbnail:"http://www.macmillan.org.uk/_images/Coconut-cardamom-rice-pudding-recipe_tcm9-22707.jpg",cook:false),
        //                   new RecipeModel(id:8, title : "Spring onion, garlic &amp; prawn risotto", donation :"5.99£", summary :"Serves 4. Preparation 10 minutes. Cooking 35 minutes.",thumbnail:"http://www.macmillan.org.uk/_images/Spring-onion-garlic-prawn-risotto-recipe_tcm9-22716.jpg",cook:false),
        //                   new RecipeModel(id:9, title : "Cherry &amp; almond cake", donation :"15.99£", summary :"Serves 15. Preparation: 5 minutes. Cooking time: 1 hour. With thanks to Clare Shaw and Maureen Hunter for contributing this recipe.",thumbnail:"http://www.macmillan.org.uk/_images/glace-cherries490x490_tcm9-163264.jpg",cook:false),
        //                   new RecipeModel(id:10, title : "Brown sugar plums with soured cream", donation :"2.99£", summary :"Serves 4. Preparation: 5 minutes. Cooking: 25 minutes. With thanks to Waitrose for contributing this recipe.",thumbnail:"http://www.macmillan.org.uk/_images/brown-sugar-plums490x490_tcm9-149106.jpg,",cook:false)
        //               };
        //}



    }
}