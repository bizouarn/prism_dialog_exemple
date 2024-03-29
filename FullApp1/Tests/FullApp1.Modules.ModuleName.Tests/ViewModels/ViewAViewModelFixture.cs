﻿using FullApp1.Modules.ModuleName.ViewModels;
using FullApp1.Services.Interfaces;
using Moq;
using Prism.Regions;
using Xunit;

namespace FullApp1.Modules.ModuleName.Tests.ViewModels
{
    public class ViewAViewModelFixture
    {
        private Mock<IMessageService> _messageServiceMock;
        private Mock<IRegionManager> _regionManagerMock;
        private const string MessageServiceDefaultMessage = "Some Value";

        public ViewAViewModelFixture()
        {
            var messageService = new Mock<IMessageService>();
            messageService.Setup(x => x.GetMessage()).Returns(MessageServiceDefaultMessage);
            _messageServiceMock = messageService;

            _regionManagerMock = new Mock<IRegionManager>();
        }

        [Fact]
        public void MessagePropertyValueUpdated()
        {
            var vm = new ViewAViewModel(_regionManagerMock.Object, _messageServiceMock.Object);

            _messageServiceMock.Verify(x => x.GetMessage(), Times.Once);

            Assert.Equal(MessageServiceDefaultMessage, vm.Message);
        }

        [Fact]
        public void MessageINotifyPropertyChangedCalled()
        {
            var vm = new ViewAViewModel(_regionManagerMock.Object, _messageServiceMock.Object);
            Assert.PropertyChanged(vm, nameof(vm.Message), () => vm.Message = "Changed");
        }
    }
}