﻿using DevFreela.Application.Commands.CreateProject;
using DevFreela.Core.Entities;
using DevFreela.Core.Repositories;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace DevFreela.UnitTests.Application.Commands
{
    public class CreateProjectCommandTest
    {
        [Fact]
        public async Task InputDataIsOk_Executed_ReturnProjectId()
        {
            // Arrange
            var projectRepository = new Mock<IProjectRepository>();

            var createProjectCommand = new CreateProjectCommand
            {
                Title = "Titulo 1",
                Description = "Descrição 1",
                IdClient = 1,
                IdFreelancer = 1,
                TotalCost = 1000
            };

            var createProjectCommandHandler = new CreateProjectCommandHandler(projectRepository.Object);
            // Act

            var id = await createProjectCommandHandler.Handle(createProjectCommand, new CancellationToken());

            // Assert

            Assert.True(id >= 0);
            projectRepository.Verify(pr => pr.AddAsync(It.IsAny<Project>()), Times.Once);
        } 
    }
}
