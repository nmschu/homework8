﻿
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Homework8.Models
{
    public class PetContextInitializaer : DropCreateDatabaseIfModelChanges<PetContext>
    {
        protected override void Seed(PetContext context)
        {
            context.Pets.Add(
                new Pet()
                {
                    //Picture
                    Breed = "Labrador Retriever",
                    Price = 200,
                    DateRecieved = DateTime.Today,
                    Quantity = 3,
                    ShortDescription = "this is the short description",
                    Description = "this will be the long description"
                });
            context.Pets.Add(
                new Pet()
                {
                    //Picture
                    Breed = "Poodle",
                    Price = 10000,
                    DateRecieved = DateTime.Today,
                    Quantity = 2,
                    ShortDescription = "here is a short description",
                    Description = "here is the long description"
                });
            context.SaveChanges();
        }
    }
}