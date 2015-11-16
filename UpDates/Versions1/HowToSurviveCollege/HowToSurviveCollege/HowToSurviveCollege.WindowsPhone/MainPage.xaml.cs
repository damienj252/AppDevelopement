using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace HowToSurviveCollege
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        //private object NavigationService;

        public MainPage()
        {
            this.InitializeComponent();
            addTheContent();
            
        }//MianPage

        private void addTheContent()
        {
            tblFood.Text = "Easy to cook dinners:" + System.Environment.NewLine + System.Environment.NewLine + 
                            " " +
                           "Fillet of Beef W/Sweet & Sour Peppers" + System.Environment.NewLine +
                           "Ingrediants:" + System.Environment.NewLine +
                           "4 Fillet steaks (170g & 3cm  thick)" + System.Environment.NewLine +
                           "6/7 tbsp olive oil, plus extra to drizzle" + System.Environment.NewLine +
                           "Sea salt & milled black pepper" + System.Environment.NewLine +
                           "1 tbsp juniper berries" + System.Environment.NewLine +
                           "Lightly crushed handful of thyme sprigs" + System.Environment.NewLine +
                           "3 Red peppers sliced" + System.Environment.NewLine +
                           "3 Yellow peppers sliced" + System.Environment.NewLine +
                           "2 tbsp white wine vinegar" + System.Environment.NewLine +
                           " " +
                           "How to cook it:" + System.Environment.NewLine +
                           "Place the fillet of beef in a shallow dish with 2-3 tbsp of olive oil. Season lightly and scatter over the juniper berries & a few thyme sprigs. Leave to marinate while you cook peppers." + System.Environment.NewLine +
                           "Heat 2 tbsp olive oil in a large pan add red & yellow peppers. Add a few thyme sprigs & cook over medium heat for 5 mins. Pour in the wine vinegar& reduce right down." + System.Environment.NewLine +
                           "Remove from heat & keep warm." + System.Environment.NewLine +
                           "Heat another heavy-based pan add remaining olive oil. When very hot sear fillets for 3-4 mins on each side. Rest in warm place for 5 mins." + System.Environment.NewLine +
                           "Divide peppers among warm plates. Slice fillets thickly on the diagonal & arrange on top of the peppers. Drizzle with a little olive oil to serve" + System.Environment.NewLine +
                           " " +
                           "Pan fried stuffed fillet of chicken" + System.Environment.NewLine +
                           " " + System.Environment.NewLine + System.Environment.NewLine +
                           "Ingrediants: " + System.Environment.NewLine +
                           "1 Whole Chicken " + System.Environment.NewLine +
                           "250ml Chicken Stock " + System.Environment.NewLine +
                           "8 Tiger Prawns " + System.Environment.NewLine +
                           "100g Sun dried tomatoes " + System.Environment.NewLine +
                           "2 Large Potatoes " + System.Environment.NewLine +
                           "3 Scallions " + System.Environment.NewLine +
                           "100g Unsalted butter" + System.Environment.NewLine +
                           "2 Cloves Garlic " + System.Environment.NewLine +
                           "50ml Olive oil" + System.Environment.NewLine +
                           "Bread 3 slices " + System.Environment.NewLine +
                           "100g Mushrooms " + System.Environment.NewLine +
                           "50ml Brandy" + System.Environment.NewLine +
                           "2 medium Carrots " + System.Environment.NewLine +
                           "2 medium Courgette" + System.Environment.NewLine +
                           "Fresh Thyme pinch " + System.Environment.NewLine +
                           "1 Lemon " + System.Environment.NewLine +
                           "100g Onion " + System.Environment.NewLine +
                           "Freshly ground mill pepper " + System.Environment.NewLine +
                           "8 Fresh Asparagus heads " + System.Environment.NewLine +
                           " " + System.Environment.NewLine + System.Environment.NewLine +
                           "How to cook: " + System.Environment.NewLine +
                           "Prepare whole chicken. " + System.Environment.NewLine +
                           "Infuse chopped chicken bones into stock. " + System.Environment.NewLine +
                           "Combine prawn, basil and sun dried tomatoes to stuff chicken. " + System.Environment.NewLine +
                           "Make garlic chicken puree. " + System.Environment.NewLine +
                           "Cook vegetables in hot stock until tender. Cook potatoes in seasoned water until tender, strain, mash, add scallions, olive oil, butter &cream. " + System.Environment.NewLine +
                           "Pan fry chicken on both sides, finish cooking in oven. " + System.Environment.NewLine +
                           "Spread garlic chicken puree on bread, place in hot oven until crispy. " + System.Environment.NewLine +
                           "Sweat sliced mushrooms flame brandy, add chicken stock reduce add cream and reduce until coating consistency. " + System.Environment.NewLine +
                           " " + System.Environment.NewLine + System.Environment.NewLine +
                           "Pan fried salmon on a cod brandade potato " + System.Environment.NewLine +
                           " " + System.Environment.NewLine + System.Environment.NewLine +
                           "Ingrediants: " + System.Environment.NewLine +
                           "2 Supremes of salmon " + System.Environment.NewLine + 
                           "2 Anchovies " + System.Environment.NewLine +
                           "100ml Tomato oil " + System.Environment.NewLine +
                           "250g Salted Cod " + System.Environment.NewLine +
                           "3 cloves of garlic " + System.Environment.NewLine +
                           "½ each of yellow & red pepper " + System.Environment.NewLine +
                           "3 Spring onions " + System.Environment.NewLine +
                           "2 Cloves " + System.Environment.NewLine +
                           "4 - 5 New potatoes " + System.Environment.NewLine +
                           "1 Egg yolk " + System.Environment.NewLine +
                           "Freshly Milled Pepper to season " + System.Environment.NewLine +
                           "½ each of  courgette & red onion " + System.Environment.NewLine +
                           "1 tsp Balsamic vinegar " + System.Environment.NewLine +
                           "2 tsp Olive oil " + System.Environment.NewLine +
                           "1 tsp Dijon mustard " + System.Environment.NewLine +
                           "500g Vine Cherry tomatoes " + System.Environment.NewLine +
                           "50 ml Hazelnut oil " + System.Environment.NewLine +
                           "20 ml Cream " + System.Environment.NewLine +
                           "10g Butter " + System.Environment.NewLine +
                           "10 Basel leaves (fresh) " + System.Environment.NewLine +
                           "5g Parsley(fresh) " + System.Environment.NewLine +
                           " " + System.Environment.NewLine + System.Environment.NewLine +
                           "How to cook it: " + System.Environment.NewLine +
                           "Peel garlic. " + System.Environment.NewLine +
                           "Make tapenade. " + System.Environment.NewLine +
                           "Marinate salmon. " + System.Environment.NewLine +
                           "Poach cod. " + System.Environment.NewLine +
                           "Liquidise cherry tomatoes. " + System.Environment.NewLine +
                           "Strain reduced sauce. " + System.Environment.NewLine +
                           "Peel & cut potatoes. " + System.Environment.NewLine +
                           "Prepare vegetables, herbs & spring onion, remove cooked cod. " + System.Environment.NewLine +
                           "Cook potatoes & skim sauce. " + System.Environment.NewLine +
                           "Cook salmon, roast vegetables. " + System.Environment.NewLine +
                           "Prepare spring onions for garnish. " + System.Environment.NewLine +
                           "Check brandade &sauce for seasoning. " + System.Environment.NewLine +
                           " " + System.Environment.NewLine + System.Environment.NewLine +
                           "Seafood chowder " + System.Environment.NewLine +
                           " " + System.Environment.NewLine + System.Environment.NewLine +
                           "Ingrediants: " + System.Environment.NewLine +
                           "50g Unsalted butter " + System.Environment.NewLine +
                           "2 Diced onions (medium) " + System.Environment.NewLine +
                           "50g Leeks " + System.Environment.NewLine +
                           "50g Celery(diced) " + System.Environment.NewLine +
                           "50g Corn(fresh) " + System.Environment.NewLine +
                           "250g Potatoes(diced) " + System.Environment.NewLine +
                           "120g Smoked Fish " +
                           "200g Fresh Fish (prawns, shrimp, mussels, Salmon, monkfish) " + System.Environment.NewLine +
                           "1 Bay leaf " + System.Environment.NewLine +
                           "80ml White Wine " + System.Environment.NewLine +
                           "600ml Fish stock " + System.Environment.NewLine +
                           "150ml Cream " + System.Environment.NewLine +
                           "20g Fresh Parsley(chopped) " + System.Environment.NewLine +
                           "30g Fresh Dill(chopped) " + System.Environment.NewLine +
                           "20g Fresh Tarragon(chopped) " + System.Environment.NewLine +
                           "Freshly Milled Pepper to season " + System.Environment.NewLine +
                           " " + System.Environment.NewLine + System.Environment.NewLine +
                           "How to cook: " + System.Environment.NewLine +
                           "Melt butter in large pot, add leeks, celery and onions, cook for 3 - 4 minutes without colour(sweat). " + System.Environment.NewLine +
                           "Add potatoes, bay leaf and white wine cook for a further 3 minutes. " + System.Environment.NewLine +
                           "Add fish stock and bring to the boil. " + System.Environment.NewLine +
                           "Add the fish and simmer for 5 - 8 minutes over a medium heat. " + System.Environment.NewLine +
                           "Add cream and fresh herbs(parsley, dill, tarragon) season with freshly milled pepper, bring back to the boil. " + System.Environment.NewLine +
                           "Serve with wholemeal brown bread. ";

           tblAccomodation.Text = "Tips on getting your deposit back:" + System.Environment.NewLine +
                                    "Record all bill payments, by law they are recorded in your rent or by receipt." + System.Environment.NewLine +
                                    "All appliances and furniture must be listed." + System.Environment.NewLine +
                                    "Take photographs of every room and all damaged items if any when you move in and out." + System.Environment.NewLine +
                                    "Look after your accomodation and inform your landlord of any damages." + System.Environment.NewLine +
                                    "Give appropriate notice when leaving." + System.Environment.NewLine +
                                    "Make sure all bills are paid for before leaving." + System.Environment.NewLine +
                                    "When you leave your landlord must return your deposit unless it is to pay for damages or if you have signed a contract saying that they can give it back on a later date." + System.Environment.NewLine +
                                    "The deposit belongs to you NOT your landlord." + System.Environment.NewLine +
                                    "Ask for a receipt of damages in case of unfair deductions and query about them.";

            tblNightLife.Text = "Welcome to Galway, get ready for the time of your life "  + System.Environment.NewLine +
                                "There are many great places to go out in Galway." + System.Environment.NewLine +
                                "Monday nights I would recomend Carbon the night club." + System.Environment.NewLine +
                                "Tuesday drinks in. " + System.Environment.NewLine +
                                "Wedbesday: depending on promotions I would recommend Electric" + System.Environment.NewLine +
                                "Thursday: I wouuld recommend 44 " + System.Environment.NewLine +
                                "Great student pubs include Fibber MeGees, Hole in the wall and the front door." + System.Environment.NewLine +
                                "There is such a variety of places to go out in Galway it's hard to say which is the best but my advice is try them all. " + System.Environment.NewLine +
                                "Don't forget, never walk home alone " + System.Environment.NewLine +
                                "Welcome to Galway, get ready for the time of your life ";

            tblCollegeServices.Text = "There are many great services in all colleges in Galway." + System.Environment.NewLine +
                                       "College councilers " + System.Environment.NewLine +
                                       "College bars. " + System.Environment.NewLine +
                                       "Shops: food and stationary for college " + System.Environment.NewLine +
                                       "Students Union " + System.Environment.NewLine +
                                       "Library with every book you could ever need as well as printing etc. " + System.Environment.NewLine +
                                       "Internet connection. " + System.Environment.NewLine +
                                       "Free grinds and IT center. " ;



        }//addTheContent()



    }//partial class
}//namespace
