using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model1;
using DAL1.Interfaces.Repository;
using System.IO;

namespace UnitTestProject1
{
    [TestClass]
    public class CategoryTest
    {
        [TestMethod]
        public void AddCategory()
        {
            Categories category = new Categories();
            category.CategoryName = "Hrana";
            category.Description = " voce i povrce";
            category.Picture = GetPhoto(@"C:\Users\vlada.milosavljevic\Pictures\hrana.jpg");
            CategoryRepository rep = new CategoryRepository();
            int id = rep.AddCategory(category);
            Assert.IsNotNull(id > 0);
        }
        [TestMethod]
        public void GetCategoryById()
        {
            CategoryRepository categoryRepository = new CategoryRepository();
            Categories category = categoryRepository.GetCategoryById(5);

            Assert.IsNotNull(category);
        }

        [TestMethod]
        public void GetAllCategories()
        {
            CategoryRepository categoryRepository = new CategoryRepository();
            categoryRepository.GetAllCategories();
            Assert.IsNotNull(categoryRepository);
        }
        [TestMethod]
        public void UpdateCategory()
        {
            Categories category = new Categories();
            category.CategoryID = 10;
            category.CategoryName = "Hrana";
            category.Description = " voce i povrce1";
            category.Picture = GetPhoto(@"C:\Users\vlada.milosavljevic\Pictures\hrana.jpg");
            CategoryRepository rep = new CategoryRepository();
            int id = rep.UpdateCategory(category);
            Assert.IsNotNull(id > 0);
        }
        [TestMethod]
        public void DeleteCategory()
        {
            CategoryRepository categoryRepository = new CategoryRepository();
            categoryRepository.DeleteCategory(10);
            Assert.IsNotNull(categoryRepository);
        }


        private byte[] GetPhoto(string filePath)
        {
            FileStream stream = new FileStream(
                filePath, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);

            byte[] photo = reader.ReadBytes((int)stream.Length);

            reader.Close();
            stream.Close();

            return photo;
        }
    }
}
