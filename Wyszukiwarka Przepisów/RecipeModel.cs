﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyszukiwarka_Przepisów
{
    class RecipeModel
    {
        public string Id { get; private set; }
        public string Title { get; private set; }

        protected RecipeModel(string id, string title)
        {
            Id = id;
            Title = title;
        }

        protected static RecipeModel recipeModelFactory(string id, string title)
        {
            return new RecipeModel(id, title);
        }

        public string GetLink()
        {
            return "https://cookidoo.pl/recipes/recipe/pl/" + Id;
        }

        public Recipe toRecipe()
        {
            Debug.WriteLine(RecipeRepository.GetRepository().Count());
            return RecipeRepository.GetRepository().FindById(Id);
        }

        public override string ToString()
        {
            return Title;
        }
    }

}
