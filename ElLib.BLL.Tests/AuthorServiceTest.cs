using System;
using System.Collections.Generic;
using ElLib.BLL.Services.Implementations;
using ElLib.BLL.Services.Interfaces;
using ElLib.Common.Entities;
using ElLib.DAL.Repositories.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace ElLib.BLL.Tests
{
    [TestClass]
    public class AuthorServiceTest
    {
        IAuthorService service;

        Mock<IAuthorRepository> repository;

        [TestInitialize]
        public void Initialize()
        {
            repository = new Mock<IAuthorRepository>();

            service = new AuthorService(repository.Object);
        }

        [TestMethod]
        public void AuthorService_GetAll_ReturnedSuccessful()
        {
            //arrange
            repository.Setup(x => x.GetAll());

            //act
            service.GetAll();

            //assert
            repository.Verify(x => x.GetAll(), Times.Once);
        }

        [TestMethod]
        public void AuthorService_GetById_Successful()
        {
            //arrange
            int id = 15;

            repository.Setup(x => x.GetById(id)).Returns(new Author()
            {
                Id = 15,
                LastName = "Митрофанов",
                Name = "Евгений",
                MiddleName = "Харитонович",
                Email = "mitroevg@gmail.ru"
            });

            //act
            Author author = service.GetById(id);

            //assert
            Assert.AreEqual(author.Id, id);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AuthorService_GetByIdNull_ExceptionThrown()
        {
            //arrange
            int? id = null;

            //act
            service.GetById(id);

            //assert
            repository.Verify(x => x.GetById(id), Times.Never);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AuthorService_GetById0_ExceptionThrown()
        {
            //arrange
            int id = 0;

            //act
            service.GetById(id);

            //assert
            repository.Verify(x => x.GetById(id), Times.Never);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AuthorService_GetByIdMinus5_ExceptionThrown()
        {
            //arrange
            int id = -5;

            //act
            service.GetById(id);

            //assert
            repository.Verify(x => x.GetById(id), Times.Never);
        }

        [TestMethod]
        public void AuthorService_Successful()
        {
            //arrange
            Author author = new Author()
            {
                Id = 1,
                LastName = "Игоньков",
                Name = "Василий",
                MiddleName = "Михайлович",
                Email = "igorek@gmail.ru"
            };

            //act
            service.Create(author);

            //assert
            repository.Verify(x => x.Create(author), Times.Once);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AuthorService_CreateNull_ExceptionThrown()
        {
            //arrange
            Author author = null;
            //act
            service.Create(author);

            //assert
            repository.Verify(x => x.Update(author), Times.Never);
        }

        [TestMethod]
        public void AuthorService_Update_Successful()
        {
            //arrange
            Author author = new Author()
            {
                Id = 15,
                LastName = "Митрофанов",
                Name = "Евгений",
                MiddleName = "Харитонович",
                Email = "mitroevg@gmail.ru"
            };

            //act
            service.Update(author);

            //assert
            repository.Verify(x => x.Update(author), Times.Once);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AuthorService_UpdateNull_ExceptionThrown()
        {
            //arrange
            Author author = null;
            //act
            service.Update(author);

            //assert
            repository.Verify(x => x.Update(author), Times.Never);
        }

        [TestMethod]
        public void AuthorService_DeleteId_Successful()
        {
            //arrange
            int? id = 3;

            //act
            service.Delete(id);

            //assert
            repository.Verify(x => x.Delete(id), Times.Once);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AuthorService_DeleteNull_ExceptionThrown()
        {
            //arrange
            int? id = null;

            //act
            service.Delete(id);

            //assert
            repository.Verify(x => x.Delete(id), Times.Never);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AuthorService_Delete0_ExceptionThrown()
        {
            //arrange
            int id = 0;

            //act
            service.GetById(id);

            //assert
            repository.Verify(x => x.GetById(id), Times.Never);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AuthorServiceDeleteMinus2_ExceptionThrown()
        {
            //arrange
            int id = -2;

            //act
            service.GetById(id);

            //assert
            repository.Verify(x => x.GetById(id), Times.Never);
        }

        [TestMethod]
        public void AuthorService_Search_Successful()
        {
            //arrange
            string query = "Иг";

            IEnumerable<Author> list = new List<Author>()
            {
                new Author()
                {
                    Id = 1,
                    LastName = "Игоньков",
                    Name = "Василий",
                    MiddleName = "Михайлович",
                    Email = "igorek@gmail.ru"
                },

                new Author()
                {
                    Id = 4,
                    LastName = "Алеев",
                    Name = "Игорь",
                    MiddleName = "Витальевич",
                    Email = "mikhailS@gmail.ru"
                },

                new Author()
                {
                    Id = 8,
                    LastName = "Петрова",
                    Name = "Игнесса",
                    MiddleName = "Викторовна",
                    Email = "ignessa@gmail.ru"
                },
            };

            repository.Setup(x => x.GetByQuery(query)).Returns(list);

            //act
            IEnumerable<Author> responseList = service.Search(query);

            //assert
            Assert.AreEqual(list,responseList);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AuthorService_SearchEmpty_ExceptionThrown()
        {
            //arrange
            string query = null;

            //act
            service.Search(query);

            //assert
            repository.Verify(x => x.GetByQuery(query), Times.Never);
        }
    }
}
