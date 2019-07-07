
using Culinars.Pages;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Culinars
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ResultPage : Page
    {
        string Ingredients = "";
        ArrayList ItemIngredients = new ArrayList();
        ArrayList ItemImage = new ArrayList();
        ArrayList ItemName = new ArrayList();
        ArrayList NameComment = new ArrayList();
        ArrayList Recipe = new ArrayList();
        ArrayList selectedIngredients = new ArrayList();
        ArrayList selectedRecipe = new ArrayList();
        ArrayList willShownIngredients = new ArrayList();
        ArrayList SelectedImage = new ArrayList();
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            
        }
        public ResultPage()
        {
            
            this.InitializeComponent();
            validate();
            fill();
        }
        private void validate()
        {
            GetData();
            check();
            //get data
            //get data from azure
            //cross match
            // inpu to the array
        }
        private void fill()
        {
            
           for(int i = 0; i <= ItemName.Count-1; i++)
            {
                for(int j = 0; j <= selectedIngredients.Count-1; j++)
                {
                    if (ItemIngredients[i].ToString().ToUpper().Contains(selectedIngredients[j].ToString().ToUpper()))
                    { 
                        Grid myGrid = new Grid();
                        myGrid.Width = 300;
                        myGrid.Height = 260;
                        myGrid.Margin = new Thickness(10);
                        myGrid.Background = new SolidColorBrush(Color.FromArgb(163, 255, 212, 134));
                        StackPanel panel = new StackPanel();
                        panel.Background = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
                        panel.Orientation = (Orientation.Vertical);
                        panel.Height = 90;
                        panel.VerticalAlignment = VerticalAlignment.Bottom;
                        Image myImage = new Image();
                        myImage.Margin = new Thickness(20, 10, 20, 90);
                        myImage.Stretch = Stretch.UniformToFill;
                        myImage.Source = new BitmapImage(new Uri(this.BaseUri, ItemImage[i].ToString()));
                        TextBlock text1 = new TextBlock();
                        text1.Text = NameComment[i].ToString();
                        text1.Width = 260;
                        text1.Height = 67;
                        text1.TextTrimming = TextTrimming.WordEllipsis;
                        text1.TextWrapping = TextWrapping.Wrap;
                        text1.HorizontalAlignment = HorizontalAlignment.Center;
                        TextBlock text2 = new TextBlock();
                        text2.Text = ItemName[i].ToString();
                        text2.Width = 186;
                        text2.Height = 14;
                        text2.Margin = new Thickness(20, 2, 0, 0);
                        text2.FontSize = 9;
                        text2.Opacity = 0.49;
                        text2.TextTrimming = TextTrimming.WordEllipsis;
                        text2.TextWrapping = TextWrapping.Wrap;
                        text2.HorizontalAlignment = HorizontalAlignment.Left;
                        myGrid.Children.Add(panel);
                        myGrid.Children.Add(myImage);
                        panel.Children.Add(text1);
                        panel.Children.Add(text2);
                        GridView.Items.Add(myGrid);
                        TextBlock txt = new TextBlock();
                        txt.Width = 200;
                        txt.Height = 100;
                        txt.Foreground = new SolidColorBrush(Colors.Yellow);
                        selectedRecipe.Add(Recipe[i].ToString());
                        willShownIngredients.Add(ItemIngredients[i].ToString());
                        SelectedImage.Add(ItemImage[i].ToString());
                        break;                 
                    }

                }

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(HomePage));
            
        }

        private void GridView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            (App.Current as App).CurrentRecipe = selectedRecipe[GridView.SelectedIndex].ToString();
            (App.Current as App).CurrentIngredients = willShownIngredients[GridView.SelectedIndex].ToString();
            (App.Current as App).currentImage = SelectedImage[GridView.SelectedIndex].ToString();
            Frame.Navigate(typeof(Recipe), GridView.SelectedIndex);
            
        }
        private void GetData()
        {
            ItemImage.Add("/Assets/itemPicture/pizza_resmi.jpg");
            ItemIngredients.Add("Water;Bread;Tomato;Oil;Cheese;Mushroom;Pepper;Pesto;Pepperoni;Ham;Corn;Sausage;");
            ItemName.Add("Pizza");
            NameComment.Add("A homemade pizza is the perfect midweek TV supper- this version has a mild chilli kick");
            Recipe.Add("In a large mixing bowl, stir together the flour, semolina and salt. Stir in the dried yeast (or crumble in the fresh yeast, whichever you are using). Make a well in the centre of the flour mixture. Pour most of the water into the well along with the olive oil and bring the dough together with your hands or a wooden spoon. As the flour is incorporated the dough will start to take shape. Add the remaining water if the dough feels tight or hard. Turn the dough out onto a clean surface and knead for 10 minutes or until the dough is smooth and elastic. Cut off a small piece of the dough and stretch part of it as thinly as you can. If you can see the shadow of your fingers through the dough - the light should shine through the dough like a window pane - without the dough tearing, it is ready to prove. Knead the cut piece back into the dough and shape the dough into an even ball. Place in an oiled bowl, cover with a damp tea towel and allow to prove in a warm place for about 1-1½ hours, or until it has doubled in size (the temperature of your kitchen can affect the timing of this). When the dough has risen, take it out of the bowl and knock the air out. Divide the dough into two equal portions, and shape each portion into a ball. Cover the dough with a damp cloth and allow to prove again for about 15 minutes. Place a pizza stone or an upturned baking tray into the oven and preheat to its highest setting. Dust the work surface liberally with semolina. Roll out one piece of the dough to form a circle that will fit on your pizza stone or baking tray. Transfer the pizza base onto a plastic chopping board (or another upturned baking tray) dusted with semolina. The tray will be used to slide the pizza base directly onto the pizza stone.Cover the surface with half of the tomato sauce and toppings of your choice.When ready to bake, slide the pizza directly onto the pizza stone and cook for 8 - 10 minutes, or until the base is golden - brown and the toppings are bubbling.Repeat with the remaining dough, tomato sauce and toppings");

            ItemImage.Add("/Assets/itemPicture/Eritrean-Chicken-Rice-10.jpg");
            ItemIngredients.Add("Oil;Thyme;Butter;Chicken;Carrot;Onion;Pepper;Rice;");
            ItemName.Add("Chicken and Rice");
            NameComment.Add("Chicken tonight? Why not. Rely on our all-star roundup of popular chicken-and-rice recipes for creative twists on familiar favorites.Chicken and Rice");
            Recipe.Add("Preheat the oven to 400 degrees F. Drizzle the chicken breasts with olive oil and sprinkle with the ground thyme and some salt and pepper. Put the chicken in a roasting pan and roast until cooked through, about 20 minutes.Set aside. In a pot over medium heat, melt the butter and saute the celery, carrots, onions and bell peppers for 3 to 4 minutes.Sprinkle with the fresh thyme and turmeric and cook for another 2 minutes.Pour in the chicken broth, cover, bring to a simmer and simmer 30 minutes. Prepare the rice according to the package instructions; keep warm. Shred or chop the chicken and add it to the pot with the soup.Simmer for another 15 minutes.Stir in the rice and minced parsley and serve.");

            ItemImage.Add("/Assets/itemPicture/1-the-windy-city-dog.jpg");
            ItemIngredients.Add("Sausage;Mustard;Pickle;Onion;Tomato;Pepper;Salt;");
            ItemName.Add("Hot Dog");
            NameComment.Add("The Chicago Dog is a Windy City classic, and a big favorite with sports fans! The frank must be all-beef, the bun must be poppyseed, the ingredients must be piled onto the bun in the order specified. And whatever you do, don't spoil the splendor with ketchup!");
            Recipe.Add("Bring a pot of water to a boil. Reduce heat to low, place hot dog in water, and cook 5 minutes or until done. Remove hot dog and set aside. Carefully place a steamer basket into the pot and steam the hot dog bun 2 minutes or until warm. Place hot dog in the steamed bun. Pile on the toppings in this order: yellow mustard, sweet green pickle relish, onion, tomato wedges, pickle spear, sport peppers, and celery salt. The tomatoes should be nestled between the hot dog and the top of the bun. Place the pickle between the hot dog and the bottom of the bun. Don't even think about ketchup!");


            ItemImage.Add("/Assets/itemPicture/Salmon-lasagne.jpg");
            ItemIngredients.Add("Noodle;Butter;Milk;Cheese;Mushroom;Fish;Flour;Tomato;Jar;");
            ItemName.Add("Smoked Salmon Lasagna");
            NameComment.Add("Smoked salmon, dry sherry, mushrooms, Parmesan cheese, provolone and Swiss cheese all come together perfectly in this savory Italian main dish recipe.");
            Recipe.Add("Preheat oven to 375 degrees F. Lightly grease a 3-quart rectangular baking dish; set aside. Cook noodles according to package directions; drain. Rinse with cold water; drain again. Meanwhile, in a medium saucepan, heat butter over low heat. Add flour; cook and stir for 4 minutes (be careful not to let flour brown). Gradually whisk in milk, salt, and pepper. Cook and stir until slightly thickened and bubbly. Reduce heat; stir in Parmesan cheese, Swiss cheese, and sherry. Cook and stir until cheeses are melted. In a medium bowl, combine Pecorino Romano, mozzarella, provolone, and cheddar cheeses. To assemble, spread one-fourth of the sauce in prepared baking dish. Sprinkle with one-fourth of the cheese mixture. Layer with one-third of the noodles, one-fourth of the sauce, half of the tomatoes, half of the mushrooms, half of the salmon, and one-fourth of the cheese mixture. Repeat layering noodles, sauce, tomatoes, mushrooms, salmon, and cheese mixture. Top with the remaining noodles, remaining sauce, and remaining cheese mixture. Bake, uncovered, for 50 to 55 minutes or until edges are bubbly and top is lightly browned. Let stand for 15 minutes before serving. Makes 12 servings.");

            ItemImage.Add("/Assets/itemPicture/481857-1-eng-GB_spiced-beef-and-beet-goulash-soup-960x420.jpg");
            ItemIngredients.Add("Olive Oil;Steak;Flour;Onion;Garlic;Tomato;Pepper;Vine;Garlic;");
            ItemName.Add("Beef Goulash");
            NameComment.Add("A hearty warming dish. A simple and tasty recipe for a traditional beef goulash");
            Recipe.Add("Preheat the oven to 170C/gas 3. Heat 1 tablespoon of olive oil in a casserole dish or heavy-based saucepan. Sprinkle the steak with the flour and brown well, in batches, in the hot casserole dish. Set the browned meat aside. Add in the remaining olive oil. Add in the onion, garlic, green pepper and red pepper to the casserole dish and fry until softened, around 5 minutes. Return the beef to the pan with the tomato puree and paprika. Cook, stirring, for 2 minutes. Add in the tomatoes, white wine and beef stock. Cover and bake in the oven for 1 hour 30 minutes. Alternatively, cover and cook it on the hob on a gentle heat for about an hour, removing the lid after 45 minutes. Sprinkle over the parsley and season well with salt and freshly ground pepper. Stir in the soured cream and serve.");

            ItemImage.Add("/Assets/itemPicture/chedday-bay-biscuits-4-small-2.jpg");
            ItemIngredients.Add("Cheese;Milk;Garlic;Salt;Margarine;Biscuit,Vanilla;");
            ItemName.Add("Cheddar Biscuits");
            NameComment.Add("This is a very tasty, easy bread to make. It goes great with things like spaghetti and lasagna");
            Recipe.Add("In a large bowl beat ricotta cheese with an electric mixer on medium speed until smooth. Add eggs and vanilla; beat until combined. Add flour, granulated sugar, baking powder, and salt. Beat on low speed until just combined. Let batter stand for 30 minutes. Drop batter by well-rounded teaspoonfuls, four or five at a time, into deep hot fat (365 degrees F). Cook 2-1/2 to 3 minutes or until golden brown, turning once. Remove fritters with slotted spoon and drain on paper towels. Repeat with remaining batter. Cool completely. Shake fritters in a bag with powdered sugar, granulated sugar, or cinnamon/sugar mixture. Makes 3 dozen.");

            ItemImage.Add("/Assets/itemPicture/p5a0090.jpg");
            ItemIngredients.Add("Cheese;Milk;Garlic;Salt;Biscuit;Flour");
            ItemName.Add("Italian Donuts ");
            NameComment.Add("Ricotta cheese adds an Italian twist to these fried dough dessert bites");
            Recipe.Add("Bring a large pot of lightly salted water to a boil. Add ziti pasta, and cook until al dente, about 8 minutes; drain. In a large skillet, brown onion and ground beef over medium heat. Add spaghetti sauce, and simmer 15 minutes. Preheat the oven to 350 degrees F (175 degrees C). Butter a 9x13 inch baking dish. Layer as follows: 1/2 of the ziti, Provolone cheese, sour cream, 1/2 sauce mixture, remaining ziti, mozzarella cheese and remaining sauce mixture. Top with grated Parmesan cheese. Bake for 30 minutes in the preheated oven, or until cheeses are melted.");

            ItemImage.Add("/Assets/itemPicture/Cooking_Italian Marinated Vegetables_DSC_8200.jpg");
            ItemIngredients.Add("Salt;Leaf;Paprika;Potato;Carrot;Celery;Flour;Onion;Beef;");
            ItemName.Add("Italian Marinated Salad");
            NameComment.Add("Enjoy the bounty of fresh produce in this colourful salad!");
            Recipe.Add("Bring a large saucepan of water to a boil. Place a large bowl of ice water next to the stove. Cook carrot, cauliflower and green beans in the boiling water, one vegetable at a time, until just tender, 1 to 3 minutes. Transfer the vegetables to the ice water with a slotted spoon as they are done. Drain the vegetables and place in a large, shallow nonreactive bowl (see Tip). Add fennel, bell peppers, hot peppers, celery and onion. Combine cider vinegar, white vinegar, 1/2 cup water, sugar, salt, celery seed, basil and oregano in a nonreactive saucepan. Bring to a boil, then simmer for 2 minutes. Pour the hot liquid over the vegetables and gently stir to coat. Let cool to room temperature, stirring occasionally, then refrigerate until cold, at least 1 hour. The longer the vegetables marinate, the more flavorful the salad will be. To serve, strain the vegetables (reserving the pickling liquid). Return the vegetables and 3 tablespoons of the pickling liquid to the bowl. (Reserve the remaining pickling liquid to pickle more vegetables or to use in a salad dressing, if desired.) Add garlic, olives, parsley, dill and oil to the vegetables; toss to combine. Season with pepper.");

            ItemImage.Add("/Assets/itemPicture/Quick and Easy Beef Stew_Recipes_1007x545.jpg");
            ItemIngredients.Add("Onion;Beaf;Tomato;Vinegar;Pepper;Oil;");
            ItemName.Add("Beef Stew");
            NameComment.Add("A hearty, savory slow cooker stew with potatoes, carrots, celery, broth, herbs and spices. You won't be slow to say 'yum'!");
            Recipe.Add("Place meat in slow cooker. In a small bowl mix together the flour, salt, and pepper; pour over meat, and stir to coat meat with flour mixture. Stir in the garlic, bay leaf, paprika, Worcestershire sauce, onion, beef broth, potatoes, carrots, and celery. Cover, and cook on Low setting for 10 to 12 hours, or on High setting for 4 to 6 hours.");


            ItemImage.Add("/Assets/itemPicture/tomatillo-chicken.jpg");
            ItemIngredients.Add("Water;Garlic;Pepper;Onion;Bread;Olive Oil;Egg;Chicken;");
            ItemName.Add("Chicken Breasts with Tomatillo Salsa and Queso Fresco");
            NameComment.Add("Moist, well-seasoned chicken is topped with fantastically flavorful tomatillo salsa and queso fresco. If you're short on time you can use a bottled salsa verde, but we think this fresh salsa is worth the effort.");
            Recipe.Add("Preheat oven to 350°F. Salsa: Bring water to a boil. Add tomatillos, garlic, and chile; cook 7 minute Drain and rinse with cold water. Combine tomatillos, garlic, chile, 1/2 c cilantro, onion, lime juice, and 1/4 t salt in food processor or blender; pulse 4-5 times or until coarsely chopped. Set aside. Chicken: Place bread in food processor and pulse 10 times or until coarse crumbs measure 1 1/2 cup Arrange crumbs on a baking sheet; bake 3 min or until lightly browned. Cool completely. Pound chicken until 1/2 inch thick. Combine 1/2 t salt, cumin, and pepper; sprinkle evenly over chicken. Place crumbs in a shallow dish. Place egg in another. Dip chicken in egg and dredge in crumbs. Heat oil in large nonstick skillet over med-high. Add chicken and cook 4 minutes on each side or until done. Top chicken with salsa and sprinkle with queso fresco. Garnish with cilantro and lime.");

            ItemImage.Add("/Assets/itemPicture/Shrimp-Skewers.jpg");
            ItemIngredients.Add("Shrimp;Garlic;Pepper;Lemon Juice;Butter;Worcestershire Sauce;");
            ItemName.Add("New Orleans BBQ Shrimp");
            NameComment.Add("Don't break out your grill for this dish. Here in New Orleans, barbecued shrimp means sautéed shrimp in Worcestershire-spiked butter sauce. We serve these shrimp with heads and tails on, so you need to dig in to enjoy");
            Recipe.Add("In a large skillet combine shrimp, Worcestershire, lemon juice, black peppers, Creole seasoning, and garlic and cook over moderately high heat until shrimp turn pink, about 1 minute on each side. Reduce heat to moderate and stir in butter, a few cubes at a time, stirring constantly and adding more only when butter is melted. Remove skillet from heat. Place shrimp in a bowl and pour sauce over top. Serve with French bread for dipping.");

            ItemImage.Add("/Assets/itemPicture/chicken-breast-stuffed-with-jalapeno-poppers.jpg");
            ItemIngredients.Add("Bacon;Olive Oil;Pepper;Bread;Chesee;Bacon;");
            ItemName.Add("Cheesy Jalapeño Popper Baked Stuffed Chicken");
            NameComment.Add("What happens when you combine Skinny Baked Jalapeño Poppers with chicken?? Oh yeah baby!! Cheesy stuffed chicken breast stuffed with diced jalapeño, cream cheese, cheddar jack cheese, scallions and bacon!");
            Recipe.Add("Wash and dry chicken cutlets, season with salt and pepper. Preheat oven to 450°. Lightly spray a baking dish with non-stick spray. Combine cream cheese, cheddar, scallions, jalapeño and bacon crumbles in a medium bowl. Lay chicken cutlets on a working surface and spread 2 tbsp of cream cheese mixture on each cutlet. Loosely roll each one, secure the ends with toothpicks to prevent the cheese from oozing out. Place breadcrumbs in a bowl; in a second bowl combine olive oil, lime juice, salt and pepper. Dip chicken in lime-oil mixture, then in breadcrumbs and place seam side down on a baking dish. Repeat with the remaining chicken. When finished, lightly spray the top of the chicken with oil spray. Bake 22-25 minutes, serve immediately.");

            check();
        }
        private void check()
        {
            
            string process = (App.Current as App).NavigateText;
            while (process.Contains(";"))
            {
                string dummy = process.Substring(0, process.IndexOf(";"));
                //process = process.Substring(0, dummy.Length);
                process = process.Remove(0,dummy.Length+1);
                
                //process = process.Substring(dummy.Length+2,process.Length);
                //dummy.Remove(dummy.IndexOf(";"));
                selectedIngredients.Add(dummy);
                dummy = "";
            }
            if (process.Contains(";"))
            {
                process = process.Substring(0, process.IndexOf(";"));
                selectedIngredients.Add(process);
            }
            
            
        }
    }
}
