using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace ArticleTest
{
    class Program
    {
        static void Main(string[] args)
        {

            
            // First data source - Articles
            List<Article> Articles = new List<Article> ();
            Articles.Add (new Article (1, 1, "Jovic returns to Real Madrid!", "Real Madrid striker Luka Jovic has returned from the coronavirus lockdown with a foot fracture, the club has revealed."));

            Articles.Add (new Article (2, 1, "LaLiga cool talks over June 20 resumption", "LaLiga insist that there remains no set date for the 2019-20 season to resume. On Thursday, Leganes coach Javier Aguirre claimed that the campaign - which was halted in March - would return on June 20 and be wrapped up five weeks later by July 26."));
            Articles.Add (new Article (3, 2, "Tinubu: 'My aide died of coronavirus'", "Former Lagos Governor and APC chieftain, Asiwaju Bola Ahmed Tinubu, has disclosed that his late Chief Security Officer, Alhaji Lateef Raheem, who died on Friday, April 25, 2020, passed on from COVID-19 complications."));

            Articles.Add (new Article (4, 2, "Appeal Court affirms Ifeanyi Ubah as senator-elect", "Justice Bello Kawu had on Jan. 17, nullified Ubah's election on grounds that he allegedly used a forged National Examination Council, (NECO) certificate to contest the senatorial election held in Anambra South on Feb. 23, 2019."));

            // Second data source - Categories
            List<Category> Categories = new List<Category> ();
            Categories.Add (new Category (1, "Sports"));
            Categories.Add (new Category (2, "Politics"));
            Categories.Add (new Category (3, "Religion"));
            Categories.Add (new Category (4, "Entertainment"));


             Console.WriteLine("\n===================USING QUERY SYNTAX===================");
            var articlesBycategory = from c in Categories
                                     join a in Articles
                                     on c.Id equals a.CategoryId into eGroup
                                     select new
                                     {
                                         Category = c,
                                         Article = eGroup
                                     };
            
            
                foreach (var category in articlesBycategory)
                {
                    foreach (var article in category.Article)
                    {
                         Console.WriteLine($"\nTitle:\n {article.Title}\n\nCategory: {category.Category.CategoryName}\n\nBody:\n {article.Body}");
                    }
                    Console.WriteLine();
                }

                 Console.WriteLine("\n===================USING METHOD SYNTAX===================");

                 var articlesBycat = Categories
                                          .GroupJoin(Articles, c => c.Id, a => a.CategoryId,
                                          (category, article) => new
                                          {
                                              Category = category,
                                              Article = article
                                          });
           
                foreach (var category in articlesBycat)
                {
                    foreach (var article in category.Article)
                    {
                        Console.WriteLine($"\nTitle:\n {article.Title}\n\nCategory: {category.Category.CategoryName}\n\nBody:\n {article.Body}");
                    }
                    Console.WriteLine();
                }
        }
    }
}
